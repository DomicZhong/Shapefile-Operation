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
        /// 将属性表导出成Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportAttributeTableToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare a datatable
            System.Data.DataTable dt = null;

            if (map1.Layers.Count > 0)
            {
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //Get the shapefile's attribute table to our datatable dt
                    dt = stateLayer.DataSet.DataTable;
                    //Call the sub ExportToExcel 
                    //This sub procedure expects a datatable as an input
                    ExportToExcel(dt);
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        /// <summary>
        /// This sub method is used to create an excel worksheet from the attribute table
        /// </summary>
        /// <param name="objDT">attribute table as a datatable input</param>
        /// <remarks>Click the COM tab of the Add Reference dialog box, and find Microsoft Excel 14 Object Library.</remarks>
        private void ExportToExcel(System.Data.DataTable objDT)
        {
            //excel = new Excel.Application();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            int intCol = 0;
            int intRow = 0;
            //path for storing excel datasheet

            if (xlApp == null)
            {
                MessageBox.Show("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                //var _with1 = Microsoft.Office.Interop.Excel.Application();
                xlApp.SheetsInNewWorkbook = 1;
                xlApp.Workbooks.Add();
                xlApp.Worksheets[1].Select();

                xlApp.Cells[1, 1].value = "Attribute table";
                //Heading of the excel file
                xlApp.Cells[1, 1].EntireRow.Font.Bold = true;

                //Add the column names from the attribute table to excel worksheet
                int intI = 1;
                for (intCol = 0; intCol <= objDT.Columns.Count - 1; intCol++)
                {
                    xlApp.Cells[2, intI].value = objDT.Columns[intCol].ColumnName;
                    xlApp.Cells[2, intI].EntireRow.Font.Bold = true;
                    intI += 1;
                }

                //Add the data row values from the attribute table to ecxel worksheet
                intI = 3;
                int intK = 1;
                for (intCol = 0; intCol <= objDT.Columns.Count - 1; intCol++)
                {
                    intI = 3;
                    for (intRow = 0; intRow <= objDT.Rows.Count - 1; intRow++)
                    {
                        xlApp.Cells[intI, intK].Value = objDT.Rows[intRow].ItemArray[intCol];
                        intI += 1;
                    }
                    intK += 1;
                }
                
                string file;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "请选择面文件路径";
                dialog.Filter = "xls文件(*.*)|*.xls*";
                dialog.AddExtension = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    file = dialog.FileName;
                }
                else
                {
                    file = null;
                }

                xlApp.ActiveCell.Worksheet.SaveAs(file);

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

                xlApp = null;
                MessageBox.Show("Data's are exported to Excel Succesfully in '" + file + "'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // The excel is created and opened for insert value. We most close this excel using this system
            System.Diagnostics.Process[] pro = (System.Diagnostics.Process[])System.Diagnostics.Process.GetProcessesByName("EXCEL");
            foreach (System.Diagnostics.Process i in pro)
            {
                i.Kill();
            }
        }

        //private void viewAttributeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //Declare a datatable
        //    System.Data.DataTable dt = null;

        //    if (map1.Layers.Count > 0)
        //    {
        //        MapPolygonLayer stateLayer = default(MapPolygonLayer);

        //        stateLayer = (MapPolygonLayer)map1.Layers[0];

        //        if (stateLayer == null)
        //        {
        //            MessageBox.Show("The layer is not a polygon layer.");
        //        }
        //        else
        //        {
        //            //Get the shapefile's attribute table to our datatable dt
        //            dt = stateLayer.DataSet.DataTable;
        //            //Set the datagridview datasource from datatable dt
        //            dgvAttributeTable.DataSource = dt;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please add a layer to the map.");
        //    }

        //}

        //private void addAColumnInTheAttributeTableToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //Declare a datatable
        //    System.Data.DataTable dt = null;

        //    //check the layers
        //    if (map1.Layers.Count > 0)
        //    {
        //        //Declare a mappolygon layer
        //        MapPolygonLayer stateLayer = default(MapPolygonLayer);

        //        //Assign the mappolygon layer from the map
        //        stateLayer = (MapPolygonLayer)map1.Layers[0];

        //        if (stateLayer == null)
        //        {
        //            MessageBox.Show("The layer is not a polygon layer.");
        //        }
        //        else
        //        {
        //            //Get the shapefile's attribute table to our datatable dt
        //            dt = stateLayer.DataSet.DataTable;

        //            //Add new column
        //            DataColumn column = new DataColumn("PercentMales");
        //            dt.Columns.Add(column);

        //            //calculate values
        //            foreach (DataRow row in dt.Rows)
        //            {

        //                double males = Convert.ToDouble(row["males"]);
        //                double females = Convert.ToDouble(row["females"]);
        //                double malesPercentage = (males / (males + females)) * 100;
        //                row["PercentMales"] = malesPercentage;
        //            }
        //            //Set the datagridview datasource from datatable dt
        //            dgvAttributeTable.DataSource = dt;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please add a layer to the map.");
        //    }


        //}

        //private void updateAttributeTableInShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (map1.Layers.Count > 0)
        //    {
        //        MapPolygonLayer stateLayer = default(MapPolygonLayer);
        //        stateLayer = (MapPolygonLayer)map1.Layers[0];
        //        if (stateLayer == null)
        //        {
        //            MessageBox.Show("The layer is not a polygon layer.");
        //        }
        //        else
        //        {
        //            stateLayer.DataSet.Save();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please add a layer to the map.");
        //    }
        //}

        //private void deleteAColumnInTheAttributeTableToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    //Declare a datatable
        //    System.Data.DataTable dt = null;

        //    if (map1.Layers.Count > 0)
        //    {
        //        MapPolygonLayer stateLayer = default(MapPolygonLayer);

        //        stateLayer = (MapPolygonLayer)map1.Layers[0];

        //        if (stateLayer == null)
        //        {
        //            MessageBox.Show("The layer is not a polygon layer.");
        //        }
        //        else
        //        {
        //            //Get the shapefile's attribute table to our datatable dt
        //            dt = stateLayer.DataSet.DataTable;

        //            //Remove a column
        //            dt.Columns.Remove("PercentMale");

        //            //Set the datagridview datasource from datatable dt
        //            dgvAttributeTable.DataSource = dt;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please add a layer to the map.");
        //    }

        //}

    }
}
