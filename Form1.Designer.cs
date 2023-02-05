
namespace software_to_print_image
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
            this.input_money = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Button();
            this.output_money = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.output_type = new System.Windows.Forms.ComboBox();
            this.input_type = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_money
            // 
            this.input_money.Location = new System.Drawing.Point(150, 35);
            this.input_money.Name = "input_money";
            this.input_money.Size = new System.Drawing.Size(109, 20);
            this.input_money.TabIndex = 0;
            this.input_money.Text = "0";
            this.input_money.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number on THB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Convert To Currency Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // convert
            // 
            this.convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.convert.ForeColor = System.Drawing.Color.White;
            this.convert.Location = new System.Drawing.Point(373, 14);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(66, 98);
            this.convert.TabIndex = 5;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // output_money
            // 
            this.output_money.Location = new System.Drawing.Point(150, 65);
            this.output_money.Name = "output_money";
            this.output_money.Size = new System.Drawing.Size(109, 20);
            this.output_money.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_type);
            this.groupBox1.Controls.Add(this.output_type);
            this.groupBox1.Controls.Add(this.output_money);
            this.groupBox1.Controls.Add(this.input_money);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "convert money currency";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // output_type
            // 
            this.output_type.FormattingEnabled = true;
            this.output_type.Items.AddRange(new object[] {
            "WON",
            "YEN",
            "USD"});
            this.output_type.Location = new System.Drawing.Point(265, 64);
            this.output_type.Name = "output_type";
            this.output_type.Size = new System.Drawing.Size(59, 21);
            this.output_type.TabIndex = 7;
            // 
            // input_type
            // 
            this.input_type.FormattingEnabled = true;
            this.input_type.Items.AddRange(new object[] {
            "THB"});
            this.input_type.Location = new System.Drawing.Point(265, 35);
            this.input_type.Name = "input_type";
            this.input_type.Size = new System.Drawing.Size(59, 21);
            this.input_type.TabIndex = 8;
            this.input_type.Text = "THB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 125);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sofeware convert money ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox input_money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.TextBox output_money;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox output_type;
        private System.Windows.Forms.ComboBox input_type;
    }
}

