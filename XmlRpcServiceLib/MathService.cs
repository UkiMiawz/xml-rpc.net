using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace XmlRpcServiceLib
{
    [DataContract]
    public class Maths
    {
        [DataMember]
        public int Number1 { get; set; }
        [DataMember]
        public int Number2 { get; set; }
    }

    [ServiceContract]
    public interface IMaths
    {
        [OperationContract]
        int Addition(Maths obj1);
        [OperationContract]
        int Substraction(Maths obj1);
        [OperationContract]
        int Multiplication(Maths obj1);
        [OperationContract]
        int Division(Maths obj1);
    }
    class MathService : IMaths
    {
        #region IMaths implementation

        public int Addition(Maths obj1)
        {
            return (obj1.Number1 + obj1.Number2);
        }

        public int Division(Maths obj1)
        {
            return (obj1.Number1 / obj1.Number2);
        }

        public int Multiplication(Maths obj1)
        {
            return (obj1.Number1 * obj1.Number2);
        }

        public int Substraction(Maths obj1)
        {
            return (obj1.Number1 - obj1.Number2);
        }
        #endregion
    }
}
