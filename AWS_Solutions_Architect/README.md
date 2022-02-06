# AWS Certified Solutions Architect - Associate (SAA-C02)

## ARCHITECTING FOR RELIABILITY  


## Defining Reliability and Resiliency
This refers to the ability to avoid and recover from failure. 
An application is measured based upon how long it runs as expected for a percentage.

Deciding on how much availability your application requires depends mostly on the application.

|Application Availability|99.0|99.9|99.99|99.999|
|--|--|--|--|--|
|Downtime Expected |3 days 15 hours|5 hours 45 mins|1 hour|5 mins|

## Traditional Applications
Traditional applications that run on Windows or Linux would require to be run on an EC2 windows or Linux instance. To enable the application to be lifted and shifted without the need to alter the application code.

A method adopted to help implement tradition applications on AWS is Loose Coupling. Just like when designing software loose coupling is used to embody each micro service.
As such one service does not depend on another

Some of the benefits here are:
- Each service can be operated on individually making it easier for updating.
-It is scalable the services that require more Resources can be altered individually. For instance a microservice could be given more processing power or more memory to help other instances perform better.
- The elastic Load balancer can proxy a user to another instance in the case where a EC2 instance goes down.

## The Cloud
The cloud refers to software and systems provided over the internet instead of locally on a computer.
AWS services are made available to users by identifying Regions => Availablity Zones(2+) => Data Centers(2+) OR Edge Groups (AWS CloudFront a little like an API)

## Cloud Native Applications
This is refers to an application which is only available or depends on a resource in the cloud.
Using this approach the architecture could be manipulated to get better performance but this would not improve the applications availability.

### Demo Example to find out the overall application Availability on a cloud service
|Resource=|Lamda(Video processing)|S3(Web asset video storage)|DynamoDb(Database)|
|--|--|--|--|
|Availability|99.95|99.9|99.999|

### The Availability 
99.95 x 99.9 x 99.999 = 99.85 

Advantages Of Cloud Native Applications:
- Scalability
 The infrastructure can easily be increased to meet larger demands.

- Performance
 The reliability and performance of the services are assured based upon the architecture used. 

- Convenience
 Services can easily be reached.

- Cost
 The cost for services used can easily be managed.

- Elasticity
 Using Cloudfront instances can be created automatically and removed when not in use.

Disadvantages:
- Your locked into the cloud 
- Availability is slightly lower than what you could achieve on a traditional architecture.

Higher availability can be achieved by making the application in more regions.

Calculated by finding the failure rate of each region

100% - 99.85% (region availability) = 0.15%  

multiply the failure rate from both regions

0.15 x 0.15 = 0.00225

subtract result from 100 = 99.999%

## Service Limits
These are set to prevent a user from over indulging in too many EC2 instances in an attempt to get 100% availability.
Best way to check the number for each user is to check the Trusted Advisor in order to find service limits.

## Setting up AWS Environment 

## Avoiding big bills 
this can be done by using AWS Budgets there are 4 focuses:
- Cost Budget 

- Usage Budget
- Reservation Budget
- Savings Plans Budget

AWS wil not stop the service when you dont turn it off!!!!!!

## AWS Identity Types
- Root User Principal:
This is created when an aws account is created. From this account IAM accounts can be created. Policies and privilidges are created,granted or taken away from this account. Once created enable MFA(Multi Factor Identifications). Create admin groups and assign appropriate permissions(i.e Developers require different permissions to Accountants). 

Policiy Documents:
Written using JSON(Java Script Object Notation) the document is made up of 
3 main parts EAR(Effcts.Action.Resources).

/-Take a look at a few policy docs before test-/

- IAM (Identity Access Management) Principal:
An account with specific access to resources and services allowed by the root account. With IAM policies the root account can manage permissions this is done to ensure least-privilidge permissions. IAM is universal.
You can use IAM Federation to allow a user to connect to directory services using their Bussiness/Office acount it uses SAML.

# S3( Simple Storage Service )
A generic storage service used to stored objects (anything static i.e files that dont change) objects can be upto 5 Terabytes but there is unlimited storage. Objects are stored in buckets(folders). Buckets are universal as such names must be globally unique, buckets however are stored regionally. The S3 With 11 9s ( 99.999999999 ) durability and 99.95-99.99 availability. 

Example S3 URL :
- https://bucket-name.S3.Region.amazonaws.com/KeyName
- https://JoesRustyBucket.S3.us-east-1.amazonaws.com/Selfie

It works off of a key value stpred which is the name of the object.
An object could also have metadata and version ID. The value of an object is the data itself which is a sequence of bytes.
S3 is designed for frequent access and is suitable for most workloads.
There is tiered storage for different use cases. There is also lifeCycle management to move items to a different tier to make management more cost effective or delete obsolete objects.
There is versioning where all instances of the object are stored and cant be deleted. Once versioning is turned on it can not be stopped just suspended.

Cannot be used to run Operating systems

## Security
- Server Side Encryption
Data once stored within a bucket can be encrypted. Or
can be encrypted on the client side using AWS KMS(Key Management Service)

- Access Control List (ACLs)
Access can be grant to specific groups or individuals.

- S3 Bucket Policies
With S3 Policies you can specify what actions are allowed or denied.

## S3 Tiers
- S3 Standard IA (Infrequently Accessed)  
Rapid Access,Pay to access data and good for long term storage or backup.

- S3 one Zone-IA
Objects or buckets only available in one Availability Zone.

## S3 Intelligent Tiering 
Moves data to the most cost effective tier based on how frequent each object is accessed

## Glacier
Used for long term archiving and users pay each time they access data.

### Types or Options
- Glacier
Provides long term data archiving with retrieval times ranging from 1-12 hours.

- Glacier Deep Archive
Provides long term data archiving with retrieval times default to 12 hours.

## Lifecycle Management
Moving objects from one tier to another to minimize storage cost you can use versioning and create rules for one object or all objects within a bucket. Lifecycle management automates moving objects between different storage tiers. Can be applied to current or 
older versions.

## S3 Object Lock
It is used to store objects using the WORM (Write Once Read Many) Model.

MODES:
- Governence Mode
Users can not overwrite or delete a version or alter its lock settings unless they have special permissions.

- Compliance Mode
Nobody can overwrite or delete the object. Unless till the retention period is complete. Retention period is a period 
set to protect an object version. Legal holds however prevent an object version from being overwritten or deleted.
Legal holds can be placed and removed only by users with S3:PutObjectLegalHold permission. 

## S3 Encryption

1. Encryption in transit
     - SSL/TLS
     - HTTPS

2. Encryption at Rest: Server-Side Encryption
Can be done using the console or through bucket policy.
    - SSE-S3: S3 Manage Keys using 256 bit encryption

    - SSE-KMS: AWS Key Management Service- managed keys


    - SSE-C: Customer provided keys

3. Encryption at Rest: Client-Side Encryption
Client encrypts object before uploading to S3.

4. You can also implement encryption using bit bucket policy. Where the put request header contains the type of encryption
acceptable.

## Optomizing S3 Performance

1. Prefix
Using prefixes oor creating subdirectories can increase requests per seconds.

2. 

# Building Virtual Private Cloud
Virtual Private Cloud is a service that islotaed from other virtual networks. 

## How to create the VPC
Using the VPC wizard on the AWS Console it can be used to create a VPC, Nat Gateway,  An internet Gateway and public subnet or private subnets. 

### Steps:
1. Go to VPC Wizard
2. Select Launch VPC
3. Select the particular configuration you wish to use.
4. In this scenario VPC with public and private subnets is selected.
5. Fill out the required details ensuring that both the private and public subnets have the same IPv4 address & allocation zone. The allocation ID should be available when selected.
6. Create VPC

## How to Connect to a VPC
There are 3 main methods to connect to a vpc:
- NAT Gateway (Network Address Translation)
In common man terms an additional layer preventing instances within the vpc from communicating with anything outside the VPC
- Direct Connect/Direct Link
Low-latency connection to AWS Region
- Internet Gateway with VPN

OR
- Transic Gateway 
This is more used to connect several VPC and can support Direct link.

## Cloud Platform Models
- IAAS (Infastructer as a service)
    A system of cloud computing that delivers computerized resources over the internet. The customer is incharge of keeping software and hardware upto date.

- PAAS (Platform as a service)
    A computing model where both hardware and software tools are provided over the internet. The user is not incharge of managing the software.

- SAAS (Software as a service)
    A computing model where all resources are provided over the internet.

## Elastic IPs
It is an IP address which can be given to any EC2 in a particullar region.
using the command:
"aws ec2 allocate address"
You can allocate a public IP address to release it use the command. $0.12/per day
"aws ec2 release-address"

## Global Accelerator
It is used to improve a users traffic re routing the user to the nearest healthiest endpoint. 

## Subnet
A subnet is a partition within a network(vpc) containing resources of a network

### Public Subnet
It has a route with and internet gateway as its target.

### Private Subnet
The Private Subnet mostly differs from the public subnet as it is only accessible to a those in a particular security group. The NAT Gateway sends traffic through the internet gateway 
It can serve as a back up. By mirroring main services or by handling a percentage of the overall load/traffic.

## Creating a Subnet
1. Select on the sidebar subnet then on the page select create subnet.
2. Fill in the required details (Pay attention to the availablility Zone ID) & specify the CIDR Block used for the particular VPC.
3. The subnet created is going to be targetting the NAT Gateway. Which Public Subnets shouldnt be to change it select the subnet(& edit route table association).
4. Change the route tableID  to the same as the public subnet created when using the VPC before. 
5. Take note of all subnetID so as to help you launch ec2 instances or resources into your subnet.  

# Launching Instances into a subnet
using the CLI
1. You can use the command
"aws ec2 describe-subnets" or "aws ec2 describe-subnets --filters Name=cidr-block,Values="10.0.11.0/24"

2. Next run the instance within the subnet using the command (The ami(amazon image ID) will need to change from reigon to reigon)
"- aws ec2 run-instances --image-id ami-01d025118d8e760db --subnet-id subnet-0286d0d7f679ac737 --instance-type t3.micro --key-name ccnetkeypair"

3. Copy the instance IP from the returned value and allocate the instance to an Elastic IP Address using the command shown below AWS-CLI.
- Firstly allocate a an Elastic IP.
- Associate the IP address using the command:
"aws ec2 associate-address --instance-id i-036a00e797649cba5 --allocation-id eipalloc-0016c8c2129a23448"

4. You can use the command below to view the address:
- "aws ec2 describe-addresses"

or 
- "aws ec2 describe-addresses --allocation-ids {The allocation ID}"

NB:AWS Shield prootect is used to prevent DDoS attacks

# Transic Gateway

Steps to connect a VPC to a Transit Gateway

# Security Groups 


## AWS Core Services
|Category | Service| Function|
|--|--|--|
|Compute|Elastic Compute Cloud| EC2 server instances run virtual versions of servers. They are reasource efficient and run almost instantly.|
||Lambda|It is a serverless platform that runs code in response to events.|
||Auto Scaling|Copies of running Ec2 instances can be defined as image templates and automatically launched when client demand is met.|
||Elastic Load Balancer|Incoming traffic can be directedd to multiple servers to prevent a server from being overwhelmed.| 

|Networking|||
|--|--|--|
||Virtual Private Cloud|Confirgurable network enviroments used to manage ec2 instances.|
||Direct Connect|Can purchase fast and secure connection to AWS through a third party vendor.|
||Route 53| It is an AWS DNS(Domain name System) that lets a user to manage domain registration, record admin, routing protocols and health checks|
||Cloud Front|Is amazons (CDN) distributed |

|Storage|||
|--|--|--|
||Simple Storage Service (S3)|
||S3 Glacier|
||Elastic Block Store (EBS)|
||Storage Gateway|

||Database||
|--|--|--|
||Relational Database Service (RDS)|
||Dynamo DB|

||Application Management||
|--|--|--|
||CloudWatch|
||CloudFormation|
||CloudTrail|
||Config|

||Security & Identity||
|--|--|--|
||Identity Access Management(IAM)|
||Key Management Service (KMS)|
||Directory Service|

||Application Integration||
|--|--|--|
||Simple Notification Service (SNS)|
||Simple WorkFlow (SWF)|
||Simple Queue Service (SQS)|
||API Gateway|


# CLI Commands (AWS-CLI)
- aws ec2 allocate-address
- aws ec2 release-address --allocation-id  eipalloc-0d47bf1294c84eaf4
- aws ec2 describe-addresses

- aws ec2 describe-subnets --filters Name=cidr-block,Values="10.0.11.0/24"
- aws ec2 run-instances --image-id ami-01d025118d8e760db --subnet-id subnet-0286d0d7f679ac737 --instance-type t3.micro --key-name ccnetkeypair
- aws ec2 allocate-address
- aws ec2 associate-address --instance-id i-036a00e797649cba5 --allocation-id eipalloc-0016c8c2129a23448
- aws ec2 terminate-instances --instance-ids i-2036a00e797649cba5
- aws ec2 release-address --allocation-id eipalloc-0016c8c2129a23448

- aws ec2 describe-nat-gateways
- aws ec2 delete-nat-gateway --nat-gateway-id nat-0827194f97b639e0d
- aws ec2 release-address --allocation-id eipalloc-0e196ad93b197e07f

- aws ec2 create-transit-gateway
- aws ec2 create-vpc --cidr-block 172.27.0.0/16
- aws ec2 create-subnet --vpc-id vpc-06b95746480684294 --cidr-block 172.27.1.0/24 --availability-zone us-east-1a
- aws ec2 create-transit-gateway-vpc-attachment --transit-gateway-id tgw-06966d6bb0e0487ed --vpc-id vpc-06b95746480684294 --subnet-ids subnet-001dd838706816ebb
- aws ec2 create-vpc --cidr-block 172.28.0.0/16
- aws ec2 create-subnet --vpc-id vpc-04d353c2a1c363eee --cidr-block 172.28.1.0/24 --availability-zone us-east-1a
- aws ec2 create-transit-gateway-vpc-attachment --transit-gateway-id tgw-06966d6bb0e0487ed --vpc-id vpc-04d353c2a1c363eee --subnet-ids subnet-09aa923619d3a352b
- aws ec2 search-transit-gateway-routes --transit-gateway-route-table-id tgw-rtb-01e158d45848e8522 --filters "Name=type,Values=static,propagated"
- aws ec2 describe-transit-gateways
- aws ec2 search-transit-gateway-routes --transit-gateway-route-table-id tgw-rtb-0ef0345df00016c92 --filters "Name=type,Values=static,propagated"