# Proyecto Integrador: Sistema de Gestión de Biblioteca Escolar

**Integrantes:** ALDO DAVID CRUZ JAIMES  
**Tecnologías:** C#, .NET Core, Git, VS Code

## Descripción del Proyecto
Sistema en consola desarrollado para administrar títulos de una biblioteca escolar. El proyecto destaca por el desarrollo manual de algoritmos fundamentales de ordenamiento y búsqueda, excluyendo el uso de librerías automáticas de ordenación.

## Funcionalidades Principales
- **Registro de Títulos:** Permite ingresar nuevos libros validando sus campos principales.
- **Insertion Sort (Ordenamiento por Inserción):** Algoritmo manual que ordena el catálogo alfabéticamente por título ($O(n^2)$).
- **Búsqueda Binaria:** Algoritmo de búsqueda eficiente ($O(\log n)$) ejecutado sobre el catálogo previamente ordenado.
- **Persistencia de Datos:** Guardado y carga automática en el archivo `src/catalogo.txt`.
- **Manejo de Errores:** Control de excepciones y validaciones de entrada para estabilidad del software.

## Estructura del Proyecto
- `src/`: Código fuente de la aplicación (`Program.cs`, `Biblioteca.cs`, `Titulo.cs`).
- `docs/`: Documentación técnica y análisis comparativo de complejidad algorítmica (`Analisis_Algoritmos.md`).

## Instrucciones de Ejecución
1. Clonar el repositorio:
   ```bash
   git clone [https://github.com/tu-usuario/Proyecto-Integrador-1.git](https://github.com/tu-usuario/Proyecto-Integrador-1.git)