CST8921 – Cloud Industry Trends
Lab 7 – Smart Turbine Monitoring System


Overview
This project implements a cloud-based Smart Turbine Monitoring System using Microsoft Azure.
The solution simulates wind turbine telemetry, processes incoming events with Azure Functions, stores processed data in Azure Table Storage, and automatically sends email notifications when an unhealthy turbine is detected.
Azure Services Used
•	Azure Event Hub
•	Azure Function App
•	Azure Table Storage
•	Azure Logic Apps
•	Office 365 Outlook












________________________________________
Architecture
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









Workflow
1.	WindGenerator generates wind turbine telemetry.
2.	Telemetry is sent to Azure Event Hub.
3.	Azure Function processes each event.
4.	The function determines the turbine health status:
o	HEALTHY
o	URGENT
5.	Processed telemetry is stored in the TurbineMetrics Azure Table.
6.	Azure Logic App runs every minute.
7.	Logic App retrieves records using the filter:
Status eq 'URGENT'
8.	Email notifications are automatically sent through Office 365 Outlook.
________________________________________
Project Structure
lab7
│
├── FunctionEGDWDumper
├── WindGenerator
├── Screenshot
└── README.md
________________________________________
Sample Email Notification


Project Structure
lab7
│
├── FunctionEGDWDumper
├── WindGenerator
├── Screenshot
└── README.md
________________________________________
Sample Email Notification
 

Subject：
Smart Turbine Alert - URGENT CST8921 Lab7

From： H Y<hy7work@outlook.com>

Email Body：
Hesheng Yang
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








Screenshots
Event Hub
 
WindGenerator Console
 

Azure Function
 
Azure Table Storage
 

 
 

Logic App Workflow Execution

 

 
 

 



 

 





Email Notification Received
 
Logic App Sends Email Notification
 





Logic App Run History
 
Email Notification
 
 
















GitHub Repository
https://github.com/hycst/CST8921-Lab7
 
________________________________________
Run Procedure
1.	Deploy the Azure Function App.
2.	Configure Event Hub and Azure Table Storage.
3.	Run the WindGenerator application.
4.	Verify telemetry is stored in Azure Table Storage.
5.	Wait for the Logic App to execute.
6.	Check Outlook for URGENT email notifications.
Result
The Smart Turbine Monitoring System was successfully implemented using Azure cloud services.
The solution demonstrates an end-to-end event-driven serverless architecture by:
•	Generating simulated wind turbine telemetry.
•	Sending telemetry to Azure Event Hub.
•	Processing incoming events using Azure Functions.
•	Determining the turbine health status (HEALTHY or URGENT).
•	Storing processed telemetry in Azure Table Storage.
•	Retrieving URGENT records using Azure Logic Apps.
•	Automatically sending email notifications through Office 365 Outlook.
This project demonstrates how Azure Event Hub, Azure Functions, Azure Table Storage, and Azure Logic Apps can be integrated to build a scalable, event-driven monitoring solution.






