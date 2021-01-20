using System;
using System.Collections.Generic;
using System.Text;
using ExemploEnum.Entities.Enums;

namespace ExemploEnum.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> ContractList { get; set; }

        public void addContract(HourContract contract)
        {
            ContractList.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            ContractList.Remove(contract);
        }
        
        public double income (int month, int year)
        {
            double total = 0;
            foreach (HourContract obj in ContractList)
            {
                total = total + obj.TotalValue();
            }
            return total;
        }
    }
}
