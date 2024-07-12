using System;

namespace Admin_Page.RecursosHumanosFolder
{
    internal class EditarDetallesEmpleados : Empleados
    {
        public EditarDetallesEmpleados(string name, string em, string fID, string phN, string bnAccNb, string bnID, string bnAccTy, int sal, int hrW, int w)
            : base(name, em, fID, phN, bnAccNb, bnID, bnAccTy, sal, hrW, w)
        {
        }

        public static void editarEmpleados()
        {
            // Implementation for editing employee details here
            // Example: editing hours worked or salary
            EditarDetallesEmpleados empleado = new EditarDetallesEmpleados("Sample Name", "sample@example.com", "123456789", "1234567890", "123456789", "Sample Bank", "Savings", 5000, 40, 200000);
            empleado.fullName = "Pepito"; // Example of editing an employee detail
            Console.WriteLine("Empleado editado:");
            empleado.displayEmployeeDetails();
        }
    }
}

