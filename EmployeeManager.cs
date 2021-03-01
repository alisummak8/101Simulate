using System;
using System.Collections.Generic;
using System.Text;

namespace _101Simulate
{
    class EmployeeManager : IPersonService
    {
        public void Update(Person person)
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }
}
