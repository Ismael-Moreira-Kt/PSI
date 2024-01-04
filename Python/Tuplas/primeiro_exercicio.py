alunos = (
    "Sophia Martinez",
    "Liam Johnson",
    "Isabella Brown",
    "Noah Davis",
    "Emma Wilson",
    "Oliver Garcia",
    "Ava Lopez",
    "Elijah Taylor",
    "Mia Rodriguez",
    "James Anderson",
    "Amelia Hernandez",
    "William Lee",
    "Harper Moore",
    "Alexander Perez",
    "Charlotte Martin"
)

print(alunos[:3])
print(alunos[-4:])
print(sorted(alunos))
numero = int(input("Digite o número do aluno que quer verificar: "))
print(alunos[numero-1])