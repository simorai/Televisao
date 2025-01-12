using TelevisaoConsole;

namespace TelevisaoForms
{
    public partial class Form1 : Form
    {
        Box _meo;
        public Box Meo
        {
            get
            {
                return _meo;
            }
            set
            {
                _meo = value;
            }
        }

        public Form1()
        {
            InitializeComponent();

            _meo = new Box();

            if (_meo != null)
            {
                if (_meo != null)
                {
                    btnOnOff.Enabled = true;
                    lblInfo.Text = _meo.Mensagem;
                }
            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (_meo.Estado)
            {
                _meo.Desligar();
                lblInfo.Text = _meo.Mensagem;
                btnOnOff.Text = "Ligar";
                //canais
                groupBoxCanais.Enabled = false;
                lblCanal.Text = "-";
                //volume
                groupBoxVolume.Enabled = false;
                progressBarVolume.Value = 0;

            }
            else
            {
                _meo.Ligar();
                lblInfo.Text = _meo.Mensagem;
                btnOnOff.Text = "desligar";
                //Canais
                groupBoxCanais.Enabled = true;
                lblCanal.Text = _meo.Canal.ToString();
                //Volume
                groupBoxVolume.Enabled = true;
                progressBarVolume.Value = _meo.Volume;
            }
        }

        private void btnAumentaVolume_Click(object sender, EventArgs e)
        {
            _meo.Canal++;
            lblCanal.Text = _meo.Canal.ToString();
        }

        private void btnDiminuiCanal_Click(object sender, EventArgs e)
        {
            _meo.Canal--;
            lblCanal.Text = _meo.Canal.ToString();
        }

        private void btnDiminuiVolume_Click(object sender, EventArgs e)
        {
            _meo.Volume--;
            progressBarVolume.Value = _meo.Volume;
        }

        private void btnAumentaVolume_Click_1(object sender, EventArgs e)
        {
            _meo.Volume++;
            progressBarVolume.Value = _meo.Volume;
        }

        private void novaBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaBox frmNova = new frmNovaBox(this);
            frmNova.Show();
        }
    }
}
