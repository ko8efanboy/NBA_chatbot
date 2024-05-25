internal class Program
{
    public static void Main(string[] args)
    {
        string intro = "Hello! Let's talk about basketball!";
        string whoGoat = "Who do you think is the NBA GOAT?";
        string excuseLebron =
            "I don't think Lebron is the GOAT because he has lost in the Finals too many times.";
        string otherResponse = "I dont know about them yet";
        string excuseKobe =
            "Kobe was a great player, but he is not the GOAT.\nRip Mamba.\nDefinitely top 3";
        string excuseJordan = "Jordan played plumbers and WE DONE WITH THE 90s. AND HE HAS NO LEFT";
        string goat = string.Empty;
        string keepGoing =  "do you want to discuss anyone else?";
        string excuseWilt =
            "Wilt was a great player, but he is not the GOAT.\nHe played against plumbers. \nHe was also 87 feet tall. \nWas the greatest athlete of all time though.";
        string excuseKareem =
            "He got Passed by lebron in points \nPlayed in 70s which was the fastest paced and highest scoring era in NBA history. \nI will admit he did have the most unstoppable shot of all time.";
        string excuseRussell =
            "Bill Russell was a civil rights legend but if we being real he played with 12 hall of famers at a time where there was like 8 teams in the leauge. \n11 Rings in 13 years is crazy though\nAlso never even average 19 points per game LMAO";
        string excuseJokic = "time will tell, you might be right 15 years from now.";
        string excuseGiannis = "Dont talk about that greek bastard to my face";
        string excuseTatum = "Stop talking steph is his daddy https://www.youtube.com//watch?v=2DWu63HgJJQ"

        string lebronJames = "Lebron James";
        string kobeBryant = "Kobe Bryant";
        string michaelJordan = "Michael Jordan";
        string wiltChamberlain = "Wilt Chamberlain";
        string kareemAbdul = "Kareem Abdul-Jabbar";
        string billRussell = "Bill Russell";
        string jokic = "Nikola Jokic"
        string giannis = "Giannis Antetokounmpo";
        string jaysonTatum = "Jayson Tatum";

        My_label:
        {
            Console.WriteLine(intro);
            Console.WriteLine(whoGoat);
            string response = Console.ReadLine();

            if (response.Equals("lebron", StringComparison.OrdinalIgnoreCase))
            {
                goat = lebronJames;
            }

            if (response.Equals("jordan", StringComparison.OrdinalIgnoreCase))
            {
                goat = michaelJordan;
            }

            if (response.Equals("kobe", StringComparison.OrdinalIgnoreCase))
            {
                goat = kobeBryant;
            }

            if (response.Equals("wilt", StringComparison.OrdinalIgnoreCase))
            {
                goat = wiltChamberlain;
            }

            if (response.Equals("i dont know", StringComparison.OrdinalIgnoreCase))
            {
                goat = otherResponse;
            }

            if (response.Equals("kareem", StringComparison.OrdinalIgnoreCase))
            {
                goat = kareemAbdul;
            }

            if (response.Equals("bill russell", StringComparison.OrdinalIgnoreCase))
            {
                goat = billRussell;
            }

            if (goat == lebronJames)
            {
                Console.WriteLine(excuseLebron);
            }

            if (goat == lebronJames)
            {
                Console.WriteLine(excuseJordan);
            }

            if (goat == kobeBryant)
            {
                Console.WriteLine(excuseKobe);
            }

            if (goat == wiltChamberlain)
            {
                Console.WriteLine(excuseWilt);
            }

            if (goat == kareemAbdul)
            {
                Console.WriteLine(excuseKareem);
            }

            if (goat == billRussell)
            {
                Console.WriteLine(excuseRussell);
            }
            if (goat == jokic)
            {
                Console.WriteLine(excuseJokic);
            }
            if (goat == giannis)
            {
                Console.WriteLine(excuseGiannis);
            }

            { }
            Console.WriteLine(keepGoing);
            string continueAnswerStr = Console.ReadLine();
            if (continueAnswerStr.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                goto My_label;
            }
        }
    }
}
