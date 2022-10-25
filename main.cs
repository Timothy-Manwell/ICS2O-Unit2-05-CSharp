// Created by: Timothy Manwell
// Created on: Oct 2022
//
// This program calculates salary and income tax
using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int hours;
        int rate;
        double takeHomeSalary;
        double INCOMETAX;

        Console.WriteLine("This program calculates salary and income tax");
        Console.Write("\nEnter number of hours worked: ");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter hourly rate: ");
        rate = Convert.ToInt32(Console.ReadLine());

        takeHomeSalary = (hours * rate) * (1.0 - 0.18);
        INCOMETAX = (hours * rate) * 0.18;
        Console.WriteLine("\nYour pay will be: $" + takeHomeSalary.ToString("0.00"));
        Console.WriteLine("\nThe government will take: $" + INCOMETAX.ToString("0.00"));
        Console.WriteLine("\nDone");
    }
}