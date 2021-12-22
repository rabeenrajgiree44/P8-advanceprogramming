using System;
using System.Collections.Generic;
using System.Text;

namespace LoopOneToTen
{
    class EncapsulationByMemberHiding
    {
        private int employeeId = 5;
        public int GetEmployeeId()
        {
            return employeeId;
        }

        public void SetEmployeeId(int empID)
        {
            employeeId = empID;
        }

        public int EmployeeId
        {
            get
            {
                return this.employeeId;
            }

            set
            {
                employeeId = value;
            }
        }
        class test1
        {
            public static void Main(string[] args)
            {
                EncapsulationByMemberHiding em = new EncapsulationByMemberHiding();
                Console.WriteLine(em.EmployeeId);
                em.EmployeeId = 12;
                //Console.WriteLine("Input any value");
                //int value = Convert.ToInt32(Console.ReadLine());
                //em.SetEmployeeId(value);
                var result = em.GetEmployeeId();
                Console.WriteLine(result);
            }

        }
    }
}