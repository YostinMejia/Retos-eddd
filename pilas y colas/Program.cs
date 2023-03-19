using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace pilas_y_colas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Stack<int> stack = new Stack<int>();
            for(int i = 10; i>=1; i--)
            {
                stack.Push(i);
            }


            Pila pila= new Pila();*/

            //pila.invertir_pila(stack);
            //Console.WriteLine(pila.E2(stack));
            //Console.WriteLine(pila.E3("(())"));

            
            Queue<int> queue = new Queue<int>();
            
            for (int i = 1; i <= 10; i++)
            {
                queue.Enqueue(i);
            }

            Cola cola = new Cola();

            cola.invertir_string(queue);
            

        }
    }
}
