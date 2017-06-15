using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace C_Sharp_ExamplesCode
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceWCFTest" in both code and config file together.
    [ServiceContract]
    public interface IServiceWCFTest
    {
        [OperationContract]
        void DoWork();
    }
}
