//=============================================================================
// Form1.Designer.cs
// Gameplay interface for the SudokuEngine
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
    partial class SudokuForm
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cell0_0 = new System.Windows.Forms.Label();
            this.cell0_1 = new System.Windows.Forms.Label();
            this.cell0_2 = new System.Windows.Forms.Label();
            this.cell0_3 = new System.Windows.Forms.Label();
            this.cell0_4 = new System.Windows.Forms.Label();
            this.cell0_5 = new System.Windows.Forms.Label();
            this.cell0_6 = new System.Windows.Forms.Label();
            this.cell0_7 = new System.Windows.Forms.Label();
            this.cell0_8 = new System.Windows.Forms.Label();
            this.cell1_8 = new System.Windows.Forms.Label();
            this.cell1_7 = new System.Windows.Forms.Label();
            this.cell1_6 = new System.Windows.Forms.Label();
            this.cell1_5 = new System.Windows.Forms.Label();
            this.cell1_4 = new System.Windows.Forms.Label();
            this.cell1_3 = new System.Windows.Forms.Label();
            this.cell1_2 = new System.Windows.Forms.Label();
            this.cell1_1 = new System.Windows.Forms.Label();
            this.cell1_0 = new System.Windows.Forms.Label();
            this.cell2_8 = new System.Windows.Forms.Label();
            this.cell2_7 = new System.Windows.Forms.Label();
            this.cell2_6 = new System.Windows.Forms.Label();
            this.cell2_5 = new System.Windows.Forms.Label();
            this.cell2_4 = new System.Windows.Forms.Label();
            this.cell2_3 = new System.Windows.Forms.Label();
            this.cell2_2 = new System.Windows.Forms.Label();
            this.cell2_1 = new System.Windows.Forms.Label();
            this.cell2_0 = new System.Windows.Forms.Label();
            this.cell5_8 = new System.Windows.Forms.Label();
            this.cell5_7 = new System.Windows.Forms.Label();
            this.cell5_6 = new System.Windows.Forms.Label();
            this.cell5_5 = new System.Windows.Forms.Label();
            this.cell5_4 = new System.Windows.Forms.Label();
            this.cell5_3 = new System.Windows.Forms.Label();
            this.cell5_2 = new System.Windows.Forms.Label();
            this.cell5_1 = new System.Windows.Forms.Label();
            this.cell5_0 = new System.Windows.Forms.Label();
            this.cell4_8 = new System.Windows.Forms.Label();
            this.cell4_7 = new System.Windows.Forms.Label();
            this.cell4_6 = new System.Windows.Forms.Label();
            this.cell4_5 = new System.Windows.Forms.Label();
            this.cell4_4 = new System.Windows.Forms.Label();
            this.cell4_3 = new System.Windows.Forms.Label();
            this.cell4_2 = new System.Windows.Forms.Label();
            this.cell4_1 = new System.Windows.Forms.Label();
            this.cell4_0 = new System.Windows.Forms.Label();
            this.cell3_8 = new System.Windows.Forms.Label();
            this.cell3_7 = new System.Windows.Forms.Label();
            this.cell3_6 = new System.Windows.Forms.Label();
            this.cell3_5 = new System.Windows.Forms.Label();
            this.cell3_4 = new System.Windows.Forms.Label();
            this.cell3_3 = new System.Windows.Forms.Label();
            this.cell3_2 = new System.Windows.Forms.Label();
            this.cell3_1 = new System.Windows.Forms.Label();
            this.cell3_0 = new System.Windows.Forms.Label();
            this.cell8_8 = new System.Windows.Forms.Label();
            this.cell8_7 = new System.Windows.Forms.Label();
            this.cell8_6 = new System.Windows.Forms.Label();
            this.cell8_5 = new System.Windows.Forms.Label();
            this.cell8_4 = new System.Windows.Forms.Label();
            this.cell8_3 = new System.Windows.Forms.Label();
            this.cell8_2 = new System.Windows.Forms.Label();
            this.cell8_1 = new System.Windows.Forms.Label();
            this.cell8_0 = new System.Windows.Forms.Label();
            this.cell7_8 = new System.Windows.Forms.Label();
            this.cell7_7 = new System.Windows.Forms.Label();
            this.cell7_6 = new System.Windows.Forms.Label();
            this.cell7_5 = new System.Windows.Forms.Label();
            this.cell7_4 = new System.Windows.Forms.Label();
            this.cell7_3 = new System.Windows.Forms.Label();
            this.cell7_2 = new System.Windows.Forms.Label();
            this.cell7_1 = new System.Windows.Forms.Label();
            this.cell7_0 = new System.Windows.Forms.Label();
            this.cell6_8 = new System.Windows.Forms.Label();
            this.cell6_7 = new System.Windows.Forms.Label();
            this.cell6_6 = new System.Windows.Forms.Label();
            this.cell6_5 = new System.Windows.Forms.Label();
            this.cell6_4 = new System.Windows.Forms.Label();
            this.cell6_3 = new System.Windows.Forms.Label();
            this.cell6_2 = new System.Windows.Forms.Label();
            this.cell6_1 = new System.Windows.Forms.Label();
            this.cell6_0 = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSudokuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point( 13, 479 );
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size( 31, 17 );
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler( this.radioButton_CheckedChanged );
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point( 50, 479 );
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size( 31, 17 );
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler( this.radioButton_CheckedChanged );
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point( 87, 479 );
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size( 31, 17 );
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler( this.radioButton_CheckedChanged );
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point( 124, 479 );
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size( 31, 17 );
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler( this.radioButton_CheckedChanged );
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point( 161, 479 );
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size( 31, 17 );
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler( this.radioButton_CheckedChanged );
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point( 198, 479 );
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size( 31, 17 );
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler( this.radioButton_CheckedChanged );
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point( 235, 479 );
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size( 31, 17 );
            this.radioButton7.TabIndex = 6;
            this.radioButton7.Text = "7";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler( this.radioButton_CheckedChanged );
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point( 272, 479 );
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size( 31, 17 );
            this.radioButton8.TabIndex = 7;
            this.radioButton8.Text = "8";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler( this.radioButton_CheckedChanged );
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point( 309, 479 );
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size( 31, 17 );
            this.radioButton9.TabIndex = 8;
            this.radioButton9.Text = "9";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler( this.radioButton_CheckedChanged );
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem} );
            this.menuStrip.Location = new System.Drawing.Point( 0, 0 );
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size( 353, 24 );
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.quitToolStripMenuItem} );
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size( 35, 20 );
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler( this.newToolStripMenuItem_Click );
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler( this.quitToolStripMenuItem_Click );
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.solveToolStripMenuItem} );
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size( 46, 20 );
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // solveToolStripMenuItem
            // 
            this.solveToolStripMenuItem.Name = "solveToolStripMenuItem";
            this.solveToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.solveToolStripMenuItem.Text = "Solve";
            this.solveToolStripMenuItem.Click += new System.EventHandler( this.solveToolStripMenuItem_Click );
            // 
            // cell0_0
            // 
            this.cell0_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell0_0.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell0_0.Location = new System.Drawing.Point( 13, 28 );
            this.cell0_0.Name = "cell0_0";
            this.cell0_0.Size = new System.Drawing.Size( 36, 47 );
            this.cell0_0.TabIndex = 10;
            this.cell0_0.Text = "1 2 3 4 5 6 7 8 9";
            this.cell0_0.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell0_0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell0_1
            // 
            this.cell0_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell0_1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell0_1.Location = new System.Drawing.Point( 48, 28 );
            this.cell0_1.Name = "cell0_1";
            this.cell0_1.Size = new System.Drawing.Size( 36, 47 );
            this.cell0_1.TabIndex = 11;
            this.cell0_1.Text = "1 2 3 4 5 6 7 8 9";
            this.cell0_1.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell0_1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell0_2
            // 
            this.cell0_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell0_2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell0_2.Location = new System.Drawing.Point( 83, 28 );
            this.cell0_2.Name = "cell0_2";
            this.cell0_2.Size = new System.Drawing.Size( 36, 47 );
            this.cell0_2.TabIndex = 12;
            this.cell0_2.Text = "1 2 3 4 5 6 7 8 9";
            this.cell0_2.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell0_2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell0_3
            // 
            this.cell0_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell0_3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell0_3.Location = new System.Drawing.Point( 124, 28 );
            this.cell0_3.Name = "cell0_3";
            this.cell0_3.Size = new System.Drawing.Size( 36, 47 );
            this.cell0_3.TabIndex = 13;
            this.cell0_3.Text = "1 2 3 4 5 6 7 8 9";
            this.cell0_3.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell0_3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell0_4
            // 
            this.cell0_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell0_4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell0_4.Location = new System.Drawing.Point( 159, 28 );
            this.cell0_4.Name = "cell0_4";
            this.cell0_4.Size = new System.Drawing.Size( 36, 47 );
            this.cell0_4.TabIndex = 14;
            this.cell0_4.Text = "1 2 3 4 5 6 7 8 9";
            this.cell0_4.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell0_4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell0_5
            // 
            this.cell0_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell0_5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell0_5.Location = new System.Drawing.Point( 194, 28 );
            this.cell0_5.Name = "cell0_5";
            this.cell0_5.Size = new System.Drawing.Size( 36, 47 );
            this.cell0_5.TabIndex = 15;
            this.cell0_5.Text = "1 2 3 4 5 6 7 8 9";
            this.cell0_5.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell0_5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell0_6
            // 
            this.cell0_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell0_6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell0_6.Location = new System.Drawing.Point( 235, 28 );
            this.cell0_6.Name = "cell0_6";
            this.cell0_6.Size = new System.Drawing.Size( 36, 47 );
            this.cell0_6.TabIndex = 16;
            this.cell0_6.Text = "1 2 3 4 5 6 7 8 9";
            this.cell0_6.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell0_6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell0_7
            // 
            this.cell0_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell0_7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell0_7.Location = new System.Drawing.Point( 270, 28 );
            this.cell0_7.Name = "cell0_7";
            this.cell0_7.Size = new System.Drawing.Size( 36, 47 );
            this.cell0_7.TabIndex = 17;
            this.cell0_7.Text = "1 2 3 4 5 6 7 8 9";
            this.cell0_7.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell0_7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell0_8
            // 
            this.cell0_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell0_8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell0_8.Location = new System.Drawing.Point( 305, 28 );
            this.cell0_8.Name = "cell0_8";
            this.cell0_8.Size = new System.Drawing.Size( 36, 47 );
            this.cell0_8.TabIndex = 18;
            this.cell0_8.Text = "1 2 3 4 5 6 7 8 9";
            this.cell0_8.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell0_8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell1_8
            // 
            this.cell1_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell1_8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell1_8.Location = new System.Drawing.Point( 305, 74 );
            this.cell1_8.Name = "cell1_8";
            this.cell1_8.Size = new System.Drawing.Size( 36, 47 );
            this.cell1_8.TabIndex = 27;
            this.cell1_8.Text = "1 2 3 4 5 6 7 8 9";
            this.cell1_8.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell1_8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell1_7
            // 
            this.cell1_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell1_7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell1_7.Location = new System.Drawing.Point( 270, 74 );
            this.cell1_7.Name = "cell1_7";
            this.cell1_7.Size = new System.Drawing.Size( 36, 47 );
            this.cell1_7.TabIndex = 26;
            this.cell1_7.Text = "1 2 3 4 5 6 7 8 9";
            this.cell1_7.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell1_7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell1_6
            // 
            this.cell1_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell1_6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell1_6.Location = new System.Drawing.Point( 235, 74 );
            this.cell1_6.Name = "cell1_6";
            this.cell1_6.Size = new System.Drawing.Size( 36, 47 );
            this.cell1_6.TabIndex = 25;
            this.cell1_6.Text = "1 2 3 4 5 6 7 8 9";
            this.cell1_6.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell1_6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell1_5
            // 
            this.cell1_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell1_5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell1_5.Location = new System.Drawing.Point( 194, 74 );
            this.cell1_5.Name = "cell1_5";
            this.cell1_5.Size = new System.Drawing.Size( 36, 47 );
            this.cell1_5.TabIndex = 24;
            this.cell1_5.Text = "1 2 3 4 5 6 7 8 9";
            this.cell1_5.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell1_5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell1_4
            // 
            this.cell1_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell1_4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell1_4.Location = new System.Drawing.Point( 159, 74 );
            this.cell1_4.Name = "cell1_4";
            this.cell1_4.Size = new System.Drawing.Size( 36, 47 );
            this.cell1_4.TabIndex = 23;
            this.cell1_4.Text = "1 2 3 4 5 6 7 8 9";
            this.cell1_4.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell1_4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell1_3
            // 
            this.cell1_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell1_3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell1_3.Location = new System.Drawing.Point( 124, 74 );
            this.cell1_3.Name = "cell1_3";
            this.cell1_3.Size = new System.Drawing.Size( 36, 47 );
            this.cell1_3.TabIndex = 22;
            this.cell1_3.Text = "1 2 3 4 5 6 7 8 9";
            this.cell1_3.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell1_3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell1_2
            // 
            this.cell1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell1_2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell1_2.Location = new System.Drawing.Point( 83, 74 );
            this.cell1_2.Name = "cell1_2";
            this.cell1_2.Size = new System.Drawing.Size( 36, 47 );
            this.cell1_2.TabIndex = 21;
            this.cell1_2.Text = "1 2 3 4 5 6 7 8 9";
            this.cell1_2.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell1_2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell1_1
            // 
            this.cell1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell1_1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell1_1.Location = new System.Drawing.Point( 48, 74 );
            this.cell1_1.Name = "cell1_1";
            this.cell1_1.Size = new System.Drawing.Size( 36, 47 );
            this.cell1_1.TabIndex = 20;
            this.cell1_1.Text = "1 2 3 4 5 6 7 8 9";
            this.cell1_1.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell1_1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell1_0
            // 
            this.cell1_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell1_0.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell1_0.Location = new System.Drawing.Point( 13, 74 );
            this.cell1_0.Name = "cell1_0";
            this.cell1_0.Size = new System.Drawing.Size( 36, 47 );
            this.cell1_0.TabIndex = 19;
            this.cell1_0.Text = "1 2 3 4 5 6 7 8 9";
            this.cell1_0.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell1_0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell2_8
            // 
            this.cell2_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell2_8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell2_8.Location = new System.Drawing.Point( 305, 120 );
            this.cell2_8.Name = "cell2_8";
            this.cell2_8.Size = new System.Drawing.Size( 36, 47 );
            this.cell2_8.TabIndex = 36;
            this.cell2_8.Text = "1 2 3 4 5 6 7 8 9";
            this.cell2_8.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell2_8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell2_7
            // 
            this.cell2_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell2_7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell2_7.Location = new System.Drawing.Point( 270, 120 );
            this.cell2_7.Name = "cell2_7";
            this.cell2_7.Size = new System.Drawing.Size( 36, 47 );
            this.cell2_7.TabIndex = 35;
            this.cell2_7.Text = "1 2 3 4 5 6 7 8 9";
            this.cell2_7.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell2_7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell2_6
            // 
            this.cell2_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell2_6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell2_6.Location = new System.Drawing.Point( 235, 120 );
            this.cell2_6.Name = "cell2_6";
            this.cell2_6.Size = new System.Drawing.Size( 36, 47 );
            this.cell2_6.TabIndex = 34;
            this.cell2_6.Text = "1 2 3 4 5 6 7 8 9";
            this.cell2_6.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell2_6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell2_5
            // 
            this.cell2_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell2_5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell2_5.Location = new System.Drawing.Point( 194, 120 );
            this.cell2_5.Name = "cell2_5";
            this.cell2_5.Size = new System.Drawing.Size( 36, 47 );
            this.cell2_5.TabIndex = 33;
            this.cell2_5.Text = "1 2 3 4 5 6 7 8 9";
            this.cell2_5.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell2_5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell2_4
            // 
            this.cell2_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell2_4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell2_4.Location = new System.Drawing.Point( 159, 120 );
            this.cell2_4.Name = "cell2_4";
            this.cell2_4.Size = new System.Drawing.Size( 36, 47 );
            this.cell2_4.TabIndex = 32;
            this.cell2_4.Text = "1 2 3 4 5 6 7 8 9";
            this.cell2_4.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell2_4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell2_3
            // 
            this.cell2_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell2_3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell2_3.Location = new System.Drawing.Point( 124, 120 );
            this.cell2_3.Name = "cell2_3";
            this.cell2_3.Size = new System.Drawing.Size( 36, 47 );
            this.cell2_3.TabIndex = 31;
            this.cell2_3.Text = "1 2 3 4 5 6 7 8 9";
            this.cell2_3.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell2_3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell2_2
            // 
            this.cell2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell2_2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell2_2.Location = new System.Drawing.Point( 83, 120 );
            this.cell2_2.Name = "cell2_2";
            this.cell2_2.Size = new System.Drawing.Size( 36, 47 );
            this.cell2_2.TabIndex = 30;
            this.cell2_2.Text = "1 2 3 4 5 6 7 8 9";
            this.cell2_2.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell2_2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell2_1
            // 
            this.cell2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell2_1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell2_1.Location = new System.Drawing.Point( 48, 120 );
            this.cell2_1.Name = "cell2_1";
            this.cell2_1.Size = new System.Drawing.Size( 36, 47 );
            this.cell2_1.TabIndex = 29;
            this.cell2_1.Text = "1 2 3 4 5 6 7 8 9";
            this.cell2_1.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell2_1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell2_0
            // 
            this.cell2_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell2_0.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell2_0.Location = new System.Drawing.Point( 13, 120 );
            this.cell2_0.Name = "cell2_0";
            this.cell2_0.Size = new System.Drawing.Size( 36, 47 );
            this.cell2_0.TabIndex = 28;
            this.cell2_0.Text = "1 2 3 4 5 6 7 8 9";
            this.cell2_0.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell2_0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell5_8
            // 
            this.cell5_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell5_8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell5_8.Location = new System.Drawing.Point( 305, 266 );
            this.cell5_8.Name = "cell5_8";
            this.cell5_8.Size = new System.Drawing.Size( 36, 47 );
            this.cell5_8.TabIndex = 63;
            this.cell5_8.Text = "1 2 3 4 5 6 7 8 9";
            this.cell5_8.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell5_8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell5_7
            // 
            this.cell5_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell5_7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell5_7.Location = new System.Drawing.Point( 270, 266 );
            this.cell5_7.Name = "cell5_7";
            this.cell5_7.Size = new System.Drawing.Size( 36, 47 );
            this.cell5_7.TabIndex = 62;
            this.cell5_7.Text = "1 2 3 4 5 6 7 8 9";
            this.cell5_7.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell5_7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell5_6
            // 
            this.cell5_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell5_6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell5_6.Location = new System.Drawing.Point( 235, 266 );
            this.cell5_6.Name = "cell5_6";
            this.cell5_6.Size = new System.Drawing.Size( 36, 47 );
            this.cell5_6.TabIndex = 61;
            this.cell5_6.Text = "1 2 3 4 5 6 7 8 9";
            this.cell5_6.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell5_6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell5_5
            // 
            this.cell5_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell5_5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell5_5.Location = new System.Drawing.Point( 194, 266 );
            this.cell5_5.Name = "cell5_5";
            this.cell5_5.Size = new System.Drawing.Size( 36, 47 );
            this.cell5_5.TabIndex = 60;
            this.cell5_5.Text = "1 2 3 4 5 6 7 8 9";
            this.cell5_5.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell5_5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell5_4
            // 
            this.cell5_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell5_4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell5_4.Location = new System.Drawing.Point( 159, 266 );
            this.cell5_4.Name = "cell5_4";
            this.cell5_4.Size = new System.Drawing.Size( 36, 47 );
            this.cell5_4.TabIndex = 59;
            this.cell5_4.Text = "1 2 3 4 5 6 7 8 9";
            this.cell5_4.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell5_4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell5_3
            // 
            this.cell5_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell5_3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell5_3.Location = new System.Drawing.Point( 124, 266 );
            this.cell5_3.Name = "cell5_3";
            this.cell5_3.Size = new System.Drawing.Size( 36, 47 );
            this.cell5_3.TabIndex = 58;
            this.cell5_3.Text = "1 2 3 4 5 6 7 8 9";
            this.cell5_3.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell5_3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell5_2
            // 
            this.cell5_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell5_2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell5_2.Location = new System.Drawing.Point( 83, 266 );
            this.cell5_2.Name = "cell5_2";
            this.cell5_2.Size = new System.Drawing.Size( 36, 47 );
            this.cell5_2.TabIndex = 57;
            this.cell5_2.Text = "1 2 3 4 5 6 7 8 9";
            this.cell5_2.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell5_2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell5_1
            // 
            this.cell5_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell5_1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell5_1.Location = new System.Drawing.Point( 48, 266 );
            this.cell5_1.Name = "cell5_1";
            this.cell5_1.Size = new System.Drawing.Size( 36, 47 );
            this.cell5_1.TabIndex = 56;
            this.cell5_1.Text = "1 2 3 4 5 6 7 8 9";
            this.cell5_1.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell5_1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell5_0
            // 
            this.cell5_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell5_0.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell5_0.Location = new System.Drawing.Point( 13, 266 );
            this.cell5_0.Name = "cell5_0";
            this.cell5_0.Size = new System.Drawing.Size( 36, 47 );
            this.cell5_0.TabIndex = 55;
            this.cell5_0.Text = "1 2 3 4 5 6 7 8 9";
            this.cell5_0.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell5_0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell4_8
            // 
            this.cell4_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell4_8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell4_8.Location = new System.Drawing.Point( 305, 220 );
            this.cell4_8.Name = "cell4_8";
            this.cell4_8.Size = new System.Drawing.Size( 36, 47 );
            this.cell4_8.TabIndex = 54;
            this.cell4_8.Text = "1 2 3 4 5 6 7 8 9";
            this.cell4_8.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell4_8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell4_7
            // 
            this.cell4_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell4_7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell4_7.Location = new System.Drawing.Point( 270, 220 );
            this.cell4_7.Name = "cell4_7";
            this.cell4_7.Size = new System.Drawing.Size( 36, 47 );
            this.cell4_7.TabIndex = 53;
            this.cell4_7.Text = "1 2 3 4 5 6 7 8 9";
            this.cell4_7.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell4_7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell4_6
            // 
            this.cell4_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell4_6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell4_6.Location = new System.Drawing.Point( 235, 220 );
            this.cell4_6.Name = "cell4_6";
            this.cell4_6.Size = new System.Drawing.Size( 36, 47 );
            this.cell4_6.TabIndex = 52;
            this.cell4_6.Text = "1 2 3 4 5 6 7 8 9";
            this.cell4_6.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell4_6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell4_5
            // 
            this.cell4_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell4_5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell4_5.Location = new System.Drawing.Point( 194, 220 );
            this.cell4_5.Name = "cell4_5";
            this.cell4_5.Size = new System.Drawing.Size( 36, 47 );
            this.cell4_5.TabIndex = 51;
            this.cell4_5.Text = "1 2 3 4 5 6 7 8 9";
            this.cell4_5.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell4_5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell4_4
            // 
            this.cell4_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell4_4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell4_4.Location = new System.Drawing.Point( 159, 220 );
            this.cell4_4.Name = "cell4_4";
            this.cell4_4.Size = new System.Drawing.Size( 36, 47 );
            this.cell4_4.TabIndex = 50;
            this.cell4_4.Text = "1 2 3 4 5 6 7 8 9";
            this.cell4_4.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell4_4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell4_3
            // 
            this.cell4_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell4_3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell4_3.Location = new System.Drawing.Point( 124, 220 );
            this.cell4_3.Name = "cell4_3";
            this.cell4_3.Size = new System.Drawing.Size( 36, 47 );
            this.cell4_3.TabIndex = 49;
            this.cell4_3.Text = "1 2 3 4 5 6 7 8 9";
            this.cell4_3.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell4_3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell4_2
            // 
            this.cell4_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell4_2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell4_2.Location = new System.Drawing.Point( 83, 220 );
            this.cell4_2.Name = "cell4_2";
            this.cell4_2.Size = new System.Drawing.Size( 36, 47 );
            this.cell4_2.TabIndex = 48;
            this.cell4_2.Text = "1 2 3 4 5 6 7 8 9";
            this.cell4_2.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell4_2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell4_1
            // 
            this.cell4_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell4_1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell4_1.Location = new System.Drawing.Point( 48, 220 );
            this.cell4_1.Name = "cell4_1";
            this.cell4_1.Size = new System.Drawing.Size( 36, 47 );
            this.cell4_1.TabIndex = 47;
            this.cell4_1.Text = "1 2 3 4 5 6 7 8 9";
            this.cell4_1.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell4_1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell4_0
            // 
            this.cell4_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell4_0.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell4_0.Location = new System.Drawing.Point( 13, 220 );
            this.cell4_0.Name = "cell4_0";
            this.cell4_0.Size = new System.Drawing.Size( 36, 47 );
            this.cell4_0.TabIndex = 46;
            this.cell4_0.Text = "1 2 3 4 5 6 7 8 9";
            this.cell4_0.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell4_0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell3_8
            // 
            this.cell3_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell3_8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell3_8.Location = new System.Drawing.Point( 305, 174 );
            this.cell3_8.Name = "cell3_8";
            this.cell3_8.Size = new System.Drawing.Size( 36, 47 );
            this.cell3_8.TabIndex = 45;
            this.cell3_8.Text = "1 2 3 4 5 6 7 8 9";
            this.cell3_8.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell3_8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell3_7
            // 
            this.cell3_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell3_7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell3_7.Location = new System.Drawing.Point( 270, 174 );
            this.cell3_7.Name = "cell3_7";
            this.cell3_7.Size = new System.Drawing.Size( 36, 47 );
            this.cell3_7.TabIndex = 44;
            this.cell3_7.Text = "1 2 3 4 5 6 7 8 9";
            this.cell3_7.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell3_7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell3_6
            // 
            this.cell3_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell3_6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell3_6.Location = new System.Drawing.Point( 235, 174 );
            this.cell3_6.Name = "cell3_6";
            this.cell3_6.Size = new System.Drawing.Size( 36, 47 );
            this.cell3_6.TabIndex = 43;
            this.cell3_6.Text = "1 2 3 4 5 6 7 8 9";
            this.cell3_6.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell3_6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell3_5
            // 
            this.cell3_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell3_5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell3_5.Location = new System.Drawing.Point( 194, 174 );
            this.cell3_5.Name = "cell3_5";
            this.cell3_5.Size = new System.Drawing.Size( 36, 47 );
            this.cell3_5.TabIndex = 42;
            this.cell3_5.Text = "1 2 3 4 5 6 7 8 9";
            this.cell3_5.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell3_5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell3_4
            // 
            this.cell3_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell3_4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell3_4.Location = new System.Drawing.Point( 159, 174 );
            this.cell3_4.Name = "cell3_4";
            this.cell3_4.Size = new System.Drawing.Size( 36, 47 );
            this.cell3_4.TabIndex = 41;
            this.cell3_4.Text = "1 2 3 4 5 6 7 8 9";
            this.cell3_4.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell3_4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell3_3
            // 
            this.cell3_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell3_3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell3_3.Location = new System.Drawing.Point( 124, 174 );
            this.cell3_3.Name = "cell3_3";
            this.cell3_3.Size = new System.Drawing.Size( 36, 47 );
            this.cell3_3.TabIndex = 40;
            this.cell3_3.Text = "1 2 3 4 5 6 7 8 9";
            this.cell3_3.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell3_3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell3_2
            // 
            this.cell3_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell3_2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell3_2.Location = new System.Drawing.Point( 83, 174 );
            this.cell3_2.Name = "cell3_2";
            this.cell3_2.Size = new System.Drawing.Size( 36, 47 );
            this.cell3_2.TabIndex = 39;
            this.cell3_2.Text = "1 2 3 4 5 6 7 8 9";
            this.cell3_2.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell3_2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell3_1
            // 
            this.cell3_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell3_1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell3_1.Location = new System.Drawing.Point( 48, 174 );
            this.cell3_1.Name = "cell3_1";
            this.cell3_1.Size = new System.Drawing.Size( 36, 47 );
            this.cell3_1.TabIndex = 38;
            this.cell3_1.Text = "1 2 3 4 5 6 7 8 9";
            this.cell3_1.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell3_1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell3_0
            // 
            this.cell3_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell3_0.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell3_0.Location = new System.Drawing.Point( 13, 174 );
            this.cell3_0.Name = "cell3_0";
            this.cell3_0.Size = new System.Drawing.Size( 36, 47 );
            this.cell3_0.TabIndex = 37;
            this.cell3_0.Text = "1 2 3 4 5 6 7 8 9";
            this.cell3_0.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell3_0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell8_8
            // 
            this.cell8_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell8_8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell8_8.Location = new System.Drawing.Point( 305, 411 );
            this.cell8_8.Name = "cell8_8";
            this.cell8_8.Size = new System.Drawing.Size( 36, 47 );
            this.cell8_8.TabIndex = 90;
            this.cell8_8.Text = "1 2 3 4 5 6 7 8 9";
            this.cell8_8.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell8_8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell8_7
            // 
            this.cell8_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell8_7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell8_7.Location = new System.Drawing.Point( 270, 411 );
            this.cell8_7.Name = "cell8_7";
            this.cell8_7.Size = new System.Drawing.Size( 36, 47 );
            this.cell8_7.TabIndex = 89;
            this.cell8_7.Text = "1 2 3 4 5 6 7 8 9";
            this.cell8_7.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell8_7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell8_6
            // 
            this.cell8_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell8_6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell8_6.Location = new System.Drawing.Point( 235, 411 );
            this.cell8_6.Name = "cell8_6";
            this.cell8_6.Size = new System.Drawing.Size( 36, 47 );
            this.cell8_6.TabIndex = 88;
            this.cell8_6.Text = "1 2 3 4 5 6 7 8 9";
            this.cell8_6.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell8_6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell8_5
            // 
            this.cell8_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell8_5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell8_5.Location = new System.Drawing.Point( 194, 411 );
            this.cell8_5.Name = "cell8_5";
            this.cell8_5.Size = new System.Drawing.Size( 36, 47 );
            this.cell8_5.TabIndex = 87;
            this.cell8_5.Text = "1 2 3 4 5 6 7 8 9";
            this.cell8_5.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell8_5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell8_4
            // 
            this.cell8_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell8_4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell8_4.Location = new System.Drawing.Point( 159, 411 );
            this.cell8_4.Name = "cell8_4";
            this.cell8_4.Size = new System.Drawing.Size( 36, 47 );
            this.cell8_4.TabIndex = 86;
            this.cell8_4.Text = "1 2 3 4 5 6 7 8 9";
            this.cell8_4.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell8_4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell8_3
            // 
            this.cell8_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell8_3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell8_3.Location = new System.Drawing.Point( 124, 411 );
            this.cell8_3.Name = "cell8_3";
            this.cell8_3.Size = new System.Drawing.Size( 36, 47 );
            this.cell8_3.TabIndex = 85;
            this.cell8_3.Text = "1 2 3 4 5 6 7 8 9";
            this.cell8_3.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell8_3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell8_2
            // 
            this.cell8_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell8_2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell8_2.Location = new System.Drawing.Point( 83, 411 );
            this.cell8_2.Name = "cell8_2";
            this.cell8_2.Size = new System.Drawing.Size( 36, 47 );
            this.cell8_2.TabIndex = 84;
            this.cell8_2.Text = "1 2 3 4 5 6 7 8 9";
            this.cell8_2.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell8_2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell8_1
            // 
            this.cell8_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell8_1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell8_1.Location = new System.Drawing.Point( 48, 411 );
            this.cell8_1.Name = "cell8_1";
            this.cell8_1.Size = new System.Drawing.Size( 36, 47 );
            this.cell8_1.TabIndex = 83;
            this.cell8_1.Text = "1 2 3 4 5 6 7 8 9";
            this.cell8_1.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell8_1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell8_0
            // 
            this.cell8_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell8_0.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell8_0.Location = new System.Drawing.Point( 13, 411 );
            this.cell8_0.Name = "cell8_0";
            this.cell8_0.Size = new System.Drawing.Size( 36, 47 );
            this.cell8_0.TabIndex = 82;
            this.cell8_0.Text = "1 2 3 4 5 6 7 8 9";
            this.cell8_0.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell8_0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell7_8
            // 
            this.cell7_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell7_8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell7_8.Location = new System.Drawing.Point( 305, 365 );
            this.cell7_8.Name = "cell7_8";
            this.cell7_8.Size = new System.Drawing.Size( 36, 47 );
            this.cell7_8.TabIndex = 81;
            this.cell7_8.Text = "1 2 3 4 5 6 7 8 9";
            this.cell7_8.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell7_8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell7_7
            // 
            this.cell7_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell7_7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell7_7.Location = new System.Drawing.Point( 270, 365 );
            this.cell7_7.Name = "cell7_7";
            this.cell7_7.Size = new System.Drawing.Size( 36, 47 );
            this.cell7_7.TabIndex = 80;
            this.cell7_7.Text = "1 2 3 4 5 6 7 8 9";
            this.cell7_7.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell7_7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell7_6
            // 
            this.cell7_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell7_6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell7_6.Location = new System.Drawing.Point( 235, 365 );
            this.cell7_6.Name = "cell7_6";
            this.cell7_6.Size = new System.Drawing.Size( 36, 47 );
            this.cell7_6.TabIndex = 79;
            this.cell7_6.Text = "1 2 3 4 5 6 7 8 9";
            this.cell7_6.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell7_6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell7_5
            // 
            this.cell7_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell7_5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell7_5.Location = new System.Drawing.Point( 194, 365 );
            this.cell7_5.Name = "cell7_5";
            this.cell7_5.Size = new System.Drawing.Size( 36, 47 );
            this.cell7_5.TabIndex = 78;
            this.cell7_5.Text = "1 2 3 4 5 6 7 8 9";
            this.cell7_5.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell7_5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell7_4
            // 
            this.cell7_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell7_4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell7_4.Location = new System.Drawing.Point( 159, 365 );
            this.cell7_4.Name = "cell7_4";
            this.cell7_4.Size = new System.Drawing.Size( 36, 47 );
            this.cell7_4.TabIndex = 77;
            this.cell7_4.Text = "1 2 3 4 5 6 7 8 9";
            this.cell7_4.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell7_4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell7_3
            // 
            this.cell7_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell7_3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell7_3.Location = new System.Drawing.Point( 124, 365 );
            this.cell7_3.Name = "cell7_3";
            this.cell7_3.Size = new System.Drawing.Size( 36, 47 );
            this.cell7_3.TabIndex = 76;
            this.cell7_3.Text = "1 2 3 4 5 6 7 8 9";
            this.cell7_3.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell7_3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell7_2
            // 
            this.cell7_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell7_2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell7_2.Location = new System.Drawing.Point( 83, 365 );
            this.cell7_2.Name = "cell7_2";
            this.cell7_2.Size = new System.Drawing.Size( 36, 47 );
            this.cell7_2.TabIndex = 75;
            this.cell7_2.Text = "1 2 3 4 5 6 7 8 9";
            this.cell7_2.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell7_2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell7_1
            // 
            this.cell7_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell7_1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell7_1.Location = new System.Drawing.Point( 48, 365 );
            this.cell7_1.Name = "cell7_1";
            this.cell7_1.Size = new System.Drawing.Size( 36, 47 );
            this.cell7_1.TabIndex = 74;
            this.cell7_1.Text = "1 2 3 4 5 6 7 8 9";
            this.cell7_1.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell7_1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell7_0
            // 
            this.cell7_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell7_0.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell7_0.Location = new System.Drawing.Point( 13, 365 );
            this.cell7_0.Name = "cell7_0";
            this.cell7_0.Size = new System.Drawing.Size( 36, 47 );
            this.cell7_0.TabIndex = 73;
            this.cell7_0.Text = "1 2 3 4 5 6 7 8 9";
            this.cell7_0.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell7_0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell6_8
            // 
            this.cell6_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell6_8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell6_8.Location = new System.Drawing.Point( 305, 319 );
            this.cell6_8.Name = "cell6_8";
            this.cell6_8.Size = new System.Drawing.Size( 36, 47 );
            this.cell6_8.TabIndex = 72;
            this.cell6_8.Text = "1 2 3 4 5 6 7 8 9";
            this.cell6_8.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell6_8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell6_7
            // 
            this.cell6_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell6_7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell6_7.Location = new System.Drawing.Point( 270, 319 );
            this.cell6_7.Name = "cell6_7";
            this.cell6_7.Size = new System.Drawing.Size( 36, 47 );
            this.cell6_7.TabIndex = 71;
            this.cell6_7.Text = "1 2 3 4 5 6 7 8 9";
            this.cell6_7.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell6_7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell6_6
            // 
            this.cell6_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell6_6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell6_6.Location = new System.Drawing.Point( 235, 319 );
            this.cell6_6.Name = "cell6_6";
            this.cell6_6.Size = new System.Drawing.Size( 36, 47 );
            this.cell6_6.TabIndex = 70;
            this.cell6_6.Text = "1 2 3 4 5 6 7 8 9";
            this.cell6_6.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell6_6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell6_5
            // 
            this.cell6_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell6_5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell6_5.Location = new System.Drawing.Point( 194, 319 );
            this.cell6_5.Name = "cell6_5";
            this.cell6_5.Size = new System.Drawing.Size( 36, 47 );
            this.cell6_5.TabIndex = 69;
            this.cell6_5.Text = "1 2 3 4 5 6 7 8 9";
            this.cell6_5.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell6_5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell6_4
            // 
            this.cell6_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell6_4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell6_4.Location = new System.Drawing.Point( 159, 319 );
            this.cell6_4.Name = "cell6_4";
            this.cell6_4.Size = new System.Drawing.Size( 36, 47 );
            this.cell6_4.TabIndex = 68;
            this.cell6_4.Text = "1 2 3 4 5 6 7 8 9";
            this.cell6_4.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell6_4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell6_3
            // 
            this.cell6_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell6_3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell6_3.Location = new System.Drawing.Point( 124, 319 );
            this.cell6_3.Name = "cell6_3";
            this.cell6_3.Size = new System.Drawing.Size( 36, 47 );
            this.cell6_3.TabIndex = 67;
            this.cell6_3.Text = "1 2 3 4 5 6 7 8 9";
            this.cell6_3.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell6_3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell6_2
            // 
            this.cell6_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell6_2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell6_2.Location = new System.Drawing.Point( 83, 319 );
            this.cell6_2.Name = "cell6_2";
            this.cell6_2.Size = new System.Drawing.Size( 36, 47 );
            this.cell6_2.TabIndex = 66;
            this.cell6_2.Text = "1 2 3 4 5 6 7 8 9";
            this.cell6_2.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell6_2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell6_1
            // 
            this.cell6_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell6_1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell6_1.Location = new System.Drawing.Point( 48, 319 );
            this.cell6_1.Name = "cell6_1";
            this.cell6_1.Size = new System.Drawing.Size( 36, 47 );
            this.cell6_1.TabIndex = 65;
            this.cell6_1.Text = "1 2 3 4 5 6 7 8 9";
            this.cell6_1.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell6_1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // cell6_0
            // 
            this.cell6_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cell6_0.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cell6_0.Location = new System.Drawing.Point( 13, 319 );
            this.cell6_0.Name = "cell6_0";
            this.cell6_0.Size = new System.Drawing.Size( 36, 47 );
            this.cell6_0.TabIndex = 64;
            this.cell6_0.Text = "1 2 3 4 5 6 7 8 9";
            this.cell6_0.MouseClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseClick );
            this.cell6_0.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.cell_MouseDoubleClick );
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.aboutSudokuToolStripMenuItem} );
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size( 40, 20 );
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSudokuToolStripMenuItem
            // 
            this.aboutSudokuToolStripMenuItem.Name = "aboutSudokuToolStripMenuItem";
            this.aboutSudokuToolStripMenuItem.Size = new System.Drawing.Size( 153, 22 );
            this.aboutSudokuToolStripMenuItem.Text = "About Sudoku...";
            this.aboutSudokuToolStripMenuItem.Click += new System.EventHandler( this.aboutSudokuToolStripMenuItem_Click );
            // 
            // SudokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 353, 507 );
            this.Controls.Add( this.cell8_8 );
            this.Controls.Add( this.cell8_7 );
            this.Controls.Add( this.cell8_6 );
            this.Controls.Add( this.cell8_5 );
            this.Controls.Add( this.cell8_4 );
            this.Controls.Add( this.cell8_3 );
            this.Controls.Add( this.cell8_2 );
            this.Controls.Add( this.cell8_1 );
            this.Controls.Add( this.cell8_0 );
            this.Controls.Add( this.cell7_8 );
            this.Controls.Add( this.cell7_7 );
            this.Controls.Add( this.cell7_6 );
            this.Controls.Add( this.cell7_5 );
            this.Controls.Add( this.cell7_4 );
            this.Controls.Add( this.cell7_3 );
            this.Controls.Add( this.cell7_2 );
            this.Controls.Add( this.cell7_1 );
            this.Controls.Add( this.cell7_0 );
            this.Controls.Add( this.cell6_8 );
            this.Controls.Add( this.cell6_7 );
            this.Controls.Add( this.cell6_6 );
            this.Controls.Add( this.cell6_5 );
            this.Controls.Add( this.cell6_4 );
            this.Controls.Add( this.cell6_3 );
            this.Controls.Add( this.cell6_2 );
            this.Controls.Add( this.cell6_1 );
            this.Controls.Add( this.cell6_0 );
            this.Controls.Add( this.cell5_8 );
            this.Controls.Add( this.cell5_7 );
            this.Controls.Add( this.cell5_6 );
            this.Controls.Add( this.cell5_5 );
            this.Controls.Add( this.cell5_4 );
            this.Controls.Add( this.cell5_3 );
            this.Controls.Add( this.cell5_2 );
            this.Controls.Add( this.cell5_1 );
            this.Controls.Add( this.cell5_0 );
            this.Controls.Add( this.cell4_8 );
            this.Controls.Add( this.cell4_7 );
            this.Controls.Add( this.cell4_6 );
            this.Controls.Add( this.cell4_5 );
            this.Controls.Add( this.cell4_4 );
            this.Controls.Add( this.cell4_3 );
            this.Controls.Add( this.cell4_2 );
            this.Controls.Add( this.cell4_1 );
            this.Controls.Add( this.cell4_0 );
            this.Controls.Add( this.cell3_8 );
            this.Controls.Add( this.cell3_7 );
            this.Controls.Add( this.cell3_6 );
            this.Controls.Add( this.cell3_5 );
            this.Controls.Add( this.cell3_4 );
            this.Controls.Add( this.cell3_3 );
            this.Controls.Add( this.cell3_2 );
            this.Controls.Add( this.cell3_1 );
            this.Controls.Add( this.cell3_0 );
            this.Controls.Add( this.cell2_8 );
            this.Controls.Add( this.cell2_7 );
            this.Controls.Add( this.cell2_6 );
            this.Controls.Add( this.cell2_5 );
            this.Controls.Add( this.cell2_4 );
            this.Controls.Add( this.cell2_3 );
            this.Controls.Add( this.cell2_2 );
            this.Controls.Add( this.cell2_1 );
            this.Controls.Add( this.cell2_0 );
            this.Controls.Add( this.cell1_8 );
            this.Controls.Add( this.cell1_7 );
            this.Controls.Add( this.cell1_6 );
            this.Controls.Add( this.cell1_5 );
            this.Controls.Add( this.cell1_4 );
            this.Controls.Add( this.cell1_3 );
            this.Controls.Add( this.cell1_2 );
            this.Controls.Add( this.cell1_1 );
            this.Controls.Add( this.cell1_0 );
            this.Controls.Add( this.cell0_8 );
            this.Controls.Add( this.cell0_7 );
            this.Controls.Add( this.cell0_6 );
            this.Controls.Add( this.cell0_5 );
            this.Controls.Add( this.cell0_4 );
            this.Controls.Add( this.cell0_3 );
            this.Controls.Add( this.cell0_2 );
            this.Controls.Add( this.cell0_1 );
            this.Controls.Add( this.cell0_0 );
            this.Controls.Add( this.radioButton9 );
            this.Controls.Add( this.radioButton8 );
            this.Controls.Add( this.radioButton7 );
            this.Controls.Add( this.radioButton6 );
            this.Controls.Add( this.radioButton5 );
            this.Controls.Add( this.radioButton4 );
            this.Controls.Add( this.radioButton3 );
            this.Controls.Add( this.radioButton2 );
            this.Controls.Add( this.radioButton1 );
            this.Controls.Add( this.menuStrip );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SudokuForm";
            this.Text = "Sudoku";
            this.menuStrip.ResumeLayout( false );
            this.menuStrip.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label cell0_0;
        private System.Windows.Forms.Label cell0_1;
        private System.Windows.Forms.Label cell0_2;
        private System.Windows.Forms.Label cell0_3;
        private System.Windows.Forms.Label cell0_4;
        private System.Windows.Forms.Label cell0_5;
        private System.Windows.Forms.Label cell0_6;
        private System.Windows.Forms.Label cell0_7;
        private System.Windows.Forms.Label cell0_8;
        private System.Windows.Forms.Label cell1_8;
        private System.Windows.Forms.Label cell1_7;
        private System.Windows.Forms.Label cell1_6;
        private System.Windows.Forms.Label cell1_5;
        private System.Windows.Forms.Label cell1_4;
        private System.Windows.Forms.Label cell1_3;
        private System.Windows.Forms.Label cell1_2;
        private System.Windows.Forms.Label cell1_1;
        private System.Windows.Forms.Label cell1_0;
        private System.Windows.Forms.Label cell2_8;
        private System.Windows.Forms.Label cell2_7;
        private System.Windows.Forms.Label cell2_6;
        private System.Windows.Forms.Label cell2_5;
        private System.Windows.Forms.Label cell2_4;
        private System.Windows.Forms.Label cell2_3;
        private System.Windows.Forms.Label cell2_2;
        private System.Windows.Forms.Label cell2_1;
        private System.Windows.Forms.Label cell2_0;
        private System.Windows.Forms.Label cell5_8;
        private System.Windows.Forms.Label cell5_7;
        private System.Windows.Forms.Label cell5_6;
        private System.Windows.Forms.Label cell5_5;
        private System.Windows.Forms.Label cell5_4;
        private System.Windows.Forms.Label cell5_3;
        private System.Windows.Forms.Label cell5_2;
        private System.Windows.Forms.Label cell5_1;
        private System.Windows.Forms.Label cell5_0;
        private System.Windows.Forms.Label cell4_8;
        private System.Windows.Forms.Label cell4_7;
        private System.Windows.Forms.Label cell4_6;
        private System.Windows.Forms.Label cell4_5;
        private System.Windows.Forms.Label cell4_4;
        private System.Windows.Forms.Label cell4_3;
        private System.Windows.Forms.Label cell4_2;
        private System.Windows.Forms.Label cell4_1;
        private System.Windows.Forms.Label cell4_0;
        private System.Windows.Forms.Label cell3_8;
        private System.Windows.Forms.Label cell3_7;
        private System.Windows.Forms.Label cell3_6;
        private System.Windows.Forms.Label cell3_5;
        private System.Windows.Forms.Label cell3_4;
        private System.Windows.Forms.Label cell3_3;
        private System.Windows.Forms.Label cell3_2;
        private System.Windows.Forms.Label cell3_1;
        private System.Windows.Forms.Label cell3_0;
        private System.Windows.Forms.Label cell8_8;
        private System.Windows.Forms.Label cell8_7;
        private System.Windows.Forms.Label cell8_6;
        private System.Windows.Forms.Label cell8_5;
        private System.Windows.Forms.Label cell8_4;
        private System.Windows.Forms.Label cell8_3;
        private System.Windows.Forms.Label cell8_2;
        private System.Windows.Forms.Label cell8_1;
        private System.Windows.Forms.Label cell8_0;
        private System.Windows.Forms.Label cell7_8;
        private System.Windows.Forms.Label cell7_7;
        private System.Windows.Forms.Label cell7_6;
        private System.Windows.Forms.Label cell7_5;
        private System.Windows.Forms.Label cell7_4;
        private System.Windows.Forms.Label cell7_3;
        private System.Windows.Forms.Label cell7_2;
        private System.Windows.Forms.Label cell7_1;
        private System.Windows.Forms.Label cell7_0;
        private System.Windows.Forms.Label cell6_8;
        private System.Windows.Forms.Label cell6_7;
        private System.Windows.Forms.Label cell6_6;
        private System.Windows.Forms.Label cell6_5;
        private System.Windows.Forms.Label cell6_4;
        private System.Windows.Forms.Label cell6_3;
        private System.Windows.Forms.Label cell6_2;
        private System.Windows.Forms.Label cell6_1;
        private System.Windows.Forms.Label cell6_0;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSudokuToolStripMenuItem;
    }
}

