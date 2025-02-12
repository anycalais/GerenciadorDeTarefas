using Layout;

namespace Tarefa
{
    class Tarefas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public Tarefa(int id, string mensagem)
        {
            Id = id;
            Descricao = mensagem;
            Concluida = false;
        }

        public void ExibirTarefa()
        {
            Console.WriteLine($"[{(Concluida ? "X" : " ")}] - ID: {Id} - {Descricao}", ConsoleColor.Yellow);
        }
    }
}