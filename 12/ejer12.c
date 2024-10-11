#include <stdio.h>
#include <omp.h>

void fibonacci(int n) {
    int a = 0, b = 1, c;

    printf("Fibonacci Serie: %d %d ", a, b);
    #pragma omp parallel shared(a, b) private(c) 
    {
        // Hacer que solo un hilo realice los cálculos uno por uno en orden
        #pragma omp for ordered
        for (int i = 2; i < n; i++) {
            #pragma omp ordered
            {
                c = a + b; 
                printf("%d ", c);
                a = b; 
                b = c;
            }
        }
    }
    printf("\n");
}

void main() {
    int n;
    printf("EJERCICIO 4 ---> SERIE FIBONACCI CON OMP\n");
    printf("Cantidad de terminos de la serie: ");
    scanf("%d", &n);
    if (n < 2) {
        printf("El número de términos debe ser al menos 2.\n");
    } else {
        fibonacci(n);
    }
}
