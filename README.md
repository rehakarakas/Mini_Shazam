# Database Setup

This application uses Microsoft SQL Server to store audio fingerprints and track metadata.

### Requirements
*   Microsoft SQL Server (LocalDB / Express is sufficient)
*   SQL Server Management Studio (SSMS)

### Database Creation
To create the required database and tables:
1.  Open **SQL Server Management Studio (SSMS)**.
2.  Connect to your local SQL Server instance.
3.  Open the SQL script located at: `/Database Script/DBScript.sql`
4.  Execute the script.
5.  The database **FingerprintsDb** and all required tables will be created automatically.

### Connection String
Make sure the connection string in `App.config` matches your local SQL Server configuration. It should look like this:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
	<connectionStrings>
		<add name="FingerprintConnectionString" 
             connectionString="Data Source=(local);Initial Catalog=FingerprintsDb;Integrated Security=True; Connection Timeout=15;" 
             providerName="System.Data.SqlClient"/>
	</connectionStrings>
</configuration>
