
CST8921 – Lab 7: Smart Turbine Monitoring System
Overview
This project implements a cloud-based Smart Turbine Monitoring solution using Azure services.

Wind turbine telemetry is generated and sent to Azure Event Hub. An Azure Function processes the incoming events, determines the health status of each turbine, and stores the results in Azure Table Storage.

A Logic App periodically checks the table for turbines with an URGENT status and automatically sends email notifications.

Architecture
WindGenerator (.NET) -> Azure Event Hub -> Azure Function -> Azure Table Storage -> Azure Logic App -> Office 365 Outlook

Azure Services Used
Azure Event Hub
Azure Function App
Azure Table Storage
Azure Logic Apps
Office 365 Outlook Connector
Workflow
WindGenerator sends telemetry to Event Hub.

Azure Function receives telemetry.

Function determines turbine status.

Telemetry is saved into Azure Table Storage.

Logic App runs every minute.

Logic App retrieves records with: "Status eq 'URGENT'"

Logic App sends email notifications.

Result
The system successfully detects unhealthy turbines and automatically sends email alerts.

The Smart Turbine Monitoring System was successfully implemented using Azure cloud services.

The solution performs the following tasks:

Generates simulated wind turbine telemetry.
Sends telemetry to Azure Event Hub.
Processes incoming events using Azure Functions.
Determines the turbine health status (HEALTHY or URGENT).
Stores processed telemetry in Azure Table Storage.
Uses Azure Logic Apps to retrieve URGENT records.
Automatically sends email notifications through Office 365 Outlook.
The project demonstrates an end-to-end event-driven cloud architecture using serverless Azure services.
