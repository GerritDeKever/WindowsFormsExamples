/*
	Author:			
	Date:			
	Description:	
*/

-- Use master
USE master;
GO

-- Check if database exists, then drop it
DROP DATABASE IF EXISTS DatabaseName;

-- Create the db
CREATE DATABASE DatabaseName
GO

-- Use the db
USE DatabaseName;
GO

SET DATEFORMAT dmy;

-- Group table
CREATE TABLE [TableName]
(
	TableId			INT NOT NULL IDENTITY(1, 1),
  Values      VARCHAR(10) NOT NULL
);

-- Primary keys
ALTER TABLE [TableName]
ADD CONSTRAINT [PK_TableName] 
PRIMARY KEY (TableId);


-- Foreign Keys
ALTER TABLE [OtherTable]
ADD CONSTRAINT [FK_ReferencedTableId] 
FOREIGN KEY (ReferencedTableId)
REFERENCES [TableName](TableId);


-- Test values
INSERT INTO [TableName] 
VALUES 
   ('Tabledata'),
   ('Datatwo');
