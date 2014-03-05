namespace VragenTool
{
    partial class frmCheckAnswer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGood = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGood = new System.Windows.Forms.RichTextBox();
            this.txtYour = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juiste antwoord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jouw antwoord:";
            // 
            // btnGood
            // 
            this.btnGood.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGood.ForeColor = System.Drawing.Color.Green;
            this.btnGood.Location = new System.Drawing.Point(548, 323);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(514, 56);
            this.btnGood.TabIndex = 1;
            this.btnGood.Text = "Ik had het goed :)";
            this.btnGood.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(18, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(524, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ik had het fout :(";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtGood
            // 
            this.txtGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGood.Location = new System.Drawing.Point(23, 41);
            this.txtGood.Name = "txtGood";
            this.txtGood.ReadOnly = true;
            this.txtGood.Size = new System.Drawing.Size(1039, 125);
            this.txtGood.TabIndex = 3;
            this.txtGood.TabStop = false;
            this.txtGood.Text = "";
            // 
            // txtYour
            // 
            this.txtYour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYour.Location = new System.Drawing.Point(23, 197);
            this.txtYour.Name = "txtYour";
            this.txtYour.ReadOnly = true;
            this.txtYour.Size = new System.Drawing.Size(1039, 120);
            this.txtYour.TabIndex = 4;
            this.txtYour.TabStop = false;
            this.txtYour.Text = "";
            // 
            // frmCheckAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 391);
            this.Controls.Add(this.txtYour);
            this.Controls.Add(this.txtGood);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheckAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCheckAnswer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox txtGood;
        public System.Windows.Forms.RichTextBox txtYour;
    }
}