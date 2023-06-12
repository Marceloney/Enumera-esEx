using System.Collections.Generic;
using System.Diagnostics.Contracts;
using CourseUdemy03.Entities.Enums;



namespace CourseUdemy03.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament departament { get; set; }
        public List<HourContract> contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalario, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalario;
            this.departament = departament;
        }

        public void AddContract(HourContract cantract)
        {
            contracts.Add(cantract);
        }

        public void RemoveContract(HourContract contract)
        {
            contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in contracts)
            {
                if (contract.Date.Year ==  year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
              
               
            }
            return sum;
        }
       

    }
}
