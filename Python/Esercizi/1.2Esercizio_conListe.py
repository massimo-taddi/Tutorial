entra=True
x=0
y=[]
def menu():
    global x
    x=int(input("inserire\n1-per stampare la lista\n2-per aggiungere un valore alla lista\n3-Rimuovere un valore dalla lista e specificare la sua posizione\n4-stampare solo una parte della lista \n5-cancellare l'ultimo dato inserito\n6-Chiudere e stampare la lista\n"))
    

def action1():
    global y
    for el in y:
        print(y)

def action2(addValue):
    global y
    y.append(addValue)

def action3(specifiedIndex):
    global y
    print("the deleted value is " + str(y[specifiedIndex]))
    del y[specifiedIndex]
    
    

def action4(inizioSelezione,fineSelezione):
    global y
    
    print(str(y[inizioSelezione:fineSelezione]))

def action5():
    global y
    value=y.pop()
    print("il valore cancellato è stato " + value)
while entra:
    menu()
    if x ==1:
        action1()
    elif x==2:
        action2(str(input("inserisci il valore da aggiungere alla lista ")))
    elif x==3:
        action3(int(input("inserisci l'indice del valore che vuoi rimuovere")))
    elif x==4:
        print("inserisci 2 valori ")
        x=int(input("inizio selezione"))
        y=int(input("inserisci l'ultimo campo del range selezionato "))
        action4(x,y)
    elif x==5:
        action5()
    elif x==6:
        
        action1()
        break

    continue

