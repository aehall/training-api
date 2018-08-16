# Infrastructure for API Training
This repo contains PostgresSQL DB code and C# DB access code that can be used as infrastructure for building a RESTful API.

## Setting up your database
1. [Download PostgresSql](https://www.enterprisedb.com/downloads/postgres-postgresql-downloads).
2. Install PostgresSql using the file you just downloaded.
3. When prompted, use "password" as the password for your DB admin user (postgres).
4. Download [PGAdmin](https://www.pgadmin.org/download/pgadmin-4-windows/).
5. Install PGAdmin using the file you just downloaded.
6. Open PGAdmin.
7. On the left pane, in the __Object Browser__, right-click __Databases__, and select __New Database__.
8. On the __New Database__ dialog, on the __Properties__ tab, enter "Employees" in the __Name__ field.
9. Click the __Sql__ tab.
10. Clear the __Read only__ check box.
11. Paste the following statement into the text box:
```
CREATE DATABASE "Employees"
  WITH OWNER = postgres
       ENCODING = 'UTF8'
       TABLESPACE = pg_default
       LC_COLLATE = 'English_United States.1252'
       LC_CTYPE = 'English_United States.1252'
       CONNECTION LIMIT = -1;
```
12. Click __OK__. The dialog closes.
13. In the left pane, in the __Object Browser__, click the new table.
14. Click the __Tool__ menu and select __Query Editor__.
15. In the query editor, run each of the scripts in the database-setup.sql file. You may have to run them one at a time.
