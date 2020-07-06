using System;
using System.Collections.Generic;
using System.Text;

namespace Subscriber.Services.Interfaces
{
    public interface ISubscriberRepository
    {
        bool checkSubscriberEmail(string email,string password);
    }
}
