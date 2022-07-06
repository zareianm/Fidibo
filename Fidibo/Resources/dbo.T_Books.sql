CREATE TABLE [dbo].[T_Books] (
    [Name]       VARCHAR (50) NOT NULL,
    [Writer]     VARCHAR (50) NOT NULL,
    [Price]      FLOAT (53)   NOT NULL,
    [SalesCount] INT          NULL,
    [Rate]       FLOAT (53)   NULL,
    [Discount]   FLOAT (53)   NULL,
    [IsVIP]      BIT          NULL,
    [Summary] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

