UPDATE Abouts SET RoomCount = (SELECT COUNT(*) FROM Rooms),
StaffCount = (SELECT COUNT(*) FROM Staffs),
CustomerCount = (SELECT COUNT(*) FROM Guests)
SELECT * FROM Abouts;

CREATE TRIGGER Roomincrease
ON Rooms
AFTER INSERT
AS
UPDATE Abouts SET RoomCount = RoomCount + 1;


CREATE TRIGGER RoomDecrease
ON Rooms
AFTER DELETE
AS
UPDATE Abouts SET RoomCount = RoomCount - 1;

--------------------------------------


CREATE TRIGGER StaffSincrease
ON Staffs
AFTER INSERT
AS
UPDATE Abouts SET StaffCount = StaffCount + 1;

CREATE TRIGGER StaffSDecrease
ON Staffs
AFTER DELETE
AS
UPDATE Abouts SET StaffCount = StaffCount - 1;

-----------------------------------------

CREATE TRIGGER Guestsincrease
ON Guests
AFTER INSERT
AS
UPDATE Abouts SET CustomerCount = CustomerCount + 1;

CREATE TRIGGER GuestsDecrease
ON Guests
AFTER DELETE
AS
UPDATE Abouts SET CustomerCount = CustomerCount - 1;

-----------------------------------------

