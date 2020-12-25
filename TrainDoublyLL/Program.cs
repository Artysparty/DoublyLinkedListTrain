using System;
using System.IO;

namespace TrainDoublyLL
{
    public class Program
    {
        static void Main(string[] args)
        {
            Train myTrain = new Train("F270", 2);

            if (args.Length > 0)
            {
                var file = File.ReadAllLines(args[0]);
                foreach (var line in file)
                {
                    myTrain.Add(new Carriage(int.Parse(line.Split(' ')[0]), line.Split(' ')[1], float.Parse(line.Split(' ')[2]),
                        float.Parse(line.Split(' ')[3]), float.Parse(line.Split(' ')[4])));
                }
            }
            else
            {
                myTrain.Add(new Carriage(1, "car1", 5000, 15, 5));
                myTrain.Add(new Carriage(2, "car2", 5000, 15, 5));
            }

            Console.WriteLine(myTrain);

            Console.ReadKey();
        }
    }
}
