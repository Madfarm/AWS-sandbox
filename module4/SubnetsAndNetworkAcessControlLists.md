## Network Access Control List
Every packet that crosses the subnets boundaries gets check by the NACL to see if the packet has the permissions to enter or leave the subnet based on who it was sent from and how it's trying to communicate

NACL only checks packets as they cross the subnet boundary

Instance level access is determined by security groups

All EC2 instances automatically come with a security group. By default, this security group does not allow any traffic into the instance at all.

By default, security groups allow all traffic to leave and allow all return traffic

ACL is stateless, Security Groups are stateful -  they remember who to let in and out


Each AWS account comes includes a default network ACL. By default it allows all inbound and outbound traffic. 
Custom network ACLs deny all inbound and outbound traffic by default.