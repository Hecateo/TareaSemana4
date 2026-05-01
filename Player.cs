using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tarea4
{
    internal class Player
    {
        public string playername;
        public int lifePlayer=3;
        public void run()
        {
            Console.WriteLine("Introdusca su nombre:");
            playername = Console.ReadLine();

            lifePlayer = 3;
            Console.WriteLine($"Su nombre es {playername} y su cantidad de vida es {lifePlayer}");
        }

    }
}
