# Documentation

## Clone Repository
- lakukan `clone` pada project menggunakan peritah `git clone`.
#### contoh :
```
https://github.com/alwi09/TestILCSDotnet.git
```

## Setup Database
- Buka `appsettings.json`, lalu ubah `host`,`Database`,`Username`,`Password`.

#### Contoh :
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "Postgres_DB": "Host=localhost;Database=<nama_database>;Username=postgres;Password=<password>"
  }
}

```

## How to run Project
- pastikan menggunakan SDK version `.NET 6`.
- masuk ke dalam project.
- lakukan perintah `dontnet build` di terminal.
- lalu lakukan perintah `dontnet ef migrations add InitialCreate`,
- lanjut lakukan perintah `dotnet ef database update`.

