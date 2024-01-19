import random 

tuplaNumerica = ()

for i in range (10):
    numero = random.randint(0,10)
    tuplaNumerica += (numero,)


print(tuplaNumerica)
print(max(tuplaNumerica))
print(min(tuplaNumerica))