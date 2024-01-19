import math

def soma_quadrados(numero):
    somaQuadrados = 0

    for i in range(numero+1):
        somaQuadrados += math.pow(i,2)

    return somaQuadrados

numero = int(input("Digite um número inteiro.\n   -> "))
print(soma_quadrados(numero))