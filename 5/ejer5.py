import multiprocessing as mp

def calcular_pi(start, end):
    pi = 0.0
    for i in range(start, end):
        if(i%2==0):
            pi+=(1.0) / (2 * i + 1)
        else:
            pi+=(-1.0) / (2 * i + 1)
    return pi

def calcular_pi_multiprocessing(iteraciones, procesadores):
    pool = mp.Pool(processes=procesadores)
    c = iteraciones // procesadores

    # Dividir las iteraciones en partes iguales para cada proceso
    d = [(i * c, (i + 1) * c) for i in range(procesadores)]
    resultados = pool.starmap(calcular_pi, d)
    pi = sum(resultados) * 4
    return pi

if __name__ == '__main__':
    iteraciones = 1000000
    procesadores = 3
    pi = calcular_pi_multiprocessing(iteraciones, procesadores)
    print("EJERCICIO 5 ---> CALCULO DE PI CON MULTIPROCESING Y 3 PROCESADORES")
    print(f"Valor de Pi : {pi:.15f}\n Calculado con {iteraciones} iteraciones y {procesadores} procesadores.")
