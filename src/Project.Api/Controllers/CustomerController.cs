using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Application.Interfaces;
using Project.Application.ViewModels;
using Project.Domain.Core.Notifications;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Api.Controllers
{
    [Authorize]
    public class CustomerController : BaseController
    {
        private readonly JsonSerializerSettings _serializerSettings;
        private readonly ICustomerAppService _customerAppService;

        public CustomerController(ICustomerAppService customerAppService, IDomainNotificationHandler<DomainNotification> notifications) : base(notifications)
        {
            _customerAppService = customerAppService;
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("customer-management/list-all")]
        public IEnumerable<CustomerViewModel> GetAll()
        {
            //return View(_customerAppService.GetAll());
            return _customerAppService.GetAll();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("customer-management/register-new")]
        public IActionResult Create([FromBody]CustomerViewModel customerViewModel)
        {
            var json = JsonConvert.SerializeObject(customerViewModel, _serializerSettings);
            if (!ModelState.IsValid) return new ObjectResult(json);
            _customerAppService.Register(customerViewModel);
            return IsValidOperation() ? new ObjectResult("Customer successfully registered!") : new ObjectResult(json);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("customer-management/edit-customer")]
        public IActionResult Edit([FromBody]CustomerViewModel customerViewModel)
        {
            var json = JsonConvert.SerializeObject(customerViewModel, _serializerSettings);
            if (!ModelState.IsValid) return new ObjectResult(json);
            _customerAppService.Update(customerViewModel);

            return IsValidOperation() ? new ObjectResult("Customer updated!") : new ObjectResult(json);
        }
    }

}
