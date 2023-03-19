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

            
            /*Stack<int> stack = new Stack<int>();
            for(int i = 1; i<=10; i++)
            {
                stack.Push(i);
            }*/


            //Pila pila= new Pila();
            //pila.recorrer_pila(stack);

            //pila.invertir_pila(stack);
            //Console.WriteLine(pila.E2(stack));
            //Console.WriteLine(pila.E3("(())"));

            
            Queue<int> queue1 = new Queue<int>();
            
            for (int i = 1; i <= 3; i++)
            {
                queue1.Enqueue(i);
            }
            Queue<int> queue2 = new Queue<int>();

            for (int i = 10; i <=30; i+=10)
            {
                queue2.Enqueue(i);
            }

            Cola cola = new Cola();

            //Console.WriteLine(cola.combine_values(queue1, queue2));

            Console.WriteLine(cola.E6(queue2, 2));
            

        }
    }
}
