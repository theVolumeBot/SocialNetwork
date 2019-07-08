Use master
DROP DATABASE SocialNetworkApp
CREATE DATABASE SocialNetWorkApp 
Use SocialNetworkApp

CREATE TABLE AppUser (
Id int PRIMARY KEY Identity,
NickName nvarchar(50) not null, 
UserPassword nvarchar(100) not null, 
Age int not null, 
City nvarchar(80) not null
)

CREATE TABLE GetMessage (
Id int PRIMARY KEY Identity,
FromId int not null REFERENCES AppUser(Id), 
Title nvarchar(80) not null, 
Content nvarchar(max) not null, 
MessageDate date not null  
)

CREATE TABLE SendMessage (
Id int PRIMARY KEY Identity,
ToId int not null REFERENCES AppUser(Id), 
Title nvarchar(80) not null,
Content nvarchar(max) not null,
MessageDate date not null
)

