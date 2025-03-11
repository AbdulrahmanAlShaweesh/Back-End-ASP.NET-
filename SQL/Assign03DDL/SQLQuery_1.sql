
-- CREATE THE DATABASE
CREATE DATABASE AirCraft; 

-- Create aircraft table
Create Table AirCraft(
    ID INT PRIMARY KEY IDENTITY(1 ,1),
    Capacity int not null, 
    Model varchar(50) NOT Null, 
    
);