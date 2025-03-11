 
-- CREATE THE DATABASE
CREATE DATABASE AirCraft; 

use AirCraft

-- Create aircraft table
Create Table AirCraft(
    ID INT PRIMARY KEY IDENTITY(1 ,1),
    Capacity int not null, 
    Model varchar(50) NOT Null, 
    MajoPilot varchar(30), 
    Assistant varchar(20), 
    Host1 varchar(30), 
    Host2 varchar(30),
    AirlineID int, 
);

-- Create Airline table
CREATE TABLE Airline 
(
    ID INT PRIMARY KEY Identity, 
    Name varchar(30) not null, 
    Address varchar(100), 
    ContactPerson varchar(50),
)

-- Create Airline Phone
Create Table AirlinePhone
(
    AirlineID int REFERENCES Airline(ID),
    Phones varchar(20), 
    PRIMARY key(AirlineID, Phones)
)

-- Create Transaction table
Create Table Transactions 
(
    ID INT Primary key identity, 
    Description varchar(200) ,
    Amount money not null, 
    TransactionDate Date, 
    AirlineID int not null REFERENCES Airline(ID),
)

-- Create Employee table
Create Table Employees
(
    EmployeeID INT PRIMARY KEY IDENTITY, 
    EmployeeName varchar(50) not null, 
    Address varchar(100),
    Gender char(1), 
    Position varchar(40) not null, 
    BD_Year int, 
    BD_Month int, 
    BD_Day int, 
    AirlineID int not null REFERENCES Airline(ID)
)

-- Create Employee Qualifications table
Create table EmployeeQualifications 
(
    EmployeeId int REFERENCES Employees(EmployeeID),
    Qualifications varchar(50), 
    PRIMARY KEY (EmployeeID , Qualifications)
)

-- Create Route table
Create TABLE Route 
(
    ID INT PRIMARY KEY IDENTITY, 
    Distance VARCHAR(50) ,
    Description VARCHAR(max) ,
    Origin VARCHAR(50), 
    Classification char(1)
)

-- Aircraft Route table
Create TABLE AircraftRoute 
(
    AircraftID INT REFERENCES Aircraft(ID), 
    RouteID INT REFERENCES Route(ID), 
    PRIMARY key (AircraftID, RouteID), 
    DepartureTime INT , 
    NumberOfPassiners INT, 
    Price money, 
    Arrival Date, 
)

alter TABLE AirCraft
add constraint FK_Owns foreign KEY (ID) REFERENCES  Airline(ID)

DROP TABLE AirCraft
