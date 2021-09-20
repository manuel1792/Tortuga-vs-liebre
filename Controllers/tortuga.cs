using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TYL_LASEC.Controllers
{
    public class tortuga : Controller
    {
        int distancia = 10;
        int i = 0;
        public int posicion = 0;


        public void tortugarun()
        {
            
            Thread.Sleep(2000);
            Console.WriteLine("La tortuga arranca a un paso lento pero seguro " + "\n");
            while (i < distancia)
            {
                if (i == ((distancia / 2)))
                {
                    Console.WriteLine("la tortuga llego a la mitad  y paso en silencio para no despertar a la liebre " + "\n");

                }

                posicion = i + 1;

                Thread.Sleep(4000);
                Console.WriteLine("la tortuga avanza lento pero seguro " + posicion + "\n");

                i++;
            }
             
            Console.WriteLine("La tortuga termina la carrera " + "\n");

        }
    }
}
