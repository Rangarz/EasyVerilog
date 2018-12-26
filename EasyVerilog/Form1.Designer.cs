namespace EasyVerilog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DevA = new System.Windows.Forms.Button();
            this.DevB = new System.Windows.Forms.Button();
            this.DevC = new System.Windows.Forms.Button();
            this.TransQueue = new System.Windows.Forms.ListBox();
            this.AddTrans = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Init = new System.Windows.Forms.RadioButton();
            this.Target = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DevA
            // 
            this.DevA.Image = ((System.Drawing.Image)(resources.GetObject("DevA.Image")));
            this.DevA.Location = new System.Drawing.Point(33, 35);
            this.DevA.Name = "DevA";
            this.DevA.Size = new System.Drawing.Size(143, 129);
            this.DevA.TabIndex = 0;
            this.DevA.UseVisualStyleBackColor = true;
            // 
            // DevB
            // 
            this.DevB.Location = new System.Drawing.Point(223, 35);
            this.DevB.Name = "DevB";
            this.DevB.Size = new System.Drawing.Size(143, 129);
            this.DevB.TabIndex = 1;
            this.DevB.UseVisualStyleBackColor = true;
            this.DevB.Click += new System.EventHandler(this.button2_Click);
            // 
            // DevC
            // 
            this.DevC.Location = new System.Drawing.Point(405, 35);
            this.DevC.Name = "DevC";
            this.DevC.Size = new System.Drawing.Size(143, 129);
            this.DevC.TabIndex = 2;
            this.DevC.UseVisualStyleBackColor = true;
            // 
            // TransQueue
            // 
            this.TransQueue.FormattingEnabled = true;
            this.TransQueue.Location = new System.Drawing.Point(428, 200);
            this.TransQueue.Name = "TransQueue";
            this.TransQueue.Size = new System.Drawing.Size(120, 134);
            this.TransQueue.TabIndex = 3;
            // 
            // AddTrans
            // 
            this.AddTrans.Location = new System.Drawing.Point(302, 257);
            this.AddTrans.Name = "AddTrans";
            this.AddTrans.Size = new System.Drawing.Size(120, 20);
            this.AddTrans.TabIndex = 4;
            this.AddTrans.Text = "Add Transaction";
            this.AddTrans.UseVisualStyleBackColor = true;
            this.AddTrans.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Device A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Device B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Device C";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 314);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Absolute Time";
            // 
            // Init
            // 
            this.Init.AutoSize = true;
            this.Init.Location = new System.Drawing.Point(33, 198);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(63, 17);
            this.Init.TabIndex = 12;
            this.Init.TabStop = true;
            this.Init.Text = "Initiator";
            this.Init.UseVisualStyleBackColor = true;
            // 
            // Target
            // 
            this.Target.AutoSize = true;
            this.Target.Location = new System.Drawing.Point(102, 198);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(57, 17);
            this.Target.TabIndex = 13;
            this.Target.TabStop = true;
            this.Target.Text = "Target";
            this.Target.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "No. Of Words/Transaction";
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(302, 314);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(120, 23);
            this.Run.TabIndex = 15;
            this.Run.Text = "Run Simulation";
            this.Run.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(561, 358);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.Init);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddTrans);
            this.Controls.Add(this.TransQueue);
            this.Controls.Add(this.DevC);
            this.Controls.Add(this.DevB);
            this.Controls.Add(this.DevA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "EasyVerilog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DevA;
        private System.Windows.Forms.Button DevB;
        private System.Windows.Forms.Button DevC;
        private System.Windows.Forms.ListBox TransQueue;
        private System.Windows.Forms.Button AddTrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Init;
        private System.Windows.Forms.RadioButton Target;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Run;
    }
}

