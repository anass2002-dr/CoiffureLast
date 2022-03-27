using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coiffure
{
    public partial class aide : Form
    {
        public aide()
        {
            InitializeComponent();
        }

        private void btn_ajouterAvis_Click(object sender, EventArgs e)
        {
            pnlavis.Visible = true;
        }

        private void btn_suppression_Click(object sender, EventArgs e)
        {
            pnlsuppression.Visible = true;
            
        }
    }
}
