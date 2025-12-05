# Función para calcular total
def calcular_total(ventas):
    total = 0
    for v in ventas:
        total += v
    return total

# Función para calcular el mayor y su día
def calcular_mayor(ventas):
    mayor = ventas[0]
    dia_mayor = 1
    for i in range(1, len(ventas)):
        if ventas[i] > mayor:
            mayor = ventas[i]
            dia_mayor = i + 1
    return mayor, dia_mayor

# Función para calcular el menor y su día
def calcular_menor(ventas):
    menor = ventas[0]
    dia_menor = 1
    for i in range(1, len(ventas)):
        if ventas[i] < menor:
            menor = ventas[i]
            dia_menor = i + 1
    return menor, dia_menor

# Función para calcular el promedio
def calcular_promedio(total, n):
    return total / n

# Función para mostrar días > 20
def mostrar_mayores_20(ventas):
    print("\nDías con ventas mayores a 20 unidades:")
    for i, v in enumerate(ventas):
        if v > 20:
            print(f"Día {i + 1}: {v} unidades")


# PROGRAMA PRINCIPAL
def main():
    n = int(input("Ingrese la cantidad de días del mes (n): "))
    ventas = []

    # Leer ventas día por día
    for i in range(n):
        valor = int(input(f"Ingrese las ventas del día {i + 1}: "))
        ventas.append(valor)

    # Cálculos principales
    total = calcular_total(ventas)
    mayor, dia_mayor = calcular_mayor(ventas)
    menor, dia_menor = calcular_menor(ventas)
    promedio = calcular_promedio(total, n)

    # Resultados
    print("\n--- RESULTADOS DEL ANÁLISIS ---")
    print(f"Total vendido en el mes: {total}")
    print(f"Día con mayor venta: Día {dia_mayor} con {mayor} unidades")
    print(f"Día con menor venta: Día {dia_menor} con {menor} unidades")
    print(f"Promedio diario: {promedio:.2f}")

    mostrar_mayores_20(ventas)

    print("\nFin del programa.")


# Llamar al programa principal
if __name__ == "__main__":
    main()
