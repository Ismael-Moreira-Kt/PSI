string = input("Digite o seu nome.\n   -> ")
stringInvertida = ""

for i in range(len(string) -1,-1,-1):
    stringInvertida += string[i]

print(stringInvertida)