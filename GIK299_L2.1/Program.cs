namespace GIK299_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange hur stor familjen är: ");
            Console.Write("> ");
            int familySize = Convert.ToInt32(Console.ReadLine());

            int switchValue = 0;
            int familyCounter = 0;
            string[] familyNames = new string[familySize];
            double[] familyAge = new double[familySize];
            double totalAge = 0;
            double medianAge = 0;
            string familyMemberName;
            int familyMemberAge = 0;

            while (switchValue != 5) //en whileloop där variabeln menuSelector är villkoret som avgör om loopen ska fortsätta eller ej
            {
                Console.WriteLine(
                    "------------------------------------------------" +
                    "\nVälj ett av alternativen: " +
                    "\n1.) Lägg till familjemedlem" +
                    "\n2.) Skriv ut lista över familjemedlemar" +
                    "\n3.) Skriv ut summerad ålder för familjen" +
                    "\n4.) Skriv ut medelålder för familjen" +
                    "\n5.) Avsluta programmet" +
                    "\n------------------------------------------------"
                    );

                Console.Write("> ");
                switchValue = int.Parse(Console.ReadLine());
                switch (switchValue)
                {
                    case 1:

                        if (familyCounter < familySize)
                        {

                            Console.WriteLine("Du har valt att lägga till en familjemedlem");
                            Console.WriteLine("Ange namn på familjemedlem");
                            Console.Write("> ");
                            familyMemberName = Console.ReadLine();
                            familyNames[familyCounter] = familyMemberName;

                            Console.WriteLine("Ange ålder på familjemedlem");
                            Console.Write("> ");
                            familyMemberAge = int.Parse(Console.ReadLine());
                            familyAge[familyCounter] = familyMemberAge;
                            familyCounter++;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Listan är full du kan inte lägga till flera familjemedlemar");

                        }

                        break;

                    case 2:

                        if (familyCounter == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Det saknas familjemedlemmar, lägg till familjemedlemmar genom att välja 1 i menyn");
                            Console.WriteLine();
                        }
                        else
                        {
                            for (int i = 0; i < familyCounter; i++)
                            {


                                Console.WriteLine(familyNames[i] + " är " + familyAge[i]);
                            }
                        }
                        break;

                    case 3:
                        if (familyCounter == 0)

                        {
                            Console.Clear();
                            Console.WriteLine("Det saknas familjemedlemmar, lägg till familjemedlemmar genom att välja 1 i menyn");
                            Console.WriteLine();
                        }
                        else
                        {
                            for (int i = 0; i < familyCounter; i++)



                            {
                                //Referens till array.sum https://www.c-sharpcorner.com/blogs/how-to-find-sum-of-an-array-of-numbers-in-c-sharp
                                totalAge = familyAge.Sum();
                            }
                            Console.WriteLine("Den totala åldern för familjen är:" + totalAge.ToString("0.00"));
                        }
                        break;

                    case 4:
                        if (familyCounter == 0)

                        {
                            Console.Clear();
                            Console.WriteLine("Det saknas familjemedlemmar, lägg till familjemedlemmar genom att välja 1 i menyn");
                            Console.WriteLine();
                        }
                        else
                        {
                            medianAge = familyAge.Sum() / familyCounter;
                            Console.WriteLine("Medelåldern för familjen är: " + medianAge.ToString("0.00"));
                        }
                        break;

                    case 5:
                        Console.WriteLine("Avslutar program");
                        break;


                    default:
                        Console.WriteLine("Felaktig indata, du behöver ange ett nummer mellan 1 - 5\n");
                        break;
                }


            }
        }
    }
}
