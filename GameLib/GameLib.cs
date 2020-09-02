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
        public static int notepadPlayer(int[] mn)
        {
            int numerNotepad=0;
            bool flag = true;
            while (flag == true)
            {
                var rndNumber = new Random();
                int n = rndNumber.Next(40, 140);
                for (int i = 0; i <200; ++i)
                {
                    if (mn[i] == n )
                    {
                        flag = true;
                        break;
                    }
                    if (mn[i] == 0)
                    {
                        flag = false;
                        break;
                    }
                    flag = false;
                    
                }
                numerNotepad = n;
            }
                return numerNotepad;
        }
        public static int cheatPlayer(int[] mn)
        {
            
            int numerCheat = 0;
            bool flag = true;
            
            while (flag == true)
            {
             var rndNumber = new Random();
             int n = rndNumber.Next(40, 140);

                for (int i = 0; i < 200; ++i)
                {
                    if (mn[i] == n)
                    {
                        flag = true;
                        break;
                    }
                   flag = false;
                }
                numerCheat = n;
            }
            return numerCheat;
        }
        public static int ubercheatPlayer(int[] mn, int n)
        {
            
            int numerUberCheat = 0;
            bool flag = true;
            while (flag == true)
            {
                for (int i = 0; i < 200; ++i)
                {
                   
                    if (mn[i] == n )
                    {

                        flag = true;
                        break;
                    }
                    flag = false;
                }
                numerUberCheat = n;
            }
            return numerUberCheat++;
        }
    }
}


  
