﻿using System;

namespace ConsoleApp7

{
    class cars
    {
        protected string model;
        protected string color;
        public int speed;
        public int year;
        public double voluem;
        
        public string CarModel
        {
            get { return model; }
            set { model = value; }
        }
        
        public string CarColor
        {
            get { return color; }
            set { color = value; }
        }
    }

    class Mercedes:cars
    {
        public Mercedes()
        {
            model = "Mercedes-Benz eclass ";
            year = 1900;
            color = "white";
            speed = 240;
            voluem = 5.5;
        }
    }

    class BMW:cars
    {
        public BMW()
        {
            model = "BMW M5 CS f90";
            year = 2024;
            color = "black";
            speed = 400;
            voluem = 6.3;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes m = new Mercedes();
            BMW bmw = new BMW();
            Console.WriteLine(m.CarModel);
            Console.WriteLine(m.CarColor);
            Console.WriteLine(m.year);
            Console.WriteLine(m.speed);
            Console.WriteLine(m.voluem);
            Console.WriteLine(bmw.CarModel);
            Console.WriteLine(bmw.CarColor);
            Console.WriteLine(bmw.year);
            Console.WriteLine(bmw.speed);
            Console.WriteLine(bmw.voluem);
            
        }
    }
}    