using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lista_de_Alumos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] listaalumnos = new Alumno[8];
            InsetarTodos(listaalumnos);
            int opcion = 0;
            while (opcion != 3)
            {
                Console.WriteLine("1.- Insertar Alumno");
                Console.WriteLine("2.- Mostrar TODOS");
                Console.WriteLine("3.- Mostrar Alumnas");
                Console.WriteLine("4.- INSENTAR TODOS");
                Console.WriteLine("5.- ORDENADO");
                Console.WriteLine("6.-  Salir");
                Console.WriteLine("Introduzca Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Insetar(listaalumnos);
                        break;
                    case 2:
                        Mostrar(listaalumnos);
                        break;
                    case 3:
                        MostrarAlumnas(listaalumnos);
                        break;
                    case 4:
                        InsetarTodos(listaalumnos);
                        break;
                    case 5:
                        OrdenarNombre(listaalumnos);
                        break;
                    default:
                        break;
                }
            }
        }
     
        static void Insetar(Alumno[] listaalumnos)
        {
            Console.WriteLine("Introduzca el Numero del Alumno: ");
            int nroalumno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el Nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el Primer Apellido: ");
            string PrimerApeliido = Console.ReadLine();
            Console.WriteLine("Introduzca el Segundo Apellido: ");
            string SegundoApellido = Console.ReadLine();
            Console.WriteLine("Introduzca su Carnet de Identidad: ");
            string CI = Console.ReadLine();
            Console.WriteLine("Introduzca su Edad: ");
            int Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca Sexo: ");
            string Sexo = Console.ReadLine();
            Alumno a = new Alumno(Nombre, PrimerApeliido, SegundoApellido, CI, Edad, Sexo);
            listaalumnos[nroalumno] = a;

        }
        static void InsetarTodos(Alumno[] listaalumnos)
        {
            listaalumnos[0] = new Alumno("Antonio ", "Arce ", "Pacheco ", "10390566 ", 21, " M ");
            listaalumnos[1] = new Alumno("Maycol ", "Mancilla ", "Lora ", "10566366 ", 22, " M");
            listaalumnos[2] = new Alumno("Camila ", "Canaviri ", "Mamani ", "12398414 ", 19, " F");
            listaalumnos[3] = new Alumno("Kassandra ", "Cuellar ", "Almendras ", "7512719 ", 21, " F");
            listaalumnos[4] = new Alumno("Danna ", "Colque ", "Soliz ", "65498512 ", 18, " F");
            listaalumnos[5] = new Alumno("Jhoselin ", "Choque ", "Ajalla ", "12931915 ", 19, " F");
            listaalumnos[6] = new Alumno("Yerson ", "Mallcu ", "Lisarazu ", "123456789 ", 26, " M");
            listaalumnos[6] = new Alumno("Paste ", "Quispe ", "Calcina ", "123456789 ", 20, " M");

        }
        static void Mostrar(Alumno[] listaalumnos)
        {
            var todos = from c in listaalumnos
                        select c;

            foreach (Alumno a in todos)
            {
                        Console.WriteLine("{0} {1} {2} {3} {4}", a.nombre, a.primerapellido, a.segundoapeliido, a.ci, a.edad);
            }
            Console.ReadKey();
        }
    
        static void MostrarAlumnas(Alumno[] listaalumnos)
        {
            var Alumnas = from c in listaalumnos
                          where c.sexo == "F"
                          select c;

            foreach (Alumno a in Alumnas)
            {
                
                        Console.WriteLine("{0} {1} {2} {3} {4}", a.nombre, a.primerapellido, a.segundoapeliido, a.ci, a.edad);
            }
            Console.ReadKey();

        }

        static void OrdenarNombre(Alumno[] listaalumnos)
        {
            var Ordenado = from c in listaalumnos                    
                           select c;
            foreach (Alumno a in Ordenado)
            {
               
                        Console.WriteLine("{0} {1} {2} {3} {4}", a.nombre, a.primerapellido, a.segundoapeliido, a.ci, a.edad);
            }
            Console.ReadKey();

        }
    }
}
