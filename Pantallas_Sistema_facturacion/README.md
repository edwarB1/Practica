# Pantallas_Sistema_facturacion

Proyecto de escritorio en C# Windows Forms según la **Guía Práctica de Laboratorio Nº 1** - Herramientas de programación III.

## Requisitos

- Visual Studio 2019 o superior (o .NET Framework 4.8 SDK)
- .NET Framework 4.8

## Contenido del proyecto

### Formularios implementados

1. **frmLogin** – Formulario de ingreso al sistema (usuario y contraseña).
2. **frmPrincipal** – Formulario principal con menú y panel contenedor (abre formularios en el panel, sin MDI).
3. **Clientes**
   - **frmListaClientes** – Lista de clientes (Nuevo / Editar).
   - **frmClientes** – Ingreso/edición de cliente (validación con **ErrorProvider**).
4. **Productos**
   - **frmListaProductos** – Lista de productes.
   - **frmProductos** – Ingreso/edición de producto (ErrorProvider).
5. **Categoría Productos**
   - **frmListaCategoriaProductos** – Lista de categorías.
   - **frmCategoriaProductos** – Ingreso/edición de categoría (ErrorProvider).
6. **frmFacturas** – Facturas (cliente, fecha, detalle; validación con ErrorProvider).
7. **Empleados**
   - **frmListaEmpleados** – Lista de empleados.
   - **frmEmpleados** – Ingreso/edición de empleado (ErrorProvider).
8. **Rol Empleados**
   - **frmListaRolEmpleados** – Lista de roles.
   - **frmRolEmpleados** – Ingreso/edición de rol (ErrorProvider).
9. **frmAdminSeguridad** – Administración de seguridad (usuarios, contraseña, rol; ErrorProvider).
10. **frmInformes** – Informes (tipo, rango de fechas).
11. **frmAyuda** – Ayuda con **WebBrowser** (URL: página oficial de Microsoft).
12. **frmAcercaDe** – Acerca de (panel con Labels, TextBox Multilinea y botón Cerrar).

### Menú principal

- **Archivo** → Salir  
- **Catálogos** → Clientes, Productos, Categoría Productos  
- **Ventas** → Facturas  
- **Administración** → Empleados, Rol Empleados, Administración Seguridad  
- **Informes**  
- **Ayuda** → Ayuda, Acerca de...

### Validación

En los formularios de ingreso/edición se valida al presionar **Actualizar** o **Guardar**:

- Campos principales no vacíos.
- Uso de **ErrorProvider** del cuadro de herramientas según la guía.

## Cómo ejecutar

1. Abrir `Pantallas_Sistema_facturacion.sln` en Visual Studio.
2. Restaurar paquetes si lo pide.
3. Compilar (F6 o menú Compilar).
4. Ejecutar (F5). Se muestra primero **frmLogin**; al hacer clic en Ingresar se abre **frmPrincipal** con el menú.

## Entrega (según guía)

1. Comprimir la carpeta del proyecto.
2. Nombre del archivo: `PRACTICA_AEAE 2_su_nombre_y_apellido.zip`
3. Subir por el formulario indicado en la guía.
