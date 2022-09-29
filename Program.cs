

namespace Game
{
    class Program

    {
        static void Main(string[] args)
        {
            int countA = 0;
            int countB = 0;
            Console.WriteLine("Welcome to Rock-Paper-Scissor-Lizard-Spock Game - 2 Player");




            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n========\nROUND " + (i + 1) +
                                "\n=======" +
                                "\n\nShapes:\n" +
                                "Rock = r\n" +
                                "Paper = p\n" +
                                "Scissor = s\n" +
                                "Lizard = l\n" +
                                "Spocks = sp" +
                                "\n\n* PLAYER A TURNS *");

                string shapeA;
                string shapeB;
                string message = ("ERROR: Only 'r' , 'p' , 's' , 'l' , 'sp' are allowed");

                while (true)
                {
                    Console.WriteLine("Choose your shape: ");
                    shapeA = Console.ReadLine();

                    if (shapeA == "r" || shapeA == "p" || shapeA == "s" || shapeA == "l" || shapeA == "sp")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(message);
                        continue;
                    }
                }

                Console.WriteLine("\n*PLAYER B TURNS *");

                while (true)
                {
                    Console.WriteLine("Choose your shape: ");
                    shapeB = Console.ReadLine();

                    if (shapeB == "r" || shapeB == "p" || shapeB == "s" || shapeB == "l" || shapeB == "sp")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(message);
                        continue;
                    }
                }

                if (shapeA == "r")
                {
                    switch (shapeB)
                    {
                        case "p":
                        case "sp":
                            Console.WriteLine("RESULT: PLAYER B GOT 1 POINT!");
                            countB++;
                            break;
                        case "s":
                        case "l":
                            Console.WriteLine("RESULT: PLAYER B GOT 1 POINT!");
                            countA++;
                            break;
                        default:
                            Console.WriteLine("RESULT: DRAW!");
                            break;
                     }
                }

                else if (shapeA == "p")
                {
                     switch (shapeB)
                    {
                        case "s":
                        case "l":
                            Console.WriteLine("RESULT: PLAYER B GOT 1 POINT!");
                            countB++;
                            break;
                        case "r":
                        case "sp":
                            Console.WriteLine("RESULT: PLAYER B GOT 1 POINT!");
                            countA++;
                            break;
                        default:
                            Console.WriteLine("RESULT: DRAW!");
                            break;
                     }
                }

                else if (shapeA == "s")
                {
                    switch (shapeB)
                     {
                        case "r":
                        case "sp":
                            Console.WriteLine("RESULT: PLAYER B GOT 1 POINT!");
                            countB++;
                            break;
                        case "p":
                        case "l":
                            Console.WriteLine("RESULT: PLAYER B GOT 1 POINT!");
                            countA++;
                            break;
                        default:
                            Console.WriteLine("RESULT: DRAW!");
                            break;
                     }
                }


                else if (shapeA == "l")
                {
                    switch (shapeB)
                     {
                        case "r":
                        case "sp":
                            Console.WriteLine("RESULT: PLAYER B GOT 1 POINT!");
                            countB++;
                            break;
                        case "p":
                        case "s":
                            Console.WriteLine("RESULT: PLAYER B GOT 1 POINT!");
                            countA++;
                            break;
                        default:
                            Console.WriteLine("RESULT: DRAW!");
                            break;
                     }
                }

                else if (shapeA == "sp")
                {
                    switch (shapeB)
                     {
                        case "l":
                        case "p":
                            Console.WriteLine("RESULT: PLAYER B GOT 1 POINT!");
                            countB++;
                            break;
                        case "r":
                        case "s":
                            Console.WriteLine("RESULT: PLAYER B GOT 1 POINT!");
                            countA++;
                            break;
                        default:
                            Console.WriteLine("RESULT: DRAW!");
                            break;
                     }
                }
                Console.WriteLine("\nCUMMULATIVE SCORE: PLAYER A = " + countA + ", PLAYER B = " + countB);
            }
           


            if (countA > countB)
            {
                Console.WriteLine("\n\nOVERALL RESULT : PLAYER A WIN!");
            }
            else if (countA < countB)
            {
                Console.WriteLine("\n\nOVERALL RESULT : PLAYER B WIN!");
            }
            else
            {
                Console.WriteLine("\n\nOVERALL RESULT : DRAW!");
            }
        }
    }
}










