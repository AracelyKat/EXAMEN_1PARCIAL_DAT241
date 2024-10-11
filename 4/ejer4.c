#include <stdio.h>

void calcular_pi_iterativo(int iteraciones, double *pi) {
    //*pi = 0.0;
    for (int i = 0; i < iteraciones; i++) {
        if(i%2==0){
            *pi+=(1.0) / (2 * i + 1);
        }else{
            *pi+=(-1.0) / (2 * i + 1);
        }
    }
    *pi *= 4;
}

void calcular_pi_recursivo(int *i, int iteraciones, double *pi) {
    if (*i == iteraciones) return;
    *pi += ((*i % 2 == 0 ? 1.0 : -1.0) / (2 * (*i) + 1));
    (*i)++;
    calcular_pi_recursivo(i, iteraciones, pi);
}

void main() {
    printf("EJERCICIO 4 ---> CALCULO DE PI USANDO LA FORMULA DE LEIBNIZ\nCON EL USO DE PUNTEROS (ITERATIVA)\n");
    int iteraciones, i=0;
    double pi_i, pi_r = 0.0;
    printf("Para una mejor precision usar un numero aprox. a 10000\n");
    printf("Introduzca el numero de Iteraciones: ");
    scanf("%d", &iteraciones);
    //iteraciones = 1000000000;
    calcular_pi_iterativo(iteraciones, &pi_i);
    printf("Pi calculado iterativamente: %.15f\n", pi_i);
    
    calcular_pi_recursivo(&i, iteraciones, &pi_r);
    pi_r *= 4;
    printf("Pi calculado recursivamente: %.15f\n", pi_r);
}
