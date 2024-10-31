namespace CollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DictionaryExample();

            string teacher = "Tuomas";

            //creating a new array with fixed size
            string[] studentsArray = new string[5];
            studentsArray[0] = "Ben";
            studentsArray[1] = "Janice";

            //creating new list that is string type
            List<string> studentsList = new();

            //Adding new items to list
            studentsList.Add("Ben");
            studentsList.Add("Janice");

            foreach (string student in studentsList)
            {
                Console.WriteLine(student);
            }

            //Adding new items to list
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);

            foreach (int item in ints)
            {
                //if the number is less than 4 the loop will start again
                if (item < 4)
                {
                    continue;
                }

                Console.WriteLine(item);
            }

            //this will be looping five tiems
            for (int i = 0; i < ints.Count; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }

        static void DictionaryExample()
        {
            Dictionary<int, string> persons = new();

            persons.Add(12345, "Tuomas");
            persons.Add(4444, "Bob");

            foreach (KeyValuePair<int, string> person in persons)
            {
                if (person.Key == 4444)
                {
                    Console.WriteLine($"Key is: {person.Key}");
                    Console.WriteLine($"Value is: {person.Value}");
                }
            }

            if (persons.ContainsKey(4444))
            {
                persons.Remove(4444);
            }

            Dictionary<string, int> cities = new();

            cities.Add("Mikkeli", 50000);
            cities.Add("Berlin", 100000);
            cities.Add("New Your", 1000000);

            foreach (KeyValuePair<string, int> city in cities)
            {
                if (city.Value > 50000)
                {
                    Console.WriteLine(city.Key);
                }

            }
        }

        static void LoopDemo()
        {
            List<string> demoList = new List<string>();
            demoList.Add("Demo 1");
            demoList.Add("Demo 2");
            demoList.Add("Demo 3");
            int iteration = 0;

            //Loops all the items in list by using for technique
            for (int i = 0; i < demoList.Count; i++)
            {
                Console.WriteLine(demoList[i]);
            }

            //looops all items by using foreach technique
            foreach (string demo in demoList)
            {
                Console.WriteLine(demo);
            }
        }

        static void RemoveFromDictionary(string cityToRemove)
        {
            Dictionary<string, int> cities = new();
            cities.Add("Mikkeli", 5000000);
            cities.Add("Kuopio", 100000);
            cities.Add("Helsinki", 500000);

            if (cities.ContainsKey(cityToRemove))
            {
                cities.Remove(cityToRemove);
            }
        }


        static int? GetCityPopulation(string city)
        {
            Dictionary<string, int> cities = new();
            cities.Add("Mikkeli", 5000000);
            cities.Add("Kuopio", 100000);
            cities.Add("Helsinki", 500000);

            int? population = null;

            if (cities.ContainsKey(city))
            {
                population = cities[city];
            }
            else
            {
                Console.WriteLine("City is not found");
            }

            return population;
        }

        static void GeneralDictionaryDemo()
        {
            // 1. Create a dictionary with string keys and int values
            Dictionary<string, int> ages = new Dictionary<string, int>();

            // 2. Add elements to the dictionary
            ages.Add("Alice", 30);
            ages.Add("Bob", 25);
            ages["Charlie"] = 35; // Using indexer

            // 3. Access a value by key
            int ageOfAlice = ages["Alice"];
            Console.WriteLine($"Alice's age is {ageOfAlice}.");

            // 4. Update a value
            ages["Bob"] = 26;

            // 5. Remove an element
            ages.Remove("Charlie");

            // 6. Check if a key exists
            if (ages.ContainsKey("Bob"))
            {
                Console.WriteLine("Bob is in the dictionary.");
            }

            // 7. Iterate over the dictionary
            Console.WriteLine("Names and ages:");
            foreach (KeyValuePair<string, int> entry in ages)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            // 8. Use TryGetValue
            int age;
            if (ages.TryGetValue("David", out age))
            {
                Console.WriteLine($"David's age is {age}.");
            }
            else
            {
                Console.WriteLine("David is not in the dictionary.");
            }

            // 9. Clear the dictionary
            ages.Clear();
            Console.WriteLine($"The dictionary has {ages.Count} elements after clearing.");
        }
    }

}
