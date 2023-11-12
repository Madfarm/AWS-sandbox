# User Permissions and Access

Root user is the AWS account owner and they have full permissions over the entire account

Best practice:

Do not use the root user for everyday tasks. 

Instead, use the root user to create your first IAM user and assign it permissions to create other users.

Then, continue to create other IAM users, and access those identities for performing regular tasks throughout AWS. Only use the root user when you need to perform a limited number of tasks that are only available to the root user. Examples of these tasks include changing your root user email address and changing your AWS support plan. For more information, see “Tasks that require root user credentials” in the AWS Account Management Reference Guide(opens in a new tab).





IAM - AWS Identity and Access Management

in IAM you can create IAM users
by default, it has no permissions - it can't even login
you must explicitly allow any action for IAM users

Best practice:

We recommend that you create individual IAM users for each person who needs to access AWS.  

Even if you have multiple employees who require the same level of access, you should create individual IAM users for each of them. This provides additional security by allowing each IAM user to have a unique set of security credentials.








IAM Policy - the way you grant or deny permissions to IAM users
- a JSON document that describes what API calls a user can or cannot make

Best Practice:
Only grant permissions that are required and no extra




IAM Groups - attach an IAM policy to the group and all users in the group get those permissions


IAM Roles - allows you to grant permissions temporarily
when an identity assumes a role it abandons all previous permissions and assumes the permissions of that role


