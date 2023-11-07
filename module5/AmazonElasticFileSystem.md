# Amazon Elastic File System
file storage that automatically scales up and down without disrupting applications

In this approach, a storage server uses block storage with a local file system to organize files. Clients access data through file paths.

- ideal for use cases in which a large number of resources or services need ot access the same data at the same time

on-premises servers can access Amazon EFS via AWS Direct

Unlike EBS, data stored in an EFS enables you to access data concurrently from any availability zone in a region