using System;
using System.Collections.Generic;
using System.Linq;

namespace linq {

    class Program {

        static void Main (string[] args) {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string> () {
                "Lemon",
                "Apple",
                "Orange",
                "Lime",
                "Watermelon",
                "Loganberry"
            };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.Contains ("L")
            select fruit;

            Console.WriteLine ("Fruits that contain L:");
            foreach (string fruit in LFruits) {
                Console.WriteLine (fruit);
            }
            Console.WriteLine ("--------------------");

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = from num in numbers
            where num % 4 == 0 || num % 6 == 0
            select num;
            Console.WriteLine ("Multiples of four or six:");
            foreach (int number in fourSixMultiples) {
                Console.WriteLine (number);
            }
            Console.WriteLine ("--------------------");

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string> () {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            var descend = from name in names
            orderby name descending
            select name;

            Console.WriteLine ("Names from Z to A:");
            foreach (string n in descend) {
                Console.WriteLine (n);
            }
            Console.WriteLine ("--------------------");

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            var ascendingNums = from nums2 in numbers2
            orderby nums2
            select nums2;

            Console.WriteLine ("Ascending numbers:");
            foreach (int n in ascendingNums) {
                Console.WriteLine (n);
            }
            Console.WriteLine ("--------------------");
            // Output how many numbers are in this list
            List<int> numbers3 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            int total = numbers3.Count ();

            Console.WriteLine ($"There are {total} total numbers in the list");
            Console.WriteLine ("--------------------");

            // How much money have we made?
            List<double> purchases = new List<double> () {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };

            double totalPurchases = purchases.Sum ();
            Console.WriteLine ($"We have made ${totalPurchases}");
            Console.WriteLine ("--------------------");

            // What is our most expensive product?
            List<double> prices = new List<double> () {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };

            double expensive = prices.Max ();
            Console.WriteLine ($"Out most expensive item costs ${expensive}");
            Console.WriteLine ("--------------------");

            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int> () {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };

            var sampleNumbersSquared = wheresSquaredo.Select(number => Math.Sqrt(number));

            foreach (int n in sampleNumbersSquared){
            Console.WriteLine ($"{n}");
            }
            Console.WriteLine ("--------------------");
        }

    }
}