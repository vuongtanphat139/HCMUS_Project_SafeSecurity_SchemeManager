CONNECT QLCONGTY/DOAN;

ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

-- list table and user

CREATE OR REPLACE PROCEDURE LIST_TABLE
AS
    TABLECURSOR SYS_REFCURSOR;
BEGIN  
    OPEN TABLECURSOR FOR
    SELECT TABLE_NAME, owner
    FROM ALL_TABLES;
    --where TABLE_NAME = 'PHONGBAN';
    --WHERE OWNER = SYS_CONTEXT('USERENV','CURRENT_USER');
    
    DBMS_SQL.RETURN_RESULT(TABLECURSOR);
END;
/
--EXEC LIST_TABLE;
-- list table with para schemaname

CREATE OR REPLACE PROCEDURE qlcongty.LIST_TABLE_wSchemaName (schemaname in varchar)
AS
    TABLECURSOR SYS_REFCURSOR;
BEGIN  
    OPEN TABLECURSOR FOR
    SELECT TABLE_NAME
    FROM ALL_TABLES
    --where TABLE_NAME = 'PHONGBAN';
    WHERE OWNER = upper(schemaname);
    
    DBMS_SQL.RETURN_RESULT(TABLECURSOR);
END;
/

--exec qlcongty.LIST_TABLE_wSchemaName ('holiday');

/
-- list schema have table

CREATE OR REPLACE PROCEDURE qlcongty.LIST_Schema_Having_Table 
AS
    TABLECURSOR SYS_REFCURSOR;
BEGIN  
    OPEN TABLECURSOR FOR
    SELECT distinct owner
    FROM ALL_TABLES;
    --where TABLE_NAME = 'PHONGBAN';
    --WHERE OWNER = upper(schemaname);
    
    DBMS_SQL.RETURN_RESULT(TABLECURSOR);
END;
/

--exec list_schema_having_table;
--
/
-- grant and revoke

CREATE OR REPLACE FUNCTION CHECK_UOR(
    UORNAME IN VARCHAR2
)
RETURN INT
AUTHID CURRENT_USER
AS
    COUNTUSER INT;
    COUNTROLE INT;
BEGIN
    SELECT COUNT(*) INTO COUNTUSER FROM ALL_USERS WHERE USERNAME = UORNAME;
    SELECT COUNT(*) INTO COUNTROLE FROM DBA_ROLES WHERE ROLE = UORNAME;
    IF(COUNTUSER != 0 OR COUNTROLE != 0) THEN
        RETURN 1;
    END IF;
    RETURN 0;
END;
/
-- check whether UoR is granted SID
create or replace function check_UoR_granted(
    UoRname in varchar,
    tableName in varchar,
    schemaname in varchar,
    priv in varchar)

return int 
AUTHID CURRENT_USER
as 
    countrow int;
begin
    if(upper(priv) != 'UPDATE') then
    begin
        select count(*) into countrow 
        from all_tab_privs 
        where grantee= upper(Uorname)
            and
            table_schema = upper(schemaname)
            and
            table_name = upper(tablename)
            and
            privilege = upper (priv);
    end ;
    else 
        begin
            select count(*) into countrow 
            from all_col_privs 
            where grantee= upper(Uorname)
                and
                table_schema = upper(schemaname)
                and
                table_name = upper(tablename)
                and
                privilege = 'UPDATE';
            --return countrow;
            
        end;
    end if;
    if (countrow>0) then
            return 1;
        end if;
        return 0;
end;
/

/
CREATE OR REPLACE PROCEDURE GRANTROLE4USER(
    USERID IN VARCHAR2,
    ROLE_NAME IN VARCHAR2)

IS
    RESULT_STR VARCHAR2(300);

BEGIN
    RESULT_STR:= 'GRANT ' || ROLE_NAME || ' TO ' || USERID;
    EXECUTE IMMEDIATE RESULT_STR; 
END;
/

CREATE OR REPLACE PROCEDURE GRANTPRI4USER(
    UORNAME IN VARCHAR2, 
    TABLENAME IN VARCHAR2,
    SCHEMANAME in varchar,
    PRIV IN VARCHAR2,
    LISTCOLUMN IN varchar,
    IS_WGO in varchar 
) 
AUTHID CURRENT_USER
IS
    L_COLUMN VARCHAR2(4000);
    RESULT_STR VARCHAR2(300);
    TABLE_NAME  VARCHAR2(50);
    COUNTUOR INT;
    countrow int;
BEGIN
--    FOR VAL IN 1..LISTCOLUMN.COUNT LOOP
--        L_COLUMN := L_COLUMN || LISTCOLUMN(VAL) || ',';
--    END LOOP;
--    L_COLUMN := RTRIM(L_COLUMN, ',');
    
    TABLE_NAME:=TABLENAME;
    if (upper(priv) = 'SELECT') then
    TABLE_NAME:=TABLENAME || '_' || UORNAME;
    end if;
    
 
    SELECT CHECK_UOR(UORNAME) INTO COUNTUOR FROM DUAL;
   
    select check_UoR_granted(uorname, table_name, schemaname, priv) into countrow from dual;
    if (countrow != 0) then
    --revoke grant option for select on objext from user cascade;
--         RESULT_STR:= 'REVOKE  grant option for '||priv|| ' ON ' || schemaname || '.' || TABLE_NAME || ' FROM ' || UORNAME || ' cascade ' ;
--        EXECUTE IMMEDIATE RESULT_STR;
        RESULT_STR:= 'REVOKE  '||priv|| ' ON ' || schemaname || '.' || TABLE_NAME || ' FROM ' || UORNAME;
        EXECUTE IMMEDIATE RESULT_STR;
    end if;
    IF(COUNTUOR != 0 ) THEN
        BEGIN
            IF(upper(priv) = 'SELECT') THEN
                BEGIN
                    
                    RESULT_STR := 'CREATE OR REPLACE VIEW ' || schemaname || '.'  || TABLE_NAME ||  ' AS '|| ' SELECT ' || listcolumn || ' FROM ' || schemaname || '.' || TABLENAME;
                    EXECUTE IMMEDIATE RESULT_STR;
                    RESULT_STR:= 'GRANT SELECT ON '   || schemaname || '.' || TABLE_NAME ||  ' TO ' ||UORNAME;--schemaname || '.'
                END;
            ELSIF (upper(PRIV) = 'UPDATE') THEN
                BEGIN
                -- can bo sung check co tung grant chua truoc khi revoke
                 select check_UoR_granted(uorname, tablename, schemaname, priv) into countrow from dual;
                    if (countrow != 0) then
                        RESULT_STR:= 'REVOKE  UPDATE'|| ' ON ' || schemaname || '.' || TABLENAME || ' FROM ' || UORNAME;
                        EXECUTE IMMEDIATE RESULT_STR;
                    end if;
                    RESULT_STR:= 'GRANT UPDATE'||'(' || LISTCOLUMN || ') ON ' || schemaname || '.' || TABLENAME || ' TO ' || UORNAME;
                END;
            ELSE 
                BEGIN
                    RESULT_STR:= 'GRANT ' || PRIV || ' ON ' || schemaname || '.' || TABLE_NAME || ' TO ' || UORNAME;
                END;
            END IF;
        
        END;
        IF(IS_WGO = 'YES') THEN
                RESULT_STR := RESULT_STR ||' WITH GRANT OPTION';
            END IF;
    ELSE
        BEGIN
            RAISE_APPLICATION_ERROR(-20000,N'USER KHÔNG TỒN TẠI'); 
        END;
    END IF;
       EXECUTE IMMEDIATE RESULT_STR;
END;
/
CREATE OR REPLACE PROCEDURE GRANTROLE4USER(
    USERID IN VARCHAR2,
    ROLE_NAME IN VARCHAR2) 
IS
    RESULT_STR VARCHAR2(300);
BEGIN
    RESULT_STR:= 'GRANT ' || ROLE_NAME || ' TO ' || USERID;
    EXECUTE IMMEDIATE RESULT_STR; 
END;
/

CREATE OR REPLACE PROCEDURE REVOKEROLEFROMUSER(
    USERID IN VARCHAR2,
    ROLE_NAME IN VARCHAR2) 
IS
    RESULT_STR VARCHAR2(300);
    countrow in int;
BEGIN
    
    RESULT_STR:= 'REVOKE ' || upper(ROLE_NAME) || ' FROM ' || upper(USERID);
    EXECUTE IMMEDIATE RESULT_STR; 
END;
/
exec revokerolefromuser ('nv000', 'taichinh')
CREATE OR REPLACE PROCEDURE GRANTPRI4ROLE(
    UORNAME IN VARCHAR2, 
    TABLENAME IN VARCHAR2,
    SCHEMANAME in varchar,
    PRIV IN VARCHAR2,
    LISTCOLUMN IN varchar
) 
IS
    L_COLUMN VARCHAR2(4000);
    RESULT_STR VARCHAR2(300);
    TABLE_NAME  VARCHAR2(50);
    COUNTUOR INT;
    countrow int;
BEGIN
--    FOR VAL IN 1..LISTCOLUMN.COUNT LOOP
--        L_COLUMN := L_COLUMN || LISTCOLUMN(VAL) || ',';
--    END LOOP;
--    L_COLUMN := RTRIM(L_COLUMN, ',');
    
    TABLE_NAME:=TABLENAME;
    if (upper(priv) = 'SELECT') then
    TABLE_NAME:=TABLENAME || '_' || UORNAME;
    end if;
    
 
    SELECT CHECK_UOR(UORNAME) INTO COUNTUOR FROM DUAL;
    select check_UoR_granted(uorname, tablename, schemaname, priv) into countrow from dual;
   
    IF(COUNTUOR != 0 ) THEN
        BEGIN
            IF(upper(priv) = 'SELECT') THEN
                BEGIN
                    RESULT_STR := 'CREATE OR REPLACE VIEW ' || schemaname || '.'  || TABLE_NAME ||  ' AS '|| ' SELECT ' || listcolumn || ' FROM ' || schemaname || '.' || TABLENAME;
                    EXECUTE IMMEDIATE RESULT_STR;
                    RESULT_STR:= 'GRANT SELECT ON '   || schemaname || '.' || TABLE_NAME ||  ' TO ' ||UORNAME;--schemaname || '.'
                END;
            ELSIF (upper(PRIV) = 'UPDATE') THEN
                BEGIN
                -- can bo sung check co tung grant chua truoc khi revoke
                 select check_UoR_granted(uorname, tablename, schemaname, priv) into countrow from dual;
                    if (countrow != 0) then
                        RESULT_STR:= 'REVOKE  UPDATE'|| ' ON ' || schemaname || '.' || TABLE_NAME || ' FROM ' || UORNAME;
                        EXECUTE IMMEDIATE RESULT_STR;
                    end if;
                    RESULT_STR:= 'GRANT UPDATE'||'(' || LISTCOLUMN || ') ON ' || schemaname || '.' || TABLE_NAME || ' TO ' || UORNAME;
                END;
            ELSE 
                BEGIN
                    RESULT_STR:= 'GRANT ' || PRIV || ' ON ' || schemaname || '.' || TABLE_NAME || ' TO ' || UORNAME;
                END;
            END IF;
        
        END;
        
    ELSE
        BEGIN
            RAISE_APPLICATION_ERROR(-20000,N'USER KHÔNG TỒN TẠI'); 
        END;
    END IF;
       EXECUTE IMMEDIATE RESULT_STR;
END;
/

/


CREATE OR REPLACE PROCEDURE ROVOKEPRIVFROMROLE(
    UORNAME IN VARCHAR2, 
    TABLENAME IN VARCHAR2,
    SCHEMANAME IN VARCHAR,
    PRIV IN VARCHAR2
    --LISTCOLUMN IN SYS.ODCIVARCHAR2LIST
) 
IS
    L_COLUMN VARCHAR2(4000);
    RESULT_STR VARCHAR2(300);
    TABLE_NAME  VARCHAR2(50);
    COUNTUOR INT;
    countrow int;
BEGIN
--    FOR VAL IN 1..LISTCOLUMN.COUNT LOOP
--        L_COLUMN := L_COLUMN || LISTCOLUMN(VAL) || ',';
--    END LOOP;
--    L_COLUMN := RTRIM(L_COLUMN, ',');
    
    table_name:=  TABLENAME;
    if (upper(priv)= 'SELECT') then 
        table_name:=  TABLENAME || '_' || uorname;
    end if;
    SELECT CHECK_UOR(upper(UORNAME)) INTO COUNTUOR FROM DUAL;
    select check_UoR_granted(uorname, table_name, schemaname, priv) into countrow from dual;
                
    IF(COUNTUOR != 0 AND COUNTROW != 0) THEN
        BEGIN
            RESULT_STR:= 'REVOKE  '|| priv|| ' ON ' || SCHEMANAME||'.'|| TABLE_NAME || ' FROM ' || UORNAME;
        END;
    ELSE
        BEGIN
            RAISE_APPLICATION_ERROR(-20000,N'USER KHÔNG TỒN TẠI'); 
            return;
        END;
    END IF;
    EXECUTE IMMEDIATE RESULT_STR;
END;
/

-- xem ds

CREATE OR REPLACE PROCEDURE LIST_USER
AS
RESULTS SYS_REFCURSOR;
BEGIN
    OPEN RESULTS FOR
    SELECT USERNAME FROM DBA_USERS
    WHERE ACCOUNT_STATUS != 'LOCKED';
    --AND USERNAME NOT IN ('SYSRAC','SYSTEM');
    DBMS_SQL.RETURN_RESULT(RESULTS);
END;
/
--EXEC LIST_USER;

-- Xem danh sach ROLE
CREATE OR REPLACE PROCEDURE LIST_ROLE
AS
RESULTS SYS_REFCURSOR;
BEGIN 
    OPEN RESULTS FOR
    SELECT distinct RL.GRANTED_ROLE
    FROM DBA_ROLES R
    JOIN DBA_ROLE_PRIVS RL
    ON R.ROLE = RL.GRANTED_ROLE;
    --WHERE RL.GRANTEE = 'QLCONGTY'
    --AND RL.GRANTED_ROLE NOT IN ('DBA');
    DBMS_SQL.RETURN_RESULT(RESULTS);
END;
/
--EXEC LIST_ROLE;
-- list user of role

-- Xem danh sach ROLE
CREATE OR REPLACE PROCEDURE LIST_USER_OF_ROLE (rolename varchar)
AS
RESULTS SYS_REFCURSOR;
BEGIN 
    OPEN RESULTS FOR
    SELECT rl.grantee
    FROM DBA_ROLES R
    JOIN DBA_ROLE_PRIVS RL
    ON R.ROLE = RL.GRANTED_ROLE
    WHERE RL.GRANTED_ROLE = upper(rolename);
    --AND RL.GRANTED_ROLE NOT IN ('DBA');
    DBMS_SQL.RETURN_RESULT(RESULTS);
END;
/
--exec list_user_of_role ('CONNECT');
--exec LIST_NOT_ROLE_OF_USER('nv000')
--
CREATE OR REPLACE PROCEDURE LIST_ROLE_OF_USER (rolename varchar)
AS
RESULTS SYS_REFCURSOR;
BEGIN 
    OPEN RESULTS FOR
    SELECT R.ROLE
    FROM DBA_ROLES R
    JOIN DBA_ROLE_PRIVS RL
    ON R.ROLE = RL.GRANTED_ROLE
    WHERE RL.GRANTEE = upper(rolename);
    --AND RL.GRANTED_ROLE NOT IN ('DBA');
    DBMS_SQL.RETURN_RESULT(RESULTS);
END;
/
-- return select, insert and delete priv of one role, on a schema, on a table
create or replace procedure usp_SID_Priv_Of_RoU (RoUname varchar, tablename varchar, schemaname varchar)
AUTHID CURRENT_USER
as
results sys_refcursor;
begin
    open results for 
    select privilege, grantable, type from sys.all_tab_privs
    where
    grantee= upper(rouname)
     and
    table_schema= upper(schemaname)
    and
    (
        (table_name = upper(tablename)
        and
        privilege!= 'SELECT'
        )
    or
        (table_name = upper(tablename||'_'||rouname)
        and
        privilege= 'SELECT'
        )
    );
 
    DBMS_SQL.RETURN_RESULT(RESULTS);
end;
/


CREATE OR REPLACE PROCEDURE LIST_NOT_ROLE_OF_USER (rolename varchar)
AS
RESULTS SYS_REFCURSOR;
BEGIN 
    OPEN RESULTS FOR
    SELECT R.ROLE
    FROM DBA_ROLES R
    JOIN DBA_ROLE_PRIVS RL
    ON R.ROLE = RL.GRANTED_ROLE
    WHERE RL.GRANTEE != upper(rolename);
    --AND RL.GRANTED_ROLE NOT IN ('DBA');
    DBMS_SQL.RETURN_RESULT(RESULTS);
END;
/
create or replace procedure usp_SID_Priv_Of_USER (RoUname varchar, tablename varchar, schemaname varchar)
AUTHID CURRENT_USER
as
results sys_refcursor;
begin
    open results for 
    select privilege, grantable, type from DBA_TAB_PRIVS
    where
    grantee= upper(rouname)
--     and
--    table_schema= upper(schemaname)
    and
    (
        (table_name = upper(tablename)
        and
        privilege!= 'SELECT'
        )
    or
        (table_name = upper(tablename||'_'||rouname)
        and
        privilege= 'SELECT'
        )
    );
 
    DBMS_SQL.RETURN_RESULT(RESULTS);
end;
/

create or replace procedure qlcongty.ColsOfTable (tablename in varchar, schemaname in varchar)
as
results sys_refcursor;
begin
    open results for 
    select 
           col.column_name --as column_name
    from sys.all_tab_columns col
    inner join sys.all_tables t on col.owner = t.owner 
                                  and col.table_name = t.table_name
    where
    col.owner = upper(schemaname)
    and 
    col.table_name = upper(tablename);
    --order by col.column_id;
    dbms_sql.return_result(results);

end;
--exec colsoftable('nhanvien_nhanvien', 'qlcongty');
/

-- list view coloumn
--select * from dba_tab_columns;
/
create or replace procedure qlcongty.ColsOfView ( UoRname in varchar, tablename in varchar,schemaname in varchar)
AUTHID CURRENT_USER
as
results sys_refcursor;
begin
    open results for 
    select 
           col.column_name --as column_name
    from sys.ALL_tab_columns col
    inner join sys.all_views v on col.owner = v.owner 
                              and col.table_name = v.view_name
    where
     col.owner = upper(schemaname)
   -- col.owner = upper(schemaname)
    and 
    col.table_name = upper(tablename||'_'||UoRname);
    --order by col.column_id;
    dbms_sql.return_result(results);

end;
/
--SELECT * FROM DBA_views;
--SELECT * FROM dba_tab_columns;
/
create or replace procedure qlcongty.ColsOfView_USER ( UoRname in varchar, tablename in varchar,schemaname in varchar)
AUTHID CURRENT_USER
as
results sys_refcursor;
begin
    open results for 
    select 
         col.column_name 
    from dba_tab_columns col
    inner join DBA_views v on col.owner = v.owner 
                              and col.table_name = v.view_name
    where
     col.owner = upper(schemaname)
   -- col.owner = upper(schemaname)
    and 
    col.table_name = upper(tablename||'_'||UoRname);
--    --order by col.column_id;
    dbms_sql.return_result(results);

end;
/
--select * from holiday.lab3_nhanvien;
--/
--select * from dba_col_privs where grantee='NV000';
--grant update(manv, mapb) on holiday.lab3_nhanvien to nv000;
-- list view coloumn

create or replace procedure qlcongty.ColsOfUpdate ( UoRname in varchar, tablename in varchar,schemaname in varchar)
as
results sys_refcursor;
begin
    open results for 
    select 
           col.column_name, col.privilege, col.grantable --as column_name
    from sys.all_col_privs col

    where
     col.table_schema = upper(schemaname)
   -- col.owner = upper(schemaname)
    and 
    col.table_name = upper(tablename)
    and
    grantee = upper(UoRname);
    --order by col.column_id;
    dbms_sql.return_result(results);

end;

/
--exec ColsOfUpdate_User ('nv000', 'LAB3_tongHOP', 'holiday');
--exec ColsOfView_USER ('nv000', 'LAB3_NHANVIEN', 'holiday');

create or replace procedure qlcongty.ColsOfUpdate_User ( UoRname in varchar, tablename in varchar,schemaname in varchar)
as
results sys_refcursor;
begin
    open results for 
    select 
           col.column_name, col.privilege, col.grantable --as column_name
    from sys.dba_col_privs col

    where
--     col.table_schema = upper(schemaname)
--   -- col.owner = upper(schemaname)
--    and 
    col.table_name = upper(tablename)
    and
    grantee = upper(UoRname);
    --order by col.column_id;
    dbms_sql.return_result(results);

end;
