using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ELEMENTOS_PILAS
{
    //Contains
    // Gen Type
    //To string
    //To Array
    //Get Enumerator

    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> Pila = new Stack<int>();

            Pila.Push(99); Pila.Push(66); Pila.Push(33); // Push : AÑADE ELEMENTOS A LA PILA
            Pila.Peek();    // Peek : PERMITE LA VISUALIZACION DE LOS ELEMENTOS DE LA PILA   
            Console.Write("\n\tELEMENTO A BUSCAR  : "); int numero = int.Parse(Console.ReadLine());
            Console.Write("\n\tESTA EL ELEMENTO {0} : {1}",numero, Pila.Contains(numero));
            // Contains:INDICA SI EL ELEMNTO ETSA EN LA PILA 
            Console.WriteLine("\n\tAÑADIR A LA PILA : 93");
            Pila.Push(93);
            Console.WriteLine("\n\tVER PILA : \n ");    

            foreach (var numer in Pila)
            {
                Console.WriteLine("\t{0}",numer);
            }
 
            Console.Write("\n\tTIPOS DE ELEMENTOS DE LA PILA : {0}", Pila.GetType());
            //GetType: ES PARA IDENTIFICAR EL TIPO DE DATO DE LOS ELEMENTOS DE LA PILA 
            Console.ReadKey();

            Stack<string> Elemento = new Stack<string>();
            Elemento.Push("NIEVE");  Elemento.Push("INVIERNO");
            Elemento.Push("DICIEMBRE"); Elemento.Push("FRIO");
            Elemento.Push("HIELO");

            Console.WriteLine("\n\n\tVER PILA 2 : \n");
            foreach (string frio in Elemento)
            {
                Console.WriteLine("\t{0}",frio);
            }
            Console.Write("\n\tNUMERIO DE ELEMENTOS DE LA PILA = {0}", Elemento.Count);
            //Count : CUENA LOS ELEMENTOS DE LA PILA
            Console.Write("\n\tQUITAR PRIMER ELEMENTO : {0} ", Elemento.Pop());         
            Console.Write("\n\tQUITAR SEGUNDO ELEMENTO : {0}", Elemento.Pop());
            // Pop : REMUEVE O QUITA ELEMENTOS DE LA PILA 

             Stack<string> Pila2 = new Stack<string>(Elemento.ToArray());
            // ToArray. devuelve toda la pila convertida en un array.

            Console.WriteLine("\n\n\tELEMENTO DE PILA A ARREGLOS :");

             foreach (string number in Pila2)
               {
                        Console.WriteLine("\t{0}",number);
                        Pila.GetEnumerator();
               }
            Console.Write("\n\tNUMERIO DE ELEMENTOS DE LA PILA = {0}", Pila2.Count);
            
            Console.Write("\n\tLIMPIAR PILA"); Pila2.Clear(); // CLEAR LIMPIA LA PILA
            Console.Write("\n\tNUMERIO DE ELEMENTOS DE LA PILA = {0}\n", Pila2.Count);
            Console.Write("\n\tTIPOS DE ELEMENTOS DE LA PILA : {0}\n", Pila2.GetEnumerator());
            // GetEnumerator: PERMINTE USAR ENUMERADO PARA RECORRER LA PILA        

            Console.Write("\n\tELEMENTO A AÑADIR : "); int nuevo = int.Parse(Console.ReadLine());
            Pila2.Push("NUMERO");
            Pila2.Push(nuevo.ToString()); // CONVIERTE ELEMNTOS DE UN TIPO A STRING            
            Pila2.Push("PALABRAS");
            Console.WriteLine("\n\n\tELEMENTO Int A String :");
            foreach (string pilaString in Pila2)
            {
                Console.WriteLine("\t{0}", pilaString);

            }
            Console.Write("\n\tNUMERIO DE ELEMENTOS DE LA PILA = {0}\n", Pila2.Count);
            Console.ReadKey();
        }
    }
}
