def generar_fibonacci(n):
    A = [0] * n  # Crear una lista con N elementos inicializados en 0
    if n > 1:
        A[0] = 0
        A[1] = 1
        for i in range(2, n):
            A[i] = A[i-2] + A[i-1]
    elif n == 1:
        A[0] = 0
    return A

def mostrar_vector(A):
    print("[", end="")
    for i in range(len(A)):
        print(A[i], end="")
        if i != len(A) - 1:
            print(" | ", end="")
    print("]")

if __name__ == "__main__":
    print("EJERCICIO 6 ---> GENERAR LA SERIE DE FIBONACCI CON EL USO DE VECTORES")
    n = int(input("Tamaño del vector: "))
    A = generar_fibonacci(n)
    mostrar_vector(A)
