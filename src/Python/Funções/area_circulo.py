import math

def area_circulo(raio):
    area = math.pow(raio, 2) * math.pi
    return area

raio = float(input("Digite o valor do raio: "))
print(area_circulo(raio))