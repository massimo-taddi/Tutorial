#voglio creare un programma che mi consenta di fare
#-login base per accedere alla mia classe 
#-visualizzare il mio conto corrente
#-depositare
#-prelevare




#Dati
class Persona():
    def __init__(self,nome,cognome):
        self.nome=nome
        self.cognome=cognome

        
        

class Utente(Persona):
    def __init__(self, nome, cognome,nomeUtente, passWord,identificativo):
        super().__init__(nome, cognome)
        self.nomeUtente=nomeUtente
        self.passWord=passWord
        self.identificativo=identificativo
        

class ContoCorrente(Utente):
    def __init__(self,nome,cognome,nomeUtente,passWord,identificativo,saldo):
        super().__init__(nome,cognome,nomeUtente,passWord,identificativo)
        self.saldo=saldo
         

entra=True
listaPersone=[]
listaUtenti=[]
listaContiCorrenti=[]
identificativo=0
soldiContanti=500
entraMenuAzioni=True
logOut=False

#FUNZIONI 

#FUNZIONANO
def corrispondenza(nomeUtente,passWord):
        for el in listaUtenti:
            if el.nomeUtente==nomeUtente and el.passWord==passWord:
                return True
        else:
            return False   

def cerca(nomeUser,passWord):
    for el in listaUtenti:
        if el.nomeUtente==nomeUser and el.passWord==passWord:
            
            return el.identificativo 

    
    
def registrazione():
    global nome
    global cognome
    global identificativo
    nominativo=nome+ " " + cognome
    nuovoNomeUtente=str(input("inserire nuovo nome utente\n"))
    nuovaPassword=str(input("inserire nuova password\n"))
    nuovoUtente=Utente(nome,cognome,nuovoNomeUtente,nuovaPassword,identificativo)
    nuovoContoCorrente=ContoCorrente(nome,cognome,nuovoNomeUtente,nuovaPassword,identificativo,saldo=0)
    listaUtenti.append(nuovoUtente)
    listaPersone.append(nominativo)
    listaContiCorrenti.append(nuovoContoCorrente)
    identificativo=identificativo+1


       

def stampa(id):
    for el in listaContiCorrenti:
        if el.identificativo==id:
            print("il nome è "+el.nome)
            print("il cognome è " + el.cognome)
            print("l'identificativo è " + str(el.identificativo))
            print("il saldo è "+str(el.saldo))
   

def depositare(id):
     for el in listaContiCorrenti:
        if el.identificativo==id:
            deposito=int(input("scegliere quanto vuoi depositare puoi depositare massimo " + str(soldiContanti)))
            nuovoSaldo= el.saldo+deposito
            el.saldo=nuovoSaldo
            print("il tuo nuovo saldo è " + str(nuovoSaldo))

            

def prelevare(id):
     for el in listaContiCorrenti:
        if el.identificativo==id:
            print("il tuo saldo è " + str(el.saldo))
            prelievo=int(input("quanti soldi vuoi prelevare?\n"))
            nuovoSaldo=el.saldo-prelievo
            el.saldo=nuovoSaldo
            print("il tuo nuovo saldo è " + str(nuovoSaldo))
              
   

def aggiungiPersona(nome,cognome):
    listaPersone.append(Persona(nome,cognome))


#MENU

nome=str(input("inserire il tuo nome\n"))
cognome=str(input("inserire il tuo cognome\n"))
aggiungiPersona(nome,cognome)
while entra: 
    if logOut==True:
        break
    answer=str(input("sei già registrato? si/no\n"))
    if answer=="si":
        print("Effettuare il login\n")
        nomeUtente=str(input("inserire nome utente\n"))
        passWord=str(input("inserire password\n"))
        numeroDaPassare=cerca(nomeUtente,passWord)
        if corrispondenza(nomeUtente,passWord)==True:
            while entraMenuAzioni==True:
                action=int(input("-1 Visualizzare il proprio contoCorrente\n-2 per depositare\n3-per prelevare\n4-Uscire\n"))
                if action==1:
                    
                    stampa(numeroDaPassare)
                    
                if action==2:
                    depositare(numeroDaPassare)
                    
                if action==3:
                    prelevare(numeroDaPassare)
                    
                if action==4:
                    logOut=True
                    break   
        else:
            print("nessuna corrispondenza trovata")                                    
    else :
       
        answer=str(input("vuoi registrarti? si/no\n"))
        if answer=="si":
            registrazione()
            
            
        if answer=="no":
            break
            
        






