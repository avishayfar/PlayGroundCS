using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDispatchTest
{
    class DoubleDispatch
    {
        public void TestDoubleDispatch()
        {
            Console.WriteLine("----  Double Dispatch ----");
            Employee managerAsEmployee = new Manager();
            BmwCar bmwCar = new BmwCar();

            managerAsEmployee.Name();
            bmwCar.Name();
            bmwCar.DrivingWith(managerAsEmployee);
        }


        public class Employee
        {
            public virtual void Name()
            {
                Console.WriteLine("I'm Employee");
            }
        }

        public class Manager : Employee
        {
            public override void Name()
            {
                Console.WriteLine("I'm Manager");
            }
        }

        public class BaseCar
        {
            public virtual void Name()
            {
                Console.WriteLine("I'm BaseCar");
            }

            public virtual void DrivingWith(Employee e)
            {
                Console.WriteLine("BaseCar with Employee");
            }

            public virtual void DrivingWith(Manager m)
            {
                Console.WriteLine("BaseCar with Manager");
            }
        }

        public class BmwCar : BaseCar
        {
            public override void Name()
            {
                Console.WriteLine("I'm BmwCar");
            }

            public override void DrivingWith(Employee e)
            {
                Console.WriteLine("BmwCar with Employee");
            }

            public override void DrivingWith(Manager m)
            {
                Console.WriteLine("BmwCar with Manager");
            }
        }
    }
}
