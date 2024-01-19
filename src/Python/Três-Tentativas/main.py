import random


numeroAleatorio = random.randint(1,10)
tentativas = 0
acertou = False


while (not acertou) and (tentativas < 3):
    tentativa = int(input("Adivinhe um número entre 1 e 10: "))


    if tentativa == numeroAleatorio:
        print("Parabéns, você acertou!")
        acertou = True
    else: 
        print("Ops! Parece que você errou.")
        tentativas += 1


if not acertou:
    print("Acabaram as tentativas. O número era {}" .format(numeroAleatorio))