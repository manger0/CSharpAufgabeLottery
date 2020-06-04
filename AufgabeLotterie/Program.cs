using System;

namespace AufgabeLotterie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Match;
            Random Random = new Random();
            string RndTicket = Convert.ToString(Random.Next(100000, 1000000));
            Console.WriteLine(RndTicket);
            LotteryTicket RandomTicket = new LotteryTicket(RndTicket);
            do
            {
                Console.WriteLine("6 stelliges Ticket oder exit eingeben");
                string Choice = Console.ReadLine();
                if (Choice != "exit" && Choice.Length == 6)
                {
                    Match = RandomTicket.CheckTicket(Choice);
                    if (Match)
                    {
                        Console.WriteLine(RandomTicket.ReturnTicket());
                        
                    } else
                    {
                        Console.WriteLine(RandomTicket.Digits(Choice));
                    }

                } else
                {
                    Match = true;
                }
            } while (!Match);
            Console.WriteLine("Lottery exit");
        }
    }
}
