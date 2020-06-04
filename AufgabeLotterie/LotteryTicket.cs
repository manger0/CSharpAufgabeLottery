using System;
namespace AufgabeLotterie
{
    public class LotteryTicket
    {
        public string Ticket;
        public LotteryTicket(string RndTicket)
        {
            Ticket = RndTicket;
        }

        public bool CheckTicket(string UserNumbers)
        {
            if (UserNumbers.Equals(Ticket))
            {
                return true;
            }
            return false;
        }

        public string ReturnTicket()
        {
            return "You won!, Ticket number: " + Ticket;
        }

        public string Digits(string UsersNumbers)
        {
            int Digits = 0;

            for(int i = 0; i < UsersNumbers.Length; i++)
            {
                if (UsersNumbers[i].Equals(Ticket[i]))
                {
                    Digits++;
                }
            }
            return "You got " + Digits + " right!";
        }
          
    }
}
