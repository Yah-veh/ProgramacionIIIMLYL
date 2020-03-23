using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ListaDeEntero = new int[100000];
            int empieza = 0;
            int tamaño = ListaDeEntero.Length;
            Random azar = new Random();
            LlenarArreglo(ListaDeEntero);
            int opcion = 0;
            while (opcion != 8)
            {
                Console.WriteLine("1.- Método de Ordenamiento de Inserción directa ");
                Console.WriteLine("2.- Método de Ordenamiento de Inserción Binaria ");
                Console.WriteLine("3.- Método de Ordenamiento Shell Sort ");
                Console.WriteLine("4.- Método de Ordenamiento Quick Sort ");
                Console.WriteLine("5.- Método de Ordenamiento Burbuja ");
                Console.WriteLine("6.- Método de Ordenamiento Shaker Sort ");
                Console.WriteLine("7.- Método de Ordenamiento Burbuja ");
                Console.WriteLine("6.-  Salir");
                Console.WriteLine("Introduzca Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        string Incio = DateTime.Now.ToString("hh:mm:ss");
                        TimeSpan TIncio = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Inicio de Tiempo {0} segundos " , Incio);
                        InsecionDirecta(ListaDeEntero);
                        string Final = DateTime.Now.ToString("hh:mm:ss");
                        TimeSpan TFinal = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Final de Tiempo {0} segundos " , Final);
                        double DuracionInsercionDirecta = TFinal.Subtract(TIncio).TotalSeconds;
                        Console.WriteLine("Total {0} segundos en realizar el Ordenamiento Insercion Directa", DuracionInsercionDirecta);
                        Console.WriteLine();
                        break;
                    case 2:
                        Incio = DateTime.Now.ToString("hh:mm:ss");
                        TIncio = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Inicio de Tiempo {0} segundos ", Incio);
                        InsecionBinaria(ListaDeEntero);
                        Final = DateTime.Now.ToString("hh:mm:ss");
                        TFinal = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Final de Tiempo {0} segundos ", Final);
                        double DuracionInsercionBinaria = TFinal.Subtract(TIncio).TotalSeconds;
                        Console.WriteLine("Total {0} segundos en realizar el Ordenamiento Insercion Binaria", DuracionInsercionBinaria);
                        Console.WriteLine();
                        break;
                    case 3:
                        Incio = DateTime.Now.ToString("hh:mm:ss");
                        TIncio = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Inicio de Tiempo {0} segundos ", Incio);
                        ShellSort(ListaDeEntero);
                        Final = DateTime.Now.ToString("hh:mm:ss");
                        TFinal = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Final de Tiempo {0} segundos ", Final);
                        double DuracionShellSort = TFinal.Subtract(TIncio).TotalSeconds;
                        Console.WriteLine("Total {0} segundos en realizar el Ordenamiento ShellSort", DuracionShellSort);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 4:
                        Incio = DateTime.Now.ToString("hh:mm:ss");
                        TIncio = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Inicio de Tiempo {0} segundos ", Incio);
                        QuickSort(ListaDeEntero,empieza,tamaño-1);
                        Final = DateTime.Now.ToString("hh:mm:ss");
                        TFinal = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Final de Tiempo {0} segundos ", Final);
                        double DuracionQuickSort = TFinal.Subtract(TIncio).TotalSeconds;
                        Console.WriteLine("Total {0} segundos en realizar el Ordenamiento QuickSort", DuracionQuickSort);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 5:
                        Incio = DateTime.Now.ToString("hh:mm:ss");
                        TIncio = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Inicio de Tiempo {0} segundos ", Incio);
                        MetodoBurbuja(ListaDeEntero);
                        Final = DateTime.Now.ToString("hh:mm:ss");
                        TFinal = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Final de Tiempo {0} segundos ", Final);
                        double DuracionBurbuja = TFinal.Subtract(TIncio).TotalSeconds;
                        Console.WriteLine("Total {0} segundos en realizar el Ordenamiento Burbuja", DuracionBurbuja);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 6:
                        Incio = DateTime.Now.ToString("hh:mm:ss");
                        TIncio = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Inicio de Tiempo {0} segundos ", Incio);
                        ShakerSort(ListaDeEntero);
                        Final = DateTime.Now.ToString("hh:mm:ss");
                        TFinal = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Final de Tiempo {0} segundos ", Final);
                        double DuracionShakerSort = TFinal.Subtract(TIncio).TotalSeconds;
                        Console.WriteLine("Total {0} segundos en realizar el Ordenamiento ShakerSort", DuracionShakerSort);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 7:
                        Incio = DateTime.Now.ToString("hh:mm:ss");
                        TIncio = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Inicio de Tiempo {0} segundos ", Incio);
                        ///////////////////////////////////////////////////////////
                        int[] nums = ListaDeEntero;                                       
                        int cant = ListaDeEntero.Length;
                        nums = new int[cant];                    
                        MergeSort(ListaDeEntero);                       
                        //////////////////////////////////////////////////////////
                        Final = DateTime.Now.ToString("hh:mm:ss");
                        TFinal = new TimeSpan(DateTime.Now.Ticks);
                        Console.WriteLine("Final de Tiempo {0} segundos ", Final);
                        double DuracionMergeSort = TFinal.Subtract(TIncio).TotalSeconds;
                        Console.WriteLine("Total {0} segundos en realizar el Ordenamiento MergeSort", DuracionMergeSort);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
            }
        }
        static void Salida(int[] arreglo)
        {
            foreach (int a in arreglo)
            Console.WriteLine(" {0} ",a);
        }
        static void LlenarArreglo(int[] arreglo)
        {
            Random azar = new Random();
            for (int i = 0; i < 100000; i++)
                arreglo[i] = azar.Next(1, 10000);           
        }
   
        static  void InsecionDirecta(int[] vector)
        {
            int auxili;
            int j;
            for (int i = 0; i < vector.Length; i++)
            {
                auxili = vector[i];
                j = i - 1;
                while (j >= 0 && vector[j] > auxili)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = auxili;
            }
        }
        static void InsecionBinaria(int[] numeros)
        {
            int auxiliar;
            int q;
            int izqui;
            int dere;
            for (int i = 0; i < numeros.Length; i++)
            {
                auxiliar = numeros[i];
                izqui = 0;
                dere = i - 1;
                while (izqui <= dere)
                {
                    q = ((izqui + dere) / 2);
                    if (auxiliar < numeros[q])
                    {
                        dere = q - 1;
                    }
                    else
                    {
                        izqui = q + 1;
                    }
                    int j = i - 1;
                    while (j >= izqui)
                    {
                        numeros[j + 1] = numeros[j];
                        j = j - 1;
                    }
                    numeros[izqui] = auxiliar;
                }
            }
        }
        static void ShellSort(int[] vector)
        {
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = vector.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (vector.Length - salto))
                    {
                        if (vector[e - 1] > vector[(e - 1) + salto])
                        {
                            auxi = vector[(e - 1) + salto];
                            vector[(e - 1) + salto] = vector[e - 1];
                            vector[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }
        static void QuickSort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                QuickSort(vector, primero, j);
            }
            if (i < ultimo)
            {
                QuickSort(vector, i, ultimo);
            }
        }
        static void MetodoBurbuja(int[] vector)
        {
            int auxili;
            int j;
            for (int i = 0; i < vector.Length; i++)
            {
                auxili = vector[i];
                j = i - 1;
                while (j >= 0 && vector[j] > auxili)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = auxili;
            }
        }
        static void ShakerSort(int[] numeros)
        {
            int n = numeros.Length;
            int izq = 1;
            int ultimo = n-1;
            int aux;
            int der = n;

            do
            {
                for (int i = numeros.Length-1; i > 0; i--)
                {
                    if (numeros[i - 1] > numeros[i])
                    {
                        aux = numeros[i];
                         numeros[i]=numeros[i - 1];
                        aux = numeros[i];
                         ultimo = i;
                    }
                }
                izq = ultimo + 1;
                for (int i = 1; i <n; i++)
                {
                    if (numeros[i - 1] > numeros[i])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[i - 1];
                         numeros[i-1] = aux;
                        ultimo = i;
                    }
                }
                der = ultimo - 1;
            }
            while (der >= izq);
        }
        public static void MergeSort(int[] x)
        {
            MergeSort(x, 0, x.Length - 1);
        }

        static private void MergeSort(int[] x, int desde, int hasta)
        {
            if (desde == hasta)
                return;
            int mitad = (desde + hasta) / 2;
            MergeSort(x, desde, mitad);
            MergeSort(x, mitad + 1, hasta);
            int[] aux = Merge(x, desde, mitad, mitad + 1, hasta);
            Array.Copy(aux, 0, x, desde, aux.Length);
        }
        static private int[] Merge(int[] x, int desde1, int hasta1, int desde2, int hasta2)
        {
            int a = desde1;
            int b = desde2;
            int[] result = new int[hasta1 - desde1 + hasta2 - desde2 + 2];

            for (int i = 0; i < result.Length; i++)
            {
                if (b != x.Length)
                {
                    if (a > hasta1 && b <= hasta2)
                    {
                        result[i] = x[b];
                        b++;
                    }
                    if (b > hasta2 && a <= hasta1)
                    {
                        result[i] = x[a];
                        a++;
                    }
                    if (a <= hasta1 && b <= hasta2)
                    {
                        if (x[b] <= x[a])
                        {
                            result[i] = x[b];
                            b++;
                        }
                        else
                        {
                            result[i] = x[a];
                            a++;
                        }
                    }
                }
                else
                {
                    if (a <= hasta1)
                    {
                        result[i] = x[a];
                        a++;
                    }
                }
            }
            return result;
        }
    }
}

