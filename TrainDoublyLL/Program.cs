using System;

namespace TrainDoublyLL
{
    public class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Carriage(1, "car1", 5000, 15, 5);
            var c2 = new Carriage(2, "car2", 5000, 15, 5);

            Train myTrain = new Train("F270", 2);
            myTrain.Add(c1);
            myTrain.Add(c2);

            foreach (var item in myTrain.train)
            {
                Console.WriteLine(myTrain.train.GetEnumerator().ToString());
            }
        }
    }
}
