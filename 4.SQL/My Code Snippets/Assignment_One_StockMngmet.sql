/****** Script for SelectTopNRows command from SSMS  ******/
CREATE TABLE SalesDetails (
SID int,
ProductId int,
SalesDate varchar(100),
SalesQty int
PRIMARY KEY (SID)
);

CREATE TABLE PurchaseDetails (
PID int,
ProductId int,
PurchaseDate varchar(100),
PurchaseQty int
PRIMARY KEY (PID)
);

CREATE TABLE ProductStockDetails (
ID int,
ProductId int,
StockQty int,
PRIMARY KEY (ID)
);

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [SID]
      ,[ProductId]
      ,[SalesDate]
      ,[SalesQty]
  FROM [INVENTORY_MANAGEMENT].[dbo].[SalesDetails];

  /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [PID]
      ,[ProductId]
      ,[PurchaseDate]
      ,[PurchaseQty]
  FROM [INVENTORY_MANAGEMENT].[dbo].[PurchaseDetails];

  /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[ProductId]
      ,[StockQty]
  FROM [INVENTORY_MANAGEMENT].[dbo].[ProductStockDetails]

INSERT INTO [dbo].[SalesDetails] values(1, '02/14/2023', 5);
INSERT INTO [dbo].[SalesDetails] values(3, '02/15/2023', 8);
INSERT INTO [dbo].[SalesDetails] values(5, '02/16/2023', 9);

INSERT INTO [dbo].[PurchaseDetails] values(1, '02/14/2023', 3);
INSERT INTO [dbo].[PurchaseDetails] values(3, '02/15/2023', 4);
INSERT INTO [dbo].[PurchaseDetails] values(5, '02/16/2023', 5);

DELETE FROM [dbo].[PurchaseDetails]
WHERE [dbo].[PurchaseDetails].[PurchaseId] = 8

INSERT INTO [dbo].[ProductStockDetails] values(1, 5);
INSERT INTO [dbo].[ProductStockDetails] values(3, 12);
INSERT INTO [dbo].[ProductStockDetails] values(5, 21);

/* Create Stored Procedures **/
CREATE PROC GetPurchaseDetails
as
begin
	SELECT [PID], [ProductId], [PurchaseDate], [PurchaseQty]
	FROM [dbo].[PurchaseDetails]
end

/* Create Stored Procedures **/
CREATE PROC GetSalesDetails
as
begin
	SELECT [ProductID], [PName] FROM [dbo].[Products]
	SELECT [SalesID], [ProductId],[SalesDate],[SalesQty]
	FROM [dbo].[SalesDetails]
end

/* Create Stored Procedures **/
CREATE PROC GetStockDetails
as
begin
	SELECT  
		Purchase.[ProductID] as ProductId, 
		Products.[PName] as ProductName,
		CASE
			WHEN Sales.[SalesQty] > 0 THEN Purchase.[PurchaseQty] - Sales.[SalesQty]
			ELSE Purchase.[PurchaseQty]
			END AS Quantity
		-- Purchase.[PurchaseQty] - Sales.[SalesQty] as Quantity
	FROM 
		[dbo].[PurchaseDetails] Purchase left outer join [dbo].[SalesDetails] Sales
	ON Purchase.[ProductId] = Sales.[ProductID]
		inner join [dbo].[Products] Products
	ON Purchase.[ProductID] = Products.[ProductID]
end
