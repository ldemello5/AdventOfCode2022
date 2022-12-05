using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string [] lines = File.ReadAllLines("Day2Input.txt");
        string [] choices;
        int roundscore = 0;
        foreach(string line in lines){
            choices = line.Split(" ");
            if(choices[1].Equals(WhatToPlay(choices[0]))){
                //We won!
                //Add points for win
                roundscore+=6;
            }else if(isDraw(choices[0],choices[1])==3){
                //We drew!
                //Add points for draw
                roundscore+=3;
            }else{
                //We lost! Don't have to do anything.
            }
            //Add points for specific thing played
            roundscore+=points(choices[1]);
        }
        Console.WriteLine("Score: "+roundscore);


    }
    public static string WhatToPlay(string choice){
        if(choice.Equals("A")){
            return "Y";
        }else if(choice.Equals("B")){
            return "Z";
        }else{
            return "X";
        }
    }
    public static int points(string choice){
        if(choice.Equals("A") || choice.Equals("X")){
            return 1;
        }else if(choice.Equals("B") || choice.Equals("Y")){
            return 2;
        }else{
            return 3;
        }
    }
    public static int isDraw(string enemy, string you){
        if(enemy.Equals("A") && you.Equals("X") || enemy.Equals("B") && you.Equals("Y") || enemy.Equals("C") && you.Equals("Z")){
            return 3;
        }else{
            return 0;
        }
    }
    
}