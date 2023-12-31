USE [master]
GO
/****** Object:  Database [DoctorDatabase]    Script Date: 8/7/2023 3:26:21 PM ******/
CREATE DATABASE [DoctorDatabase]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'DoctorDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DoctorDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'DoctorDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DoctorDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
-- WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DoctorDatabase] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DoctorDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DoctorDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DoctorDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DoctorDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DoctorDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DoctorDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [DoctorDatabase] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DoctorDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DoctorDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DoctorDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DoctorDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DoctorDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DoctorDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DoctorDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DoctorDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DoctorDatabase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DoctorDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DoctorDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DoctorDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DoctorDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DoctorDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DoctorDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DoctorDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DoctorDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DoctorDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [DoctorDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DoctorDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DoctorDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DoctorDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DoctorDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DoctorDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DoctorDatabase] SET QUERY_STORE = ON
GO
ALTER DATABASE [DoctorDatabase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DoctorDatabase]
GO
/****** Object:  FullTextCatalog [appointmenttable]    Script Date: 8/7/2023 3:26:22 PM ******/
CREATE FULLTEXT CATALOG [appointmenttable] WITH ACCENT_SENSITIVITY = ON
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 8/7/2023 3:26:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Appointments](
	[AppointmentID] [bigint] IDENTITY(18399,1) NOT NULL,
	[PatientName] [varchar](255) NOT NULL,
	[MedicalIssue] [varchar](255) NULL,
	[DoctorToVisit] [varchar](255) NULL,
	[DoctorAvailableTime] [nvarchar](150) NULL,
	[AppointmentTime] [datetime] NULL,
	[AppointmentStatus] [varchar](50) NULL,
	[PaymentStatus] [varchar](50) NULL,
	[Notes] [text] NULL,
 CONSTRAINT [PK__Appointm__8ECDFCA293C4AD32] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diseases]    Script Date: 8/7/2023 3:26:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diseases](
	[DiseaseID] [int] IDENTITY(1,1) NOT NULL,
	[DiseaseName] [varchar](255) NOT NULL,
	[SuitableDoctor] [int] NULL,
 CONSTRAINT [PK__Diseases__69B533A90A0B5120] PRIMARY KEY CLUSTERED 
(
	[DiseaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 8/7/2023 3:26:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctors](
	[DoctorID] [int] IDENTITY(1,101) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Specialised] [varchar](255) NULL,
	[Qualification] [varchar](255) NULL,
	[AvailableFrom] [time](7) NULL,
	[AvailableTo] [time](7) NULL,
	[AvailableDays] [varchar](50) NULL,
	[ContactNumber] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[ClinicAddress] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18399, N'Rajesh Kumar', N'Heart Disease', N'Dr. Devi Shetty', N'09:00:00.0000000', CAST(N'2023-08-05T10:30:00.000' AS DateTime), N'Scheduled', N'Pending', N'Follow-up visit')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18400, N'Priya Sharma', N'Lung Infection', N'Dr. Randeep Guleria', N'11:00:00.0000000', CAST(N'2023-08-05T11:45:00.000' AS DateTime), N'Scheduled', N'Pending', N'Cough and fever')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18401, N'Amit Patel', N'Diabetes', N'Dr. Devi Prasad Shetty', N'08:00:00.0000000', CAST(N'2023-08-06T09:15:00.000' AS DateTime), N'Scheduled', N'Pending', N'Checkup and medication')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18402, N'Sneha Joshi', N'Asthma', N'Dr. Farokh Udwadia', N'10:30:00.0000000', CAST(N'2023-08-06T12:00:00.000' AS DateTime), N'Scheduled', N'Pending', N'Inhaler prescription')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18403, N'Anita Verma', N'Pregnancy', N'Dr. Nandita Palshetkar', N'09:00:00.0000000', CAST(N'2023-08-07T10:00:00.000' AS DateTime), N'Scheduled', N'Pending', N'Second trimester checkup')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18404, N'Rahul Singh', N'Skin Conditions', N'Dr. Mohan Thomas', N'10:00:00.0000000', CAST(N'2023-08-07T11:30:00.000' AS DateTime), N'Scheduled', N'Pending', N'Rash and itching')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18405, N'Deepika Nair', N'COVID-19', N'Dr. Suniti Solomon', N'11:00:00.0000000', CAST(N'2023-08-08T10:45:00.000' AS DateTime), N'Scheduled', N'Pending', N'Symptoms and test')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18406, N'Vikram Iyer', N'Cancer', N'Dr. Ashok Seth', N'09:30:00.0000000', CAST(N'2023-08-08T12:15:00.000' AS DateTime), N'Scheduled', N'Pending', N'Chemotherapy session')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18407, N'Neha Menon', N'Anemia', N'Dr. Mammen Chandy', N'08:30:00.0000000', CAST(N'2023-08-09T09:30:00.000' AS DateTime), N'Scheduled', N'Pending', N'Fatigue and weakness')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18408, N'Karan Sharma', N'Obesity', N'Dr. Naresh Trehan', N'08:00:00.0000000', CAST(N'2023-08-09T10:00:00.000' AS DateTime), N'Scheduled', N'Pending', N'Weight management')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18409, N'Sai Kumar', N'Cancer', N'Dr. Ashok Seth', N'09:30:00 to 17:30:00 on Wednesday,Thursday,Friday', CAST(N'2023-08-12T13:03:00.000' AS DateTime), N'Scheduled', N'Pending', N'The End')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18410, N'Sukumar', N'Heart Disease', N'Dr. Devi Shetty', N'09:00:00 to 17:00:00 on Monday,Tuesday,Wednesday,Thursday,Friday', CAST(N'2023-08-11T13:11:00.000' AS DateTime), N'Scheduled', N'Pending', N'Checkup ')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18411, N'Suresh', N'Anemia', N'Dr. Mammen Chandy', N'08:30:00 to 16:30:00 on Monday,Wednesday,Friday', CAST(N'2023-08-16T14:13:00.000' AS DateTime), N'Scheduled', N'Pending', N'Checkup ')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18412, N'Urjith Patel', N'Diabetes', N'Dr. Devi Prasad Shetty', N'08:00:00 to 16:00:00 on Monday,Tuesday,Wednesday,Thursday,Friday', CAST(N'2023-08-09T13:17:00.000' AS DateTime), N'Scheduled', N'Pending', N'Regular Checkup')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18413, N'Ramesh', N'Skin Conditions', N'Dr. Mohan Thomas', N'09:00:00 to 17:00:00 on Tuesday,Thursday', CAST(N'2023-08-17T13:22:00.000' AS DateTime), N'Scheduled', N'Pending', N'Therapy Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18414, N'Hari', N'Obesity', N'Dr. Naresh Trehan', N'08:00:00 to 16:00:00 on Monday,Tuesday,Wednesday,Thursday,Friday', CAST(N'2023-08-15T15:07:00.000' AS DateTime), N'Scheduled', N'Pending', N'Treatment Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18415, N'Tony', N'COVID-19', N'Dr. Suniti Solomon', N'11:00:00 to 19:00:00 on Tuesday,Thursday', CAST(N'2023-08-18T02:01:00.000' AS DateTime), N'Scheduled', N'Pending', N'Treatment Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18417, N'nick', N'Heart Disease', N'Dr. Devi Shetty', N'09:00:00 to 17:00:00 on Monday,Tuesday,Wednesday,Thursday,Friday', CAST(N'2023-08-12T10:53:00.000' AS DateTime), N'Scheduled', N'Pending', N'Treatment Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18418, N'shawlett', N'Skin Conditions', N'Dr. Mohan Thomas', N'09:00:00 to 17:00:00 on Tuesday,Thursday', CAST(N'2023-08-08T11:05:00.000' AS DateTime), N'Scheduled', N'Pending', N'Regular Checkup')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18423, N'siphon', N'General Checkup', N'Dr. Shawlett', N'10:00:00 to 19:00:00 on Monday to Friday', CAST(N'2023-08-07T14:30:00.000' AS DateTime), N'Scheduled', N'Pending', N'Therapy Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18424, N'Robert Downey', N'Asthma', N'Dr. Farokh Udwadia', N'10:30:00 to 18:30:00 on Wednesday,Friday', CAST(N'2023-08-09T00:34:00.000' AS DateTime), N'Scheduled', N'Pending', NULL)
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18425, N'Sohail', N'General Checkup', N'Dr. Shawlett', N'10:00:00 to 19:00:00 on Monday to Friday', CAST(N'2023-08-10T12:38:00.000' AS DateTime), N'Scheduled', N'Pending', N'Treatment Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18426, N'Prashanth neel', N'Skin Conditions', N'Dr. Mohan Thomas', N'09:00:00 to 17:00:00 on Tuesday,Thursday', CAST(N'2023-08-05T13:51:00.000' AS DateTime), N'Scheduled', N'Pending', N'Therapy Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18427, N'Sai', N'Asthma', N'Dr. Farokh Udwadia', N'10:30:00 to 18:30:00 on Wednesday,Friday', CAST(N'2023-08-16T14:44:00.000' AS DateTime), N'Scheduled', N'Pending', N'Regular Checkup')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18428, N'David', N'Obesity', N'Dr. Naresh Trehan', N'08:00:00 to 16:00:00 on Monday,Tuesday,Wednesday,Thursday,Friday', CAST(N'2023-08-18T14:55:00.000' AS DateTime), N'Scheduled', N'Pending', N'Treatment Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18429, N'Dravid', N'COVID-19', N'Dr. Suniti Solomon', N'11:00:00 to 19:00:00 on Tuesday,Thursday', CAST(N'2023-08-17T15:02:00.000' AS DateTime), N'Scheduled', N'Pending', N'Treatment Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18430, N'Dravid', N'COVID-19', N'Dr. Suniti Solomon', N'11:00:00 to 19:00:00 on Tuesday,Thursday', CAST(N'2023-08-17T15:02:00.000' AS DateTime), N'Scheduled', N'Pending', N'Treatment Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18431, N'Dravid', N'Heart Disease', N'Dr. Devi Shetty', N'09:00:00 to 17:00:00 on Monday,Tuesday,Wednesday,Thursday,Friday', CAST(N'2023-08-18T15:08:00.000' AS DateTime), N'Scheduled', N'Pending', N'Treatment Required')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18432, N'Dravid', N'Diabetes', N'Dr. Devi Prasad Shetty', N'08:00:00 to 16:00:00 on Monday,Tuesday,Wednesday,Thursday,Friday', CAST(N'2023-08-17T15:14:00.000' AS DateTime), N'Scheduled', N'Pending', N'Checkup ')
INSERT [dbo].[Appointments] ([AppointmentID], [PatientName], [MedicalIssue], [DoctorToVisit], [DoctorAvailableTime], [AppointmentTime], [AppointmentStatus], [PaymentStatus], [Notes]) VALUES (18433, N'shawlett', N'General Checkup', N'Dr. Shawlett', N'10:00:00 to 19:00:00 on Monday to Friday', CAST(N'2023-08-08T15:20:00.000' AS DateTime), N'Scheduled', N'Pending', NULL)
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO
SET IDENTITY_INSERT [dbo].[Diseases] ON 

INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (1, N'Heart Disease', 1)
INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (2, N'Lung Infection', 203)
INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (3, N'Cancer', 304)
INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (4, N'Anemia', 405)
INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (5, N'COVID-19', 506)
INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (6, N'Asthma', 607)
INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (7, N'Pregnancy', 708)
INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (8, N'Skin Conditions', 809)
INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (9, N'Diabetes', 910)
INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (10, N'Obesity', 102)
INSERT [dbo].[Diseases] ([DiseaseID], [DiseaseName], [SuitableDoctor]) VALUES (11, N'General Checkup', 1011)
SET IDENTITY_INSERT [dbo].[Diseases] OFF
GO
SET IDENTITY_INSERT [dbo].[Doctors] ON 

INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (1, N'Dr. Devi Shetty', N'Cardiology', N'MBBS, MS, FRCS', CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time), N'Monday,Tuesday,Wednesday,Thursday,Friday', N'+91-9876543210', N'devi.shetty@example.com', N'123 Cardiac Lane, Bangalore')
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (102, N'Dr. Naresh Trehan', N'Cardiothoracic Surgery', N'MBBS, MS, FRCS', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), N'Monday,Tuesday,Wednesday,Thursday,Friday', N'+91-8765432109', N'naresh.trehan@example.com', N'456 Heart Avenue, Delhi')
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (203, N'Dr. Randeep Guleria', N'Pulmonology', N'MBBS, MD', CAST(N'10:00:00' AS Time), CAST(N'18:00:00' AS Time), N'Tuesday,Thursday', N'+91-7654321098', N'randeep.guleria@example.com', N'789 Lung Street, Delhi')
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (304, N'Dr. Ashok Seth', N'Interventional Cardiology', N'MBBS, MD', CAST(N'09:30:00' AS Time), CAST(N'17:30:00' AS Time), N'Wednesday,Thursday,Friday', N'+91-6543210987', N'ashok.seth@example.com', N'101 Stent Road, Mumbai')
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (405, N'Dr. Mammen Chandy', N'Hematology', N'MBBS, MD', CAST(N'08:30:00' AS Time), CAST(N'16:30:00' AS Time), N'Monday,Wednesday,Friday', N'+91-5432109876', N'mammen.chandy@example.com', N'111 Blood Drive, Chennai')
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (506, N'Dr. Suniti Solomon', N'Infectious Diseases', N'MBBS, MD', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), N'Tuesday,Thursday', N'+91-4321098765', N'suniti.solomon@example.com', N'222 Immunity Lane, Chennai')
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (607, N'Dr. Farokh Udwadia', N'Respiratory Medicine', N'MBBS, MD', CAST(N'10:30:00' AS Time), CAST(N'18:30:00' AS Time), N'Wednesday,Friday', N'+91-3210987654', N'farokh.udwadia@example.com', N'333 Lung Health Avenue, Mumbai')
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (708, N'Dr. Nandita Palshetkar', N'Obstetrics and Gynecology', N'MBBS, MD', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), N'Monday,Wednesday,Thursday,Friday', N'+91-2109876543', N'nandita.palshetkar@example.com', N'444 Maternity Street, Mumbai')
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (809, N'Dr. Mohan Thomas', N'Plastic Surgery', N'MBBS, MS', CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time), N'Tuesday,Thursday', N'+91-1098765432', N'mohan.thomas@example.com', N'555 Beauty Avenue, Delhi')
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (910, N'Dr. Devi Prasad Shetty', N'Cardiac Surgery', N'MBBS, MS, FRCS', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), N'Monday,Tuesday,Wednesday,Thursday,Friday', N'+91-8765432101', N'deviprasad.shetty@example.com', N'666 Heartbeat Lane, Bangalore')
INSERT [dbo].[Doctors] ([DoctorID], [Name], [Specialised], [Qualification], [AvailableFrom], [AvailableTo], [AvailableDays], [ContactNumber], [Email], [ClinicAddress]) VALUES (1011, N'Dr. Shawlett', N'General Physician', N'MBBS,MD', CAST(N'10:00:00' AS Time), CAST(N'19:00:00' AS Time), N'Monday to Friday', N'+91-8765434567', N'shawlett@gmail.com', N'777 Bala Nagar,Hyderabad')
SET IDENTITY_INSERT [dbo].[Doctors] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uc_DiseaseName]    Script Date: 8/7/2023 3:26:22 PM ******/
ALTER TABLE [dbo].[Diseases] ADD  CONSTRAINT [uc_DiseaseName] UNIQUE NONCLUSTERED 
(
	[DiseaseName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uc_DoctorName]    Script Date: 8/7/2023 3:26:22 PM ******/
ALTER TABLE [dbo].[Doctors] ADD  CONSTRAINT [uc_DoctorName] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointments] ADD  CONSTRAINT [DF__Appointme__Appoi__5070F446]  DEFAULT ('Scheduled') FOR [AppointmentStatus]
GO
ALTER TABLE [dbo].[Appointments] ADD  CONSTRAINT [DF__Appointme__Payme__5165187F]  DEFAULT ('Pending') FOR [PaymentStatus]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK__Appointme__Medic__52593CB8] FOREIGN KEY([MedicalIssue])
REFERENCES [dbo].[Diseases] ([DiseaseName])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK__Appointme__Medic__52593CB8]
GO
ALTER TABLE [dbo].[Diseases]  WITH CHECK ADD  CONSTRAINT [FK_Diseases_Doctors] FOREIGN KEY([SuitableDoctor])
REFERENCES [dbo].[Doctors] ([DoctorID])
GO
ALTER TABLE [dbo].[Diseases] CHECK CONSTRAINT [FK_Diseases_Doctors]
GO
USE [master]
GO
ALTER DATABASE [DoctorDatabase] SET  READ_WRITE 
GO
