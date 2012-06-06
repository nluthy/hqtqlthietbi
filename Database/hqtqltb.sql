SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TINHTRANGVATCHAT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TINHTRANGVATCHAT](
	[MATINHTRANG] [nchar](10) NOT NULL,
	[TENTINHTRANG] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MATINHTRANG] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TINHTRANGYEUCAU]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TINHTRANGYEUCAU](
	[MATINHTRANG] [nchar](10) NOT NULL,
	[TENTINHTRANG] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MATINHTRANG] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NGUOISUDUNG]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NGUOISUDUNG](
	[MANGUOISUDUNG] [nchar](10) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[MATKHAU] [nchar](10) NULL,
	[NGAYSINH] [datetime] NULL,
	[EMAIL] [nchar](20) NULL,
	[HOPLE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MANGUOISUDUNG] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LOAIVATCHAT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LOAIVATCHAT](
	[MALOAI] [nchar](10) NOT NULL,
	[TENLOAI] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[COSOVATCHAT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[COSOVATCHAT](
	[MAVATCHAT] [nchar](10) NOT NULL,
	[TENVATCHAT] [nvarchar](50) NULL,
	[MALOAI] [nchar](10) NULL,
	[MATINHTRANG] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAVATCHAT] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PHIEUYEUCAU]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PHIEUYEUCAU](
	[MAPHIEU] [nchar](10) NOT NULL,
	[MANGUOISUDUNG] [nchar](10) NULL,
	[MAVATCHAT] [nchar](10) NULL,
	[THOIGIANDANGKI] [datetime] NULL,
	[THOIGIANMUON] [datetime] NULL,
	[MATINHTRANG] [nchar](10) NULL,
	[GHICHU] [nvarchar](50) NULL,
	[SOLUONG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEU] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KETQUA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[KETQUA](
	[MAKETQUA] [nchar](10) NOT NULL,
	[MANGUOISUDUNG] [nchar](10) NULL,
	[YEUCAUTHANHCONG] [nchar](10) NULL,
	[YEUCAUTHATBAI] [nchar](10) NULL,
	[GHICHU] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKETQUA] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ThemNguoiSuDung]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[ThemNguoiSuDung] 
				@Ma nchar(10),
				@HoTen nvarchar(50),
				@MatKhau nchar(10),
				@Ngaysinh datetime,
				@Email nchar(20),
				@HopLe int	
AS
BEGIN
	if exists (select * from NGUOISUDUNG where MANGUOISUDUNG = @Ma)
	begin
		return -1
	end 
	insert into NGUOISUDUNG values (@Ma, @HoTen, @MatKhau, @NgaySinh, @Email, @HopLe)
	return 1
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DangNhap]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DangNhap]
	@MaNguoiSuDung nchar(10),
	@MatKhau nchar(10)
AS
BEGIN
	if(not exists (select * from NGUOISUDUNG where MANGUOISUDUNG = @MaNguoiSuDung))
	begin
		return -1
	end
	declare @DBMatKhau nchar(10)
	declare curMatKhau cursor for (select MATKHAU from NGUOISUDUNG where MANGUOISUDUNG = @MaNguoiSuDung)
	open curMatKhau
	fetch next from curMatKhau into @DBMatKhau
	close curMatKhau
	deallocate curMatKhau
	if(@DBMatKhau = @MatKhau)
	begin
		return 1
	end
	return 0
END
' 
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CSVC_LVC]') AND parent_object_id = OBJECT_ID(N'[dbo].[COSOVATCHAT]'))
ALTER TABLE [dbo].[COSOVATCHAT]  WITH CHECK ADD  CONSTRAINT [FK_CSVC_LVC] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAIVATCHAT] ([MALOAI])
GO
ALTER TABLE [dbo].[COSOVATCHAT] CHECK CONSTRAINT [FK_CSVC_LVC]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CSVC_TTVC]') AND parent_object_id = OBJECT_ID(N'[dbo].[COSOVATCHAT]'))
ALTER TABLE [dbo].[COSOVATCHAT]  WITH CHECK ADD  CONSTRAINT [FK_CSVC_TTVC] FOREIGN KEY([MATINHTRANG])
REFERENCES [dbo].[TINHTRANGVATCHAT] ([MATINHTRANG])
GO
ALTER TABLE [dbo].[COSOVATCHAT] CHECK CONSTRAINT [FK_CSVC_TTVC]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PYC_CSVC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PHIEUYEUCAU]'))
ALTER TABLE [dbo].[PHIEUYEUCAU]  WITH CHECK ADD  CONSTRAINT [FK_PYC_CSVC] FOREIGN KEY([MAVATCHAT])
REFERENCES [dbo].[COSOVATCHAT] ([MAVATCHAT])
GO
ALTER TABLE [dbo].[PHIEUYEUCAU] CHECK CONSTRAINT [FK_PYC_CSVC]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PYC_NSD]') AND parent_object_id = OBJECT_ID(N'[dbo].[PHIEUYEUCAU]'))
ALTER TABLE [dbo].[PHIEUYEUCAU]  WITH CHECK ADD  CONSTRAINT [FK_PYC_NSD] FOREIGN KEY([MANGUOISUDUNG])
REFERENCES [dbo].[NGUOISUDUNG] ([MANGUOISUDUNG])
GO
ALTER TABLE [dbo].[PHIEUYEUCAU] CHECK CONSTRAINT [FK_PYC_NSD]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PYC_TTYC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PHIEUYEUCAU]'))
ALTER TABLE [dbo].[PHIEUYEUCAU]  WITH CHECK ADD  CONSTRAINT [FK_PYC_TTYC] FOREIGN KEY([MATINHTRANG])
REFERENCES [dbo].[TINHTRANGYEUCAU] ([MATINHTRANG])
GO
ALTER TABLE [dbo].[PHIEUYEUCAU] CHECK CONSTRAINT [FK_PYC_TTYC]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KQ_NSD]') AND parent_object_id = OBJECT_ID(N'[dbo].[KETQUA]'))
ALTER TABLE [dbo].[KETQUA]  WITH CHECK ADD  CONSTRAINT [FK_KQ_NSD] FOREIGN KEY([MANGUOISUDUNG])
REFERENCES [dbo].[NGUOISUDUNG] ([MANGUOISUDUNG])
GO
ALTER TABLE [dbo].[KETQUA] CHECK CONSTRAINT [FK_KQ_NSD]
