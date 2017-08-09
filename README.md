# .NET MVC
A simple CRUD application that runs on the .Net Framework.

## Restoring the database

This can be done in a few ways, but first clone the project and build the application.
Compile/build the application. The command for this is:
Ctrl + Shift + B.

Next, access the package manager console in VS2015 by navigating to View > Other Windows > Package Manager Console
Type the command:
Update-Database -Context GummyBearKingdomTokyoContext
This should generate the database from the models.  This commmand can also be run from the project directory in powershell.


## Navigating
Upon a successfully cloning and recreating the database, navigate to localhost:xxxxx to go to the website.
the "xxxx"s above are generated by VS2015 automatically.

## Motivation
Website referenced for styling.
https://picroma.com/cubeworld

## Bugs/Notes
There are currently a few errors.  The ApplicationDbContext sql commection has been removed as it was
conflicting with the main connection string.  User authentication/login is currently not working.

Contact info: eluts15dev@gmail.com

## Technologies Used
Asp.Net Mvc, VS2015, Bootstrap CSS

## License
MIT
