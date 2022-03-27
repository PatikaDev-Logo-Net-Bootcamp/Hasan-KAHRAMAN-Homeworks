USE [LogoDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_AddUserToUsers]    Script Date: 27.03.2022 21:29:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_AddUserToUsers] 
	@Name			NVARCHAR(100),
	@Email			NVARCHAR(100),
	@Phone			NVARCHAR(20),
	@Address		NVARCHAR(100),
	@CompanyId		INT

AS 
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO dbo.Users
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

