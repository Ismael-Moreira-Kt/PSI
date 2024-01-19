subsidioAlimentacao = 5.2


salarioBruto = float(input("Qual é o salário bruto do funcionário?\n   -> "))
diasTrabalhados = int(input("Quantos dias o funcionário trabalhou?\n   -> "))


irs = salarioBruto * .2
impostoSelo = salarioBruto *.015
descontoSs = salarioBruto * .15
seguroSaude = salarioBruto * .075
subsidioAlimentacaoPago = diasTrabalhados * subsidioAlimentacao


salarioLiquido = salarioBruto - (irs + impostoSelo + descontoSs + seguroSaude) + subsidioAlimentacaoPago


print("\n\n\n\tDe acordo com o Salário Bruto apresentado ({}) e pelos {} dias de trabalho, os pagamentos a fazer são:\n\tIRS: {}\n\tImposto de Selo: {}\n\tDesconto para a Segurança Social: {}\n\tSeguro de Saúde: {}\n\tSubsidio de Alimentação: {}\n\t\tSalário Liquido: {}" .format(salarioBruto, diasTrabalhados,irs,impostoSelo, descontoSs,seguroSaude,subsidioAlimentacaoPago, salarioLiquido))