using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static BitRaceWcfService.Enums;
using static BitRaceWcfService.Enums.SQLState;

namespace BitRaceWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BitRaceWcfService1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BitRaceWcfService1.svc or BitRaceWcfService1.svc.cs at the Solution Explorer and start debugging.
    public class BitRaceWcfService : IBitRaceWcfService
    {
        public string GetData(int value)
        {
            if (value == 0)
            {
                return Controller.
            }
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
