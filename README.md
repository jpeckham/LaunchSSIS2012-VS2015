# LaunchSSIS2012-VS2015
Launch ssis from VB.net code using sql 2012 and VS 2015

## Primary goals
- Use SQL 2012 with SSIS (Special needs, SP 2 CU1-6+SEC 1)
- VS 2015
- Visual Basic
- Launch SSIS package from file locally
- Windows 7 Enterprise

## Other thoughts
### Does SSIS have to be 2012?
We're connecting remotely to a sql 2012 server. Seems like we could use whatever SSIS we wanted locally.

## Environment Setup
* Setup new VM 4 gigs ram, 4 CPU
* Install Win 7 Enterprise SP 1
* Install SQL 2012 SP2 Developer Edition
  - Database engine
  - MGMT tools (all)
  - Client Connectivity
  - Client Connectivity SDK
* Install VS 2015
  - Git
  - Web Apps
  - SSDT (SQL Server Data Tools)
* Install SSDT for VS 2015 version 17.4 "SSDT for VS2015 17.4" found at https://docs.microsoft.com/en-us/sql/ssdt/previous-releases-of-sql-server-data-tools-ssdt-and-ssdt-bi?view=sql-server-2017

## Key Challenges
* Mismatch of .net version to the Managed DTS runtime. v2 vs v4.5. This article was key: https://stackoverflow.com/questions/29240142/mixed-mode-assembly-is-built-against-version-v2-0-50727-of-the-runtime-and-can/29241003#29241003
* Target SSIS version should/must be changed from SQL 2017 to SQL 2012
