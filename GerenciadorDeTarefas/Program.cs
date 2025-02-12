using Layout;
using GerenciarTarefa;
using Tarefas;

class Program
{
    static void Main()
    {
        Gerenciador gerenciador = new Gerenciador();

        while (true)
        {   
    
            Formatacao.ImprimirCabecalho();
            Formatacao.Cor("\n1 - Adicionar Tarefa\n", ConsoleColor.White);
            Formatacao.Cor("2 - Listar Tarefas\n", ConsoleColor.White);
            Formatacao.Cor("3 - Concluir Tarefa\n", ConsoleColor.White);
            Formatacao.Cor("4 - Remover Tarefa\n", ConsoleColor.White);
            Formatacao.Cor("0 - Sair\n", ConsoleColor.White);
            Formatacao.Cor("\nEscolha uma opção: ", ConsoleColor.White);
            
        }
    }
}