# Readme

## Introduction
This project was developed as an exercise to build a small CRM customer management application.

## Requirements
- Manage customers
- Change status
- Enter some basic contact details
- Filter and sort customers 
- Manage customer notes

## Technical
### Technology
- .NET core 2.2 
- Entity Framework Core
- MVC (razor pages)

### Project structure
- **Web** : This project will be the startup project to launch our .NET MVC application. Frontend and backend are hosted in one project (using the MVC framework)
- **Data** : Shared project with the webproject that will handle all database access operations (using Entity Framework). 
- **Database** : No specific database project is required, since we are using .NET Entity Framework migrations to upgrade our SQL database.
- **Test.Unit** : This project will contain all unit tests. Keep in mind tha this project does not have any dependency to a given external system and should run very fast and mock away all external dependencies. 
- **Test.Integration** : This project will contain integration tests that will verify our ORM code towards the database. Since they could run a little slower compared to the unit tests, we could run these tests in a nightly build (instead of our CI build)