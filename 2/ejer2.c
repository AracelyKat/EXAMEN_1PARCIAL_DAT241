#include <stdio.h>

int suma(int a, int b) {
    return a + b;
}

int resta(int a, int b) {
    return a - b;
}

int multiplicacion(int a, int b) {
    return a * b;
}

float division(int a, int b) {
    if (b != 0)
        return (float) a / b;
    else {
        printf("Error: No se puede dividir entre cero...\n");
        return 0;
    }
}

void main() {
    int a, b;
    printf("EJERCICIO 2 ---> OPERACIONES BASICAS SIN EL USO DE PUNTEROS\n");
    printf("Introduzca a: ");
    scanf("%d", &a);
    printf("Introduzca b: ");
    scanf("%d", &b);
    printf("Suma: %d+%d=%d\n", a, b, suma(a, b));
    printf("Resta: %d-%d=%d\n", a, b, resta(a, b));
    printf("Multiplicacion: %d*%d=%d\n", a, b, multiplicacion(a, b));
    printf("Division: %d/%d=%.2f\n", a, b, division(a, b));
}
