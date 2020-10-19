﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(listPersonInCity);
            CheckForTeenagers(listPersonInCity);
            findAverageInList(listPersonInCity);
            Console.ReadKey();
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
        }

        private static void Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => e.Age < 60).Take(2).ToList())
            {
                Console.WriteLine("Name: " + person.Name + "\t Age: " + person.Age);
            }
        }

        private static void CheckForTeenagers(List<Person> listPersonInCity)
        {
            if(listPersonInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("Teenager Present.");
            }
            else
            {
                Console.WriteLine("Teenager Not Present.");
            }
        }

        private static void findAverageInList(List<Person> listPersonInCity)
        {
            double average = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("The average of people in list is "+ average);
        }
    }
}