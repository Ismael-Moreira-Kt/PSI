string = input("Digite o seu nome.\n   -> ")
letra = input("Digite uma letra para subsituir as vogais.\n   -> ")
vogais = ["a","e","i","o","u"]
novaString = ""
nVogais = 0


for i in range(len(string)):
    if string[i] in vogais:
        nVogais += 1
        novaString += letra
    else:
        novaString += string[i]

print(novaString)