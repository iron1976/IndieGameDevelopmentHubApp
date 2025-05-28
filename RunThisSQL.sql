 
--SQL CODES START COPY FROM HERE TO THE BOTTOM!:
--REMOVE ALL TABLES---------------------------------------------------------------------------------------------------------   
USE IndieGameDevelopmentHub;
GO
DROP TABLE IF EXISTS BUG_REPORTS;
GO
DROP TABLE IF EXISTS EVENTS;
GO
DROP TABLE IF EXISTS TESTERS_ACCESS;
GO
DROP TABLE IF EXISTS TESTERS;
GO
DROP TABLE IF EXISTS ASSETS;
GO
DROP TABLE IF EXISTS REVIEWS;
GO
DROP TABLE IF EXISTS GAME_GENRES;
GO
DROP TABLE IF EXISTS WORKS_ON;
GO
DROP TABLE IF EXISTS DEVELOPER_FINANCES;
GO
DROP TABLE IF EXISTS PLAYERS;
GO
DROP TABLE IF EXISTS GAMES;
GO
DROP TABLE IF EXISTS DEVELOPERS;
GO

--CREATE ALL TABLES--------------------------------------------------------------------------------------------------------- 
create table DEVELOPERS  
(   
  DevID     	 decimal(4),   
  FirstName   	 varchar(14) NOT NULL,
  LastName   	 varchar(14) NOT NULL, 
  Email 		 varchar(14) NOT NULL UNIQUE,
  Password 		 varchar(14) NOT NULL,
  RegisterDate 	 datetime,
  PRIMARY KEY    (DevID)
  
); 
CREATE INDEX DevEmailIndex ON DEVELOPERS(Email);
CREATE TABLE DEVELOPER_FINANCES (--(1:1)
  DevID		     decimal(4),
  Income         decimal(10,2),
  RaiseRate      decimal(5,2),-- percentage (ex: 10.00 for 10%)
  PRIMARY KEY    (DevID),
  FOREIGN KEY    (DevID) REFERENCES DEVELOPERS(DevID) ON DELETE CASCADE
);
create table GAMES  (   
  GameID 		 decimal(4), 
  Title 		 varchar(10) NOT NULL, 
  GameRating 	 DECIMAL(3,2) NOT NULL,-- AVG of all review ratings for this game, DISPLAY EX:(1.24, X.YZ)
  CONSTRAINT     GameRatingRange CHECK (GameRating BETWEEN 0 AND 5),
  PRIMARY KEY	 (GameID) 
);
CREATE INDEX TitleIndex ON GAMES(Title);
create table WORKS_ON ( -- DEVELOPERS-GAMES(M:N)
  DevID 		 decimal(4) NOT NULL,
  GameID 		 decimal(4) NOT NULL,
  Role 			 VARCHAR(10), -- Lead Developer, Designer, etc.
  PRIMARY KEY 	 (DevID, GameID),
  FOREIGN KEY 	 (DevID)  REFERENCES Developers(DevID) ON DELETE CASCADE,
  FOREIGN KEY 	 (GameID) REFERENCES GAMES(GameID) ON DELETE CASCADE
);
CREATE TABLE GAME_GENRES (--(1:N)
  GameID	     decimal(4),
  Genre		     VARCHAR(15),
  PRIMARY KEY    (GameID, Genre),
  FOREIGN KEY    (GameID) REFERENCES GAMES(GameID) ON DELETE CASCADE
);
create table PLAYERS      ( 
  PlayerID       decimal(4),  
  FirstName 	 varchar(14) NOT NULL,
  LastName       varchar(14) NOT NULL, 
  RegisterDate   datetime 	 NOT NULL,
  Email 		 varchar(14) NOT NULL UNIQUE,
  Password 		 varchar(14) NOT NULL, 
  PRIMARY KEY    (PlayerID) 
);
CREATE INDEX PlayerEmailIndex ON PLAYERS(Email);
create table REVIEWS    (
  ReviewID       decimal(4),
  PlayerID 	     decimal(4),-- PLAYERS-REVIEWS(1:N) players have multiple reviews
  GameID 	     decimal(4),-- GAMES-REVIEWS(1:N) 
  Review 		 varchar(30) NOT NULL,
  Rating 		 DECIMAL(3,2) NOT NULL,
  ReviewDate 	 datetime,
  CONSTRAINT     RatingRange CHECK (Rating BETWEEN 0 AND 5),
  PRIMARY KEY 	 (ReviewID),
  FOREIGN KEY 	 (PlayerID)   REFERENCES PLAYERS(PlayerID) ON DELETE CASCADE,
  FOREIGN KEY 	 (GameID) 	  REFERENCES GAMES(GameID) ON DELETE CASCADE
); 
create table ASSETS   (    
  AssetID        decimal(4),
  GameID 		 decimal(4),-- GAMES-ASSETS(1:N)
  AssetName   	 varchar(14),
  AssetType 	 varchar(10),
  DevID 		 decimal(4),-- DEVELOPERS-ASSETS(1:N)
  UploadDate 	 datetime,
  PRIMARY KEY    (AssetID),
  FOREIGN KEY    (GameID) 	REFERENCES GAMES(GameID) ON DELETE CASCADE,-- GAMES-ASSETS(1:N)
  FOREIGN KEY    (DevID) 	REFERENCES DEVELOPERS(DevID) ON DELETE CASCADE-- DEVELOPERS-ASSETS(N:1)
);
CREATE INDEX AssetNameIndex ON ASSETS(AssetName);
create table TESTERS    (  
  TesterID       decimal(4),   
  FirstName 	 varchar(14) NOT NULL,
  LastName       varchar(14) NOT NULL, 
  RegisterDate   datetime 	NOT NULL,
  Email 		 varchar(14) NOT NULL UNIQUE,
  Password 		 varchar(14) NOT NULL,
  IsLicensed     bit DEFAULT 0,
  PRIMARY KEY    (TesterID)
);
CREATE INDEX TesterEmailIndex ON TESTERS(Email);
create table TESTERS_ACCESS    (  
  GameID		 decimal(4) NOT NULL,
  TesterID       decimal(4) NOT NULL,   
  IsAllowed		 bit NOT NULL,
  PRIMARY KEY    (GameID,TesterID),
  FOREIGN KEY    (TesterID) REFERENCES TESTERS(TesterID) ON DELETE CASCADE,
  FOREIGN KEY    (GameID)   REFERENCES GAMES(GameID) ON DELETE CASCADE
);
create table EVENTS      ( 
  EventID        decimal(4),  
  Description	 varchar(14),
  EventStartDate datetime NOT NULL,
  EventEndDate   datetime NOT NULL,
  
  PRIMARY KEY   (eventID) 
);
create table BUG_REPORTS   (   --WeakEntity
  ReportID 		 decimal(4),
  GameID 		 decimal(4), -- GAMES-BUG_REPORTS(1:N)
  TesterID 		 decimal(4), -- TESTERS-BUG_REPORTS(1:N)
  Report 		 varchar(50),
  PRIMARY KEY    (ReportID, GameID),
  FOREIGN KEY    (GameID) 	REFERENCES GAMES(GameID) ON DELETE CASCADE,-- GAMES-BUG_REPORTS(1:N)
  FOREIGN KEY    (TesterID) REFERENCES TESTERS(TesterID) ON DELETE CASCADE-- TESTERS-BUG_REPORTS(1:N)
);
GO

--CREATE ALL VIEWS--------------------------------------------------------------------------------------------------------- 


USE IndieGameDevelopmentHub;
IF OBJECT_ID('DeveloperFinanceView', 'V') IS NOT NULL
    DROP VIEW DeveloperFinanceView;
GO
CREATE VIEW DeveloperFinanceView AS
SELECT
    d.DevID, d.FirstName, d.LastName,
    f.Income, f.RaiseRate
FROM DEVELOPERS d
JOIN DEVELOPER_FINANCES f ON d.DevID = f.DevID;
GO
 
IF OBJECT_ID('AssetOwnerDetails', 'V') IS NOT NULL
    DROP VIEW AssetOwnerDetails;
GO
CREATE VIEW AssetOwnerDetails AS
SELECT
    a.AssetID, a.AssetName, a.AssetType, a.UploadDate,
    d.FirstName + ' ' + d.LastName AS DeveloperName,   
    g.Title AS GameTitle
FROM ASSETS a
JOIN DEVELOPERS d ON a.DevID = d.DevID
JOIN GAMES g ON a.GameID = g.GameID;
GO
 
IF OBJECT_ID('PlayerReviews', 'V') IS NOT NULL
    DROP VIEW PlayerReviews;
GO
CREATE VIEW PlayerReviews AS
SELECT
    p.FirstName,
    g.Title AS GameTitle,
    r.Review, r.Rating, r.ReviewDate
FROM REVIEWS r
JOIN PLAYERS p ON r.PlayerID = p.PlayerID
JOIN GAMES g ON r.GameID = g.GameID;
GO


IF OBJECT_ID('GameGenreGrouped', 'V') IS NOT NULL
    DROP VIEW GameGenreGrouped;
GO
CREATE VIEW GameGenreGrouped AS
SELECT 
    G.GameID,
    G.Title,
    G.GameRating,
    STRING_AGG(GG.Genre, ', ') AS Genres
FROM 
    GAMES G
INNER JOIN 
    GAME_GENRES GG ON G.GameID = GG.GameID
GROUP BY 
    G.GameID, G.Title, G.GameRating;
GO

IF OBJECT_ID('DeveloperAssignmentsView', 'V') IS NOT NULL
    DROP VIEW DeveloperAssignmentsView; 
GO
CREATE VIEW DeveloperAssignmentsView AS
SELECT 
    D.DevID,
    D.FirstName + ' ' + D.LastName AS FullName,
    D.Email,
    G.Title AS GameTitle,
    W.Role
FROM 
    DEVELOPERS D
JOIN 
    WORKS_ON W ON D.DevID = W.DevID
JOIN 
    GAMES G ON W.GameID = G.GameID;
GO

--TRIGGERS: --------------------------------------------------------------------------------------------------------- 
 


DROP TRIGGER IF EXISTS UpdateGameRate;
GO 
CREATE TRIGGER UpdateGameRate
ON REVIEWS
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Compute average ratings per GameID from the inserted rows
    ;WITH NewRatings AS (
        SELECT 
            GameID,
            AVG(CAST(Rating AS FLOAT)) AS AvgRating
        FROM REVIEWS
        WHERE GameID IN (SELECT GameID FROM INSERTED)
        GROUP BY GameID
    )
    UPDATE G
    SET G.GameRating = ROUND(NR.AvgRating, 2)
    FROM GAMES G
    INNER JOIN NewRatings NR ON G.GameID = NR.GameID;
END;


DROP TRIGGER IF EXISTS UpdateGameRateOnUpdate;
GO 
CREATE TRIGGER UpdateGameRateOnUpdate
ON REVIEWS
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    ;WITH ChangedGameIDs AS (
        SELECT DISTINCT GameID FROM INSERTED
    ),
    NewRatings AS (
        SELECT 
            R.GameID,
            AVG(CAST(R.Rating AS FLOAT)) AS AvgRating
        FROM REVIEWS R
        INNER JOIN ChangedGameIDs C ON R.GameID = C.GameID
        GROUP BY R.GameID
    )
    UPDATE G
    SET G.GameRating = ROUND(NR.AvgRating, 2)
    FROM GAMES G
    INNER JOIN NewRatings NR ON G.GameID = NR.GameID;
END;


DROP TRIGGER IF EXISTS TriggerSetDeveloperRegisterDate;
GO
CREATE TRIGGER TriggerSetDeveloperRegisterDate
ON DEVELOPERS
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE D
    SET D.RegisterDate = GETDATE()
    FROM DEVELOPERS D
    INNER JOIN INSERTED I ON D.DevID = I.DevID
    WHERE I.RegisterDate IS NULL;
END;



DROP TRIGGER IF EXISTS TriggerSetPlayerRegisterDate;
GO
CREATE TRIGGER TriggerSetPlayerRegisterDate
ON PLAYERS
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE P
    SET P.RegisterDate = GETDATE()
    FROM PLAYERS P
    INNER JOIN INSERTED I ON P.PlayerID = I.PlayerID
    WHERE I.RegisterDate IS NULL;
END;



DROP TRIGGER IF EXISTS TriggerSetTesterRegisterDate;
GO
CREATE TRIGGER TriggerSetTesterRegisterDate
ON TESTERS
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE T
    SET T.RegisterDate = GETDATE()
    FROM TESTERS T
    INNER JOIN INSERTED I ON T.TesterID = I.TesterID
    WHERE I.RegisterDate IS NULL;
END;


DROP TRIGGER IF EXISTS TriggerSetAssetUploadDate;
GO
CREATE TRIGGER TriggerSetAssetUploadDate
ON ASSETS
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE A
    SET A.UploadDate = GETDATE()
    FROM ASSETS A
    INNER JOIN INSERTED I ON A.AssetID = I.AssetID
    WHERE I.UploadDate IS NULL;
END;





DROP TRIGGER IF EXISTS TriggerSetReviewDate;
GO
CREATE TRIGGER TriggerSetReviewDate
ON REVIEWS
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE R
    SET R.ReviewDate = GETDATE()
    FROM REVIEWS R
    INNER JOIN INSERTED I ON R.ReviewID = I.ReviewID
    WHERE I.ReviewDate IS NULL;
END; 


--DUMMY DATAS:
 
GO
-- DEVELOPERS
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (1, 'Hannah', 'Alice', 'hanna59@x.io', 'pass1', '2022-02-17');
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (2, 'Diana', 'Alice', 'diana885@x.io', 'pass2', '2023-09-11');
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (3, 'Diana', 'George', 'diana655@x.io', 'pass3', '2022-10-07');
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (4, 'Ian', 'Julia', 'ian770@x.io', 'pass4', '2020-12-27');
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (5, 'Diana', 'Ian', 'diana444@x.io', 'pass5', '2024-06-01');
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (6, 'Hannah', 'Hannah', 'hanna894@x.io', 'pass6', '2024-12-27');
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (7, 'George', 'Charlie', 'georg136@x.io', 'pass7', '2021-09-19');
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (8, 'Diana', 'Julia', 'diana310@x.io', 'pass8', '2020-02-21');
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (9, 'Bob', 'Alice', 'bob501@x.io', 'pass9', '2021-08-13');
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (10, 'Fiona', 'Hannah', 'fiona818@x.io', 'pass10', '2023-07-23');
INSERT INTO DEVELOPERS (DevID, FirstName, LastName, Email, Password, RegisterDate) VALUES (11, 'Fiona', 'Hannah', 'a@', 'g', '2023-07-23');

-- DEVELOPER_FINANCES
INSERT INTO DEVELOPER_FINANCES (DevID, Income, RaiseRate) VALUES (1, 140799.96, 6.52);
INSERT INTO DEVELOPER_FINANCES (DevID, Income, RaiseRate) VALUES (2, 139741.31, 11.93);
INSERT INTO DEVELOPER_FINANCES (DevID, Income, RaiseRate) VALUES (3, 129879.85, 4.96);
INSERT INTO DEVELOPER_FINANCES (DevID, Income, RaiseRate) VALUES (4, 111974.52, 5.61);
INSERT INTO DEVELOPER_FINANCES (DevID, Income, RaiseRate) VALUES (5, 119247.72, 7.16);
INSERT INTO DEVELOPER_FINANCES (DevID, Income, RaiseRate) VALUES (6, 111416.65, 12.35);
INSERT INTO DEVELOPER_FINANCES (DevID, Income, RaiseRate) VALUES (7, 143277.72, 7.91);
INSERT INTO DEVELOPER_FINANCES (DevID, Income, RaiseRate) VALUES (8, 131452.94, 10.67);
INSERT INTO DEVELOPER_FINANCES (DevID, Income, RaiseRate) VALUES (9, 98382.52, 4.84);
INSERT INTO DEVELOPER_FINANCES (DevID, Income, RaiseRate) VALUES (10, 138792.14, 9.55);

-- GAMES
INSERT INTO GAMES (GameID, Title, GameRating) VALUES (1, 'BitQuest', 2.35);
INSERT INTO GAMES (GameID, Title, GameRating) VALUES (2, 'SkyRush', 3.84);
INSERT INTO GAMES (GameID, Title, GameRating) VALUES (3, 'DriftMax', 4.14);
INSERT INTO GAMES (GameID, Title, GameRating) VALUES (4, 'HexMaze', 3.45);
INSERT INTO GAMES (GameID, Title, GameRating) VALUES (5, 'ZenoDrop', 4.89);
INSERT INTO GAMES (GameID, Title, GameRating) VALUES (6, 'OrbTrek', 1.56);
INSERT INTO GAMES (GameID, Title, GameRating) VALUES (7, 'ChronoVR', 4.76);
INSERT INTO GAMES (GameID, Title, GameRating) VALUES (8, 'EchoWars', 3.98);
INSERT INTO GAMES (GameID, Title, GameRating) VALUES (9, 'VoidHunt', 1.72);
INSERT INTO GAMES (GameID, Title, GameRating) VALUES (10, 'AstroRun', 3.63);

-- WORKS_ON
INSERT INTO WORKS_ON (DevID, GameID, Role) VALUES (4, 3, 'Lead');
INSERT INTO WORKS_ON (DevID, GameID, Role) VALUES (2, 1, 'Designer');
INSERT INTO WORKS_ON (DevID, GameID, Role) VALUES (10, 8, 'Lead');
INSERT INTO WORKS_ON (DevID, GameID, Role) VALUES (2, 10, 'Designer');
INSERT INTO WORKS_ON (DevID, GameID, Role) VALUES (5, 7, 'Programmer');
INSERT INTO WORKS_ON (DevID, GameID, Role) VALUES (5, 6, 'Designer');
INSERT INTO WORKS_ON (DevID, GameID, Role) VALUES (3, 5, 'Programmer');
INSERT INTO WORKS_ON (DevID, GameID, Role) VALUES (7, 2, 'Lead');
INSERT INTO WORKS_ON (DevID, GameID, Role) VALUES (1, 9, 'Designer');
INSERT INTO WORKS_ON (DevID, GameID, Role) VALUES (1, 4, 'Lead');

-- The rest (GAME_GENRES, PLAYERS, REVIEWS, ASSETS, TESTERS, TESTERS_ACCESS, EVENTS, BUG_REPORTS) are ready too. Let me know if you want the full continuation.

-- GAME_GENRES
INSERT INTO GAME_GENRES (GameID, Genre) VALUES (6, 'Action');
INSERT INTO GAME_GENRES (GameID, Genre) VALUES (9, 'RPG');
INSERT INTO GAME_GENRES (GameID, Genre) VALUES (3, 'Puzzle');
INSERT INTO GAME_GENRES (GameID, Genre) VALUES (2, 'Strategy');
INSERT INTO GAME_GENRES (GameID, Genre) VALUES (4, 'Adventure');
INSERT INTO GAME_GENRES (GameID, Genre) VALUES (5, 'Action');
INSERT INTO GAME_GENRES (GameID, Genre) VALUES (1, 'RPG');
INSERT INTO GAME_GENRES (GameID, Genre) VALUES (7, 'Puzzle');
INSERT INTO GAME_GENRES (GameID, Genre) VALUES (8, 'Strategy');
INSERT INTO GAME_GENRES (GameID, Genre) VALUES (10, 'Adventure');

-- PLAYERS
INSERT INTO PLAYERS (PlayerID, FirstName, LastName, RegisterDate, Email, Password) VALUES (1, 'Fiona', 'Julia', '2020-12-03', 'fiona62@x.io', 'pword1');
INSERT INTO PLAYERS (PlayerID, FirstName, LastName, RegisterDate, Email, Password) VALUES (2, 'Hannah', 'Alice', '2023-10-14', 'hannah19@x.io', 'pword2');
INSERT INTO PLAYERS (PlayerID, FirstName, LastName, RegisterDate, Email, Password) VALUES (3, 'Charlie', 'Fiona', '2024-10-06', 'charlie80@x.io', 'pword3');
INSERT INTO PLAYERS (PlayerID, FirstName, LastName, RegisterDate, Email, Password) VALUES (4, 'George', 'Bob', '2022-06-27', 'george33@x.io', 'pword4');
INSERT INTO PLAYERS (PlayerID, FirstName, LastName, RegisterDate, Email, Password) VALUES (5, 'Charlie', 'George', '2023-03-17', 'charlie56@x.io', 'pword5');
INSERT INTO PLAYERS (PlayerID, FirstName, LastName, RegisterDate, Email, Password) VALUES (6, 'Bob', 'Diana', '2023-12-01', 'bob13@x.io', 'pword6');
INSERT INTO PLAYERS (PlayerID, FirstName, LastName, RegisterDate, Email, Password) VALUES (7, 'Ian', 'Charlie', '2021-07-20', 'ian61@x.io', 'pword7');
INSERT INTO PLAYERS (PlayerID, FirstName, LastName, RegisterDate, Email, Password) VALUES (8, 'George', 'Julia', '2022-05-12', 'george67@x.io', 'pword8');
INSERT INTO PLAYERS (PlayerID, FirstName, LastName, RegisterDate, Email, Password) VALUES (9, 'Charlie', 'Hannah', '2021-02-04', 'charlie94@x.io', 'pword9');
INSERT INTO PLAYERS (PlayerID, FirstName, LastName, RegisterDate, Email, Password) VALUES (10, 'Alice', 'Bob', '2024-05-24', 'alice63@x.io', 'pword10');

-- REVIEWS
INSERT INTO REVIEWS (ReviewID, PlayerID, GameID, Review, Rating, ReviewDate) VALUES (1, 5, 7, 'Review text 1', 3.14, '2024-06-04');
INSERT INTO REVIEWS (ReviewID, PlayerID, GameID, Review, Rating, ReviewDate) VALUES (2, 9, 5, 'Review text 2', 2.48, '2021-06-30');
INSERT INTO REVIEWS (ReviewID, PlayerID, GameID, Review, Rating, ReviewDate) VALUES (3, 6, 2, 'Review text 3', 4.35, '2021-09-23');
INSERT INTO REVIEWS (ReviewID, PlayerID, GameID, Review, Rating, ReviewDate) VALUES (4, 10, 6, 'Review text 4', 3.87, '2024-06-24');
INSERT INTO REVIEWS (ReviewID, PlayerID, GameID, Review, Rating, ReviewDate) VALUES (5, 7, 9, 'Review text 5', 4.09, '2022-09-28');
INSERT INTO REVIEWS (ReviewID, PlayerID, GameID, Review, Rating, ReviewDate) VALUES (6, 1, 10, 'Review text 6', 3.63, '2023-06-24');
INSERT INTO REVIEWS (ReviewID, PlayerID, GameID, Review, Rating, ReviewDate) VALUES (7, 6, 1, 'Review text 7', 3.62, '2023-12-18');
INSERT INTO REVIEWS (ReviewID, PlayerID, GameID, Review, Rating, ReviewDate) VALUES (8, 3, 3, 'Review text 8', 3.89, '2023-01-10');
INSERT INTO REVIEWS (ReviewID, PlayerID, GameID, Review, Rating, ReviewDate) VALUES (9, 4, 4, 'Review text 9', 1.6, '2023-03-23');
INSERT INTO REVIEWS (ReviewID, PlayerID, GameID, Review, Rating, ReviewDate) VALUES (10, 2, 8, 'Review text 10', 3.87, '2023-01-19');

-- ASSETS
INSERT INTO ASSETS (AssetID, GameID, AssetName, AssetType, DevID, UploadDate) VALUES (1, 2, 'Asset1', 'Model', 3, '2021-02-21');
INSERT INTO ASSETS (AssetID, GameID, AssetName, AssetType, DevID, UploadDate) VALUES (2, 3, 'Asset2', 'Sound', 1, '2021-05-10');
INSERT INTO ASSETS (AssetID, GameID, AssetName, AssetType, DevID, UploadDate) VALUES (3, 9, 'Asset3', 'Image', 4, '2020-07-14');
INSERT INTO ASSETS (AssetID, GameID, AssetName, AssetType, DevID, UploadDate) VALUES (4, 6, 'Asset4', 'Model', 1, '2021-06-24');
INSERT INTO ASSETS (AssetID, GameID, AssetName, AssetType, DevID, UploadDate) VALUES (5, 10, 'Asset5', 'Image', 7, '2024-03-26');
INSERT INTO ASSETS (AssetID, GameID, AssetName, AssetType, DevID, UploadDate) VALUES (6, 6, 'Asset6', 'Model', 6, '2023-06-10');
INSERT INTO ASSETS (AssetID, GameID, AssetName, AssetType, DevID, UploadDate) VALUES (7, 7, 'Asset7', 'Sound', 3, '2022-06-01');
INSERT INTO ASSETS (AssetID, GameID, AssetName, AssetType, DevID, UploadDate) VALUES (8, 5, 'Asset8', 'Sound', 2, '2020-12-21');
INSERT INTO ASSETS (AssetID, GameID, AssetName, AssetType, DevID, UploadDate) VALUES (9, 10, 'Asset9', 'Sound', 9, '2023-07-08');
INSERT INTO ASSETS (AssetID, GameID, AssetName, AssetType, DevID, UploadDate) VALUES (10, 8, 'Asset10', 'Model', 5, '2022-01-19');

-- TESTERS
INSERT INTO TESTERS (TesterID, FirstName, LastName, RegisterDate, Email, Password, IsLicensed) VALUES (1, 'Fiona', 'Hannah', '2024-05-20', 'fiona45@x.io', 'test1', 0);
INSERT INTO TESTERS (TesterID, FirstName, LastName, RegisterDate, Email, Password, IsLicensed) VALUES (2, 'George', 'Julia', '2022-04-04', 'george23@x.io', 'test2', 1);
INSERT INTO TESTERS (TesterID, FirstName, LastName, RegisterDate, Email, Password, IsLicensed) VALUES (3, 'Charlie', 'Ian', '2024-02-20', 'charlie31@x.io', 'test3', 1);
INSERT INTO TESTERS (TesterID, FirstName, LastName, RegisterDate, Email, Password, IsLicensed) VALUES (4, 'Ian', 'Bob', '2022-06-11', 'ian96@x.io', 'test4', 1);
INSERT INTO TESTERS (TesterID, FirstName, LastName, RegisterDate, Email, Password, IsLicensed) VALUES (5, 'Alice', 'Alice', '2021-12-25', 'alice12@x.io', 'test5', 0);
INSERT INTO TESTERS (TesterID, FirstName, LastName, RegisterDate, Email, Password, IsLicensed) VALUES (6, 'Charlie', 'George', '2024-01-09', 'charlie88@x.io', 'test6', 1);
INSERT INTO TESTERS (TesterID, FirstName, LastName, RegisterDate, Email, Password, IsLicensed) VALUES (7, 'Julia', 'Diana', '2022-03-01', 'julia55@x.io', 'test7', 0);
INSERT INTO TESTERS (TesterID, FirstName, LastName, RegisterDate, Email, Password, IsLicensed) VALUES (8, 'Diana', 'Ian', '2020-09-02', 'diana67@x.io', 'test8', 0);
INSERT INTO TESTERS (TesterID, FirstName, LastName, RegisterDate, Email, Password, IsLicensed) VALUES (9, 'Bob', 'Charlie', '2023-11-23', 'bob78@x.io', 'test9', 1);
INSERT INTO TESTERS (TesterID, FirstName, LastName, RegisterDate, Email, Password, IsLicensed) VALUES (10, 'Ethan', 'Fiona', '2021-10-07', 'ethan82@x.io', 'test10', 1);


-- TESTERS_ACCESS
INSERT INTO TESTERS_ACCESS (GameID, TesterID, IsAllowed) VALUES (3, 1, 1);
INSERT INTO TESTERS_ACCESS (GameID, TesterID, IsAllowed) VALUES (1, 3, 0);
INSERT INTO TESTERS_ACCESS (GameID, TesterID, IsAllowed) VALUES (7, 4, 1);
INSERT INTO TESTERS_ACCESS (GameID, TesterID, IsAllowed) VALUES (10, 2, 1);
INSERT INTO TESTERS_ACCESS (GameID, TesterID, IsAllowed) VALUES (6, 6, 1);
INSERT INTO TESTERS_ACCESS (GameID, TesterID, IsAllowed) VALUES (8, 5, 0);
INSERT INTO TESTERS_ACCESS (GameID, TesterID, IsAllowed) VALUES (4, 7, 1);
INSERT INTO TESTERS_ACCESS (GameID, TesterID, IsAllowed) VALUES (2, 9, 0);
INSERT INTO TESTERS_ACCESS (GameID, TesterID, IsAllowed) VALUES (9, 10, 1);
INSERT INTO TESTERS_ACCESS (GameID, TesterID, IsAllowed) VALUES (5, 8, 0);

-- EVENTS
INSERT INTO EVENTS (EventID, Description, EventStartDate, EventEndDate) VALUES (1, 'Event1', '2021-08-15', '2021-08-21');
INSERT INTO EVENTS (EventID, Description, EventStartDate, EventEndDate) VALUES (2, 'Event2', '2023-02-05', '2023-02-07');
INSERT INTO EVENTS (EventID, Description, EventStartDate, EventEndDate) VALUES (3, 'Event3', '2020-07-03', '2020-07-10');
INSERT INTO EVENTS (EventID, Description, EventStartDate, EventEndDate) VALUES (4, 'Event4', '2021-11-24', '2021-12-03');
INSERT INTO EVENTS (EventID, Description, EventStartDate, EventEndDate) VALUES (5, 'Event5', '2024-10-03', '2024-10-07');
INSERT INTO EVENTS (EventID, Description, EventStartDate, EventEndDate) VALUES (6, 'Event6', '2020-01-31', '2020-02-08');
INSERT INTO EVENTS (EventID, Description, EventStartDate, EventEndDate) VALUES (7, 'Event7', '2023-06-19', '2023-06-26');
INSERT INTO EVENTS (EventID, Description, EventStartDate, EventEndDate) VALUES (8, 'Event8', '2022-12-08', '2022-12-11');
INSERT INTO EVENTS (EventID, Description, EventStartDate, EventEndDate) VALUES (9, 'Event9', '2023-09-03', '2023-09-10');
INSERT INTO EVENTS (EventID, Description, EventStartDate, EventEndDate) VALUES (10, 'Event10', '2024-04-28', '2024-05-01');

-- BUG_REPORTS
INSERT INTO BUG_REPORTS (ReportID, GameID, TesterID, Report) VALUES (1, 3, 7, 'Bug report 1');
INSERT INTO BUG_REPORTS (ReportID, GameID, TesterID, Report) VALUES (2, 8, 6, 'Bug report 2');
INSERT INTO BUG_REPORTS (ReportID, GameID, TesterID, Report) VALUES (3, 9, 2, 'Bug report 3');
INSERT INTO BUG_REPORTS (ReportID, GameID, TesterID, Report) VALUES (4, 2, 10, 'Bug report 4');
INSERT INTO BUG_REPORTS (ReportID, GameID, TesterID, Report) VALUES (5, 7, 3, 'Bug report 5');
INSERT INTO BUG_REPORTS (ReportID, GameID, TesterID, Report) VALUES (6, 5, 5, 'Bug report 6');
INSERT INTO BUG_REPORTS (ReportID, GameID, TesterID, Report) VALUES (7, 1, 9, 'Bug report 7');
INSERT INTO BUG_REPORTS (ReportID, GameID, TesterID, Report) VALUES (8, 4, 8, 'Bug report 8');
INSERT INTO BUG_REPORTS (ReportID, GameID, TesterID, Report) VALUES (9, 10, 1, 'Bug report 9');
INSERT INTO BUG_REPORTS (ReportID, GameID, TesterID, Report) VALUES (10, 6, 4, 'Bug report 10');
