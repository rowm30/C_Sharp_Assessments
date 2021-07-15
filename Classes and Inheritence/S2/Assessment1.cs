using System;

namespace S2
{
    public class Employee
    {
        public string name;
        public decimal BasicSalery;
        public decimal HRA;
        public decimal DA;
        public decimal TAX;
        public decimal Grosspay;
        public decimal NetSalery;

        public void CalcHRA()
        {
            HRA = BasicSalery * 0.15;
        }

        public void CalcDA()
        {
            DA = BasicSalery * 0.1;
        }

        public void CalcGrosspay()
        {
            Grosspay = BasicSalery + HRA + DA;
        }

        public void CalcTAX()
        {
            TAX = Grosspay * 0.08;
        }

        public void CalcNetpay()
        {
            NetSalery = Grosspay - TAX;
        }

        public Employee(string name,int basicSalary)
        {
            this.name = name;
            this.BasicSalery = basicSalary;
        }

        public void displaySalery()
        {
            Console.WriteLine("This man name is {0} gets inhand cash {1}",name,BasicSalery);
        }
    }

    public class Assessment1{
        public static void main(String[] args)
        {
            Employee mayank = new Employee("Mayank", 10000);
            mayank.displaySalery();

        }
    }
}