using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netflix
{
    public partial class Lista : Form
    {
        int indice = 0;

        public Lista()
        {
            InitializeComponent();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (indice == 0)
            {

            }
            else
            {
                indice--;
            }
        }
    }
}
