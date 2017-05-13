/*
Created		22.03.2017
Modified		10.05.2017
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/



















Create table [notebook]
(
	[producer_code] Nvarchar(25) NOT NULL,
	[color] Nvarchar(20) NOT NULL,
	[width] Float NOT NULL,
	[height] Float NOT NULL,
	[depth] Float NOT NULL,
	[weight] Float NOT NULL,
	[id_display] Integer NOT NULL,
	[id_cpu] Integer NOT NULL,
	[id_ram] Integer NOT NULL,
	[id_hdd] Integer NOT NULL,
	[label] Nvarchar(50) NOT NULL,
	[type] Nvarchar(256) NOT NULL,
	[hash] Nvarchar(64) NOT NULL,
Primary Key ([producer_code],[color],[width],[height],[depth],[weight],[id_display],[id_cpu],[id_ram],[id_hdd],[label],[type],[hash])
) 
go

Create table [display]
(
	[id_display] Integer Identity NOT NULL, UNIQUE ([id_display]),
	[diagonal] Float NULL,
	[width] Integer NULL,
	[height] Integer NULL,
	[label] Nvarchar(10) NULL,
Primary Key ([id_display])
) 
go

Create table [cpu]
(
	[id_cpu] Integer Identity NOT NULL, UNIQUE ([id_cpu]),
	[type] Nvarchar(256) NULL,
	[number_cores] Integer NULL,
Primary Key ([id_cpu])
) 
go

Create table [ram]
(
	[id_ram] Integer Identity NOT NULL, UNIQUE ([id_ram]),
	[type] Nvarchar(256) NULL,
	[frequency] Integer NULL,
	[size] Integer NULL,
Primary Key ([id_ram])
) 
go

Create table [hdd]
(
	[id_hdd] Integer Identity NOT NULL, UNIQUE ([id_hdd]),
	[type] Nvarchar(256) NULL,
	[size] Integer NULL,
Primary Key ([id_hdd])
) 
go

Create table [os]
(
	[label] Nvarchar(50) NOT NULL,
Primary Key ([label])
) 
go

Create table [gpu]
(
	[type] Nvarchar(256) NOT NULL,
Primary Key ([type])
) 
go

Create table [imported_files]
(
	[hash] Nvarchar(64) NOT NULL,
Primary Key ([hash])
) 
go

Create table [top_search]
(
	[pattern] Nvarchar(450) NOT NULL, UNIQUE ([pattern]),
	[count] Integer NULL,
Primary Key ([pattern])
) 
go





Alter table [notebook] add  foreign key([id_display]) references [display] ([id_display])  on update no action on delete no action 
go
Alter table [notebook] add  foreign key([id_cpu]) references [cpu] ([id_cpu])  on update no action on delete no action 
go
Alter table [notebook] add  foreign key([id_ram]) references [ram] ([id_ram])  on update no action on delete no action 
go
Alter table [notebook] add  foreign key([id_hdd]) references [hdd] ([id_hdd])  on update no action on delete no action 
go
Alter table [notebook] add  foreign key([label]) references [os] ([label])  on update no action on delete no action 
go
Alter table [notebook] add  foreign key([type]) references [gpu] ([type])  on update no action on delete no action 
go
Alter table [notebook] add  foreign key([hash]) references [imported_files] ([hash])  on update no action on delete no action 
go


Set quoted_identifier on
go


CREATE PROCEDURE [dbo].[sp_responseConsistency] 
	@producer_code NVarchar(25)
AS
BEGIN
	SET NOCOUNT ON;
DECLARE @consistency Bit

SELECT @consistency=(color_consistency | width_consistency | height_consistency | depth_consistency | weight_consistency | display_diagonal_consistency | display_width_consistency | 
display_height_consistency | display_label_consistency | cpu_type_consistency | cpu_cores_consistency | ram_type_consistency | ram_frequency_consistency | 
ram_size_consistency | hdd_type_consistency | hdd_size_consistency | os_label_consistency | gpu_type_consistency)
FROM fn_consistency()
WHERE producer_code=@producer_code

print @producer_code + ':' + 
cast(@consistency as varchar)

END
GO






CREATE FUNCTION fn_notebooks 
()
RETURNS TABLE 
AS
RETURN 
(
SELECT n.hash, n.producer_code, n.color, n.width, n.height, n.depth, n.weight, 
		d.diagonal as display_diagonal, d.width as display_width, d.height as display_height, d.label as display_label, 
		c.type as cpu_type, c.number_cores as cpu_cores, 
		r.type as ram_type, r.frequency as ram_frequency, r.size as ram_size, 
		h.type as hdd_type, h.size as hdd_size, 
		o.label as os_label,
		g.type as gpu_type 
FROM notebook n, display d, cpu c, ram r, hdd h, os o, gpu g
WHERE n.id_display = d.id_display and n.id_cpu = c.id_cpu and n.id_ram = r.id_ram and n.id_hdd = h.id_hdd and n.label = o.label and n.type = g.type
)
GO

CREATE FUNCTION fn_consistency 
()
RETURNS TABLE 
AS
RETURN 
(
	SELECT distinct(producer_code), 
		cast(count(distinct(color)) -1 AS bit) as color_consistency,
		cast(count(distinct(width)) -1 AS bit) as width_consistency,
		cast(count(distinct(height)) -1 AS bit) as height_consistency,
		cast(count(distinct(depth)) -1 AS bit) as depth_consistency,
		cast(count(distinct(weight)) -1 AS bit) as weight_consistency,
		cast(count(distinct(display_diagonal)) -1 AS bit) as display_diagonal_consistency,
		cast(count(distinct(display_width)) -1 AS bit) as display_width_consistency,
		cast(count(distinct(display_height)) -1 AS bit) as display_height_consistency,
		cast(count(distinct(display_label)) -1 AS bit) as display_label_consistency,
		cast(count(distinct(cpu_type)) -1 AS bit) as cpu_type_consistency,
		cast(count(distinct(cpu_cores)) -1 AS bit) as cpu_cores_consistency,
		cast(count(distinct(ram_type)) -1 AS bit) as ram_type_consistency,
		cast(count(distinct(ram_frequency)) -1 AS bit) as ram_frequency_consistency,
		cast(count(distinct(ram_size)) -1 AS bit) as ram_size_consistency,
		cast(count(distinct(hdd_type)) -1 AS bit) as hdd_type_consistency,
		cast(count(distinct(hdd_size)) -1 AS bit) as hdd_size_consistency,
		cast(count(distinct(os_label)) -1 AS bit) as os_label_consistency,
		cast(count(distinct(gpu_type)) -1 AS bit) as gpu_type_consistency
	FROM fn_notebooks()
	GROUP BY producer_code
)
GO







CREATE VIEW v_notebooks
AS
SELECT        n.hash, n.producer_code, n.color, n.width, n.height, n.depth, n.weight, n.display_diagonal, n.display_width, n.display_height, n.display_label, n.cpu_type, n.cpu_cores, n.ram_type, n.ram_frequency, n.ram_size, 
                         n.hdd_type, n.hdd_size, n.os_label, n.gpu_type, c.color_consistency, c.width_consistency, c.height_consistency, c.depth_consistency, c.weight_consistency, c.display_diagonal_consistency, 
                         c.display_width_consistency, c.display_height_consistency, c.display_label_consistency, c.cpu_type_consistency, c.cpu_cores_consistency, c.ram_type_consistency, c.ram_frequency_consistency, 
                         c.ram_size_consistency, c.hdd_type_consistency, c.hdd_size_consistency, c.os_label_consistency, c.gpu_type_consistency
FROM            dbo.fn_consistency() AS c INNER JOIN
                         dbo.fn_notebooks() AS n ON c.producer_code = n.producer_code
GO








CREATE TRIGGER t_Condition 
   ON  top_search
   INSTEAD OF INSERT,UPDATE
AS 
DECLARE @pattern NVarChar(1024)
DECLARE @count Integer
BEGIN
	SET NOCOUNT ON;
	SET @pattern = (SELECT pattern FROM inserted)
	IF NOT EXISTS(SELECT pattern FROM top_search WHERE pattern = @pattern)
	BEGIN
		INSERT INTO top_search(pattern, [count]) VALUES(@pattern, 0)
	END

	SET @count = (SELECT [count] FROM top_search WHERE pattern = @pattern)
	UPDATE top_search SET [count] = @count + 1 WHERE pattern = @pattern
END
GO




CREATE TRIGGER t_notebooksInsert ON v_notebooks
INSTEAD OF INSERT
AS
DECLARE @hash NVarChar(64)
DECLARE @producer_code NVarChar(25)
DECLARE @color NVarChar(20)
DECLARE @width float
DECLARE @height float
DECLARE @depth float
DECLARE @weight float
DECLARE @display_diagonal float
DECLARE @display_width float
DECLARE @display_height float
DECLARE @display_label NVarChar(10)
DECLARE @cpu_type NVarChar(256)
DECLARE @cpu_cores Integer
DECLARE @ram_type NVarChar(256)
DECLARE @ram_frequency Integer
DECLARE @ram_size Integer
DECLARE @hdd_type NVarChar(256)
DECLARE @hdd_size Integer
DECLARE @gpu_type NVarChar(256)
DECLARE @os_label NVarChar(256)

DECLARE @id_display Integer
DECLARE @id_cpu Integer
DECLARE @id_ram Integer
DECLARE @id_hdd Integer
BEGIN

	SET NOCOUNT ON;
	SET @hash			  = (SELECT hash FROM inserted)
	SET @producer_code    = (SELECT producer_code FROM inserted)
	SET @color		      = (SELECT color FROM inserted)
	SET @width		      = (SELECT width FROM inserted)
	SET @height		      = (SELECT height FROM inserted)
	SET @depth	          = (SELECT depth FROM inserted)
	SET @weight			  = (SELECT weight FROM inserted)
	SET @display_diagonal = (SELECT display_diagonal FROM inserted)
	SET @display_width    = (SELECT display_width FROM inserted)
	SET @display_height   = (SELECT display_height FROM inserted)
	SET @display_label	  = (SELECT display_label FROM inserted)
	SET @cpu_type		  = (SELECT cpu_type FROM inserted)
	SET @cpu_cores		  = (SELECT cpu_cores FROM inserted)
	SET @ram_type		  = (SELECT ram_type FROM inserted)
	SET @ram_frequency	  = (SELECT ram_frequency FROM inserted)
	SET @ram_size		  = (SELECT ram_size FROM inserted)
	SET @hdd_type		  = (SELECT hdd_type FROM inserted)
	SET @hdd_size		  = (SELECT hdd_size FROM inserted)
	SET @gpu_type		  = (SELECT gpu_type FROM inserted)
	SET @os_label		  = (SELECT os_label FROM inserted)

	IF NOT EXISTS(SELECT hash FROM imported_files WHERE hash=@hash)
	BEGIN
		INSERT INTO imported_files(hash) VALUES(@hash)
	END

	IF NOT EXISTS(SELECT id_display FROM display d WHERE d.diagonal = @display_diagonal AND d.height = @display_height AND d.label = @display_label AND d.width = @display_width)
	BEGIN
		INSERT INTO display(diagonal, width, height, label) VALUES (@display_diagonal, @display_width, @display_height, @display_label)
	END
	SET @id_display = (SELECT id_display FROM display d WHERE d.diagonal = @display_diagonal AND d.height = @display_height AND d.label = @display_label AND d.width = @display_width)

	IF NOT EXISTS(SELECT id_cpu FROM cpu c WHERE c.type = @cpu_type AND c.number_cores = @cpu_cores)
	BEGIN
		INSERT INTO cpu(type, number_cores) VALUES (@cpu_type, @cpu_cores)
	END
	SET @id_cpu = (SELECT id_cpu FROM cpu c WHERE c.type = @cpu_type AND c.number_cores = @cpu_cores)

	IF NOT EXISTS(SELECT id_ram FROM ram r WHERE r.type = @ram_type AND r.frequency = @ram_frequency AND r.size = @ram_size)
	BEGIN
		INSERT INTO ram(type, frequency, size) VALUES (@ram_type, @ram_frequency, @ram_size)
	END
	SET @id_ram = (SELECT id_ram FROM ram r WHERE r.type = @ram_type AND r.frequency = @ram_frequency AND r.size = @ram_size)

	IF NOT EXISTS(SELECT id_hdd FROM hdd h WHERE h.type = @hdd_type AND h.size = @hdd_size)
	BEGIN
		INSERT INTO hdd(type, size) VALUES (@hdd_type, @hdd_size)
	END
	SET @id_hdd = (SELECT id_hdd FROM hdd h WHERE h.type = @hdd_type AND h.size = @hdd_size)

	IF NOT EXISTS(SELECT type FROM gpu g WHERE g.type = @gpu_type)
	BEGIN
		INSERT INTO gpu(type) VALUES (@gpu_type)
	END

	IF NOT EXISTS(SELECT label FROM os o WHERE o.label = @os_label)
	BEGIN
		INSERT INTO os(label) VALUES (@os_label)
	END
	
	IF NOT EXISTS(SELECT producer_code FROM notebook n WHERE n.hash = @hash AND n.producer_code = @producer_code AND n.color = @color AND n.width = @width AND n.height = @height AND
 															    n.depth = @depth AND n.weight = @weight AND n.id_display = @id_display AND n.id_cpu = @id_cpu AND 
 																n.id_ram = @id_ram AND n.id_hdd = @id_hdd AND n.label = @os_label AND n.type = @gpu_type)
	BEGIN
		INSERT INTO notebook(hash, producer_code, color, width, height, depth, weight, id_display, id_cpu, id_ram, id_hdd, label, type)
			VALUES(@hash, @producer_code, @color, @width, @height, @depth, @weight, @id_display, @id_cpu, @id_ram, @id_hdd, @os_label, @gpu_type)
	END
	execute sp_responseConsistency @producer_code
	RETURN
END



Set quoted_identifier off
go





