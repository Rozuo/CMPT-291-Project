DELETE FROM Users
USE [291GroupProject]
GO
/*this line is for deleting the rows in table. Type "where" for more conditions*/


INSERT INTO [dbo].[Branch] VALUES (NEWID(),'Edmonton')

INSERT INTO [dbo].[Branch] VALUES (NEWID(),'Calgary')

INSERT INTO [dbo].[Branch] VALUES (NEWID(),'RedDeer')

INSERT INTO [dbo].[Branch] VALUES (NEWID(),'Vancouver')

INSERT INTO [dbo].[Branch] VALUES (NEWID(),'Richmond')

SELECT * FROM Branch

/*userID, total year rent, username, password, first name, last name, address, creditcardnum, phone, membership, role(client or admin)*/
INSERT INTO [dbo].[Users] VALUES (NEWID(),'1','AmyBillid','BillidA677','Amy','Billid','Kurby street 67Ave RedDeer Alberta Canada',5510290033700484,'780-567-1234', 0, 'client')

INSERT INTO [dbo].[Users] VALUES (NEWID(),'5','KarenCathey','CatKaren333','Karen','Cathey','124 street 106Ave Edmonton Alberta Canada',5510290032010951,'780-710-2234', 1, 'client')

INSERT INTO [dbo].[Users] VALUES (NEWID(),'3','DerikGates','password','Derik','Gates','Stony Plain Rd 102Ave Edmonton Alberta Canada',5510281133700484,'780-341-6534',1, 'client')

INSERT INTO [dbo].[Users] VALUES (NEWID(),'0','PhilipBerry','Berry699Phil','Philip','Berry','133 street 67Ave Calgary Alberta Canada',5510290056760484,'780-962-1774',0, 'client')

INSERT INTO [dbo].[Users] VALUES (NEWID(),'3','HenryCayman','HenryC7788','Henry','Cayman','99 street 42Ave Vancuouver British Columbia Canada',5510291156760484,'672-962-5706',1, 'client')

INSERT INTO [dbo].[Users] VALUES (NEWID(),'7','PhoenaSmall','PhoenaS9960','Phoena','Small','199 street 11Ave Calgary Alberta Canada',5510290059870484,'567-870-7741',1, 'client')

INSERT INTO [dbo].[Users] VALUES (NEWID(),'4','SarahWieldge','SarahW2099','Sarah','Wieldge','20 street 43Ave RedDeer Alberta Canada',5510290056760214,'780-652-3144',1, 'client')

INSERT INTO [dbo].[Users] VALUES (NEWID(),'1','LophiliaHam','LophiliaH1043','Lophilia','Ham','220 street 133Ave Vancuouver British Columbia Canada',5510290056760274,'672-919-5446',0, 'client')

INSERT INTO [dbo].[Users] VALUES (NEWID(),'0','SophiaPage','SophiaH557','Sophia','Page','220 street 133Ave Vancuouver British Columbia Canada',5510290026107774,'672-788-5336',0, 'admin')

INSERT INTO [dbo].[Users] VALUES (NEWID(),'5','Tommy','TommyM3901','Tommy','May','104 street 94Ave Edmonton Alberta Canada',5510290021162033,'567-555-2299',1, 'admin')

SELECT * FROM Users

/*car table: vehicleID, color, model, make, status, type of vehicle, userID(can be NULL)*/
SELECT userID from Users

SELECT userID from Users where Users.[First Name] = 'Karen'
INSERT INTO [dbo].[Car] VALUES (NEWID(),'grey', 'civic', 'Honda', 0, 'sedan', NULL)

INSERT INTO [dbo].[Car] VALUES (NEWID(),'black', 'civic', 'Toyota', 0, 'hatchback', NULL)

INSERT INTO [dbo].[Car] VALUES (NEWID(),'blue', 'civic', 'Toyota', 1, 'sedan',
(SELECT userID from Users where Users.[First Name] = 'Karen' and Users.[Last Name] = 'Cathey'))

INSERT INTO [dbo].[Car] VALUES (NEWID(),'red', 'civic','Honda', 1,'hatchback',
(SELECT userID from Users where Users.[First Name] = 'Derik' and Users.[Last Name] = 'Gates'))

INSERT INTO [dbo].[Car] VALUES(NEWID(),'grey', 'mustang', 'Ford', 0, 'coupe', NULL)

INSERT INTO [dbo].[Car] VALUES(NEWID(),'grey', 'mustang', 'Ford', 2, 'coupe', NULL)

INSERT INTO [dbo].[Car] VALUES(NEWID(),'blue', '911', 'Porsche', 2, 'convertible', NULL)

INSERT INTO [dbo].[Car] VALUES(NEWID(),'white', 'Cayenne', 'Porsche', 0, 'suv', NULL)

INSERT INTO [dbo].[Car] VALUES(NEWID(),'blue', 'F-150', 'Ford', 0, 'truck', NULL)

SELECT * FROM Car
/*carType table: type of vehicle, daily price, weekly price, monthly price*/
INSERT INTO [dbo].[CarType] VALUES('sedan',230,0.95,0.65)

INSERT INTO [dbo].[CarType] VALUES('hatchback',250,0.95,0.65)

INSERT INTO [dbo].[CarType] VALUES('coupe',510,0.75,0.55)

INSERT INTO [dbo].[CarType] VALUES('convertible',530,0.75,0.55)

INSERT INTO [dbo].[CarType] VALUES('suv',370,0.9,0.7)

INSERT INTO [dbo].[CarType] VALUES('truck',410,0.9,0.7)

INSERT INTO [dbo].[CarType] VALUES('van',390,0.9,0.7)

SELECT * FROM CarType
/*reservation: reservationID, start date, end date, total price, branchID, vehicleID, userID*/


/*ExraFee table: reservationID, types of fee, price*/
INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(),'late return',25)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(), 'insurence', 160)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(), 'oil fee', 75)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(), 'is under 25', 50)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(),'different location',25)
GO

