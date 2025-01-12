using TelevisaoConsole;

namespace TelevisaoForms
{
    /// <summary>
    /// Formulário para criar uma nova instância de Box.
    /// Este formulário permite ao utilizador especificar o número de canais para uma nova Box
    /// e comunica com o formulário principal para atualizar a Box existente.
    /// </summary>
    public partial class frmNovaBox : Form
    {
        /// <summary>
        /// Referência ao formulário principal da aplicação.
        /// Utilizada para comunicar alterações na Box entre formulários.
        /// </summary>
        Form1 _formPrincipal;

        /// <summary>
        /// Inicializa uma nova instância do formulário frmNovaBox.
        /// </summary>
        /// <param name="principal">Referência ao formulário principal da aplicação.</param>
        public frmNovaBox(Form1 principal)
        {
            InitializeComponent();
            _formPrincipal = principal;            
        }

        /// <summary>
        /// Manipula o evento de clique no botão Cancelar.
        /// Fecha o formulário atual sem criar uma nova Box.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Manipula o evento de clique no botão OK.
        /// Valida os dados inseridos, cria uma nova Box se possível, e atualiza o formulário principal.
        /// </summary>
        /// <param name="sender">O objeto que disparou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Verifica se o número de canais é válido
            if (numericUpDownCanais.Value <= 0)
            {
                MessageBox.Show("Tem de escolher um numero de canais valido", "Faltam dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se a Box existente está ligada
            if (_formPrincipal.Meo != null && _formPrincipal.Meo.Estado)
            {
                MessageBox.Show("Tem de desligar a box, para poder criar outra");
                return;
            }

            // Cria uma nova Box com o número de canais especificado
            Box novaBox = new Box(Convert.ToInt16(numericUpDownCanais.Value));

            // Atualiza a Box no formulário principal
            _formPrincipal.Meo = novaBox;

            // Fecha o formulário atual 
            this.Close();
        }
    }
}
