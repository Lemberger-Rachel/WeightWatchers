using Subscriber.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subscriber.Services.Interfaces
{
  public interface ISubscriberServices
    {
        bool checkSubscriberEmail(string email, string password);
    }
}
