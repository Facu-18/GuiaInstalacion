# 🚀 Guía de Inicio del Proyecto

## 📁 Referencias entre Proyectos

| Proyecto | Depende de |
|---|---|
| `Proyecto.BD` | `Proyecto.Shared` |
| `Proyecto.Repository` | `Proyecto.BD`, `Proyecto.Shared` |
| `Proyecto.Servicios` | `Proyecto.Shared` |
| `Proyecto.Server` | `Proyecto.BD`, `Proyecto.Repository`, `Proyecto.Shared`, `Proyecto.Client` |
| `Proyecto.Client` | `Proyecto.Shared` |

---

## 📦 NuGet Packages

### `Proyecto.BD`
- `Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Design`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools`

### `Proyecto.Server`
- *(2 paquetes instalados por defecto)*
- `Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Design`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools`

---

## ⚙️ Configuración

### `appsettings.json`

```json
{
  "ConnectionStrings": {
    "ConnSqlServer": "url base de datos"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

### `Proyecto.Server/Program.cs`

Agregar luego de `var builder = WebApplication.CreateBuilder(args);`:

```csharp
string connectionString = builder.Configuration.GetConnectionString("ConnSqlServer")
    ?? throw new InvalidOperationException("No existe la conexión con la base de datos.");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
```

---

## 🗄️ Migraciones

Ejecutar desde la **Package Manager Console** con `Proyecto.BD` como proyecto por defecto, y `Proyecto.Server` como startup:

```
add-migration Inicio -Project Proyecto.BD -StartupProject Proyecto.Server
```

```
Update-Database -Project Proyecto.BD -StartupProject Proyecto.Server
```
