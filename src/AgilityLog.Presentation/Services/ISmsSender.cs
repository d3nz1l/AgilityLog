using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilityLog.Presentation.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
