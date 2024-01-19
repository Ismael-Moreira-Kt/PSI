string = input("Digite o seu nome.\n   -> ")
idade = int(input("Digite a sua idade.\n   -> "))
genero = input("Digite o seu género [H/M].\n   -> ")


if genero.upper() == 'M' and idade < 25:
    print("{} ACEITA!" .format(string))
else:
    print("NÃO ACEITA!") 