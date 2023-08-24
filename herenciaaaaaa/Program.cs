using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaaaaaa
{
    
   
        public class ClaseA
    { //Superclase A
        public int variable_x = 1;
        public int método_x()
        {
            return variable_x * 10;
        }
        public int método_y()
        {
            return variable_x + 100;
        } //El valor de variable_x es 1
        ~ClaseA()
        { //Destructor de clase A
            System.Console.WriteLine("Recursos de ClaseA liberados");
        }
    }
    public class ClaseB : ClaseA
    { //Subclase B
        int variable_x = 2; //Redefinición del variable_x
        public int método_x()
        { //Redefinición del Método_x
            return variable_x * -10;
        } //El valor de variable_x es 2
        public int método_z()
        {
            variable_x = base.variable_x + 3; // El valor de base.variable_x es 1
            return base.método_x() + variable_x;
        } // El valor de super.método_x() es 10
        ~ClaseB()
        { //Destructor de clase B
            System.Console.WriteLine("Recursos de ClaseB liberados");
        }
    }
    class Program
    { //Clase princiapal
        static void Main(string[] args)
        {
            ClaseB objClaseB = new ClaseB();
            System.Console.WriteLine(objClaseB.variable_x); //Escribe 2
            System.Console.WriteLine(objClaseB.método_y()); //Escribe 101 método heredado
            System.Console.WriteLine(objClaseB.método_x()); //Escribe -20
            System.Console.WriteLine(objClaseB.método_z()); //Escribe 14
            objClaseB = null; //Destrucción del objeto objClaseB
            System.GC.Collect();
            System.Console.WriteLine("Presiones una tecla para terminar...");
            System.Console.ReadKey();
        }

    }
}

