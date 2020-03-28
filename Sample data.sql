USE [291GroupProject]
GO

DELETE FROM Branch

INSERT INTO [dbo].[Branch] VALUES (NEWID(),'Edmonton')

INSERT INTO [dbo].[Branch] VALUES (NEWID(),'Calgary')

INSERT INTO [dbo].[Branch] VALUES (NEWID(),'RedDeer')

INSERT INTO [dbo].[Branch] VALUES (NEWID(),'Vancouver')

INSERT INTO [dbo].[Branch] VALUES (NEWID(),'Richmond')

SELECT * FROM Branch


INSERT INTO [dbo].[Client] VALUES (NEWID(),'1','Amy','Billid','Kurby street 67Ave RedDeer Alberta Canada',5510290033700484,'780-567-1234')

INSERT INTO [dbo].[Client] VALUES (NEWID(),'5','Karen','Cathey','124 street 106Ave Edmonton Alberta Canada',5510290032010951,'780-710-2234')

INSERT INTO [dbo].[Client] VALUES (NEWID(),'3','Derik','Gates','Stony Plain Rd 102Ave Edmonton Alberta Canada',5510281133700484,'780-341-6534')

INSERT INTO [dbo].[Client] VALUES (NEWID(),'0','Philip','Berry','133 street 67Ave Calgary Alberta Canada',5510290056760484,'780-962-1774')

INSERT INTO [dbo].[Client] VALUES (NEWID(),'3','Henry','Cayman','99 street 42Ave Vancuouver British Columbia Canada',5510291156760484,'672-962-5706')

INSERT INTO [dbo].[Client] VALUES (NEWID(),'7','Phoena','Small','199 street 11Ave Calgary Alberta Canada',5510290059870484,'567-870-7741')

INSERT INTO [dbo].[Client] VALUES (NEWID(),'4','Sarah','Wieldge','20 street 43Ave RedDeer Alberta Canada',5510290056760214,'780-652-3144')

INSERT INTO [dbo].[Client] VALUES (NEWID(),'1','Lophilia','Ham','220 street 133Ave Vancuouver British Columbia Canada',5510290056760274,'672-919-5446')

SELECT * FROM Client



INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(),'late return',25)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(), 'Front bumper damage', 500)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(), 'Rear bumper damage', 500)

INSERT INTO [dbo].[ExtraFee] VALUES (NEWID(), 'Scratches', 150)
GO

