namespace ExercicioLogica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaPlaca(txtPlaca.Text))
                MessageBox.Show("Placa inválido");
        }

        private bool ValidaPlaca(string placa)
        {

            if (placa == null || placa.Trim() == "")
            {
                return false;
            }
            else

            {
                placa = placa.Remove(3, 1);

                if (!Char.IsLetter(placa[0]))
                {
                    return false;
                }


                if (!Char.IsLetter(placa[1]))
                {
                    return false;
                }


                if (!Char.IsLetter(placa[2]))
                {
                    return false;
                }

                if 

                return true;
            }


        }

        private void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
