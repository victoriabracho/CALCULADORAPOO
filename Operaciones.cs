using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    internal class Operaciones
    {
        private int a;
        private int b;
        private string flag;//NOS PERMITIRÁ VALIDAR SI SE HAN CREADO LOS OPERANDOS O NO

        public Operaciones(int a, int b, string flag)
        {
     
                this.a = a;
                this.b = b;
                this.flag = flag; 
        }
        public Operaciones()
        {
            
                Console.WriteLine("CALCULADORA");
            
        }
        public string Sumar() //SUMA
        {
            return $"El resultado de la suma de {this.a} + {this.b} es: {a+b}";

        }
        public string Restar()
        {
            return $"El resultado de la resta de {this.a} - {this.b} es: {a - b}"; ;

        }
        public string Dividir()//DIVIDE Y TAMBIEN MANEJA LA EXCEPCION DE LA DIVISION ENTRE 0
        {
            if (b == 0)
            {
                return "No se puede dividir entre 0, realice otras operaciones o ingrese nuevos números";
            }
            else
            {
                double resultado = (double)a / (double)b;
                return $"El resultado de la división de {this.a} / {this.b} es: {resultado}";

            }
        }
        public string Multiplicar() //MULTIPLICA
        {
            return $"El resultado de la multiplicación de {this.a} * {this.b} es: {a * b}";
        }

        public string ValidarMsj()//MUESTRA EL MENSAJE DE VALIDACIÓN SI EL USUARIO NO HA INGRESADO 2 NUMEROS
        {
               
           return "Debes ingresar dos numeros para realizar las operaciones."; 
            
        }
        public int Validar2()//VALIDAR SI SE HAN CREADO O NO LOS OPERANDOS
        {
            if (flag == null)
            {

                return 0; 
            }
            else
            {
                return 1 ;
            }
        }
    }
}
