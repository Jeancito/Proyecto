using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizapp
{
    class Matriz9
    {

        private string[] nombres;
        private int[,] sueldos;
        private int[] sueldostotal;
        private int suma = 0;
        public void cargar() {
            nombres = new string[4];
            sueldos = new int[4, 3];
            for (int i = 0; i < nombres.Length; i++) {
                Console.Write("Ingresar el nombre : ");
                nombres[i] = Console.ReadLine();
                for (int j = 0; j < sueldos.GetLength(1); j++) {
                    Console.Write("Ingrese el sueldo: ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[i, j] = int.Parse(linea);                               
                }                                  
            }
        }

        public void calcularsumasueldo(){

            sueldostotal = new int[4];
            for (int i = 0; i < sueldostotal.GetLength(0);i++ ) {
                Console.WriteLine("Total de sueldos pagados por empleado Jean se la come: ");
                for (int j = 0; j < sueldos.GetLength(1); j++) {
                    suma = suma = sueldos[i, j];             
                }
                sueldostotal[i] = suma;          
            }     
        }


        public void imprimirtotalpagado() {

            Console.WriteLine("Total de sueldos pagados por empleado.");
            for (int i = 0; i < sueldostotal.Length; i++) {
                Console.WriteLine(nombres[i] + " - " + sueldostotal[i]);
            
            
            }                
        }
        static void Main(string[] args)
        {

            Matriz9 obj = new Matriz9();
            obj.cargar();
            obj.calcularsumasueldo();
            obj.imprimirtotalpagado();

        }
    }
}
