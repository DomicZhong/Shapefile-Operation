using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Symbology;
using DotSpatial.Topology;
using DotSpatial.Projections;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Reflection;
using System;

namespace Shapefile_Operation
{
    public partial class Form1
    {
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.AddLayer();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ClearLayers();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Admin", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }


    }
}
