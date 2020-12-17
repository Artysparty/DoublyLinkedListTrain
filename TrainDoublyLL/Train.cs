using System;
using System.Collections;
using System.Collections.Generic;
using TrainDoublyLL.DoublyLinkedList;

namespace TrainDoublyLL
{
    public class Train
    {
        public DoublyLinkedList<Carriage> train;

        public Train(string trainCode, int numberOfCarriages)
        {
            NumberOfCarriages = numberOfCarriages;
            TrainCode = trainCode;
            train = new DoublyLinkedList<Carriage>();
        }

        public string TrainCode { get; set; }
        public int NumberOfCarriages { get; set; }

        public void Add(Carriage carriage)
        {
            train.Add(carriage);
            Console.WriteLine($"Вагон с кодом {carriage.Number} добавлен к поезду.");
        }

        public void Remove(Carriage carriage)
        {
            train.Remove(carriage);
            Console.WriteLine($"Вагон с кодом {carriage.Number} отцеплен от поезда.");
        }

        public void GetAll()
        {
            foreach (var c in train)
            {
                Console.WriteLine(train.GetEnumerator());
            }
        }
    }
}