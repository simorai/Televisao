namespace TelevisaoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma nova instância da classe Box
            Box meo = new Box();

            // TODO: Implementar uma forma de visualizar os objetos na memória

            // Verifica se a box foi criada com sucesso
            if (meo == null)
            {
                Console.WriteLine("A box ainda nao foi criada!");
            }
            else
            {
                Console.WriteLine("A box já foi criada!");
                int opcao;
                do
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("****** Comando da Box ******");
                        Console.WriteLine("1 - Ligar a Box");
                        Console.WriteLine("2 - Desligar a Box");
                        Console.WriteLine("0 - Sair");
                        Console.WriteLine("Escolha a opção");
                    } while (!int.TryParse(Console.ReadLine(), out opcao));
                } while (opcao < 0 || opcao > 2);

                switch (opcao)
                {
                    case 1:
                        // Tenta ligar a box se ela estiver desligada
                        if (meo.Estado == false)
                        {
                            meo.Ligar();
                            Console.WriteLine(meo.Mensagem); 
                        }
                        else
                        {
                            Console.WriteLine("Box já está ligada");
                        }                        
                        break;
                    case 2:
                        // Desliga a box
                        meo.Desligar();
                        Console.WriteLine(meo.Mensagem);
                        break;
                }
            }
        }
    }
}
