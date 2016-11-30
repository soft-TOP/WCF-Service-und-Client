using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCF_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownEingabe_ValueChanged(Object sender, EventArgs e)
        {
            ServiceTOPClient client = new ServiceTOPClient();
            try
            {
                Int32 i = (Int32)Math.Round(((NumericUpDown)sender).Value, 0);
                labelGetData.Text = client.LiesZahl(i);

                // Verwenden Sie die client-Variable, um Vorgänge für den Dienst aufzurufen.

                // Schließen Sie den Client immer.

                Pausenzeiten pause = client.LiesPausenzeiten(i % 2 == 0);

                listBoxPause.Items.Clear();
                foreach (var item in pause.Pause)
                {
                    listBoxPause.Items.Add(item);
                }
                //listBoxPause.Refresh();
            }
            finally
            {
                client.Close();
            }            
        }
    }
}
