## C# CRUD

A C# crud application written using .NET 8.0

- Connects to MariaDB or MySQL server to provide a command line user interface.
- A Relational Schema generator script is provided in the repository. 

---

## To Build:

1. Clone the repository.
2. Run the `Dbscript.sql` file on your database system
3. Open the `.env` file to add your database login information:
    - `SERVER_NAME` : 127.0.0.1 By Default
    - `SERVER_PORT` : 3306 By Default
    - `DB_NAME` : Name of your database (eg: LmsCrud)
    - `DB_USER` : Name of your database user account
    - `DB_PASS` : Your database user account password
4. Run `dotnet run` to launch the application.
