import math

def area_coroa(raio, segundoRaio):
    if raio > segundoRaio:
        return ValueError
    else:
        area = (math.pi * math.pow(segundoRaio,2)) - (math.pi * math.pow(raio,2)) 
        return area

raio = float(input("Digite o valor do primeiro raio: "))
segundoRaio = float(input("Digite o valor do segundo raio: "))
print(area_coroa(raio, segundoRaio))