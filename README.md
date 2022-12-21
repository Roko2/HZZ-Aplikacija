# HZZ-Aplikacija
.NET Win forms application for free jobs that are on labors market in Croatia

## Additional files

Must have file: **App.config** placed in HZZ_Kovac/HZZ_Kategorije

App.config has infomation about version of framework and connection string
```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <connectionStrings>
    <add name="DbConnection" connectionString="{your_db}"/>
  </connectionStrings>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6.1"/>
    </startup>
</configuration>
```

> Data for your db is in a script that is called **HZZScript.sql**
