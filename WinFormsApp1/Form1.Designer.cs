
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.SumarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.ErroresErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RestarButton = new System.Windows.Forms.Button();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(120, 37);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(100, 23);
            this.Numero1TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número 2:";
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(120, 90);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(100, 23);
            this.Numero2TextBox.TabIndex = 3;
            // 
            // SumarButton
            // 
            this.SumarButton.Image = global::WinFormsApp1.Properties.Resources.plus___36px;
            this.SumarButton.Location = new System.Drawing.Point(51, 153);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(75, 57);
            this.SumarButton.TabIndex = 4;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalirButton.Location = new System.Drawing.Point(237, 333);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 28);
            this.SalirButton.TabIndex = 5;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // ErroresErrorProvider
            // 
            this.ErroresErrorProvider.ContainerControl = this;
            // 
            // RestarButton
            // 
            this.RestarButton.Image = global::WinFormsApp1.Properties.Resources.minus_36px;
            this.RestarButton.Location = new System.Drawing.Point(145, 153);
            this.RestarButton.Name = "RestarButton";
            this.RestarButton.Size = new System.Drawing.Size(75, 57);
            this.RestarButton.TabIndex = 6;
            this.RestarButton.Text = "Restar";
            this.RestarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RestarButton.UseVisualStyleBackColor = true;
            this.RestarButton.Click += new System.EventHandler(this.RestarButton_Click);
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Image = global::WinFormsApp1.Properties.Resources.multiplication_36px;
            this.MultiplicarButton.Location = new System.Drawing.Point(51, 227);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(75, 67);
            this.MultiplicarButton.TabIndex = 7;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 406);
            this.ControlBox = false;
            this.Controls.Add(this.MultiplicarButton);
            this.Controls.Add(this.RestarButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(349, 422);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones Básicas";
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.ErrorProvider ErroresErrorProvider;
        private System.Windows.Forms.Button RestarButton;
        private System.Windows.Forms.Button MultiplicarButton;
    }
}

