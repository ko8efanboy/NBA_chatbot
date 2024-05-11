
        string intro = "Hello! Let's talk about basketball!";
        string whoGoat = "Who do you think is the NbA GOAT?";
        string excuseLebron = "I don't think Lebron is the GOAT because he has lost in the Finals too many times.";
        string otherResponse = "i dont know about them yet";
        string excuseKobe = "Kobe was a great player, but he is not the GOAT.\nRip Mamba.\nDefinitely top 3";
        string excuseJordan = "Jordan played plumbers and WE DONE WITH THE 90s. AND HE HAS NO LEFT";
        string goat = string.Empty;
        string excuseWilt = "Wilt was a great player, but he is not the GOAT.\nHe played against plumbers. \n He was also 87 feet tall. \nWas the greatest athlete of all time though.";
        string excuseKareem = "He got Passed by lebron in points, Played in 70s which was the fastest paced and highest scoring era in NBA history. \nI will admit he did have the most unstoppable shot of all time.";
        
        string lebronJames = "Lebron James";
        string kobeBryant = "Kobe Bryant";
        string michaelJordan = "Michael Jordan";
        string wiltChamberlain = "Wilt Chamberlain";
        string kareemAbdul = "Kareem Abdul-Jabbar";
        
        Console.WriteLine(intro);
        Console.ReadLine();
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
        
        