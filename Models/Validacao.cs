class Validacao
{
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
}