using System;

public class Program
{
    public static void Main(string[] args)
    {
        GoatHandler handler = new GoatHandler();

        string intro = "Hello! Let's talk about basketball!";
        string whoGoat = "Who do you think is the NBA GOAT?";
        string keepGoing = "Do you want to discuss anyone else?";

        My_label:
        {
            Console.WriteLine(intro);
            Console.WriteLine(whoGoat);
            string response = Console.ReadLine();

            string goat = handler.GetGoat(response);

            if (goat == handler.lebronJames)
            {
                Console.WriteLine(handler.excuseLebron);
            }
            else if (goat == handler.michaelJordan)
            {
                Console.WriteLine(handler.excuseJordan);
            }
            else if (goat == handler.kobeBryant)
            {
                Console.WriteLine(handler.excuseKobe);
            }
            else if (goat == handler.wiltChamberlain)
            {
                Console.WriteLine(handler.excuseWilt);
            }
            else if (goat == handler.kareemAbdul)
            {
                Console.WriteLine(handler.excuseKareem);
            }
            else if (goat == handler.billRussell)
            {
                Console.WriteLine(handler.excuseRussell);
            }
            else if (goat == handler.jokic)
            {
                Console.WriteLine(handler.excuseJokic);
            }
            else if (goat == handler.giannis)
            {
                Console.WriteLine(handler.excuseGiannis);
            }
            else if (goat == handler.jaysonTatum)
            {
                Console.WriteLine(handler.excuseTatum);
            }
            else if (goat == handler.magicJohnson)
            {
                Console.WriteLine(handler.excuseMagic);
            }
            else if (goat == handler.larryBird)
            {
                Console.WriteLine(handler.excuseLarry);
            }
            else if (goat == handler.shaquilleOneal)
            {
                Console.WriteLine(handler.excuseShaq);
            }
            else if (goat == handler.steph)
            {
                Console.WriteLine(handler.excuseSteph);
            }
            else if (goat == handler.timDuncan)
            {
                Console.WriteLine(handler.excuseTim);
            }
            else if (goar == handler.yaoMing)
            {
                Console.WriteLine(handler.excuseYao)
            }
            else if (goat == handler.otherResponse)
            {
                Console.WriteLine("That's a trash choice, and they are irrelevant (DM me on Discord if I just forgot about them)");
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
