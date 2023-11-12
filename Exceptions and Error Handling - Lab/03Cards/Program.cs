using System.Text;

namespace Cards
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] args1 = input.Split(",").ToArray();
            List<Card> cards = new List<Card>();
            foreach (var kvp in args1)
            {
                string[] kvpArgs = kvp.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                try
                {
                    Card currCard = new Card(kvpArgs[0], kvpArgs[1]);
                    cards.Add(currCard);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine("Invalid card!");
                }
            }
            Console.WriteLine(String.Join(" ", cards));
        }
    }
    public class Card
    {
        private string face;

        public string Face
        {
            get 
            { 
                return face;
            }
            set 
            {
                if (!FACE.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                face = value;
            }
        }
        private string suit;

        public string Suit
        {
            get { return suit; }
            set 
            {
                if (!SUIT.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                suit = value;
            }
        }

        private static readonly List<string> FACE = new List<string>{ "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private static readonly List<string> SUIT = new List<string> { "S", "H", "D", "C" };

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Face);
            if (this.Suit == "S")
            {
                byte[] bytes = Encoding.Default.GetBytes("\u2660");
                string myString = Encoding.UTF8.GetString(bytes);
                sb.Append(myString);
            }
            else if (this.Suit == "H")
            {
                byte[] bytes = Encoding.Default.GetBytes("\u2665");
                string myString = Encoding.UTF8.GetString(bytes);
                sb.Append(myString);
            }
            else if (this.Suit == "D")
            {
                byte[] bytes = Encoding.Default.GetBytes("\u2666");
                string myString = Encoding.UTF8.GetString(bytes);
                sb.Append(myString);
            }
            else if (this.Suit == "C")
            {
                byte[] bytes = Encoding.Default.GetBytes("\u2663");
                string myString = Encoding.UTF8.GetString(bytes);
                sb.Append(myString);
            }
            return $"[{sb.ToString()}]";
        }
    }
}