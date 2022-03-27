USE [LogoDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_AddUserToUserTable]    Script Date: 27.03.2022 20:51:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_AddUserToUserTable] 
	@Name			NVARCHAR(100),
	@Email			NVARCHAR(100),
	@Phone			NVARCHAR(20),
	@Address		NVARCHAR(100),
	@CompanyId		INT

AS 
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO dbo.[User]
          (                    
            Name,
            Email,
            Phone,
            Address,
			CompanyId) 
     VALUES 
          ( 
            @Name,
            @Email,
            @Phone,
            @Address,
			@CompanyId) 

END 


GO

