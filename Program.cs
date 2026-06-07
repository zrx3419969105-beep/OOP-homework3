using System;

class Program
{
    static double[] temp = new double[10];

    static void Main(string[] args)
    {
        int choice;

        ReadData();

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Compute Min and Max");
            Console.WriteLine("2. Compute Average");
            Console.WriteLine("3. Get Temperature Above Threshold");
            Console.WriteLine("4. Re-enter Data");
            Console.WriteLine("0. Exit");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    MinMax();
                    break;

                case 2:
                    Average();
                    break;

                case 3:
                    Threshold();
                    break;

                case 4:
                    ReadData();
                    break;

                case 0:
                    Console.WriteLine("Program Ended.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }

        } while (choice != 0);
    }

    static void ReadData()
    {
        Console.WriteLine("\nEnter 10 Temperatures:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Temperature " + (i + 1) + ": ");
            temp[i] = Convert.ToDouble(Console.ReadLine());
        }
    }

    static void MinMax()
    {
        double min = temp[0];
        double max = temp[0];

        for (int i = 1; i < temp.Length; i++)
        {
            if (temp[i] < min)
            {
                min = temp[i];
            }

            if (temp[i] > max)
            {
                max = temp[i];
            }
        }

        Console.WriteLine("Minimum Temperature = " + min);
        Console.WriteLine("Maximum Temperature = " + max);
    }

    static void Average()
    {
        double sum = 0;

        for (int i = 0; i < temp.Length; i++)
        {
            sum += temp[i];
        }

        double avg = sum / temp.Length;

        Console.WriteLine("Average Temperature = " + avg);
    }

    static void Threshold()
    {
        Console.Write("Enter Threshold: ");
        double threshold = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Temperatures Above Threshold:");

        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] > threshold)
            {
                Console.WriteLine(temp[i]);
            }
        }
    }
}