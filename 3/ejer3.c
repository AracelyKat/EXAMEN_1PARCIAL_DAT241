#include <stdio.h>

void suma(int a, int b, int *c){
    *c = a+b;
}

void resta(int a, int b, int *c) {
    *c = 0;
    *c = a-b;
}

void multiplicacion(int a, int b, int *c) {
    *c = 0;
    *c = a*b;
}

void multiP(int a, int b, int *c){
    int i;
    *c = 0;
    for (i=0; i<b; i++){
        suma(a, *c, c);
    }
}

void division(int a, int b, float *d) {
    if (b != 0)
        *d = a/b;
    else {
        printf("Error: No se puede dividir entre cero...\n");
        *d = 0;
    }
}

void main() {
    int a, b, c;
    float d;
    printf("EJERCICIO 3 ---> OPERACIONES BASICAS CON EL USO DE PUNTEROS\n");
    printf("Introduzca a: ");
    scanf("%d", &a);
    printf("Introduzca b: ");
    scanf("%d", &b);

    //&: dato que cambiara de valor
    suma(a, b, &c);
    printf("Suma: %d+%d=%d\n", a, b, c);
    resta(a, b, &c);
    printf("Resta: %d-%d=%d\n", a, b, c);
    multiplicacion(a, b, &c);
    printf("Multiplicacion: %d*%d=%d\n", a, b, c);
    multiP(a, b, &c);
    printf("Multiplicacion en base a sumas: %d*%d=%d\n", a, b, c);
    division(a, b, &d);
    printf("Division: %d/%d=%.2f\n", a, b, d);
}
