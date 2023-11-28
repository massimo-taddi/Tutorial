#le funzioni servono per riutilizzare codice

def say_my_name():
    nome=str(input("perfavore inserisci il tuo nome"))
    cognome=str(input("perfavore inserisci il tuo cognome"))
    print(nome + " " + cognome)


print(say_my_name())

#proviamo con una funzione con argomenti
valoreA=int(input("inserisci un valore"))
valoreB=int(input("inserisci il secondo valore"))
def addizione(a,b):
    risultato=a+b
    print("il risultato è " + str(risultato))

print(addizione(valoreA,valoreB))   
    
#funzione con argomenti non obbligatori 
#esempio con vendita di un laptop
#!!!Attenzione in phyton non si è  costretti a passare
#ogni argomento gli argomenti che non verranno passati
#al richiamo della funzione avranno l'assegnazione
#definita negli argomenti della funzione
#in questo caso se non viene passato valore ad antivirus
#esso avrà valore False

def laptop_nuovo(ram,cpu,antivirus=False):
    print("RAM: " + str(ram))
    print("CPU: " + str( cpu))
    if antivirus==True:
        print("ha anche un antivirus ")

ramProva=(int(input("inserisci la ram di un primo laptop")))
ramProva1=(int(input("inserisci la ram di un secondo laptop")))
cpuProva=(int(input("inserisci la cpu di un primo laptop")))
cpuProva1=(int(input("inserisci la cpu di un primo laptop")))

print(laptop_nuovo(ramProva,cpuProva))
print(laptop_nuovo(ramProva1,cpuProva1))




#Return per ritornare e rompere la funzione in un punto
#che decidiamo noi e nonetype invece significa che non ritorna
#nulla

def addizione(a,b):
    return a+b

risultato=addizione(3,5)
print(risultato)