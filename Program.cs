using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> eastAsia = new Queue<string>();
            eastAsia.Enqueue("Taipei");
            eastAsia.Enqueue("Beijing");
            eastAsia.Enqueue("Tokyo");
            eastAsia.Enqueue("Seoul");
            eastAsia.Enqueue("Ulaanbaatar");
            Console.Write("Country Capital Quiz!\nEnter any capital you know in East Asia: ");
            string eCapital = Console.ReadLine();
            if (eastAsia.Contains(eCapital))
                Console.WriteLine($"Nice! {eCapital} is one of the capitals in East Asia!");
            else
                Console.WriteLine($"Wrong. {eCapital} is not a capital in East Asia.");
            eastAsia.Dequeue();
            Console.WriteLine("\n**************************************************");
            Console.WriteLine($" Here is the number of capitals in East Asia: {eastAsia.Count()}");
            Console.WriteLine(" Here are the capitals in East Asia.\n");
            foreach(string e in eastAsia)
                Console.WriteLine("\t" + e);

            PriorityQueue<string, int> ncAsia = new PriorityQueue<string, int>();
            ncAsia.Enqueue("Astana", 2);
            ncAsia.Enqueue("Tashkent", 6);
            ncAsia.Enqueue("Dushanbe", 4);
            ncAsia.Enqueue("Moscow", 1);
            ncAsia.Enqueue("Ashgabat", 5);
            ncAsia.Enqueue("Bishkek", 3);
            Console.WriteLine("\n**************************************************");
            Console.WriteLine(" Here is the capital in North Asia.\n");
            Console.WriteLine($"\t{ncAsia.Peek()}");
            ncAsia.Dequeue();
            Console.WriteLine("\n**************************************************");
            Console.WriteLine(" Here are the capitals in Central Asia.\n");
            while (ncAsia.TryDequeue(out string c, out int p))
                Console.WriteLine("\t" + c);

            Stack<string> southAsia = new Stack<string>();
            southAsia.Push("Sri Jayawardenepura Kotte");
            southAsia.Push("Islamabad");
            southAsia.Push("Kathmandu");
            southAsia.Push("Male");
            southAsia.Push("New Delhi");
            southAsia.Push("Thimphu");
            southAsia.Push("Dhaka");
            southAsia.Push("Kabul");
            Console.Write("\n\nEnter any capital you know in South Asia: ");
            string sCapital = Console.ReadLine();
            if (southAsia.Contains(sCapital))
                Console.WriteLine($"Nice! {sCapital} is one of the capitals in South Asia!");
            else
                Console.WriteLine($"Wrong. {sCapital} is not a capital in South Asia.");
            southAsia.Pop();
            Console.WriteLine("\n**************************************************");
            Console.WriteLine($" Here is the number of capitals in South Asia: {southAsia.Count()}");
            Console.WriteLine(" Here are the capitals in South Asia.\n");
            foreach (string s in southAsia)
                Console.WriteLine("\t" + s);

            LinkedList<string> westAsia = new LinkedList<string>();
            westAsia.AddFirst("Ankara");
            westAsia.AddLast("North Nicosia");
            westAsia.AddLast("Yerevan");
            westAsia.AddLast("Baku");
            westAsia.AddLast("Cairo");
            Console.WriteLine("\n**************************************************");
            Console.WriteLine($" Here is the capital in Anatolia region in West Asia: {westAsia.First.Value}");
            Console.WriteLine($" Here is the capital in Sinai Peninsula region in West Asia: {westAsia.Last.Value}");
            LinkedListNode<string> m = westAsia.Find("Yerevan");
            westAsia.AddAfter(m, "Tbilisi");
            westAsia.Remove("North Nicosia");
            Console.WriteLine($" Here is the number of capitals in Anatolia, South Caucasus, and Sinai Peninsula regions in West Asia: {westAsia.Count()}");
            Console.WriteLine(" Here are the capitals in Anatolia, South Caucasus, and Sinai Peninsula regions in West Asia.\n");
            foreach (string w in westAsia)
                Console.WriteLine($"\t" + w);

            Dictionary<string, string> owAsia = new Dictionary<string, string>();
            owAsia.Add("Bahrain", "Manama");
            owAsia.Add("Kuwait", "Kuwait City");
            owAsia.Add("Oman", "Muscat");
            owAsia.Add("Qatar", "Doha");
            owAsia.Add("Saudi Arabia", "Riyadh");
            owAsia.Add("United Arab Emirates", "Abu Dhabi");
            owAsia.Add("Yemen", "Sanaa");
            Console.WriteLine("\n**************************************************");
            Console.WriteLine(" Here are the countries in Arabian Peninsula region in West Asia.\n");
            foreach(string key in owAsia.Keys)
                Console.WriteLine($"\t{key}");
            Console.WriteLine("\n**************************************************");
            Console.WriteLine(" Here are the capitals in Arabian Peninsula region in West Asia.\n");
            foreach (string value in owAsia.Values)
                Console.WriteLine($"\t{value}");
            Console.WriteLine("\n**************************************************");
            Console.WriteLine(" Here are the countries and the capitals in Arabian Peninsula region in West Asia.\n");
            foreach (KeyValuePair<string, string> kvp in owAsia)
                Console.WriteLine($"\tCountry: {kvp.Key} - Capital: {kvp.Value}");
            owAsia.Remove("Yemen");
            Console.WriteLine($"\n Here is the number of countries in Arabian Peninsula region in West Asia after removing Yemen from the list: {owAsia.Count()}");

            SortedList<string, string> america = new SortedList<string, string>();
            america.Add("United States", "Washington, D.C.");
            america.Add("Canada", "Ottawa");
            america.Add("Mexico", "Mexico City");
            america.Add("The Bahamas", "Nassau");
            america.Add("Belize", "Belmopan");
            Console.Write("\n\nEnter any country you know in Central America: ");
            string country = Console.ReadLine();
            Console.Write($"Enter the capital of {country}: ");
            string capital = Console.ReadLine();
            if (america.ContainsKey(country))
                america.Remove(country);
            else
                america.Remove("Belize");
            america.Add(country, capital);
            Console.WriteLine("\n**************************************************");
            Console.WriteLine(" Here are the countries and the capitals in America.\n");
            foreach (KeyValuePair<string, string> kvp in america)
                Console.WriteLine($"\tCountry: {kvp.Key} - Capital: {kvp.Value}");

            HashSet<string> antilles = new HashSet<string>();
            antilles.Add("Cayman Islands");
            antilles.Add("Cuba");
            antilles.Add("Dominican Republic");
            antilles.Add("Jamaica");
            antilles.Add("Navassa Island");

            HashSet<string> lAntilles = new HashSet<string>();
            lAntilles.Add("Antigua and Barbuda");
            lAntilles.Add("Barbados");
            lAntilles.Add("Dominica");
            lAntilles.Add("Grenada");
            lAntilles.Add("Saint Kitts and Nevis");

            HashSet<string> spanish = new HashSet<string>();
            spanish.Add("Cuba");
            spanish.Add("Costa Rica");
            spanish.Add("Dominican Republic");
            spanish.Add("El Salvador");
            spanish.Add("Guatemala");

            antilles.UnionWith(lAntilles);
            Console.WriteLine("\n**************************************************");
            Console.WriteLine(" Here are the countries in Antilles.\n");
            foreach (string a in antilles)
                Console.WriteLine($"\t{a}");

            HashSet<string> sAntilles = new HashSet<string>();
            sAntilles = antilles;
            sAntilles.IntersectWith(spanish);
            Console.WriteLine("\n**************************************************");
            Console.WriteLine(" Here are the Spanish speaking countries in Antilles.\n");
            foreach (string s in sAntilles)
                Console.WriteLine($"\t{s}");

            List<string> wwAsia = new List<string>();
            wwAsia.Add("Baghdad");
            wwAsia.Add("Jerusalem");
            wwAsia.Add("Amman");
            wwAsia.Add("Beirut");
            wwAsia.Add("Ramallah");
            string[] west = new string[] { "Damascus", "Tehran", "Nicosia" };
            wwAsia.AddRange(west);
            wwAsia.Sort();
            Console.WriteLine("\n**************************************************");
            Console.WriteLine(" Here are the capitals in Fertile Crescent, Iranian Plateau, and Mediterranean Sea regions in West Asia.\n");
            foreach (string w in wwAsia)
                Console.WriteLine("\t" + w);
            wwAsia.Remove("Amman");
            wwAsia.Reverse();
            Console.WriteLine("\n**************************************************");
            Console.WriteLine(" Here is the reversed list after removing Amman.\n");
            foreach (string r in wwAsia)
                Console.WriteLine("\t" + r);
        }
    }
}
