## S3 Babyyyyyy
- file storage
- data is stored as objects
- max size: 5 TBs

Each object consists of data, metadata, and a key

The data might be an image, video, text document, or any other type of file. Metadata contains information about what the data is, how it is used, the object size, and so on. An object’s key is its unique identifier.


########################## S3 Storage Classes ###################################

## S3 Standard
- High availability 
- Stored in a minimum of three Availability Zones with 11 9s of durability which means there is a 99.999999999 percent probability that it will remain intact after 1 year
- Designed for frequently accessed data

## S3 Standard-Infrequent Access (S3 Standard-IA)
- ideal for infrequently accessed data
- cheaper than standard, but same availability


## S3 One Zone-Infrequent Access (S3 One Zone-IA)
- Only stored in one availability zone
- cheaper than Standard-IA


## S3 Intelligent-Tiering
- S3 monitors how you access specific objects and moves them in the appropriate access tiers ex: standard, infrequent-access

- ideal for data with unknown or changing access patterns
- requires a small monthly autotmation and monitoring fee per object


## S3 Glacier Instant Retrieval
- Archival storage that can retrieve objects within a few miliseconds


## S3 Glacier Flexible Retrieval
- Archival storage that can retrieve objects within a few minutes to hours
- low cost for data archiving


## S3 Glacier Deep Archive
- Archival storage that can retrieve objects within 12 - 48 hours
- cheapest object storage

## S3 Outposts
- buckets in AWS Outposts