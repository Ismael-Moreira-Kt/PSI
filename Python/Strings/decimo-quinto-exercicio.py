string = input("Digite um texto.\n   -> ")
novaString = ""

for char in string:
    novaString += chr(ord(char)+1)
        
print(novaString)