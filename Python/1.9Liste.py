#liste in pyton

my_List=[0,1,2,3,4,5,6,7,8,9,10]
type(my_List)

#list slicing permette di creare una lista con parte

my_List[1:5] #decidiamo di selezionare i dati da indice 1 a indice 5

#con cicli for e while

#esempio che legge la lista

for el in my_List:
    print(el)

print("fine esempio semplice")


#esempio più complicato


def match(lista):
    
    listaProva=[5,10,2,99,88,77]

    for el in lista:
        for el1 in listaProva:
             if (el1==el):
                 print("MATCH sono uguali " + str(el1) + " " + str(el))
    
print(match(my_List))    

#per aggiungere ad una lista si aggiunge un singolo
#elemento con .append

#più elementi 
# con extend

#nomedellalista.index(valoredentrolalista)
#printa l'indice in cui si trova
#remove
#.pop() riumove l'ultimo elemento di una lista
#.Remove(valore) riumove il valore specificato
#del lista[indice] rimuove il valore a indice specificato