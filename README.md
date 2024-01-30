# Proyecto de Sistema de Inventario de Libros

## Descripción del Proyecto

Este proyecto es el resultado de una prueba técnica en la que  se pedía  desarrollar una aplicación web simplificada de gestión de biblioteca utilizando ASP.NET MVC.   La prueba definía dos tipos de requisitos:  funcionales y generales. Entre los requisitos generales estaba utilizar ASP.NET MVC con C#, base de datos SQL Server y tener claridad en la escritura del código. Los requisitos funcionales van relacionados con la funcionalidad de la aplicacion y  hacen referencia a las tres vistas que se pedían:  

1. Página Principal:  

- Mostrar una lista de todos los libros registrados.  

- Opción para agregar un nuevo libro.  

- Opción para agregar un nuevo autor.  

2. Gestión de Libros:  

- Al agregar un nuevo libro, se debe redirigir a una página con un formulario que solicite: título y autor (de una lista desplegable de autores existentes). 

3. Gestión de Autores:  

- Al agregar un nuevo autor, se debe redirigir a una página con un formulario que solicite: nombre del autor. 

4. Base de datos: 

- Utilizar Entity Framework para la interacción con la base de datos. 

- Tabla Libros: ID, título, autorID (clave foránea). 

- Tabla Autores: AutorID (clave primaria), nombre. 

- Relación entre las tablas. 

5. Adicionales  

- Implementación básica de diseño. 

- Validaciones básicas en los formularios. 

## Configuración y Ejecución

Siga los siguientes pasos para configurar y ejecutar la aplicación:

1. Cree la base de datos en SQL Server ejecutando el script `DB_Library.sql` que se encuentra en la carpeta del proyecto.

2. Obtenga la cadena de conexión a la base de datos y modifique el campo `DBLibraryConnection` en el archivo `appsettings.json` con su valor.

3. Asegúrese de tener instalado .NET Core 6 o superior.

4. Ejecute el siguiente comando en la CLI de .NET:

   ```bash
   dotnet run
   ```
5. Si lo ejecuta en consola el proyecto se verá en alguna de las siguientes rutas: 

- [https://localhost:7095](https://localhost:7095) 

- [http://localhost:5236](http://localhost:5236)

6. O abrir la solución `LibraryASPMVC.sln` en Visual Studio, realizar pasos 1, 2, compilar y ejecutar.

- [https://localhost:44390](https://localhost:44390) 

## Capturas de pantalla

### Inicial o Home

![Home](/Images/Home.png)

### Autores

![Autores](/Images/Author.png)

### Libros

![Libros](/Images/Book.png)

### Validaciones

![Validación 1](/Images/valid1.png)

![Validación 2](/Images/Valid2.png)

### Diagrama Entidad Relación

![Diagrama](/Images/EntidadR.png)

![Diagrama](/Images/Dbdiagram.png) 