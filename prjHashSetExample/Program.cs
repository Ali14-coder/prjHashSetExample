namespace prjHashSetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a HashSet to store unique superhero
            HashSet<string> superheroes = new HashSet<string>();

            //add some superhero to the set
            superheroes.Add("Superman");
            superheroes.Add("Wonder woman");
            superheroes.Add("Batman");
            superheroes.Add("The Flash");
            superheroes.Add("Aquaman");

            //Attempt to add a duplicate superhero
            bool added = superheroes.Add("Superman");
            Console.WriteLine($"Was Superman added again? {added}");

            //Display all superheroes in the set
            Console.WriteLine("\nList of Superheroes: ");
            foreach (string hero in superheroes)
            {
                Console.WriteLine(hero);
            }

            //Check if a specific superhero is in the set
            bool containsHero = superheroes.Contains("The Flash");
            Console.WriteLine($"\nIs the Flash in the set? { containsHero}");
        }
    }
}
