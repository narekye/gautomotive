CREATE TABLE [dbo].[Customer](
	[Id] [bigint] NOT NULL PRIMARY KEY,
	[CustomerName] [nvarchar](max) NULL,
	[CustomerTelephone] [nvarchar](max) NULL,
	[Mark] [nvarchar](250) NULL,
	[WIN] [nvarchar](250) NULL,
	[OrderAcceptanceDate] [date] NULL,
	[OrderSellDate] [date] NULL,
	[OriginalPrice] [decimal](18, 0) NULL,
	[SellPrice] [decimal](18, 0) NULL,
	[Profit] [decimal](18, 0) NULL,
	[DetailCode] [nvarchar](max) NULL,
	[DetailReplaceCode] [nvarchar](max) NULL,
	[Weight/KG] [int] NULL
)
GO