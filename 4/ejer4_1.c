#include <stdio.h>
#include <math.h>

// Factorial de un número
void factorial(int n, int *f) {
    *f = 1;
    for (int i = 1; i <= n; i++) {
        *f *= i;
    }
}

// Cálculo de Pi usando la fórmula de Ramanujan (iterativa)
void calcular_pi_iterativo(int iteraciones, double *pi) {
    int fact_4k, fact_k;
    double suma = 0.0;
    double constante = (2 * sqrt(2)) / 9801;

    for (int k = 0; k < iteraciones; k++) {
        factorial(4 * k, &fact_4k);  // Factorial de 4k
        factorial(k, &fact_k);       // Factorial de k

        double numerador = fact_4k * (1103 + 26390 * k);
        double denominador = pow(fact_k, 4) * pow(396, 4 * k);
        suma += numerador / denominador;
    }

    *pi = 1 / (constante * suma);
}

// Función recursiva para calcular la serie de Ramanujan
void calcular_pi_ramanujan_recursivo(int *k, int iteraciones, double *suma) {
    if (*k == iteraciones) return;  // Condición base de recursión

    int fact_4k, fact_k;
    factorial(4 * (*k), &fact_4k);  // Factorial de 4k
    factorial(*k, &fact_k);         // Factorial de k

    double numerador = fact_4k * (1103 + 26390 * (*k));
    double denominador = pow(fact_k, 4) * pow(396, 4 * (*k));
    *suma += numerador / denominador;

    (*k)++;  // Incrementar k para la siguiente llamada recursiva
    calcular_pi_ramanujan_recursivo(k, iteraciones, suma);
}

int main() {
    printf("EJERCICIO 4_1 ---> CALCULO DE PI USANDO LA FORMULA DE RAMANUJAN\nCON EL USO DE PUNTEROS (ITERATIVA Y RECURSIVA)\n");

    int iteraciones;
    double pi;

    // Entrada del número de iteraciones
    printf("Introduzca el numero de Iteraciones: ");
    scanf("%d", &iteraciones);

    // Llamada a la función iterativa
    calcular_pi_iterativo(iteraciones, &pi);
    printf("Pi calculado iterativamente: %.15f\n", pi);

    // Llamada a la función recursiva
    int k = 0;
    double suma = 0.0;

    calcular_pi_ramanujan_recursivo(&k, iteraciones, &suma);
    double constante = (2 * sqrt(2)) / 9801;
    pi = 1 / (constante * suma);

    printf("Pi calculado recursivamente: %.15f\n", pi);

    return 0;
}

/*#include <stdio.h>
#include <math.h>

// Factorial de un número
void factorial(int n, int *f) {
    *f = 1;
    for (int i = 1; i <= n; i++) {
        *f *= i;
    }
}

// Cálculo de Pi usando la fórmula de Ramanujan (iterativa)
void calcular_pi_iterativo(int iteraciones, double *pi) {
    int fact_4k, fact_k;
    double suma = 0.0;
    double constante = (2 * sqrt(2)) / 9801;
    for (int k = 0; k < iteraciones; k++) {
        factorial(4 * k, &fact_4k);
        factorial(k, &fact_k);

        double numerador = fact_4k * (1103 + 26390 * k);
        double denominador = pow(fact_k, 4) * pow(396, 4 * k);
        suma += numerador / denominador;
    }

    *pi = 1 / (constante * suma);
}
// Función recursiva para calcular la serie de Ramanujan
void calcular_pi_ramanujan_recursivo(int *k, int iteraciones, double *suma) {
    if (*k == iteraciones) return;
    int fact_4k, fact_k;
    factorial(4 * *k, &fact_4k);
    factorial(*k, &fact_k);
    double numerador = fact_4k * (1103 + 26390 * (*k));
    double denominador = pow(fact_k, 4) * pow(396, 4 * (*k));
    *suma += numerador / denominador;

    (*k)++;
    calcular_pi_ramanujan_recursivo(k, iteraciones, suma);
}

void main() {
    printf("EJERCICIO 4_1 ---> CALCULO DE PI USANDO LA FORMULA DE RAMANJAN\nCON EL USO DE PUNTEROS (ITERATIVA)\n");
    int iteraciones;
    double pi;
    printf("Introduzca el numero de Iteraciones: ");
    scanf("%d", &iteraciones);

    calcular_pi_iterativo(iteraciones, &pi);
    printf("Pi calculado iterativamente: %.15f\n", pi);

    //recursivo
    int k = 0;
    double suma = 0.0;
    pi = 0.0;
    calcular_pi_ramanujan_recursivo(&k, iteraciones, &suma);
    double constante = (2 * sqrt(2)) / 9801;
    pi = 1 / (constante * suma);

    printf("Pi calculado recursivamente: %.15f\n", pi);
}*/

/*
#include <stdio.h>

void calcular_pi_recursivo(int *i, int *iteraciones, double *pi) {
    if (*i == *iteraciones) return;
    *pi += ((*i % 2 == 0 ? 1.0 : -1.0) / (2 * (*i) + 1));
    (*i)++;
    calcular_pi_recursivo(i, iteraciones, pi);
}

int main() {
    int iteraciones = 100000;
    int i = 0;
    double pi = 0.0;

    calcular_pi_recursivo(&i, &iteraciones, &pi);
    pi *= 4;
    printf("Pi calculado recursivamente: %.15f\n", pi);

    return 0;
}
*/
