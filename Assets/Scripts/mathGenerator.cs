/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var rnd = new Random();
        var quit = false;
        var userScore = 0;
        var totalProblems = 0;
        var percentCorrect = 0d;

        while (!quit)
        {
            var number1 = rnd.Next(1, 31);
            var number2 = rnd.Next(1, 31);
            var operation = rnd.Next(1, 5);
            string operatorString;
            int answer;
            totalProblems++;

//          Console.WriteLine("\tVyries prosim nizsie uvedeny vygenerovany priklad. Bude Ti udelena znamka:");

            switch (operation)
            {
                case 1:
                    answer = number1 + number2;
                    operatorString = "+";
                    break;
                case 2:
                    answer = number1 - number2;
                    operatorString = "-";
                    break;
                case 3:
                    answer = number1 * number2;
                    operatorString = "*";
                    break;
                case 4:
                    answer = number1 / number2;
                    operatorString = "/";
                    break;
                default:
                    answer = 0;
                    operatorString = "?";
                    break;
            }

//          Console.WriteLine("\t{0} {1} {2}", number1, operatorString, number2);
//          Console.Write("\nVysledok je (ak je potrebne, zaokruhli): ");
//          var input = Console.ReadLine();
            int inputAsInt;

            while (!int.TryParse(input, out inputAsInt))
            {
                //Console.Write("Odpoved musi byt integer. Skus znova: ");
                input = Console.ReadLine();
            }

            if (inputAsInt == answer)
            {
//              Console.WriteLine("Spravna odpoved, super!");
                userScore++;
            }
            else
            {
//              Console.WriteLine("Prepac, spravna odpoved bola: {0}", answer);
            }

            percentCorrect = Math.Round((double)userScore / totalProblems * 100, 2);

//          Console.WriteLine("\nOdpovedal si {0}x spravne z {1} pokusov, " +
//            "co je {2}%.", userScore, totalProblems, percentCorrect);

//          Console.Write("\nStlac 'q' ak chces skoncit, alebo pokracuj dalej ...");
//          if (Console.ReadKey().Key == ConsoleKey.Q) quit = true;
    }

//          Console.Write("\nStlac nejaku klavesu pre ukoncenie..");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}*/
