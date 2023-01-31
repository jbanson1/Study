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

# Compute 

# Networking 

# Storage

# Database

# Athuentication and Authorization 


### Cloud Shell commands

