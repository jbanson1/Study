# ARCHITECTING FOR RELIABILITY  

## Defining Reliability and Resiliency
---------------------
This refers to the ability to avoid and recover from failure. 
An application is measured based upon how long it runs as expected for a percentage.

Deciding on how much availability your application requires depends mostly on the application.

|Application Availability|99.0|99.9|99.99|99.999|
|--|--|--|--|--|
|Downtime Expected |3 days 15 hours|5 hours 45 mins|1 hour|5 mins|

## Traditional Applications
---------------------------
Traditional applications that run on Windows or Linux would require to be run on an EC2 windows or Linux instance. To enable the application to be lifted and shifted without the need to alter the application code.

A method adopted to help implement tradition applications on AWS is Loose Coupling. Just like when designing software loose coupling is used to embody each micro service.
As such one service does not depend on another

Some of the benefits here are:
- Each service can be operated on individually making it easier for updating.
-It is scalable the services that require more Resources can be altered individually. For instance a microservice could be given more processing power or more memory to help other instances perform better.
- The elastic Load balancer can proxy a user to another instance in the case where a EC2 instance goes down.


## Cloud Native Applications
----------------------------
This is refers to an application which is only available or depends on a resource in the cloud.
Using this approach the architecture could be manipulated to get better performance but this would not improve the applications availability.

### Demo Example to find out the overall application Availability on a cloud service
-----
|Resource=|Lamda(Video processing)|S3(Web asset video storage)|DynamoDb(Database)|
|--|--|--|--|
|Availability|99.95|99.9|99.999|

### The Availability 
99.95 x 99.9 x 99.999 = 99.85 

Advantages Of Cloud Native Applications:
- Scalability
- Performance
- Convenience

Disadvantages:
- Your locked into the cloud 
- Availability is slightly lower than what you could achieve on a traditional architecture.

Higher availability can be achieved by making the application in more regions.

Calculated by finding the failure rate of each region

100% - 99.85% (region availability) = 0.15%  

multiply the failure rate from both regions

0.15 x 0.15 = 0.00225

subtract result from 100 = 99.999%

# Service Limits
These are seet to prevent a user from over indulging in too many EC2 instances in an attempt to get 100% availability.
Best way to check the number for each user is to check the Trusted Advisor in order to find service limits.

