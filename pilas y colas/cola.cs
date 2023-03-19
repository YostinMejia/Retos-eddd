using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilas_y_colas
{
    public class Cola
    {
        private void recorrer_pila(Queue<int> pila_inicial)
        {
            foreach (int item in pila_inicial)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------");
        }

        public Queue<int> invertir_string(Queue<int> cola)
        {
            /* E4. Invertir una cola sólo usando colas */
            this.recorrer_pila(cola);

            Queue<int> aux1 = new Queue<int>();
            Queue<int> aux2 = new Queue<int>();

            foreach (int item in cola)
            {
                cola.Dequeue();
                
            }

            return cola;




        }



    }
}
