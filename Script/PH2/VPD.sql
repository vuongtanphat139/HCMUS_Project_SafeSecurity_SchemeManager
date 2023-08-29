CONNECT QLCONGTY/DOAN;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

--NHANVIEN
--Chính sách Update dành cho nhân viên Nhân sự và Tài chính
/
BEGIN
  DBMS_RLS.DROP_POLICY (object_schema     => 'QLCONGTY',
                        object_name       => 'NHANVIEN',
                        policy_name       => 'UID_NHANVIEN');
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLCONGTY',
        object_name     => 'NHANVIEN',
        policy_name     => 'UID_NHANVIEN',
        function_schema => 'QLCONGTY',
        policy_function => 'CHANGENHANVIEN',
        statement_types => 'INSERT,UPDATE',
        update_check    => true
        );
END;
/
CREATE OR REPLACE FUNCTION QLCONGTY.CHANGENHANVIEN(
    OBJ_SCHEMA IN VARCHAR2,
    OBJ_NAME IN VARCHAR2
)
RETURN VARCHAR2
AS
    IDEMP VARCHAR2(20);
BEGIN
    IDEMP := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF (IDEMP LIKE 'NS%') THEN RETURN 'LUONG IS NULL AND PHUCAP IS NULL';
    ELSIF (IDEMP LIKE 'TC%') THEN RETURN '1=1';
    ELSE RETURN '1=1';
    END IF;
END;
/
--PHANCONG
--Chính sách select, update, insert, delete dành cho toàn bộ nhân viên
BEGIN
  DBMS_RLS.DROP_POLICY (object_schema     => 'QLCONGTY',
                        object_name       => 'PHANCONG',
                        policy_name       => 'QLPHANCONG');
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLCONGTY',
        object_name     => 'PHANCONG',
        policy_name     => 'QLPHANCONG',
        function_schema => 'QLCONGTY',
        policy_function => 'MANAGEPHANCONG',
        statement_types => 'INSERT,UPDATE,DELETE,SELECT',
        update_check    => true
        );
END;
/
CREATE OR REPLACE FUNCTION QLCONGTY.MANAGEPHANCONG(
    OBJ_SCHEMA IN VARCHAR2,
    OBJ_NAME IN VARCHAR2
)
RETURN VARCHAR2
AS
    IDEMP CHAR(5);
BEGIN
    IDEMP := SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF(IDEMP LIKE 'QL%') THEN RETURN 'MANV = ''' || IDEMP || ''' OR MANV IN (SELECT MANV FROM QLCONGTY.NHANVIEN WHERE MANV = ''' || IDEMP || ''')';
    ELSIF(IDEMP LIKE 'TP%') THEN RETURN 'MANV = ''' || IDEMP || ''' OR MANV IN (SELECT MANV FROM QLCONGTY.NHANVIEN WHERE PHG IN (SELECT MAPB FROM QLCONGTY.PHONGBAN WHERE TRPHG = ''' || IDEMP || '''))';
    ELSIF(IDEMP LIKE 'TC%') THEN RETURN '1=1';
    ELSE RETURN 'MANV = ''' || IDEMP || '''';
    END IF;
END;