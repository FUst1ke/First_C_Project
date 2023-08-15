using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//egyenlő (==) nem egyenlő (!=) és (&&) vagy (||)

//------------------------------------------------------

//if (i == 5)
//{
//    Console.WriteLine("egyenlő");
//} else if (i > 5)
//{
//    Console.WriteLine("nagyobb");
//} else if (i < 5)
//{
//    Console.WriteLine("kisebb");
//}

//------------------------------------------------------

//switch(i) { ezt akkor érdemes használni, ha az érték amit beadsz (i) egy olyan érték aminek pl csak 1-2-3-4-5 fajtája létezik mint kimenetel, ezt itt tudod checkolni "case" alatt. "default" akkor fog lefutni, ha egyik case-be se megy bele.
//    default: 
//        Console.WriteLine("tojáska");
//        break;
//    case 5:
//        Console.WriteLine("helyes case, mivel az i == 5.");
//        break;
//}

//------------------------------------------------------

//string[] names = new string[3]; // Létrehoz egy 3 elemű string tömböt

//names[0] = "Alice";
//names[1] = "Bob";
//names[2] = "Charlie";

//Console.WriteLine(names[1]); // Kiírja: "Bob"

//------------------------------------------------------

//int[] numbers = new int[4]; // Létrehoz egy 4 elemű int tömböt

//numbers[0] = 10;
//numbers[1] = 20;
//numbers[2] = 30;
//numbers[3] = 40;

//int sum = numbers[0] + numbers[1] + numbers[2] + numbers[3]; // Összeadja a tömb elemeit
//Console.WriteLine(sum); // Kiírja: 100

//------------------------------------------------------



namespace akarmi
{
    class Program
    {
        static void Main(string[] args) {
            Matek eredmeny = new Matek();
            
            Console.WriteLine("Add meg az első számot: ");
            string firstNum = Console.ReadLine();
            Console.WriteLine("Add meg a második számot: ");
            string secondNum = Console.ReadLine();
            Console.WriteLine("Az első számod a(z) " + firstNum + ", a második pedig a(z) " + secondNum + ".");

            //--------------------------------------------------------------

            double osztas = eredmeny.Divide(firstNum, secondNum);
            int szorzas = eredmeny.Multiplication(firstNum, secondNum);
            int osszeadas = eredmeny.Add(firstNum, secondNum);
            int kivonas = eredmeny.Sub(firstNum, secondNum);
            Console.WriteLine("A két szám \n osztva: " + osztas + "\n szorozva: " + szorzas + "\n összeadva: " + osszeadas + "\n kivonva: " + kivonas);

            //--------------------------------------------------------------

            Console.ReadKey();
        }

    }
    class Matek
    {
        public double Divide(string a, string b)
        {
            int firstNum = int.Parse(a);
            int secondNum = int.Parse(b);
            double eredmeny = (double)firstNum / secondNum; //csak hogy tudd, azért elég az a-t double-ezni, mert ha már 1.0-t osztunk egész számmal az már nem egész számot fog returnolni.
            return eredmeny;
        }

        public int Multiplication(string a, string b)
        {
            int firstNum = int.Parse(a);
            int secondNum = int.Parse(b);
            int eredmeny = firstNum - secondNum;
            return eredmeny;
        }

        public int Add(string a, string b)
        {
            int firstNum = int.Parse(a);
            int secondNum = int.Parse(b);
            int eredmeny = firstNum - secondNum;
            return eredmeny;
        }
        public int Sub(string a, string b)
        {
            int firstNum = int.Parse(a);
            int secondNum = int.Parse(b);
            int eredmeny = firstNum - secondNum;
            return eredmeny;
        }
    }
}