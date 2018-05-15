Work Log 5/9/2018

***************************************
Refining data types in a MySql database
***************************************

1) A C# string maps to longtext in the database
************************************************

Using decorator:

no decorator => FirstMidName longtext

[Column("first_mid_name", TypeName="varchar(50)")]
 public string FirstMidName { get; set; }

 with decorator => first_mid_name varchar(50)