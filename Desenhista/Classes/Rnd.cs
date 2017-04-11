using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desenhista.Classes
{
    public static class Rnd
    {
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();

        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            {
                return getrandom.Next(min, max);
            }
        }
    }
}
