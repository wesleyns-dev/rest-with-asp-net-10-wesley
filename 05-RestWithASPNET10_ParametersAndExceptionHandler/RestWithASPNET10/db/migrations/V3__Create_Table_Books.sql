CREATE TABLE [dbo].[books] (
	[id] bigint NOT NULL IDENTITY,
	[title] varchar(MAX) NULL,
	[author] varchar(MAX) NULL,
	[price] DECIMAL(18,2) NOT NULL,
	[launch_date] DATETIME2 NOT NULL
)