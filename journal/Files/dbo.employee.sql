CREATE TABLE [dbo].[employee] (
    [Id]               INT            NOT NULL,
    [firstname]        NVARCHAR (50)  NOT NULL,
    [lastname]         NVARCHAR (50)  NOT NULL,
    [gender]           NVARCHAR (10)  NOT NULL,
    [designation]      NVARCHAR (15)  NOT NULL,
    [email]            NVARCHAR (20)  NOT NULL,
    [presentaddress]   NVARCHAR (500) NOT NULL,
    [permanentaddress] NVARCHAR (500) NOT NULL,
    [contact]          NVARCHAR (20)  NOT NULL,
    [salary]           INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

