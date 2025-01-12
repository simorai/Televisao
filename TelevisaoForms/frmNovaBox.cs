using TelevisaoConsole;

namespace TelevisaoForms
{
    public partial class frmNovaBox : Form
    {
        //private Box _formPrincipal;

        Form1 _formPrincipal;
        public frmNovaBox(Form1 principal)
        {
            InitializeComponent();
            _formPrincipal = principal;
            //_formPrincipal._meo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (numericUpDownCanais.Value <= 0)
            {
                MessageBox.Show("Tem de escolher um numero de canais valido", "Faltam dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Se a outra box estiver ligada
            //aviso para desligar e só depois que aceita uma nova com o numero de canais pretendidos
            if (_formPrincipal.Meo != null && _formPrincipal.Meo.Estado)
            {
                MessageBox.Show("Tem de desligar a box, para poder criar outra");
                return;
            }

            //criar nova box com os canais
            Box novaBox = new Box(Convert.ToInt16(numericUpDownCanais.Value));
            this.Close();
        }
    }
}
