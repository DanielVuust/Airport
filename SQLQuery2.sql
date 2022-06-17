SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Daniel Vuust
-- Create date: 15-06-2022
-- Description:	Creates a new record of Company
-- =============================================
CREATE PROCEDURE CreateNewCompany
	-- Add the parameters for the stored procedure here
	@CompanyName Varchar(256)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Company (CompanyName) VALUES (@CompanyName);
END
GO
