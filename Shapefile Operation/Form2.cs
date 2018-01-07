using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shapefile_Operation
{
    public partial class Form2 : Form
    {
        public Form2( DataTable dt)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = dt;
        }

    }
}
