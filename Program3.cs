﻿using System;


    public class GeneralMAnager
    {
        public void DisplayGeneralMAnagerGM()
        {
            Console.WriteLine("General manager is head of all managers");
        }
    }

    public class AreaDivisionManagerA :GeneralMAnager
    {
        public void DisplayAreaDivisionManagerA()
        {
            Console.WriteLine("ADM is the Area divisional manager of south india");
        }
    }

    public class RegionalManagerR : GeneralMAnager
    {
        public void DisplayRegionalManagerR()
        {
            Console.WriteLine("RM is the regional manager of chamrajnagar");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            AreaDivisionManagerA areaDivisionManagerA = new AreaDivisionManagerA(); 
            RegionalManagerR regionalManagerR = new RegionalManagerR();

        areaDivisionManagerA.DisplayAreaDivisionManagerA();
        areaDivisionManagerA.DisplayGeneralMAnagerGM();

        regionalManagerR.DisplayRegionalManagerR();
        regionalManagerR.DisplayGeneralMAnagerGM();
        }
    }