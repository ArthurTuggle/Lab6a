using System;
using System.Linq;

class HelloWorld {
    static void Main() {
        
        double[] Celcius = new double[7];
        double[] Fahrenheit = new double[7];
        double sum = 0;

        for (int i=0; i<7; i++)
        {
            Console.Write("Enter temperature in Celcius: ");
            Celcius[i] = Convert.ToDouble(Console.ReadLine());
        }
        
        for (int i=0; i<7; i++)
        {
            Fahrenheit[i] = (Celcius[i] * 1.8) + 32;
            sum += Fahrenheit[i];
        }

        double average = sum/7.0;

        Array.Sort(Fahrenheit); 
        Array.Reverse(Fahrenheit);

        Console.WriteLine("\nTemperature in Fahrenheit");  
        foreach(double value in Fahrenheit) 
        { 
            Console.Write(value + " "); 
        }

        Console.WriteLine("\nAverage weekly temperature is " + average + " degrees fahrenheit"); 

    }
}