def dia_mes(mes):
    meses31 = ["jan","mar","mai","jul","ago","out","dez"]
    meses30 = ["abr","jun","set","nov"]

    if mes in meses31:
        print("O mês tem 31 dias.")
    elif mes in meses30:
        print("O mês tem 30 dias.")
    else:
        print("O mês tem 28 dias.")

mesExtenso = input("Introduza o nome de um mês.\n   -> ")
mes = mesExtenso[:3]
dia_mes(mes)