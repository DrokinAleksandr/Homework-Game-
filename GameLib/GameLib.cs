using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib
{
    public class Players
    {
        public static int UberPlayer(int number)
        {
            int n = number++;
            return n;
        }
        public static int SimplePlayer()
        {
            var rndNumber = new Random();
            int n = rndNumber.Next(40, 140);
            return n;

            //
        }
    }

}
  
