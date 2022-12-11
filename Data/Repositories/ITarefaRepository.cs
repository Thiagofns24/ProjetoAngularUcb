using System;
using Mission.API2.Models;

namespace Mission.API2.Data.Repositories
{
	public interface ITarefaRepository
	{

		void Adicionar(Tarefa tarefa);

		void Atualizar(string id, Tarefa tarefaAtualizada);

		IEnumerable<Tarefa> Buscar();

		Tarefa Buscar(string id);


	}

}

