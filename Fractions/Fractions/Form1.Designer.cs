namespace Fractions
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
            this.leftUpBox = new System.Windows.Forms.TextBox();
            this.leftDownBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rightDownBox = new System.Windows.Forms.TextBox();
            this.rightUpBox = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.devision = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.nonequal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resDownBox = new System.Windows.Forms.TextBox();
            this.resUpBox = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftUpBox
            // 
            this.leftUpBox.Location = new System.Drawing.Point(74, 75);
            this.leftUpBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftUpBox.Name = "leftUpBox";
            this.leftUpBox.Size = new System.Drawing.Size(70, 27);
            this.leftUpBox.TabIndex = 0;
            this.leftUpBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // leftDownBox
            // 
            this.leftDownBox.Location = new System.Drawing.Point(74, 139);
            this.leftDownBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftDownBox.Name = "leftDownBox";
            this.leftDownBox.Size = new System.Drawing.Size(70, 27);
            this.leftDownBox.TabIndex = 1;
            this.leftDownBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyDownPressed);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(74, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 2);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(458, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 2);
            this.label2.TabIndex = 5;
            // 
            // rightDownBox
            // 
            this.rightDownBox.Location = new System.Drawing.Point(458, 139);
            this.rightDownBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rightDownBox.Name = "rightDownBox";
            this.rightDownBox.Size = new System.Drawing.Size(70, 27);
            this.rightDownBox.TabIndex = 4;
            this.rightDownBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyDownPressed);
            // 
            // rightUpBox
            // 
            this.rightUpBox.Location = new System.Drawing.Point(458, 75);
            this.rightUpBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rightUpBox.Name = "rightUpBox";
            this.rightUpBox.Size = new System.Drawing.Size(70, 27);
            this.rightUpBox.TabIndex = 3;
            this.rightUpBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPressed);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(172, 94);
            this.plus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(23, 29);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.onPlusClick);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(213, 94);
            this.minus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(23, 29);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.onMinusClick);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(253, 94);
            this.multiply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(23, 29);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.onMultiplyClick);
            // 
            // devision
            // 
            this.devision.Location = new System.Drawing.Point(294, 94);
            this.devision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.devision.Name = "devision";
            this.devision.Size = new System.Drawing.Size(23, 29);
            this.devision.TabIndex = 9;
            this.devision.Text = "/";
            this.devision.UseVisualStyleBackColor = true;
            this.devision.Click += new System.EventHandler(this.onDivisionClick);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(339, 94);
            this.equal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(40, 29);
            this.equal.TabIndex = 10;
            this.equal.Text = "==";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.onEqualClick);
            // 
            // nonequal
            // 
            this.nonequal.Location = new System.Drawing.Point(395, 94);
            this.nonequal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nonequal.Name = "nonequal";
            this.nonequal.Size = new System.Drawing.Size(33, 29);
            this.nonequal.TabIndex = 11;
            this.nonequal.Text = "!=";
            this.nonequal.UseVisualStyleBackColor = true;
            this.nonequal.Click += new System.EventHandler(this.onClickNonEqual);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(545, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(588, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 2);
            this.label4.TabIndex = 15;
            // 
            // resDownBox
            // 
            this.resDownBox.Location = new System.Drawing.Point(588, 139);
            this.resDownBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resDownBox.Name = "resDownBox";
            this.resDownBox.ReadOnly = true;
            this.resDownBox.Size = new System.Drawing.Size(70, 27);
            this.resDownBox.TabIndex = 14;
            // 
            // resUpBox
            // 
            this.resUpBox.Location = new System.Drawing.Point(588, 75);
            this.resUpBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resUpBox.Name = "resUpBox";
            this.resUpBox.ReadOnly = true;
            this.resUpBox.Size = new System.Drawing.Size(70, 27);
            this.resUpBox.TabIndex = 13;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(369, 159);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(0, 20);
            this.check.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 258);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resDownBox);
            this.Controls.Add(this.resUpBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nonequal);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.devision);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rightDownBox);
            this.Controls.Add(this.rightUpBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftDownBox);
            this.Controls.Add(this.leftUpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leftUpBox;
        private System.Windows.Forms.TextBox leftDownBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rightDownBox;
        private System.Windows.Forms.TextBox rightUpBox;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button devision;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button nonequal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resDownBox;
        private System.Windows.Forms.TextBox resUpBox;
        private Label check;
    }
}