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
            int nDayOff = 0,numerNotepad=0;
            bool flag = true;
            //var rndNumber = new Random();
            //int n = rndNumber.Next(40, 140
           while (flag == true)
           {
                for (int i = 0; i < mn.Length||flag!=false; ++i)
                {
                    var rndNumber = new Random();
                    int n = rndNumber.Next(40, 140);
                    if (mn[i] == n || mn[i]!=0)
                    {
                   
                        flag = false;
                    break;
                    }
                    numerNotepad = n;
                    break;
                }
                
            }
            
                return numerNotepad;

        }



    }
}


  
