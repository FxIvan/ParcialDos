# Sistema Generador de Comprobantes

Este proyecto consiste en una aplicación de escritorio desarrollada en **C# y Windows Forms**, que permite generar comprobantes a partir de la información contenida en dos archivos de texto: `CABECERA.txt` y `DETALLE.txt`.

## 🧾 Descripción del ejercicio

1. Se tienen dos archivos:
   - `CABECERA.txt`: contiene los encabezados de los comprobantes emitidos por un comercio.
   - `DETALLE.txt`: contiene los ítems o detalles correspondientes a cada comprobante.

   Ambos archivos están relacionados por el campo **Nro de Comprobante**.

2. La aplicación debe tener una interfaz gráfica con:
   - Un botón **"GENERAR COMPROBANTES"**: al presionarlo, se listan todos los comprobantes en un `ListBox`, incluyendo su cabecera (una sola vez por comprobante) y todos sus ítems.
   - Al final de cada comprobante debe aparecer el **TOTAL**, que resulta de la suma de los importes de sus ítems.
   - Un botón **"SALIR"**, que debe cerrar la aplicación.

---

## 📁 Archivos de entrada

### CABECERA.txt
Nro Comprobante;Razon Social;Fecha
1000101;Bar Unico;01/10/2022
1000110;El Ñandú;01/10/2022
1000115;Lavadero Todo limpio;02/10/2022
1000120;La pureza;02/10/2022
1000122;Carnes La Lonja;03/10/2022
1000125;Bazar Gaspar;03/10/2022

### DETALLE.txt
Nro Comprobante;Descripcion;Importe
1000101;Servicio de Mantenimiento Software;10500
1000101;Antivirus;5500
1000101;BackUp de Datos;2500
1000110;Instalacion de RED;55000
1000110;Instalacion de Software;10500
1000115;Servicio de Mantenimiento Software;10500
1000115;Antivirus;5500
1000115;Reparacion de RED;7500
1000120;Servicio de Mantenimiento Software;10500
1000122;Servicio de Mantenimiento Software;10500
1000122;Antivirus;5500
1000125;Servicio de Mantenimiento Software;10500
1000125;Antivirus;5500
1000125;Reparacion PC;45000
1000125;BackUp de Datos;2500

---

## 💻 Interfaz de usuario (GUI)

- **Botón "GENERAR COMPROBANTES"**: genera y muestra los comprobantes con su cabecera, ítems y total.
- **ListBox**: muestra en pantalla los comprobantes generados.
- **Botón "SALIR"**: cierra la aplicación.

---

## ✅ Resultado esperado

Ejemplo del contenido que se muestra en el `ListBox` tras presionar "GENERAR COMPROBANTES":

Comprobante: 1000101
Razón Social: Bar Unico
Fecha: 01/10/2022
- Servicio de Mantenimiento Software - $10500
- Antivirus - $5500
- BackUp de Datos - $2500
TOTAL: $18500
--------------
Comprobante: 1000110
Razón Social: El Ñandú
Fecha: 01/10/2022
- Instalacion de RED - $55000
- Instalacion de Software - $10500
TOTAL: $65500

...


---

## 🛠 Tecnologías utilizadas

- Lenguaje: **C#**
- Plataforma: **.NET Framework / Windows Forms**
- Lectura de archivos: `System.IO`
- Interfaz gráfica: `System.Windows.Forms`

---

## 🚀 Ejecución

1. Abrí el proyecto en Visual Studio.
2. Asegurate de que los archivos `CABECERA.txt` y `DETALLE.txt` estén en la misma carpeta que el ejecutable (por ejemplo: `bin\Debug`).
3. Ejecutá la aplicación.
4. Presioná **"GENERAR COMPROBANTES"** para ver los resultados.

---





