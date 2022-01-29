using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    public class PessoaFisica : Pessoa, IpessoaFisica
    {
        public string ?cpf { get; set; }

        public DateTime ?dataNascimento { get; set; }
         
        public bool ValidarDataNascimento(DateTime datNasc)
        {
            throw new NotImplementedException();
        }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}