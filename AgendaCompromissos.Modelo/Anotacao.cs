using System;

namespace AgendaCompromissos.Model;

public class Anotacao
{
    public string Texto { get; private set; }
    public DateTime DataCriacao { get; private set; }

    public Anotacao(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
        {
            throw new ArgumentException("O texto da anotação não pode ser vazio.");
        }

        Texto = texto;
        DataCriacao = DateTime.Now;
    }
}