
namespace MemoryMap
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.OutputLog = new System.Windows.Forms.TextBox();
            this.Table1 = new System.Windows.Forms.DataGridView();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ressource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_statTypes = new System.Windows.Forms.GroupBox();
            this.rb_TypeValue = new System.Windows.Forms.RadioButton();
            this.rb_TypeDiff = new System.Windows.Forms.RadioButton();
            this.rb_TypeBaseline = new System.Windows.Forms.RadioButton();
            this.memReportPathBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tb_searchPattern = new System.Windows.Forms.TextBox();
            this.l_searchPattern = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).BeginInit();
            this.gb_statTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(570, 217);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(81, 88);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // OutputLog
            // 
            this.OutputLog.Location = new System.Drawing.Point(366, 493);
            this.OutputLog.Multiline = true;
            this.OutputLog.Name = "OutputLog";
            this.OutputLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputLog.Size = new System.Drawing.Size(518, 311);
            this.OutputLog.TabIndex = 1;
            // 
            // Table1
            // 
            this.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Memory,
            this.Ressource});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Table1.Location = new System.Drawing.Point(1014, 373);
            this.Table1.Name = "Table1";
            this.Table1.RowHeadersWidth = 62;
            this.Table1.RowTemplate.Height = 28;
            this.Table1.Size = new System.Drawing.Size(449, 380);
            this.Table1.TabIndex = 2;
            // 
            // Memory
            // 
            this.Memory.HeaderText = "Memory";
            this.Memory.MinimumWidth = 8;
            this.Memory.Name = "Memory";
            this.Memory.Width = 150;
            // 
            // Ressource
            // 
            this.Ressource.HeaderText = "Ressource";
            this.Ressource.MinimumWidth = 8;
            this.Ressource.Name = "Ressource";
            this.Ressource.Width = 150;
            // 
            // gb_statTypes
            // 
            this.gb_statTypes.Controls.Add(this.rb_TypeValue);
            this.gb_statTypes.Controls.Add(this.rb_TypeDiff);
            this.gb_statTypes.Controls.Add(this.rb_TypeBaseline);
            this.gb_statTypes.Location = new System.Drawing.Point(728, 149);
            this.gb_statTypes.Name = "gb_statTypes";
            this.gb_statTypes.Size = new System.Drawing.Size(223, 239);
            this.gb_statTypes.TabIndex = 3;
            this.gb_statTypes.TabStop = false;
            this.gb_statTypes.Text = "stat type";
            // 
            // rb_TypeValue
            // 
            this.rb_TypeValue.AutoSize = true;
            this.rb_TypeValue.Location = new System.Drawing.Point(46, 159);
            this.rb_TypeValue.Name = "rb_TypeValue";
            this.rb_TypeValue.Size = new System.Drawing.Size(75, 24);
            this.rb_TypeValue.TabIndex = 2;
            this.rb_TypeValue.TabStop = true;
            this.rb_TypeValue.Text = "Value";
            this.rb_TypeValue.UseVisualStyleBackColor = true;
            // 
            // rb_TypeDiff
            // 
            this.rb_TypeDiff.AutoSize = true;
            this.rb_TypeDiff.Location = new System.Drawing.Point(48, 107);
            this.rb_TypeDiff.Name = "rb_TypeDiff";
            this.rb_TypeDiff.Size = new System.Drawing.Size(108, 24);
            this.rb_TypeDiff.TabIndex = 1;
            this.rb_TypeDiff.TabStop = true;
            this.rb_TypeDiff.Text = "Difference";
            this.rb_TypeDiff.UseVisualStyleBackColor = true;
            // 
            // rb_TypeBaseline
            // 
            this.rb_TypeBaseline.AutoSize = true;
            this.rb_TypeBaseline.Location = new System.Drawing.Point(46, 68);
            this.rb_TypeBaseline.Name = "rb_TypeBaseline";
            this.rb_TypeBaseline.Size = new System.Drawing.Size(95, 24);
            this.rb_TypeBaseline.TabIndex = 0;
            this.rb_TypeBaseline.TabStop = true;
            this.rb_TypeBaseline.Text = "Baseline";
            this.rb_TypeBaseline.UseVisualStyleBackColor = true;
            // 
            // tb_searchPattern
            // 
            this.tb_searchPattern.Location = new System.Drawing.Point(366, 253);
            this.tb_searchPattern.Name = "tb_searchPattern";
            this.tb_searchPattern.Size = new System.Drawing.Size(100, 26);
            this.tb_searchPattern.TabIndex = 4;
            this.tb_searchPattern.Text = "*memreport";
            // 
            // l_searchPattern
            // 
            this.l_searchPattern.AutoSize = true;
            this.l_searchPattern.Location = new System.Drawing.Point(244, 256);
            this.l_searchPattern.Name = "l_searchPattern";
            this.l_searchPattern.Size = new System.Drawing.Size(116, 20);
            this.l_searchPattern.TabIndex = 5;
            this.l_searchPattern.Text = "Search Pattern";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1106);
            this.Controls.Add(this.l_searchPattern);
            this.Controls.Add(this.tb_searchPattern);
            this.Controls.Add(this.gb_statTypes);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.OutputLog);
            this.Controls.Add(this.BtnOpen);
            this.Name = "Form1";
            this.Text = "MemoryMap";
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).EndInit();
            this.gb_statTypes.ResumeLayout(false);
            this.gb_statTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.TextBox OutputLog;
        private System.Windows.Forms.DataGridView Table1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ressource;
        private System.Windows.Forms.GroupBox gb_statTypes;
        private System.Windows.Forms.RadioButton rb_TypeValue;
        private System.Windows.Forms.RadioButton rb_TypeDiff;
        private System.Windows.Forms.RadioButton rb_TypeBaseline;
        private System.Windows.Forms.FolderBrowserDialog memReportPathBrowserDialog;
        private System.Windows.Forms.TextBox tb_searchPattern;
        private System.Windows.Forms.Label l_searchPattern;
    }
}

