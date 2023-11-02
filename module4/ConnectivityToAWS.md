# Virutal Private Cloud(VPC)
Basically your own network in AWS. Lets you define your IP range for your AWS resources. Place EC2 instances and load balancers inside it.

Your own isolated section of the AWS cloud with a network you define that you can launch resources in.

> Subnets
- Chunks of IP address within your VPC that let you group together your AWS resources. Can be private or public.

to allow traffic from the public internet to flow into your VPC you must attatch an Internet Gateway (IGW) to it

A Virutal Private Gateway only allows people to access the VPC from an approved network

## AWS Direct Connect
Dedicated private fiber connection from your data center to AWS