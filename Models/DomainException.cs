using System;

namespace AcquaJrApplication.Models
{
    public class DomainException : Exception
    {
        public DomainException(string mensagem) : base(mensagem) { }

        public static void When(bool condicao, string mensagem)
        {
            if (condicao)
            {
                throw new DomainException(mensagem);
            }
        }
    }
}
