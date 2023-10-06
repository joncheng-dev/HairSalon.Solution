# Eau Claire's Salon

#### A C# web application.

#### By Jonathan Cheng

## Technologies Used

- _C#_
- _HTML_
- _.NET 6_
- _ASP.NET Core MVC_
- _Razor View Engine_
- _MySQL Workbench_ 
- _MySQL Community Server_
- _Entity Framework Core_

<p align="center"><img src="./wwwroot/img/database-schema.png" alt="schema of database relationship"></p>

## Description

- _._

## Setup/Installation Requirements

### Required Technology

_1. Check that you have the required technology installed for MySql (https://dev.mysql.com/doc/mysql-installation-excerpt/5.7/en/) and MySql Workbench (https://dev.mysql.com/doc/workbench/en/)._

### Setting Up the Project

_1. Open your terminal (e.g., Terminal or GitBash)._

_2. Navigate to where you want to place the cloned directory._

_3. Clone the repository from the GitHub link by entering in this command:_

> ```bash
> $ git clone https://github.com/joncheng-dev/HairSalon.Solution.git
> ```

_4. Navigate to the project's production directory `HairSalon.Solution`, and create a new file called `appsettings.json`._

_5. Within `appsettings.json`, put in the following code, replacing the `uid`, and `pwd` values with your username and password for MySQL._ 
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
```

### Importing / Setting up the Database

_1. In MySql Workbench's Navigator > Administration window, select Data Import/Restore._

_2. In Import Options, select Import from Self_Contained File._ 

_3. Navigate to the file `jonathan_cheng.sql` found in the project's root directory._

_4. Under Default Schema to be Imported To, select the New button._

_5. Enter the name of the database as `hair_salon` or another name of your choosing. If you do choose to use a different name for your database, replace `hair_salon` in the `appsettings.json` file `ConnectionStrings` object `DefaultConnection` substring `database=hair_salon` as `database=[YOUR-DB-NAME-HERE]` accordingly. Click Ok._

_6. Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window._


## Running the Project

- _Navigate to the project's production directory `HairSalon`. In the command line, run this command to compile and execute the web application. A new browser window should open, allowing you to interact with it._

> ```bash
> $ dotnet watch run
> ```

- _Alternatively, using the command `dotnet run` will execute the application, but you will have to manually open a browser window and navigate to the application url (ex: `https://localhost:5001` or `http://localhost:5000`)_

> ```bash
> $ dotnet run
> ```

- _Optionally, to compile this web app without running it, enter:_

> ```bash
> $ dotnet build
> ```


## Known Bugs

- _Please report any additional bugs you find with a message to joncheng.dev@gmail.com_

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) _2023_ _Jonathan Cheng_