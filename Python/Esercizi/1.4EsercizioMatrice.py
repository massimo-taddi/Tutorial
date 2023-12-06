#una slot machine
#con 6 valori in colonna
#e 6 valori in orizzontale 
#ogni spin ha un prezzo 
#hai un credito di default predefinito
#con 3 valori uguali o multipli in orizzontale o in diagonale succede qualcosa
#anche al contrario 

import random as random
import numpy as np



#devo creare un vettore di 36 numeri randomici e inserirli nella matrice 

costoSpin=20
soldiContanti=100
saldo=0
entra=True
matrice_np=np.array([
                    [1,2,3,4,5,6],
                    [7,8,9,10,11,12],
                    [13,14,15,16,17,18],
                    [19,20,21,22,23,24],
                    [25,26,27,28,29,30],
                    [31,32,33,34,35,36]
                ])
#devo creare i controlli
def Paga():
    global costoSpin
    global soldiContanti
    if soldiContanti-costoSpin>0 or soldiContanti-costoSpin==0:
        return True
    else :
        return False
def JackPotVerticalePari():
    global matrice_np
    indiceVerticale=0
    indiceOrizzontale=0
    for numero in range(0,24,1):
        if(matrice_np[indiceVerticale,indiceOrizzontale] %2==0 and matrice_np[indiceVerticale+1,indiceOrizzontale]%2==0 and matrice_np[indiceVerticale+2,indiceOrizzontale] %2==0 ):
            return True
        else:
            indiceOrizzontale+=1
            if indiceOrizzontale>5:
                indiceVerticale+=1
                indiceOrizzontale=0   
    
def JackPotVerticaleDispari():
    global matrice_np
    indiceVerticale=0
    indiceOrizzontale=0
    for numero in range(0,24,1):
        if(matrice_np[indiceVerticale,indiceOrizzontale] %2==1 and matrice_np[indiceVerticale+1,indiceOrizzontale]%2==1 and matrice_np[indiceVerticale+2,indiceOrizzontale] %2==1 ):
            return True
        else:
            indiceOrizzontale+=1
            if indiceOrizzontale>5:
                indiceVerticale+=1
                indiceOrizzontale=0
def JackPotOrizzontalePari():
    global matrice_np
    indiceOrizzontale=0
    indiceVerticale=0
    for numero in range(0,24,1):
        if (matrice_np[indiceVerticale,indiceOrizzontale]%2==0 and matrice_np[indiceVerticale,indiceOrizzontale+1]%2==0 and matrice_np[indiceVerticale,indiceOrizzontale+2]%2==0):
            return True
        else:
            indiceOrizzontale+=1
            if indiceOrizzontale>3:
                indiceVerticale+=1
                indiceOrizzontale=0
    pass
def JackPotOrizzontaleDispari():
    global matrice_np
    indiceOrizzontale=0
    indiceVerticale=0
    for numero in range(0,24,1):
        if (matrice_np[indiceVerticale,indiceOrizzontale]%2==1 and matrice_np[indiceVerticale,indiceOrizzontale+1]%2==1 and matrice_np[indiceVerticale,indiceOrizzontale+2]%2==1):
            return True
        else:
            indiceOrizzontale+=1
            if indiceOrizzontale>3:
                indiceVerticale+=1
                indiceOrizzontale=0
def JackPotDiagonalePari():
    global matrice_np
    indiceOrizzontale=0
    indiceVerticale=0
    for numero in range(0,16,1):
        if(matrice_np[indiceVerticale,indiceOrizzontale]%2==0 and matrice_np[indiceVerticale+1,indiceOrizzontale+1]%2==0 and matrice_np[indiceVerticale+2,indiceOrizzontale+2]%2==0 ):
            return True
        else:
            indiceOrizzontale+=1
            if indiceOrizzontale>3:
                indiceOrizzontale=0
                indiceVerticale+=1
    
def JackPotDiagonaleDispari():
    global matrice_np
    indiceOrizzontale=0
    indiceVerticale=0
    for numero in range(0,16,1):
        if(matrice_np[indiceVerticale,indiceOrizzontale]%2==1 and matrice_np[indiceVerticale+1,indiceOrizzontale+1]%2==1 and matrice_np[indiceVerticale+2,indiceOrizzontale+2]%2==1 ):
            return True
        else:
            indiceOrizzontale+=1
            if indiceOrizzontale>3:
                indiceOrizzontale=0
                indiceVerticale+=1
    
#questo codice crea una nuova matrice al lancio/esecuzione con valori randomici 

risposta=str(input("ehy ciao hai soldi per giocare? ogni spin sono 20 euro si/no"))
if risposta.lower()=="si":
    
    while (entra==True):
        print("il tuo saldo attuale è "+str(saldo))
        soldiContanti-=costoSpin   
        indiceVerticale=0
        indiceOrizzontale=0

        for number in range(0,36,1):
            
            valoreRandomico=random.randint(0,9)
            matrice_np[indiceVerticale,indiceOrizzontale]=valoreRandomico
            indiceOrizzontale+=1
            if indiceOrizzontale % 6==0:
                indiceOrizzontale=0
                indiceVerticale+=1
        print(matrice_np)
        if JackPotDiagonaleDispari():
            saldo+=5
            print("JackPotDiagonaleDispari")
            
        if JackPotDiagonalePari():
            saldo+=2
            print("JackPotDiagonalePari")
            
        if JackPotOrizzontaleDispari():
            saldo+=3
            print("JackPotOrizzontaleDispari")
            
        if JackPotOrizzontalePari():
            saldo+=1
            print("JackPotOrizzontalePari")
            
        if JackPotVerticaleDispari():
            saldo+=9
            print("JackPotVerticaleDispari")
            
        if JackPotVerticalePari():
            saldo+=8
            print("JackPotVerticalePari")
        print("il tuo saldo è " + str(saldo))
        print("soldi contanti" + str(soldiContanti))  
        risposta=str(input("Vuoi ritirare il tuo saldo?"))
        if risposta.lower()=="si":
            soldiContanti+=saldo
            saldo=0

        risposta=str(input("vuoi continuare  giocare?"))
        if risposta.lower()=="si":
            Paga()
            if Paga()==False:
                print("non hai abbastanza contanti ciao")
                break
            continue           
        else:
            print("è stato un piacere torna presto")
            break
        
else:
    print("ciaoo")










