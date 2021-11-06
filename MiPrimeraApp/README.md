TUTORIAL INICIAL ASP.NET CORE 5.0

    dotnet run: Ejecutar el programa
    dotnet build: Compilar el programa y verificar si hay errores
    dotnet --version: Verificar la versión del SDK del .Net

    1) Descargar e instalar .Net core 5.0 https://dotnet.microsoft.com/download

    2) Instalar Visual Studio Code
        Instalar extensiones:
            C# for Microsoft
            C# Extension jchannon
            C# Extension JosKreativ

    3) Se debe instalar el Framework Entity de forma global
        dotnet tool install --global dotnet-ef (instalación)
        dotnet tool update --global dotnet-ef(actualización)

    4) Instalar la solución de Entity Framework (el programa que se va a construir)
        dotnet new sln -o MiPrimeraApp ("MiPrimeraApp es el nombre del programa a construir)

    5) Instalar las librerias para generar la conexión con la base de datos e implementar las entidades del programa
        dotnet new classlib -o MiPrimeraApp.Persistencia
        dotnet new classlib -o MiPrimeraApp.Dominio

    6) Instalar la aplicación web para crear el frontend del programa
        dotnet new webapp -o MiPrimeraApp.Frontend

    7) Instalar la libreria de consola para realizar pruebas del programa
        dotnet new console -o MiPrimeraApp.Consola
    
    8) Instalación de paquetes:
            --version 5.0.9 (Opcional para instalar una versión específica)
        dotnet add package Microsoft.EntityFameworkCore (Carpeta Persistencia)
        dotnet add package Microsoft.EntityFameworkCore.Tools (Carpeta Persistencia)
        dotnet add package Microsoft.EntityFameworkCore.Design (Carpeta Consola y Persistencia)
        dotnet add package Microsoft.EntityFameworkCore.SqlServer (Carpeta Persistencia)
    
    9) Crear las referencias a las carpetas de Persistencia y Dominio; siempre y cuando analicemos las uniones que debemos realizar dentro de los .csproj
        dotnet add reference ..\MiPrimeraApp.Dominio\ (En la carpeta Persistencia y Consola)
        dotnet add reference ..\MiPrimeraApp.Persistencia\(En la carpeta Consola)

    10) Crear las entidades en la carpeta Dominio

    11) Crear el AppContext para realizar el mapeo de las entidades para crear la migración y crear la conexión con la base de datos (Sql Server)

    12) Crear la migración a la base de datos
         dotnet ef migrations add Inicial --startup-project ..\MiPrimeraApp.Console\ (Crear migración)
         dotnet ef database update --startup-project ..\MiPrimeraApp.Console\ (Actualizar migraciones)