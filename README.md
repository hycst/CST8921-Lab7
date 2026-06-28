#### CST8921 – Cloud Industry Trends
#### Lab 7 – Smart Turbine Monitoring System


#### Overview
This project implements a cloud-based Smart Turbine Monitoring System using Microsoft Azure.
The solution simulates wind turbine telemetry, processes incoming events with Azure Functions, stores processed data in Azure Table Storage, and automatically sends email notifications when an unhealthy turbine is detected.
Azure Services Used

-	Azure Event Hub
-	Azure Function App
-	Azure Table Storage
-	Azure Logic Apps
-	Office 365 Outlook




________________________________________
#### Architecture


#### Architecture

```text
WindGenerator (.NET)
        │
        ▼
Azure Event Hub
        │
        ▼
Azure Function
        │
        ▼
Azure Table Storage
        │
        ▼
Azure Logic App
        │
        ▼
Email Notification
```




####  Workflow
1.	WindGenerator generates wind turbine telemetry.
2.	Telemetry is sent to Azure Event Hub.
3.	Azure Function processes each event.
4.	The function determines the turbine health status:
o	HEALTHY
o	URGENT
5.	Processed telemetry is stored in the TurbineMetrics Azure Table.
6.	Azure Logic App runs every minute.
7.	Logic App retrieves records using the filter:  Status eq 'URGENT'
8.	Email notifications are automatically sent through Office 365 Outlook.

   
________________________________________
####  Project Structure

#### Project Structure

```text
lab7
│
├── FunctionEGDWDumper
├── WindGenerator
├── Screenshot
└── README.md
```
________________________________________

#### Sample Email Notification

Subject：
Smart Turbine Alert - URGENT CST8921 Lab7

From： H Y<hy7work@outlook.com>

Email Body：
Hi,

An unhealthy wind turbine has been detected.

Device:
TURBINE-2

Time:
20260624235938502

Status:
URGENT

Wind Speed:
23

Generated Power:
3

Please check the turbine immediately.

CST8921 Lab7

________________________________________








####  Screenshots
#####  Event Hub
 <img width="1904" height="1002" alt="Event_Hub" src="https://github.com/user-attachments/assets/33c400a4-5abb-449f-90ca-3506cc3c6a07" />

##### WindGenerator Console
 
<img width="1163" height="648" alt="WindGenerator console" src="https://github.com/user-attachments/assets/7a430491-a39f-4a97-a413-ca52e1c7ac30" />

##### Azure Function
 <img width="1261" height="715" alt="FunctionApp" src="https://github.com/user-attachments/assets/ed37fe69-daac-4b48-bf99-7ede04c91a85" />

##### Azure Table Storage
 
<img width="1909" height="926" alt="Table" src="https://github.com/user-attachments/assets/5708e62d-4570-43e9-89b8-f2448e21a6bb" />

 
 

##### Logic App Workflow Execution

<img width="1906" height="656" alt="Web_Log_App" src="https://github.com/user-attachments/assets/e15fd920-8a51-4eb1-ae3b-10068b689c4b" />


 
 

 



 

 





##### Email Notification Received

<img width="1163" height="648" alt="EMail_Received" src="https://github.com/user-attachments/assets/43ec74a2-fde4-4189-a4ed-1ef30779b31a" />



#####  Validate Table Storage Writes
<img width="1900" height="979" alt="Validate Table Storage Writes" src="https://github.com/user-attachments/assets/ce59bf02-89e1-4ad6-93a8-4ab50bab87e7" />


##### Logic App Sends Email Notification
 


<img width="975" height="504" alt="image" src="https://github.com/user-attachments/assets/fe9107b5-9c2f-457d-a75b-93574b00d05b" />



##### Logic App Run History

<img width="1904" height="979" alt="Logic_app_rrunning_history" src="https://github.com/user-attachments/assets/bc0ff50b-22f8-4791-8c78-6a7ac9326ef7" />
<img width="1912" height="918" alt="Running_History" src="https://github.com/user-attachments/assets/af1af215-fee0-41b7-abf4-350d65bd3099" />

 
##### Email Notification
 
 



<img width="1900" height="949" alt="Work_flow" src="https://github.com/user-attachments/assets/c210d841-f3b1-43ed-9d10-08d23cfd1598" />
<img width="1885" height="868" alt="Email" src="https://github.com/user-attachments/assets/02725c40-f9a5-4df6-b83f-22db5877b4d2" />


<img width="1163" height="722" alt="Sends email notification" src="https://github.com/user-attachments/assets/67400667-d6be-4629-ba84-982e30d33a43" />














##### GitHub Repository
https://github.com/hycst/CST8921-Lab7
 <img width="1251" height="807" alt="git" src="https://github.com/user-attachments/assets/44ffa22c-847b-40d9-a9bb-5bd1cf3ae489" />

________________________________________
#### Run Procedure
1.	Deploy the Azure Function App.
2.	Configure Event Hub and Azure Table Storage.
3.	Run the WindGenerator application.
4.	Verify telemetry is stored in Azure Table Storage.
5.	Wait for the Logic App to execute.
6.	Check Outlook for URGENT email notifications.

##### Result
The Smart Turbine Monitoring System was successfully implemented using Azure cloud services. The solution demonstrates an end-to-end event-driven serverless architecture by:


1. Generating simulated wind turbine telemetry.
2. Sending telemetry to Azure Event Hub.
3. Processing incoming events using Azure Functions.
4. Determining the turbine health status (HEALTHY or URGENT).
5. Storing processed telemetry in Azure Table Storage.
6. Retrieving URGENT records using Azure Logic Apps.
7. Automatically sending email notifications through Office 365 Outlook.

This project demonstrates how Azure Event Hub, Azure Functions, Azure Table Storage, and Azure Logic Apps can be integrated to build a scalable, event-driven monitoring solution.






