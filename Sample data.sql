USE [291GroupProject]
GO
/*this line is for deleting the rows in table. Type "where" for more conditions*/
DELETE FROM Users

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

SELECT * FROM Users


/*car table: vehicleID, color, model, make, status, type of vehicle, userID(can be NULL)*/
SELECT userID from Users as Userid
/*put 8 cars and 2 with userID*/
INSERT INTO [dbo].[Car] VALUES (NEWID(),'grey', 'civic', 'Toyota', 'Sedan')

INSERT INTO [dbo].[Car] VALUES (NEWID(),'black', 'civic', 'Toyota', 'Sedan')

INSERT INTO [dbo].[Car] VALUES (NEWID(),'blue', 'civic', 'Toyota', 'Sedan')
/*carType table: type of vehicle, daily price, weekly price, monthly price*/

/*reservation: reservationID, start date, end date, total price, branchID, vehicleID, userID*/


/*ExraFee table: reservationID, types of fee, price*/
INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(),'late return',25)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(), 'insurence', 160)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(), 'oil fee', 75)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(), 'is under 25', 50)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(),'different location',25)
GO

