-- Создание таблицы Classes
CREATE TABLE Classes (
  Id INT PRIMARY KEY IDENTITY(1,1),
  ClassNumber INT NOT NULL,
  ClassLetter NVARCHAR(1) NOT NULL
);

-- Создание таблицы Subjects
CREATE TABLE Subjects (
  Id INT PRIMARY KEY IDENTITY(1,1),
  Name NVARCHAR(50) NOT NULL
);

-- Создание таблицы Students
CREATE TABLE Students (
  Id INT PRIMARY KEY IDENTITY(1,1),
  FullName NVARCHAR(50) NOT NULL,
  BirthDate DATE NOT NULL,
  ClassId INT NOT NULL,
  PhoneNumber NVARCHAR(20),
  Email NVARCHAR(50),
  Photo NVARCHAR(50),
  FOREIGN KEY (ClassId) REFERENCES Classes(Id)
);

-- Создание таблицы Teachers
CREATE TABLE Teachers (
  Id INT PRIMARY KEY IDENTITY(1,1),
  FullName NVARCHAR(50) NOT NULL,
  BirthDate DATE NOT NULL,
  PhoneNumber NVARCHAR(20),
  Email NVARCHAR(50),
  Photo NVARCHAR(50),
  SubjectId INT,
  FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
);

-- Создание таблицы Lessons
CREATE TABLE Lessons (
  Id INT PRIMARY KEY IDENTITY(1,1),
  LessonName NVARCHAR(50) NOT NULL,
  LessonDate DATE NOT NULL,
  LessonTime TIME NOT NULL,
  TeacherId INT NOT NULL,
  FOREIGN KEY (TeacherId) REFERENCES Teachers(Id)
);

-- Создание таблицы Grades
CREATE TABLE Grades (
  Id INT PRIMARY KEY IDENTITY(1,1),
  StudentId INT NOT NULL,
  LessonId INT NOT NULL,
  GradeValue INT NOT NULL,
  FOREIGN KEY (StudentId) REFERENCES Students(Id),
  FOREIGN KEY (LessonId) REFERENCES Lessons(Id)
);

-- Создание таблицы Attendance
CREATE TABLE Attendance (
  Id INT PRIMARY KEY IDENTITY(1,1),
  StudentId INT NOT NULL,
  LessonId INT NOT NULL,
  AttendanceValue INT NOT NULL,
  FOREIGN KEY (StudentId) REFERENCES Students(Id),
  FOREIGN KEY (LessonId) REFERENCES Lessons(Id)
);
