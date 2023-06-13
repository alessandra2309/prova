using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provaoficial
{
    public partial class gabarito : Form
    {
        public gabarito()
        {
            InitializeComponent();
            lb_resultado.Text = "";
            lb_resuldato1.Text = "";
            lb_resultado2.Text = "";
            lb_resultado3.Text = "";
            lb_resultado4.Text = "";
            lb_resultado5.Text = "";
            lb_resultado6.Text = "";
            lb_resultado7.Text = "";
            lb_resultado8.Text = "";
            lb_resltado9.Text = "";
            lb_reprovado.Text = "";
            lb_aprovado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            correcao c = new correcao();
            bt_comparar.Text = c.ToString();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
