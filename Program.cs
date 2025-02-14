using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Principal;
using System.Reflection;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace LabØvelse6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // oppgave 5.3
            // 4 forskjellige måter å legge til 1 på variabelen x
            // int x = 0;
            // int y = 0;  

            /*x++;
            x = x + 1;
            x = +1;
            ++x;

            Console.WriteLine(x);*/

            // oppgave 5.4


            //a
            /*int x = 13;
            int y = 16;
            int z = x++ + y;
            
           
            //b
            int count = 15;
            if (count > 10)
            {
                Console.WriteLine("count er større enn 10");
            }

            //c 
            int total = 100;
            total = total - --x; // trekker fra verdien av x i total variabelen 

           //d 
           double divisor = 4; // divisor = rest 
            double q = 10;

            q %= divisor; // resten blir 2 siden 10 / 4 får 2 i rest 

            Console.WriteLine(q);*/







            // oppgave 5.5 
            //int sum = 0;
            //int x = 1;
            //sum = sum + x


            /* while (x <= 10)
             {
                sum =+ x; // Den legger til verdien av x til sum i hver iterasjon av løkken.
                 x++;
             }
             Console.WriteLine("the sum is: " + sum);*/




            //oppgave 5.8


           /* int product = 5;
            int x = 5;
            int c = 5;


            product *= x++; // product = 5  * 5 + 1

            while (c <= 5)
            {
                product *= c;
                ++c;

            }
            Console.WriteLine(product);/*


            /*int gender = 5;

            if (gender == 1)
            {
                Console.WriteLine("Woman");
            }
            else // if i had the ; after else, the else statement would run idenpendently and infinitely 
            {
                Console.WriteLine("Man");*/
            



            /*int z = 5;
            int sum = 5;
            
            while (z >= 0) 
            {
                sum += z; //--- siden z skal være 5, så vil z alltid være større enn 0, derfor vil aldri løkken stoppe.
                          // // sum keeps increasing, but z is always 5
            }
            Console.WriteLine(sum); */// derfor vil ikke koden outputte noe, siden den vil aldri nå denne linjen 




            /* int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i + " ");
                i++;
            }

            Console.WriteLine("hei");
            */



            /* student student1 = new student();

             student1.setPoeng(59);





         }
         class student
         {
             private int poeng;


             public void setPoeng(int p)
             {
                 if (p>= 0 && p <= 100)
                 {
                     poeng = p;
                     Console.WriteLine("du består");
                 }
                 else
                 {
                     Console.WriteLine("ugyldig poeng verdi");
                 }


             }
         }*/


            //oppgave 

          /*  List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 10, 23, 25, 12 };
            int sum = 0;    

            foreach (int item in list) // går gjennom hver tall i listen

            {

                sum += item;  // plusser på hvert tall til summen 

            }
            Console.WriteLine(sum); // viser summen av en antall positive heltall 



            int numbers = 100;
            int sum2 = 0; 

            for (int i = 0;  i <= numbers; i++) // iterasjon for de første 100 positive tallene 
            {
                sum2 = sum2 + i; // summerer tallene sammen #1+2+3+4+5+....
            }
            Console.WriteLine("the sum of the first 100 positive integers is " + sum2);


            //oppgave 5.15

            int x1 = 1, total= 0;
            while (x1 <= 10)
            {
                total = total + x1; // problemet var at total ikke var initialisert 
                x1++;
            }
            Console.WriteLine("total is" + total);


            while (x <= 100)
            {
                total += x;
                ++x;
            }


            // int y = 1;
            /* while (y > 0) _ this code will result in infinite loop 
             {
                 Console.WriteLine(y);
                 ++y;

             }*/

           /* int z = 5;

            ++z;  // pre-inkrementasjon: z blir 6 før det brukes
            Console.WriteLine(z); // Output: 6

            z++;  // post-inkrementasjon: z brukes først, deretter blir z 7
            Console.WriteLine(z);/* // Output: 7*/
           //_____________________________________________________________________________//
            




            Hus hus = new Hus();


            Console.WriteLine("hva er adressen til huset");
            hus.Adresse = Console.ReadLine();
          
            hus.Byggår = 2025;

            Console.WriteLine("hvor mange etasjer har huset? ");
            hus.Bygghus(int.Parse(Console.ReadLine()), hus.Adresse); // 2 er antall etasjer 

            hus.KlarForSalg();


           
        }
    }
    class Hus
    {
        public int Rom {  get; set; }   
        public int Vegger { get; set; }
        public string Adresse { get; set; } = "";  
        public int AntallEtasjer { get; set; } //må ha mer eller lik 1 etasje 
        public bool Tak {  get; set; }  
        public int Byggår { get; set; } 

        
        public bool KlarForSalg() // lager betingler for om huset skal være klart for salg eller ikke
        {
            bool erKlar = true;

            if (Vegger < 4)
                erKlar = false;

            if (Rom < 5 )
                erKlar = false;

            if (AntallEtasjer < 1)
                erKlar = false;

            if (Tak == false)
                erKlar = false;

            if (Adresse == string.Empty) // hvis bruker ikke oppgir adresse 
                erKlar = false;

            if (Byggår == 0)
                erKlar = false;

            if (erKlar == false)
                Console.WriteLine("huset er ikke klar til å selges");
            else
            {
                Console.WriteLine("huset er klar til salg");
                erKlar = true;
                
            }
                


            return erKlar;


        }

        public void Bygghus(int etasjer, string adressa)  // vi skal kun la bruker velge adresse og etasjer
        {

           while (Vegger < 4)
            {
                Vegger++;
                Console.WriteLine($"vi har satt opp en vegg");
            }

            Console.WriteLine($"Huset har nå {Vegger} vegger");

            while (AntallEtasjer < etasjer)
            {
                AntallEtasjer++;
                Console.WriteLine("vi har satt opp en etsaje");
            }
            

           
            Console.WriteLine($"huset har {etasjer} etasjer");

            Adresse = adressa;
            Console.WriteLine("adressen til huset er " + adressa);

            Tak = true; 

            while (Rom  < 5)
            {
                Rom++;
                Console.WriteLine("legger til et til rom");
            }
            Console.WriteLine("huset har nå " + Rom + " rom");

            Console.WriteLine("huset ble bygd i " + Byggår);
        }

    }
}
// gjør koden ferdig senere
// man skal kunne bygge huset, også sjekke om det er til salgs 