using System;
using System.Globalization;

namespace ConsoleApp1{
  internal class Program{
    static void Main(string[] args){

      PrintChristmasTree(10);
      
    }

    public static void PrintStars(int numStars){
      for(int i = 1; i<=numStars; i++){
        Console.Write("*");
        if(i==numStars){
          Console.WriteLine("");
        }
      }
    }

    public static void PrintSquare(int squareSize){
      for(int i = 1; i<=squareSize; i++){
        PrintStars(squareSize);
      }
    }

    public static void PrintRectangle(int width, int height){
      for(int countHeight = 1; countHeight <= height; countHeight++){
        PrintStars(width);
      }
    }

    public static void PrintTriangle(int height){
      for(int countHeight = 1; countHeight<=height; countHeight++){
        PrintStars(countHeight);
      }
    }

    public static void PrintSpaces(int spaces){
      spaces--;
      for(int countSpaces = 1; countSpaces<=spaces; countSpaces++){
        Console.Write(" ");
      }
    }

    public static void PrintRightTriangle(int size){
      int numStars = 1;
      for(int count = size; count>=1; count--){
        PrintSpaces(count);
        PrintStars(numStars);
        numStars++;
      }
    }

    public static void PrintChristmasTree(int height){

      int numStars = 1;
      for(int count = height; count>=1; count--){
        PrintSpaces(count);
        PrintStars(numStars);
        numStars = numStars + 2;
      }
      for(int i = 1; i<=2; i++){
        PrintSpaces(height-1);
        PrintStars(3);
      }
    }
  }
}