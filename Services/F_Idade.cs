class F_Idade
{
    public ResultadoPesquisaIdade CalcularPessoaMaisNovaEMaisVelha(Pessoa[] pessoas)
    {
        int menorIdadePessoa = pessoas[0].Idade;
        int maiorIdadePessoa = pessoas[0].Idade;

        for (int i = 1; i < pessoas.Length; i++)
        {
            Pessoa pessoa = pessoas[i];

            if (pessoa.Idade < menorIdadePessoa)
            {
                menorIdadePessoa = pessoa.Idade;
            }

            if (pessoa.Idade > maiorIdadePessoa)
            {
                maiorIdadePessoa = pessoa.Idade;
            }
        }

        return new ResultadoPesquisaIdade(menorIdadePessoa, maiorIdadePessoa);
    }
}