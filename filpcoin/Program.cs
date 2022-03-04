using System;

namespace filpcoin
{
    internal class FlipCoin
    {
        int headcount = 0;
        int tailcount = 0;
        public string FlipCoinMethod(int userinput)
        {
            Random r = new Random();
            while (userinput !=0)
            {
                double random=r.NextDouble();

                if (random <= 0.5)
                {
                    tailcount = tailcount + 1;
                }
                else
                {
                    headcount ++;  
                }
                userinput = userinput - 1;
            }
            return "%";
        }
    }
}