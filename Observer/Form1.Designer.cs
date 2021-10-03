
namespace Observer
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
            this.buttonNewForm = new System.Windows.Forms.Button();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewForm
            // 
            this.buttonNewForm.Location = new System.Drawing.Point(104, 108);
            this.buttonNewForm.Name = "buttonNewForm";
            this.buttonNewForm.Size = new System.Drawing.Size(75, 23);
            this.buttonNewForm.TabIndex = 0;
            this.buttonNewForm.Text = "Yeni form";
            this.buttonNewForm.UseVisualStyleBackColor = true;
            this.buttonNewForm.Click += new System.EventHandler(this.buttonNewForm_Click);
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(104, 158);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeColor.TabIndex = 1;
            this.buttonChangeColor.Text = "Renk Değiştir";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 330);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.buttonNewForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewForm;
        private System.Windows.Forms.Button buttonChangeColor;
    }
}

