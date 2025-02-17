using Layout;

using GerenciadorTarefa;


class Program
{
    static void Main()
    {   
        var gerenciador = new GerenciarTarefa();


        while (true)
        {
            Console.Clear();

            gerenciador.ListarTarefa();

            Formatacao.ImprimirCabecalho();
            Formatacao.Cor("1 - Adicionar Tarefa\n", ConsoleColor.White);
            Formatacao.Cor("2 - Listar Tarefas\n", ConsoleColor.White);
            Formatacao.Cor("3 - Concluir Tarefa\n", ConsoleColor.White);
            Formatacao.Cor("4 - Remover Tarefa\n", ConsoleColor.White);
            Formatacao.Cor("0 - Sair\n", ConsoleColor.White);
            Formatacao.Cor("Digite a opção aqui: \n", ConsoleColor.White);


            string opcao = Console.ReadLine();


            if (opcao == "0")
            {
                Formatacao.Cor("Saindo...", ConsoleColor.Red);
                break;
            }


            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Formatacao.Cor("Descreva a tarefa: \n", ConsoleColor.White);
                    string descricao = Console.ReadLine();
                    gerenciador.AdicionarTarefa(descricao);
                    break;


                case "2":
                    Console.Clear();
                    gerenciador.ListarTarefa();
                    break;


                case "3":
                    Console.Clear();
                    gerenciador.ListarTarefa();
                    Formatacao.Cor("\nDigite o Id da Tarefa que deseja concluir: ", ConsoleColor.White);
                    if (int.TryParse(Console.ReadLine(), out int idConcluir))
                    {
                        gerenciador.ConcluirTarefa(idConcluir);
                    }
                    break;


                case "4":
                    Console.Clear();
                    gerenciador.ListarTarefa();
                    Console.Write("Digite o ID da tarefa que deseja remover: ");
                    if (int.TryParse(Console.ReadLine(), out int idRemover))
                    {
                        gerenciador.RemoverTarefa(idRemover);
                    }
                    break;


                default:
                    Console.Clear();
                    Formatacao.Cor("Opção inválida! Tente novamente.\n", ConsoleColor.Red);
                    break;
            }


            Console.ReadKey();
        }
    }
}