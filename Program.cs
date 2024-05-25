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
        string excuseLarry = "every racist white guys favorite player so not suprised he is your's too.\n played with 4 hall of famers and still only won 3 rings.\n not to mention magic was better than him.\n bro litteraly looked like a plumber.\n if i see someone shoot with his ugly form i am going it will get tragic up in here.\n cant even run the length of the court without getting tired and having a hurt back.\n that 47 point game with his left hand was cold though even as a hater i got to admit";
        string excuseShaq = "If we were talking most DOMINANT ever you would be right and it wouldnt even be up for debate, but we're not so learn how to read. \n fat as hell and couldnt make a freethrow \n less rings then Mr. MAMBA\n if he had mamba mentality and listened to kobe he would be the goat no question, not even close\n also he did stay with kobe so that is a no go for for that one.\n good try tho i guess.";
        string excuseSteph = "I mean he is the greatest shooter of all time and the greatest PG of all time but he is not even close to the goat.\nHe has only won 1 Finals MVP and he has lost in the Finals twice.\nHe is also a liability on defense.\n decent though NGL.";
        string excuseTim = "Greatest PF of all time but dont talk about that fundemantal bastard to me \n i shouldnt even talk to you with that opinion get outa here.\n 5 rings and 3 finals mvps is good but not goat worthy.\n also he is boring as hell to watch.\n man was the goat fundamental player tho, still try again.";

        string lebronJames = "Lebron James";
        string kobeBryant = "Kobe Bryant";
        string michaelJordan = "Michael Jordan";
        string wiltChamberlain = "Wilt Chamberlain";
        string kareemAbdul = "Kareem Abdul-Jabbar";
        string billRussell = "Bill Russell";
        string jokic = "Nikola Jokic";
        string giannis = "Giannis Antetokounmpo";
        string jaysonTatum = "Jayson Tatum";
        string magicJohnson = "Magic Johnson";
        string larryBird = "Larry Bird";
        string shaquilleOneal = "Shaquille O'Neal";
        string steph = "Steph Curry";
        string timDuncan = "Tim Duncan";
        
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
                goat = magicJohnson;
            }
            else if (response.Equals("larry", StringComparison.OrdinalIgnoreCase))
            {
                goat = larryBird;
            }
            else if (response.Equals("shaq", StringComparison.OrdinalIgnoreCase))
            {
                goat = shaquilleOneal;
            }
            else if (response.Equals("steph", StringComparison.OrdinalIgnoreCase))
            {
                goat = steph;
            }
            else if (response.Equals("tim", StringComparison.OrdinalIgnoreCase))
            {
                goat = timDuncan;
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
            else if (goat == magicJohnson)
            {
                Console.WriteLine(excuseMagic);
            }
            else if (goat == larryBird)
            {
                Console.WriteLine(excuseLarry);
            }
            else if (goat == shaquilleOneal)
            {
                Console.WriteLine(excuseShaq);
            }
            else if (goat == steph)
            {
                Console.WriteLine(excuseSteph);
            }
            else if (goat == timDuncan)
            {
                Console.WriteLine(excuseTim);
            }
            else if (goat == otherResponse)
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
