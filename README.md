# Distopía Utópica – Sistema de Gestión de Biblioteca

## Descripción del proyecto

**Distopía Utópica** es una aplicación de consola desarrollada en C# que simula la gestión básica de una biblioteca. Su propósito es aplicar los fundamentos de programación mediante funciones estáticas, estructuras de control, validación de entradas y navegación entre menús y submenús.

El proyecto permite representar las principales operaciones de administración de libros, usuarios, préstamos, búsquedas, reportes y gestión de datos mediante mensajes descriptivos en consola.

Esta versión corresponde a una primera etapa de desarrollo enfocada en la estructura funcional y la simulación de operaciones, sin implementar almacenamiento ni manipulación real de información.

## Objetivo

Desarrollar una aplicación de consola que permita practicar y demostrar los conocimientos fundamentales de C#, mediante la construcción de un sistema de menús interactivos con navegación funcional, validaciones básicas y organización del código mediante métodos estáticos.

## Funcionalidades

El sistema está organizado en los siguientes módulos:

### 1. Gestión de libros
- Registrar libros.
- Listar libros.
- Consultar libros disponibles y prestados.
- Visualizar detalles de un libro por ID o ISBN.
- Simular la actualización de título, autor, año y categoría.
- Simular la eliminación de libros.

### 2. Gestión de usuarios
- Registrar usuarios.
- Listar usuarios.
- Consultar detalles por ID o documento.
- Simular la actualización de información personal y contacto.
- Simular la activación y desactivación de usuarios.
- Simular la eliminación de usuarios.

### 3. Gestión de préstamos
- Simular la creación de préstamos.
- Listar préstamos generales, activos y cerrados.
- Consultar detalles de préstamos por ID.
- Simular el registro de devoluciones.
- Simular la eliminación de préstamos.

### 4. Búsquedas y reportes
- Simular búsquedas de libros por título, autor, ID o categoría.
- Simular búsquedas de usuarios por nombre o ID.
- Representar consultas y reportes relacionados con los préstamos y el estado general de la biblioteca.

### 5. Gestión de datos
- Simular el guardado de información.
- Simular la carga de datos.
- Simular el reinicio de datos mediante confirmación del usuario.

### 6. Salida del sistema
- Solicitar confirmación antes de salir.
- Permitir elegir si se desea simular el guardado antes de finalizar la ejecución.
- Validar las respuestas del usuario.

## Tecnologías utilizadas

- **C#:** lenguaje de programación utilizado para desarrollar la aplicación.
- **.NET:** plataforma de desarrollo y ejecución.
- **Git:** sistema de control de versiones.
- **GitHub:** plataforma de alojamiento y gestión del repositorio.

## Conceptos de programación aplicados

- Métodos y funciones estáticas.
- Método principal `Main()`.
- Estructuras de selección `switch` y `case`.
- Estructuras condicionales `if` y `else`.
- Ciclos `do-while`.
- Captura de información mediante `Console.ReadLine()`.
- Validación básica de entradas.
- Navegación entre menús y submenús.
- Organización y reutilización de métodos.

## Requisitos para ejecutar el proyecto

Para ejecutar la aplicación se necesita:

- Sistema operativo compatible con .NET.
- SDK de .NET instalado.
- Git instalado (opcional, para clonar el repositorio).

## Instalación y ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/deossaandres170/DistopiaUtopica.git
```

### 2. Ingresar al directorio del proyecto

```bash
cd DistopiaUtopica
```

### 3. Ejecutar la aplicación

```bash
dotnet run --project src
```

## Estructura del proyecto

```text
DistopiaUtopica/
│
├── src/
│   └── Program.cs
│
├── .gitignore
└── README.md
```

## Estrategia de control de versiones

Para organizar el desarrollo se utilizó **Git Flow**, trabajando con ramas independientes para cada funcionalidad e integrando posteriormente los cambios en la rama `develop`.

### Ramas principales

- `main`: contiene la versión estable del proyecto.
- `develop`: integra las funcionalidades desarrolladas.

### Ramas de funcionalidades

- `feature/project-bootstrap`
- `feature/main-menu-navigation`
- `feature/books-menu`
- `feature/users-menu`
- `feature/loans-menu`
- `feature/search-reports-menu`
- `feature/persistence-menu`
- `feature/exit-flow`
- `feature/final-menu-validation`

Las funcionalidades se desarrollaron de manera independiente y posteriormente se integraron en `develop` mediante fusiones (`merge --no-ff`).

## Alcance y limitaciones

Esta versión del proyecto está orientada exclusivamente a la aplicación de la sintaxis básica de C# y la construcción de menús interactivos.

Por lo tanto:

- No implementa programación orientada a objetos.
- No utiliza colecciones para almacenar libros, usuarios o préstamos.
- No implementa operaciones CRUD reales.
- No utiliza bases de datos.
- No implementa persistencia real de información.
- Las operaciones se representan mediante funciones estáticas que muestran mensajes descriptivos en consola.

Estas limitaciones corresponden al alcance establecido para esta primera etapa del proyecto.

## Autor

**Andrés Deossa**

Estudiante de Análisis y Desarrollo de Software (ADSO).

## Repositorio

[GitHub – Distopía Utópica](https://github.com/deossaandres170/DistopiaUtopica)