string = input("Digite uma frase.\n   -> ")
branco = 0

for char in string:
    if char == " ":
        branco += 1

print(branco)