## S3 Babyyyyyy
- file storage
- data is stored as objects
- max size: 5 TBs

Each object consists of data, metadata, and a key

The data might be an image, video, text document, or any other type of file. Metadata contains information about what the data is, how it is used, the object size, and so on. An object’s key is its unique identifier.


## S3 Storage Classes
> S3 Standard
- High availability 
- Stored in a minimum of three Availability Zones with 11 9s of durability which means there is a 99.999999999 percent probability that it will remain intact after 1 year
- Designed for frequently accessed data

> S3 Standard-Infrequent Access (S3 Standard-IA)
> S3 One Zone-Infrequent Access (S3 One Zone-IA)
> S3 Intelligent-Tiering
> S3 Glacier Instant Retrieval
> S3 Glacier Flexible Retrieval
> S3 Glacier Deep Archive
> S3 Outposts