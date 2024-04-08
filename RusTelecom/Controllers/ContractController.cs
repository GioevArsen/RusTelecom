using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RusTelecom.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RusTelecom.Controllers
{
    public class ContractController : Controller
    {
        private readonly IContratsRepository contratsRepository;

        public ContractController(IContratsRepository contratsRepository)
        {
            this.contratsRepository = contratsRepository;
        }

        public IActionResult Index()
        {
            return View(contratsRepository);
        }

        public IActionResult Edit(int contractId)
        {
            var contract = contratsRepository.TryGetById(contractId);
            return View(contract);
        }

        [HttpPost]
        public IActionResult Change(int contractId, string lastname, string firstname, string secondname, string ip, string service, DateTime date)
        {
            var contract = contratsRepository.TryGetById(contractId);
            if(contract != null)
            {
                if (contratsRepository.Contracts.Contains(contract))
                {
                    contratsRepository.ChangeContract(contractId, new Contract(contractId, lastname, firstname, secondname, ip, service, date));
                }
            }
            else
            {
                contratsRepository.AddContract(new Contract(lastname, lastname, firstname, secondname, service, date));
            }

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
