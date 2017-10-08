CREATE TABLE [dbo].[Order] (
    [orderId]   UNIQUEIDENTIFIER NOT NULL,
    [size]      VARCHAR (50)     NOT NULL,
    [crust]     VARCHAR (50)     NOT NULL,
    [toppings]  VARCHAR (50)     NOT NULL,
    [name]      VARCHAR (50)     NOT NULL,
    [address]   VARCHAR (50)     NOT NULL,
    [zip]       VARCHAR (50)     NOT NULL,
    [phone]     VARCHAR (50)     NOT NULL,
    [payment]   VARCHAR (50)     NOT NULL,
    [completed] BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([orderId] ASC)

	
);


