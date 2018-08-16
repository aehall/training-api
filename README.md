# Infrastructure for API Training
This repo contains PostgresSQL DB code and C# DB access code that can be used as infrastructure for building a RESTful API. 

Use the following instructions to set up your database.

The C# solution already has a WebAPI project with a repository class that communicates with the database. Your API controller can use the repository to send and receive data.

You'll need to create a test project to practice test-driven development as you fill out the API.

## Setting up your database
1. [Download PostgresSql](https://www.enterprisedb.com/downloads/postgres-postgresql-downloads).
2. Install PostgresSql using the file you just downloaded.
3. When prompted, use "password" as the password for your DB admin user (postgres).
`NOTE: When prompted, you don't need to install any of the StackBuilder applications. Just click Cancel.`
4. Download [PGAdmin](https://www.pgadmin.org/download/pgadmin-4-windows/).
5. Install PGAdmin using the file you just downloaded.
6. Open PGAdmin.
7. On the left pane, in the __Object Browser__, right-click __Databases__, and select __New Database__.
8. On the __New Database__ dialog, enter "Employees" in the __Database__ field.
9. Click __Save__. The dialog closes.
10. In the left pane, in the __Object Browser__, click the new table.
11. Click the __Tool__ menu and select __Query Tool__.
12. In the query editor, run scripts in the database-setup.sql file. You can run them all at the same time.
