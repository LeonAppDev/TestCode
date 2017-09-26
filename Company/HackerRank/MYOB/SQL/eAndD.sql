/****** Script for SelectTopNRows command from SSMS  ******/
SELECT DISTINCT dp.NAME,
     (
     select count(ID) from EMPLOYEE
     where DEPT_ID = dp.DEPT_ID
     ) as number
  FROM DEPARTMENT as dp
  left join EMPLOYEE as emp
  on dp.DEPT_ID= emp.DEPT_ID
  Order by number DESC, Name
