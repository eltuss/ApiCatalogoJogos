using System;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException()
            : base("Este jogo n�o est� cadastrado")
        { }
    }
}
