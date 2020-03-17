# _Inventory Collections_

#### _MySQL & Entity Framework Core Practice for Epicodus_, _Mar. 17 2020_

#### By _**Brandan Sayarath, Michelle Morin, Geoff Goetz**_

## Description

_This application allows a user to track their inventory collections. The splash page includes a link to view all collections a user has added, and each collection is clickable to view details about the collection (type of collection and description)._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application creates instance of a Collection object | Collection newCollection = new Collection(type, description) | new Collection object created |
| Application saves all new collections in database table named collections | new collection object instantiated | new collection object saved as row in database table |
| If user visits '/' root route, applications displays splash page with link to '/collections' | user visits '/' route | displays homepage |
| If user visits '/collections' route, applications displays all collections in database, each with a link to view more details about the animal and ordered alphabetically by type | user visits '/collections' route | displays list of collections |
| If user clicks "add new collection" button, application redirects to new collection form | user clicks "add new collection" button | application redirects to new collection form |
| If user visits '/collection/new', application shows new collection form | user visits '/collection/new' | application displays form for adding new collection |
| If user visits submits new collection form, application adds new collection to database and redirects to '/collection' | user submits form | application adds new collection to database and redirects to page showing all collections in database |
| If user visits '/collections/{id}', application displays details for that collection | user clicks on specific collection in collections list | application redirects to display details about that collection |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository
* ``cd Inventory.Solution``

_Confirm that you have navigated to the ToDoList.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd Inventory``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet run`` or ``dotnet watch run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _ASP.NET Core MVC_
* _dotnet script_
* _MySQL_
* _MySQL Workbench_
* _Entity Framework Core_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Brandan Sayarath, Michelle Morin, Geoff Goetz_**