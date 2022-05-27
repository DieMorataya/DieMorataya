namespace TAREA3PILASYCOLAS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPilas = new System.Windows.Forms.Button();
            this.btnColas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPOS DE ESTRUCTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el tipo de estructura a utilizar";
            // 
            // btnPilas
            // 
            this.btnPilas.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPilas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnPilas.Location = new System.Drawing.Point(123, 148);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Size = new System.Drawing.Size(75, 74);
            this.btnPilas.TabIndex = 2;
            this.btnPilas.Text = "PILAS";
            this.btnPilas.UseVisualStyleBackColor = false;
            this.btnPilas.Click += new System.EventHandler(this.btnPilas_Click);
            // 
            // btnColas
            // 
            this.btnColas.BackColor = System.Drawing.Color.CadetBlue;
            this.btnColas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnColas.Location = new System.Drawing.Point(269, 148);
            this.btnColas.Name = "btnColas";
            this.btnColas.Size = new System.Drawing.Size(75, 74);
            this.btnColas.TabIndex = 3;
            this.btnColas.Text = "COLAS";
            this.btnColas.UseVisualStyleBackColor = false;
            this.btnColas.Click += new System.EventHandler(this.btnColas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(394, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(492, 397);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnColas);
            this.Controls.Add(this.btnPilas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnPilas;
        private Button btnColas;
        private Button btnSalir;
    }
}