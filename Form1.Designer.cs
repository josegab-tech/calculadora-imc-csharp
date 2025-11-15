namespace WinFormsIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            frfsf = new Label();
            frsfsf = new Label();
            button1 = new Button();
            txtResult = new Label();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 46);
            label1.TabIndex = 0;
            label1.Text = "Calculadora IMC";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // frfsf
            // 
            frfsf.AutoSize = true;
            frfsf.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frfsf.ForeColor = Color.Black;
            frfsf.Location = new Point(35, 167);
            frfsf.Name = "frfsf";
            frfsf.Size = new Size(97, 46);
            frfsf.TabIndex = 1;
            frfsf.Text = "Peso:";
            frfsf.TextAlign = ContentAlignment.TopCenter;
            // 
            // frsfsf
            // 
            frsfsf.AutoSize = true;
            frsfsf.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frsfsf.ForeColor = Color.Black;
            frsfsf.Location = new Point(35, 86);
            frsfsf.Name = "frsfsf";
            frsfsf.Size = new Size(117, 46);
            frsfsf.TabIndex = 2;
            frsfsf.Text = "Altura:";
            frsfsf.TextAlign = ContentAlignment.TopCenter;
            frsfsf.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(100, 251);
            button1.Name = "button1";
            button1.Size = new Size(178, 51);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.Black;
            txtResult.Location = new Point(100, 346);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(187, 46);
            txtResult.TabIndex = 5;
            txtResult.Text = "Resultado:";
            txtResult.TextAlign = ContentAlignment.TopCenter;
            txtResult.Click += label5_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(184, 103);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(178, 27);
            txtAltura.TabIndex = 6;
            txtAltura.TextChanged += textBox1_TextChanged;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(184, 184);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(178, 27);
            txtPeso.TabIndex = 7;
            txtPeso.TextChanged += txtPeso_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(368, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(txtResult);
            Controls.Add(button1);
            Controls.Add(frsfsf);
            Controls.Add(frfsf);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label frfsf;
        private Label frsfsf;
        private Button button1;
        private Label txtResult;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private PictureBox pictureBox1;
    }
}
