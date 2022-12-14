# Welcome to my Angular-ASP Zoo app!

Table of Contents

| Sections      | Title                   |
| :-:           | :-                      | 
| 1             | Design Document         |
| 2             | Technical Specifcation  | 

<br><br>

# 1] Design Document

A zoo management SPA for zoo visitors to book a visit or view the animals and posts, and for zoo staff to manage all animals, create posts and manage bookings.


## Functionality

    Visitor
    - Create an account
    - Manage their account
    - Create a booking
    - Ammend or cancel booking
    - View all public animals
    - View all public posts

    Staff
    - Manage bookings
    - Manage all animals
    - Create posts

    Staff Admin
    - Manage all accounts
    - Manage all animals


## Pages

| Page & Components       | User              | Description |
| :-                      | :-                | :-          |
| Homepage                | Staff, Visitor    | Welcome page to the application |
| Staff Dashboard         | Staff             | Dashboard for staff |
| account-creator         | Anonymous, Admin  | Create an account |
| account-manager         | All               | Manage this account |
| account-manager-admin   | Admin             | Manage all accounts |
| booking-creator         | Everyone          | Create a booking |
| booking-manager         | Everyone          | Manage a booking |
| navbar                  | Everyone          | Navigation to all pages |
| footer                  | Everyone          | General links & contact etc... |

<br><br><br>


# 2] Technical Specification

I am Following the course "Build an app with ASPNET Core and Angular from scratch" from [Udemy](https://www.udemy.com/course/build-an-app-with-aspnet-core-and-angular-from-scratch/).

It uses a ASP.NET's MVC, for joining the Angular frontend with the ASP.NET SQLite backend. 

## Tools Used
Developed on my main computer 'Valkyrie' and laptop 'Duo-Pro' with the following tools:

- Angular CLI 14.1.1
- Node 16.18.1
- npm 9.1.2
- .NETCore 6.0.11
- TypeScript 4.8.4
- win32 x64


## Skills involved

1. ASP.NET v2.1
2. Angular v14
3. Entity Framework Core
4. Postman - API Platform

## VS Code Extentions

* C#
* C# Extentions
* NuGet Gallery
* SQlite

## Packages

  `Microsoft.EntityFrameworkCore.Sqlite` | Entity Framework SQLite for API

  `Microsoft.EntityFrameworkCore.Design` | Entity Framework Design for API ef migrations

```console
`dotnet tool install --global dotnet-ef --version 7.0.0-rc.2.22472.11`
dotnet-ef for API (Get the version to match your .NET Core version)

`dotnet new gitignore` | Gitignore specific to dotnet

`dotnet dev-certs https --trust
```

## CLI Commands

```console
>>dotnet run

>>dotnet watch run
//

>>dotnet ef migrations add InitialCreate -o Data/Migrations 
//Migrate current C# code into SQL schemas with the name 'InitialCreate'

>>dotnet ef database update
//Creates/updates a database                  

>>dotnet ef migrations add NewName
//Creates a new migration for any new changes to the entity framework schema          

>>dotnet ef database update
//Updates the existing database with the new migration schema
```

## Key learning points

Trust ASP.NET Http certification

```console
dotnet dev-certs https --trust
```

SSL Certificate created and applied, it's on .gitignore

Protected: This class or any classes which inherit this class can access this variable

Private: Only this class can access this variable


## Angular


## ASP.NET

```console
prop //Generates a property boilterplate
```


## SQL

This course uses SQLite which stores the database in a local file, it is only for <i>develoment<i/> purposes


## Entity Framework | Microsoft

An Object Relational Mapper (ORM) which translates code into SQL for our tables in the database. (Creates schemas)

```console
DbContext.Users.Add(new User {Id = 4, Name = Lee})  //Input

INSERT INTO Users(Id, Name) VALUES(4, Lee)          //Ouput
```
* Querying
* Change Tracking
* Saving
* Concurrency
* Transactions
* Caching
* Built-in conventions
* Migrations