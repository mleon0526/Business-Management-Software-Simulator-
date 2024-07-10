
using System;

namespace Admin_Page
{
    internal class Finanzas
    {
        public static void finanzas()
        {
            string chosenActionFinanzas = "";

            while (chosenActionFinanzas != "x")
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("Bienvenido al panel de finanzas");
                Console.WriteLine();
                Console.WriteLine("nuevoFinanzas: Generar un nuevo reporte financiero");
                Console.WriteLine();
                Console.WriteLine("eliminarFinanzas: Elimina un informe financiero y agregalo al historial.");
                Console.WriteLine();
                Console.WriteLine("editarFinanzas: Editar los detalles de un reporte financiero.");
                Console.WriteLine();
                Console.WriteLine("analisisFinanzas: Genera un analisis financiero hecho por IA");
                Console.WriteLine();
                Console.WriteLine("consultaFinanzas: Chatea con un chtabot para cualquier duda respecto a las finanzas de tu empresa.");
                Console.WriteLine();
                Console.WriteLine("presentacionFinanzas: Genera una presentacion financiera con asistente IA incluido.");
                Console.WriteLine();
                Console.WriteLine("cerrarFinanzas: Cerrar el modulo de finanzas");
                Console.WriteLine();
                Console.WriteLine("Ingresa 'x' para salir del programa.");
                Console.WriteLine();

                chosenActionFinanzas = Console.ReadLine();

                switch (chosenActionFinanzas)
                {

                    case "nuevoFinanzas":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando reporte fianciero...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "eliminarFinanzas":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Eliminando reporte financiero...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "editarFinanzas":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando reporte financiero...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "analisisFinanzas":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando analisis financiero...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "consultaFinanzas":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chat abierto...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "presentacionFinanzas":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando Presentacion...");
                        Principal.WaitForCompletion();
                        Principal.Main();
                        Console.WriteLine();
                        break;

                    case "cerrarFinanzas":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Cerrando  panel de finanzas...");
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
