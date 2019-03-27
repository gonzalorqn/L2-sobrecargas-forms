using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase04.Entidades;

namespace Clase04.WindowsForms
{
    public partial class FrmCosa : Form
    {
        public FrmCosa()
        {
            InitializeComponent();
        }

        private void FrmCosa_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo");
            this.BackColor = Color.DarkBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cosa obj = new Cosa();
            MessageBox.Show(obj.Mostrar());
            this.button1.Text = "Crear una cosa bonita";
            this.Text = "Crear cosas";
        }
    }
}
