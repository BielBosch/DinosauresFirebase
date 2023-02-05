using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using Test.Domini;
using Test.Dades.Model;
using Firebase.Database;

namespace Test
{
    public partial class Form1 : Form
    {
        public IDominiDinosaur DominiDinosaur { get; set; }
        public Form1()
        {
            InitializeComponent();
            DominiDinosaur = new DominiDinosaur();
        }

        private async void Boto_Click(object sender, EventArgs e)
        {
            recorreDinosAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            try { 
                Dinosaur myDino = new Dinosaur();

                myDino.nom = textBox1.Text;
                myDino.appeared = int.Parse(textBox2.Text);
                myDino.height = int.Parse(textBox3.Text);
                myDino.length = int.Parse(textBox4.Text);
                myDino.order = textBox5.Text;
                myDino.vanished = int.Parse(textBox6.Text);
                myDino.weight = int.Parse(textBox7.Text);

                DominiDinosaur.CrearDinosaures(myDino);

                recorreDinosAsync();

            }
            catch (IOException error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //ELIMINAR
            await DominiDinosaur.DeleteDino(textBox8.Text);

            recorreDinosAsync();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //editar
        {

            //EDITAR

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private async Task recorreDinosAsync()
        {
            listBoxDinosaures.Items.Clear();
            var dinosaures = await DominiDinosaur.ObtenirDinosaures();
            foreach (var dino in dinosaures)
            {
                listBoxDinosaures.Items.Add(dino.Key);
            }
        }
    }
}