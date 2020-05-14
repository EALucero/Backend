CREATE TABLE [dbo].[Table]
(
	[id_Alumnos] NUMERIC NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [Apellido] NVARCHAR(50) NOT NULL, 
    [Club] NVARCHAR(50) NULL, 
    [id_Curso] NUMERIC NOT NULL
)
