
CREATE TABLE [dbo].[MItemCategory] (
    [Id]                   INT           IDENTITY (1, 1) NOT NULL ,
    [cItemCategoryCode]    VARCHAR (10)  NOT NULL Unique,
    [cItemCategoryDesc]    VARCHAR (200) NOT NULL,
    [lItemCategoryStatus]  BIT           NOT NULL,
    [cItemCategoryRemarks] VARCHAR (500) NULL,
    [cCreatedBy]           VARCHAR (50)  NOT NULL,
    [dCreatedDate]         DATETIME      NOT NULL,
    [cUpdatedBy]           VARCHAR (50)  NOT NULL,
    [dUpdatedDate]         DATETIME      NOT NULL, 
    CONSTRAINT [PK_MItemCategory] PRIMARY KEY ([Id])
);


