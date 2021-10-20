CREATE DATABASE QuanCafeK19;
GO

USE QuanCafeK19;
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign]
    (
      @strInput NVARCHAR(4000)
    )
RETURNS NVARCHAR(4000)
AS
    BEGIN
        IF @strInput IS NULL
            RETURN @strInput;
        IF @strInput = ''
            RETURN @strInput;
        DECLARE @RT NVARCHAR(4000);
        DECLARE @SIGN_CHARS NCHAR(136);
        DECLARE @UNSIGN_CHARS NCHAR(136);
        SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'
            + NCHAR(272) + NCHAR(208);
        SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD';
        DECLARE @COUNTER INT;
        DECLARE @COUNTER1 INT;
        SET @COUNTER = 1;
        WHILE ( @COUNTER <= LEN(@strInput) )
            BEGIN
                SET @COUNTER1 = 1;
                WHILE ( @COUNTER1 <= LEN(@SIGN_CHARS) + 1 )
                    BEGIN
                        IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1, 1)) = UNICODE(SUBSTRING(@strInput,
                                                              @COUNTER, 1))
                            BEGIN
                                IF @COUNTER = 1
                                    SET @strInput = SUBSTRING(@UNSIGN_CHARS,
                                                              @COUNTER1, 1)
                                        + SUBSTRING(@strInput, @COUNTER + 1,
                                                    LEN(@strInput) - 1);
                                ELSE
                                    SET @strInput = SUBSTRING(@strInput, 1,
                                                              @COUNTER - 1)
                                        + SUBSTRING(@UNSIGN_CHARS, @COUNTER1,
                                                    1) + SUBSTRING(@strInput,
                                                              @COUNTER + 1,
                                                              LEN(@strInput)
                                                              - @COUNTER);
                                BREAK;
                            END;
                        SET @COUNTER1 = @COUNTER1 + 1;
                    END;
                SET @COUNTER = @COUNTER + 1;
            END;
        SET @strInput = REPLACE(@strInput, ' ', '-');
        RETURN @strInput;
    END;
GO

-- ACCOUNT
CREATE TABLE ACCOUNT
    (
      Username VARCHAR(100) PRIMARY KEY ,
      Password VARCHAR(100) DEFAULT '1' ,
      DisplayName NVARCHAR(100) DEFAULT 'K19 2' ,
      TypeAccount INT DEFAULT 0 , -- 1: admin, 0: staff
      Avatar IMAGE
    );
GO

INSERT  dbo.ACCOUNT
        ( Username, DisplayName, TypeAccount )
VALUES  ( 'admin', N'Quản lý', 1 ),
        ( 'nguyenvana', N'Nguyễn Văn A', 0 ),
        ( 'nguyenvanb', N'Nguyễn Văn B', 0 );
GO

CREATE PROC GetListAccount
AS
    BEGIN
        SELECT  Username N'Tên tài khoản' ,
                Password N'Mật khẩu' ,
                DisplayName N'Tên hiển thị' ,
                CASE TypeAccount
                  WHEN 1 THEN N'Quản lý'
                  ELSE N'Nhân viên'
                END N'Loại tài khoản' ,
                Avatar N'Ảnh đại diện'
        FROM    dbo.ACCOUNT;    
    END;
GO

CREATE PROC InsertAccount
    @username VARCHAR(100) ,
    @password VARCHAR(100) ,
    @displayName NVARCHAR(100) ,
    @typeAccount INT ,
    @avatar IMAGE
AS
    BEGIN
        INSERT  dbo.ACCOUNT
                ( Username ,
                  Password ,
                  DisplayName ,
                  TypeAccount ,
                  Avatar
                )
        VALUES  ( @username ,
                  @password ,
                  @displayName ,
                  @typeAccount ,
                  @avatar
                );
    END;
GO

CREATE PROC UpdateAccount
    @username VARCHAR(100) ,
    @password VARCHAR(100) ,
    @displayName NVARCHAR(100) ,
    @typeAccount INT ,
    @avatar IMAGE
AS
    BEGIN
        UPDATE  dbo.ACCOUNT
        SET     Password = @password ,
                DisplayName = @displayName ,
                TypeAccount = @typeAccount ,
                Avatar = @avatar
        WHERE   Username = @username;
    END;
GO

CREATE PROC DeleteAccount @username VARCHAR(100)
AS
    BEGIN
        DELETE  dbo.ACCOUNT
        WHERE   Username = @username;
    END;
GO

CREATE PROC SearchAccountByUsername @username VARCHAR(100)
AS
    BEGIN
        SELECT  Username N'Tên tài khoản' ,
                Password N'Mật khẩu' ,
                DisplayName N'Tên hiển thị' ,
                CASE TypeAccount
                  WHEN 1 THEN N'Quản lý'
                  ELSE N'Nhân viên'
                END N'Loại tài khoản' ,
                Avatar N'Ảnh đại diện'
        FROM    dbo.ACCOUNT
        WHERE   ( dbo.fuConvertToUnsign(Username) LIKE N'%'
                  + dbo.fuConvertToUnsign(@username) + '%' );
    END;
GO

CREATE PROC SearchAccountByDisplayName
    @displayName NVARCHAR(100)
AS
    BEGIN
        SELECT  Username N'Tên tài khoản' ,
                Password N'Mật khẩu' ,
                DisplayName N'Tên hiển thị' ,
                CASE TypeAccount
                  WHEN 1 THEN N'Quản lý'
                  ELSE N'Nhân viên'
                END N'Loại tài khoản' ,
                Avatar N'Ảnh đại diện'
        FROM    dbo.ACCOUNT
        WHERE   ( dbo.fuConvertToUnsign(DisplayName) LIKE N'%'
                  + dbo.fuConvertToUnsign(@displayName) + '%' );
    END;
GO

CREATE PROC LoginAccount
    @username VARCHAR(100) ,
    @password VARCHAR(100)
AS
    BEGIN
        SELECT  TypeAccount
        FROM    dbo.ACCOUNT
        WHERE   Username = @username
                AND Password = @password;
    END;
GO

-- TABLE FOOD
CREATE TABLE TABLEFOOD
    (
      Id INT PRIMARY KEY
             IDENTITY ,
      Name NVARCHAR(100) DEFAULT N'Chưa đặt tên' ,
      Status INT DEFAULT 0, -- 0: Trống, 1: Có người
    );
GO

DECLARE @i INT = 1;
WHILE @i <= 10
    BEGIN
        INSERT  dbo.TABLEFOOD
                ( Name )
        VALUES  ( N'Bàn ' + CAST(@i AS NVARCHAR(100)) );
        SET @i = @i + 1;
    END;
GO

CREATE PROC GetListTableFood
AS
    BEGIN
        SELECT  Id N'Mã bàn' ,
                Name N'Tên bàn' ,
                CASE Status
                  WHEN 0 THEN N'Trống'
                  ELSE N'Có người'
                END N'Trạng thái'
        FROM    dbo.TABLEFOOD;
    END;
GO

CREATE PROC InsertTableFood @name NVARCHAR(100)
AS
    BEGIN
        INSERT  dbo.TABLEFOOD
                ( Name )
        VALUES  ( @name );
    END;
GO

CREATE PROC UpdateNameTableFood
    @id INT ,
    @name NVARCHAR(100)
AS
    BEGIN
        UPDATE  dbo.TABLEFOOD
        SET     Name = @name
        WHERE   Id = @id;
    END;
GO

CREATE PROC UpdateStatusTableFood @id INT, @status INT
AS
    BEGIN
        UPDATE  dbo.TABLEFOOD
        SET     Status = @status
        WHERE   Id = @id;
    END;
GO

CREATE PROC DeleteTableFood @id INT
AS
    BEGIN
        DELETE  dbo.TABLEFOOD
        WHERE   Id = @id;
    END;
GO

CREATE PROC SearchTableFoodByName @name NVARCHAR(100)
AS
    BEGIN
        SELECT  Id N'Mã bàn' ,
                Name N'Tên bàn' ,
                CASE Status
                  WHEN 0 THEN N'Trống'
                  ELSE N'Có người'
                END N'Trạng thái'
        FROM    dbo.TABLEFOOD
        WHERE   ( dbo.fuConvertToUnsign(Name) LIKE N'%'
                  + dbo.fuConvertToUnsign(@name) + '%' );
    END;
GO

-- FOODCATEGORY
CREATE TABLE FOODCATEGORY
    (
      Id INT PRIMARY KEY
             IDENTITY ,
      Name NVARCHAR(100) DEFAULT N'Chưa đặt tên' ,
      Avatar IMAGE
    );
GO

CREATE PROC GetListFoodCategory
AS
    BEGIN
        SELECT  Id N'Mã loại' ,
                Name N'Tên loại' ,
                Avatar N'Ảnh minh hoạ'
        FROM    dbo.FOODCATEGORY;
    END;
GO

CREATE PROC InsertFoodCategory
    @name NVARCHAR(100) ,
    @avatar IMAGE
AS
    BEGIN
        INSERT  dbo.FOODCATEGORY
                ( Name, Avatar )
        VALUES  ( @name, @avatar );
    END;
GO

CREATE PROC UpdateFoodCategory
    @id INT ,
    @name NVARCHAR(100) ,
    @avatar IMAGE
AS
    BEGIN
        UPDATE  dbo.FOODCATEGORY
        SET     Name = @name ,
                Avatar = @avatar
        WHERE   Id = @id;
    END;
GO

CREATE PROC DeleteFoodCategory @id INT
AS
    BEGIN
        DELETE  dbo.FOODCATEGORY
        WHERE   Id = @id;
    END;
GO

CREATE PROC SearchFoodCategoryByName @name NVARCHAR(100)
AS
    BEGIN
        SELECT  Id N'Mã loại thực phẩm' ,
                Name N'Tên loại thực phẩm' ,
                Avatar N'Ảnh minh hoạ'
        FROM    dbo.FOODCATEGORY
        WHERE   ( dbo.fuConvertToUnsign(Name) LIKE N'%'
                  + dbo.fuConvertToUnsign(@name) + '%' );
    END;
GO

-- FOOD
CREATE TABLE FOOD
    (
      Id INT PRIMARY KEY
             IDENTITY ,
      Name NVARCHAR(100) DEFAULT N'Chưa đặt tên' ,
      IdCategory INT NOT NULL
                     FOREIGN KEY REFERENCES dbo.FOODCATEGORY ( Id ) ,
      Cost INT NOT NULL
               DEFAULT 0 , -- Giá vốn
      Price INT NOT NULL
                DEFAULT 0 , -- Giá bán ra
      Count INT DEFAULT 0 ,
      Avatar IMAGE
    );
GO

CREATE PROC GetListFood
AS
    BEGIN
        SELECT  F.Id N'Mã thực phẩm' ,
                F.Name N'Tên thực phẩm' ,
                FC.Name N'Tên loại thực phẩm' ,
                F.Cost N'Giá vốn' ,
                F.Price N'Giá bán' ,
                F.Count N'Số lượng' ,
                F.Avatar N'Ảnh minh hoạ'
        FROM    dbo.FOOD F ,
                dbo.FOODCATEGORY FC
        WHERE   F.IdCategory = FC.Id;
    END;
GO

CREATE PROC GetListFoodByIDFoodCategory @idFoodCategory INT
AS
    BEGIN
        SELECT  F.Id N'Mã thực phẩm' ,
                F.Name N'Tên thực phẩm' ,
                FC.Name N'Tên loại thực phẩm' ,
                F.Cost N'Giá vốn' ,
                F.Price N'Giá bán' ,
                F.Count N'Số lượng' ,
                F.Avatar N'Ảnh minh hoạ'
        FROM    dbo.FOOD F ,
                dbo.FOODCATEGORY FC
        WHERE   F.IdCategory = FC.Id
                AND FC.Id = @idFoodCategory;
    END;
GO

CREATE PROC InsertFood
    @name NVARCHAR(100) ,
    @idCategory INT ,
    @cost INT ,
    @price INT ,
    @count INT ,
    @avatar IMAGE
AS
    BEGIN
        INSERT  dbo.FOOD
                ( Name ,
                  IdCategory ,
                  Cost ,
                  Price ,
                  Count ,
                  Avatar
                )
        VALUES  ( @name ,
                  @idCategory ,
                  @cost ,
                  @price ,
                  @count ,
                  @avatar
                );
    END;
GO

CREATE PROC UpdateFood
    @id INT ,
    @name NVARCHAR(100) ,
    @idCategory INT ,
    @cost INT ,
    @price INT ,
    @count INT ,
    @avatar IMAGE
AS
    BEGIN
        UPDATE  dbo.FOOD
        SET     Name = @name ,
                IdCategory = @idCategory ,
                Cost = @cost ,
                Price = @price ,
                Count = @count ,
                Avatar = @avatar
        WHERE   Id = @id;
    END;
GO
    
CREATE PROC DeleteFood @id INT
AS
    BEGIN
        DELETE  dbo.FOOD
        WHERE   Id = @id;
    END;
GO

CREATE PROC SearchFoodByName @name NVARCHAR(100)
AS
    BEGIN
        SELECT  F.Id N'Mã thực phẩm' ,
                F.Name N'Tên thực phẩm' ,
                FC.Name N'Tên loại thực phẩm' ,
                F.Cost N'Giá vốn' ,
                F.Price N'Giá bán' ,
                F.Count N'Số lượng' ,
                F.Avatar N'Ảnh minh hoạ'
        FROM    dbo.FOOD F ,
                dbo.FOODCATEGORY FC
        WHERE   ( dbo.fuConvertToUnsign(F.Name) LIKE N'%'
                  + dbo.fuConvertToUnsign(@name) + '%' )
                AND F.IdCategory = FC.Id;
    END;
GO

-- BILL
CREATE TABLE BILL
    (
      Id INT PRIMARY KEY
             IDENTITY ,
      DateCheckIn DATETIME NOT NULL
                           DEFAULT GETDATE() ,
      DateCheckOut DATETIME DEFAULT NULL ,
      IdTableFood INT NOT NULL
                      FOREIGN KEY REFERENCES dbo.TABLEFOOD ( Id ) ,
      Status INT NOT NULL
                 DEFAULT 0 , -- 0: chưa thanh toán, 1: đã thanh toán
      Discount INT DEFAULT 0 ,
      TotalPrice INT DEFAULT 0,
    );
GO

CREATE PROC GetListBill
AS
    BEGIN
        SELECT  B.Id N'Mã hoá đơn' ,
                B.DateCheckIn N'Thời gian ghi' ,
                B.DateCheckOut N'Thời gian thanh toán' ,
                B.Discount N'Giảm giá' ,
                T.Name N'Tên bàn' ,
                B.TotalPrice N'Tổng tiền' ,
                CASE B.Status
                  WHEN 1 THEN N'Đã thanh toán'
                  ELSE N'Chưa thanh toán'
                END N'Trạng thái'
        FROM    dbo.BILL B ,
                dbo.TABLEFOOD T
        WHERE   B.IdTableFood = T.Id
                AND B.Status = 1;
    END;
GO

CREATE PROC InsertBill @idTableFood INT
AS
    BEGIN
        INSERT  dbo.BILL
                ( IdTableFood )
        VALUES  ( @idTableFood );
    END;
GO

CREATE PROC UpdateBill
    @id INT ,
    @status INT ,
    @discount INT ,
    @totalPrice INT
AS
    BEGIN
        UPDATE  dbo.BILL
        SET     DateCheckOut = GETDATE() ,
                Status = @status ,
                Discount = @discount ,
                TotalPrice = @totalPrice
        WHERE   Id = @id;
    END;
GO

CREATE PROC DeleteBill @id INT
AS
    BEGIN
        DELETE  dbo.BILL
        WHERE   Id = @id;
    END;
GO

CREATE PROC SearchBillByDate
    @dateCheckIn DATETIME ,
    @dateCheckOut DATETIME
AS
    BEGIN
        SELECT  B.Id N'Mã hoá đơn' ,
                B.DateCheckIn N'Thời gian ghi' ,
                B.DateCheckOut N'Thời gian thanh toán' ,
                B.Discount N'Giảm giá' ,
                T.Name N'Tên bàn' ,
                B.TotalPrice N'Tổng tiền' ,
                B.Status N'Trạng thái'
        FROM    dbo.BILL B ,
                dbo.TABLEFOOD T
        WHERE   B.IdTableFood = T.Id
                AND ( B.DateCheckIn >= @dateCheckIn
                      AND B.DateCheckOut <= @dateCheckOut
                    );
    END;
GO

CREATE PROC GetIDBillLatest
AS
    BEGIN
        SELECT  Id
        FROM    dbo.BILL
        ORDER BY Id DESC;
    END;
GO

CREATE PROC GetTotalPriceByIDBill @idBill INT
AS
    BEGIN
    
        SELECT  SUM(F.Price * BI.Count) N'Tổng tiền'
        FROM    dbo.BILL B ,
                dbo.BILLINFO BI ,
                dbo.FOOD F
        WHERE   ( B.Id = BI.IdBill
                  AND BI.IdFood = F.Id
                )
                AND B.Id = @idBill
        GROUP BY B.Id;
    END;
GO

-- BILLINFO
CREATE TABLE BILLINFO
    (
      Id INT PRIMARY KEY
             IDENTITY ,
      IdBill INT FOREIGN KEY REFERENCES dbo.BILL ( Id )
                 NOT NULL ,
      IdFood INT FOREIGN KEY REFERENCES dbo.FOOD ( Id )
                 NOT NULL ,
      Count INT NOT NULL
                DEFAULT 0,
    );
GO

CREATE PROC GetListBillInfo
AS
    BEGIN
        SELECT  BI.Id N'Mã chi tiết hoá đơn' ,
                BI.IdBill N'Mã hoá đơn' ,
                F.Name N'Tên thực phẩm' ,
                BI.Count N'Số lượng' ,
                BI.Count * F.Price N'Tổng tiền'
        FROM    dbo.BILLINFO BI ,
                dbo.BILL B ,
                dbo.FOOD F
        WHERE   BI.IdBill = B.Id
                AND BI.IdFood = F.Id;
    END;
GO

CREATE PROC GetBillInfoForTableFood @idTableFood INT
AS
    BEGIN
        SELECT  BI.Id N'Mã riêng' ,
                F.Name N'Tên thực phẩm' ,
                BI.Count N'Số lượng'
        FROM    dbo.BILLINFO BI ,
                dbo.BILL B ,
                dbo.TABLEFOOD T ,
                dbo.FOOD F
        WHERE   ( BI.IdBill = B.Id
                  AND B.IdTableFood = T.Id
                  AND BI.IdFood = F.Id
                )
                AND T.Id = @idTableFood
                AND B.Status = 0;
    END;
GO

CREATE PROC GetBillInfoForBill @idBill INT
AS
    BEGIN
        SELECT  BI.IdBill N'Mã hoá đơn' ,
                BI.Id N'Mã chi tiết hoá đơn' ,
                F.Name N'Tên thực phẩm' ,
                BI.Count N'Số lượng' ,
                BI.Count * F.Price N'Tổng tiền'
        FROM    dbo.BILLINFO BI ,
                dbo.BILL B ,
                dbo.FOOD F
        WHERE   BI.IdBill = B.Id
                AND BI.IdFood = F.Id
                AND B.Id = @idBill;
    END;
GO

CREATE PROC InsertBillInfo
    @idBill INT ,
    @idFood INT ,
    @count INT
AS
    BEGIN
        INSERT  dbo.BILLINFO
                ( IdBill, IdFood, Count )
        VALUES  ( @idBill, @idFood, @count );
    END;
GO

CREATE PROC UpdateBillInfo
    @id INT ,
    @idBill INT ,
    @idFood INT ,
    @count INT
AS
    BEGIN
        UPDATE  dbo.BILLINFO
        SET     IdBill = @idBill ,
                IdFood = @idFood ,
                Count = @count
        WHERE   Id = @id;
    END;
GO

CREATE PROC UpdateCountBillInfo @id INT, @count INT
AS
    BEGIN
        UPDATE  dbo.BILLINFO
        SET     Count += @count
        WHERE   Id = @id;
    END;
GO

CREATE PROC GetIDBillByIDBillInfo @idBillInfo INT
AS
    BEGIN
        SELECT  IdBill
        FROM    dbo.BILLINFO
        WHERE   Id = @idBillInfo;
    END;
GO

CREATE PROC DeleteBillInfo @id INT
AS
    BEGIN
        DELETE  dbo.BILLINFO
        WHERE   Id = @id;
    END;
GO

-- REPORT

-- Số nhân viên
CREATE PROC TotalStaff
AS
    BEGIN
        SELECT  COUNT(*)
        FROM    dbo.ACCOUNT;
    END;
GO

-- Số loại thực phẩm
CREATE PROC TotalCategory
AS
    BEGIN
        SELECT  COUNT(*)
        FROM    dbo.FOODCATEGORY;
    END;
GO

-- Số thực phẩm
CREATE PROC TotalFood
AS
    BEGIN
        SELECT  COUNT(*)
        FROM    dbo.FOOD;
    END;
GO

-- Số hoá đơn
CREATE PROC TotalBill
AS
    BEGIN
        SELECT  COUNT(*)
        FROM    dbo.BILL
        WHERE   Status = 1;
    END;
GO

-- Tiền vốn
CREATE PROC TotalCost
AS
    BEGIN
        SELECT  ( SUM(BI.Count) * F.Cost )
        FROM    dbo.FOOD F ,
                dbo.BILL B ,
                dbo.BILLINFO BI
        WHERE   ( F.Id = BI.IdFood
                  AND B.Id = BI.IdBill
                )
                AND B.Status = 1
        GROUP BY F.Name ,
                F.Cost;
    END;
GO

-- Tiền lãi
CREATE PROC TotalPrice
AS
    BEGIN
        SELECT  ( SUM(BI.Count) * F.Price )
        FROM    dbo.FOOD F ,
                dbo.BILL B ,
                dbo.BILLINFO BI
        WHERE   ( F.Id = BI.IdFood
                  AND B.Id = BI.IdBill
                )
                AND B.Status = 1
        GROUP BY F.Name ,
                F.Price;
    END;
GO

-- Số sản phẩm đã bán
CREATE PROC TotalProductSold
AS
    BEGIN
        SELECT  SUM(BI.Count)
        FROM    dbo.FOOD F ,
                dbo.BILL B ,
                dbo.BILLINFO BI
        WHERE   ( F.Id = BI.IdFood
                  AND B.Id = BI.IdBill
                )
                AND B.Status = 1
        GROUP BY F.Name;
    END;
GO

-- Báo cáo theo tháng (tên tháng, số sản phẩm đã bán, tiền lãi)
CREATE PROC Report
AS
    BEGIN
        SELECT  MONTH(B.DateCheckIn) N'Tháng' ,
                SUM(BI.Count) N'Số sản phẩm đã bán' ,
                SUM(B.TotalPrice) N'Tổng tiền'
        FROM    dbo.BILL B ,
                dbo.BILLINFO BI ,
                dbo.FOOD F
        WHERE   ( B.Id = BI.IdBill
                  AND BI.IdFood = F.Id
                )
                AND B.Status = 1
        GROUP BY MONTH(B.DateCheckIn);
    END;
GO

--INSERT  dbo.BILL
--        ( DateCheckIn, DateCheckOut, IdTableFood, Status, Discount, TotalPrice )
--VALUES  ( '2020-9-15', '2020-9-15', 1, 1, 0, 10000 ),
--        ( '2020-9-15', '2020-9-15', 1, 1, 0, 10000 ),
--        ( '2020-9-15', '2020-9-15', 1, 1, 0, 10000 );
--GO

--INSERT  dbo.BILLINFO
--        ( IdBill, IdFood, Count )
--VALUES  ( 20, 1, 1 ),
--        ( 21, 1, 1 ),
--		( 22, 1, 1 )
--GO

-- TRIGGER
CREATE TRIGGER tg_DeleteTableFood ON dbo.TABLEFOOD
    INSTEAD OF DELETE
AS
    BEGIN
        DECLARE @idTableFood INT;
        SET @idTableFood = ( SELECT Deleted.Id
                             FROM   Deleted
                           );

        DELETE  dbo.BILL
        WHERE   IdTableFood = @idTableFood;
        DELETE  dbo.TABLEFOOD
        WHERE   Id = @idTableFood;
    END;
GO

CREATE TRIGGER tg_DeleteBill ON dbo.BILL
    INSTEAD OF DELETE
AS
    BEGIN
        DECLARE @idBill INT;
        SET @idBill = ( SELECT  Deleted.Id
                        FROM    Deleted
                      );

        DELETE  dbo.BILLINFO
        WHERE   Id = @idBill;
        DELETE  dbo.BILL
        WHERE   Id = @idBill;
    END;
GO

CREATE TRIGGER tg_DeletedFoodCategory ON dbo.FOODCATEGORY
    INSTEAD OF DELETE
AS
    BEGIN
        DECLARE @idFoodCategory INT;
        SET @idFoodCategory = ( SELECT  Deleted.Id
                                FROM    Deleted
                              );
        DELETE  dbo.FOOD
        WHERE   IdCategory = @idFoodCategory;
        DELETE  dbo.FOODCATEGORY
        WHERE   Id = @idFoodCategory;
    END;
GO

CREATE TRIGGER tg_DeleteFood ON dbo.FOOD
    INSTEAD OF DELETE
AS
    BEGIN
        DECLARE @idFood INT;
        SET @idFood = ( SELECT  Deleted.Id
                        FROM    Deleted
                      );
        DELETE  dbo.BILLINFO
        WHERE   IdFood = @idFood;
        DELETE  dbo.FOOD
        WHERE   Id = @idFood;
    END;
GO