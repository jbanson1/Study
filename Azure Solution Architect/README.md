# Azure Notes
# AZ-900 Fundamentals 
# Cloud Concepts

### High availability:
Ensuring that systems are always available
|traditional | Cloud|
|---|---|
|You own the hardware | You don't own the hardware| 
|You have physical access| Add more servers with a click|
|You cant "Just add servers"| If hardware fails easily replaceable|

### Reliability
Explains how Azure can tolerate failures or disasters.
- Resilience:<br>
The ability of a system to recover from failures and continue to function.

Reliability is achieved by either <br>
1) Deploy to Multiple Locations<br>
- Global scale computing<br>
- Which protects against<br>

2) No Single Point of Failure
- Resources in multiple Locations
- If one computer goes down, others pick up the load

### Scalability
Is the process of scaling up out or down to handle the demand of customers. By increasing the amount of VM when demand is high and removing them when demand is low.

- Horizontal Scaling:<br>
The act of creating more Virtual Machines

- Vertical Scaling:<br>
The act of increasing the power of existing Virtual Machines.

### Predictability 
Knowing the application will perform as expected and knowing the cost
- Performance:<br>
The experience remains consistent for customers regardless of the traffic.<br>
Autoscaling, load balancing and high availability provide a constant experience.

- Costs:<br>
No unexpected costs<br>
Track and forecast usage of resources in real time<br>
Analytics provide trends to enable forecasting

### Security
Having full control of the cloud security posture
- Full control of the security of cloud environment. Patches, Maintenance, network control and more!

### Governance
Governance how you meet requirements/Company standards
- Creating standardized environments
- Regulatory requirements (e.i password reset) 
- Audit for compliance

### Manageability
1)Management of The Cloud:<br>
Refers to how you manage different cloud resources
- Autoscaling
- Monitoring
- Template based deployments

2)Management within the cloud<br>
How you interact with the resources
- Portal
- CLI
- APIs

### Cloud Service Models
---
#### Infrastructure As A Service
Provides virtual computing resources such as servers, Storage and VM.

#### Platform As A Service
Provides a platform such as windows enabling users to run software on in an
integrated manner.(i.e.Windows 10)

#### Software As A Service
Users are not responsible for the hardware or software as licenses and services 
are maintained by Azure.
Can only be accessed over the internet.(i.e. Email)

### Cloud Architect Models
---

#### Private:
Is azure on a hardware of users choosing in a location of choice with all the benefits of public cloud but requires a lot of staff to manage.
|Pros|Cons|
|---|---|
|Complete control of infrastructure |Organizations IT department is responsible for Maintenance Microsoft will not step in|
|Benefits of public cloud| Requires the same staffing as traditional data centers |
|Better security and better privacy| |

#### Public:
Azure, Aws , GCP. NO upfront cost but charged for monthly usage.
Little control over services and infrastructure.
|Pros|Cons|
|---|---|
|No purchase of hardware|No controls as to updates on features|
|Low monthly Fee| No control on where the data is stored|

#### Hybrid:
Is a combination of both private and public cloud but can be very complicated.
|Pros|Cons|
|---|---|
|Gradual integration to avoid disruptions and outages|Complexity to create|
|Some applications don't live in teh public cloud for regulatory purposes,governance||
|Allows applications and data to span between both public and private cloud||
|Alleviate CapEx investments||

# Azure Architecture
## Regions<br>
A set of data centers deployed within a latency-defines
perimeter and connected through a dedicated regional 
low latency network.<br>
Each region has more than 1 data center.

### How to decide what region to use
- Location:<br>
Choosing a region close to users to reduce latency.

- Features:<br>
Not all features are available in all regions. New regions 
would have more features.

- Pricing:<br>
May vary depending on the region. <br>

Each region is paired so if one region fails another region would take over.

### Availability Zones
- Each availability zone is a physical location within a region.
- Each zone is independent having it's own power, cooling and network.
- Zones Each region has a minimum of 3 zones.

## Resource Groups 
All resources on Azure belong to a resource group,
it is not a resource but helps structure the Azure Architecture.

### Resource Group Facts
- One Resource
A resource can exist in only one resource group at a time.

- Add/Remove
You can add or remove resources to any resource group at any time.

- Move Resource
You can move resource from one resource group to another.

- Multiple Regions
resources from multiple regions can be in one resource group.

- Access Control
You can give users access to a resource group and everything in it.

- Interact 
Resources can interact with other resources in different resource groups.

- Location
A resource group has a location,Or region, as it stores meta data about the resources in it.

## Azure resource manager (ARM)
It is a layer of the Azure Architecture that all azure resources go through
in order to be added to a resource group.
It manages all resources on Azure.

It enables:
- Group resource handling:<br>
You can deploy, manage and monitor resources as a group.

- Consistency:<br>
Deploying resources from various tools will always result in the same consistent state.

- Dependencies:<br>
You can define dependencies between resources to prevent
clashing.

- Access control:<br>
It makes it easy to assign rights too users

- Tagging:<br>
Tag resource to easily identify them for futures purposes.
It is a way of relabelling.

- Billing:<br>
Can use tagging to identify groups for billing purposes.

# Compute 
## Virtual Machines (IAAS)
- A computer or server accessed to exclusively 
- You don't buy, own, or control any hardware.
- Virtual Machines are an Iaas Offering, Where you are responsible for the entire machine.
- Azure Virtual machines take advantage of Azure tools.
- Pricing goes up as resources go up. Pay by the hour.

## Scale sets
It refers to set identical VM. That can be activated or deactivated as needed.
Lets you create and manage a group of load balanced vm. Provides high availability
against server failures.

- A baseline VM to set the scale ensures the application stability. A baseline VM is what you copy to make up the scale set VMs.
- As resource usage increases, more VMs are activated to take the load.
- You only pay for the VM, Storage and networking resources you use. Nothing additional for Scale sets.

## App Services (PAAS)
A managed platform to host and manage your web application.
Supports several programming languages and Operating SYstems.
Categories:
- Web apps: Host websites and web applications.
- API Apps: Host backend data services.
- Containers: Host existing container images.

## Azure Container Instances
Primary Azure Service for running container workloads.
Hosts and runs containers on azure. They have less overhead than
Virtual machines and can be deployed consistently.

## Azure Kubernetes Services
Open source container orchestration system for 
automating application deployment, scaling and management.
Uses clusters and pods to scale and deploy applications.
- Enable you to replicate container architectures
- Standard azure services are included 
- Global reach 

### Azure Container Registry (ACR)
- Keeps track of current valid images.
- Manage files and artifacts for containers.
- Feeds container images to ACI and AKS
- Use Azure Identity and security features

## Functions
- Smallest Compute on Azure
- Called or invoked via standard web address 
- Runs once and stops

### Functions benefits:
- Only runs when needed
- Saves money 
- Resilience 

# Networking 
## Virtual Network (Vnet)
Enables Azure resources to communicate to the internet and other resources.
Every Vnet belongs to single region and single subscription. 
A subscription can have multiple VNets.
It is a fundamental part of Azure Infrastructure.

### Address Space 
Range of IP Addresses you cana use for your resources.

### Subnet
A smaller network, which is apart of your Vnet. Use these 
for security and logical division of resources. 
- Enables Resource Grouping
- Enables Address allocation
- Enables Subnet Security

### Benefits of Cloud VN
- Scaling:<br>
Adding more VNets or more addressed is simple.

- High Availability:<br>
Peering VNets, using a load balancer or using VPN gateway.

- Isolation:<br>
You can manage and organize resources with subnets and network security groups.

### VNet Peering 
Allows you to connect 2 or more VN to share resources.
Traffic between VN are private enabling:
- Low Latency, High bandwidth
- Link separate Networks 
- Data Transfer

## Load Balancer
Distributes new inbound flows that arrive on the Load Balancers frontend to backend pool
instances, according to the rules and health probes.

- Inbound Flows: <br> 
Traffic from the internet or Local network.

- Frontend: <br> 
The access point for the load balancer. All traffic goes here.

- Backend pool: <br>
The VM instances receiving traffic.

- Rules and Health Probes: <br>
Checks to ensure backend instance can receive the data.

### Scenarios
- Internet Traffic: <br>
Balance the load of incoming internet traffic into
a system or application.

- Internal Networks: <br>
Works well with internal applications.

- Port forwarding: <br>
Forwarding traffic to a specific machine on the backend pool.

- Outbound Traffic: <br>
Allow backend connectivity for the Backend VMs

## VPN Gateway
Specific type of VN gateway that is used to send encrypted traffic 
between an Azure Virtual Network and an on premises Location over the 
public internet.

### Components
- Azure Vnet (with a vpn gateway with its own public IP address)
- Tunnel (encryption mechanisms)
- On premises network (with a gateway)

## Application Gateway
Is a high level load balancer which works on the http request of the traffic, instead of the IP address and port.

### Benefits:
- Scaling: <br>
  Enables you to scale up or down based on the amount of traffic received.

- Encryption: <br>
  Comply with any security policies.

- Zone redundancy: <br>
  Span multiple availability zones and improve fault resiliency.

- Multi-Site Hosting: <br>
  Use the same application Gateway for up to 100 websites.

## Content Delivery Network (CDN)
It is a distributed network of servers that can deliver web content close to users.
To minimize latency.

- Cache:<br>
  Temporary copies of original files. to optimize speed for an application
  till the copy expires.

- Origin Server: <br>
  The original location of the files such as a web application.

### Benefits:
- Better Performance: <br>
  Improved user experience and performance of the application

- Scaling: <br>
  Suits spikes in traffic and also protects your main backend server instance
  from high loads

- Distribution: <br>
  Edge servers will serve requests closest to the user. Meaning less traffic is then sent to the server hosting your application.

## Express Route
They don't go over the internet. Are very reliable and low latency.
It is private straight to Azure.

# Storage
## BLOB
Storage for anything and are usually inside a container, which is inside a storage account.

### BLOB types
- Block: <br>
  Store text and binary data up to 4.7tb. Made up of individually managed blocks of data.

- Append: <br>
  Block BLOBS that are optimized for append operations.Works well for logging where data is constantly appended.

- Page: <br>
  Store files up to 8TB. Any part of the file could be accessed at any time, for example a virtual hard drive.

  ### Pricing Tiers
  - Hot: Frequently accessed files. Lower access times and higher access costs.
  - Cool: Lower storage costs and higher access times. Data remains here for at least 30 days.
  - Archive: Lowest Cost and highest access times.

## Disk 
It is what you would attach to a virtual machine to imitate whether it has HDD storage, SSD, Premium SSD or Ultra Disk. This enables you to run simulations according to the hardware requirements.

## File 
Mitigating on premises file storage as files are highly available and resilient.
As well as easy to share

## Archive
A cheap way to store Large amounts of data

## Storage Redundancy 
Ensures that data is spread amongst several systems to reduce the amount of failure.
Usually data has 3 copies either in single/multiple regions or single/multiple zones.

## Moving Data
Different solutions based on 
- Transfer Frequency
- Data Size
- Network Bandwidth
  
### AzCopy
It is a command line Utility used to help with the transfer of data.
1) Transfer blobs and Azure files
2) Useful for scripting data transfers 

### Storage Explorer
 It is a GUI
 1) Downloaded application.
 2) User friendly gui. Drag and drop interaction.
 3) Can move all storage account data types.

 ### Azure File Sync
 Synchronize Azure Files with On-Premises File Servers.

## Additional Migration Options
### Azure Data Box
Scenario Lots of data to transfer with limited bandwidth.
A physical box sent to user location to place data on.
It is encrypted. The data is then placed on your storage account.

### Azure Migrate 
Focuses on non azure resources such as servers, databases and applications.
To be places on Azure.
- Example: <br>
  Migrating a data center to Azure or a VM .

## Premium Performance Options
All work with SSD 

| **Type Of Storage Account** | **Supported Storage Services** | **Redundancy Options** |
|-------|-------|-------|
| **Premium block   blobs** |   Blobs Storage    |   LRS/ZRS    |
| **Premium page blobs** |   Page blobs only (IAAS disks)    |    LRS   |
| **Premium File shares** |   Azure Files    |   LRS/ZRS    |

# Database (Supplemental)
# Authentication and Authorization
## Identity Services
- Authentication: Confirming the Identity of a user.
- Authorization: comes after authorization and asks whether the particular user is allowed access.
  
## Azure Active Directory 
- Tenant: <br>The Tenant represents the organization.
- Dedicated AAD:<br> The tenant is a dedicated instance of AAD that an organization receives when signing up for Azure.
- Separate: <br>Each Tenant is distinct and completely separate from other AAD tenants.
- One User - one Tenant:<br> Each user in Azure can only belong to a single tenant. Users can be guests to other tenants. 

## Zero Trust 
All users are assumed untrustworthy unless proven otherwise.
- Trust proven by identity 
- Least privilege access - Just enough permissions to perform their Job.
- Regardless of location (trusted/Untrusted networks)

## MFA
Using at least 2 ways to log yourself in.

## Conditional Access
When user meets a set of conditions their access may require an action like seeking MFA .

## Passwordless Authentication
Increase convenience whiles staying secure.

- Microsoft Authenticator App
- WIndows Hello (Facial Recognition)
- FIDO2 Security Key(USB key)

## External guest Access
 1) Create a separate organisation account for an external user
 2) Invite guest to azure tenant as an external collaborator

## Azure Active Directory Domain Services

## Single Sign-on


# Azure Solutions (Supplemental)
# Security
## Defence in depth
- How Microsoft provides different layers of security for cloud infrastructure.

### Securing Network Connectivity
#### Firewall
- Set of rules that define what kind of traffic can access a device or service behind it.
- Firewalls come as hardware and software versions. They can suit any type and size of network.
- It is the critical part of any network 

#### Azure provides DDoS Protection Services <br>
Enabling several devices to connect to a a website in order to make several requests and Detects DDoS attacks. This is done with no downtime.

#### Network Security Group (NSG)
- A set of rules attached to a virtual network, subnet or network interface. 

### Public and Private Endpoints
#### Public Endpoints = Publicly Reachable PaaS Services
##### Service Endpoint
Allows you to connect privately connect VNet subnet to Azure Paas Services. <br>
Direct Connection from subnet to Azure PaaS services. <br>
Connects over Microsoft's private backbone (not over public internet)

##### Limitations of Service Endpoints
Provides secure access to azure VNets only. Not truly private. Service endpoints provide access to an entire service.


##### Private Endpoint
Provides a private connection to a specific instance of a service. It provides truly private connections over connected networks.You can completed disable all public exposure.

### Microsoft Defender for Cloud (Formerly Azure Security Center)
- Define Policies <br>
Set up Policies for Azure to monitor resources from. A policy is a set of rules used to evaluate a resource. User predefined policies or create your own.

- Protect Resources <br>
Actively protect your resources through monitoring your policies and their outcomes.

- Respond <br>
Respond to any security alerts. Investigate all of them then define new policies to account for alert.

### Key Vault (Supplemental)

### Azure Information Protection 

### Microsoft defender for Identity

### Azure Sentinel

### Azure dedicated host


# Monitoring and management

## Governance: 
## Azure policy:<br>
Is used to create policies in Azure. It is a set of rules created to assure all resources abide by the overall policy.
### Role Based Access Control:
- Defines which users have access to specific resources.
- Minimum access necessary to resources
- Target specific user cases
  
### Locks
- Assigning: Locks can be assigned to a subscription, resource group or resource.
- Types: Locks are of 2 type. Delete, where you can't delete the locked object and read only where you cant make any changes
- Lock needs to be removed before any actions can be taken on an object.

### Blueprints:
They are templates for creating standard Azure environments.

## Azure Monitor
It helps users identify services or resources that aren't work 100% capacity using collected telemetry.
- Log analytics: Lets the user analyse logs. in order to query a user would need to use Kusto Query Language (KQL)
- Application insights: Give a user insights into an application. Works with web apps only.
- Azure Monitor Alerts: Provides notifications in response to unexpected events. Comprises of an Alert rule made up of<br>
   
1) Monitored Resource:VM
2) Monitored Telemetry:CPU Utilization
3) Conditions to Trigger the Alert: > 90% for 5 minutes
4) Assigned Severity: LEvel 2 - Warning <br>
 
Action Group = The actions to take place once an alert is triggered.

## Azure Service Health
Comprises of:
- Dashboard highlighting resources and issues  affecting them.
- Custom Alerts: Enabling users to get notified of any outages planned or unplanned.
- Real time tracking to track any issues.
- Free service.

## Compliance
### GDPR
### ISO Standard
### NIST

### Azure compliance manager 
provides recommendations with the above
It can :<br>
- can provides tasks 
- provides a compliance score 
- Secure storage to upload documents to prove compliance 
- reports provides reports to provide the compliance.

## Privacy 
### Azure Privacy 
- Azure Information Protection
Classify, label and protect data based on data sensitivity.

- Azure Policy
Define and enforce rules to ensure privacy and external regulations.

- Guides
  Use guides on Azure to respond and comply with GDPR privacy requests.

- Compliance Manager
  
### Trust 
Trust center and service trust portal

### Azure Arc
A centralized governance and management tool for on-premises and multi-cloud computing resources.

- Benefits:
1) Manage Azure and non azure resources in the same place
2) Mange non-azure kubernetes clusters
3) Deploy Azure-managed database services to non-Azure locations.
4) Manage and protect non-Azure servers.
5) Apply Azure governance.
6) Deploy Azure serverless services to non-azure hardware.

# Pricing
## Subscription
Every resource belongs to a subscription. An account can have multiple subscriptions.
- Billing Admins Control Costs
- Management groups help keep track of many subscriptions in an account

## Cost Management
Use Azure cost management to keep costs low and optimize resources.

## Pricing Factors
1) Resource size 
2) Resource type
3) Location of the service 
4) and bandwidth and zones used 
   
There are 2 calculators for predicting cost Azure pricing calculator and Total Cost of Ownership Calculator

## Best practices
1) Use spending limits
2) Quotas for services 
3) tags to order resources
4) reserve instances to manage costs and 

# PASSED AZ-900 AZURE FUNDAMENTALS -> AZ-104
# AZ-104
# Azure Admin
## Understanding Resource Manager
The orchestration layer that manages resources in the Azure Cloud.
# Governance and compliance
Managing subscriptions 

Using Managing Groups 

## Azure policy 
- Policy Definition:<br>
Defines evaluation criteria for compliance and defines the actions that take place.

- Policy assignment:<br>
The scope at which we will assign our policy. The scope could be management group,
subscription,resource group,or resource.

- Initiative Definition 
A collection of policies that are tailored to achieving a singular high-level goal together. 

## Tagging Resources
The are a name value pair.
- Tags are not inherited.
- Resources can have 50 tags at a time.

## Locking and moving resources
### Locks
- Allows you to override permissions to resources
- You can lock subscriptions, resource groups, or resources.
- lock restrictions apply to all users and roles

### Lock types
- Read Only: <br> 
Allows users to read a resource, but they cannot delete or update.

- Cannot delete: <br>
Allows users to read a resource and modify, but they cannot delete or update.

- Locks are inherited from the parent scope

### Moving Resources
The process of moving resources that are contained in a specific place in Azure
to another place.

- If a resource is locked it then prevents the resource from being moved.

## Managing Azure Cost
### What Impacts Cost?
- Subscription type :  The type of subscription being used
- Resource Type : The resource type for example VM or Storage
- Usage Meters  : Utilities like ingress/egress network traffic and disk sizes
- Resource Usage : The cost of using a resource
- Location : Cost may vary for different regions

## Cost Best Practices
|Best Practices|Cost Tools|
|-|-|
|Select appropriate too for the user case|Pricing Calculator|
|De-allocate resources when not needed|Total Cost of Ownership (TCO) Calculator|
|Use cloud capabilities where possible (Scalability,elasticity)||
|Plan Cost prior to purchase||

### Tools Definition 
- Pricing Calculator
Used to create quotes of work loads

- TCO
Helps simulate how much it would cost to run the on premises workloads
on Azure. Compare costs to determine cost savings between on-premises and cloud solutions.

- Microsoft Cost Management
Microsoft Cost Management is a suite of tools that help organizations monitor, allocate, and optimize the cost of their Microsoft Cloud workloads.
Analyze costs , apply filtering and create budgets.

## Building a cloud governance strategy with azure tooling
### Cloud Governance
Cloud governance is a set of policies and rules used by companies who build or work in the cloud

### Planning cloud strategy
- Define : Define the governance needs of the organization 
- Plan : PLan which tools will be used to implement governance 
- Ready : Getting an understanding of how the tools will be used to implement governance
- Adopt : Implementing the cloud strategy for the organization

### Governance Services
- Management groups and subscriptions <br>
Organize subscriptions into hierarchical structures
- Azure RBAC <br>
Provide access to resources at varying scopes
- Policies <br>
Implement policies to enforce standards
- Locks and Tagging <br>
Lock resources to prevent deletion and modification

# Identity
## Azure Active Directory
### AAD Features
1. IAM PLatform <br>
IAM for Azure cloud-based resources
2. Identity Security<br>
Additional security with MFA and Privileged Identity Management
3. Collaboration and Development<br>
Azure AD B2B for collaboration and Azure AD B2C support development.
4. Monitoring<br>
Audit logs, security monitoring,identity protection and risk management.
5. Identity Integration<br>
Hybrid Identity(using AD Connect) and single sign on using Azure Domain Services.
6. Enterprise Access<br>
Additional security for applications and devices both on-premises and in the cloud.

 ## Managing Tenants
 ### Designing the Tenant
 Planning out the deign of our tenant will support easy adoption.

### Steps to create Tenant
(Go Over again)

Tenants are bound within a geographical region. Within the tenant / object is where you will have users and groups 
devices and applications ... 
As such we use IAM resource to provide access to resources.

1. Build secure Foundations<br>
Set up best practices, MFA, back up, global admin,privileged users for specific tasks
2. Populate Identity resources<br>
Add users, groups, devices and hybrid identities
3. Identify Apps<br>
Identify apps to be used from app gallery and register apps from on premises.
4. Monitor and Automate<br>
Monitor administrators, perform access reviews and automate user lifecycle.

## Creating and Managing Users
### Types of Users
- Administrators
Users with an administrator role assigned
- Members
Regular users that are native to Azure AD
- Guests 
External users that are invited to the Azure AD tenant
<br>
- Role assignment:<br>
Determines the permissions and access users are given.
- Object Ownership: <br>


### Methods of Creating Users

- Azure Portal
Navigate to Azure AD Service > select Users > New User

- Azure CLI
az ad user create

- PowerShell
new-AzureADUser

## Groups and Managing Groups
- Owners and Members: <br>


- Types of Group: <br>
1. Security:<br>
Security groups are used to manage resources for a group of users.

2. Microsoft 365:<br>
Used to grant members of a group access to things like a shared mailbox,Calendars,Files....


- Membership type: <br>
1. Assigned :<br>
Users are specifically selected to be apart of a group.

2. Dynamic User :<br>
Users are placed in a group based upon the properties they have.
Membership rules that are created automate the process.

3. Dynamic Device :<br>
Users are placed in a group based upon device properties.


# Role-Based Access Control
# Azure Storage
# Virtual Networking
# Inter-site connectivity
# Azure virtual machines
# Network Traffic Management
# Web App and Containers
# Monitoring
# Backup and recovery
# Wrap-up and practice

