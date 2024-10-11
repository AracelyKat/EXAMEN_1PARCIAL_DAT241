#include <mpi.h>
#include <stdio.h>

int main(int argc, char *argv[]) {
    printf("EJERCICIO 13 ---> MPI \n");
    int id_proceso;
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &id_proceso);

    if (id_proceso == 0) {
        char nombres[4][10] = {"Milton", "Alejandro", "Villarroel", "Garvizu"};
        
        for (int i = 0; i < 4; i++) {
            if (i % 2 == 0) {
                MPI_Send(&nombres[i], 10, MPI_CHAR, 1, 0, MPI_COMM_WORLD);
            } else {
                MPI_Send(&nombres[i], 10, MPI_CHAR, 2, 0, MPI_COMM_WORLD);
            }
        }
    }

    if (id_proceso == 1) {
        char nombresPares[10];
        
        for (int i = 0; i < 2; i++) {
            MPI_Recv(&nombresPares, 10, MPI_CHAR, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            printf("Proceso %d: Nombre en posición par: %s\n", id_proceso, nombresPares);
        }
    }

    if (id_proceso == 2) {
        char nombresImpares[10];
        
        for (int j = 0; j < 2; j++) {
            MPI_Recv(&nombresImpares, 10, MPI_CHAR, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            printf("Proceso %d: Nombre en posición impar: %s\n", id_proceso, nombresImpares);
        }
    }

    MPI_Finalize();
    return 0;
}
