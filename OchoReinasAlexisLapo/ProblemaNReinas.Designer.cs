namespace OchoReinasAlexisLapo
{
    partial class Problema8Reinas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numeroReinasTextBox = new TextBox();
            listaColocacionesListBox = new ListBox();
            iniciarButton = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 53);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 0;
            label1.Text = "N";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 89);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 1;
            label2.Text = "Número de colocaciones =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 124);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Colocaciones";
            // 
            // numeroReinasTextBox
            // 
            numeroReinasTextBox.Location = new Point(81, 50);
            numeroReinasTextBox.Name = "numeroReinasTextBox";
            numeroReinasTextBox.Size = new Size(125, 27);
            numeroReinasTextBox.TabIndex = 3;
            // 
            // listaColocacionesListBox
            // 
            listaColocacionesListBox.FormattingEnabled = true;
            listaColocacionesListBox.ItemHeight = 20;
            listaColocacionesListBox.Location = new Point(43, 157);
            listaColocacionesListBox.Name = "listaColocacionesListBox";
            listaColocacionesListBox.Size = new Size(243, 304);
            listaColocacionesListBox.TabIndex = 4;
            listaColocacionesListBox.Click += listBox1_Click;
            listaColocacionesListBox.KeyUp += listBox1_KeyUp;
            // 
            // iniciarButton
            // 
            iniciarButton.Location = new Point(327, 44);
            iniciarButton.Name = "iniciarButton";
            iniciarButton.Size = new Size(94, 29);
            iniciarButton.TabIndex = 6;
            iniciarButton.Text = "Iniciar";
            iniciarButton.UseVisualStyleBackColor = true;
            iniciarButton.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 101);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 7;
            label4.Text = "Tablero";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(327, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(326, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(351, 350);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(702, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(350, 350);
            dataGridView1.TabIndex = 5;
            // 
            // Problema8Reinas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 492);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(iniciarButton);
            Controls.Add(dataGridView1);
            Controls.Add(listaColocacionesListBox);
            Controls.Add(numeroReinasTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Problema8Reinas";
            Text = "Problema8Reinas";
            Load += Problema8Reinas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox numeroReinasTextBox;
        private ListBox listaColocacionesListBox;
        private Button iniciarButton;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
    }
}