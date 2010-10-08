namespace iDetector4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label1 = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(5, 1);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(316, 23);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Make sure you\'re in DFU before hitting the button below!";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(8, 153);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(316, 175);
            this.txtConsole.TabIndex = 7;
            this.txtConsole.Text = "";
            this.txtConsole.WordWrap = false;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Blue;
            this.Label2.Location = new System.Drawing.Point(219, 114);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 15);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "DFU Mode Help";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(5, 27);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(316, 81);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "New or old Bootrom?";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "By: iH8sn0w && Fallensn0w : )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(329, 133);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iDetector 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.RichTextBox txtConsole;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label3;

    }
}