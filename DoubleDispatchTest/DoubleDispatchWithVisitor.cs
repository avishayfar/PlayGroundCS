using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDispatchTest
{
    class DoubleDispatchWithVisitor
    {
        public void TestDoubleDispatch()
        {
            Console.WriteLine();
            Console.WriteLine("--  DoubleD ispatch with visitor --");
            Employee managerAsEmployee = new Manager();
            BaseCar bmwAscar = new BmwCar();

            managerAsEmployee.Name();
            bmwAscar.Name();
            bmwAscar.Accept(managerAsEmployee);
        }


        
        public class Employee
        {
            public virtual void Name()
            {
                Console.WriteLine("I'm Employee");
            }

            public virtual void Visit(BaseCar bc)
            {
                //bc.DrivingWith(this);
                Console.WriteLine("BaseCar with Employee");
            }

            public virtual void Visit(BmwCar bmw)
            {
                Console.WriteLine("BmwCar with Employee");
            }
        }

        public class Manager : Employee
        {
            public override void Name()
            {
                Console.WriteLine("I'm Manager");
            }

            public override void Visit(BaseCar bc)
            {
                //bc.DrivingWith(this);
                Console.WriteLine("BaseCar with Manager");
            }

            public override void Visit(BmwCar bmw)
            {
                //bmw.DrivingWith(this);
                Console.WriteLine("BmwCar with Manager");
            }
        }

        public class BaseCar
        {
            public virtual void Name()
            {
                Console.WriteLine("I'm BaseCar");
            }

            public virtual void Accept(Employee e)
            {
                e.Visit(this);
            }

          
        }

        public class BmwCar : BaseCar
        {
            public override void Name()
            {
                Console.WriteLine("I'm BmwCar");
            }

            public override void Accept(Employee e)
            {
                e.Visit(this);
            }

           
        }
    }
}
