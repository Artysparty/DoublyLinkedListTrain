using System;
using System.Collections;
using System.Collections.Generic;

namespace TrainDoublyLL
{
    public class Carriage : IComparable<Carriage>

    {
    public Carriage(int number, string cargo, float weight, float length, float width)
    {
        Number = number;
        Cargo = cargo;
        Weight = weight;
        Length = length;
        Width = width;
    }

    public int Number { get; set; }
    public string Cargo { get; }
    public float Weight { get; }
    public float Length { get; }
    public float Width { get; }

    public int CompareTo(Carriage other)
    {
        var result = string.Compare(Cargo, other.Cargo, StringComparison.Ordinal);
        if (result == 0)
        {
            result = Weight.CompareTo(other.Weight);
            if (result == 0) result = Length.CompareTo(other.Length);
        }

        return result;
    }
    }
}