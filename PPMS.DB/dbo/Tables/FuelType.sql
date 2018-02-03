﻿CREATE TABLE [dbo].[FuelType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [IsActive]    BIT            CONSTRAINT [DF_FuelType_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_FuelType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

