﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PersonDataManagement
{
    class PersonData
    {

        /// <summary>
        /// UC1-Adding Person details and display it. 
        /// </summary>
        /// <param name="list"></param>
        public static void AddPerson(List<Person> list)
        {
            Console.WriteLine("\n-----------Adding person details to list----------\n");
            try
            {
                if (list.Count >= 0)
                {
                    list.Add(new Person() { SSN = 1, name = "Radhika", address = "Chennai", age = 21 });
                    list.Add(new Person() { SSN = 2, name = "Priya", address = "Bangalore", age = 27 });
                    list.Add(new Person() { SSN = 3, name = "Arun", address = "Pondicherry", age = 35 });
                    list.Add(new Person() { SSN = 4, name = "Ajoy", address = "Madurai", age = 37 });
                    list.Add(new Person() { SSN = 5, name = "Kishore", address = "Hyderabad", age = 41 });
                }
                else if (list.Count == 0)
                {
                    Console.WriteLine("No details are added");
                }

                IterateThroughList(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UC2-Retrieve Top two records which is less tahn 60
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool RetrieveTopTwoLessThan60(List<Person> list)
        {
            Console.WriteLine("\n----------Retrieve top two records in list-----------\n");
            try
            {
                AddPerson(list);
                if (list.Count > 0)
                {
                    var ageResult1 = list.FindAll(a => a.age < 60).OrderBy(b => b.age).Take(2).ToList();
                    IterateThroughList(ageResult1);
                    return true;
                }
                else if (list.Count < 0)
                {
                    Console.WriteLine("No data present in list");
                    return false;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }
        /// <summary>
        /// UC3-Retrieve teenage records
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool RetrieveTeenageRecords(List<Person> list)
        {
            Console.WriteLine("\n----------Retrieve Records which is Age between 13 to 18-----------\n");
            try
            {
                AddPerson(list);

                if (list.Count > 0)
                {
                    var ageResult2 = list.FindAll(a => a.age > 13 && a.age < 18);


                    IterateThroughList(ageResult2);
                    return true;

                }
                else
                {
                    Console.WriteLine("No data present in list");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static void IterateThroughList(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine("SSN : {0} Name : {1} Address : {2} Age : {3}  ", person.SSN, person.name, person.address, person.age);
            }
        }
    }
}
