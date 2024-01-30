DROP DATABASE IF EXISTS DB_Library;

CREATE DATABASE DB_Library;

USE DB_Library;

CREATE TABLE Author
(
    authorID INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(200)
);


CREATE TABLE Book
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    title VARCHAR(200) NOT NULL,
    authorID INT
    CONSTRAINT fk_auhtor FOREIGN KEY (authorID) REFERENCES Author(authorID)
);

CREATE VIEW BookAuthorInfo
AS
    SELECT b.ID, b.title, b.authorID, a.name
    FROM book b JOIN Author a ON a.authorID = b.authorID;
GO

INSERT INTO Author (name) VALUES('Gabriel García Márquez');
INSERT INTO Book(title, authorID) VALUES ('Cien años de soledad',1);
INSERT INTO Author (name) VALUES('Miguel de Cervantes Saavedra');
INSERT INTO Book(title, authorID) VALUES ('El Quijote',2);

SELECT * FROM BookAuthorInfo;