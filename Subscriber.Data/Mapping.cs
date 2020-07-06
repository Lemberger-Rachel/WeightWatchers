using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;


namespace Subscriber.Data
{
   public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Entities.SubscriberEntities,Services.Models.SubscriberModels>();
            CreateMap<Services.Models.SubscriberModels, Entities.SubscriberEntities>();
        }
      
    }
}
