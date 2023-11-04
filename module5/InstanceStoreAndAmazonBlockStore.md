## Instance Store Volumes
- provided wiuth some EC2 instances
- physically attatched to the host of your EC2 instances so the data does not persist if your EC2 is stopped or terminated
- good for temporary and ephemereal data

## Amazon Elastic Book Store
- create virtual hard drives called EBS Volumes
- not tied directly to the host the EC2 is running so data persists between stops and starts of the instance

you define the size, the type and configurations of the volume you need then you configure your application to write to the volume