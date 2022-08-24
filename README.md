# Sekmen.LoadBalancing

## Chapter 1 - Local Balancing
This chapter will take you through how to configure Umbraco v10 to exist in a load balanced environment on your local development machine.

## Chapter 2: Azure with Umbraco
This chapter will take you through how to configure Umbraco v10 to be hosted as a scalable Azure Web App

## Requirements

- Umbraco 10 (latest version)
- .NET6 (and hosting bundle)
- IIS
- SQL Server
- Visual Studio 2022
- SQL Server Management Studio
- Active Microsoft Azure subscription (paid or trial)
- Azure Storage Explorer

### Project setup

1. Create a database
2. Follow the instructions here to create a new blank Umbraco project locally: https://our.umbraco.com/documentation/Fundamentals/Setup/Install/install-umbraco-with-templates
3. Run the project and do the initial setup 
4. Install Umbraco.TheStarterKit from nuGet. The package contains the necessary files for most of our courses
5. Run the site (don2t worry about the errors), goto /umbraco and generate models
6. Stop/start the application (to compile the generated models)

#### Exercise Files

- Web: https://training.umbraco.com/resources
- Password: ShouldIStayOrShouldILoad1992
- PDF: [LoadBalancing.pdf](/Docs/LoadBalancing___ShouldIStayOrShouldILoad1992.pdf)
