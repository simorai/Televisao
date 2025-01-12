using TelevisaoConsole;

namespace TelevisaoForms
{
    /// <summary>
    /// Representa o formul�rio principal da aplica��o de controle de TV.
    /// Este formul�rio permite ao utilizador interagir com uma Box de TV,
    /// controlando o seu estado (ligado/desligado), canal e volume.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Obt�m ou define a inst�ncia da Box de TV controlada por este formul�rio.
        /// Esta propriedade representa o modelo de dados principal com o qual
        /// a interface do utilizador interage.
        /// </summary>
        public Box Meo { get; set; }

        /// <summary>
        /// Inicializa uma nova inst�ncia do formul�rio Form1.
        /// Este construtor configura a interface do utilizador inicial e
        /// cria uma nova inst�ncia da Box de TV.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Cria uma nova inst�ncia da Box
            Meo = new Box();

            // Verifica se a Box foi criada com sucesso e configura a UI inicial
            if (Meo != null)
            {
                if (Meo != null)
                {
                    // Habilita o bot�o de ligar/desligar para intera��o do utilizador
                    btnOnOff.Enabled = true;
                    // Exibe a mensagem inicial da Box para fornecer feedback ao utilizador
                    lblInfo.Text = Meo.Mensagem;
                }
            }
        }

        /// <summary>
        /// Manipula o evento de clique no bot�o Ligar/Desligar.
        /// Este m�todo alterna o estado da Box entre ligado e desligado,
        /// atualizando a interface do utilizador de acordo.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o bot�o OnOff.</param>
        /// <param name="e">Os argumentos do evento, n�o utilizados neste m�todo.</param>
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (Meo.Estado)
            {
                // L�gica para desligar a Box e atualizar a UI
                Meo.Desligar();
                lblInfo.Text = Meo.Mensagem;
                btnOnOff.Text = "Ligar";
                // Desativa controlos relacionados com canais e volume
                groupBoxCanais.Enabled = false;
                lblCanal.Text = "-";
                groupBoxVolume.Enabled = false;
                progressBarVolume.Value = 0;

            }
            else
            {
                // L�gica para ligar a Box e atualizar a UI
                Meo.Ligar();
                lblInfo.Text = Meo.Mensagem;
                btnOnOff.Text = "desligar";
                // Ativa controlos relacionados com canais e volume
                groupBoxCanais.Enabled = true;
                lblCanal.Text = Meo.Canal.ToString();
                groupBoxVolume.Enabled = true;
                progressBarVolume.Value = Meo.Volume;
            }
        }

        /// <summary>
        /// Aumenta o canal da Box e atualiza a exibi��o do canal atual.
        /// Este m�todo � chamado quando o utilizador clica no bot�o para aumentar o canal.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o bot�o de aumentar canal.</param>
        /// <param name="e">Os argumentos do evento, n�o utilizados neste m�todo.</param>
        private void btnAumentaCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal++;
            lblCanal.Text = Meo.Canal.ToString();
        }

        /// <summary>
        /// Diminui o canal da Box e atualiza a exibi��o do canal atual.
        /// Este m�todo � chamado quando o utilizador clica no bot�o para diminuir o canal.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o bot�o de diminuir canal.</param>
        /// <param name="e">Os argumentos do evento, n�o utilizados neste m�todo.</param>
        private void btnDiminuiCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal--;
            lblCanal.Text = Meo.Canal.ToString();
        }

        /// <summary>
        /// Diminui o volume da Box e atualiza a barra de progresso do volume.
        /// Este m�todo � chamado quando o utilizador clica no bot�o para diminuir o volume.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o bot�o de diminuir volume.</param>
        /// <param name="e">Os argumentos do evento, n�o utilizados neste m�todo.</param>
        private void btnDiminuiVolume_Click(object sender, EventArgs e)
        {
            Meo.Volume--;
            progressBarVolume.Value = Meo.Volume;
        }

        /// <summary>
        /// Aumenta o volume da Box e atualiza a barra de progresso do volume.
        /// Este m�todo � chamado quando o utilizador clica no bot�o para aumentar o volume.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o bot�o de aumentar volume.</param>
        /// <param name="e">Os argumentos do evento, n�o utilizados neste m�todo.</param>
        private void btnAumentaVolume_Click_1(object sender, EventArgs e)
        {
            Meo.Volume++;
            progressBarVolume.Value = Meo.Volume;
        }

        /// <summary>
        /// Abre um novo formul�rio para criar uma nova Box.
        /// Este m�todo � chamado quando o utilizador seleciona a op��o de menu para criar uma nova Box.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o item de menu.</param>
        /// <param name="e">Os argumentos do evento, n�o utilizados neste m�todo.</param>
        private void novaBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria e exibe um novo formul�rio para criar uma nova Box
            frmNovaBox frmNova = new frmNovaBox(this);
            frmNova.Show();
        }
    }
}
