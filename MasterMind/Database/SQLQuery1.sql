CREATE TABLE PlayersResults
(
	PlayerID INT IDENTITY(1,1) PRIMARY KEY,
	PlayerNickName nvarchar(50) NOT NULL,
	PlayerScore int NOT NULL
)
go
insert into PlayersResults values('Joy', 3200)
select * from PlayersResults
