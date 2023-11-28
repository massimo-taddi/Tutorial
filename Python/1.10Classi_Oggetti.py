#esempio classe con costruttore
class Persona():
    #costruttore
    #self da riferimento alla classe a quale istanza associare i dati in entrata +
    def __init__(self,nome,cognome) :
        self.nome=nome
        self.cognome=cognome
    def saluta(self):
        print("ciao sono " + self.nome)

Persona1=Persona(str(input("inserisci il nome della persona")),str(input("inserisci il cognome della persona")))

Persone=[]
Persone.append(Persona1)

answer=int(input("inserisci 1 per aggiungere alla lista"))
if answer==1:
    
    for el in Persone:
        print(el.nome)
        print(el.cognome)