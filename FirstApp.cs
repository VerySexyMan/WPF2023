using System;
using System.IO;

class Program {
  public static void Main (string[] args) {
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine (number);
    int[] array = new int[number];
    Random rand = new Random();
    for (int i = 0; i < number; i++)
      array[i] = rand.Next(); 
    Console.WriteLine("[{0}]", string.Join(", ", array));
    Array.Sort(array);
    string Str = String.Join(" ", array);
    string name = Console.ReadLine();
    Console.WriteLine (name);
    name = name.Insert(name.Length, " ");
    name = name.Insert(name.Length, Str);
    string path = "text.txt";
    File.WriteAllText(path, name);
    }
  }
  
