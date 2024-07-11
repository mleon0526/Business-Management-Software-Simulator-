using System;

namespace Admin_Page
{
    internal class Empleados
    {
        //existing variables
        public string fullName;
        public string email;
        public string fiscalID;
        public string phoneNumber;
        public string bankAccountNumber;
        public string bankID;
        public string bankAccountType;
        public int salary;

        //variables I would like to find

        public int hoursWorked;
        public int wage;

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

        public void calculateHoursWorked(int numberOfHours)
        {
            hoursWorked += numberOfHours;
            Console.WriteLine($"{fullName} a trabajado por un total de {numberOfHours} horas.");
        }

        public double calculateWage(bool restartHours = true)
        {
            wage = salary * hoursWorked;
            Console.WriteLine($"{fullName} gana un total de {wage} dolares.");

            if (restartHours)
                hoursWorked = 0;
            return wage;

        }

        public void findWereToDepositSalary()
        {
            Console.WriteLine($"Al empleado {fullName} se le deposita en el {bankID} a la cuenta #{bankAccountNumber} cuenta {bankAccountType}.");
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

    }
}
