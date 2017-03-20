namespace Draw
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.draw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lines = new System.Windows.Forms.Label();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.angleText = new System.Windows.Forms.TextBox();
            this.incremText = new System.Windows.Forms.TextBox();
            this.noLinesText = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 311);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.draw);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Lines);
            this.panel2.Controls.Add(this.lengthText);
            this.panel2.Controls.Add(this.angleText);
            this.panel2.Controls.Add(this.incremText);
            this.panel2.Controls.Add(this.noLinesText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 311);
            this.panel2.TabIndex = 1;
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.LightCoral;
            this.draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.draw.Location = new System.Drawing.Point(37, 255);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(75, 23);
            this.draw.TabIndex = 8;
            this.draw.Text = "DRAW";
            this.draw.UseVisualStyleBackColor = false;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Increments";
            // 
            // Lines
            // 
            this.Lines.AutoSize = true;
            this.Lines.Location = new System.Drawing.Point(12, 18);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(39, 13);
            this.Lines.TabIndex = 4;
            this.Lines.Text = "#Lines";
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(12, 90);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(100, 20);
            this.lengthText.TabIndex = 3;
            // 
            // angleText
            // 
            this.angleText.Location = new System.Drawing.Point(12, 145);
            this.angleText.Name = "angleText";
            this.angleText.Size = new System.Drawing.Size(100, 20);
            this.angleText.TabIndex = 2;
            // 
            // incremText
            // 
            this.incremText.Location = new System.Drawing.Point(12, 198);
            this.incremText.Name = "incremText";
            this.incremText.Size = new System.Drawing.Size(100, 20);
            this.incremText.TabIndex = 1;
            // 
            // noLinesText
            // 
            this.noLinesText.Location = new System.Drawing.Point(12, 34);
            this.noLinesText.Name = "noLinesText";
            this.noLinesText.Size = new System.Drawing.Size(100, 20);
            this.noLinesText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lines;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.TextBox angleText;
        private System.Windows.Forms.TextBox incremText;
        private System.Windows.Forms.TextBox noLinesText;
    }
}

