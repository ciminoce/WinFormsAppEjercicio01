
namespace WinFormsApp1
{
    partial class FrmOperacionesBasicas
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
            this.DividirButton = new System.Windows.Forms.Button();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SumasTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RestasTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductosTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CocientesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(51, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número 2:";
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(120, 71);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(100, 23);
            this.Numero2TextBox.TabIndex = 2;
            // 
            // SumarButton
            // 
            this.SumarButton.Image = global::WinFormsApp1.Properties.Resources.plus___36px;
            this.SumarButton.Location = new System.Drawing.Point(25, 22);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(75, 57);
            this.SumarButton.TabIndex = 3;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SalirButton.Location = new System.Drawing.Point(160, 305);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 66);
            this.SalirButton.TabIndex = 7;
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
            this.RestarButton.Location = new System.Drawing.Point(119, 22);
            this.RestarButton.Name = "RestarButton";
            this.RestarButton.Size = new System.Drawing.Size(75, 57);
            this.RestarButton.TabIndex = 4;
            this.RestarButton.Text = "Restar";
            this.RestarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RestarButton.UseVisualStyleBackColor = true;
            this.RestarButton.Click += new System.EventHandler(this.RestarButton_Click);
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Image = global::WinFormsApp1.Properties.Resources.multiplication_36px;
            this.MultiplicarButton.Location = new System.Drawing.Point(27, 85);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(75, 67);
            this.MultiplicarButton.TabIndex = 5;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            this.MultiplicarButton.Click += new System.EventHandler(this.MultiplicarButton_Click);
            // 
            // DividirButton
            // 
            this.DividirButton.Image = global::WinFormsApp1.Properties.Resources.divide_36px;
            this.DividirButton.Location = new System.Drawing.Point(119, 85);
            this.DividirButton.Name = "DividirButton";
            this.DividirButton.Size = new System.Drawing.Size(75, 67);
            this.DividirButton.TabIndex = 6;
            this.DividirButton.Text = "Dividir";
            this.DividirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DividirButton.UseVisualStyleBackColor = true;
            this.DividirButton.Click += new System.EventHandler(this.DividirButton_Click);
            // 
            // MostrarButton
            // 
            this.MostrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MostrarButton.BackColor = System.Drawing.Color.Transparent;
            this.MostrarButton.Image = global::WinFormsApp1.Properties.Resources.arrow_36px;
            this.MostrarButton.Location = new System.Drawing.Point(64, 305);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(75, 66);
            this.MostrarButton.TabIndex = 7;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MostrarButton.UseVisualStyleBackColor = false;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(292, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estadísticas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sumas:";
            // 
            // SumasTextBox
            // 
            this.SumasTextBox.Enabled = false;
            this.SumasTextBox.Location = new System.Drawing.Point(336, 75);
            this.SumasTextBox.Name = "SumasTextBox";
            this.SumasTextBox.Size = new System.Drawing.Size(100, 23);
            this.SumasTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Restas:";
            // 
            // RestasTextBox
            // 
            this.RestasTextBox.Enabled = false;
            this.RestasTextBox.Location = new System.Drawing.Point(336, 104);
            this.RestasTextBox.Name = "RestasTextBox";
            this.RestasTextBox.ReadOnly = true;
            this.RestasTextBox.Size = new System.Drawing.Size(100, 23);
            this.RestasTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Productos:";
            // 
            // ProductosTextBox
            // 
            this.ProductosTextBox.Enabled = false;
            this.ProductosTextBox.Location = new System.Drawing.Point(336, 135);
            this.ProductosTextBox.Name = "ProductosTextBox";
            this.ProductosTextBox.Size = new System.Drawing.Size(100, 23);
            this.ProductosTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cocientes:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CocientesTextBox
            // 
            this.CocientesTextBox.Enabled = false;
            this.CocientesTextBox.Location = new System.Drawing.Point(336, 164);
            this.CocientesTextBox.Name = "CocientesTextBox";
            this.CocientesTextBox.Size = new System.Drawing.Size(100, 23);
            this.CocientesTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SumarButton);
            this.groupBox1.Controls.Add(this.RestarButton);
            this.groupBox1.Controls.Add(this.DividirButton);
            this.groupBox1.Controls.Add(this.MultiplicarButton);
            this.groupBox1.Location = new System.Drawing.Point(41, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Operaciòn";
            // 
            // FrmOperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 406);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CocientesTextBox);
            this.Controls.Add(this.ProductosTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RestasTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SumasTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(499, 445);
            this.MinimumSize = new System.Drawing.Size(279, 445);
            this.Name = "FrmOperacionesBasicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones Básicas";
            this.Load += new System.EventHandler(this.FrmOperacionesBasicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button DividirButton;
        private System.Windows.Forms.TextBox CocientesTextBox;
        private System.Windows.Forms.TextBox ProductosTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RestasTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SumasTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

