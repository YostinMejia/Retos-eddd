using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilas_y_colas
{
    public class Cola
    {
        private void recorrer_cola(Queue<int> cola_inicial)
        {
            foreach(int cola in cola_inicial)
            {
                Console.WriteLine(cola);
            }

            Console.WriteLine("-------------");
        }
        /* E4. Invertir una cola sólo usando colas 
        public void invertir_string(Queue<int> cola)
        {
           
            this.recorrer_cola(cola);

            if(cola.Count<=0) {
                return;
            }

            int numero = cola.Dequeue();
            
            invertir_string_recursividad(cola);
            cola.Enqueue(numero);
        }*/


      
        private Stack<int> queue_to_reverse_stack(Queue<int> cola_inicial)
        {
            Stack<int> stack = new Stack<int>();

            while (cola_inicial.Count > 0 )
            {
                stack.Push(cola_inicial.Dequeue());
            }
            Pila pila = new Pila();

            return stack;

        }
        /* E5. Escriba una función que reciba dos colas q1 y q2 y retorne a q1 con los elementos de q1 y q2 combinados 
       * tal que después de cada elemento de q1 aparece el elemento de q2 en su posición inversa. 
       * Por ejemplo, si q1 es [1,2,3] y q2 es [10,20,30], la función debe retornar a q1 siendo [1,30,2,20,3,10], es decir, 
       * el primero de q1 seguido del último de q2 y así sucesivamente.
       * Asuma que el tamaño de ambas colas es el mismo. Puede usar pilas para apoyar la solución pero no puede usar más colas.*/
        public Queue<int> combine_values(Queue<int> q1, Queue<int> q2)
        {

            Pila pila = new Pila();
            Stack<int> stack_auxiliar = new Stack<int>();

            int q1_eliminado;
            int q2_eliminado;

            Console.WriteLine("Cola q1 inicial");
            this.recorrer_cola(q1);
            Console.WriteLine("Cola q2 inicial");
            this.recorrer_cola(q2);
            while (q1.Count > 0)
            {
                q1_eliminado = q1.Dequeue();
                q2_eliminado = q2.Dequeue();
                stack_auxiliar.Push(q1_eliminado);
                stack_auxiliar.Push(q2_eliminado);
                Console.WriteLine("Elemento q1 eliminado");
                Console.WriteLine(q1_eliminado);
                Console.WriteLine("Elemento q2 eliminado");
                Console.WriteLine(q2_eliminado);
                Console.WriteLine("elementos agregados a la pila auxuiliar");
                pila.recorrer_pila(stack_auxiliar);
            }
            Console.WriteLine("------------stack formado con q1 y q2------------");
            pila.recorrer_pila(stack_auxiliar);
            stack_auxiliar = pila.invertir_pila(stack_auxiliar);
            Console.WriteLine("------------stack invertido formado con q1 y q2------------");
            pila.recorrer_pila(stack_auxiliar);

            while (stack_auxiliar.Count > 0)
            {
                q1.Enqueue(stack_auxiliar.Pop());
            }
            Console.WriteLine("q1 final");
            this.recorrer_cola(q1);

            return q1;
        }

    }
}
