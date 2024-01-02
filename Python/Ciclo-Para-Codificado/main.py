a = 0
b = 0
c = 0


contador = int(input("Quantos cálculos deseja fazer?\n   -> "))


for i in range(contador):

    while a == 0:
        a = float(input("Digite o primeiro valor: "))
    
    b = float(input("Digite o segundo valor: "))


    while True:
        print("Qual é o tipo de cálculo que deseja efetuar?")
        print("+ Para soma.")
        print("- Para subtração.")
        print("* Para multiplicação.")
        print("/ Para divisão.")
        calculo = input()


        if calculo == '+':
            c = a + b
            break

        elif calculo == '-':
            c = a - b
            break

        elif calculo == '*':
            c = a * b
            break

        elif calculo == '/':
            c = a / b
            break

        else:
            print("Opção inválida!")
    

    print("O resultado é {}" .format(c))


    while True:
        prosseguir = input("Deseja prosseguir os cálculos com esse resultado? [S/N]\n   -> ")

        if prosseguir.lower() == 's':
            a = c
            break

        elif prosseguir.lower() == 'n':
            a = 0
            break

        else:
            print("Opção inválida!")