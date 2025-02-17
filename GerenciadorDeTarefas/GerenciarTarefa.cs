using Layout;
using Tarefas;

namespace GerenciadorTarefa
{
    class GerenciarTarefa
    {
        private List<Tarefa> listaDeTarefas = new List<Tarefa>();
        private int contadorId = 1;

        public void AdicionarTarefa(string descricao)
        {
            listaDeTarefas.Add(new Tarefa(contadorId, descricao));
            contadorId++;
            Formatacao.Cor("Tarefa adicionada!\n", ConsoleColor.Green);
        }

        public void ConcluirTarefa(int id)
        {
            foreach (var tarefa in listaDeTarefas)
            {
                if (tarefa.Id == id)
                {
                    tarefa.Concluida = true;
                    Formatacao.Cor("Tarefa concluída!\n", ConsoleColor.Green);
                    return;
                }
            }
            Formatacao.Cor("Tarefa não encontrada!\n", ConsoleColor.Red);
        }

        public void ListarTarefa()
        {
            Formatacao.Cor("Tarefas:", ConsoleColor.White);
            foreach (var tarefa in listaDeTarefas)
            {
                tarefa.ExibirTarefa();
            }
            Console.WriteLine();
        }

        public void RemoverTarefa(int id)
        {
            listaDeTarefas.RemoveAll(t => t.Id == id);
            Formatacao.Cor("Tarefa removida!", ConsoleColor.Red);
        }
    }
}