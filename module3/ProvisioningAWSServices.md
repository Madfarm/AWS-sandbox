# How to Provision AWS Resources
Create and manage AWS resources by making calls to AWS APIs


## Ways to create requests to send to the AWS APIs
- AWS Management Console
- AWS CLI
- AWS SDKs
- Tools like CloudFormation

AWS Management Console is a browser-based and makes it easy to visually manage your AWS resources
The management console is inefficient at managing AWS resources compared to scripting or programming the API calls

AWS Elastic Beanstalk is a service that helps you provision EC2-based environments. You give it your application code and desired configurations and it builds out the environment for you

AWS CloudFormation is an Infrastructure as Code(IaC) tool that lets you define AWS resources in a declarative way using JSON or YAML text-based documents called CloudFormation templates. CloudFormation is not limited to EC2-based solutions. You can run the same template in various in multiple accounts or multiple regions and it will create identical environments across them. IaC software helps create automated and repeatabled deployments while letting you manage your infrastructure as a full environment.


## AWS Elastic Beanstalk
Provide it the code and configuration settings and it will deploy the resources necessary to:
- Adjust capacity
- Load balancing
- Health monitoring
- Automatic scaling

## AWS CloudFormation
Lets you build a cloud environment by writing lines of code which lets you provision cloud resources in a safe and repeatable manner. Also rolls back changes if it detects errors.