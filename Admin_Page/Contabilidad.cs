using System;

namespace Admin_Page
{
    internal class Contabilidad
    {
        public static void contabilidad()
        {
            string chosenActionContabilidad = "";

            while (chosenActionContabilidad != "x")
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("Bienvenido al panel de contabilidad");
                Console.WriteLine();
                Console.WriteLine("nuevoContabilidad: Generar un reporte contable con asistente IA incluido.");
                Console.WriteLine();
                Console.WriteLine("eliminarContabilidad: Elimina un reporte contable del sistema.");
                Console.WriteLine();
                Console.WriteLine("editarContabilidad: Editar los detalles de un reporte.");
                Console.WriteLine();
                Console.WriteLine("historialContabilidad: Accede al historial de reportes y la base contable de la empresa");
                Console.WriteLine();
                Console.WriteLine("chatContabilidad: Genera un chat grupal para trabajar en un reporte grupal.");
                Console.WriteLine();
                Console.WriteLine("reporte602: genera una reporte tipo 602");
                Console.WriteLine();
                Console.WriteLine("reporte606: genera una reporte tipo 606");
                Console.WriteLine();
                Console.WriteLine("reporte608: genera una reporte tipo 608");
                Console.WriteLine();
                Console.WriteLine("cerrarContabilidad: cerrar el modulo de contabilidad");
                Console.WriteLine();
                Console.WriteLine("Ingresa 'x' para salir del programa.");
                Console.WriteLine();

                chosenActionContabilidad = Console.ReadLine();

                switch (chosenActionContabilidad)
                {
                    case "nuevoContabilidad":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando nuevo reporte contable...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "eliminarContabilidad":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Eliminando reporte contable del sistema...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "editarContabilidad":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando reporte contable...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "historialContabilidad":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chequeando historial contable...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "chatContabilidad":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chat abierto...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "reporte602":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando reporte 602...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "reporte606":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando reporte 606...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "reporte608":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando reporte 608...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "cerrarContabilidad":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Cerrando panel de contabilidad...");
                        Principal.WaitForCompletion();
                        Principal.Main();
                        Console.WriteLine();

                        break;

                    case "x":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Error: asegurate de escribir bien el comando");
                        break;

                }

            }

            Environment.Exit(0); //exit program when x clicked
        }
    }
}
