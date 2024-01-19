def mostrar_linhas():
    linha = int(input("Qual linha quer ver?\n   -> "))
    print(sorted(vendas[linha], reverse=True))


def mostrar_vendas():
    for i in range(3):
        for j in range (4):
            print("Linha: {}.\nColuna: {}\nValor: {}" .format(i,j,vendas[i][j]))


def soma_vendas():
    soma = 0

    for i in range(3):
        for j in range (4):
            soma += vendas[i][j]
    return soma




vendas = [[0 for _ in range(4)] for _ in range(3)]

for i in range(3):
    for j in range (4):
        # O código utiliza dois loops para solicitar a entrada de dados para preencher a matriz.
        print("Linha: {}.\nColuna: {}" .format(i+1,j+1))
        vendas[i][j] = int(input("   -> "))


print(soma_vendas())
print(mostrar_vendas())
print(mostrar_linhas())