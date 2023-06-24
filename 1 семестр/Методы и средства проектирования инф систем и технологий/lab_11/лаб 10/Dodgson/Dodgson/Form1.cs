using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dodgson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rangeAddButton_Click(object sender, EventArgs e)
        {

            int rs = Convert.ToInt32(rangeSize.Value);
            int[] g = new int[(rs - 1) * rs];
            var variants = new List<string>();
            for (int i = 0; i < rangeDGV.ColumnCount-1; i++)
            {
                variants.Add(rangeDGV[i, 0].Value.ToString());
            }

            int i2 = 0;
            foreach (string s1 in variants)
            {
                foreach (string s2 in variants)
                {
                    if (s1 == s2) continue;
                    foreach (DataGridViewRow row in rangeDGV.Rows)
                    {
                        if (row.Cells[0].Value == null) continue;
                        string r="";
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            r = r + cell.Value.ToString();
                        }
                        int pos1 = r.IndexOf(s1);
                        int pos2 = r.IndexOf(s2);
                        if (pos1 < pos2)
                        {
                            g[i2] = g[i2] + Convert.ToInt32(row.Cells[rangeDGV.ColumnCount-1].Value);
                        }
                    }
                    i2++;
                }
            }
            GDGV.ColumnCount = rs;
            GDGV.RowCount = rs;
            int k = 0;
            for (int i = 0; i < rs; i++)
            {
                for (int j = 0; j < rs; j++)
                {
                    if (i==j) continue;
                    
                    GDGV[j, i].Value = g[k];
                    k++;
                }
            }

            HDGV.ColumnCount = rs;
            HDGV.RowCount = rs;
            k = 0;
            for (int i = 0; i < rs; i++)
            {
                for (int j = 0; j < rs; j++)
                {
                    if (i == j) continue;

                    if (g[k] == 0)
                    {
                        HDGV[i, j].Value = 0;
                    }
                    else
                    {
                        HDGV[i, j].Value = Convert.ToInt32(GDGV[i, j].Value) / g[k];
                    }
                    k++;
                }
            }
            foreach (string s in variants)
            {
                resultDGV.Columns.Add(s, s);
            }
            int totalVotes = 0;

            foreach (DataGridViewRow row in rangeDGV.Rows)
            {
                totalVotes += Convert.ToInt32(row.Cells[rangeDGV.ColumnCount - 1].Value);
            }
            Console.WriteLine("tut");
            int winCount = 0;
            for (int f = 0; f < rs;)
            { 
                foreach (DataGridViewCell cellH in HDGV.Rows[f].Cells)
                {
                    if (f >= rs) break;
                    if (cellH.Value == null) continue;
                    string check = cellH.Value.ToString();
                    if (check == "0")
                    {
                        int c = cellH.ColumnIndex;
                        int r = cellH.RowIndex;
                        int fg = Convert.ToInt32(GDGV[c, r].Value);
                        int result = (totalVotes / 2) - fg;
                        resultDGV[f, 0].Value = result;
                        f++;
                    }
                    if (check != "0")
                    {
                        winCount++;
                    }
                    if (winCount == 2)
                    {
                        int c = cellH.ColumnIndex;
                        int r = cellH.RowIndex;
                        int fg = Convert.ToInt32(GDGV[c, r].Value);
                        string result = "winner";
                        resultDGV[f, 0].Value = result;
                        f++;
                        winCount = 0;
                    }
                }
            }
        }

        private void resizeDGV(object sender, EventArgs e)
        {
            rangeDGV.ColumnCount = Convert.ToInt32(rangeSize.Value)+1;
        }
    }
}
