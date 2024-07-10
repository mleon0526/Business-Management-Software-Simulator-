using System;

namespace Admin_Page
{
    internal class Ayuda
    {
        public static void ayuda()
        {
            string chosenActionAyuda = "";

            while (chosenActionAyuda != "x")
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("Bienvenido al panel de inventario");
                Console.WriteLine();
                Console.WriteLine("atenderCaso: Atender caso de un cliente.");
                Console.WriteLine();
                Console.WriteLine("rechazarCaso: Ignorar caso de un cliente.");
                Console.WriteLine();
                Console.WriteLine("historialAyuda: Accede al historial de todas las quejas y problemas.");
                Console.WriteLine();
                Console.WriteLine("asistenteAyuda: Panel de mantenimineto para el asistente IA de ayuda.");
                Console.WriteLine();
                Console.WriteLine("chatAyuda: Accede o crea un chat general con los clientes.");
                Console.WriteLine();
                Console.WriteLine("tutorialesAyuda: Maneja el contenido de auto ayuda para el cliente.");
                Console.WriteLine();
                Console.WriteLine("cerrarAyuda: Cerrar el modulo de ayuda y servicio al cliente");
                Console.WriteLine();
                Console.WriteLine("Ingresa 'x' para salir del programa.");
                Console.WriteLine();

                chosenActionAyuda = Console.ReadLine();

                switch (chosenActionAyuda)
                {
                    case "atenderCaso":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Atendiendo Caso...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "rechazarCaso":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("cerrando consulta...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "historialAyuda":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("historial de ayuda abierto...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "asistenteAyuda":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando asistente IA de ayuda...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "chatAyuda":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chat global abierto...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "tutorialesAyuda":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chequeando historial...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "cerrarAyuda":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Cerrando panel de inventario...");
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

            Environment.Exit(0);
        }
    }
}
