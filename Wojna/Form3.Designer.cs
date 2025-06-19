namespace Wojna
{
    partial class Form3
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Nrgry = new DataGridViewTextBoxColumn();
            Nick = new DataGridViewTextBoxColumn();
            Wynik = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 94);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Historia gier";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nrgry, Nick, Wynik });
            dataGridView1.Location = new Point(146, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(509, 225);
            dataGridView1.TabIndex = 1;
            // 
            // Nrgry
            // 
            Nrgry.HeaderText = "Nr gry";
            Nrgry.MinimumWidth = 8;
            Nrgry.Name = "Nrgry";
            Nrgry.Width = 150;
            // 
            // Nick
            // 
            Nick.HeaderText = "Nick";
            Nick.MinimumWidth = 8;
            Nick.Name = "Nick";
            Nick.Width = 150;
            // 
            // Wynik
            // 
            Wynik.HeaderText = "Wynik";
            Wynik.MinimumWidth = 8;
            Wynik.Name = "Wynik";
            Wynik.Width = 150;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nrgry;
        private DataGridViewTextBoxColumn Nick;
        private DataGridViewTextBoxColumn Wynik;
    }
}