using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLoadingTest
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        public async Task<string> LoadThread()
        {           
            await Task.Run(() => Thread.Sleep(3000));
            return "ok";
        }

        private async void bLoad_Click(object sender, EventArgs e)
        {
            // Mostra
            pbLoading.Show();
            pbLoading.Update();
            try
            {
                var resp = await LoadThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }

            // Esconde
            pbLoading.Hide();
            lbLoaded.Text = "Data Loaded!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbLoading.Hide();
        }
    }
}
