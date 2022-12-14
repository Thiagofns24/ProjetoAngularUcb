using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mission.API2.Models
{

public class Tarefa
{
        public Tarefa(string nome, string detalhes)
        {
            Id = Guid.NewGuid().ToString();
            Nome = nome;
            Detalhes = detalhes;
            Concluido = false;
            DataCadastro = DateTime.Now;
            DataConclusao = null;
        }

        public string Id { get; private set; }

    public string Nome { get; private set; }

    public string Detalhes { get; private set; }

    public DateTime? DataCadastro { get; private set; }

    public bool Concluido { get; private set; }

    public DateTime? DataConclusao { get; private set; }
}

}