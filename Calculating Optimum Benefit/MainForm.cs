using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatingOptimumBenefit
{
    public partial class MainForm : Form
    {
        float[,] Table = new float[,] { 
                                        { 4, 6, 5, 6 ,5}, 
                                        { 1, 3, 2, 1 ,6}, 
                                        { 4, 3, 5, 1 ,4},
                                        { 3, 2, 0, 5 ,6}, 
                                        { 2, 4, 3, 1 ,8},
                                        { 3, 5, 7, 1 ,1}
                                      };

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResurcesAndInterestTable.Columns.Add("ProjectsAndResources", "Project / Resource");
            ResurcesAndInterestTable.Columns[0].ReadOnly = true;
            ResurcesAndInterestTable.Columns[0].Frozen = true;
            ResurcesAndInterestTable.Columns[0].DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            CalculateButton.Enabled = false;
            CalculateToolStripMenuItem.Enabled = false;
        }

        private CalculatingOptimumBenefit.Node[,] CalculateOptimumInterest(float[,] Table)
        {
            Node BestNodet;
            float maxBenefit;
            int ResurceUsing;
            Node[,] NodesTable = new Node[Table.GetLength(0), Table.GetLength(1) + 1];

            NodesTable[NodesTable.GetLength(0) - 1, NodesTable.GetLength(1) - 1] = new Node(0, null, 0);
            for (int i = 0; i < NodesTable.GetLength(1) - 1; i++)
                NodesTable[NodesTable.GetLength(0) - 1, i] = new Node(Table[Table.GetLength(0) - 1, Table.GetLength(1) - 1 - i], null, Table.GetLength(1) - i);

            for (int i = NodesTable.GetLength(0) - 2; i >= 0; i--)
                for (int j = 0; j < NodesTable.GetLength(1); j++)
                {
                    BestNodet = null;
                    maxBenefit = 0;
                    ResurceUsing = 0;
                    for (int k = j, m = -1; k < NodesTable.GetLength(1); k++, m++)
                        if (m == -1)
                        {
                            maxBenefit = NodesTable[i + 1, k].OptimumBenefit;
                            BestNodet = NodesTable[i + 1, k];
                            ResurceUsing = m + 1;
                        }
                        else if (Table[i, m] + NodesTable[i + 1, k].OptimumBenefit > maxBenefit)
                        {
                            maxBenefit = Table[i, m] + NodesTable[i + 1, k].OptimumBenefit;
                            BestNodet = NodesTable[i + 1, k];
                            ResurceUsing = m + 1;
                        }
                    NodesTable[i, j] = new Node(maxBenefit, BestNodet, ResurceUsing);
                }
            return NodesTable;
        }

        private void AddResurceButton_Click(object sender, EventArgs e)
        {
            int CurrentRecourse = ResurcesAndInterestTable.Columns.Count;
            ResurcesAndInterestTable.Columns.Add("Resurce" + CurrentRecourse, "Resource " + CurrentRecourse);
        }

        private void RandolTableMaker_Click(object sender, EventArgs e)
        {
            Random RandomNumMaker = new Random();
            int Columns = RandomNumMaker.Next(3, 20);
            int Rows = RandomNumMaker.Next(3, 20);
            ResurcesAndInterestTable.Columns.Clear();
            ResurcesAndInterestTable.Rows.Clear();
            ResurcesAndInterestTable.Columns.Add("ProjectsAndResources", "Project / Resource");
            ResurcesAndInterestTable.Columns[0].DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            for (int i = 1; i < Columns; i++)
            {
                ResurcesAndInterestTable.Columns.Add("Resurce " + (i), "Resource " + (i));
                ResurcesAndInterestTable.Columns[i].Width = 50;
            }
            for (int i = 0; i < Rows; i++)
            {
                ResurcesAndInterestTable.Rows.Add();
                ResurcesAndInterestTable[0, i].Value = "Project " + (i + 1);
            }
            for (int i = 1; i < Columns; i++)
                for (int j = 0; j < Rows; j++)
                    ResurcesAndInterestTable[i, j].Value = RandomNumMaker.Next(0, 100);
            ResurcesAndInterestTable.Columns[0].Frozen = true;
            ResurcesAndInterestTable.Columns[0].ReadOnly = true;
            CalculateButton.Enabled = true;
            CalculateToolStripMenuItem.Enabled = true;
        }

        private void ResurcesAndInterestTable_RowUnshared(object sender, DataGridViewRowEventArgs e)
        {
            ResurcesAndInterestTable.Columns[0].ReadOnly = false;
            ResurcesAndInterestTable[0, ResurcesAndInterestTable.Rows.Count - 1].Value = "Project " + ResurcesAndInterestTable.Rows.Count;
            ResurcesAndInterestTable.Columns[0].ReadOnly = true;
        }

        private void ResurcesAndInterestTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ResurcesAndInterestTable[e.ColumnIndex, e.RowIndex].Value.ToString().ToCharArray()[0] == '$')
                return;
            else
            {
                try
                {
                    double x = System.Convert.ToDouble(ResurcesAndInterestTable[e.ColumnIndex, e.RowIndex].Value.ToString());
                    string temp = ResurcesAndInterestTable[e.ColumnIndex, e.RowIndex].Value.ToString();
                    ResurcesAndInterestTable[e.ColumnIndex, e.RowIndex].Value = "$" + temp;
                }
                catch (Exception)
                {
                    if (e.ColumnIndex != 0)
                        ResurcesAndInterestTable[e.ColumnIndex, e.RowIndex].Value = "$0.00";
                }
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Node[,] ProjectsNode;
            Node BestStartNode;
            int k = 0;
            String Alert = "";
            float[,] InterestTable = new float[ResurcesAndInterestTable.Rows.Count - 1, ResurcesAndInterestTable.Columns.Count - 1];
            try
            {
                for (int i = 0; i < InterestTable.GetLength(0); i++)
                {
                    for (int j = 0; j < InterestTable.GetLength(1); j++)
                    {
                        string temp = ResurcesAndInterestTable[j + 1, i].Value.ToString();
                        temp = temp.Remove(0, 1);
                        InterestTable[i, j] = (float)(Convert.ToDouble(temp));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please fill the table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProjectsNode = CalculateOptimumInterest(InterestTable);
            BestStartNode = ProjectsNode[0, 0];
            for (int i = 1; i < ProjectsNode.GetLength(1); i++)
                if (ProjectsNode[0, i].OptimumBenefit > BestStartNode.OptimumBenefit)
                    BestStartNode = ProjectsNode[0, i];
            while (BestStartNode != null)
            {
                Alert += "For Project " + (k + 1) + " Use " + BestStartNode.ResurcesUsing + " Resurces.\n";
                BestStartNode = BestStartNode.NextNode;
                k++;
            }
            System.Windows.Forms.MessageBox.Show(this, Alert, "How To Make Best Benefit", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResurcesAndInterestTable.Rows.Clear();
            ResurcesAndInterestTable.Columns.Clear();
            ResurcesAndInterestTable.Columns.Add("ProjectsAndResources", "Project / Resource");
            ResurcesAndInterestTable.Columns[0].ReadOnly = true;
            ResurcesAndInterestTable.Columns[0].Frozen = true;
            ResurcesAndInterestTable.Columns[0].DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            ResurcesAndInterestTable_RowUnshared(null, null);
            CalculateButton.Enabled = false;
            CalculateToolStripMenuItem.Enabled = false;
        }

        private void ResurcesAndInterestTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (ResurcesAndInterestTable.Columns.Count > 1)
                {
                    ResurcesAndInterestTable[0, e.RowIndex].Selected = false;
                    ResurcesAndInterestTable[1, e.RowIndex].Selected = true;
                }
            }
        }

        private void ResurcesAndInterestTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateButton.Enabled = true;
            CalculateToolStripMenuItem.Enabled = true;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButton_Click(sender, e);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewResourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddResurceButton_Click(sender, e);
        }

        private void RandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandolTableMaker_Click(sender, e);
        }

        private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs abtUs = new AboutUs();
            abtUs.MainForm1 = this;
            abtUs.Visible = true;
            this.Enabled = false;
        }

        private void CalculateOptimumBenefitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateButton_Click(sender, e);
        }
    }
}
