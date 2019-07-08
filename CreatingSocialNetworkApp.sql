Use master
GO
DROP DATABASE SocialNetworkApp
GO
CREATE DATABASE SocialNetWorkApp 
GO
Use SocialNetworkApp
GO

CREATE TABLE AppUser (
Id int PRIMARY KEY Identity,
NickName nvarchar(50) not null, 
UserPassword nvarchar(100) not null, 
Age int not null, 
City nvarchar(80) not null
)
GO
CREATE TABLE GetMessage (
Id int PRIMARY KEY Identity,
FromId int not null REFERENCES AppUser(Id), 
Title nvarchar(80) not null, 
Content nvarchar(max) not null, 
MessageDate date not null  
)
GO
CREATE TABLE SendMessage (
Id int PRIMARY KEY Identity,
ToId int not null REFERENCES AppUser(Id), 
Title nvarchar(80) not null,
Content nvarchar(max) not null,
MessageDate date not null
)

