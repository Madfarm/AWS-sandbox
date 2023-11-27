# Migration Strategies
if tightly coupled, 6 possible options for enterprise migrations

6 R's:
## Rehosting - lift and shift
self-explanatory

## Replatforming - lift tinker and shift
rehosting still -  no changing core code 
but you might make some optimizations like MySQl -> RDS or upgrade to Aurora

## Retiring
ending some applications that you are no longer using

## Retain
some applications may need to retire soon but not yet, in which case, there isn't much benefit to migrating them to AWS so you just leave them as is

## Repurchase
switch software providers like ending a contract with an old CRM or switching db to cloud native db

moving to a different product

## Refactoring
Writing new code with cloud-native features in mind
new features or better performance etc.
