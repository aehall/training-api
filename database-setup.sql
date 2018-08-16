----Create Employees Database----

DROP DATABASE IF EXISTS "Employees";

CREATE DATABASE "Employees"
  WITH OWNER = postgres
       ENCODING = 'UTF8'
       TABLESPACE = pg_default
       LC_COLLATE = 'English_United States.1252'
       LC_CTYPE = 'English_United States.1252'
       CONNECTION LIMIT = -1;

COMMENT ON DATABASE "Employees"
  IS 'This is a simple database for REST API training.';

USE Employees;

----Create Individuals Table----
CREATE TABLE individuals (
	id SERIAL PRIMARY KEY,
	teamId integer NOT NULL,
	firstName varchar(40),
	lastName varchar(40),
	title varchar(40),
	emailAddress varchar(40)
);

----Create Teams Table----
CREATE TABLE teams (
	id SERIAL PRIMARY KEY,
	name varchar(40)
);

----Populate Teams Table----
INSERT INTO teams
    (id, name)
VALUES
    (1, 'The Spartans'),
    (2, 'Vulcan'),
    (3, 'Cheaha')

----Populate Individuals
INSERT INTO individuals
    (teamId, firstName, lastName, title, emailAddress)
VALUES
    (1, 'Aaron', 'Hall', 'Developer', 'aehall@ebsco.com'),
    (1, 'Tim', 'Hays', 'Developer', 'thays@ebsco.com'),
    (2, 'Joanne', 'Adams', 'Developer', 'jadams@ebsco.com'),
    (3, 'Patty', 'Campbell', 'Developer', 'pcampbell@ebsco.com')