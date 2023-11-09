-- Tables
CREATE TABLE RoomTypes (
    type_id INT PRIMARY KEY,
    type_name VARCHAR(50),
    price DECIMAL(10, 2)
);

CREATE TABLE Rooms (
    room_id INT PRIMARY KEY,
    type_id INT,
    is_booked BIT,
    FOREIGN KEY (type_id) REFERENCES RoomTypes(type_id)
);

CREATE TABLE Customers (
    customer_id INT PRIMARY KEY,
    name VARCHAR(100)
);

CREATE TABLE Reservations (
    reservation_id INT PRIMARY KEY,
    customer_id INT,
    room_id INT,
    check_in_date DATE,
    check_out_date DATE,
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id),
    FOREIGN KEY (room_id) REFERENCES Rooms(room_id)
);

CREATE TABLE Payments (
    payment_id INT PRIMARY KEY,
    reservation_id INT,
    amount DECIMAL(10, 2),
    FOREIGN KEY (reservation_id) REFERENCES Reservations(reservation_id)
);

CREATE TABLE Spendings (
    spending_id INT PRIMARY KEY,
    reservation_id INT,
    description VARCHAR(255),
    amount DECIMAL(10, 2),
    FOREIGN KEY (reservation_id) REFERENCES Reservations(reservation_id)
);

-- 1.1 View: AllCustomerReservations
CREATE VIEW AllCustomerReservations AS
SELECT Customers.name, Reservations.check_in_date, Reservations.check_out_date
FROM Customers
JOIN Reservations ON Customers.customer_id = Reservations.customer_id;

-- 1.2 Procedure: GetRoomDetails
CREATE PROCEDURE GetRoomDetails
    @roomID INT
AS
BEGIN
    SELECT Rooms.room_id, RoomTypes.type_name, RoomTypes.price
    FROM Rooms
    JOIN RoomTypes ON Rooms.type_id = RoomTypes.type_id
    WHERE Rooms.room_id = @roomID;
END;

-- 1.3 Function: CalculateTotalAmount
CREATE FUNCTION CalculateTotalAmount
    (@reservationID INT)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @totalAmount DECIMAL(10, 2);

    SELECT @totalAmount = ISNULL(SUM(amount), 0)
    FROM Payments
    WHERE reservation_id = @reservationID;

    SELECT @totalAmount = @totalAmount + ISNULL(SUM(amount), 0)
    FROM Spendings
    WHERE reservation_id = @reservationID;

    RETURN @totalAmount;
END;

-- 1.4 Trigger: UpdateRoomStatusOnReservation
CREATE TRIGGER UpdateRoomStatusOnReservation
ON Reservations
AFTER INSERT
AS
BEGIN
    UPDATE Rooms
    SET is_booked = 1
    FROM inserted
    WHERE Rooms.room_id = inserted.room_id;
END;
