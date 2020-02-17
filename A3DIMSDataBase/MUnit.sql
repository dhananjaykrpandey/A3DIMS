CREATE TABLE [dbo].[MUnit]
(
    [iId]                   INT           IDENTITY (1, 1) NOT NULL ,
    [cUnitCode]    VARCHAR (10)  NOT NULL Unique,
    [cUnitDesc]    VARCHAR (200) NOT NULL,
    [lUnitStatus]  BIT           NOT NULL,
    [cUnitRemarks] VARCHAR (500) NULL,
    [cCreatedBy]           VARCHAR (50)  NOT NULL,
    [dCreatedDate]         DATETIME      NOT NULL,
    [cUpdatedBy]           VARCHAR (50)  NOT NULL,
    [dUpdatedDate]         DATETIME      NOT NULL, 
    CONSTRAINT [PK_MUnit] PRIMARY KEY ([iId])
);