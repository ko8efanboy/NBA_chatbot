public class GoatHandler
{
    {
    public string excuseLebron = "I don't think Lebron is the GOAT because he has lost in the Finals like 80 times.";
    public string excuseKobe = "Kobe was a GOAT and absolute dawg, but he is not *THE* GOAT.\nRip Mamba.\nDefinitely top 3";
    public string excuseJordan = "Jordan played plumbers and WE DONE WITH THE 90s. AND HE HAS NO LEFT";
    public string otherResponse = "I don't know about them yet";
    public string excuseWilt = "Wilt was a great player, but he is not the GOAT.\nHe played against plumbers. \nHe was also 87 feet tall. \nWas the greatest athlete of all time though.";
    public string excuseKareem = "He got passed by Lebron in points.\nPlayed in the 70s which was the fastest-paced and highest-scoring era in NBA history.\nI will admit he did have the most unstoppable shot of all time.";
    public string excuseRussell = "Bill Russell was a civil rights legend, but if we're being real, he played with 12 Hall of Famers at a time when there were like 8 teams in the league.\n11 Rings in 13 years is crazy though\nAlso never even averaged 19 points per game LMAO";
    public string excuseJokic = "Time will tell, you might be right 15 years from now.";
    public string excuseGiannis = "Don't talk about that Greek bastard to my face";
    public string excuseTatum = "Stop talking, Steph is his daddy https://www.youtube.com//watch?v=2DWu63HgJJQ";
    public string excuseMagic = "Bro you can't be serious, he had Kareem and still doesn't even have the most assists in history.\nI will admit that baby hook game-winner was cold though.\nAll in all, not even the greatest PG of all time. Don't @ me.";
    public string excuseLarry = "Every racist white guys favorite player so not surprised he is your's too.\nPlayed with 4 Hall of Famers and still only won 3 rings.\nNot to mention Magic was better than him.\nBro literally looked like a plumber.\nIf I see someone shoot with his ugly form it will get tragic up in here.\nCan't even run the length of the court without getting tired and having a hurt back.\nThat 47 point game with his left hand was cold though even as a hater I got to admit.";
    public string excuseShaq = "If we were talking most DOMINANT ever you would be right and it wouldn't even be up for debate, but we're not so learn how to read.\nFat as hell and couldn't make a freethrow\nLess rings than Mr. MAMBA\nIf he had mamba mentality and listened to Kobe he would be the GOAT no question, not even close.\nAlso he did stay with Kobe so that is a no go for that one.\nGood try though I guess.";
    public string excuseSteph = "I mean he is the greatest shooter of all time and the greatest PG of all time but he is not even close to the GOAT.\nHe has only won 1 Finals MVP and he has lost in the Finals twice.\nHe is also a liability on defense.\nDecent though NGL.";
    public string excuseTim = "Greatest PF of all time but don't talk about that fundamental bastard to me.\nI shouldn't even talk to you with that opinion get outta here.\n5 rings and 3 Finals MVPs is good but not GOAT worthy.\nAlso he is boring as hell to watch.\nMan was the GOAT fundamental player though, still try again.";
    public string excuseYao = "what is it bas said? \n If you could see how I grown\nMoney stack taller than\nYao, Yao, Yao, Yao Ming. \n Listen to that song its so fire\n https://www.youtube.com/watch?v=g0JJsPA50G0"
    
    
    public string lebronJames = "Lebron James";
    public string kobeBryant = "Kobe Bryant";
    public string michaelJordan = "Michael Jordan";
    public string wiltChamberlain = "Wilt Chamberlain";
    public string kareemAbdul = "Kareem Abdul-Jabbar";
    public string billRussell = "Bill Russell";
    public string jokic = "Nikola Jokic";
    public string giannis = "Giannis Antetokounmpo";
    public string jaysonTatum = "Jayson Tatum";
    public string magicJohnson = "Magic Johnson";
    public string larryBird = "Larry Bird";
    public string shaquilleOneal = "Shaquille O'Neal";
    public string steph = "Steph Curry";
    public string timDuncan = "Tim Duncan";
    public string yaoMing = "Yao Ming";

    public string GetGoat(string response)
    {
        if (response.Equals("lebron", StringComparison.OrdinalIgnoreCase))
        {
            return lebronJames;
        }
        else if (response.Equals("jordan", StringComparison.OrdinalIgnoreCase))
        {
            return michaelJordan;
        }
        else if (response.Equals("kobe", StringComparison.OrdinalIgnoreCase))
        {
            return kobeBryant;
        }
        else if (response.Equals("wilt", StringComparison.OrdinalIgnoreCase))
        {
            return wiltChamberlain;
        }
        else if (response.Equals("i dont know", StringComparison.OrdinalIgnoreCase
        {
            return otherResponse;
        }
        else if (response.Equals("kareem", StringComparison.OrdinalIgnoreCase))
        {
            return kareemAbdul;
        }
        else if (response.Equals("bill russell", StringComparison.OrdinalIgnoreCase))
        {
            return billRussell;
        }
        else if (response.Equals("jokic", StringComparison.OrdinalIgnoreCase))
        {
            return jokic;
        }
        else if (response.Equals("giannis", StringComparison.OrdinalIgnoreCase))
        {
            return giannis;
        }
        else if (response.Equals("jayson tatum", StringComparison.OrdinalIgnoreCase))
        {
            return jaysonTatum;
        }
        else if (response.Equals("magic", StringComparison.OrdinalIgnoreCase))
        {
            return magicJohnson;
        }
        else if (response.Equals("larry", StringComparison.OrdinalIgnoreCase))
        {
            return larryBird;
        }
        else if (response.Equals("shaq", StringComparison.OrdinalIgnoreCase))
        {
            return shaquilleOneal;
        }
        else if (response.Equals("steph", StringComparison.OrdinalIgnoreCase))
        {
            return steph;
        }
        else if (response.Equals("tim", StringComparison.OrdinalIgnoreCase))
        {
            return timDuncan;
        }
        else if (response.Equals("yao", StringComparison.OrdinalIgnoreCase))
        {
            return yaoMing;
        }
        else
        {
            return otherResponse;
        }
    }
}
