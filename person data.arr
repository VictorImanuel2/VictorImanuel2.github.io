use context starter2024
# Lag en funksjon, som tar data i Strukturerte data 1, som INPUT, og returnerer navn og fødselsdato for alle personer, som er yngre enn 80 eller 80 år, og eldre enn 30 eller 30 år, som OUTPUT.

include shared-gdrive("dcic-2021", "1wyQZj_L0qqV9Ekgr9au6RX2iqt2Ga8Ep")
# tar med google drive funksjon

include gdrive-sheets
include data-source

ssid = "1RYN0i4Zx_UETVuYacgaGfnFcv4l9zd9toQTTdkQkj7g"
tabell-strukturerte_data = load-table: id, first-name, last-name, email, gender, ip-adress, age
source: load-spreadsheet(ssid).sheet-by-name("o1-oppg3", true)    
end


# oppgave a 
# viser navn til de som er yngre enn 80 eller 80, og eldre enn 30 og 30
# lager en liste for de kolonnene som oppgave a skal inneholde 
List_age = [list: "age", "first-name", "last-name"]


fun filteralder(): 
  doc: "filtrerer ut alle de som ikke er innenfor aldersgruppen til oppgaven"
  filterusers = sieve tabell-strukturerte_data using age:
    (age >= 30) and (age <= 80) 
  end
  test1 = filterusers.select-columns(List_age)
  test1
where: 
  filteralder() is table: age, first-name, last-name
    row: 31, "Veda", "Seiller"
    row: 65, "Adham", "Wynch"
    row: 45, "Benn", "Drawmer"
    row: 68, "Myrtia", "Eary"
    row: 80, "Veronika", "Berget"
    row: 51, "Rivi", "Locke"
  end
end


# oppgave b  Lag en funksjon, som tar data i Strukturerte data 1, som INPUT, og returnerer fullt navn og e-postadressen til den eldste eller den yngste personen (brukeren av din funksjon skal kunne velge om den ønsker data om den yngste eller den eldste personen

List_email = [list: "first-name", "last-name", "email"]  
fun oppgb(x): 
  doc: "viser navn og mail til eldste eller yngste person, utfra hvilken x variabel bruker velger"
  if x == "oldest":
    oldest_first = order tabell-strukturerte_data: 
    age descending
  end
  oldest-mail = oldest_first.select-columns(List_email)
  oldest_user = oldest-mail.row-n(0)
  oldest_user
  else if x == "youngest":
    youngest_first = order tabell-strukturerte_data: 
      age ascending 
  end
    youngest-mail = youngest_first.select-columns(List_email)
    youngest_user = youngest-mail.row-n(0)
    youngest_user
  end
where: oppgb("oldest") is-not 49
end


fun oppgc():
  doc: "enkel funksjon som returnerer gjennomsnittsalder til de i tabellen"
  mean(tabell-strukturerte_data, "age") # mean er en funksjon som lar deg regne gjennomsnitt, i dette tilfelle regner vi gjennomsnittet i kolonnen "age"
where: 
  mean(tabell-strukturerte_data, "age") is 55.9
end


  


fun visualize-age(t :: Table):
  doc: "Lager en bar-chart, med valgte kolonner, og printer ut en bar-chart"
  desired-colnames = [list: "age", "first-name", "last-name"]
  relevant-table = select-columns(t, desired-colnames)
  full-name-table = build-column(relevant-table, "full-name", lam(r): r["first-name"] + " " + r["last-name"] end)
  bar-chart(full-name-table, "full-name", "age")
end 