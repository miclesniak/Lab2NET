namespace Lab2NET
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
            button1=new Button();
            label1=new Label();
            pictureBox1=new PictureBox();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location=new Point(414, 376);
            button1.Name="button1";
            button1.Size=new Size(106, 46);
            button1.TabIndex=1;
            button1.Text="button1";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(376, 41);
            label1.Name="label1";
            label1.Size=new Size(68, 30);
            label1.TabIndex=3;
            label1.Text="label1";
            label1.Click+=label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location=new Point(32, 87);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(206, 257);
            pictureBox1.TabIndex=4;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(259, 389);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(100, 23);
            textBox1.TabIndex=5;
            textBox1.TextChanged+=textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(283, 87);
            textBox2.Multiline=true;
            textBox2.Name="textBox2";
            textBox2.Size=new Size(461, 115);
            textBox2.TabIndex=6;
            textBox2.TextChanged+=textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(283, 223);
            textBox3.Multiline=true;
            textBox3.Name="textBox3";
            textBox3.Size=new Size(461, 121);
            textBox3.TabIndex=7;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}