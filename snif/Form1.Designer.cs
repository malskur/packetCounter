namespace snif
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cbx_iface = new System.Windows.Forms.ComboBox();
            this.btn_startStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cntAll = new System.Windows.Forms.Label();
            this.cntIface = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbx_iface
            // 
            this.cbx_iface.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbx_iface.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_iface.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbx_iface.FormattingEnabled = true;
            this.cbx_iface.Location = new System.Drawing.Point(13, 13);
            this.cbx_iface.Name = "cbx_iface";
            this.cbx_iface.Size = new System.Drawing.Size(303, 21);
            this.cbx_iface.TabIndex = 0;
            this.cbx_iface.Text = "select network interface";
            // 
            // btn_startStop
            // 
            this.btn_startStop.Location = new System.Drawing.Point(13, 47);
            this.btn_startStop.Name = "btn_startStop";
            this.btn_startStop.Size = new System.Drawing.Size(75, 23);
            this.btn_startStop.TabIndex = 1;
            this.btn_startStop.Text = "START";
            this.btn_startStop.UseVisualStyleBackColor = true;
            this.btn_startStop.Click += new System.EventHandler(this.startStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "--->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "TOTAL";
            // 
            // cntAll
            // 
            this.cntAll.AutoSize = true;
            this.cntAll.Location = new System.Drawing.Point(376, 52);
            this.cntAll.Name = "cntAll";
            this.cntAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cntAll.Size = new System.Drawing.Size(16, 13);
            this.cntAll.TabIndex = 11;
            this.cntAll.Text = "---";
            // 
            // cntIface
            // 
            this.cntIface.AutoSize = true;
            this.cntIface.Location = new System.Drawing.Point(376, 16);
            this.cntIface.Name = "cntIface";
            this.cntIface.Size = new System.Drawing.Size(16, 13);
            this.cntIface.TabIndex = 10;
            this.cntIface.Text = "---";
            this.cntIface.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 82);
            this.Controls.Add(this.cntAll);
            this.Controls.Add(this.cntIface);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_startStop);
            this.Controls.Add(this.cbx_iface);
            this.Name = "Form1";
            this.Text = "Snif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_iface;
        private System.Windows.Forms.Button btn_startStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cntAll;
        private System.Windows.Forms.Label cntIface;
        private System.Windows.Forms.Timer timer1;
    }
}

