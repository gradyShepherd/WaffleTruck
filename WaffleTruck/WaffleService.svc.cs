using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WaffleTruck
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WaffleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WaffleService.svc or WaffleService.svc.cs at the Solution Explorer and start debugging.
    public class WaffleService : IWaffleService
    {
        string IWaffleService.ShowMenu()
        {
            return "Strawberry Waffles,Belgian Waffles,Peanut Butter Waffles,Chocolcate Waffles";
        }
    }
}
