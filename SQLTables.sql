USE [291GroupProject]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Branch](
	[BranchID][int] NOT NULL,
	[Location][nvarchar](20) NULL,
	CONSTRAINT [PK_BranchID] PRIMARY KEY CLUSTERED
	([BranchID] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON) ON [PRIMARY]
) ON [PRIAMRY]

GO

CREATE TABLE [dbo].[Car](
	[VehicleID][int] NOT NULL,
	[Type of Vehicle][varchar](50) NULL,
	[Color][varchar](50) NULL,
	[Make][varchar](10) NULL,
	[Brand][varchar](20) NULL,
	[CustomerID][int] NOT NULL
	CONSTRAINT FK_Customer_ID FOREIGN KEY (CustomerID)
	REFERENCES Client(CustomerID)
	CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED
	([VehicleID] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON) ON [PRIMARY]
) ON [PRIAMRY]

GO

CREATE TABLE [dbo].[CarType](
	[Daily Price][money] NULL,
	[Weekly Price][money] NULL,
	[Monthly Price][money] NULL
)


CREATE TABLE [dbo].[Client](
	[CustomerID][int] NOT NULL,
	[Total Year Rent][nchar](50) NULL,
	[First Name][nchar](50) NOT NULL,
	[Last Name][nchar](20) NOT NULL,
	[Address][nchar](100) NOT NULL,
	[CreditCardNum][int] NULL,
	[Phone][nvarchar](15) NULL,
	CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED
	([CustomerID] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON) ON [PRIMARY]
) ON [PRIAMRY]

GO

CREATE TABLE [dbo].[ExtraFee](
	[ReservationID][int] NOT NULL,
	[Types of fee][varchar](10) NULL,
	[Price][money] NULL
	CONSTRAINT [PK_ExtraFee] PRIMARY KEY CLUSTERED
	([ReservationID] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON) ON [PRIMARY]
) ON [PRIAMRY]

GO

CREATE TABLE [dbo].[Reservation](
	[ReservationID][int] NOT NULL,
	[Start date][datetime] NULL,
	[End date][datetime] NULL,
	[Total Price][money] NULL,
	[BranchID][int] NOT NULL,
	[VehicleID][int] NOT NULL,
	[CustomerID][int] NOT NULL,
	CONSTRAINT FK_Branch_ID FOREIGN KEY (BranchID)
	REFERENCES Branch(BranchID),
	CONSTRAINT FK_Car_ID FOREIGN KEY (VehicleID)
	REFERENCES Car(VehicleID),
	CONSTRAINT FK_Client_ID FOREIGN KEY (CustomerID)
	REFERENCES Client(CustomerID),
	CONSTRAINT [PK_Rerservation] PRIMARY KEY CLUSTERED
	([ReservationID] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON) ON [PRIMARY]
) ON [PRIAMRY]

GO