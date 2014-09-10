namespace CalculatingOptimumBenefit
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ResurcesAndInterestTable = new System.Windows.Forms.DataGridView();
            this.AddResurceButton = new System.Windows.Forms.Button();
            this.RandolTableMaker = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlButtonHolder = new System.Windows.Forms.Panel();
            this.pnlBottunHolder2 = new System.Windows.Forms.Panel();
            this.pnlTableHolder = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ResurcesAndInterestTable)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.pnlButtonHolder.SuspendLayout();
            this.pnlBottunHolder2.SuspendLayout();
            this.pnlTableHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResurcesAndInterestTable
            // 
            this.ResurcesAndInterestTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ResurcesAndInterestTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ResurcesAndInterestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = "$0.00";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResurcesAndInterestTable.DefaultCellStyle = dataGridViewCellStyle11;
            this.ResurcesAndInterestTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResurcesAndInterestTable.Location = new System.Drawing.Point(5, 5);
            this.ResurcesAndInterestTable.Name = "ResurcesAndInterestTable";
            this.ResurcesAndInterestTable.RowHeadersVisible = false;
            this.ResurcesAndInterestTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = "$0.00";
            this.ResurcesAndInterestTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.ResurcesAndInterestTable.RowTemplate.DefaultCellStyle.Format = "C2";
            this.ResurcesAndInterestTable.RowTemplate.DefaultCellStyle.NullValue = "$0.00";
            this.ResurcesAndInterestTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResurcesAndInterestTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResurcesAndInterestTable.Size = new System.Drawing.Size(410, 258);
            this.ResurcesAndInterestTable.TabIndex = 8;
            this.ResurcesAndInterestTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResurcesAndInterestTable_CellEnter);
            this.ResurcesAndInterestTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResurcesAndInterestTable_CellValueChanged);
            this.ResurcesAndInterestTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ResurcesAndInterestTable_RowsAdded);
            this.ResurcesAndInterestTable.RowUnshared += new System.Windows.Forms.DataGridViewRowEventHandler(this.ResurcesAndInterestTable_RowUnshared);
            // 
            // AddResurceButton
            // 
            this.AddResurceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddResurceButton.Location = new System.Drawing.Point(5, 0);
            this.AddResurceButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddResurceButton.Name = "AddResurceButton";
            this.AddResurceButton.Size = new System.Drawing.Size(209, 30);
            this.AddResurceButton.TabIndex = 3;
            this.AddResurceButton.Text = "Add Resource";
            this.AddResurceButton.UseVisualStyleBackColor = true;
            this.AddResurceButton.Click += new System.EventHandler(this.AddResurceButton_Click);
            // 
            // RandolTableMaker
            // 
            this.RandolTableMaker.Dock = System.Windows.Forms.DockStyle.Right;
            this.RandolTableMaker.Location = new System.Drawing.Point(214, 0);
            this.RandolTableMaker.Margin = new System.Windows.Forms.Padding(0);
            this.RandolTableMaker.Name = "RandolTableMaker";
            this.RandolTableMaker.Size = new System.Drawing.Size(138, 30);
            this.RandolTableMaker.TabIndex = 2;
            this.RandolTableMaker.Text = "Create Random Table";
            this.RandolTableMaker.UseVisualStyleBackColor = true;
            this.RandolTableMaker.Click += new System.EventHandler(this.RandolTableMaker_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculateButton.Location = new System.Drawing.Point(5, 5);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(0);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(410, 30);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate Optimum Benefit";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResetButton.Location = new System.Drawing.Point(352, 0);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(30);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(63, 30);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(420, 24);
            this.menuStrip.TabIndex = 5;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.CalculateToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.CalculateToolStripMenuItem.Text = "Calculate";
            this.CalculateToolStripMenuItem.Click += new System.EventHandler(this.CalculateOptimumBenefitToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewResourceToolStripMenuItem,
            this.RandomToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // NewResourceToolStripMenuItem
            // 
            this.NewResourceToolStripMenuItem.Name = "NewResourceToolStripMenuItem";
            this.NewResourceToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.NewResourceToolStripMenuItem.Text = "New Resource";
            this.NewResourceToolStripMenuItem.Click += new System.EventHandler(this.NewResourceToolStripMenuItem_Click);
            // 
            // RandomToolStripMenuItem
            // 
            this.RandomToolStripMenuItem.Name = "RandomToolStripMenuItem";
            this.RandomToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.RandomToolStripMenuItem.Text = "Create Random Table";
            this.RandomToolStripMenuItem.Click += new System.EventHandler(this.RandomToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUsToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutUsToolStripMenuItem
            // 
            this.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem";
            this.AboutUsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.AboutUsToolStripMenuItem.Text = "About Us";
            this.AboutUsToolStripMenuItem.Click += new System.EventHandler(this.AboutUsToolStripMenuItem_Click);
            // 
            // pnlButtonHolder
            // 
            this.pnlButtonHolder.Controls.Add(this.AddResurceButton);
            this.pnlButtonHolder.Controls.Add(this.RandolTableMaker);
            this.pnlButtonHolder.Controls.Add(this.ResetButton);
            this.pnlButtonHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonHolder.Location = new System.Drawing.Point(0, 327);
            this.pnlButtonHolder.Name = "pnlButtonHolder";
            this.pnlButtonHolder.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnlButtonHolder.Size = new System.Drawing.Size(420, 35);
            this.pnlButtonHolder.TabIndex = 6;
            // 
            // pnlBottunHolder2
            // 
            this.pnlBottunHolder2.Controls.Add(this.CalculateButton);
            this.pnlBottunHolder2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottunHolder2.Location = new System.Drawing.Point(0, 287);
            this.pnlBottunHolder2.Name = "pnlBottunHolder2";
            this.pnlBottunHolder2.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBottunHolder2.Size = new System.Drawing.Size(420, 40);
            this.pnlBottunHolder2.TabIndex = 4;
            // 
            // pnlTableHolder
            // 
            this.pnlTableHolder.Controls.Add(this.ResurcesAndInterestTable);
            this.pnlTableHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableHolder.Location = new System.Drawing.Point(0, 24);
            this.pnlTableHolder.Name = "pnlTableHolder";
            this.pnlTableHolder.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.pnlTableHolder.Size = new System.Drawing.Size(420, 263);
            this.pnlTableHolder.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(420, 362);
            this.Controls.Add(this.pnlTableHolder);
            this.Controls.Add(this.pnlBottunHolder2);
            this.Controls.Add(this.pnlButtonHolder);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Calculating Optimum Benefit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResurcesAndInterestTable)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlButtonHolder.ResumeLayout(false);
            this.pnlBottunHolder2.ResumeLayout(false);
            this.pnlTableHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResurcesAndInterestTable;
        private System.Windows.Forms.Button AddResurceButton;
        private System.Windows.Forms.Button RandolTableMaker;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewResourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculateToolStripMenuItem;
        private System.Windows.Forms.Panel pnlButtonHolder;
        private System.Windows.Forms.Panel pnlBottunHolder2;
        private System.Windows.Forms.Panel pnlTableHolder;
    }
}