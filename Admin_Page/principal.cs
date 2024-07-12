using System;

namespace Admin_Page
{
    internal class Principal
    {

        public static void Main()
        {
            Console.WriteLine("Bienvenido a Adm Cloud");
            Console.WriteLine();
            Console.WriteLine("escribe i para iniciar el programa y x para cerrarlo");
            Console.WriteLine();

            string chosenMainAction = Console.ReadLine(); // Initial input

            while (chosenMainAction != "x")
            {
                if (chosenMainAction == "i")
                {
                    Console.WriteLine();
                    Console.WriteLine("Bienvenido al panel principal de Adm Cloud. Escribe uno de los siguientes comandos para que puedas acceder a cada uno de los modulos disponibles:");
                    Console.WriteLine();
                    Console.WriteLine("empleados: Accede al panel de con los perfiles del manejo de detallesEmpleados.");
                    Console.WriteLine();
                    Console.WriteLine("finanzas: Maneja todo lo relacionado a las finanzas de tu empresa.");
                    Console.WriteLine();
                    Console.WriteLine("contabilidad: Panel para manejar todo lo relacionado al manejo contable.");
                    Console.WriteLine();
                    Console.WriteLine("ventas: Organiza, realiza todo lo relacionado a ventas.");
                    Console.WriteLine();
                    Console.WriteLine("compras: realiza compras, editalas y almacena los datos en esta seccion.");
                    Console.WriteLine();
                    Console.WriteLine("proyectos: Genera, edita y comparte todos los proyectos de todo tipo.");
                    Console.WriteLine();
                    Console.WriteLine("inventario: Inspeciona, edita y controla todo el flujo de materiales y productos.");
                    Console.WriteLine();
                    Console.WriteLine("ayuda: Panel para asistir cualquier duda o problemas de los clientes.");
                    Console.WriteLine();
                }

                chosenMainAction = Console.ReadLine(); // Read user input in each iteration

                switch (chosenMainAction)
                {
                    case "empleados":
                        Console.WriteLine();
                        RecursoHumano.Empleados();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        break;
                    case "finanzas":
                        Console.WriteLine();
                        Finanzas.finanzas();
                        Console.WriteLine("Handling finances module.");
                        break;
                    case "contabilidad":
                        Console.WriteLine();
                        Contabilidad.contabilidad();
                        Console.WriteLine("Handling accounting module.");
                        break;
                    case "ventas":
                        Console.WriteLine();
                        Ventas.ventas();
                        Console.WriteLine("Handling sales module.");
                        break;
                    case "compras":
                        Console.WriteLine();
                        Compras.compras();
                        Console.WriteLine("Handling purchases module.");
                        break;
                    case "proyectos":
                        Console.WriteLine();
                        Proyectos.proyectos();
                        Console.WriteLine("Handling projects module.");
                        break;
                    case "inventario":
                        Console.WriteLine();
                        Inventario.inventario();
                        Console.WriteLine("Handling inventory module.");
                        break;
                    case "Reportes":
                        Console.WriteLine();
                        Console.WriteLine("Handling reports module.");
                        break;
                    case "ayuda":
                        Console.WriteLine();
                        Ayuda.ayuda();
                        Console.WriteLine("Handling help module.");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Error: Invalid Input.");
                        break;
                }
            }

            Environment.Exit(0);

        }
        public static void WaitForCompletion()
        {
            string subAction = "";
            while (subAction != "listo") 
            {
                Console.WriteLine("Ingresa 'listo' para completar el cambio.");
                subAction = Console.ReadLine();

                if (subAction == "listo")
                {
                    Console.WriteLine("Cambio Completado");
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    Console.WriteLine("");

                }
                else
                {
                    Console.WriteLine("Error: Asegurate de que el comando este bien escrito.");
                }
            }
        }


    }
}