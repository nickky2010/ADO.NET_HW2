USE [TrainingTranslate]
GO

/****** Объект: Table [dbo].[RussianWords] Дата скрипта: 23.02.2019 10:36:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RussianWords] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Russian] NVARCHAR (50) NOT NULL,
    [English] NVARCHAR (50) NOT NULL,
    [Picture] IMAGE         NOT NULL
);


