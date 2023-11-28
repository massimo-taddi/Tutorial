
#esempio classe con costruttore

class Persona():
    #__init__ costruttore (sempreself,attributi)

    def __init__(self,nome,cognome) :
        self.nome=nome
        self.cognome=cognome
    def saluta(self):
        print("ciao sono " + self.nome)

#pass permette di non vedere l'errore che accadrebbe
#da parte code che dice "non viene implementato"
#è come un return per una funzione


#questo consente di richiamare il costruttore della
#classe padre 

class Insegnante(Persona):
    def __init__(self,nome,cognome,materia,anni):
     super().__init__(nome,cognome)
     #per aggiungere attributi esclusivi a classi figlio
     #ESTENDO il costruttore della classe figlio
     #con nuovi attributi SPECIFICI
     #della classe figlio
     self.materia=materia
     self.anni=anni
     #Persona().__init__(nome,cognome)
    def saluta(self):
        print("buongiorno sono " + self.nome + " " + self.cognome)
    #l'override in questo linguaggio è automatico non 
    #non è necessario scrivere override o renderlo
    #visibile se sappiamo che una classe figlio
    #estende una classe padre la classe figlio col
    #suo costruttore può sovrascrivere i dati della
    #classe padre 

    #the override you dont need to write it "override" the 
    #class that innherit the father class can change the value inside of it
  


persona1=Persona("Massimo","Taddi")
insegnante1=Insegnante("Marco","Columbro","Zoologia",44)

print(insegnante1.nome)
print(insegnante1.cognome)
print(insegnante1.anni)
print(insegnante1.materia)