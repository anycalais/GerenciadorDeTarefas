namespace Tarefa
{
    class Tarefa
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
            Console.WriteLine($"[{(Concluida ? "X" : " ")}] - ID: {Id} - {Descricao}");
        }
    }
}