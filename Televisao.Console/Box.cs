namespace TelevisaoConsole
{
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

        #region Metodos

        public Box()
        {
            _estado = false;
            _canal = 1;
            _volume = 50;
            _mensagem = "Box criada com sucesso";
            _numeroCanais = 10;
        }

        public void Ligar()
        {
            _estado = true;
            _mensagem = "Ligada com sucesso";
        }

        public void Desligar()
        {
            _estado = false;
            _mensagem = "Box desligada";
        }
        
        



        #endregion
    }
}
