using System;
using System.Collections.Generic;

class Day2Part2
{
    public static void Main(string[] args)
    {
        string [] lines = File.ReadAllLines("Day2Input.txt");
        string [] choices;
        int roundscore = 0;
        foreach(string line in lines){
            choices = line.Split(" ");
            if(choices[1].Equals("X")){
                //Need to lose!
                //Add points for what was played
                roundscore+=points(howToLose(choices[0]));
            }else if(choices[1].Equals("Y")){
                //Need to draw!
                //Add points for what was played
                roundscore+=points(choices[0]);
                //Add points for draw
                roundscore+=3;
            }else{
                //Need to win!
                //Add points for what was played
                roundscore+=points(WhatToPlay(choices[0]));
                //Add points for win
                roundscore+=6;
            }
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
    public static string howToLose(string choice){
        if(choice.Equals("A")){
            return "Z";
        }else if(choice.Equals("B")){
            return "X";
        }else{
            return "Y";
        }
    }
    
}