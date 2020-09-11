# WebAPIwithOracleDapper

http://www.mukeshkumar.net/articles/aspnetcore/asp-net-core-web-api-with-oracle-database-and-dapper


Create a table name as "EMPLOYEE". 
You can use the following syntax to create the table inside oracle database.

```
CREATE TABLE "TEST_DB"."EMPLOYEE" 
(	
    "ID" NUMBER(10), 
	"NAME" VARCHAR2(255), 
	"SALARY" NUMBER(10), 
	"ADDRESS" VARCHAR2(500)
)
```

Need to add some dummy records inside the tables, so that we can directly get the data from PostMan. 
So, we are adding four records here as follows.

```
Insert into TEST_DB.EMPLOYEE (ID,NAME,SALARY,ADDRESS) values (100,'Mukesh',20000,'India');
Insert into TEST_DB.EMPLOYEE (ID,NAME,SALARY,ADDRESS) values (101,'Rion',28000,'US');
Insert into TEST_DB.EMPLOYEE (ID,NAME,SALARY,ADDRESS) values (102,'Mahesh',10000,'India');
Insert into TEST_DB.EMPLOYEE (ID,NAME,SALARY,ADDRESS) values (103,'Banky',20000,'India');
```