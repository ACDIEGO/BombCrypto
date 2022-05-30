namespace BombCrypto.forms
{
    partial class FormAutoClick
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
            this.groupBoxCursorCam = new System.Windows.Forms.GroupBox();
            this.lblStatusInsert = new System.Windows.Forms.Label();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenCursor = new System.Windows.Forms.Button();
            this.groupBoxCursorCam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCursorCam
            // 
            this.groupBoxCursorCam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxCursorCam.Controls.Add(this.lblStatusInsert);
            this.groupBoxCursorCam.Controls.Add(this.numericUpDownDelay);
            this.groupBoxCursorCam.Controls.Add(this.label1);
            this.groupBoxCursorCam.Controls.Add(this.btnOpenCursor);
            this.groupBoxCursorCam.ForeColor = System.Drawing.Color.White;
            this.groupBoxCursorCam.Location = new System.Drawing.Point(16, 30);
            this.groupBoxCursorCam.Name = "groupBoxCursorCam";
            this.groupBoxCursorCam.Size = new System.Drawing.Size(242, 107);
            this.groupBoxCursorCam.TabIndex = 9;
            this.groupBoxCursorCam.TabStop = false;
            this.groupBoxCursorCam.Text = "Inserir AutoClick";
            // 
            // lblStatusInsert
            // 
            this.lblStatusInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusInsert.Location = new System.Drawing.Point(30, 79);
            this.lblStatusInsert.Name = "lblStatusInsert";
            this.lblStatusInsert.Size = new System.Drawing.Size(182, 15);
            this.lblStatusInsert.TabIndex = 7;
            this.lblStatusInsert.Text = "...";
            this.lblStatusInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownDelay.Location = new System.Drawing.Point(74, 43);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownDelay.TabIndex = 2;
            this.numericUpDownDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenCursor
            // 
            this.btnOpenCursor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenCursor.Location = new System.Drawing.Point(178, 37);
            this.btnOpenCursor.Name = "btnOpenCursor";
            this.btnOpenCursor.Size = new System.Drawing.Size(36, 32);
            this.btnOpenCursor.TabIndex = 3;
            this.btnOpenCursor.UseVisualStyleBackColor = true;
            // 
            // FormAutoClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(274, 166);
            this.Controls.Add(this.groupBoxCursorCam);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAutoClick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClick";
            this.groupBoxCursorCam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCursorCam;
        private System.Windows.Forms.Label lblStatusInsert;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenCursor;
    }
}