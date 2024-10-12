# Definerer klassen Student
class Student:
    def __init__(self, navn, gruppeNr):
        self.navn = navn
        self.gruppeNr = gruppeNr

# Definerer klassen Gruppe
class Gruppe:
    def __init__(self, navn, gruppeNr):
        self.navn = navn
        self.gruppeNr = gruppeNr

# Oppretter student objekter
Victor = Student("Victor", 1)
Bob = Student("Bob", 1)
Finn = Student("Finn", 2)
Erik = Student("Erik", 2)
Else = Student("Else", 3)
Karl = Student("Karl", 3)

# Oppretter gruppe objekter
gr1 = Gruppe("Gruppe 1", 1)
gr2 = Gruppe("Gruppe 2", 2)
gr3 = Gruppe("Gruppe 3", 3)

# Definerer funksjonen som finner gruppen basert på studenten
def findGroup(student):
    if student.gruppeNr == 1:
        return gr1.navn
    elif student.gruppeNr == 2:
        return gr2.navn
    elif student.gruppeNr == 3:
        return gr3.navn

# Eksempler på bruk:
print(findGroup(Victor))  # Vil skrive ut "Gruppe 1"
print(findGroup(Finn))    # Vil skrive ut "Gruppe 2"
