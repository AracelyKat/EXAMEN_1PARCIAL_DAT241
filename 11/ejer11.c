#include <mpi.h>
#include <stdio.h>

int main(int argc, char *argv[])
{
    printf("EJERCICIO 11 ---> MPI\n");
    int id_proceso;

    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &id_proceso);

    if (id_proceso == 0)
    {
        int vx[10];
        int vy[10];
        int vz[10];

        for (int i = 0; i < 10; i++)
        {
            vx[i] = i;
            vy[i] = 5;
        }

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                MPI_Send(&vx[i], 1, MPI_INT, 2, 0, MPI_COMM_WORLD);
                MPI_Send(&vy[i], 1, MPI_INT, 2, 1, MPI_COMM_WORLD);
                MPI_Recv(&vz[i], 1, MPI_INT, 2, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            }
            else
            {
                MPI_Send(&vx[i], 1, MPI_INT, 1, 0, MPI_COMM_WORLD);
                MPI_Send(&vy[i], 1, MPI_INT, 1, 1, MPI_COMM_WORLD);
                MPI_Recv(&vz[i], 1, MPI_INT, 1, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            }
        }

        printf("Proceso %d envió los vectores a los procesos 1 y 2:\n", id_proceso);
        printf("Vector X: ");
        for (int i = 0; i < 10; i++)
        {
            printf("%d ", vx[i]);
        }
        printf("\n");

        printf("Vector Y: ");
        for (int i = 0; i < 10; i++)
        {
            printf("%d ", vy[i]);
        }
        printf("\n");

        printf("Vector Resultado: ");
        for (int i = 0; i < 10; i++)
        {
            printf("%d ", vz[i]);
        }
        printf("\n");
    }
    else if (id_proceso == 1)
    {
        for (int i = 1; i < 10; i += 2)
        {
            int imparX, imparY;
            MPI_Recv(&imparX, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            MPI_Recv(&imparY, 1, MPI_INT, 0, 1, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            int sumaImpares = imparX + imparY;
            MPI_Send(&sumaImpares, 1, MPI_INT, 0, 0, MPI_COMM_WORLD);
        }
    }
    else if (id_proceso == 2)
    {
        for (int i = 0; i < 10; i += 2)
        {
            int parX, parY;
            MPI_Recv(&parX, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            MPI_Recv(&parY, 1, MPI_INT, 0, 1, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            int sumaPares = parX + parY;
            MPI_Send(&sumaPares, 1, MPI_INT, 0, 0, MPI_COMM_WORLD);
        }
    }

    MPI_Finalize();
    return 0;
}
