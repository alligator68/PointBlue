/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [_user]
      ,[_type]
      ,[_withdraw]
      ,[_date]
  FROM [bank].[dbo].[tblmoney]