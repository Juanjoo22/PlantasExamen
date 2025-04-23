-- Base de datos CategoriasDB
CREATE TABLE Categorias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NombreCategoria NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(500),
    FechaCreacion DATETIME DEFAULT GETDATE(),
    Activa BIT DEFAULT 1
);

-- Base de datos PlantasDB
CREATE TABLE Plantas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    NombreCientifico NVARCHAR(150),
    Descripcion NVARCHAR(500),
    RequisitosCuidado NVARCHAR(500),
    Precio DECIMAL(10, 2) CHECK (Precio >= 0),
    Stock INT DEFAULT 0,
    CategoriaId INT NOT NULL,
    FechaRegistro DATETIME DEFAULT GETDATE(),
    Activa BIT DEFAULT 1,
    FOREIGN KEY (CategoriaId) REFERENCES CategoriasDB.dbo.Categorias(Id)
);