string = input("Digite um número binário.\n   -> ")
n = 0

for char in string:
    if char == "1":
        n += 1

print(n)