using System;
    class Eligibility
    {
        static void Main(string[] args)
        {
           int mpc,mp,maths, physics, chemistry;
        string name;
        Console.WriteLine("Enter mark in maths:");
        maths = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter mark in physics:");
        physics = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter mark in chemistry:");
        chemistry = int.Parse(Console.ReadLine());
        mpc=maths+physics+chemistry;
        mp=maths+physics;
        if(maths>=65&&physics>=55&&chemistry>=50)
        {
            if(mpc>=180||mp>=140)
            {
                Console.WriteLine("eligible for admission.");
            }
            else
            {
                Console.WriteLine("not eligible for admission.");
            }
        }
        else
        {
            Console.WriteLine("not eligible for admission.");
        }
    }
        }