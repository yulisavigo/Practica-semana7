using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_semana7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            String codigo="", carrera="", bienvenido="";
            do
            {
                Console.Clear();
                Console.WriteLine("=======Menu de opciones======");
                Console.WriteLine("1. Leer codigo de sestudiante y carrera.");
                Console.WriteLine("2. Formar una nueva etiqueta textual con ambos (concatenado).");
                Console.WriteLine("3. Mostrar longitud de caracteres del código, carrera y etiqueta.");
                Console.WriteLine("4. Mostrar el primer y último carácter del código.");
                Console.WriteLine("5. Imprimir la carrera carácter por carácter.");
                Console.WriteLine("6. Cree una nueva etiqueta de bienvenida agregando \"Periodo: 2026-2“ al final de la carrera.");
                Console.WriteLine("7. Generar formato correo, upn");
                Console.WriteLine("8. Salir del menú");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el codigo");
                        codigo = Console.ReadLine();
                        Console.WriteLine("Carrea: ");
                        carrera = Console.ReadLine();
                        break;
                    case 2:
                        bienvenido = codigo + "| carreraa: " + carrera;
                        Console.WriteLine("etiqueta generada" + bienvenido);
                        break;
                    case 3:
                        Console.WriteLine("La longitud del codigo es: " + codigo.Length);
                        Console.WriteLine("La longitud de la carrera es: " + carrera.Length);
                        Console.WriteLine("La lonngitud del saludo es: " + bienvenido.Length);
                        break;
                    case 4:
                        Console.WriteLine("El primer caracter es: " + carrera[0]);
                        Console.WriteLine("El último caracter es: " + carrera[carrera.Length - 1]);
                        break;
                    case 5:
                        for (int i = 0; i < carrera.Length; i++)
                        {
                            Console.WriteLine(carrera[i]);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Ingrese nombres y apellidos: ");
                        String alumno = Console.ReadLine();

                        string[] partes = alumno.Split(' ');
                        String primernombre = partes[0];
                        String iniciales = "";
                        for (int i = 0; i < partes.Length; i++) 
                        {
                            iniciales += partes[i].Substring(0, 1);
                        }
                        break;
                    case 8: Console.WriteLine("Saliendo...");
                        break;
                    default: Console.WriteLine("Opción no valida");
                            break;
                }
                Console.ReadKey();
            }
            while (opcion !=7);
           

        }
    }
}
