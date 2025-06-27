class Validacao
{
    //Validação Do Nome
     public bool ValidarNome(string nomeDigitado)
    {
        nomeDigitado = nomeDigitado.Trim();

        if (nomeDigitado.Length < 1)
        {
            return false;
        }

        string[] partesNome = nomeDigitado.Split(' ');

        if (partesNome.Length < 2)
        {
            return false;
        }

        int i = 0;
        while (i < partesNome.Length)
        {
            if (partesNome[i].Length < 2)
            {
                return false;
            }
            i = i + 1;
        }

        return true;
    }
    // Validação de Email
    public bool ValidarEmail(string emailDigitado)
    {
        emailDigitado = emailDigitado.Trim();

        if (emailDigitado.Length < 1)
        {
            return false;
        }

        int posicaoArroba = emailDigitado.IndexOf('@');

        if (posicaoArroba < 3)
        {
            return false;
        }

        int totalCaracteresDepois = emailDigitado.Length - (posicaoArroba + 1);

        if (totalCaracteresDepois < 3)
        {
            return false;
        }

        if (posicaoArroba == -1)
        {
            return false;
        }

        return true;
    }

        //Validação da Idade 
        public bool ValidarIdade(int idadeDigitada)
        {
            if (idadeDigitada >= 0)
            {
                if (idadeDigitada <= 150)
                {
                    return true;
                }
            }

            return false;
        }
}
