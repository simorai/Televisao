namespace TelevisaoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar o objeto meo do tipo Box(Classe)
            Box meo = new Box();
            //Box meo = null; //se a box nao tiver sido instanciada, entra no if e dá a mensagem correspondente

            //TODO dar uma vista de olhos nos objetos na memoria

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
                        if (meo.Estado == false)
                        {
                            meo.Ligar();
                            Console.WriteLine(meo.Mensagem); 
                        }
                        else
                        {
                            Console.WriteLine("Box já está ligada");
                        }
                        //meo.Mensagem = "ola"; //Metodo privado nao pode ser alterado
                        break;
                    case 2:
                        meo.Desligar();
                        Console.WriteLine(meo.Mensagem);
                        break;
                }
            }
        }
    }
}
