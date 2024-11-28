namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // telegrama urgente?
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u'; // Cambiamos a urgente si el checkbox está marcado
            }

            // Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(' ').Length;

            // Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 3;
                }
                else
                {
                    coste = 3 + 0.5 * (numPalabras - 10);
                }
            }
            else
            {
                // Si el telegrama es urgente
            if (tipoTelegrama == 'u')
               {
                if (numPalabras <= 10)
                {
                    coste = 6;
                }
                else
                {
                coste = 6 + 0.75 * (numPalabras - 10);
                }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

    }
}