import datetime


saida = 'r'


while True:
    if saida.lower() == 'r':
        altura = float(input("Altura da caixa: "))
        largura = float(input("Largura da caixa: "))
        comprimento = float(input("Comprimento da caixa: "))


        volume = altura * largura * comprimento


        if (altura >= 3) and (volume >= 50):
            print("A caixa passa pelo controlo de qualidade.")
        else:
            if (altura < 3) and (volume < 50):
                print("A caixa não possui a altura e volume necessários para passar pelo controlo de qualidade.")
            else:
                if altura < 3:
                    print("A caixa não possui a altura necessária para passar pelo controlo de qualidade.")
                else:
                    print("A caixa não possui o volume necessário para passar pelo controlo de qualidade.")
        

    saida = input("Você quer registar uma nova caixa ou abandonar o programa? [R/T]\n   -> ")


    if saida.lower() == 't':
        horario = datetime.datetime.now().strftime('%H:%M')

        print("O programa fechou ás {}" .format(horario))
        break