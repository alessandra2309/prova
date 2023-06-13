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
    public partial class correcao : Form
    {
        public correcao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gabarito c = new gabarito();
            c.ShowDialog();
            //correcao 
            string correcao = "a" ;
            string correcao1 = "b";
            string correcao2 = "c";
            string correcao3 = "d";
            string correcao4 = "e";
          
           

            for (int i  = 0; i < 10; i++)
            {
               
                if(i == 0)
                {
                    Console.WriteLine($"seu resultado é {correcao}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }

                if (i == 1)
                {
                    Console.WriteLine($"seu resultado é {correcao1}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }

                if (i == 2)
                {
                    Console.WriteLine($"seu resultado é {correcao2}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }

                if (i == 3)
                {
                    Console.WriteLine($"seu resultado é {correcao3}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }

                if (i == 4)
                {
                    Console.WriteLine($"seu resultado é {correcao3}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }

                if (i == 5)
                {
                    Console.WriteLine($"seu resultado é {correcao4}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }

                if (i == 6)
                {
                    Console.WriteLine($"seu resultado é {correcao}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }

                if (i == 7)
                {
                    Console.WriteLine($"seu resultado é {correcao2}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }

                if (i == 8)
                {
                    Console.WriteLine($"seu resultado é {correcao1}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }

                if (i == 9)
                {
                    Console.WriteLine($"seu resultado é {correcao4}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }

                if (i == 10)
                {
                    Console.WriteLine($"seu resultado é {correcao}");
                }
                else
                {
                    Console.WriteLine($"seu resultado esta incorreto");
                }
            }

           /*  string[] corrigir = { "a", "b", "c", "d" };

            if (corrigir.Length > 0)
            {
                corrigir[1] = "a";
            }*/


        }
    }
}
