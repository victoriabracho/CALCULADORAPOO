using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculadoraPOO
{
    internal class Menu
    {
        List<Opciones> opciones;
        private Operaciones operaciones;

        public Menu() //OPCIONES DEL MENÚ
        {
            operaciones = new Operaciones();
            opciones = new List<Opciones>() {
                new Opciones("Ingresa los numeros", crearOperadores),
                new Opciones("Sumar", Sumar),
                new Opciones("Restar", Restar),
                new Opciones("Multiplicar", Multiplicar),
                new Opciones("Dividir", Dividir),
                new Opciones("Salir", ()=>Environment.Exit(0))

                };

            while (true)
            {
                MostrarMenu();
                seleccionarOpcion();
            }
        }
        public void MostrarMenu()//MUESTRA EL MENU
        {
            foreach (Opciones opcion in opciones)
            {
                Console.WriteLine(opciones.IndexOf(opcion) + ". " + opcion.Message);
            }
        }
        public void seleccionarOpcion()//PERMITE SELCCIONAR LAS OPCIONES E INVOCA LA ACCION
        {
            int numOpcion = int.Parse(Console.ReadLine());
            Console.Clear();
            opciones[numOpcion].Action.Invoke();
            Console.Clear();
        }
        public void crearOperadores()//CREA UN CONJUNTO DE OPERADORES PARA HACER LAS OPERACIONES
        {
            Console.WriteLine("Ingrese su primer numero por favor: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segundo numero por favor: ");
            int b = int.Parse(Console.ReadLine());
            string flag = "si";

            operaciones = new Operaciones (a,b,flag);
        }
        public void Sumar()//PERMITE SUMAR
        {
            if (operaciones.Validar2() == 0)
            {
                Console.WriteLine(operaciones.ValidarMsj());
                Console.WriteLine("Presione cualquier tecla para continuar.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(operaciones.Sumar());
                Console.WriteLine("Presione cualquier tecla para continuar.");
                Console.ReadLine();
            }
        }
        public void Restar()//PERMITE RESTAR
        {
            if (operaciones.Validar2() == 0)
            {
                Console.WriteLine(operaciones.ValidarMsj());
                Console.WriteLine("Presione cualquier tecla para continuar.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(operaciones.Restar());
                Console.WriteLine("Presione cualquier tecla para continuar.");
                Console.ReadLine();
            }
           
        }
        public void Dividir()//PERMITE DIVIDIR
        {
            if (operaciones.Validar2() == 0)
            {
                Console.WriteLine(operaciones.ValidarMsj());
                Console.WriteLine("Presione cualquier tecla para continuar.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(operaciones.Dividir());
                Console.WriteLine("Presione cualquier tecla para continuar.");
                Console.ReadLine();
            }
           
        }
        public void Multiplicar()//PERMITE MULTIPLICAR
        {
            if (operaciones.Validar2() == 0)
            {
                Console.WriteLine(operaciones.ValidarMsj());
                Console.WriteLine("Presione cualquier tecla para continuar.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(operaciones.Multiplicar());
                Console.WriteLine("Presione cualquier tecla para continuar.");
                Console.ReadLine();
            }
           
        }

    }
}
