namespace TelevisaoConsole
{
    /// <summary>
    /// Representa uma box de televisão com funcionalidades básicas de controle.
    /// Esta classe encapsula as operações e o estado de uma box de TV, incluindo
    /// controle de canal, volume, estado de energia e persistência de dados.
    /// </summary>
    public class Box
    {
        #region Atributos
        /// <summary>
        /// O canal atual da box.
        /// Este valor é limitado pelo número total de canais disponíveis.
        /// </summary>
        private int _canal;
        /// <summary>
        /// O volume atual da box.
        /// Este valor é limitado entre 0 e 100.
        /// </summary>
        private int _volume;
        /// <summary>
        /// Mensagem de status da box.
        /// Utilizada para fornecer feedback sobre operações realizadas na box.
        /// </summary>
        private string _mensagem;
        /// <summary>
        /// O número total de canais disponíveis.
        /// Este valor é definido na criação da box e limita o intervalo de canais válidos.
        /// </summary>
        private int _numeroCanais;
        /// <summary>
        /// O estado atual da box (ligada ou desligada).
        /// True indica que a box está ligada, false indica que está desligada.
        /// </summary>
        private bool _estado;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o canal atual da box.
        /// </summary>
        /// <value>
        /// O canal atual, um valor inteiro entre 0 e o número máximo de canais.
        /// Se um valor fora deste intervalo for atribuído, a propriedade não será alterada.
        /// </value>
        /// <remarks>
        /// Esta propriedade verifica se o valor atribuído está dentro do intervalo válido
        /// antes de alterar o canal atual.
        /// </remarks>
        public int Canal
        {
            get
            {
                return _canal;
            }
            set
            {
                if (value >= 0 && value <= _numeroCanais)
                {
                    _canal = value;
                }
            }
        }

        /// <summary>
        /// Obtém ou define o volume atual da box.
        /// </summary>
        /// <value>
        /// O volume atual, um valor inteiro entre 0 e 100.
        /// Se um valor fora deste intervalo for atribuído, a propriedade não será alterada.
        /// </value>
        /// <remarks>
        /// Esta propriedade verifica se o valor atribuído está dentro do intervalo válido
        /// antes de alterar o volume atual.
        /// </remarks>
        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _volume = value;
                }
            }
        }

        /// <summary>
        /// Obtém a mensagem de status atual da box.
        /// </summary>
        /// <value>
        /// Uma string contendo a mensagem de status atual.
        /// Esta mensagem é atualizada por vários métodos da classe para fornecer feedback.
        /// </value>
        /// <remarks>
        /// Esta propriedade é somente leitura. A mensagem é atualizada internamente
        /// pelos métodos da classe.
        /// </remarks>
        public string Mensagem
        {
            get
            {
                return _mensagem;
            }
            //private set { _mensagem = value; }            
        }

        /// <summary>
        /// Obtém o estado atual da box.
        /// </summary>
        /// <value>
        /// True se a box estiver ligada, false caso contrário.
        /// </value>
        /// <remarks>
        /// Esta propriedade é somente leitura. O estado é alterado pelos métodos
        /// Ligar() e Desligar().
        /// </remarks>
        public bool Estado
        {
            get
            {
                return _estado;
            }
        }

        #endregion

        #region Construtores

        /// <summary>
        /// Inicializa uma nova instância da classe Box com configurações padrão.
        /// </summary>
        /// <remarks>
        /// Este construtor cria uma box com as seguintes configurações:
        /// - Estado: Desligada
        /// - Canal inicial: 1
        /// - Volume inicial: 50
        /// - Número de canais: 10
        /// </remarks>
        public Box()
        {
            _estado = false;
            _canal = 1;
            _volume = 50;
            _mensagem = "Box criada com sucesso";
            _numeroCanais = 10;
        }

        /// <summary>
        /// Inicializa uma nova instância da classe Box com um número específico de canais.
        /// </summary>
        /// <param name="numeroCanais">O número total de canais disponíveis.</param>
        /// <remarks>
        /// Este construtor cria uma box com as seguintes configurações:
        /// - Estado: Desligada
        /// - Canal inicial: 1
        /// - Volume inicial: 50
        /// - Número de canais: Especificado pelo parâmetro numeroCanais
        /// </remarks>
        public Box(int numeroCanais)
        {
            _estado = false;
            _canal = 1;
            _volume = 50;
            _mensagem = "Box criada com sucesso";
            _numeroCanais = numeroCanais;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Liga a box e tenta ler as informações salvas anteriormente.
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes operações:
        /// 1. Tenta ler as informações salvas (canal e volume) do arquivo.
        /// 2. Se a leitura for bem-sucedida, atualiza o canal e o volume da box.
        /// 3. Se ocorrer uma exceção durante a leitura, a mensagem de erro é armazenada.
        /// 4. Altera o estado da box para ligada.
        /// 5. Atualiza a mensagem de status.
        /// </remarks>
        public void Ligar()
        {
            try
            {
                LerInfo();
            }
            catch (Exception e)
            {
                _mensagem = e.Message;                
            }
            _estado = true;
            _mensagem = "Ligada com sucesso";
        }

        /// <summary>
        /// Desliga a box e tenta gravar as informações atuais.
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes operações:
        /// 1. Altera o estado da box para desligada.
        /// 2. Tenta gravar as informações atuais (canal e volume) no arquivo.
        /// 3. Se ocorrer uma exceção durante a gravação, a mensagem de erro é armazenada.
        /// 4. Atualiza a mensagem de status.
        /// </remarks>
        public void Desligar()
        {
            _estado = false;

            try
            {
                GravarInfo();
            }
            catch (Exception e)
            {
                _mensagem = e.Message;
            }            
            _mensagem = "Box desligada";
        }


        /// <summary>
        /// Grava a informação atual do canal e volume da TV num ficheiro de texto.
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes operações:
        /// 1. Define o nome do arquivo como "tvInfo.txt".
        /// 2. Cria uma linha de texto com o canal e volume atuais.
        /// 3. Abre um StreamWriter para escrever no arquivo (sobrescrevendo o conteúdo existente).
        /// 4. Se o arquivo não existir, cria um novo.
        /// 5. Escreve a linha de informação no arquivo.
        /// 6. Fecha o StreamWriter para salvar as alterações e liberar recursos.
        /// </remarks>
        /// <exception cref="IOException">
        /// Lançada se houver problemas de acesso ao arquivo, como permissões insuficientes ou disco cheio.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// Lançada se o programa não tiver permissão para escrever no diretório especificado.
        /// </exception>
        private void GravarInfo()
        {
            // Define o nome do ficheiro onde a informação será gravada.
            string ficheiro = @"tvInfo.txt";

            // Cria uma linha de texto com o canal e volume atuais.
            string linha = $"{_canal} {_volume}";

            // Cria um StreamWriter para escrever no ficheiro. O segundo parâmetro 'false' indica que o ficheiro será sobrescrito, não anexado.
            StreamWriter sw = new StreamWriter(ficheiro, false);

            // Verifica se o ficheiro existe. Se não existir, cria um novo.
            if (!File.Exists(ficheiro))
            {
                sw = File.CreateText(ficheiro);
            }

            // Escreve a linha de informação no ficheiro.
            sw.WriteLine(linha);

            // Fecha o StreamWriter para libertar recursos e garantir que os dados sejam gravados.
            sw.Close();
        }

        /// <summary>
        /// Lê as informações de canal e volume de um ficheiro de texto e atualiza a box.
        /// </summary>
        /// <remarks>
        /// Este método realiza as seguintes operações:
        /// 1. Verifica se o arquivo "tvInfo.txt" existe.
        /// 2. Se existir, abre o arquivo para leitura.
        /// 3. Lê cada linha do arquivo.
        /// 4. Divide a linha em campos usando ';' como separador.
        /// 5. Se houver dois campos, converte-os para inteiros e atualiza o canal e o volume da box.
        /// 6. Fecha o StreamReader após a leitura.
        /// </remarks>
        /// <exception cref="IOException">
        /// Lançada se houver problemas de acesso ao arquivo, como permissões insuficientes.
        /// </exception>
        /// <exception cref="FormatException">
        /// Lançada se os dados no arquivo não estiverem no formato esperado (dois números inteiros separados por ';').
        /// </exception>
        private void LerInfo()
        {
            string ficheiro = @"tvInfo.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);
                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = new string[2];
                    campos = linha.Split(';');

                    Canal = Convert.ToInt32(campos[0]);
                    Volume = Convert.ToInt32(campos[1]);
                }
                sr.Close();
            }
        }


        #endregion
    }
}
