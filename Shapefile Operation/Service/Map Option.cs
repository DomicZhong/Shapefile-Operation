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
        /// <summary>
        /// 打印地图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DotSpatial.Controls.LayoutForm frm = new DotSpatial.Controls.LayoutForm();
            frm.MapControl = map1;
            frm.Show();
        }

        /// <summary>
        /// 默认方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Select;
        }

        /// <summary>
        /// 放大
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomOut();
        }

        private void measurementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Label;
        }

        private void zoomToExtentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomToMaxExtent();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Info;
        }

        private void panToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Pan;
        }

    }
}
