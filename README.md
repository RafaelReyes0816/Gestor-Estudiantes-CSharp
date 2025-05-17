# 🎓 Tarea 1 - Gestión de Estudiantes en C#

<div align="center">
  <img src="https://img.shields.io/badge/C%23-Console-blue?logo=csharp&logoColor=white" alt="C# Console" />
  <img src="https://img.shields.io/badge/Proyecto-Escolar-green" alt="Proyecto Escolar" />
</div>

---

## 📋 Descripción

Este proyecto es una aplicación de consola en **C#** que permite gestionar una lista de estudiantes. El usuario puede agregar, mostrar, buscar y borrar estudiantes, así como ver sus calificaciones.

---

## 🚀 Funcionalidades

- ✏️ **Agregar estudiante:** Solicita nombre, edad y entre 2 y 6 calificaciones.
- 📋 **Mostrar estudiantes:** Lista todos los estudiantes registrados y sus datos.
- 🔍 **Buscar estudiante:** Permite buscar estudiantes por nombre.
- 🗑️ **Borrar estudiante:** Elimina estudiantes por nombre.
- ✅ **Validaciones:** El programa valida entradas vacías o incorrectas y muestra mensajes claros.

---

## 🗂️ Estructura del proyecto

```
Tarea-1/
│
├── Program.cs
├── Models/
│   ├── Estudiante.cs
│   └── Persona.cs
├── Services/
│   ├── EscuelaService.cs
│   └── IEscuelaService.cs
├── Utils/
│   └── ArrayUtils.cs
└── Tarea-1.csproj
```

---

## 🖥️ ¿Cómo ejecutar?

1. Abre una terminal en la carpeta `Tarea-1`.
2. Ejecuta el siguiente comando:

   ```bash
   dotnet run
   ```

---

## 👨‍💻 Créditos

Desarrollado por **Juan Rafael Reyes Burgos** para la materia de *Estructuras de Datos*.

---