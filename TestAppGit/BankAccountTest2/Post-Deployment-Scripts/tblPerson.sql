/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO tblPerson (FirstName,LastName,BirthDate,FiscalCodes,GenderID) 
VALUES ('Ion','Draganel','1991-06-10','4679834467985',1),
       ('Petru','Popescu','1968-12-23','4679855767985',1),
	   ('Viorel','Ionescu','1969-12-01','4672753467985',1),
	   ('Victor','Stan','1970-05-19','4679853897985',1),
	   ('Ion','Nemet','1971-01-07','4679853467985',1),
	   ('Mihai','Dumitrescu','1972-05-03','4679858967985',1),
	   ('Oleg','Ionita','1973-02-15','4679853445985',1),
	   ('Iurie','Tudor','1973-10-03','4679845467985',1),
	   ('Veaceslav','Dobre','1975-04-24','4679855667985',1),
	   ('Daniel','Barbu','1976-04-20','4679111467985',1),
	   ('Eugen','Nistor','1977-01-25','4645853467985',1),
	   ('Andrei','Preda','1978-06-28','4679573467985',1),
	   ('Lilia','Cristea','1980-10-17','4679683467985',2),
	   ('Viorica','Tabacu','1981-07-21','4679856967985',2),
	   ('Ana','Stoica','1981-10-28','4674553467985',2),
	   ('Eugenia','Albu','1985-11-26','3479853467985',2),
	   ('Olesea','Mocanu','1989-05-29','7679853467985',2),
	   ('Ana-Maria','Florea','1989-12-29','2479853467985',2),
	   ('Elizabeta','Diaconu','1993-03-12','3279853467985',2),
	   ('Ruxanda','Georgescu','1994-11-08','4579853467985',2),
	   ('Dumitru','Ene','1995-04-11','2279853467985',1);