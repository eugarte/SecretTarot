# A simple, cross platform, modularized ecommerce system built on .NET Core

[![Join the chat at https://gitter.im/SecretTarot/SecretTarot](https://badges.gitter.im/SecretTarot/SecretTarot.svg)](https://gitter.im/SecretTarot/SecretTarot?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

## Build Status
| Build server| Platform       | Status      |
|-------------|----------------|-------------|
| AppVeyor    | Windows        |[![Build status](https://ci.appveyor.com/api/projects/status/cq61prgs6ta8e9hi/branch/master?svg=true)](https://ci.appveyor.com/project/thiennn/SecretTarot/branch/master) |
|Travis       | Linux / MacOS  |[![Build Status](https://travis-ci.org/SecretTarot/SecretTarot.svg?branch=master)](https://travis-ci.org/SecretTarot/SecretTarot) |

## Online demo (Azure Website)
- Store front: http://demo.SecretTarot.com
- Administration: http://demo.SecretTarot.com/admin Email: admin@SecretTarot.com Password: 1qazZAQ!

## Docker
- First run the database: `docker run --name simpldb -d postgres`
- Then run the app: `docker run --name simplsite -d -p 5000:80 --link simpldb:simpldb SecretTarot/nightly-build`


## Visual Studio 2017 and SQL Server

#### Prerequisites

- SQL Server
- [Visual Studio 2017 version >= 15.8 with .NET Core SDK 2.1.402](https://www.microsoft.com/net/download/all)
- Node.js (LTS)

#### Steps to run

- Update the connection string in appsettings.json in SecretTarot.WebHost
- Build whole solution.
- Open Package Manager Console Window and type "Update-Database" then press "Enter". This action will create database schema.
- In Visual Studio, press "Control + F5".
- The back-office can access via /Admin using the pre-created account: admin@SecretTarot.com, 1qazZAQ!

## Mac/Linux with PostgreSQL

#### Prerequisite

- PostgreSQL
- [.NET Core SDK 2.1.402](https://www.microsoft.com/net/download/all)
- Node.js (LTS)

#### Steps to run

- Update the connection string in appsettings.json in SecretTarot.WebHost.
- Run file simpl-build.sh by "sudo ./simpl-build.sh". For ubuntu 18 "sudo bash simpl-build.sh"
- In the terminal, navigate to the "src/SecretTarot.WebHost" type "dotnet run" and hit "Enter".
- Open browser, open http://localhost:5000. The back-office can access via /Admin using the pre-created account: admin@SecretTarot.com, 1qazZAQ!

## Technologies and frameworks used:
- ASP.NET MVC Core 2.1
- Entity Framework Core 2.1
- ASP.NET Identity Core 2.1
- Autofac 4.3
- Angular 1.6.3
- MediatR 5.0.1 for domain event

## Docs

http://docs.SecretTarot.com

## Roadmap

https://github.com/SecretTarot/SecretTarot/wiki/Roadmap

## How to contribute

- Star this project on GitHub.
- Report bugs or suggest features by create new issues or add comments to issues
- Submit pull requests
- Spread the word by blogging about SecretTarot or sharing it on social networks
- Donate us 

     [![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=JWYGHJQSYLVVQ)

## License

SecretTarot is licensed under the Apache 2.0 license.
