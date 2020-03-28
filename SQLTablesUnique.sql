USE [291GroupProject]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CarType](
	[Daily Price][money] NULL,
	[Weekly Price][money] NULL,
	[Monthly Price][money] NULL
)

CREATE TABLE [dbo].[Login](
	[username][nvarchar](50) NOT NULL,
	[password][nvarchar](50) NOT NULL,
	[role][nvarchar] (50) NOT NULL,
	CONSTRAINT PK_username
	PRIMARY KEY (username))

CREATE TABLE [dbo].[Client](
	[CustomerID][uniqueidentifier] NOT NULL,
	[Total Year Rent][nchar](50) NULL,
	[First Name][nchar](50) NOT NULL,
	[Last Name][nchar](20) NOT NULL,
	[Address][nchar](100) NOT NULL,
	[CreditCardNum][bigint] NULL,
	[Phone][nvarchar](15) NULL,
	[username][nvarchar] (50) UNIQUE NOT NULL,
	CONSTRAINT FK_username FOREIGN KEY (username) 
	REFERENCES Login(username),
	CONSTRAINT PK_Customer 
	PRIMARY KEY (CustomerID))

GO


CREATE TABLE [dbo].[Branch](
	[BranchID][uniqueidentifier] NOT NULL,
	[Location][nvarchar](20) NULL,
	CONSTRAINT PK_BranchID
	PRIMARY KEY (BranchID))

GO


/* Status: 0 = ready, 1 = taken, 2 = repairing
 * Type of vehiiiicle is the frame of the car ex: SUV, Sedan and Sport
 * Model: the name of the car
 * Make: the company who makes vehicle contraption.
 */
CREATE TABLE [dbo].[Car](
	[VehicleID][uniqueidentifier] NOT NULL,
	[Type of Vehicle][varchar](50) NULL,
	[Color][varchar](50) NULL,
	[Model][varchar](50) NULL,
	[Make][varchar](10) NULL,
	[Status][int] NULL,
	[CustomerID][uniqueidentifier] NOT NULL
	CONSTRAINT FK_Customer_ID FOREIGN KEY (CustomerID)
	REFERENCES Client(CustomerID)
	CONSTRAINT PK_Car 
	PRIMARY KEY (VehicleID))

GO



CREATE TABLE [dbo].[ExtraFee](
	[ReservationID][uniqueidentifier] NOT NULL,
	[Types of fee][varchar](10) NULL,
	[Price][money] NULL
	CONSTRAINT PK_ExtraFee
	PRIMARY KEY (ReservationID))

GO

CREATE TABLE [dbo].[Reservation](
	[ReservationID][uniqueidentifier] NOT NULL,
	[Start date][datetime] NULL,
	[End date][datetime] NULL,
	[Total Price][money] NULL,
	[BranchID][uniqueidentifier] NOT NULL,
	[VehicleID][uniqueidentifier] NOT NULL,
	[CustomerID][uniqueidentifier] NOT NULL,
	CONSTRAINT FK_Branch_ID FOREIGN KEY (BranchID)
	REFERENCES Branch(BranchID),
	CONSTRAINT FK_Car_ID FOREIGN KEY (VehicleID)
	REFERENCES Car(VehicleID),
	CONSTRAINT FK_Client_ID FOREIGN KEY (CustomerID)
	REFERENCES Client(CustomerID),
	CONSTRAINT PK_Rerservation
	PRIMARY KEY (ReservationID))

GO