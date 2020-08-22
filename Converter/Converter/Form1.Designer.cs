namespace Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.InDec = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.InHex = new System.Windows.Forms.RadioButton();
            this.InOct = new System.Windows.Forms.RadioButton();
            this.InBin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.RadioButton();
            this.Sub = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.groupBoxSign = new System.Windows.Forms.GroupBox();
            this.Unsign = new System.Windows.Forms.RadioButton();
            this.Sign = new System.Windows.Forms.RadioButton();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.OutDec = new System.Windows.Forms.RadioButton();
            this.OutBin = new System.Windows.Forms.RadioButton();
            this.OutOct = new System.Windows.Forms.RadioButton();
            this.OutHex = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOperation.SuspendLayout();
            this.groupBoxSign.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number System Calculator";
            // 
            // InDec
            // 
            this.InDec.AutoSize = true;
            this.InDec.Location = new System.Drawing.Point(0, 21);
            this.InDec.Name = "InDec";
            this.InDec.Size = new System.Drawing.Size(63, 17);
            this.InDec.TabIndex = 1;
            this.InDec.TabStop = true;
            this.InDec.Text = "Decimal";
            this.InDec.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Systen";
            // 
            // InHex
            // 
            this.InHex.AutoSize = true;
            this.InHex.Location = new System.Drawing.Point(0, 90);
            this.InHex.Name = "InHex";
            this.InHex.Size = new System.Drawing.Size(86, 17);
            this.InHex.TabIndex = 3;
            this.InHex.TabStop = true;
            this.InHex.Text = "Hexadecimal";
            this.InHex.UseVisualStyleBackColor = true;
            // 
            // InOct
            // 
            this.InOct.AutoSize = true;
            this.InOct.Location = new System.Drawing.Point(0, 67);
            this.InOct.Name = "InOct";
            this.InOct.Size = new System.Drawing.Size(50, 17);
            this.InOct.TabIndex = 4;
            this.InOct.TabStop = true;
            this.InOct.Text = "Octal";
            this.InOct.UseVisualStyleBackColor = true;
            // 
            // InBin
            // 
            this.InBin.AutoSize = true;
            this.InBin.Location = new System.Drawing.Point(0, 44);
            this.InBin.Name = "InBin";
            this.InBin.Size = new System.Drawing.Size(54, 17);
            this.InBin.TabIndex = 5;
            this.InBin.TabStop = true;
            this.InBin.Text = "Binary";
            this.InBin.UseVisualStyleBackColor = true;
            this.InBin.CheckedChanged += new System.EventHandler(this.InBin_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operation";
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Location = new System.Drawing.Point(0, 21);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 17);
            this.Add.TabIndex = 7;
            this.Add.TabStop = true;
            this.Add.Text = "Addition";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(0, 44);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(79, 17);
            this.Sub.TabIndex = 8;
            this.Sub.TabStop = true;
            this.Sub.Text = "Subtraction";
            this.Sub.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(0, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Signed/Unsigned";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.InDec);
            this.groupBoxInput.Controls.Add(this.InBin);
            this.groupBoxInput.Controls.Add(this.InOct);
            this.groupBoxInput.Controls.Add(this.InHex);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Location = new System.Drawing.Point(41, 77);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(152, 128);
            this.groupBoxInput.TabIndex = 10;
            this.groupBoxInput.TabStop = false;
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.Add);
            this.groupBoxOperation.Controls.Add(this.Sub);
            this.groupBoxOperation.Controls.Add(this.label3);
            this.groupBoxOperation.Location = new System.Drawing.Point(199, 77);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Size = new System.Drawing.Size(152, 128);
            this.groupBoxOperation.TabIndex = 11;
            this.groupBoxOperation.TabStop = false;
            // 
            // groupBoxSign
            // 
            this.groupBoxSign.Controls.Add(this.Unsign);
            this.groupBoxSign.Controls.Add(this.Sign);
            this.groupBoxSign.Controls.Add(this.label4);
            this.groupBoxSign.Location = new System.Drawing.Point(41, 211);
            this.groupBoxSign.Name = "groupBoxSign";
            this.groupBoxSign.Size = new System.Drawing.Size(152, 125);
            this.groupBoxSign.TabIndex = 12;
            this.groupBoxSign.TabStop = false;
            // 
            // Unsign
            // 
            this.Unsign.AutoSize = true;
            this.Unsign.Location = new System.Drawing.Point(3, 42);
            this.Unsign.Name = "Unsign";
            this.Unsign.Size = new System.Drawing.Size(70, 17);
            this.Unsign.TabIndex = 7;
            this.Unsign.TabStop = true;
            this.Unsign.Text = "Unsigned";
            this.Unsign.UseVisualStyleBackColor = true;
            // 
            // Sign
            // 
            this.Sign.AutoSize = true;
            this.Sign.Location = new System.Drawing.Point(3, 19);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(58, 17);
            this.Sign.TabIndex = 8;
            this.Sign.TabStop = true;
            this.Sign.Text = "Signed";
            this.Sign.UseVisualStyleBackColor = true;
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(474, 185);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(167, 20);
            this.Number1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Number 1 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number 2 :";
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(474, 229);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(167, 20);
            this.Number2.TabIndex = 15;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(457, 275);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 27);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Output";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(300, 393);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(167, 20);
            this.Output.TabIndex = 18;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.OutDec);
            this.groupBoxOutput.Controls.Add(this.OutBin);
            this.groupBoxOutput.Controls.Add(this.OutOct);
            this.groupBoxOutput.Controls.Add(this.OutHex);
            this.groupBoxOutput.Controls.Add(this.label8);
            this.groupBoxOutput.Location = new System.Drawing.Point(199, 208);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(152, 128);
            this.groupBoxOutput.TabIndex = 20;
            this.groupBoxOutput.TabStop = false;
            // 
            // OutDec
            // 
            this.OutDec.AutoSize = true;
            this.OutDec.Location = new System.Drawing.Point(0, 21);
            this.OutDec.Name = "OutDec";
            this.OutDec.Size = new System.Drawing.Size(63, 17);
            this.OutDec.TabIndex = 1;
            this.OutDec.TabStop = true;
            this.OutDec.Text = "Decimal";
            this.OutDec.UseVisualStyleBackColor = true;
            // 
            // OutBin
            // 
            this.OutBin.AutoSize = true;
            this.OutBin.Location = new System.Drawing.Point(0, 44);
            this.OutBin.Name = "OutBin";
            this.OutBin.Size = new System.Drawing.Size(54, 17);
            this.OutBin.TabIndex = 5;
            this.OutBin.TabStop = true;
            this.OutBin.Text = "Binary";
            this.OutBin.UseVisualStyleBackColor = true;
            // 
            // OutOct
            // 
            this.OutOct.AutoSize = true;
            this.OutOct.Location = new System.Drawing.Point(0, 67);
            this.OutOct.Name = "OutOct";
            this.OutOct.Size = new System.Drawing.Size(50, 17);
            this.OutOct.TabIndex = 4;
            this.OutOct.TabStop = true;
            this.OutOct.Text = "Octal";
            this.OutOct.UseVisualStyleBackColor = true;
            // 
            // OutHex
            // 
            this.OutHex.AutoSize = true;
            this.OutHex.Location = new System.Drawing.Point(0, 90);
            this.OutHex.Name = "OutHex";
            this.OutHex.Size = new System.Drawing.Size(86, 17);
            this.OutHex.TabIndex = 3;
            this.OutHex.TabStop = true;
            this.OutHex.Text = "Hexadecimal";
            this.OutHex.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Output Number System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.groupBoxSign);
            this.Controls.Add(this.groupBoxOperation);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOperation.ResumeLayout(false);
            this.groupBoxOperation.PerformLayout();
            this.groupBoxSign.ResumeLayout(false);
            this.groupBoxSign.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InDec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton InHex;
        private System.Windows.Forms.RadioButton InOct;
        private System.Windows.Forms.RadioButton InBin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.RadioButton Sub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.GroupBox groupBoxSign;
        private System.Windows.Forms.RadioButton Unsign;
        private System.Windows.Forms.RadioButton Sign;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.RadioButton OutDec;
        private System.Windows.Forms.RadioButton OutBin;
        private System.Windows.Forms.RadioButton OutOct;
        private System.Windows.Forms.RadioButton OutHex;
        private System.Windows.Forms.Label label8;
    }
}

