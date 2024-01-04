namespace Projeto123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string fraseMotivacional = "MEU PRIMEIRO FOREACH EM C#";
            //lista.Items.Add(fraseMotivacional.Length);

            List<string> listaDeNomes = new List<string>()
            {
                "JOÃO", "MARIA","KADU","TIAGO"
            };
            foreach (string nome in listaDeNomes)
            {
                lista.Items.Add(nome);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] valores = new int[] { 10, 20, 30, 40, 50, 60, 70 };
            foreach (int valor in valores)
            {
                listBox1.Items.Add(valor);            }
        }
    }
}