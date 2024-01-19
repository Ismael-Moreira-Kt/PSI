string = input("Digite um número binário.\n   -> ")
stringNova = ""

for i in range(len(string)):
    if string[i] == "0":
        stringNova += "1"
    else:
        stringNova += string[i]

print("   -> {}" .format(stringNova))