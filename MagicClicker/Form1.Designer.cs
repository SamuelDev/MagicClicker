namespace ClickTest
{
    partial class MagicClicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagicClicker));
            this.timeClickDelay = new System.Windows.Forms.NumericUpDown();
            this.listMousePoints = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeClickVariance = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPixelOffput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtScriptNotes = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeClickDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeClickVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPixelOffput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeClickDelay
            // 
            this.timeClickDelay.Location = new System.Drawing.Point(141, 69);
            this.timeClickDelay.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.timeClickDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeClickDelay.Name = "timeClickDelay";
            this.timeClickDelay.Size = new System.Drawing.Size(120, 20);
            this.timeClickDelay.TabIndex = 1;
            this.timeClickDelay.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // listMousePoints
            // 
            this.listMousePoints.FormattingEnabled = true;
            this.listMousePoints.Location = new System.Drawing.Point(12, 53);
            this.listMousePoints.Name = "listMousePoints";
            this.listMousePoints.Size = new System.Drawing.Size(120, 407);
            this.listMousePoints.TabIndex = 3;
            this.listMousePoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listMousePoints_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delay between clicks (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Variance on each click (ms)";
            // 
            // timeClickVariance
            // 
            this.timeClickVariance.Location = new System.Drawing.Point(141, 121);
            this.timeClickVariance.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.timeClickVariance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeClickVariance.Name = "timeClickVariance";
            this.timeClickVariance.Size = new System.Drawing.Size(120, 20);
            this.timeClickVariance.TabIndex = 6;
            this.timeClickVariance.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(141, 147);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(120, 78);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "To delete a point, select and press d\n\nTo copy a point,  select and press c";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "(adds 0 to x randomly)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "F5 = set left, F6 = set right, F8 = start";
            // 
            // numPixelOffput
            // 
            this.numPixelOffput.Location = new System.Drawing.Point(141, 251);
            this.numPixelOffput.Name = "numPixelOffput";
            this.numPixelOffput.Size = new System.Drawing.Size(120, 20);
            this.numPixelOffput.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pixel Offput";
            // 
            // txtScriptNotes
            // 
            this.txtScriptNotes.Location = new System.Drawing.Point(141, 301);
            this.txtScriptNotes.Name = "txtScriptNotes";
            this.txtScriptNotes.Size = new System.Drawing.Size(120, 157);
            this.txtScriptNotes.TabIndex = 14;
            this.txtScriptNotes.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadScriptToolStripMenuItem,
            this.saveScriptToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadScriptToolStripMenuItem
            // 
            this.loadScriptToolStripMenuItem.Name = "loadScriptToolStripMenuItem";
            this.loadScriptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadScriptToolStripMenuItem.Text = "Load Script";
            this.loadScriptToolStripMenuItem.Click += new System.EventHandler(this.loadScriptToolStripMenuItem_Click);
            // 
            // saveScriptToolStripMenuItem
            // 
            this.saveScriptToolStripMenuItem.Name = "saveScriptToolStripMenuItem";
            this.saveScriptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveScriptToolStripMenuItem.Text = "Save Script";
            this.saveScriptToolStripMenuItem.Click += new System.EventHandler(this.saveScriptToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Script Notes:";
            // 
            // MagicClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 470);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtScriptNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numPixelOffput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.timeClickVariance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMousePoints);
            this.Controls.Add(this.timeClickDelay);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MagicClicker";
            this.Text = "Magic Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.timeClickDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeClickVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPixelOffput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown timeClickDelay;
        private System.Windows.Forms.ListBox listMousePoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown timeClickVariance;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPixelOffput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtScriptNotes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label6;
    }
}

