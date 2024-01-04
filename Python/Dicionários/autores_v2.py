def inserir_autor():
    tecnologia = input("De qual tecnologia vai introduzir o autor?\n   -> ")
    tecnologia = tecnologia.lower()
    autor = input("Introduza o nome do autor: ")
    autores[tecnologia] = autor

def apagar_autor():
    tecnologia = input("De qual tecnologia vai apagar o autor?\n   -> ")
    tecnologia = tecnologia.lower()
    autores.pop(tecnologia)

def modificar_autor():
    tecnologia = input("De qual tecnologia vai modificar o autor?\n   -> ")
    tecnologia = tecnologia.lower()
    autor = input("Introduza o nome do autor: ")
    autores[tecnologia] = autor

def verificar_tecnologia():
    tecnologia = input("Qual tecnologia vai verificar?\n   -> ")
    tecnologia = tecnologia.lower()
    if tecnologia in autores.keys():
        print("sim, existe")
    else:
        print("não, não existe")


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


print(autores)
inserir_autor()
print(autores)
modificar_autor()
print(autores)
apagar_autor()
print(autores)
verificar_tecnologia()