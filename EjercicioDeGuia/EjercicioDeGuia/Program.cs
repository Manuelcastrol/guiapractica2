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

            WriteLine("PORFAVOR INGRESE EL NOMBRE ");
            clien.nombre = ReadLine();
            WriteLine("PORFAVOR INGRESE EL APELLIDO ");
            clien.apellido = ReadLine();
            WriteLine("PORFAVOR INGRESE  LA EDAD ");
            clien.edad = ReadLine();
            WriteLine("los datos ingresados son: \n" + "CLIENTE NOMBRE:" + clien.nombre + "\n" + "CLIENTE APELLIDO:" + clien.apellido + "\n" + "EDAD:" + clien.edad);
            string datos = ReadLine();



            bebida bebi = new bebida();
            WriteLine("seleccioen una opcion");
            WriteLine("1. cuba libre");
            WriteLine("2. mojito");
            WriteLine("3. piñacolada");

            int seleccion = Convert.ToInt32(ReadLine());
          

            switch (seleccion)
            {
                case (1):
                    
                    WriteLine("selecionaste " + bebi.tipo1);

                    break;

                case (2):

                    
                    WriteLine("selecionaste " + bebi.tipo2);

                    break;

                case (3):

                    WriteLine("selecionaste " + bebi.tipo3);

                    break;

                default:
                    WriteLine("esa opcion no esta");
                    return;
            }

            Empleados emplea = new Empleados();

            Ingrediente ingre = new Ingrediente();

            WriteLine("INGRESE EL PRIMER INGREDIENTE");
            ingre.ingrediente1 = ReadLine();
            WriteLine("INGRESE EL SEGUNDO INGREDIENTE");
            ingre.ingrediente2 = ReadLine();
            WriteLine("INGRESE EL TERCER INGREDIENTE");
            ingre.ingrediente3 = ReadLine();

            WriteLine(" \n CON LA CUENTA \n" + "NOMBRE CLIENTE:" + clien.nombre + "," + clien.apellido + "\n" + "NOMBRE EMPLEADO:" + emplea.nombre + "" + "CARGO DEL EMPLREADO:" + emplea.cargo + "" + "BEBIDA:" + seleccion + "\n" + "PRIMER INGREDIENTE:" + ingre.ingrediente1 + "\n" + "SEGUNDO INGREDIENTE:" + ingre.ingrediente2 + "\n" + "TERCER INGREDIENTE:" + ingre.ingrediente3);
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
        public string edad;
    }


    public class bebida
    {

        public string tipo1 = "cuba libre";
        public string tipo2 = "mojito";
        public string tipo3 = "piñacolada";
    }


    public class Ingrediente
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
            date.edad = ReadLine();
            string recoleccionDatosClientes = ReadLine();
        }

    }
}