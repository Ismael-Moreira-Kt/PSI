string = input("Digite um texto.\n   -> ")
stringDois = input("Digite um texto.\n   -> ")

if len(string) > len(stringDois):
    print("O primeiro texto é maior.")
elif len(string) < len(stringDois):
    print("O segundo texto é maior.")
else:
    print("Os textos são iguais.")