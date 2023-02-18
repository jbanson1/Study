# Azure Notes

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

- Cache:<br> Temporary copies of original files. to optimize speed for an application
  till the copy expires.

- Origin Server: <br> The original location of the files such as a web application.

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
# Database
# Authentication and Authorization
# Azure Solutions (Supplemental)
# Security
# Monitoring and management
# Pricing
# Support (Supplemental)
# Authentication and Authorization  


### Cloud Shell commands

