using System;

namespace Admin_Page
{
    internal class Inventario
    {
        public static void inventario()
        {
            string chosenActionInventario = "";

            while (chosenActionInventario != "x")
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("Bienvenido al panel de inventario");
                Console.WriteLine();
                Console.WriteLine("planBasic: Edita y accede a los ajustes del plan Basic.");
                Console.WriteLine();
                Console.WriteLine("planStandard: Edita y accede a los ajustes del plan Standard.");
                Console.WriteLine();
                Console.WriteLine("planPremium: Edita y accede a los ajustes del plan Premium.");
                Console.WriteLine();
                Console.WriteLine("planPremiumPlus: Edita y accede a los ajustes del plan Premium Plus.");
                Console.WriteLine();
                Console.WriteLine("planPremiumPlusNomina: Edita y accede a los ajustes del plan Premium Plus Nomina .");
                Console.WriteLine();
                Console.WriteLine("historialInventario: chequea el historial de todos los clientes y sus planes");
                Console.WriteLine();
                Console.WriteLine("cerrarInventario: cerrar el modulo de inventario");
                Console.WriteLine();
                Console.WriteLine("Ingresa 'x' para salir del programa.");
                Console.WriteLine();

                chosenActionInventario = Console.ReadLine();

                switch (chosenActionInventario)
                {
                    case "planBasic":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando plan...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "planStandard":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando plan...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "planPremium":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando plan...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "planPremiumPlus":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando plan...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "planPremiumPlusNomina":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Editando plan...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "historialInventario":
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("Chequeando historial...");
                        Principal.WaitForCompletion();
                        Console.WriteLine();
                        break;

                    case "cerrarInventario":
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

            Environment.Exit(0); //exit program when x clicked
        }
    }
}
