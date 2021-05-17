SET IDENTITY_INSERT [dbo].[Bill_Payment_Master] ON
INSERT INTO [dbo].[Bill_Payment_Master] ([Bill_ID], [Company_Name], [Amount], [type], [Payment_Date]) VALUES (1, N'ABC Company ', 1000, N'-1', N'2021-05-01 16:50:00')
SET IDENTITY_INSERT [dbo].[Bill_Payment_Master] OFF

SET IDENTITY_INSERT [dbo].[Client_Master] ON
INSERT INTO [dbo].[Client_Master] ([Client_ID], [Client_Name], [Client_Mobile], [Client_Address], [Client_Edate]) VALUES (1, N'rakhee', N'98777', N'ghg', N'2021-03-23 12:00:00')
INSERT INTO [dbo].[Client_Master] ([Client_ID], [Client_Name], [Client_Mobile], [Client_Address], [Client_Edate]) VALUES (2, N'Dilpreet', N'1231231231', N'Newzeland', N'2021-05-16 19:44:00')
INSERT INTO [dbo].[Client_Master] ([Client_ID], [Client_Name], [Client_Mobile], [Client_Address], [Client_Edate]) VALUES (3, N'Manpreet', N'64453', N'acs', N'2021-05-06 17:44:00')
SET IDENTITY_INSERT [dbo].[Client_Master] OFF

SET IDENTITY_INSERT [dbo].[Company_Master] ON
INSERT INTO [dbo].[Company_Master] ([Company_ID], [Company_Name], [Contact_Number], [Company_Address], [Contact], [Company_Edate]) VALUES (1, N'ABC Company ', N'24234', N'India', N'79393', N'2021-05-01 18:46:00')
INSERT INTO [dbo].[Company_Master] ([Company_ID], [Company_Name], [Contact_Number], [Company_Address], [Contact], [Company_Edate]) VALUES (2, N'xyz', N'453', N'delhi', N'89080', N'2021-04-09 18:47:00')
SET IDENTITY_INSERT [dbo].[Company_Master] OFF

SET IDENTITY_INSERT [dbo].[Payment_Master] ON
INSERT INTO [dbo].[Payment_Master] ([Payment_ID], [Party_Name], [Mobile], [Qty], [Amount], [Paid_Amt], [Status], [Payment_Edate]) VALUES (1, N'pmp', N'453', 10, 500, 5000, N'paid', N'2021-05-07 16:49:00')
SET IDENTITY_INSERT [dbo].[Payment_Master] OFF

SET IDENTITY_INSERT [dbo].[Sale_Master] ON
INSERT INTO [dbo].[Sale_Master] ([Sale_ID], [Party_Name], [Mobile], [Company], [Item_Name], [Type], [Qty], [Price], [Total_Price], [Bill_No], [Stock_Edate]) VALUES (1, N'pmp', N'84596', N'abc', N'books', -1, 45, 22, 45, 1, N'2021-05-01 16:48:00')
SET IDENTITY_INSERT [dbo].[Sale_Master] OFF
