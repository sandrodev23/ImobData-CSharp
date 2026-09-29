

namespace ConceitosC_
{
    internal class Proprietario
    {
        public string nomeCompleto;
        public string nascimento;
        public string cpf;
        public string endereco;
        
        public string dataCadastro;
        public string bairro;
        public string cidade;


        public string exibirMensagem()
        {
            
            Delay(3000);

           return "Cadastro realizado com sucesso!";
        }

        static void Delay(int tempo)
        {
            Thread.Sleep(tempo);
        }

        public void formatDados()
        {
            nomeCompleto = nomeCompleto.ToUpper();
            endereco = endereco.ToUpper();
            bairro = bairro.ToUpper();
            cidade = cidade.ToUpper();

            nascimento = formatData(nascimento);
            cpf = formatCpf(cpf);
        }
        private string formatData(string data)
        {
            if(data.Length == 8)
            {
                return data.Insert(2, "/").Insert(5, "/");
            }
            return data;
        }
        private string formatCpf(string cpf)
        {
            if (cpf.Length == 11)
            {
                return cpf.Insert(3, ".")
                    .Insert(7, ".")
                    .Insert(11, "-");
            }
            return cpf;
        }
    }
    
}
