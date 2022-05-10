namespace Spotiflix
{
    public class Program
    {
        public void Main(string[] args)
        {
            char input;
            string keyword;
            bool check;

            do
            {
                Console.Clear();
                Console.WriteLine("Choose how to search below" +
                 "\n\nGeneric search   - '1'" +
                 "\nSpecified search - '2'");
                input = Console.ReadKey().KeyChar;

                if (input == '1' || input == '2')
                {
                    check = true;
                }
                else
                {
                    Console.Clear();
                    Console.Write("Invalid input, please pick a valid input from the menu" +
                        "\npress any key to return to the menu");
                    Console.ReadKey();
                    check = false;
                }
            } while (!check);

            if (input == '1') //Generic search
            {
                keyword = "Keyword: ";
            }
            else //Specified search
            {
                //Kald relavant menu
            }
        }
    }
}