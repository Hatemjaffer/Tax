use master
go
create database DB_Grad
go

--���� ������
CREATE TABLE [States]
(
	[States_ID] [int] IDENTITY(1,1)  PRIMARY KEY,--����� ����� ������
	[States_Name] [nvarchar](50) NULL,--��� ������
	[id_User] [int] NULL--����� ���� ��������
);
--���� ����������
CREATE TABLE Users
(   
	[UserID] int IDENTITY(1,1) PRIMARY KEY,--��� ��������
	[Name] [nvarchar](50) NULL,--��� ������
	[Password] [nvarchar](20) NULL,--���� ����
	[PermissionType] [nvarchar](50) NULL,--������
	[id_State] [int] NULL
);
go

--���� �����
CREATE TABLE [Type](
	[Type_ID] [int] IDENTITY(1,1)  PRIMARY KEY,--��� ��� ����� �����
	[Type_Name] [nvarchar](50) NULL,--��� ������
 
)
--���� �������
CREATE TABLE Departments
(
	[DepartmentsID] [int] IDENTITY(1,1) PRIMARY KEY,--����� �����
	[DepartmentsNum] [nvarchar](50) NULL,--��� ���
	[DepartmentsName] [nvarchar](150) NULL,--��� �����
	[EdaraID] [int] NULL,--��� �������
	[State] [int] NULL,--��� ������
	[UserID] [int] NULL,-- ��� ��������

)
go

CREATE TABLE [Edara](
	[EdaraID] [int] IDENTITY(1,1) PRIMARY KEY,-- ��� ����� ����� ����� ����� �� �� �������
	[EdaraName] [nvarchar](150) NULL,--��� �������
	[State] [tinyint] NULL,--����
	[UserID] [int] NULL,-- ��� ��������
)
go
--���� ������
CREATE TABLE [Employee](
	[Employee_ID] [int] IDENTITY(1,1) PRIMARY KEY,--����� ����
	[Employee_Num] [bigint] NULL,--��� ������
	[Job_name] [nvarchar](150) NULL,--���� ����
	[Employee_Name] [nvarchar](150) NULL,-- ��� ������
	[EdaraID] [int] NULL,--��� �������
	[dep_ID] [int] NULL,-- ��� �����
	[EmpNote] [nvarchar](150) NULL,--������� ��� ������
	[Notes] [nvarchar](150) NULL,--�������
	[UserID] [int] NULL,--��� ��������
	[State] [bit] NULL,--��� ������

)
go
-- ���� ������
CREATE TABLE [Ossol]
(
	[Ossol_ID] [int] IDENTITY(1,1) PRIMARY KEY,--����� ������
	[Ossol_No] [nvarchar](50) NULL,--��� �����
	[Ossol_Name] [nvarchar](150) NULL,--��� �����
	[Note] [nvarchar](150) NULL,--�������
	[state] [int] NULL,--������
	[UserID] [int] NULL,--��� ��������
	[MainOssolID] [int] NULL,--��� ������ �������

)
-- ���� ��� ������
CREATE TABLE [OssolType]
(
	[OssolType_ID] [int] IDENTITY(1,1) PRIMARY KEY,--��� ���� ������ ����  ����� ���� ���� ����� �����
	[OssolType_No] [nvarchar](50) NULL,-- ��� ��� ����� �������
	[OssolType_Name] [nvarchar](150) NULL,--��� ��� �����
	[Ossol_ID] [int] NULL, -- ����� ����
	[Ossol_Name] [nvarchar](150) NULL,--��� �����
	[Note] [nvarchar](150) NULL,--�������
	[state] [int] NULL,-- ���� ��� ���� �� ����� ������ ��� ���� ������ ��� ���� ����
	[UserID] [int] NULL,-- ����� ���� ��������
	[MainOssolID] [int] NULL,-- ����� ���� ������ �������

)

GO