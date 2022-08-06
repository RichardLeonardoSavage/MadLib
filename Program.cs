namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {

            string color, pluralNoun, celebrity, breath;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.Write(" What are ogres like? ");
            breath = Console.ReadLine();




            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
            Console.WriteLine("My breath smells like " + breath); 

            Console.ReadLine();
        }
    }
}