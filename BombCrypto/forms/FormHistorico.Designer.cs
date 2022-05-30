namespace BombCrypto.forms
{
    partial class FormHistorico
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
            this.gbLogs = new System.Windows.Forms.GroupBox();
            this.txthistorico = new System.Windows.Forms.RichTextBox();
            this.gbLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogs
            // 
            this.gbLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogs.Controls.Add(this.txthistorico);
            this.gbLogs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogs.ForeColor = System.Drawing.Color.Black;
            this.gbLogs.Location = new System.Drawing.Point(12, 12);
            this.gbLogs.Name = "gbLogs";
            this.gbLogs.Size = new System.Drawing.Size(575, 403);
            this.gbLogs.TabIndex = 99;
            this.gbLogs.TabStop = false;
            this.gbLogs.Text = "HISTÓRICOS";
            // 
            // txthistorico
            // 
            this.txthistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txthistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txthistorico.ForeColor = System.Drawing.Color.White;
            this.txthistorico.Location = new System.Drawing.Point(18, 27);
            this.txthistorico.Name = "txthistorico";
            this.txthistorico.Size = new System.Drawing.Size(539, 357);
            this.txthistorico.TabIndex = 0;
            this.txthistorico.Text = "";
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 427);
            this.Controls.Add(this.gbLogs);
            this.Name = "FormHistorico";
            this.Text = "FormHistorico";
            this.gbLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogs;
        public System.Windows.Forms.RichTextBox txthistorico;
    }
}