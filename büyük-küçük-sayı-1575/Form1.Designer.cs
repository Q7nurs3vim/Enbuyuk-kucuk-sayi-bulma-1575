namespace büyük_küçük_sayı_1575
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
            lblSayi1 = new Label();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            lblSayi2 = new Label();
            txtSayi3 = new TextBox();
            lblSayi3 = new Label();
            lblEnbüyük = new Label();
            button1 = new Button();
            lblEnkücük = new Label();
            SuspendLayout();
            // 
            // lblSayi1
            // 
            lblSayi1.AutoSize = true;
            lblSayi1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSayi1.Location = new Point(16, 15);
            lblSayi1.Name = "lblSayi1";
            lblSayi1.Size = new Size(108, 20);
            lblSayi1.TabIndex = 0;
            lblSayi1.Text = "1. Sayıyı Girin :";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(126, 12);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(125, 27);
            txtSayi1.TabIndex = 1;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(126, 47);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(125, 27);
            txtSayi2.TabIndex = 3;
            // 
            // lblSayi2
            // 
            lblSayi2.AutoSize = true;
            lblSayi2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSayi2.Location = new Point(16, 50);
            lblSayi2.Name = "lblSayi2";
            lblSayi2.Size = new Size(110, 20);
            lblSayi2.TabIndex = 2;
            lblSayi2.Text = "2. Sayıyı Girin :";
            // 
            // txtSayi3
            // 
            txtSayi3.Location = new Point(126, 79);
            txtSayi3.Name = "txtSayi3";
            txtSayi3.Size = new Size(125, 27);
            txtSayi3.TabIndex = 5;
            // 
            // lblSayi3
            // 
            lblSayi3.AutoSize = true;
            lblSayi3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSayi3.Location = new Point(16, 83);
            lblSayi3.Name = "lblSayi3";
            lblSayi3.Size = new Size(110, 20);
            lblSayi3.TabIndex = 4;
            lblSayi3.Text = "3. Sayıyı Girin :";
            // 
            // lblEnbüyük
            // 
            lblEnbüyük.AutoSize = true;
            lblEnbüyük.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnbüyük.Location = new Point(12, 182);
            lblEnbüyük.Name = "lblEnbüyük";
            lblEnbüyük.Size = new Size(81, 20);
            lblEnbüyük.TabIndex = 6;
            lblEnbüyük.Text = "En Büyük :";
            lblEnbüyük.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(36, 126);
            button1.Name = "button1";
            button1.Size = new Size(176, 33);
            button1.TabIndex = 7;
            button1.Text = "KARŞILAŞTIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblEnkücük
            // 
            lblEnkücük.AutoSize = true;
            lblEnkücük.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnkücük.Location = new Point(10, 233);
            lblEnkücük.Name = "lblEnkücük";
            lblEnkücük.Size = new Size(80, 20);
            lblEnkücük.TabIndex = 8;
            lblEnkücük.Text = "En Küçük :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(263, 282);
            Controls.Add(lblEnkücük);
            Controls.Add(button1);
            Controls.Add(lblEnbüyük);
            Controls.Add(txtSayi3);
            Controls.Add(lblSayi3);
            Controls.Add(txtSayi2);
            Controls.Add(lblSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(lblSayi1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSayi1;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Label lblSayi2;
        private TextBox txtSayi3;
        private Label lblSayi3;
        private Label lblEnbüyük;
        private Button button1;
        private Label lblEnkücük;
    }
}