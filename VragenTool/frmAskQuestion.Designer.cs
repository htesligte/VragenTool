namespace VragenTool
{
    partial class frmAskQuestion
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
            this.txtVraag = new System.Windows.Forms.TextBox();
            this.txtAntwoord = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolstripAmountHad = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripAmountWrong = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripAmountGood = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripAmountTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVraag
            // 
            this.txtVraag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVraag.BackColor = System.Drawing.Color.White;
            this.txtVraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVraag.Location = new System.Drawing.Point(13, 13);
            this.txtVraag.Multiline = true;
            this.txtVraag.Name = "txtVraag";
            this.txtVraag.ReadOnly = true;
            this.txtVraag.Size = new System.Drawing.Size(1265, 123);
            this.txtVraag.TabIndex = 999;
            this.txtVraag.TabStop = false;
            // 
            // txtAntwoord
            // 
            this.txtAntwoord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAntwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntwoord.Location = new System.Drawing.Point(13, 143);
            this.txtAntwoord.Name = "txtAntwoord";
            this.txtAntwoord.Size = new System.Drawing.Size(1265, 455);
            this.txtAntwoord.TabIndex = 1;
            this.txtAntwoord.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(1203, 604);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripAmountHad,
            this.toolStripAmountWrong,
            this.toolStripAmountGood,
            this.toolStripAmountTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1290, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolstripAmountHad
            // 
            this.toolstripAmountHad.Name = "toolstripAmountHad";
            this.toolstripAmountHad.Size = new System.Drawing.Size(29, 17);
            this.toolstripAmountHad.Text = "Had";
            // 
            // toolStripAmountWrong
            // 
            this.toolStripAmountWrong.ForeColor = System.Drawing.Color.Red;
            this.toolStripAmountWrong.Name = "toolStripAmountWrong";
            this.toolStripAmountWrong.Size = new System.Drawing.Size(43, 17);
            this.toolStripAmountWrong.Text = "Wrong";
            // 
            // toolStripAmountGood
            // 
            this.toolStripAmountGood.ForeColor = System.Drawing.Color.Green;
            this.toolStripAmountGood.Name = "toolStripAmountGood";
            this.toolStripAmountGood.Size = new System.Drawing.Size(36, 17);
            this.toolStripAmountGood.Text = "Good";
            // 
            // toolStripAmountTotal
            // 
            this.toolStripAmountTotal.Name = "toolStripAmountTotal";
            this.toolStripAmountTotal.Size = new System.Drawing.Size(34, 17);
            this.toolStripAmountTotal.Text = "Total";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Location = new System.Drawing.Point(13, 604);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(1002, 604);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(195, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Niet controleren, volgende vraag";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmAskQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 661);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAntwoord);
            this.Controls.Add(this.txtVraag);
            this.Name = "frmAskQuestion";
            this.Text = "frmAskQuestion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAskQuestion_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAskQuestion_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVraag;
        private System.Windows.Forms.RichTextBox txtAntwoord;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolstripAmountHad;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAmountWrong;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAmountGood;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAmountTotal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}