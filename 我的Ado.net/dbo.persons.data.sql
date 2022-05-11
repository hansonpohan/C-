SET IDENTITY_INSERT [dbo].[persons] ON
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [Email], [生日], [婚姻狀態], [點數]) VALUES (1, N'陳大貓', N'0912345678', N'高雄市前金區中正路', N'mm@hh.com', N'1985-05-05', 0, 1000)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [Email], [生日], [婚姻狀態], [點數]) VALUES (2, N'黃小貓', N'0912121212', N'高雄市三民區建國路', N'aa@hh.com', N'1986-06-06', 1, 500)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [Email], [生日], [婚姻狀態], [點數]) VALUES (3, N'張大書', N'0934343434', N'高雄市鼓山區美術路', N'bb@hh.com', N'1978-11-09', 1, 2000)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [Email], [生日], [婚姻狀態], [點數]) VALUES (4, N'林阿霈', N'0956565656', N'台南市東區中華路', N'cc@hh.com', N'1979-01-05', 0, 1500)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [Email], [生日], [婚姻狀態], [點數]) VALUES (5, N'王小明', N'0978787878', N'台中市西屯區', N'dd@hh.com', N'1992-08-20', 1, 300)
INSERT INTO [dbo].[persons] ([Id], [姓名], [電話], [地址], [Email], [生日], [婚姻狀態], [點數]) VALUES (6, N'吳中線', N'0911111111', N'台南市東區中華一路', N'ee@hh.com', N'1988-09-25', 1, 3000)
SET IDENTITY_INSERT [dbo].[persons] OFF
