SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Daniel Vuust
-- Create date: 15-06-2022
-- Description:	Creates a new record of Airport. 
-- =============================================
CREATE PROCEDURE CreateNewAirport
	-- Add the parameters for the stored procedure here
	@IATA VarChar(3), 
	@AirportName VarChar(256), 
	@AirportAddress VarChar(256)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if DATALENGTH(@IATA) != 3
	BEGIN
		return 0;
	END
	INSERT INTO AirPort (IATA, AirportName, AirportAddress) VALUES (@IATA, @AirportName, @AirportAddress);
END
GO
