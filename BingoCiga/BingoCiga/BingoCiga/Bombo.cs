using System;
using System.Collections.Generic;
using Gtk;

namespace BingoCiga
{
    public class Bombo
    {
        private IList<int> bolas = new List<int>();
        private Random random = new Random();

        public Bombo()
        {
            for (int i = 1; i <= 90; i++)
            bolas.Add(i);
            
        }
        public int sacarBola()
        {
            int indexAleatorio = random.Next(bolas.Count);
            int bola = bolas[indexAleatorio];
            bolas.RemoveAt(indexAleatorio);
            return bola;
        }
    }

}