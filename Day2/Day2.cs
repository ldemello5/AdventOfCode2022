
using System;
using System.Collections.Generic;

class Day2
{
    public static void Main(string[] args)
    {
        string [] lines = File.ReadAllLines("Day1Input.txt");
        string [] inputs;
        int overlapping = 0;
        foreach(string line in lines){
            inputs = line.Split(",");
            if(minMax(inputs[0])[0] >= minMax(inputs[1])[0] && minMax(inputs[0])[0] <= minMax(inputs[1])[1]
            || minMax(inputs[1])[0] >= minMax(inputs[0])[0] && minMax(inputs[1])[0] <= minMax(inputs[0])[1]){
                overlapping++;
            }
        }
        Console.WriteLine("Overlapping: "+overlapping);
        
    }
    public static int [] minMax(string input){
        string [] numbers = input.Split("-");
        int [] minandmax = new int[2];
        minandmax[0] = int.Parse(numbers[0]);
        minandmax[1] = int.Parse(numbers[1]);
        return minandmax;
    }
}