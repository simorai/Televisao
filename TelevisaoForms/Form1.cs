using TelevisaoConsole;

namespace TelevisaoForms
{
    /// <summary>
    /// Representa o formulário principal da aplicação de controle de TV.
    /// Este formulário permite ao utilizador interagir com uma Box de TV,
    /// controlando o seu estado (ligado/desligado), canal e volume.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Obtém ou define a instância da Box de TV controlada por este formulário.
        /// Esta propriedade representa o modelo de dados principal com o qual
        /// a interface do utilizador interage.
        /// </summary>
        public Box Meo { get; set; }

        /// <summary>
        /// Inicializa uma nova instância do formulário Form1.
        /// Este construtor configura a interface do utilizador inicial e
        /// cria uma nova instância da Box de TV.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Cria uma nova instância da Box
            Meo = new Box();

            // Verifica se a Box foi criada com sucesso e configura a UI inicial
            if (Meo != null)
            {
                if (Meo != null)
                {
                    // Habilita o botão de ligar/desligar para interação do utilizador
                    btnOnOff.Enabled = true;
                    // Exibe a mensagem inicial da Box para fornecer feedback ao utilizador
                    lblInfo.Text = Meo.Mensagem;
                }
            }
        }

        /// <summary>
        /// Manipula o evento de clique no botão Ligar/Desligar.
        /// Este método alterna o estado da Box entre ligado e desligado,
        /// atualizando a interface do utilizador de acordo.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão OnOff.</param>
        /// <param name="e">Os argumentos do evento, não utilizados neste método.</param>
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (Meo.Estado)
            {
                // Lógica para desligar a Box e atualizar a UI
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
                // Lógica para ligar a Box e atualizar a UI
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
        /// Aumenta o canal da Box e atualiza a exibição do canal atual.
        /// Este método é chamado quando o utilizador clica no botão para aumentar o canal.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão de aumentar canal.</param>
        /// <param name="e">Os argumentos do evento, não utilizados neste método.</param>
        private void btnAumentaCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal++;
            lblCanal.Text = Meo.Canal.ToString();
        }

        /// <summary>
        /// Diminui o canal da Box e atualiza a exibição do canal atual.
        /// Este método é chamado quando o utilizador clica no botão para diminuir o canal.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão de diminuir canal.</param>
        /// <param name="e">Os argumentos do evento, não utilizados neste método.</param>
        private void btnDiminuiCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal--;
            lblCanal.Text = Meo.Canal.ToString();
        }

        /// <summary>
        /// Diminui o volume da Box e atualiza a barra de progresso do volume.
        /// Este método é chamado quando o utilizador clica no botão para diminuir o volume.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão de diminuir volume.</param>
        /// <param name="e">Os argumentos do evento, não utilizados neste método.</param>
        private void btnDiminuiVolume_Click(object sender, EventArgs e)
        {
            Meo.Volume--;
            progressBarVolume.Value = Meo.Volume;
        }

        /// <summary>
        /// Aumenta o volume da Box e atualiza a barra de progresso do volume.
        /// Este método é chamado quando o utilizador clica no botão para aumentar o volume.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o botão de aumentar volume.</param>
        /// <param name="e">Os argumentos do evento, não utilizados neste método.</param>
        private void btnAumentaVolume_Click_1(object sender, EventArgs e)
        {
            Meo.Volume++;
            progressBarVolume.Value = Meo.Volume;
        }

        /// <summary>
        /// Abre um novo formulário para criar uma nova Box.
        /// Este método é chamado quando o utilizador seleciona a opção de menu para criar uma nova Box.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento, tipicamente o item de menu.</param>
        /// <param name="e">Os argumentos do evento, não utilizados neste método.</param>
        private void novaBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria e exibe um novo formulário para criar uma nova Box
            frmNovaBox frmNova = new frmNovaBox(this);
            frmNova.Show();
        }
    }
}
