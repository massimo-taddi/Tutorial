#variabili globali e locali
#variabili locali sono variabili inserite in un contesto
#come in una fuznione nascono vivono e muoiono nella funzione
#le variabili globali generalmente sono le variabili
#scritte a inizio pagina che vengono create e utilizzate
#per tutto il progetto.
#se vogliamo utilizzare una variabile globale
#all'interno di una funzione e usarla nel "locale"
#dobbiamo definirla con il nome "global"
x=10
def esempio():
    global x
    risultato=x+2
    return risultato
print(esempio())