CONNECT QLCONGTY/DOAN;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
--SELECT ON NHANVIEN
--NHÂN SỰ
CREATE OR REPLACE VIEW QLCONGTY.NS_NHANVIEN AS 
    SELECT * FROM QLCONGTY.NHANVIEN WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')
    UNION
    SELECT MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, NULL AS LUONG, NULL AS PHUCAP , VAITRO, MANQL, PHG FROM QLCONGTY.NHANVIEN;
/
--TÀI CHÍNH
--SELECT * FROM QLCONGTY.NHANVIEN

--NHÂN VIÊN VÀ TRƯỞNG ĐỀ ÁN
CREATE OR REPLACE VIEW QLCONGTY.V_NHANVIEN AS 
    SELECT * FROM QLCONGTY.NHANVIEN WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
/
--TRƯỞNG PHÒNG
CREATE OR REPLACE VIEW QLCONGTY.TP_NHANVIEN AS 
    SELECT * FROM QLCONGTY.NHANVIEN WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')
    UNION
    SELECT MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, NULL AS LUONG, NULL AS PHUCAP , VAITRO, MANQL, PHG FROM QLCONGTY.NHANVIEN
    WHERE PHG IN (SELECT PHG FROM QLCONGTY.NHANVIEN WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER'))
/
--QUẢN LÝ
CREATE OR REPLACE VIEW QLCONGTY.QL_NHANVIEN AS 
    SELECT * FROM QLCONGTY.NHANVIEN WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER')
    UNION
    SELECT MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, NULL AS LUONG, NULL AS PHUCAP , VAITRO, MANQL, PHG FROM QLCONGTY.NHANVIEN WHERE MANQL = SYS_CONTEXT('USERENV', 'SESSION_USER');