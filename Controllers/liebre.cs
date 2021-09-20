using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TYL_LASEC.Controllers
{
    public class liebre : Controller
    {
       
            int i = 0;
            int distancia = 10;
            public int posicion = 0;


        public void liebrerun()
            {
              
                Thread.Sleep(2000);
                Console.WriteLine("La liebre sale de la meta " + "\n");
                while (i < distancia)
                {

                    if (i == ((distancia / 2)))
                    {
                        Console.WriteLine("la liebre llego a la mitad y como ve que la tortuga va lento se confia y se queda dormida debajo de un arbol " + "\n");
                        Thread.Sleep((2000 * (distancia)) + 1000);

                    }
                    posicion = i + 1;

                    Thread.Sleep(2000);
                    Console.WriteLine("La liebre despierta y al ver que la tortuga casi esta en la meta corre lo mas rapido posible " + posicion + "\n"); i++;


                }

                Console.WriteLine("La liebre no alcanza a llegar y queda en segundo lugar " + "\n");

            }
        }
    
}
