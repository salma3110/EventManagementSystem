CREATE DATABASE EventManagementDB;
GO
USE EventManagementDB;
GO

CREATE TABLE Venue (
    venue_id    INT PRIMARY KEY IDENTITY(1,1),
    name        VARCHAR(100) NOT NULL,
    street_name VARCHAR(100) NOT NULL,
    city        VARCHAR(50)  NOT NULL,
    capacity    INT          NOT NULL CHECK (capacity > 0)
);

CREATE TABLE Patron (
    patron_id    INT PRIMARY KEY IDENTITY(1,1),
    fname        VARCHAR(50)  NOT NULL,
    lname        VARCHAR(50)  NOT NULL,
    email        VARCHAR(100) NOT NULL UNIQUE,
    phone_number VARCHAR(15)  NULL,
    password_hash VARCHAR(255) NOT NULL DEFAULT 'defaultpass'
);

CREATE TABLE Staff (
    staff_id INT PRIMARY KEY IDENTITY(1,1),
    fname    VARCHAR(50) NOT NULL,
    lname    VARCHAR(50) NOT NULL
);

CREATE TABLE Gathering (
    gathering_id INT PRIMARY KEY IDENTITY(1,1),
    title        VARCHAR(100) NOT NULL,
    date         DATE         NOT NULL,
    category     VARCHAR(50)  NOT NULL,
    venue_id     INT          NOT NULL,
    FOREIGN KEY (venue_id) REFERENCES Venue(venue_id)
);

CREATE TABLE EntryClass (
    class_id         INT           PRIMARY KEY IDENTITY(1,1),
    class_name       VARCHAR(50)   NOT NULL,
    price            DECIMAL(10,2) NOT NULL CHECK (price >= 0),
    seats_allocation INT           NOT NULL CHECK (seats_allocation > 0),
    gathering_id     INT           NOT NULL,
    FOREIGN KEY (gathering_id) REFERENCES Gathering(gathering_id)
);

CREATE TABLE EntryPass (
    pass_id       INT  PRIMARY KEY IDENTITY(1,1),
    purchase_date DATE NOT NULL,
    patron_id     INT  NOT NULL,
    class_id      INT  NOT NULL,
    FOREIGN KEY (patron_id) REFERENCES Patron(patron_id),
    FOREIGN KEY (class_id)  REFERENCES EntryClass(class_id),
    CONSTRAINT UQ_EntryPass UNIQUE (patron_id, class_id)
);

CREATE TABLE GatheringStaff (
    gathering_id INT         NOT NULL,
    staff_id     INT         NOT NULL,
    role         VARCHAR(50) NOT NULL,
    PRIMARY KEY (gathering_id, staff_id),
    FOREIGN KEY (gathering_id) REFERENCES Gathering(gathering_id),
    FOREIGN KEY (staff_id)     REFERENCES Staff(staff_id),
    CONSTRAINT CHK_Role CHECK (role IN ('Coordinator', 'Primary Technician', 'Staff'))
); 
