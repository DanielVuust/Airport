DROP Table Airport_Route;DROP TABLE Plane;DROP TABLE Airport;DROP TABLE Route;DROP TABLE Company;

CREATE TABLE Company
(
	CompanyId int IDENTITY(1,1) primary key ,
	CompanyName Varchar(256) NOT NULL
);
CREATE TABLE Route
(
	RouteId int IDENTITY(1,1) primary key,
	Company_CompanyId int,
	FOREIGN KEY (Company_CompanyId) REFERENCES Company(CompanyId)
);
CREATE TABLE AirPort
(
	IATA VARCHAR(3) PRIMARY KEY,
	AirportName VARCHAR(256) NOT NULL,
	AirportAddress VARCHAR(256) NOT NULL,
	CONSTRAINT CH_IATA CHECK (DATALENGTH(IATA) = 3 AND (upper(IATA) = IATA collate Latin1_General_BIN2))
);
CREATE TABLE Plane
(
	SerialNum VARCHAR(256) PRIMARY KEY,
	Company_CompanyId int NOT NULL,
	Route_RouteId int,
	Airport_IATA VARCHAR(3),
	FOREIGN KEY (Company_CompanyId) REFERENCES Company(CompanyId),
	FOREIGN KEY (Route_RouteId) REFERENCES Route(RouteId),
	FOREIGN KEY (Airport_IATA) REFERENCES Airport(IATA)
);
CREATE TABLE Airport_Route
(
	Airport_StartIATA VARCHAR(3) NOT NULL,
	Airport_EndIATA VARCHAR(3) NOT NULL,
	Route_RouteId INT NOT NULL,
	FOREIGN KEY (Route_RouteId) REFERENCES Route(RouteId),
	FOREIGN KEY (Airport_StartIATA) REFERENCES Airport(IATA),
	FOREIGN KEY (Airport_EndIATA) REFERENCES Airport(IATA)

);

INSERT INTO AirPort (IATA, AirportName, AirportAddress) VALUES ('TES', 'Name', 'Address')

EXEC CreateNewCompany @CompanyName = 'Test';
EXEC CreateNewAirport @IATA = '123', @AirportName = 'TestName2', @AirportAddress = 'TestAddress2';
EXEC CreateRouteAndAssignOwner @CompanyId = 1, @RouteStartIATA = 'CPH', @RouteEndDestinationIATA = '123';
SELECT * FROM Company;
SELECT * FROM AirPort;


