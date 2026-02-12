# 📊 Sistema CRUD de Clientes con ASP.NET MVC y MySQL

## 📌 Descripción del Proyecto

Este proyecto consiste en el desarrollo de una aplicación web utilizando **ASP.NET MVC** integrada con una base de datos **MySQL**, permitiendo la gestión completa de clientes mediante operaciones CRUD (Create, Read, Update, Delete).

La aplicación implementa Entity Framework Core con el proveedor Pomelo para MySQL, asegurando una conexión eficiente entre la aplicación y la base de datos.

---
## 👥Integrantes del Grupo 4

Jeurys José Durán Beato - A00115777

Bladimir Ventura - A00115757

Ángel Javier Barrientos - A00115984

Miguel José Saint Hilaire Peña - A00116662

Sean Alcántara Carrera - A00115911 

---

## 🎯 Objetivo

Integrar una base de datos MySQL en una aplicación ASP.NET MVC para la gestión estructurada de información, aplicando buenas prácticas de desarrollo y arquitectura MVC.

---

## 🛠 Tecnologías Utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- Pomelo.EntityFrameworkCore.MySql
- MySQL (Railway)
- Bootstrap (estilo base)
- Git & GitHub

---

## 🏗 Arquitectura del Proyecto

El sistema sigue el patrón MVC:

- **Model** → Clase `Cliente`
- **View** → Vistas Razor generadas automáticamente
- **Controller** → `ClientesController`
- **Data** → `ApplicationDbContext`
- **Database** → MySQL (Railway)

---
## 🖥 Funcionalidades CRUD

✔ Crear cliente
✔ Listar clientes
✔ Editar cliente
✔ Eliminar cliente
✔ Persistencia en MySQL

---
## 🔄 Diagrama de Flujo del Sistema

A continuación se muestra el flujo general de funcionamiento del CRUD integrado con MySQL:

<img width="1024" height="1536" alt="ChatGPT Image 12 feb 2026, 12_10_57 a m" src="https://github.com/user-attachments/assets/f24dff36-ce18-4cbf-959a-f275f47ba1f7" />


---

## 🧩 Modelo Implementado

```csharp
public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
}
```
---
📚 Proyecto Académico

Desarrollado como práctica de integración de ASP.NET MVC + MySQL + Entity Framework Core, aplicando operaciones CRUD y conexión a base de datos remota.
