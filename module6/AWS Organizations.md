# AWS Organizations
a central location to manage multiple AWS accounts

features
- centralized management
- consolidated billing
- hierarchical grouping of accounts
- centrally control permissions for the accounts in the org

when you create an organization, AWS Organizations creates a root, which is the parent container for all acounts in your organization

Service Control Policies (SCPs) allow you to place restrictions on AWS Servcices, resources, and individual API actions that users and roles in each account can access thus allowing you to centrally control permissions for the accounts in organization

group accounts into Organization Units (OUs)
when you apply a policy to an OU all the accounts in the OU automaticall inherit the permissions of that policy