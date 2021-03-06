USE [master]
GO
/****** Object:  Database [SistemaColecionador]    Script Date: 11/04/2019 22:37:17 ******/
CREATE DATABASE [SistemaColecionador]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaColecionador', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SistemaColecionador.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaColecionador_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SistemaColecionador_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SistemaColecionador] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaColecionador].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaColecionador] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaColecionador] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaColecionador] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaColecionador] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaColecionador] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaColecionador] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemaColecionador] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaColecionador] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaColecionador] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaColecionador] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaColecionador] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaColecionador] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaColecionador] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaColecionador] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaColecionador] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SistemaColecionador] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaColecionador] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaColecionador] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaColecionador] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaColecionador] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaColecionador] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaColecionador] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaColecionador] SET RECOVERY FULL 
GO
ALTER DATABASE [SistemaColecionador] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaColecionador] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaColecionador] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaColecionador] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaColecionador] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaColecionador] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SistemaColecionador', N'ON'
GO
ALTER DATABASE [SistemaColecionador] SET QUERY_STORE = OFF
GO
USE [SistemaColecionador]
GO
/****** Object:  Table [dbo].[Itens]    Script Date: 11/04/2019 22:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Itens](
	[id_item] [int] IDENTITY(1,1) NOT NULL,
	[tipoItem] [varchar](20) NOT NULL,
	[Titulo] [varchar](40) NOT NULL,
	[valor] [decimal](10, 2) NULL,
	[quantidade] [int] NOT NULL,
	[localArmazenado] [varchar](40) NULL,
	[descricao] [varchar](100) NULL,
	[imagem] [varbinary](max) NULL,
	[original] [varchar](3) NULL,
	[data_cadastro] [datetime] NOT NULL,
	[mensagem] [varchar](40) NULL,
	[valorTotal] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarItemLocall]    Script Date: 11/04/2019 22:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_BuscarItemLocall]
@localArmazenado varchar(40)
as begin
select * from Itens where localArmazenado like @localArmazenado+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarItemNomee]    Script Date: 11/04/2019 22:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_BuscarItemNomee]
@Titulo varchar(40)
as begin
select * from Itens where Titulo like @Titulo+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarItemTipoo]    Script Date: 11/04/2019 22:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_BuscarItemTipoo]
@tipoItem varchar(20)
as begin
select * from Itens where tipoItem like @tipoItem+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_editarItem]    Script Date: 11/04/2019 22:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[sp_editarItem]
@id_item int,
@tipoItem varchar(20),
@Titulo varchar(40),
@valor decimal(10,2),
@valorTotal decimal(10,2),
@imagem varbinary(max),
@quantidade int,
@localArmazenado varchar(40),
@descricao varchar(100),
@original varchar (2),
@mensagem VARCHAR(40) output
as
begin
UPDATE Itens set tipoItem = @tipoItem,
				Titulo = @Titulo,
				valor = @valor,
				valorTotal = @valorTotal,
				imagem = @imagem,
				quantidade = @quantidade,
				localArmazenado = @localArmazenado,
				descricao = @descricao,
				original = @original
				 WHERE id_item = @id_item
SET @mensagem='Dados alterados com sucesso!'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_excluirItemm]    Script Date: 11/04/2019 22:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_excluirItemm]
@id_item int,
@mensagem VARCHAR(40) output
as
begin
delete Itens where @id_item = id_item
set @mensagem='Deseja realmente excluir?'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_salvarItem]    Script Date: 11/04/2019 22:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_salvarItem]
@tipoItem varchar(20),
@Titulo varchar(40),
@valor decimal(10,2),
@valorTotal decimal(10,2),
@imagem varbinary(max),
@quantidade int,
@localArmazenado varchar(40),
@descricao varchar(100),
@original varchar (2),
@data_cadastro DATETIME,
@mensagem VARCHAR(40) output
as
begin
insert into Itens(
								tipoItem,
								Titulo,
								valor,
								valorTotal,
								imagem,
								quantidade,
								localArmazenado,
								descricao,
								original ,
								data_cadastro
								)
								
								VALUES (
								@tipoItem,
								@Titulo,
								@valor,
								@valorTotal,
								@imagem,
								@quantidade,
								@localArmazenado,
								@descricao,
								@original ,
								@data_cadastro)
set @mensagem='Dados salvos com sucesso!'
end
GO
USE [master]
GO
ALTER DATABASE [SistemaColecionador] SET  READ_WRITE 
GO
