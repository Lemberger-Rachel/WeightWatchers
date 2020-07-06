using AutoMapper;
using Subscriber.Data.Entities;
using Subscriber.Services.Interfaces;
using Subscriber.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subscriber.Data
{
   public class SubscriberRepository : ISubscriberRepository
    {
        public SubscriberRepository()
        {
        }
        private readonly WeightWatchersContext context;
        private readonly IMapper _mapper;
        public SubscriberRepository(IMapper mapper,WeightWatchersContext context)
        {
            _mapper = mapper;
            this.context = context;
        }
        public bool checkSubscriberEmail(string email, string password)
        {
            foreach (var item in context.Subscribers)
            {
                if (item.Email==email&&item.Password==password)
                {
                    Console.WriteLine("User exist");
                    return true;
                }
            }
            //string flag = context.Subscribers.Find(subscriber.Email).ToString();
            //if (flag==null)
            //{ 
            //    createSubscriber(subscriber);
            //    return false;
            //}
           // createSubscriber(subscriber);
            return false;
        }
        public void createSubscriber(SubscriberModels sub)
        {
          var subscriber= _mapper.Map<SubscriberEntities>(sub);
          context.Subscribers.Add(subscriber);
          context.SaveChanges();
        }

    }
}
