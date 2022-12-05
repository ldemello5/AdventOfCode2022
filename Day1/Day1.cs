using System;
using System.Collections.Generic;

class Day1
{
    public static void Main(string[] args)
    {
        List<int> number = new List<int>();
        string [] lines = File.ReadAllLines("Day1Input.txt");
        int temp = 0;
        foreach(string line in lines){
            if(!line.Equals("")){
                temp += int.Parse(line);
            }else{
                number.Add(temp);
                temp = 0;
            }
        }
        int total = 0;
        temp = FindLargest(number);
        total+=temp;
        number.Remove(temp);
        temp = FindLargest(number);
        total+=temp;
        number.Remove(temp);
        temp = FindLargest(number);
        total+=temp;
        Console.WriteLine("Top 3 "+total);
    }
    //finds largest number in list
    public static int FindLargest(List<int> number){
        int temp = 0;
        for(int i=0;i<number.Count;i++){
            if(number[i]>temp){
                temp = number[i];
            }
        }
        return temp;
    }
}