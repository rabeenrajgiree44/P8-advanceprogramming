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
        class test1
        {
            public static void Main(string[] args)
            {
                EncapsulationByMemberHiding em = new EncapsulationByMemberHiding();
                var result = em.GetEmployeeId();
                Console.WriteLine(result);
            }

        }
    }
}