using Subscriber.Services.Interfaces;
using Subscriber.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subscriber.Services
{
    public class SubscriberServices : ISubscriberServices
    {
        private readonly ISubscriberRepository subscriberRepository;
        public SubscriberServices(ISubscriberRepository subscriberRepository)
        {
            this.subscriberRepository = subscriberRepository;
        }
        public bool checkSubscriberEmail(string email,  string password)
        {
           return this.subscriberRepository.checkSubscriberEmail(email, password);
        }
    }
}
