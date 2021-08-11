SET IDENTITY_INSERT [dbo].[CourierOffice] ON
INSERT INTO [dbo].[CourierOffice] ([Id], [Office_Name], [Contact_Number], [Email_Id]) VALUES (1, N'DHL', N'0225677898', N'Dhl.com')
INSERT INTO [dbo].[CourierOffice] ([Id], [Office_Name], [Contact_Number], [Email_Id]) VALUES (2, N'Post Haste', N'022556899', N'Posthaste.com')
INSERT INTO [dbo].[CourierOffice] ([Id], [Office_Name], [Contact_Number], [Email_Id]) VALUES (3, N'Aramex', N'022677879', N'Aramex.com')
SET IDENTITY_INSERT [dbo].[CourierOffice] OFF
SET IDENTITY_INSERT [dbo].[CourierDeliver] ON
INSERT INTO [dbo].[CourierDeliver] ([Id], [DeliveryPerson_Name], [DeliveryPerson_Address], [DeliveryPerson_Contact], [DeliveryPerson_EmailId]) VALUES (1, N'Sit', N'Auckland', N'022778989', N'Sit.com')
INSERT INTO [dbo].[CourierDeliver] ([Id], [DeliveryPerson_Name], [DeliveryPerson_Address], [DeliveryPerson_Contact], [DeliveryPerson_EmailId]) VALUES (2, N'Den', N'Auckland', N'0226767889', N'Den.com')
INSERT INTO [dbo].[CourierDeliver] ([Id], [DeliveryPerson_Name], [DeliveryPerson_Address], [DeliveryPerson_Contact], [DeliveryPerson_EmailId]) VALUES (3, N'Ysh', N'Auckland', N'0226778890', N'Ysh.com')
SET IDENTITY_INSERT [dbo].[CourierDeliver] OFF
SET IDENTITY_INSERT [dbo].[CourierReceiver] ON
INSERT INTO [dbo].[CourierReceiver] ([Id], [Receiver_Name], [Receiver_Address], [Receiver_Contact], [CourierDeliveryID], [CourierDeliver_IDId]) VALUES (1, N'Ryt', N'Auckland', N'022677899', 1, NULL)
INSERT INTO [dbo].[CourierReceiver] ([Id], [Receiver_Name], [Receiver_Address], [Receiver_Contact], [CourierDeliveryID], [CourierDeliver_IDId]) VALUES (2, N'Wit', N'Auckland', N'022676799', 2, NULL)
INSERT INTO [dbo].[CourierReceiver] ([Id], [Receiver_Name], [Receiver_Address], [Receiver_Contact], [CourierDeliveryID], [CourierDeliver_IDId]) VALUES (3, N'Dark', N'Auckland', N'022677898', 3, NULL)
SET IDENTITY_INSERT [dbo].[CourierReceiver] OFF
