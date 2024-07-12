using System;

namespace Admin_Page
{
    internal class Empleados
    {
        //existing variables
        protected string fullName;
        protected string email;
        protected string fiscalID;
        protected string phoneNumber;
        protected string bankAccountNumber;
        protected string bankID;
        protected string bankAccountType;
        protected int salary;

        //variables I would like to find

        protected int hoursWorked;
        protected int wage;

        public Empleados(string name, string em, string fID, string phN, string bnAccNb, string bnID, string bnAccTy, int sal, int hrW, int w)
        {
            fullName = name;
            email = em;
            fiscalID = fID;
            phoneNumber = phN;
            bankAccountNumber = bnAccNb;
            bankID = bnID;
            bankAccountType = bnAccTy;
            salary = sal;
            hoursWorked = hrW;
            wage = w;
        }

        public void displayEmployeeDetails()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("Detalles del Empleado");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"Nombre:",-20} {fullName}");
            Console.WriteLine($"{"Email:",-20} {email}");
            Console.WriteLine($"{"ID Fiscal:",-20} {fiscalID}");
            Console.WriteLine($"{"Número de Teléfono:",-20} {phoneNumber}");
            Console.WriteLine($"{"Número de Cuenta:",-20} {bankAccountNumber}");
            Console.WriteLine($"{"Banco:",-20} {bankID}");
            Console.WriteLine($"{"Tipo de Cuenta:",-20} {bankAccountType}");
            Console.WriteLine("------------------------------------------------------------------------------------------");
        }

        public void detallesEmpleados()
        {

            Empleados FelipeHernandez = new Empleados("Felipe Hernández", "fhernandez@fortechint.com", "03700973088", "8299193941", "778107623", "Banco Popular", "Ahorro", 5000, 40, 200000);

            FelipeHernandez.displayEmployeeDetails();

            Empleados EstebanRey = new Empleados("Felipe Hernández", "fhernandez@fortechint.com", "03700973088", "8299193941", "778107623", "Banco Popular", "Ahorro", 5000, 40, 200000);

            EstebanRey.displayEmployeeDetails();

            Empleados JoshuaDecastro = new Empleados("Felipe Hernández", "fhernandez@fortechint.com", "03700973088", "8299193941", "778107623", "Banco Popular", "Ahorro", 5000, 40, 200000);

            JoshuaDecastro.displayEmployeeDetails();

            Empleados MatiasLeon = new Empleados("Felipe Hernández", "fhernandez@fortechint.com", "03700973088", "8299193941", "778107623", "Banco Popular", "Ahorro", 5000, 40, 200000);

            MatiasLeon.displayEmployeeDetails();
        }


    }
}
