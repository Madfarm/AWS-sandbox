# Amazon Database Migration Service (DMS)
Lets you migrate between a source and a target database. The source database remains fully funtional during the migration
Source and target do not have to be the same type

Migrations where both are the same type are called:
> Homogenous
MySQL -> RDS
SQL Server -> RDS
Oracle -> RDS

the source database can be located on-premises, running on Amazon EC2 Instances, or it can be an Amazon RDS database. The target itself can be a database in Amazon EC2 or Amazon RDS. In this case, you create a migration task with connections to the source and target databases. Then start the migration with a click of the button. AWS Database Migration Service takes care of the rest. 

> Heterogenous Migration
2 step process

- use AWS Schema Conversion Tool to convert the source schema and code to match the target database

- use DMS to migrate