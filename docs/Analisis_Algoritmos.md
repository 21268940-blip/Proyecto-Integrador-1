# Análisis Técnico y Comparación de Algoritmos

Este documento analiza los algoritmos implementados manualmente en el proyecto **Sistema de Gestión de Biblioteca Escolar**.

---

## 1. Algoritmo de Ordenamiento: Insertion Sort (Inserción Directa)

### Descripción
El ordenamiento por inserción recorre el catálogo de libros elemento por elemento. Toma el libro actual (`clave`) y lo inserta en su posición ordenada correspondiente dentro de la sublista previa, desplazando los elementos mayores hacia la derecha.

### Complejidad Computacional
* **Peor caso $O(n^2)$**: Ocurre cuando el catálogo de libros está en orden totalmente inverso. Requiere comparar y desplazar cada elemento con todos los elementos anteriores.
* **Caso promedio $O(n^2)$**: En listas desordenadas aleatoriamente.
* **Mejor caso $O(n)$**: Ocurre si la lista ya se encuentra ordenada; solo realiza una comparación por elemento sin desplazamientos.
* **Espacio $O(1)$**: Es un algoritmo in-place (in situ), opera directamente en la memoria ocupada por la lista sin requerir espacio adicional.

---

## 2. Comparación de Búsqueda: Secuencial (Lineal) vs. Binaria

| Criterio | Búsqueda Secuencial (Lineal) | Búsqueda Binaria |
| :--- | :--- | :--- |
| **Complejidad Peor Caso** | $O(n)$ | $O(\log n)$ |
| **Complejidad Mejor Caso** | $O(1)$ | $O(1)$ |
| **Requisito Previos** | Ninguno (funciona en desorden) | **La lista debe estar ordenada** |
| **Rendimiento con $n = 10,000$** | Hasta 10,000 comparaciones | Máximo 14 comparaciones ($\log_2 10,000 \approx 13.29$) |
| **Acceso a datos** | Secuencial (uno a uno) | Acceso aleatorio directo por índices |

### Conclusión del Análisis
La **Búsqueda Binaria** ofrece una eficiencia drásticamente superior a la Búsqueda Secuencial cuando el número de registros en la biblioteca crece exponencialmente. Sin embargo, impone el requisito estricto de mantener el catálogo ordenado previamente mediante **Insertion Sort**.