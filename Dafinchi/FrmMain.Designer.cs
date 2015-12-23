namespace Dafinchi
{
    partial class FrmMain
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
            this.lblCredit = new System.Windows.Forms.Label();
            this.lstConsole = new System.Windows.Forms.ListBox();
            this.txbX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txbY = new System.Windows.Forms.TextBox();
            this.lblLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLeft = new System.Windows.Forms.TextBox();
            this.txbRight = new System.Windows.Forms.TextBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(12, 440);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(181, 13);
            this.lblCredit.TabIndex = 0;
            this.lblCredit.Text = " Created by Keegon Cabinaw  - 2015";
            // 
            // lstConsole
            // 
            this.lstConsole.FormattingEnabled = true;
            this.lstConsole.Location = new System.Drawing.Point(12, 12);
            this.lstConsole.Name = "lstConsole";
            this.lstConsole.Size = new System.Drawing.Size(500, 199);
            this.lstConsole.TabIndex = 1;
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(61, 217);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(100, 20);
            this.txbX.TabIndex = 2;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 220);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(43, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X point:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 242);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(43, 13);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y point:";
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(61, 243);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(100, 20);
            this.txbY.TabIndex = 5;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(234, 220);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(28, 13);
            this.lblLeft.TabIndex = 6;
            this.lblLeft.Text = "Left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Right:";
            // 
            // txbLeft
            // 
            this.txbLeft.Location = new System.Drawing.Point(275, 217);
            this.txbLeft.Name = "txbLeft";
            this.txbLeft.Size = new System.Drawing.Size(100, 20);
            this.txbLeft.TabIndex = 8;
            // 
            // txbRight
            // 
            this.txbRight.Location = new System.Drawing.Point(432, 217);
            this.txbRight.Name = "txbRight";
            this.txbRight.Size = new System.Drawing.Size(100, 20);
            this.txbRight.TabIndex = 9;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 20;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.txbRight);
            this.Controls.Add(this.txbLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txbX);
            this.Controls.Add(this.lstConsole);
            this.Controls.Add(this.lblCredit);
            this.Name = "FrmMain";
            this.Text = "Dafinchi!";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.ListBox lstConsole;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLeft;
        private System.Windows.Forms.TextBox txbRight;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}

