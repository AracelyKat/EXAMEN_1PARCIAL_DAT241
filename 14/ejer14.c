#include <mpi.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(int argc, char *argv[])
{
    
    printf("EJERCICIO 14 ---> MPI utilizando MPI_Send y MPI_Recv multiplique dos matricesS\n");
    int id_proceso, total_procesos;
    
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &id_proceso);
    MPI_Comm_size(MPI_COMM_WORLD, &total_procesos);

    int filas_matA = 3,cols_matA = 2,filas_matB = 2,cols_matB = 3;

    srand(time(NULL));

    if(id_proceso == 0) {
        int matrizA[filas_matA][cols_matA];
        printf("Proceso %d: Generando Matriz A\n", id_proceso);

        for (int i = 0; i < filas_matA; i++) {
            for (int j = 0; j < cols_matA; j++) {
                matrizA[i][j] = rand() % 10;
                printf("%d ", matrizA[i][j]);
            }
            printf("\n");
        }

        MPI_Send(&matrizA, filas_matA * cols_matA, MPI_INT, 2, 0, MPI_COMM_WORLD);
    }

    if(id_proceso == 1) {
        int matrizB[filas_matB][cols_matB];
        printf("Proceso %d: Generando Matriz B\n", id_proceso);

        for (int i = 0; i < filas_matB; i++) {
            for (int j = 0; j < cols_matB; j++) {
                matrizB[i][j] = rand() % 10;
                printf("%d ", matrizB[i][j]);
            }
            printf("\n");
        }

        MPI_Send(&matrizB, filas_matB * cols_matB, MPI_INT, 2, 0, MPI_COMM_WORLD);
    }

    if(id_proceso == 2) {
        int matrizResultado[filas_matA][cols_matB];
        int matrizRecibidaA[filas_matA][cols_matA];
        int matrizRecibidaB[filas_matB][cols_matB];

        MPI_Recv(&matrizRecibidaA, filas_matA * cols_matA, MPI_INT, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
        MPI_Recv(&matrizRecibidaB, filas_matB * cols_matB, MPI_INT, 1, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);

        printf("Proceso %d: Matriz Resultado\n", id_proceso);

        for (int i = 0; i < filas_matA; i++) {
            for (int j = 0; j < cols_matB; j++) {
                int acumulador = 0;
                for (int k = 0; k < cols_matA; k++) {
                    acumulador += matrizRecibidaA[i][k] * matrizRecibidaB[k][j];
                }
                matrizResultado[i][j] = acumulador;
                printf("%d ", matrizResultado[i][j]);
            }
            printf("\n");
        }
    }

    MPI_Finalize();
    return 0;
}
