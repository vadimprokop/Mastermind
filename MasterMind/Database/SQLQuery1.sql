CREATE TABLE PlayersResults
(
	PlayerID INT IDENTITY(1,1) PRIMARY KEY,
	PlayerNickName nvarchar(50) NOT NULL,
	PlayerTime time NOT NULL,
	PlayerScore int NOT NULL
)
go
insert into PlayersResults values('Joy', '00:2:00', 3200)
select * from PlayersResults