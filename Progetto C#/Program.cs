using System.ComponentModel;

namespace Progetto_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SNACK 1");
            string num1;
            string num2;
            Console.WriteLine("Inserisci il primo numero");
            num1 = Console.ReadLine();
            Console.WriteLine("Inserisci il secondo numero");
            num2 = Console.ReadLine();


            if (Int32.Parse(num1) > Int32.Parse(num2))
            {
                Console.WriteLine($"Il numero più grande è" + " " + (num1));
            }
            else
            {
                Console.WriteLine($"Il numero più grande è" + " " + (num2));
            }

            Console.WriteLine("SNACK 2");
            List<int> arrayNum = [];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("inserisci un numero");
                string input = Console.ReadLine();
                sum += Int32.Parse(input);
                arrayNum.Add(Int32.Parse(input));
            }
            Console.WriteLine(sum);
            foreach (int i in arrayNum)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("SNACK 3");
            string strInput;
            Console.WriteLine("Inserisci un numero e sarà sempre pari");
            strInput = Console.ReadLine();
            int numInput = Int32.Parse(strInput);

            if (numInput % 2 == 0)
            {
                Console.WriteLine($"Il numero " + numInput + " è pari");
            }
            else
            {
                Console.WriteLine($"Il numero era dispari: ora è " + (numInput + 1));
            }

            Console.WriteLine("SNACK 4");
            string[] listInvited = { "Jenna", "Orlando", "Jlo", "Margot", "Sia" };
            string nameGuest;
            Console.WriteLine("Inserisca il suo nome per procedere");
            nameGuest = Console.ReadLine();

            if (listInvited.Contains(nameGuest))
            {
                Console.WriteLine("Benvenuto\a si accomodi");
            }
            else
            {
                Console.WriteLine("Sono spiacente ma non risulta nella lista degli invitati");
            }

            Console.WriteLine("SNACK 5");
            List<int> arrayNumber1 = [];
            string strImput;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Inserisci un numero");
                strImput = Console.ReadLine();
                if (Int32.Parse(strImput) % 2 == 1)
                {
                    arrayNumber1.Add(Int32.Parse(strImput));
                }


            }
            string outputStr = "";
            for (int i = 0; i < arrayNumber1.Count(); i++)
            {
                if (i == arrayNumber1.Count() - 1)
                {
                    outputStr += arrayNumber1[i].ToString();
                }
                else
                {
                    outputStr += arrayNumber1[i].ToString() + ", ";
                }
            }
            Console.WriteLine("I tuoi numeri dispari sono: " + outputStr);


            Console.WriteLine("SNACK 6");
            List<int> arrayNumberInt = [1, 2, 3, 4, 5];
            int summaryOfNumbers = 0;
            for (int i = 0; i < arrayNumberInt.Count; i++)
            {
                if (i % 2 == 1)
                {
                    summaryOfNumbers += arrayNumberInt[i];
                }
            }
            Console.WriteLine("La somma dei numeri in posizione dispari è: " + summaryOfNumbers);

            Console.WriteLine("SNACK 7");
            string imputNumber;
            int numberConverted;
            List<int> arrayNumber = [];
            while (arrayNumber.Sum() <= 50)
            {

                Console.WriteLine("inserisci un numero");
                imputNumber = Console.ReadLine();
                numberConverted = (Int32.Parse(imputNumber));
                arrayNumber.Add(numberConverted);
            }



            Console.WriteLine("SNACK 8");
            Console.WriteLine("Inserisci un numero");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int[] newArray = { };
                for (int y = 0; y < 10; y++)
                {
                    Array.Resize(ref newArray, newArray.Length + 1);
                    Random rnd = new Random();
                    newArray[newArray.Length - 1] = rnd.Next(1, 101);

                }
                Console.WriteLine("\n");
                Console.WriteLine($"Array numero {i + 1}:");
                for (int x = 0; x < newArray.Length; x++)
                {
                    Console.WriteLine(newArray[x]);
                }
            }
        }
    }
}



