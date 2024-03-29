﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractice
{
    class Car:Vehicle
    {
        string Color;
        int Year;
        string Brand;
        string Model;
        int FuelCapacity;
        double FuelFor1Km;
        double CurrentFuel;

        public Car()
        {

        }
        public Car(string Color) : base(Color)
        {

        }
        public Car(string Color, int Year) : base(Color, Year)
        {

        }



        public Car(string Color, int Year, string Brand)
        {
            this.Brand = Brand;

        }

        public Car(string Color, int Year, string Brand, string Model) : this(Color, Year, Brand)
        {
            this.Model = Model;
        }
        public Car(string Color, int Year, string Brand, string Model, int FuelCapacity) : this(Color, Year, Brand, Model)
        {
            this.FuelCapacity = FuelCapacity;
        }

        public Car(string Color, int Year, string Brand, string Model, int FuelCapacity, double FuelFor1Km) : this(Color, Year, Brand, Model, FuelCapacity)
        {
            this.FuelFor1Km = FuelFor1Km;
        }

        public Car(string Color, int Year, string Brand, string Model, int FuelCapacity, double FuelFor1Km, double CurrentFuel) : this(Color, Year, Brand, Model, FuelCapacity, FuelFor1Km)
        {
            this.CurrentFuel = CurrentFuel;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Çənin Tutduğu Benzin Həcmi {FuelCapacity}Litr");
            Console.WriteLine($"1Km üçün istifadə etdiyi yanacaq {FuelFor1Km}Litr");

            Console.WriteLine("---------------------------------");

        }

        

        public void Drive(double driveway)
        {
            if (driveway>0)
            {
                CurrentFuel = (driveway *  FuelFor1Km);
                Console.WriteLine($"Istifadə olunduqdan sonra qalan benzin {CurrentFuel}Litr");
            }

            else
            {
                Console.WriteLine("Benzin Yoxdur");
            }
            
        }













    }
}
