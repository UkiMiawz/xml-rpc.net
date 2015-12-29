using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace XmlRpcWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMaths
    {
        [OperationContract]
        int Addition(Math obj1);

        [OperationContract]
        int Subtraction(Math obj1);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Math
    {
        int number1, number2;

        [DataMember]
        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }

        [DataMember]
        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }
    }
}
