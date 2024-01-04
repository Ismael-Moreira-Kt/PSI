autores = {
    "php":"Rasmus Lerdorf",
    "perl":"Larry Wall",
    "tcl":"John Ousterhout",
    "awk":"Brian Kernighan",
    "java":"James Gosling",
    "parrot":"Simon Cozens",
    "python":"GuidovanRossum",
    "xpto":"zxcv"
}


autores["git"] = "Linus Torvalds"
print(autores)
autores["python"] = "Guido van Rossum"
print(autores)
autores.pop("xpto")
print(autores)

if "c++" in autores.keys():
    print("sim, existe")
else:
    print("não, não existe")

print(autores)