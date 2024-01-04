string = input("Digite um texto.\n   -> ")
novaString = ""

for char in string:
    if char != " ":
        novaString += chr(ord(char)+32)
    else:
        novaString += char
        
print(novaString)