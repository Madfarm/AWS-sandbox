## Messaging and Queueing

Having a buffer between the EC2 instances is messaging and queueing


A buffer between the applications decouples the architecture, making it some when one application fails the other applications don't

2 AWS services that act as buffers
- SQS | Amazon Simple Queue Service
- SNS | Amazon Simple Notification Service

SQS allows you to send, store, and receive messages between software entities with no limit on volume. The data stored in an SQS message is referred to as a Payload. Messages are placed in the SQS queue until they are processed
like all of AWS; scales automatically



