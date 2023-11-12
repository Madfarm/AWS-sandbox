# User Permissions and Access

Root user is the AWS account owner and they have full permissions over the entire account

IAM - AWS Identity and Access Management

in IAM you can create IAM users
by default, it has no permissions - it can't even login
you must explicitly allow any action for IAM users

IAM Policy - the way you grant or deny permissions to IAM users
- a JSON document that describes what API calls a user can or cannot make


IAM Groups - attach an IAM policy to the group and all users in the group get those permissions


IAM Roles - allows you to grant permissions temporarily
when an identity assumes a role it abandons all previous permissions and assumes the permissions of that role


Best practice:

Do not use the root user for everyday tasks. 

Instead, use the root user to create your first IAM user and assign it permissions to create other users.

Then, continue to create other IAM users, and access those identities for performing regular tasks throughout AWS. Only use the root user when you need to perform a limited number of tasks that are only available to the root user. Examples of these tasks include changing your root user email address and changing your AWS support plan. For more information, see “Tasks that require root user credentials” in the AWS Account Management Reference Guide(opens in a new tab).