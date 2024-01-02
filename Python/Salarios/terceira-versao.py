subsidioAlimentacao = 5.2


numeroFuncionarios = int(input("Quantos funcionários vão ser registados?\n   -> "))

for i in range(numeroFuncionarios):
    i += 1


    salarioBruto = float(input("Qual é o salário bruto do funcionário?\n   -> "))
    diasTrabalhados = int(input("Quantos dias o funcionário trabalhou?\n   -> "))


    if salarioBruto < 700:
        irs = 0
        descontoSs = 0
    elif (salarioBruto >= 700) and (salarioBruto < 1500):
        irs = salarioBruto * .1
        descontoSs = salarioBruto * .05
    elif (salarioBruto >= 1500) and (salarioBruto < 2500):
        irs = salarioBruto * .2
        descontoSs = salarioBruto * .1
    elif (salarioBruto >= 2500) and (salarioBruto < 5000):    
        irs = salarioBruto * .33
        descontoSs = salarioBruto * .15
    else:
        irs = salarioBruto * .45
        descontoSs = salarioBruto * .2



    impostoSelo = salarioBruto *.015
    seguroSaude = salarioBruto * .075
    subsidioAlimentacaoPago = diasTrabalhados * subsidioAlimentacao


    salarioLiquido = salarioBruto - (irs + impostoSelo + descontoSs + seguroSaude) + subsidioAlimentacaoPago


    print("\n\n\n\tDe acordo com o Salário Bruto apresentado ({}) e pelos {} dias de trabalho, os pagamentos a fazer são:\n\tIRS: {}\n\tImposto de Selo: {}\n\tDesconto para a Segurança Social: {}\n\tSeguro de Saúde: {}\n\tSubsidio de Alimentação: {}\n\t\tSalário Liquido: {}" .format(salarioBruto, diasTrabalhados,irs,impostoSelo, descontoSs,seguroSaude,subsidioAlimentacaoPago, salarioLiquido))