namespace Cadastro_Usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = texto1.Text;
            string email = texto3.Text;
            string senha = texto4.Text;
            string confSenha = texto6.Text;
            string telefone = mask_tel.Text;
         
            if (senha == confSenha) 
            {
                txt1.Text = "";
                MessageBox.Show($"Seus dados fora salvos: {nome}\n{email}");
            }
            else
            {
                txt1.Text = "Senha incoreta";
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            texto1.Text = "";
            texto2.Text = "";
            texto3.Text = "";
            texto4.Text = "";
            mask_tel.Text = "";
            texto6.Text = "";
            txt1.Text = "";
        }

        
    }
}