# Azure Notes

# Cloud Concepts

### High availablility:
Ensuring that systems are always available
|traditional | Cloud|
|---|---|
|You own the hardware | You dont own the hardware| 
|You have physical access| Add more servers with a click|
|You cant "Just add servers"| If hardware fails easily replaceable|

### Reliabliity
Explains how Azure can tolerate failures or disasters.
- Resilience:<br>
The ability of a system to recover from failures and continue to function.

Reliability is achieved by either <br>
1) Deploy to Multiple Locations<br>
- Global scale computing<br>
- Which protects against<br>

2)No Single Point of Failure
- Resources in multiple Locations
- If one computer goes down, others pick up the load

### Scalability
Is the process of scaling up out or down to handle the demand of customers. By increasing the amount of VM when demand is high and removing them when demand is low.

- Horozontal Scaling:<br>
The act of creating more Virtual Machines

- Verticle Scaling:<br>
The act of increasing the power of existing Virtual Machines.

### Predictability 
Knowing the application will perform as expected and knowing the cost
- Performance:<br>
The experience remains consistent for customers regardless of the traffic.<br>
Autoscaling, load balacing and high availability provide a constant experience.

- Costs:<br>
No unexpected costs<br>
Track and forecast usage of resources in real time<br>
Analytics provide trends to enable forcasting

### Security
Having full control of the cloud security posture
- Full control of the security of cloud environment. Patches, Maintenance, network control and more!

### Governence
Governance how you meet requirements/Company standards
- Creating standardized environments
- Regulatory requirements (e.i password reset) 
- Audit for compliance

### Managability
1)Management of The Cloud:<br>
Refers to how you manage different cloud resources
- Autoscaling
- Monitoring
- Template based deployments

2)Management within the cloud<br>
How you interact with the resources
- Portal
- CLI
- APIs<br>
---------------------------------------------------
---------------------------------------------------
### Cloud Service Models
---
#### Infrastructure As A Service
Provides virtual computing resources such as servers, Storage and VM.

#### Platform As A Service
Provides a platform such as windows enabling users to run software on in an
integrated manner.(i.e.Windows 10)

#### Software As A Service
Users are not responsible for the hardware or software as licences and services 
are maintained by Azure.
Can only be accessed over the internet.(i.e. Email)

-----------------------------------------------------
-----------------------------------------------------

### Cloud Architect Models
---

#### Private:
Is azure on a hardware of users choosing in a location of choice with all the benefits of public cloud but requires alot of staff to manage.
|Pros|Cons|
|---|---|
|Complete control of infrastructure |Organisations IT department is responsible for Maintenance Microsoft will not step in|
|Benefits of public cloud| Requires the same staffing as traditional data centers |
|Better security aand better privacy| |

#### Public:
Azure, Aws , GCP. NO upfront cost but charged for monthly usage.
Little control over services and infrastucture.
|Pros|Cons|
|---|---|
|No purchase of hardware|No controll as to updates on features|
|Low monthly Fee| No conttrol on where the data is stored|

#### Hybrid:
Is a combination of both private and public cloud but can be very complicated.
|Pros|Cons|
|---|---|
|Gradual intergration to avoid disruptions and outages|Complexity to create|
|Some applications dont live in teh public cloud for regulatory purposes,governence||
|Allows appliactions and data to span between both public and private cloud||
|Alleviate CapEx investments||

-----------------------------------------------------
-----------------------------------------------------
# Azure Architecture
---
## Regions<br>
A set of datacenters deployed within a latency-defines
perimeter and connected through a dedicated regional 
low latency network.<br>
Each region has more than 1 data center.

### How to decide what region to use
- Location:<br>
Choosing a region close to users to reduce latency.

- Features:<br>
Not all features are available in all regions. New regions 
would have more features.

-Pricing:<br>
May vary deoending on the region. <br>

Each region is paired so if one region fails another region would take over.

### Availability Zones
- Each availability zone is a physical location within a region.
- Each zone is independant having it's own power, cooling and network.
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
Deploying resources from various tools will always reult in the same consistent state.

- Dependencies:<br>
You can define dependencies between resources to prevent
clashing.

- Access control:<br>
It makes it easy to asign rights too users

- Tagging:<br>
Tag resource to easily identify them for futures purposes.
It is a way of relabeling.

- Billing:<br>
Can use taggin to identify groups for billing purposes.

# Compute 

# Networking 

# Storage

# Database

# Athuentication and Authorization 


### Cloud Shell commands

