namespace CatsAndDogs
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
            this.DogPicture = new System.Windows.Forms.PictureBox();
            this.GetAdog = new System.Windows.Forms.Button();
            this.CatPicture = new System.Windows.Forms.PictureBox();
            this.GetAcAT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DogPicture
            // 
            this.DogPicture.Location = new System.Drawing.Point(768, 74);
            this.DogPicture.Name = "DogPicture";
            this.DogPicture.Size = new System.Drawing.Size(334, 359);
            this.DogPicture.TabIndex = 1;
            this.DogPicture.TabStop = false;
            // 
            // GetAdog
            // 
            this.GetAdog.Location = new System.Drawing.Point(874, 497);
            this.GetAdog.Name = "GetAdog";
            this.GetAdog.Size = new System.Drawing.Size(115, 38);
            this.GetAdog.TabIndex = 2;
            this.GetAdog.Text = "Get dog image";
            this.GetAdog.UseVisualStyleBackColor = true;
            this.GetAdog.Click += new System.EventHandler(this.GetAdog_Click);
            // 
            // CatPicture
            // 
            this.CatPicture.Location = new System.Drawing.Point(147, 74);
            this.CatPicture.Name = "CatPicture";
            this.CatPicture.Size = new System.Drawing.Size(349, 359);
            this.CatPicture.TabIndex = 3;
            this.CatPicture.TabStop = false;
            // 
            // GetAcAT
            // 
            this.GetAcAT.Location = new System.Drawing.Point(253, 497);
            this.GetAcAT.Name = "GetAcAT";
            this.GetAcAT.Size = new System.Drawing.Size(120, 38);
            this.GetAcAT.TabIndex = 4;
            this.GetAcAT.Text = "Get cat image";
            this.GetAcAT.UseVisualStyleBackColor = true;
            this.GetAcAT.Click += new System.EventHandler(this.GetAcAT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 709);
            this.Controls.Add(this.GetAcAT);
            this.Controls.Add(this.CatPicture);
            this.Controls.Add(this.GetAdog);
            this.Controls.Add(this.DogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DogPicture;
        private System.Windows.Forms.Button GetAdog;
        private System.Windows.Forms.PictureBox CatPicture;
        private System.Windows.Forms.Button GetAcAT;
    }
}

