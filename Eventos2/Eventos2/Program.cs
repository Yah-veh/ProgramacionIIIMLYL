using System;

namespace Eventos2
{
    class Program
    {
        public class Operacionesvecto
        {
            public delegate void Delegado(int[] arreglo);
            public event Delegado Cuandoindtroduce1;

            public void Llenar(int [] arreglo)
            {
                Console.WriteLine("Introduzca Valores");
                for (int i=0;i<5;i++)
                {
                    arreglo[i] = int.Parse(Console.ReadLine());
                    if ((arreglo[i] == -1) && (Cuandoindtroduce1 != null))
                        {
                        Cuandoindtroduce1(arreglo);
                    }

                }
            }

        }
       
        static void Main(string[] args)
        {
            int[] arreglo = new int[5];
            Operacionesvecto op = new Operacionesvecto();
            op.Cuandoindtroduce1 += MostrarVector; //suscribirse al evento
            op.Llenar(arreglo);
        }
        static void MostrarVector(int[] arreglo)
        {
            foreach (int elemento in arreglo)
            {
                Console.WriteLine(elemento);
            }
        }
      
    }
}
