# Project Clothing Size API 

#### By Zoe Weinstein, Amy Young, Chris Nakayama, Wajma Niazi, Jonathan Delcid 


## Technologies Used

* VS Code
* C# 
* .NET 5.0
* MySQL
* ASP.NET Core
* Entity Framework
* Swagger
* Swashbuckle

## Description
* Create an database for clothing size. The API will list the available clothing size for major brands 
* Full CRUD functionality and successfully returns responses to API calls.
* Using Swagger documentation to access the database.

## Setup/Installation Requirements
 
* Go to GitHub: https://github.com/MxZoe/ClothingSizeApi.Solution/tree/main/ClothingSizeApi
* Clone Repository to your desktop
* If you haven't already, please download the following: C#, .NET, MySQL Community Server and MySQL Workbench.  Please go to https://www.learnhowtoprogram.com/c-and-net-part-time/getting-started-with-c/installing-c-and-net, if you need to download C# and .NET and  https://www.learnhowtoprogram.com/c-and-net-part-time/getting-started-with-c/installing-and-configuring-mysql, if needed to download MySQL. 
* Launch the MySQL server with the command mysql -uroot -p[YOUR-PASSWORD-HERE]
* Go to MySQL Workbench, select Data Import/Restore, then navigate to  wajma_niazi.sql file in the root directory of the project (AnimalShelter/)
* Navigate to the appsettings.json file $ cd appsettings.json and enter:
```
{
  "Logging":
  {
    "LogLevel":
    {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings":
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=clothingsizeapi;uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"
  }
}
``` 
* Swagger:Swagger UI offers a web-based UI that provides information about the service, using the generated OpenAPI specification. Swashbuckle includes an embedded version of Swagger UI

* dotnet add Shelter.csproj package Swashbuckle.AspNetCore -v 6.2.3.  and dotnet tool install -g Microsoft.dotnet-openapi

* For more information please go to https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio-code#package-installation-1

* Add the Swagger generator to the services collection in the Startup.ConfigureServices
```
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<ClothingSizeApiContext>(opt =>
        opt.UseInMemoryDatabase("YOURPROJECTSNAME"));
    services.AddControllers();

    // Register the Swagger generator, defining 1 or more Swagger documents
    services.AddSwaggerGen();
}
```
*  In the Startup.Configure method
```
using Microsoft.OpenApi.Models;


public void Configure(IApplicationBuilder app)
{
    // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger(c =>
    {
        c.SerializeAsV2 = true;
    });

    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
    // specifying the Swagger JSON endpoint.
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });

    app.UseRouting();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}
```

* $ dotnet build 
* Set up the initial Migrations /on terminal: $ dotnet ef migrations add Initial
* Updating the database while on terminal: $ dotnet ef database update
* $ dotnet run

## API Endpoints
```
*GET /api/Brands 
*GET /api/Brands?{key}={value}
**Brand key query options: brandid, clothingtype, gender, xxxs, xxs, xs, s, m, l, xl, xxl, xxxl, xxxxl
*Get /api/Brands/{id}
*POST /api/Brands 
*PUT /api/Brands/{id} 
*Delete /api/Brands/{id} 

*GET /api/Sizes 
*GET /api/Sizes?{key}={value}
**Size key query options: sizeid, clothingtype, gender, lettersize, neck, chest, sleeve, waist, hip inseam
*Get /api/Sizes/{id}
*POST /api/Sizes
*PUT /api/Sizes/{id} 
*Delete /api/Sizes/{id} 
```

## Known Bugs
* None 

## License

_MIT

Copyright (c) 2022 
Zoe Weinstein <zweinstein@gmail.com>
Amy Young <youngamy1223@gmail.com>
Chris Nakayama <cnakayam@gmail.com>	
Wajma Niazi  <w1niazi@hotmail.com>
Jonathan Delcid <jdelcid23@gmail.com>
