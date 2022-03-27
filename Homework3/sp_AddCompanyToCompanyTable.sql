USE [LogoDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_AddCompanyToCompanyTable]    Script Date: 27.03.2022 20:52:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_AddCompanyToCompanyTable] 
	@Name			NVARCHAR(100),
	@Country		NVARCHAR(100),
	@City			NVARCHAR(100),
	@Address		NVARCHAR(100)
AS 
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO dbo.Company
          (                    
            Name,
            Country,
            City,
            Address) 
     VALUES 
          ( 
            @Name,
            @Country,
            @City,
            @Address) 

END 


GO

