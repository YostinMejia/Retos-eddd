using System;
using System.Collections.Generic;

namespace pilas_y_colas
{
    internal class Pila
    {
        /* E1 Escriba una función que invierta una pila. Sólo puede usar pilas*/

        public void recorrer_pila(Stack<int> pila_inicial)
        {
            foreach (int item in pila_inicial)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------");
        }

        public Stack<int> invertir_pila(Stack<int> pila_inicial)
        {

            this.recorrer_pila(pila_inicial);

            Stack<int> pila_invertida = new Stack<int>();

            Stack<int> pila_normal = new Stack<int>();

            while (pila_inicial.Count > 0)
            {
                pila_invertida.Push(pila_inicial.Pop());

            }

            while (pila_invertida.Count > 0)
            {
                pila_normal.Push(pila_invertida.Pop());
            }

            while (pila_normal.Count > 0)
            {
                pila_inicial.Push(pila_normal.Pop());
            }


            recorrer_pila(pila_inicial);

            return pila_inicial;
        }

        /* E2. Escriba una función para saber si una pila está ordenada ascendentemente desde el tope. */

        private bool E2_recursion(Stack<int> pila_inicial, int valor1)
        {

            if(pila_inicial.Count == 0 )
            {
                return true;
            }

            int valor2 = pila_inicial.Pop();
            Console.WriteLine($"{valor1} < {valor2} {valor1 < valor2} ");

            if (valor1 < valor2)
            {
                return false;
            }

            valor2 = valor1;

            return E2_recursion(pila_inicial, valor1 );

        }
        public bool E2(Stack<int> pila_inicial)
        {
            recorrer_pila(pila_inicial);

            int temp = pila_inicial.Pop();
            
            return E2_recursion(pila_inicial, temp);

        }

        /*E3. Escriba una función que reciba un string de paréntesis y diga si está balanceado. Este string estará balanceado si cada paréntesis que abre, tiene uno que cierra. */
        private bool E3_recursion(string caracteres, int posicion, int abre, int cierra)
        {
            if (posicion == caracteres.Length)
            {
                return abre == cierra;
            }

            if ( caracteres[posicion] == char.Parse(")")){
                cierra += 1;
            }
            else if (caracteres[posicion] == char.Parse("(")){
                abre += 1;
            }

            return E3_recursion(caracteres, posicion+1, abre, cierra); 
        }
        public bool E3(string caracteres)
        {
            return E3_recursion(caracteres, 0, 0, 0);
        }





    }
}
