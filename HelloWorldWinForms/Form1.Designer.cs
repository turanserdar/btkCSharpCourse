
namespace HelloWorldWinForms
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn_changecolor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_hellomessage = new System.Windows.Forms.Label();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.Color.Peru;
            this.btn1.Location = new System.Drawing.Point(128, 101);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(134, 53);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Hello Click Me";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_changecolor
            // 
            this.btn_changecolor.Location = new System.Drawing.Point(336, 101);
            this.btn_changecolor.Name = "btn_changecolor";
            this.btn_changecolor.Size = new System.Drawing.Size(127, 53);
            this.btn_changecolor.TabIndex = 1;
            this.btn_changecolor.Text = "change color";
            this.btn_changecolor.UseVisualStyleBackColor = true;
            this.btn_changecolor.Click += new System.EventHandler(this.btn_changecolor_Click);
            // 
            // label1
            // 
           
            // 
            // lbl_hellomessage
            // 
            this.lbl_hellomessage.AutoSize = true;
            this.lbl_hellomessage.Location = new System.Drawing.Point(286, 216);
            this.lbl_hellomessage.Name = "lbl_hellomessage";
            this.lbl_hellomessage.Size = new System.Drawing.Size(0, 13);
            this.lbl_hellomessage.TabIndex = 3;
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_hello.Location = new System.Drawing.Point(278, 216);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(35, 13);
            this.lbl_hello.TabIndex = 4;
            this.lbl_hello.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.lbl_hellomessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_changecolor);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn_changecolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hellomessage;
        private System.Windows.Forms.Label lbl_hello;
    }
}

