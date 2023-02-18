using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EjercicioDeGuia
{
    internal class Program
    {
       

        static void Main(string[] args)
        {

            Empleados date = new Empleados();

            WriteLine("BAR PEPITO \n");

            WriteLine(" DATOS DE EL EMPLEADO \n PRESIONE ENTER");
            string texto = ReadLine();
            WriteLine(" EMPLEADO");
            WriteLine($" NOMBRE: {date.nombre} APELLIDO: {date.apellido} EDAD: {date.edad} \n CARGO: {date.cargo} \n");

            WriteLine("INGRESE LOS DATOS DEL CLIENTE \n PRESIONE ENTER");
            string Cliente = ReadLine();

            Cliente clien = new Cliente();
                WriteLine("INGRESE EL NOMBRE");
                clien.nombre = ReadLine();
                WriteLine("INGRESE EL APELLIDO");
                clien.apellido = ReadLine();
                WriteLine("INGRESE LA EDAD");
                clien.edad = Convert.ToInt32(ReadLine());
                Clear();
                WriteLine("los datos ingresados son: \n" + "CLIENTE NOMBRE:" + clien.nombre + "\n" + "CLIENTE APELLIDO:" + clien.apellido + "\n" + "EDAD:" + clien.edad);
                string datos = ReadLine();



            bebida bebi = new bebida();
            WriteLine("BEBIDAS ALCOHOLICAS UNICAMENTE PARA MAYORES DE EDAD\n");
            WriteLine("INGRESE LA BEBIDA QUE DESEA");
            bebi.tipo_bebida = ReadLine();



            Ingrediente ingre = new Ingrediente();
            WriteLine("INGREDIENTES OPCIONALES\n");

            WriteLine("INGRESE EL PRIMER INGREDIENTE");
            ingre.ingrediente1 = ReadLine();
            WriteLine("INGRESE EL SEGUNDO INGREDIENTE");
            ingre.ingrediente2 = ReadLine();
            WriteLine("INGRESE EL TERCER INGREDIENTE");
            ingre.ingrediente3 = ReadLine();

            WriteLine(" \n CON LA CUENTA \n" + "NOMBRE CLIENTE:" + clien.nombre + "," + clien.apellido + "\n" + "NOMBRE EMPLEADO:" + ingre.nombre + "" + "CARGO DEL EMPLREADO:" + ingre.cargo + "" + "BEBIDA:" + bebi.tipo_bebida + "\n" + "PRIMER INGREDIENTE:" + ingre.ingrediente1 + "\n" + "SEGUNDO INGREDIENTE:" + ingre.ingrediente2 + "\n" + "TERCER INGREDIENTE:" + ingre.ingrediente3);
            string contra = ReadLine();

        }
    }

    public class Empleados
    {
        public string id;
        public string nombre = " Juan \n";
        public string apellido = " Hernandez \n";
        public string cargo = "barista \n";
        public int edad = 34;

    }

    public class Cliente
    {

        public string nombre;
        public string apellido;
        public int edad;
    }


    public class bebida
    {

        public string tipo_bebida;
    }


    public class Ingrediente : Empleados
    {
        public string ingrediente1;
        public string ingrediente2;
        public string ingrediente3;



    }

    public class metodos : Cliente
    {
        public void information()
        {


            Cliente date = new Cliente();

            WriteLine("Ingrese los datos del cliente");
            WriteLine("Nombre");
            date.nombre = ReadLine();
            WriteLine("Apellido");
            date.apellido = ReadLine();
            WriteLine("Edad");
            date.edad = Convert.ToInt32(ReadLine());
            string recoleccionDatosClientes = ReadLine();
        }

    }
}