SELECT
	EMP1.EMPName [Employee Name],
	EMP2.EMPName [Manager Name]
FROM
[dbo].[EmployeeManagers] EMP1 INNER JOIN [dbo].[EmployeeManagers] EMP2
on EMP1.EmpMngrID = EMP2.EmpID

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EmpID]
      ,[EmpName]
      ,[EmpMngrID]
  FROM [INVENTORY_MANAGEMENT].[dbo].[EmployeeManagers]
