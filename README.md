# Practica - Sistema de Facturación

Proyecto de escritorio en **C# Windows Forms** desarrollado según la Guía Práctica de Laboratorio Nº 1 (Herramientas de programación III).

## Contenido del repositorio

- **Pantallas_Sistema_facturacion/** – Aplicación de escritorio con formularios de login, catálogos (Clientes, Productos, Categorías), ventas (Facturas), empleados, roles, administración de seguridad, informes, ayuda y acerca de.

## Requisitos

- Visual Studio 2019 o superior
- .NET Framework 4.8

## Cómo ejecutar

1. Abrir la solución:
   ```
   Pantallas_Sistema_facturacion/Pantallas_Sistema_facturacion.sln
   ```
2. En Visual Studio: **Compilar** (F6) y **Ejecutar** (F5).
3. En la ventana de login ingresar cualquier usuario y contraseña, luego **Ingresar**.

## Desde la terminal

```powershell
cd Pantallas_Sistema_facturacion
dotnet build
dotnet run
```

## Estructura principal

| Menú           | Pantallas                                      |
|----------------|-------------------------------------------------|
| Catálogos      | Clientes, Productos, Categoría Productos       |
| Ventas         | Facturas                                       |
| Administración | Empleados, Rol Empleados, Administración Seguridad |
| Informes       | Informes                                      |
| Ayuda          | Ayuda (WebBrowser), Acerca de...               |

Los formularios de edición usan **ErrorProvider** para validar campos obligatorios al guardar.

---
*Tecnología en Desarrollo de Software – Herramientas de programación III*
