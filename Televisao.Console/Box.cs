namespace TelevisaoConsole
{
    /// <summary>
    /// Representa uma box de televisão com funcionalidades básicas de controle.
    /// </summary>
    public class Box
    {
        #region Atributos

        private int _canal;
        private int _volume;
        private string _mensagem;
        private int _numeroCanais;
        private bool _estado;

        #endregion

        #region Propriedades

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

        public string Mensagem
        {
            get
            {
                return _mensagem;
            }
            //private set { _mensagem = value; }            
        }

        public bool Estado
        {
            get
            {
                return _estado;
            }
        }

        #endregion

        #region Construtores
        public Box()
        {
            _estado = false;
            _canal = 1;
            _volume = 50;
            _mensagem = "Box criada com sucesso";
            _numeroCanais = 10;
        }

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
        /// Este método cria ou sobrescreve um ficheiro chamado "tvInfo.txt" com as informações atuais.
        /// O ficheiro conterá uma única linha com o formato "[canal] [volume]".
        /// Se o ficheiro não existir, será criado. Se já existir, seu conteúdo será substituído.
        /// </remarks>
        /// <exception cref="IOException">Pode ser lançada se houver problemas de acesso ao ficheiro.</exception>
        /// <exception cref="UnauthorizedAccessException">Pode ser lançada se o programa não tiver permissão para escrever no diretório.</exception>
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
