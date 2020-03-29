USE [291GroupProject]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[CarType](
    [Type of Vehicle][varchar](50) NOT NULL,
	[Daily Price][money] NULL,
	[Weekly Price][money] NULL,
	[Monthly Price][money] NULL,
	CONSTRAINT PK_Type_of_Vehicle 
	PRIMARY KEY ([Type of Vehicle])
) 

/*CREATE TABLE [dbo].[Login](
	[username][nvarchar](50) NOT NULL,
	[password][nvarchar](50) NOT NULL,
	[role][nvarchar] (50) NOT NULL,
	CONSTRAINT PK_username
	PRIMARY KEY (username))
	*/

	-- 0 false
	-- 1 true
CREATE TABLE [dbo].[Users](
	[UserID][uniqueidentifier] NOT NULL,
	[Total Year Rent][nchar](50) NULL,
	[username][nvarchar](50) NOT NULL,
	[password][nvarchar](50) NOT NULL,
	[First Name][nchar](50) NOT NULL,
	[Last Name][nchar](20) NOT NULL,
	[Address][nchar](100) NOT NULL,
	[CreditCardNum][bigint] NULL,
	[Phone][nvarchar](15) NULL,
	[Gold][bit] NOT NULL,
	[role][nvarchar] (50) NOT NULL,
	CONSTRAINT PK_UserID 
	PRIMARY KEY (UserID))

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
	[VehicleID][uniqueidentifier] UNIQUE NOT NULL,
	[Color][varchar](50) NULL,
	[Model][varchar](50) NULL,
	[Make][varchar](10) NULL,
	[Status][int] NULL,
	[Type of Vehicle][varchar](50) NOT NULL,
	[UserID][uniqueidentifier] NULL
	CONSTRAINT FK_User_ID FOREIGN KEY (UserID)
	REFERENCES Users(UserID),
	CONSTRAINT FK_Type_of_Vehicle FOREIGN KEY ([Type of Vehicle])
	REFERENCES CarType([Type of Vehicle]),
	CONSTRAINT PK_Car 
	PRIMARY KEY (VehicleID))

GO





CREATE TABLE [dbo].[Reservation](
	[ReservationID][uniqueidentifier] NOT NULL,
	[Start date][datetime] NULL,
	[End date][datetime] NULL,
	[Total Price][money] NULL,
	[BranchID][uniqueidentifier] NOT NULL,
	[VehicleID][uniqueidentifier] NOT NULL,
	[UserID][uniqueidentifier] NOT NULL,
	CONSTRAINT FK_Branch_ID FOREIGN KEY (BranchID)
	REFERENCES Branch(BranchID),
	CONSTRAINT FK_Car_ID FOREIGN KEY (VehicleID)
	REFERENCES Car(VehicleID),
	CONSTRAINT FK_TheUserID FOREIGN KEY (UserID)
	REFERENCES Users(UserID),
	CONSTRAINT PK_Rerservation
	PRIMARY KEY (ReservationID))

GO

CREATE TABLE [dbo].[ExtraFee](
	[ReservationID][uniqueidentifier] NOT NULL,
	[Types of fee][varchar](10) NULL,
	[Price][money] NULL
	CONSTRAINT FK_ReservationID FOREIGN KEY (ReservationID)
	REFERENCES Reservation(ReservationID))
GO