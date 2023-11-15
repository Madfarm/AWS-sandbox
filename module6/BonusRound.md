# Additional Security Services

Encryption - at rest | at transit



# Amazon Inspector
automated security assessments 
helps improve security and compliance of your AWS deployed applications

Specifically, it helps to check on deviations of security best practices, exposure of EC2 instances, vulnerabilities, and so forth.

has three parts
- network reachability piece
- Amazon agent, which can be installed to EC2 instances
- security assessment service

to use => configure Inspector options, run the service and out pops a list of potential security issues displayed in the Amazon Inspector console that details the security iosse and provides a reccomendation on how to fix it

can also be retrieved through an API

# Amazon GuardDuty
threat detection offering
analyzes continuous streams of metadata generated from your account, and network activity from CloudTrail events, VPC Flow logs, and DNS logs

uses known malicious IP addresses, anomaly detection, and ML to identify threats

runs independently from your AWS Services
-> doesn't affect performance or availability on existing infrastructure and workloads


# Key Management Service (AWS KMS)
encryption at rest
create, manage, and use cryptographic keys
specify the access level using IAM users and roles


# WAF
web application firewall -> lets you monitor network requests that comine into your web applications

has their own ACLs, WACLs
same concept