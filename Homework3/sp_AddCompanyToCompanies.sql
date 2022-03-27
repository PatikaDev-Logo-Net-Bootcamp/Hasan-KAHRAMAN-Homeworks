USE [LogoDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_AddCompanyToCompanies]    Script Date: 27.03.2022 21:29:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_AddCompanyToCompanies] 
	@Name			NVARCHAR(100),
	@Country		NVARCHAR(100),
	@City			NVARCHAR(100),
	@Address		NVARCHAR(100)
AS 
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO dbo.Companies
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

