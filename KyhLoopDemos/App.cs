using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhLoopDemos
{
    internal class App
    {

        public void Run()
        {

            //LOOP 6

            int sist = 0;
            int nästsenaste = 0;
            int senaste = 0;
            int medelvärde = 0;


            while (true)
            {

                sist = nästsenaste;
                nästsenaste = senaste;
                

                medelvärde = (sist + nästsenaste + senaste) / 3;

                if (medelvärde == 25)
                {

                    Console.WriteLine("Alarm");
                    break;

                }


                Console.Write("Mata in temperatur: ");

                int number1 = Convert.ToInt32(Console.ReadLine());

                senaste = number1;
                
                

                



            }






            //LOOP 5

            //Console.Write("Number: ");

            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = number - 1; i > 0 ; i--)
            //{

            //    Console.WriteLine(i);


            //}


            //int counter = 0;

            //number--;

            //while (number > 0)
            //{

            //    Console.WriteLine(number);

            //    number--;


            //}








            //LOOP 4
 
            //int number = 0;
            //int sum = 0;

            //for (int i = 0; i < 10; i++)
            //{

            //    Console.Write("Skriv in ett tal: ");

            //    number = Convert.ToInt32(Console.ReadLine());

            //    sum += number;

            //    if (i == 9)
            //    {
            //        Console.WriteLine("Summan av det du matat in är " + sum);


            //    }

            //}


            //int counter = 0;

            //while (counter < 10)
            //{
                   
          
            //        Console.Write("Skriv in ett tal: ");
            //        number = Convert.ToInt32(Console.ReadLine());
            //        sum += number;

            //        counter++;  

            //    if (counter == 10)
            //    {
            //        Console.WriteLine("Summan av det du matat in är " + sum);


            //     }



            //}







            //LOOP 3

            //while (true)
            //{

            //    Console.Write("Number 1: ");
            //    int number1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Number 2: ");
            //    int number2 = Convert.ToInt32(Console.ReadLine());


            //    Console.WriteLine(number1 + number2 );
            //    Console.WriteLine(" ");

            //    Console.WriteLine("Vill du fortsätta(J/N)? ");

            //    string answer = Console.ReadLine();


            //    if (answer == "J")
            //    {




            //    }


            //    else if (answer == "N")
            //    {


            //        Console.WriteLine("Avslutar");

            //        break;


            //    }



            //  }


            //LOOP 2


            //Console.Write("Nummer 1: ");
            //int valueOne = Convert.ToInt32(Console.ReadLine());


            //Console.Write("Nummer 2: ");
            //int valueTwo = Convert.ToInt32(Console.ReadLine());

            //if (valueOne < valueTwo)
            //{

            //    for (valueOne += 1; valueOne < valueTwo; valueOne++)
            //    {

            //        Console.WriteLine(valueOne);


            //    }


            //}

            //else if (valueOne > valueTwo)
            //{

            //    for (int i = valueOne - 1; i > valueTwo; i--)
            //    {

            //        Console.WriteLine(i);


            //    }



            //}




            //if (valueOne < valueTwo)
            //{

            //    valueOne++;

            //    while (valueOne < valueTwo)
            //    {



            //        Console.WriteLine(valueOne);

            //        valueOne++;

            //    }




            //}

            //else if (valueOne > valueTwo)
            //{
            //    valueOne--;

            //    while (valueOne > valueTwo)
            //    {



            //        Console.WriteLine(valueOne);

            //        valueOne--;


            //    }


            //}


            //LOOP 1





            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //int counter = 0;

            //while (counter < 11)
            //{

            //    Console.WriteLine(counter);

            //    counter++;

            //}





            //string namnet = "Stefan";
            //char letter = 'A';

            //foreach (char c in namnet)
            //{
            //    Console.WriteLine(c);
            //}


            //bool isRunning = true;
            //while (isRunning)
            //{

            //    Console.WriteLine("1. Starta spelet");
            //    Console.WriteLine("2. Highscore");
            //    Console.WriteLine("3. Avsluta");
            //    Console.WriteLine("Vad vill du göra:");
            //    string selection = Console.ReadLine();

            //    if (selection == "1")
            //    {

            //        Console.WriteLine("Spelet startar");
            //        Console.WriteLine("..... och slutar");


            //    }

            //    else if (selection == "2")
            //    {

            //        Console.WriteLine("Highscore visas");
            //        Console.WriteLine("..... och slutar");


            //    }

            //    else if (selection == "3")
            //    {             
            //        break;
            //        isRunning = false;
            //    }



            //}



            //int age = 12;
            //if (age > 10)
            //{

            //}


            // int counter = 0;

            //while (counter < 5)               
            //{
            //    Console.WriteLine("Jag heter Stefan");
            //    Console.WriteLine("Hej");
            //    counter++;  
            //}


            //for (int counter2 = 0; counter2 < 5; counter2++)
            //{

            //    Console.WriteLine("Jag heter Stefan");
            //    Console.WriteLine("Hej");

            //}






            //for (int year = 2022; year >= 1972; year--)
            //{

            //    Console.WriteLine(year);

            //}

            //for (int year = 1972; year <= 2022; year++)
            //{

            //    Console.WriteLine(year);

            //}
            //Console.WriteLine("Slut");


        }


    }
}
