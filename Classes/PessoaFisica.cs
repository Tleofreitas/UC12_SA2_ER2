using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    public class PessoaFisica : Pessoa, IpessoaFisica
    {
        public string ?cpf { get; set; }

        public string ?Endereco { get; set; }     

        public string ?dataNascimento { get; set; }
         
        // public bool ValidarDataNascimento(DateTime dataNasc)
        // {
        //     DateTime dataAtual = DateTime.Today;
        //     double anos = (dataAtual - dataNasc).TotalDays / 365;

        //     if (anos >= 18)
        //     {
        //         return true;
        //     }
        //     return false;
        // }

        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                Console.WriteLine($"{dataConvertida}");
                
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }
                return false;       
            }
            return false;
        }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime datNasc)
        {
            throw new NotImplementedException();
        }
    }
}