using System;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base("Este j� jogo est� cadastrado")
        { }
    }
}
