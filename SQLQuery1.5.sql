CREATE TABLE Hotel_Facilitet (
    FacilityNum int NOT NULL,
    Hotel_No int NOT NULL,
    FOREIGN KEY (FacilityNum) REFERENCES Facility(FacilityNum),
    FOREIGN KEY (Hotel_No) REFERENCES DemoHotel(Hotel_No)
);

CREATE TABLE Facility (
    FacilityNum int NOT NULL,
    Name varchar(50) NOT NULL,
    PRIMARY KEY (FacilityNum)
);