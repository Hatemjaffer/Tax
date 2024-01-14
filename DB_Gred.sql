use master
go
create database DB_Grad
go

--ÃœÊ· «·Õ«·…
CREATE TABLE [States]
(
	[States_ID] [int] IDENTITY(1,1)  PRIMARY KEY,--„› «Õ —∆Ì”Ì ··Õ«·…
	[States_Name] [nvarchar](50) NULL,--«”„ «·Õ«·…
	[id_User] [int] NULL--„› «Õ ›—⁄Ì ··„” Œœ„
);
--ÃœÊ· «·„”‰Œœ„Ì‰
CREATE TABLE Users
(   
	[UserID] int IDENTITY(1,1) PRIMARY KEY,--—ﬁ„ «·„” Œœ„
	[Name] [nvarchar](50) NULL,--«”„ „” Œœ„
	[Password] [nvarchar](20) NULL,--ﬂ·„Ê „—Ê—
	[PermissionType] [nvarchar](50) NULL,--’·«ÕÌ…
	[id_State] [int] NULL
);
go

--ÃœÊ· «·‰Ê⁄
CREATE TABLE [Type](
	[Type_ID] [int] IDENTITY(1,1)  PRIMARY KEY,--—ﬁ„ ‰Ê⁄ „› «Õ —∆Ì”Ì
	[Type_Name] [nvarchar](50) NULL,--«”„ «·Õ«·…
 
)
--ÃœÊ· «·«ﬁ”«„
CREATE TABLE Departments
(
	[DepartmentsID] [int] IDENTITY(1,1) PRIMARY KEY,--„› «Õ —Ì∆”Ì
	[DepartmentsNum] [nvarchar](50) NULL,--—ﬁ„ ﬁ”„
	[DepartmentsName] [nvarchar](150) NULL,--«”„ «·ﬁ”„
	[EdaraID] [int] NULL,--—ﬁ„ «·«œ«—…
	[State] [int] NULL,--—ﬁ„ «·Õ«·…
	[UserID] [int] NULL,-- —ﬁ„ «·„” Œœ„

)
go

CREATE TABLE [Edara](
	[EdaraID] [int] IDENTITY(1,1) PRIMARY KEY,--  »Ì  ⁄œÌ· Ã⁄·Â« „› «Õ —∆Ì”Ì ›Ì ﬂ· «·Ãœ«Ê·
	[EdaraName] [nvarchar](150) NULL,--«”„ «·«œ«—…
	[State] [tinyint] NULL,--Õ«·…
	[UserID] [int] NULL,-- «”„ «·„” Œœ„
)
go
--ÃœÊ· „Êÿ›Ì‰
CREATE TABLE [Employee](
	[Employee_ID] [int] IDENTITY(1,1) PRIMARY KEY,--„› «Õ —Ì”Ì
	[Employee_Num] [bigint] NULL,--—ﬁ„ «·„ÊŸ›
	[Job_name] [nvarchar](150) NULL,--’Ì›… „ÊŸ›
	[Employee_Name] [nvarchar](150) NULL,-- «”„ «·„ÊŸ›
	[EdaraID] [int] NULL,--—ﬁ„ «·«œ«—…
	[dep_ID] [int] NULL,-- —ﬁ„ «·ﬁ”„
	[EmpNote] [nvarchar](150) NULL,--„·«ÕŸ«  ⁄·Ì «·„ÊŸ›
	[Notes] [nvarchar](150) NULL,--„·«ÕŸ« 
	[UserID] [int] NULL,--—ﬁ„ «·„” Œœ„
	[State] [bit] NULL,--—ﬁ„ «·Õ«·…

)
go
-- ÃœÊ· «·«’Ê·
CREATE TABLE [Ossol]
(
	[Ossol_ID] [int] IDENTITY(1,1) PRIMARY KEY,--„› «Õ «·—∆”Ì
	[Ossol_No] [nvarchar](50) NULL,--—ﬁ„ «·«’·
	[Ossol_Name] [nvarchar](150) NULL,--«”„ «·«’·
	[Note] [nvarchar](150) NULL,--„·«ÕŸ« 
	[state] [int] NULL,--«·Õ«·…
	[UserID] [int] NULL,--—ﬁ„ «·„” Œœ„
	[MainOssolID] [int] NULL,--—ﬁ„ «·«’Ê· «·—∆”Ì…

)
-- ÃœÊ· ‰Ê⁄ «·«’Ê·
CREATE TABLE [OssolType]
(
	[OssolType_ID] [int] IDENTITY(1,1) PRIMARY KEY,--—ﬁ„  “Ìœ »«Ê«Õœ ·€—÷   — Ì» ·«“„  ﬂÊ‰ „› «Õ —∆Ì”Ì
	[OssolType_No] [nvarchar](50) NULL,-- Â–« —ﬁ„ Ìﬂ »Â „ ”Œœ„…
	[OssolType_Name] [nvarchar](150) NULL,--«”„ ‰Ê⁄ «·«’·
	[Ossol_ID] [int] NULL, -- „› «Õ ›—⁄Ì
	[Ossol_Name] [nvarchar](150) NULL,--«”„ «·«’·
	[Note] [nvarchar](150) NULL,--„·«ÕŸ« 
	[state] [int] NULL,-- Õ«·… ﬂ„« „Ê÷Õ ›Ì ﬂ—«”… ‰ﬁ—Ì»« ›ÌÂ ÃœÊ· ··Õ«·… —ﬁ„ Ê«”„ Õ«·…
	[UserID] [int] NULL,-- „› «Õ ›—⁄Ì ··„” Œœ„
	[MainOssolID] [int] NULL,-- „› «Õ ›—⁄Ì ··«’Ê· «·—∆”Ì…

)

GO