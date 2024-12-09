# UEH Coffee Shop Management System

## Setup Database

Change the connection string in `App.config` to your local SQL Server.

```config
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <connectionStrings>
    <add name="Local"
        connectionString="<your_local_SQL_server>"
        providerName="System.Data.SqlClient" />
    </connectionStrings>

    <startup>
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
    </startup>
</configuration>
```

---
