using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public abstract class Worker
    {
        protected int wage;
        protected int experience;
        protected int countDayOff;
        public Worker(int wage, int experience, int countDayOff)
        {
            this.wage = wage;
            this.experience = experience;
            this.countDayOff = countDayOff;
        }
        public abstract void PrintInfo();
    }
    public abstract class Manage : Worker
    {
        protected List<Work> workers;
        public Manage(int wage, int experience, int countDayOff, List<Work> workers) : base(wage, experience, countDayOff)
        {
            this.workers = new List<Work>(); 
            this.workers = workers;
        }
        private void Workers()
        {
            foreach(Work worker in this.workers)
            {
                Console.WriteLine(worker.Name);
            }
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{wage} {experience}");
            Workers();
        }
    }
    public abstract class Work : Worker
    {
        public readonly string Name;
        public Work(int wage, int experience, int countDayOff,string name) : base(wage, experience, countDayOff)
        {
            this.Name = name;
        }
        public abstract void product();
        public override void PrintInfo()
        {
            Console.WriteLine($"{wage} {experience}");
        }
    }
    public class Director : Manage
    {
        public Director(int wage, int experience, int countDayOff, List<Work> workers) : base(wage, experience, countDayOff, workers)
        {

        }

    }
    public class Manager : Manage
    {
        public Manager(int wage, int experience, int countDayOff, List<Work> workers) : base(wage, experience, countDayOff, workers)
        {

        }
    }
    public class Engineer : Work
    {
        public Engineer(int wage, int experience, int countDayOff, string name) : base(wage, experience, countDayOff, name)
        {

        }
        public override void product()
        {
            Console.WriteLine("Чертеж детали");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{wage} {experience} {countDayOff}");
        }
    }
    public class Mechanic : Work
    {
        public Mechanic(int wage, int experience, int countDayOff, string name) : base(wage, experience, countDayOff, name)
        {

        }
        public override void product()
        {
            Console.WriteLine("Собрана деталь");
        }
    }
    public class ArchitecturalEngineer : Work
    {
        public ArchitecturalEngineer(int wage, int experience, int countDayOff, string name) : base(wage, experience, countDayOff, name)
        {

        }
        public override void product()
        {
            Console.WriteLine("Чертеж проэкта");
        }
    }
}
