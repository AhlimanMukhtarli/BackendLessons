CREATE DATABASE AcademyDatabase;
USE AcademyDatabase;
CREATE TABLE Student (
    StudentID VARCHAR(20) PRIMARY KEY,
    FullName VARCHAR(255) NOT NULL,
    DateOfBirth DATE,
    GroupNo INT,
    Grade DECIMAL(4, 2)
	);
	INSERT INTO Student (StudentID, FullName, DateOfBirth, GroupNo, Grade)
VALUES ('S001', 'Ahilman Mukhtarli', '2000-01-15', 101, 85.5);

INSERT INTO Student (StudentID, FullName, DateOfBirth, GroupNo, Grade)
VALUES ('S002', 'Akbar Aliyev', '2001-03-20', 102, 92.0);
SELECT * FROM Student;
SELECT * FROM Student WHERE StudentID = 'S001';
UPDATE Student
SET Grade = 90.0
WHERE StudentID = 'S001';
DELETE FROM Student
WHERE StudentID = 'S002';