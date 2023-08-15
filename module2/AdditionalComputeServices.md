EC2 requires you to patch your instances when new software updates come out.

> Enter Serverless

Serverless means you cannot see or access the underlying infrastructure or instances that are hosting the application

- AWS Lambda
lets you upload your code into what's called a Lambda function and set a trigger for when to run that code

- AWS Container Services
Amazon Elastic Container Service, ECS
Amazon Elastic Kubernetes Services, EKS

container orchestration tools - both run docker containers

serverless container orchestration with Fargate

need access to the OS? Use EC2
event driven, short running functions? Use Lambda
and use EKS or ECS to use container based workloads