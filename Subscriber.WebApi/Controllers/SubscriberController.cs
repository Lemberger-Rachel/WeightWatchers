using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Subscriber.Data.Entities;
using Subscriber.Services.Interfaces;
using Subscriber.Services.Models;


namespace Subscriber.WebApi.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class SubscriberController : Controller
    {
        private readonly ISubscriberServices SubscriberServices;
        private readonly IMapper _mapper;

        public SubscriberController(IMapper mapper,ISubscriberServices subscriberServices)
        {
            SubscriberServices = subscriberServices;
            _mapper = mapper;
        }

        //[AllowAnonymous]
        [HttpPost]
        public bool Post([FromBody] SubscriberModels subscriber )
        {
            // return SubscriberServices.checkSubscriberEmail(subscriber);
            return true;
        }
        [HttpPost]
        public bool Post([FromQuery] string email, [FromQuery] string password)
        {
            return SubscriberServices.checkSubscriberEmail(email,password);

        }

    }
}
