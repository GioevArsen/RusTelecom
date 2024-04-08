using RusTelecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RusTelecom
{
    public class InMemoryContractsRepository : IContratsRepository
    {
        List<Contract> contracts = new List<Contract>
        {
            new Contract("Gussaov", "George", "Aslambeckovich", "69.69.69.69", "Интернет", new DateTime(2023, 12, 17)),
            new Contract("Sponge", "SquarePants", "Bob", "0.0.0.0", "IP-телефония", new DateTime(2020, 8, 17)),
            new Contract("Walter", "Hartwell", "White", "1.1.1.1", "Видеонаблюдение", new DateTime(2015, 2, 10)),
            new Contract("Sanakoev", "Arthur", "Vyacheslavovich", "7.7.7.7", "Интернет", new DateTime(2021, 10, 29)),
            new Contract("Yarlinski", "Oleg", "Vasilievich", "228.228.228.228", "Интернет", new DateTime(2023, 12, 25)),
            new Contract("Jesse", "Bruce", "Pinkman", "5.5.5.5", "IP-телефония", new DateTime(2017, 9, 15)),
            new Contract("Ivanov", "Ivan", "Ivanovich", "3.3.3.3", "IP-телефония", new DateTime(2018, 11, 8)),
            new Contract("Saul", "Gene", "Goodman", "17.17.17.17", "Видеонаблюдение", new DateTime(2016, 6, 21)),
            new Contract("John", "Smith", "Michael", "10.10.10.10", "Интернет", new DateTime(2019, 5, 20)),
            new Contract("Anna", "Johnson", "Elizabeth", "20.20.20.20", "IP-телефония", new DateTime(2020, 8, 15)),
            new Contract("Michael", "Williams", "David", "30.30.30.30", "Видеонаблюдение", new DateTime(2017, 11, 30)),
            new Contract("Sarah", "Brown", "Jessica", "40.40.40.40", "Интернет", new DateTime(2022, 3, 10)),
            new Contract("Matthew", "Jones", "Andrew", "50.50.50.50", "Видеонаблюдение", new DateTime(2018, 9, 25)),
            new Contract("Emily", "Miller", "Olivia", "60.60.60.60", "Интернет", new DateTime(2016, 12, 5)),
            new Contract("Daniel", "Davis", "William", "70.70.70.70", "IP-телефония", new DateTime(2023, 7, 18)),
            new Contract("Chloe", "Wilson", "Sophia", "80.80.80.80", "Видеонаблюдение", new DateTime(2019, 2, 14)),
            new Contract("Ethan", "Taylor", "Benjamin", "90.90.90.90", "Интернет", new DateTime(2021, 6, 28)),
            new Contract("Madison", "Anderson", "Isabella", "100.100.100.100", "IP-телефония", new DateTime(2017, 4, 3)),
            new Contract("Christopher", "Thomas", "Ethan", "110.110.110.110", "Видеонаблюдение", new DateTime(2020, 10, 9)),
            new Contract("Emma", "Jackson", "Charlotte", "120.120.120.120", "Интернет", new DateTime(2018, 1, 17)),
            new Contract("Alexander", "White", "James", "130.130.130.130", "IP-телефония", new DateTime(2019, 8, 22)),
            new Contract("Olivia", "Harris", "Sophia", "140.140.140.140", "Видеонаблюдение", new DateTime(2022, 5, 11)),
            new Contract("Noah", "Martinez", "Mason", "150.150.150.150", "Интернет", new DateTime(2017, 3, 7)),
            new Contract("Sophia", "Robinson", "Ava", "160.160.160.160", "IP-телефония", new DateTime(2020, 11, 28)),
            new Contract("James", "Clark", "Henry", "170.170.170.170", "Видеонаблюдение", new DateTime(2019, 9, 2)),
            new Contract("Isabella", "Rodriguez", "Mia", "180.180.180.180", "Интернет", new DateTime(2018, 7, 14)),
            new Contract("William", "Lewis", "Samuel", "190.190.190.190", "IP-телефония", new DateTime(2021, 4, 19)),
            new Contract("Grace", "Lee", "Lily", "200.200.200.200", "Видеонаблюдение", new DateTime(2016, 8, 30))
        };

        public List<Contract> Contracts
        {
            get { return contracts; }
            set { contracts = value; }
        }

        public Contract TryGetById(int id)
        {
            return Contracts.FirstOrDefault(contract => contract.Id == id);
        }

        public void AddContract(Contract contract)
        {
            Contracts.Add(contract);
        }

        public void ChangeContract(int id, Contract newContract)
        {
            var contract = Contracts.FirstOrDefault(contract => contract.Id == id);
            int index = Contracts.IndexOf(contract);
            Contracts[index] = newContract;
        }
    }

    public interface IContratsRepository
    {
        List<Contract> Contracts { get; set; }

        public Contract TryGetById(int id);

        public void AddContract(Contract contract);

        public void ChangeContract(int id, Contract newContract);
    }
}
