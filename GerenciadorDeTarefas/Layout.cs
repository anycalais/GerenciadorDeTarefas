namespace Layout
{
    class Formatacao
    {
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }
        public static void ImprimirCabecalho()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string titulo = "GERENCIADOR DE TAREFAS";
            int largura = 40;
       
    }
}
