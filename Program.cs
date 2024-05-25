using System;

public class Program
{
    public static void Main(string[] args)
    {
        string intro = "Hello! Let's talk about basketball!";
        string whoGoat = "Who do you think is the NBA GOAT?";
        string excuseLebron = "I don't think Lebron is the GOAT because he has lost in the Finals too many times.";
        string otherResponse = "I don't know about them yet";
        string excuseKobe = "Kobe was a great player, but he is not the GOAT.\nRip Mamba.\nDefinitely top 3";
        string excuseJordan = "Jordan played plumbers and WE DONE WITH THE 90s. AND HE HAS NO LEFT";
        string goat = string.Empty;
        string keepGoing = "Do you want to discuss anyone else?";
        string excuseWilt = "Wilt was a great player, but he is not the GOAT.\nHe played against plumbers. \nHe was also 87 feet tall. \nWas the greatest athlete of all time though.";
        string excuseKareem = "He got passed by Lebron in points.\nPlayed in the 70s which was the fastest-paced and highest-scoring era in NBA history.\nI will admit he did have the most unstoppable shot of all time.";
        string excuseRussell = "Bill Russell was a civil rights legend, but if we're being real, he played with 12 Hall of Famers at a time when there were like 8 teams in the league.\n11 Rings in 13 years is crazy though\nAlso never even averaged 19 points per game LMAO";
        string excuseJokic = "Time will tell, you might be right 15 years from now.";
        string excuseGiannis = "Don't talk about that Greek bastard to my face";
        string excuseTatum = "Stop talking, Steph is his daddy https://www.youtube.com//watch?v=2DWu63HgJJQ";
        string excuseMagic = "Bro you can't be serious, he had Kareem and still doesn't even have the most assists in history.\nI will admit that baby hook game-winner was cold though.\nAll in all, not even the greatest PG of all time. Don't @ me.";

        string lebronJames = "Lebron James";
        string kobeBryant = "Kobe Bryant";
        string michaelJordan = "Michael Jordan";
        string wiltChamberlain = "Wilt Chamberlain";
        string kareemAbdul = "Kareem Abdul-Jabbar";
        string billRussell = "Bill Russell";
        string jokic = "Nikola Jokic";
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
            else if (response.Equals("jordan", StringComparison.OrdinalIgnoreCase))
            {
                goat = michaelJordan;
            }
            else if (response.Equals("kobe", StringComparison.OrdinalIgnoreCase))
            {
                goat = kobeBryant;
            }
            else if (response.Equals("wilt", StringComparison.OrdinalIgnoreCase))
            {
                goat = wiltChamberlain;
            }
            else if (response.Equals("i dont know", StringComparison.OrdinalIgnoreCase))
            {
                goat = otherResponse;
            }
            else if (response.Equals("kareem", StringComparison.OrdinalIgnoreCase))
            {
                goat = kareemAbdul;
            }
            else if (response.Equals("bill russell", StringComparison.OrdinalIgnoreCase))
            {
                goat = billRussell;
            }
            else if (response.Equals("jokic", StringComparison.OrdinalIgnoreCase))
            {
                goat = jokic;
            }
            else if (response.Equals("giannis", StringComparison.OrdinalIgnoreCase))
            {
                goat = giannis;
            }
            else if (response.Equals("jayson tatum", StringComparison.OrdinalIgnoreCase))
            {
                goat = jaysonTatum;
            }
            else if (response.Equals("magic", StringComparison.OrdinalIgnoreCase))
            {
                goat = "Magic Johnson";
            }

            if (goat == lebronJames)
            {
                Console.WriteLine(excuseLebron);
            }
            else if (goat == michaelJordan)
            {
                Console.WriteLine(excuseJordan);
            }
            else if (goat == kobeBryant)
            {
                Console.WriteLine(excuseKobe);
            }
            else if (goat == wiltChamberlain)
            {
                Console.WriteLine(excuseWilt);
            }
            else if (goat == kareemAbdul)
            {
                Console.WriteLine(excuseKareem);
            }
            else if (goat == billRussell)
            {
                Console.WriteLine(excuseRussell);
            }
            else if (goat == jokic)
            {
                Console.WriteLine(excuseJokic);
            }
            else if (goat == giannis)
            {
                Console.WriteLine(excuseGiannis);
            }
            else if (goat == jaysonTatum)
            {
                Console.WriteLine(excuseTatum);
            }
            else if (goat == "Magic Johnson")
            {
                Console.WriteLine(excuseMagic);
            }
            else
            {
                Console.WriteLine("That's an interesting choice, but I don't have an opinion on them.");
            }

            Console.WriteLine(keepGoing);
            string continueAnswerStr = Console.ReadLine();
            if (continueAnswerStr.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                goto My_label;
            }
        }
    }
}
