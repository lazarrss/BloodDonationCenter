USE [master]
GO
/****** Object:  Database [DonacijaKrvi]    Script Date: 5/12/2023 10:47:02 AM ******/
CREATE DATABASE [DonacijaKrvi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DonacijaKrvi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DonacijaKrvi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DonacijaKrvi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DonacijaKrvi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DonacijaKrvi] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DonacijaKrvi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DonacijaKrvi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET ARITHABORT OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DonacijaKrvi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DonacijaKrvi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DonacijaKrvi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DonacijaKrvi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET RECOVERY FULL 
GO
ALTER DATABASE [DonacijaKrvi] SET  MULTI_USER 
GO
ALTER DATABASE [DonacijaKrvi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DonacijaKrvi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DonacijaKrvi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DonacijaKrvi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DonacijaKrvi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DonacijaKrvi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DonacijaKrvi', N'ON'
GO
ALTER DATABASE [DonacijaKrvi] SET QUERY_STORE = ON
GO
ALTER DATABASE [DonacijaKrvi] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DonacijaKrvi]
GO
/****** Object:  Table [dbo].[Akceptori]    Script Date: 5/12/2023 10:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Akceptori](
	[jmbg] [varchar](13) NOT NULL,
	[ime] [varchar](20) NOT NULL,
	[prezime] [varchar](30) NOT NULL,
	[datr] [datetime] NOT NULL,
	[krvnaGrupa] [varchar](3) NOT NULL,
	[mesto] [varchar](100) NOT NULL,
	[id_bolnice] [varchar](100) NULL,
	[id_doktora] [varchar](13) NULL,
	[datumPrijave] [datetime] NOT NULL,
	[email] [varchar](100) NOT NULL,
	[lozinka] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[jmbg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bolnica]    Script Date: 5/12/2023 10:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolnica](
	[id_bolnice] [varchar](100) NOT NULL,
	[grad] [varchar](20) NOT NULL,
	[opstina] [varchar](100) NOT NULL,
	[adresa] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_bolnice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BolnicaSponzori]    Script Date: 5/12/2023 10:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BolnicaSponzori](
	[id_bolnice] [varchar](100) NULL,
	[nazivSponzora] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DA]    Script Date: 5/12/2023 10:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DA](
	[jmbgD] [varchar](13) NULL,
	[jmbgA] [varchar](13) NULL,
	[kolicinaKrvi] [int] NOT NULL,
	[datumDavanja] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doktori]    Script Date: 5/12/2023 10:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doktori](
	[jmbg] [varchar](13) NOT NULL,
	[ime] [varchar](20) NOT NULL,
	[prezime] [varchar](30) NOT NULL,
	[specijalizacija] [varchar](20) NOT NULL,
	[id_bolnice] [varchar](100) NULL,
	[email] [varchar](100) NOT NULL,
	[lozinka] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[jmbg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donori]    Script Date: 5/12/2023 10:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donori](
	[jmbg] [varchar](13) NOT NULL,
	[ime] [varchar](20) NOT NULL,
	[prezime] [varchar](30) NOT NULL,
	[datr] [datetime] NOT NULL,
	[krvnaGrupa] [varchar](3) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[lozinka] [varchar](100) NOT NULL,
	[brojTelefona] [varchar](15) NOT NULL,
	[pol] [varchar](6) NOT NULL,
	[brojDavanjaKrvi] [int] NULL,
	[ukupnaKolicinaKrvi] [int] NULL,
	[mesto] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[jmbg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hitno]    Script Date: 5/12/2023 10:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hitno](
	[jmbg] [varchar](13) NOT NULL,
	[ime] [varchar](20) NOT NULL,
	[prezime] [varchar](30) NOT NULL,
	[datr] [datetime] NOT NULL,
	[krvnaGrupa] [varchar](3) NOT NULL,
	[mesto] [varchar](100) NOT NULL,
	[id_bolnice] [varchar](100) NULL,
	[id_doktora] [varchar](13) NULL,
	[datumPrijave] [datetime] NOT NULL,
	[email] [varchar](100) NULL,
	[lozinka] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[jmbg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sponzori]    Script Date: 5/12/2023 10:47:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sponzori](
	[nazivSponzora] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nazivSponzora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Akceptori] ([jmbg], [ime], [prezime], [datr], [krvnaGrupa], [mesto], [id_bolnice], [id_doktora], [datumPrijave], [email], [lozinka]) VALUES (N'2503004745028', N'Una', N'Mikic', CAST(N'2004-03-25T01:13:45.000' AS DateTime), N' B-', N'Leskovac', N'Deciji dispanzer', N'0807972745030', CAST(N'2023-05-05T01:14:22.823' AS DateTime), N'unamikic6@gmail.com', N'unamikic')
GO
INSERT [dbo].[Akceptori] ([jmbg], [ime], [prezime], [datr], [krvnaGrupa], [mesto], [id_bolnice], [id_doktora], [datumPrijave], [email], [lozinka]) VALUES (N'2706004740030', N'Lazar', N'Stojanovic', CAST(N'2004-06-27T00:00:00.000' AS DateTime), N'0-', N'Leskovac', N'Dom Zdravlja Leskovac', N'1302965740030', CAST(N'2023-03-19T20:32:19.003' AS DateTime), N'lazarstojanovic0004@gmail.com', N'plazmanekeks69!')
GO
INSERT [dbo].[Bolnica] ([id_bolnice], [grad], [opstina], [adresa]) VALUES (N'Deciji dispanzer', N'Leskovac', N'Leskovac', N'Mlinska 1')
GO
INSERT [dbo].[Bolnica] ([id_bolnice], [grad], [opstina], [adresa]) VALUES (N'Dom Zdravlja Leskovac', N'Leskovac', N'Leskovac', N'Svetozara Markovica 116')
GO
INSERT [dbo].[Bolnica] ([id_bolnice], [grad], [opstina], [adresa]) VALUES (N'Opsta bolnica Leskovac', N'Leskovac', N'Leskovac', N'Svetozara Markovica 110')
GO
INSERT [dbo].[DA] ([jmbgD], [jmbgA], [kolicinaKrvi], [datumDavanja]) VALUES (N'1808004745028', N'2706004740030', 495, CAST(N'2023-05-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DA] ([jmbgD], [jmbgA], [kolicinaKrvi], [datumDavanja]) VALUES (N'1808004745028', N'2706004740030', 450, CAST(N'2023-01-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DA] ([jmbgD], [jmbgA], [kolicinaKrvi], [datumDavanja]) VALUES (N'1808004745028', N'2706004740030', 420, CAST(N'2022-09-20T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DA] ([jmbgD], [jmbgA], [kolicinaKrvi], [datumDavanja]) VALUES (N'0911004740030', N'2706004740030', 495, CAST(N'2021-03-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DA] ([jmbgD], [jmbgA], [kolicinaKrvi], [datumDavanja]) VALUES (N'0911004740030', N'2706004740030', 495, CAST(N'2022-03-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Doktori] ([jmbg], [ime], [prezime], [specijalizacija], [id_bolnice], [email], [lozinka]) VALUES (N'0807972745030', N'Suzana', N'Cakic', N'Pedijatar', N'Deciji dispanzer', N'suzacakic@gmail.com', N'suzaaaa1')
GO
INSERT [dbo].[Doktori] ([jmbg], [ime], [prezime], [specijalizacija], [id_bolnice], [email], [lozinka]) VALUES (N'1302965740030', N'Goran', N'Mladenov', N'Pedijatar', N'Deciji dispanzer', N'goranmladenov65@gmail.com', N'osmeh123')
GO
INSERT [dbo].[Donori] ([jmbg], [ime], [prezime], [datr], [krvnaGrupa], [email], [lozinka], [brojTelefona], [pol], [brojDavanjaKrvi], [ukupnaKolicinaKrvi], [mesto]) VALUES (N'0911004740030', N'Dejan', N'Saric', CAST(N'2004-11-09T15:18:29.000' AS DateTime), N'AB+', N'nisamdejan@gmail.com', N'deki123', N'06111111', N'musko', 0, 0, N'Leskovac')
GO
INSERT [dbo].[Donori] ([jmbg], [ime], [prezime], [datr], [krvnaGrupa], [email], [lozinka], [brojTelefona], [pol], [brojDavanjaKrvi], [ukupnaKolicinaKrvi], [mesto]) VALUES (N'1003004745038', N'Milica', N'Vuletic', CAST(N'2004-03-10T00:31:45.000' AS DateTime), N'A+', N'milicamicivuletic@gmail.com', N'neverujem123', N'0668844564', N'zensko', 0, 0, N'Medvedja')
GO
INSERT [dbo].[Donori] ([jmbg], [ime], [prezime], [datr], [krvnaGrupa], [email], [lozinka], [brojTelefona], [pol], [brojDavanjaKrvi], [ukupnaKolicinaKrvi], [mesto]) VALUES (N'1808004745028', N'Teodora', N'Djordjevic', CAST(N'2004-08-18T00:00:00.000' AS DateTime), N'0-', N'teodora.djj@gmail.com', N'tepihdrvo378', N'0691882004', N'zensko', 0, 0, N'Leskovac')
GO
INSERT [dbo].[Donori] ([jmbg], [ime], [prezime], [datr], [krvnaGrupa], [email], [lozinka], [brojTelefona], [pol], [brojDavanjaKrvi], [ukupnaKolicinaKrvi], [mesto]) VALUES (N'2601005740033', N'Maci', N'Miladinovic', CAST(N'2005-01-26T03:59:39.000' AS DateTime), N'B+', N'maci@gmail.com', N'macii', N'06333333', N'musko', 0, 0, N'Leskovac')
GO
INSERT [dbo].[Hitno] ([jmbg], [ime], [prezime], [datr], [krvnaGrupa], [mesto], [id_bolnice], [id_doktora], [datumPrijave], [email], [lozinka]) VALUES (N'2503004745028', N'Una', N'Mikic', CAST(N'2004-03-25T01:13:45.000' AS DateTime), N' B-', N'Leskovac', N'Deciji dispanzer', N'0807972745030', CAST(N'2023-05-05T04:09:51.463' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Hitno] ([jmbg], [ime], [prezime], [datr], [krvnaGrupa], [mesto], [id_bolnice], [id_doktora], [datumPrijave], [email], [lozinka]) VALUES (N'2706004740030', N'Lazar', N'Stojanovic', CAST(N'2004-06-27T00:00:00.000' AS DateTime), N'0-', N'Leskovac', N'Dom Zdravlja Leskovac', N'1302965740030', CAST(N'2023-05-05T01:55:20.303' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Sponzori] ([nazivSponzora]) VALUES (N'Aktavis Leskovac')
GO
ALTER TABLE [dbo].[Akceptori]  WITH CHECK ADD FOREIGN KEY([id_bolnice])
REFERENCES [dbo].[Bolnica] ([id_bolnice])
GO
ALTER TABLE [dbo].[Akceptori]  WITH CHECK ADD FOREIGN KEY([id_doktora])
REFERENCES [dbo].[Doktori] ([jmbg])
GO
ALTER TABLE [dbo].[BolnicaSponzori]  WITH CHECK ADD FOREIGN KEY([id_bolnice])
REFERENCES [dbo].[Bolnica] ([id_bolnice])
GO
ALTER TABLE [dbo].[BolnicaSponzori]  WITH CHECK ADD FOREIGN KEY([nazivSponzora])
REFERENCES [dbo].[Sponzori] ([nazivSponzora])
GO
ALTER TABLE [dbo].[DA]  WITH CHECK ADD FOREIGN KEY([jmbgA])
REFERENCES [dbo].[Akceptori] ([jmbg])
GO
ALTER TABLE [dbo].[DA]  WITH CHECK ADD FOREIGN KEY([jmbgD])
REFERENCES [dbo].[Donori] ([jmbg])
GO
ALTER TABLE [dbo].[Doktori]  WITH CHECK ADD FOREIGN KEY([id_bolnice])
REFERENCES [dbo].[Bolnica] ([id_bolnice])
GO
ALTER TABLE [dbo].[Hitno]  WITH CHECK ADD FOREIGN KEY([id_bolnice])
REFERENCES [dbo].[Bolnica] ([id_bolnice])
GO
ALTER TABLE [dbo].[Hitno]  WITH CHECK ADD FOREIGN KEY([id_doktora])
REFERENCES [dbo].[Doktori] ([jmbg])
GO
USE [master]
GO
ALTER DATABASE [DonacijaKrvi] SET  READ_WRITE 
GO
