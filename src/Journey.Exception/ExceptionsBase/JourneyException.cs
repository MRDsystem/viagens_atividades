using System.Net;

namespace Journey.Exception.ExceptionsBase
{
    public abstract class JourneyException : System.Exception //abstract: impede criar instancias dela. Apenas é possível criar instancias de classes que derivam dela
    {
        public JourneyException(string message) : base(message)
        {
            
        }

        public abstract HttpStatusCode GetStatusCode(); //Com essa função sem corpo (com ; no final), definida como abstract obrigado a sempre que usar a classe terem que implementar essa função
        public abstract IList<string> GetErrorMessages();
    }
}
