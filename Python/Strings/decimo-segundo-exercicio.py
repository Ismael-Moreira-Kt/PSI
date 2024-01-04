string = input("Digite o seu nome.\n   -> ")
vogais = ["a","e","i","o","u"]
novaString = ""

for i in range(len(string)):
    if string[i] not in vogais:
        novaString += string[i]

print(novaString)