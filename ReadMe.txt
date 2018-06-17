Work Log 5/9/2018

***************************************
Refining data types in a MySql database
***************************************

1) A C# string maps to longtext in the database by default
************************************************

Using decorator:

no decorator => FirstMidName longtext

[Column("first_mid_name", TypeName="varchar(50)")]
 public string FirstMidName { get; set; }

 with decorator => first_mid_name varchar(50)

 2) Timestamp
 ************************************************
Ref: https://stackoverflow.com/questions/21502290/how-to-convert-sql-timestamp-to-a-string-in-entity-framework

MySql TimeStamp
Ref:http://www.mysqltutorial.org/mysql-timestamp.aspx
NOTE: timestamp MsSql is not the same as MySql

3) set default value
https://stackoverflow.com/questions/19554050/entity-framework-6-code-first-default-value

