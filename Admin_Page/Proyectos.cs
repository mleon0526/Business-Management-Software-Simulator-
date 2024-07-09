using System;

namespace Admin_Page
{
    internal class Proyectos
    {
        public static void proyectos()
        {
            string chosenActionPoryectos = "";

            while (chosenActionPoryectos != "x")
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("Bienvenido al panel de proyectos");
                Console.WriteLine();
                Console.WriteLine("nuevoProyecto: Generar un nuevo proyecto");
                Console.WriteLine();
                Console.WriteLine("eliminarProyecto: Elimina un proyecto del sistema");
                Console.WriteLine();
                Console.WriteLine("editarProyecto: Editar los detalles de una compra.");
                Console.WriteLine();
                Console.WriteLine("historialProyectos: Accede al historial de todos los proyectos");
                Console.WriteLine();
                Console.WriteLine("chatProyecto: Genera un chat grupal para trabajar en un proyecto grupal.");
                Console.WriteLine();
                Console.WriteLine("presentacionReporte: genera una presentacion de un proyecto con asistente IA incluido");
                Console.WriteLine();
                Console.WriteLine("cerrarProyecto: Cerrar el modulo de proyectos");
                Console.WriteLine();
                Console.WriteLine("Ingresa 'x' para salir del programa.");
                Console.WriteLine();

                chosenActionPoryectos = Console.ReadLine();

                switch (chosenActionPoryectos)
                {

                    case "nuevoProyecto":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando nuevo proyecto...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "eliminarProyecto":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Eliminando proyecto del sistema...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "editarProyecto":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando proyecto...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "historialProyectos":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chequeando historial...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "chatProyecto":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chat abierto...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "presentacionProyecto":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Generando presentacion de proyecto...");
                        Principal.WaitForCompletion();
                        Principal.Main();
                        Console.WriteLine();
                        break;

                    case "cerrarProyecto":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Cerrando panel de proyectos...");
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
