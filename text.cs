using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    internal class text:player
    {
        public void player(playername, lifePlayer)
        {
            int opcion;
            Console.WriteLine($"{playername} despiertas en un bosque y te empieza a dar sed, por un lado vez un charco de agua y en otro lado vez arriba de una roca un vaso de agua");
            Console.WriteLine("1.tomar Agua del vaso");
            Console.WriteLine("2.tomar agua del charco");
            opcion=int.Parse(Console.ReadLine());
            if(opcion==1)
            {
                Console.WriteLine("bebes agua fresca, te sientes sin sed");
            }
            else
            {
                Console.WriteLine($"bebes agua del charco, te sientes un poco mal (te quefan {lifePlayer} vidas)");
            }

            Console.WriteLine($"{playername} te empieza a dar hambre vez una manzana en el suelo y en otro lado vez un bistec");
            Console.WriteLine("1.agarrar el bistec");
            Console.WriteLine("2.agarrar la manzana");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine($"al agarar el bistec una trampa de oso te atrapa la mano , sin embargo logras sacar la mano con el bistec(tu vida actual es {lifePlayer})");
            }
            else
            {
                Console.WriteLine($"te comenz la manzana, ya no tienes hambre");
            }

            Console.WriteLine($"{playername} te empieza a dar sueño miras por cualquier lado buscando refugio, te encuentras una cueva y luego encuentras un lugar donda hay un monton de paja");
            Console.WriteLine("1.dormir en la cueva");
            Console.WriteLine("2.dormir en la paja");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                if (lifePlayer <= 1)
                {
                    Console.WriteLine("duermes en la cueva y das tu ultimo aliento");
                }
                else
                {
                    Console.WriteLine("pasa la noche en la cueva y en eñ siguiente dia te encuentras en el bosque de nuevo");
                }

            }
            else
            {
                Console.WriteLine($"duermes en la paja, al dia siguiente despiertas en tu cama");
            }

        }

    }
}
