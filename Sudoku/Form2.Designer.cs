//=============================================================================
// Form2.Designer.cs
// About box for Sudoku gameplay interface.
// Copyright (c) 2007 Andrew Lin
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
namespace Sudoku
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 12, 9 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 93, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Sudoku, release 1";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point( 12, 35 );
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size( 110, 13 );
            this.labelURL.TabIndex = 1;
            this.labelURL.TabStop = true;
            this.labelURL.Text = "http://dragoncoil.com";
            this.labelURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.URL_LinkClicked );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 12, 22 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 155, 13 );
            this.label2.TabIndex = 2;
            this.label2.Text = "Copyright (c)  2007  Andrew Lin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.label12 );
            this.groupBox1.Controls.Add( this.label11 );
            this.groupBox1.Controls.Add( this.label10 );
            this.groupBox1.Controls.Add( this.label9 );
            this.groupBox1.Controls.Add( this.label8 );
            this.groupBox1.Controls.Add( this.label7 );
            this.groupBox1.Controls.Add( this.label6 );
            this.groupBox1.Controls.Add( this.label5 );
            this.groupBox1.Controls.Add( this.label4 );
            this.groupBox1.Controls.Add( this.label3 );
            this.groupBox1.Location = new System.Drawing.Point( 12, 69 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 365, 169 );
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point( 29, 79 );
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size( 154, 13 );
            this.label12.TabIndex = 9;
            this.label12.Text = "BKSP or DEL: clear active cell.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point( 29, 141 );
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size( 309, 13 );
            this.label11.TabIndex = 8;
            this.label11.Text = "Right Mouse Button: set or clear symbol as hint in clicked-in cell.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point( 29, 128 );
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size( 331, 13 );
            this.label10.TabIndex = 7;
            this.label10.Text = "Left Mouse Button Double-Click: set or clear symbol in clicked-in cell.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point( 29, 115 );
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size( 198, 13 );
            this.label9.TabIndex = 6;
            this.label9.Text = "Left Mouse Button: Select cell as active.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point( 7, 102 );
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size( 42, 13 );
            this.label8.TabIndex = 5;
            this.label8.Text = "Mouse:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point( 7, 16 );
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size( 55, 13 );
            this.label7.TabIndex = 4;
            this.label7.Text = "Keyboard:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point( 29, 66 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 265, 13 );
            this.label6.TabIndex = 3;
            this.label6.Text = "CTRL-SPACE: set or clear symbol as hint in active cell.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 29, 53 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 200, 13 );
            this.label5.TabIndex = 2;
            this.label5.Text = "SPACE: set or clear symbol in active cell.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 29, 40 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 94, 13 );
            this.label4.TabIndex = 1;
            this.label4.Text = "1-9: select symbol.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 29, 27 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 166, 13 );
            this.label3.TabIndex = 0;
            this.label3.Text = "Arrow Keys: move active cell box.";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point( 302, 256 );
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size( 75, 23 );
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler( this.buttonOK_Click );
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 393, 291 );
            this.Controls.Add( this.buttonOK );
            this.Controls.Add( this.groupBox1 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.labelURL );
            this.Controls.Add( this.label1 );
            this.Name = "AboutBox";
            this.Text = "About Sudoku";
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel labelURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonOK;
    }
}