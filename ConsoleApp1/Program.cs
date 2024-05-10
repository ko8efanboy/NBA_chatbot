
        string intro = "Hello! Let's talk about basketball!";
        string whoGoat = "Who do you think is the NbA GOAT?";
        string excuseLebron = "I don't think Lebron is the GOAT because he has lost in the Finals too many times.";
        string otherResponse = "i dont know about them yet";
        string excuseKobe = "Kobe was a great player, but he is not the GOAT.\nRip Mamba.\nDefinitely top 3";
        string excuseJordan = "Jordan played plumbers and WE DONE WITH THE 90s.";
        string goat = string.Empty;
        string excuseWilt = "Wilt was a great player, but he is not the GOAT.\nHe played against plumbers. \n He was also 87 feet tall";
        
        string lebronJames = "Lebron James";
        string kobeBryant = "Kobe Bryant";
        string michaelJordan = "Michael Jordan";
        string wiltChamberlain = "Wilt Chamberlain";
        
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