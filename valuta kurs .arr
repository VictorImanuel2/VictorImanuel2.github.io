use context starter2024
#Oppgave A 
#funksjon for å gjøre om nok til eur 
fun eur():
  doc: "Gitt beløp i nok, beregner eur"
  NOK = 50 #valuta av nok som skal være "input"
  EURkurs = 0.085 
  EUR = NOK * EURkurs
  print(EUR)
where:
  eur() is 4.25
end 

#oppgave b 
#lager en funksjon for å gjøre om NOK til USD 
fun usd():
  doc: "Gitt beløp i nok, beregner verdi i USD"
  NOK = 50 #valuta av nok som skal være "input"
  USDkurs = 0.094
  USD = NOK * USDkurs 
  print(USD)
where: 
  usd() is 4.7
end

#Oppgave c
#lager en funksjon som gir ut USD eller EUR basert på det som er input

fun valuta_valg(x): #viser usd eller eur etter det som blir angit i funksjonen 
  doc: "Gitt beløp i nok, beregner verdi i USD eller EUR, avhengig av hvilken x-verdi bruker velger"
  if x == 0:
    eur() #funksjonen for NOK til EUR hvis x er 0 
  else if x == 1:
    usd() #funksjonen for nok til usd hvis x er 1 
  end
where: 
  valuta_valg(1) is 4.7
  valuta_valg(0) is 4.25
end

valuta_valg(1) #kaller ut funksjonen som velger valuta og vil utgi en verdi av valgt valuta



