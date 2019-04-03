using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    [Serializable]
    public class IncorrectPersonalInformationException : Exception, ISerializable
    {
        //Storage of information about the worker in which the exception occurred
        public Worker WrongWorker { get; private set; }

        //Ctors
        public IncorrectPersonalInformationException()
        {
        }
        public IncorrectPersonalInformationException(Worker wrongWorker)
        {
            WrongWorker = wrongWorker;
        }
        public IncorrectPersonalInformationException(Worker wrongWorker, string message) : base(message)
        {
            WrongWorker = wrongWorker;
        }
        public IncorrectPersonalInformationException(Worker wrongWorker, string message, Exception innerException) : base(message, innerException)
        {
            WrongWorker = wrongWorker;
        }

        //Work with serialization
        protected IncorrectPersonalInformationException(SerializationInfo info, StreamingContext context)
        {
            WrongWorker = (Worker)info.GetValue("WrongWorker", typeof(Worker));
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("WrongWorker", WrongWorker, typeof(Worker));
        }
    }
}
