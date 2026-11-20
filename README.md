# Examen Práctico – Programación Básica
## Cafetería "El Buen Sabor" – Pedidos (Windows Forms, C#)

## 1. Datos del estudiante
- **Nombre:** ROTCIV OZUNA
- **Matrícula:** 2025-2501
- **Fecha:** 19/11/2026

## 2. Descripción del programa
Aplicación de escritorio en Windows Forms (C#) para la cafetería "El Buen Sabor". Registra los productos de un pedido y calcula el subtotal, el descuento por cliente frecuente, el empaque para llevar, el ITBIS y el total a pagar. Todo está en un solo formulario (`frmPedidos`).

## 3. Datos de entrada
- Cliente (nombre) y si es cliente frecuente.
- Fecha del pedido.
- Producto (nombre) y precio unitario, digitados.
- Cantidad (de 1 a 20).
- Tamaño: Normal o Grande (+RD$25).
- Porción extra (+RD$30).
- Servicio: Consumir en local o Para llevar (+RD$20).

## 4. Proceso
1. Precio unitario = precio digitado + 25 si es grande + 30 si lleva porción extra.
2. Total de línea = precio unitario × cantidad. Subtotal = suma de las líneas.
3. Descuento = 10 % del subtotal si el cliente es frecuente.
4. Empaque = RD$20 una sola vez por pedido si es "Para llevar".
5. Base imponible = subtotal − descuento + empaque.
6. ITBIS = 18 % de la base imponible. Total = base imponible + ITBIS.

## 5. Salida
Las líneas del pedido se muestran en columnas (Cant, Producto, Precio, Total) y los resultados en formato `RD$ 0.00`: subtotal, descuento, empaque, ITBIS y total a pagar.

**Caso de prueba:** María Pérez (frecuente), Sándwich 180 × 2 grande = 410.00; Jugo 120 × 1 con porción extra = 150.00; para llevar.
Subtotal 560.00 · Descuento 56.00 · Empaque 20.00 · Base 524.00 · ITBIS 94.32 · **Total RD$ 618.32**

## 6. Captura de pantalla
![Programa en ejecución]()
