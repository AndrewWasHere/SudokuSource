//=============================================================================
// Form1.cs
// Gameplay interface for the SudokuEngine.
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuForm : Form
    {
        private SudokuEngine.Board gameBoard;
        private SudokuEngine.Board solutionBoard;
        private int symbol;
        private int activeCellRow, activeCellColumn;
        private Label[ , ] cells;
        private Color activeColor;
        private Color inactiveColor;

        public SudokuForm()
        {
            InitializeComponent();

            gameBoard = new SudokuEngine.Board();
            symbol = 0;
            radioButton1.Checked = true;
            radioButton_CheckedChanged( radioButton1, new EventArgs() );

            // Organize the cells (labels) in a more useful way.
            // I probably wouldn't have to do this if I built the board
            // manually. Maybe next time.
            #region Cell Array Initialization
            cells = new Label[ 9, 9 ];
            cells[ 0, 0 ] = cell0_0;
            cells[ 0, 1 ] = cell0_1;
            cells[ 0, 2 ] = cell0_2;
            cells[ 0, 3 ] = cell0_3;
            cells[ 0, 4 ] = cell0_4;
            cells[ 0, 5 ] = cell0_5;
            cells[ 0, 6 ] = cell0_6;
            cells[ 0, 7 ] = cell0_7;
            cells[ 0, 8 ] = cell0_8;

            cells[ 1, 0 ] = cell1_0;
            cells[ 1, 1 ] = cell1_1;
            cells[ 1, 2 ] = cell1_2;
            cells[ 1, 3 ] = cell1_3;
            cells[ 1, 4 ] = cell1_4;
            cells[ 1, 5 ] = cell1_5;
            cells[ 1, 6 ] = cell1_6;
            cells[ 1, 7 ] = cell1_7;
            cells[ 1, 8 ] = cell1_8;

            cells[ 2, 0 ] = cell2_0;
            cells[ 2, 1 ] = cell2_1;
            cells[ 2, 2 ] = cell2_2;
            cells[ 2, 3 ] = cell2_3;
            cells[ 2, 4 ] = cell2_4;
            cells[ 2, 5 ] = cell2_5;
            cells[ 2, 6 ] = cell2_6;
            cells[ 2, 7 ] = cell2_7;
            cells[ 2, 8 ] = cell2_8;

            cells[ 3, 0 ] = cell3_0;
            cells[ 3, 1 ] = cell3_1;
            cells[ 3, 2 ] = cell3_2;
            cells[ 3, 3 ] = cell3_3;
            cells[ 3, 4 ] = cell3_4;
            cells[ 3, 5 ] = cell3_5;
            cells[ 3, 6 ] = cell3_6;
            cells[ 3, 7 ] = cell3_7;
            cells[ 3, 8 ] = cell3_8;

            cells[ 4, 0 ] = cell4_0;
            cells[ 4, 1 ] = cell4_1;
            cells[ 4, 2 ] = cell4_2;
            cells[ 4, 3 ] = cell4_3;
            cells[ 4, 4 ] = cell4_4;
            cells[ 4, 5 ] = cell4_5;
            cells[ 4, 6 ] = cell4_6;
            cells[ 4, 7 ] = cell4_7;
            cells[ 4, 8 ] = cell4_8;

            cells[ 5, 0 ] = cell5_0;
            cells[ 5, 1 ] = cell5_1;
            cells[ 5, 2 ] = cell5_2;
            cells[ 5, 3 ] = cell5_3;
            cells[ 5, 4 ] = cell5_4;
            cells[ 5, 5 ] = cell5_5;
            cells[ 5, 6 ] = cell5_6;
            cells[ 5, 7 ] = cell5_7;
            cells[ 5, 8 ] = cell5_8;

            cells[ 6, 0 ] = cell6_0;
            cells[ 6, 1 ] = cell6_1;
            cells[ 6, 2 ] = cell6_2;
            cells[ 6, 3 ] = cell6_3;
            cells[ 6, 4 ] = cell6_4;
            cells[ 6, 5 ] = cell6_5;
            cells[ 6, 6 ] = cell6_6;
            cells[ 6, 7 ] = cell6_7;
            cells[ 6, 8 ] = cell6_8;

            cells[ 7, 0 ] = cell7_0;
            cells[ 7, 1 ] = cell7_1;
            cells[ 7, 2 ] = cell7_2;
            cells[ 7, 3 ] = cell7_3;
            cells[ 7, 4 ] = cell7_4;
            cells[ 7, 5 ] = cell7_5;
            cells[ 7, 6 ] = cell7_6;
            cells[ 7, 7 ] = cell7_7;
            cells[ 7, 8 ] = cell7_8;

            cells[ 8, 0 ] = cell8_0;
            cells[ 8, 1 ] = cell8_1;
            cells[ 8, 2 ] = cell8_2;
            cells[ 8, 3 ] = cell8_3;
            cells[ 8, 4 ] = cell8_4;
            cells[ 8, 5 ] = cell8_5;
            cells[ 8, 6 ] = cell8_6;
            cells[ 8, 7 ] = cell8_7;
            cells[ 8, 8 ] = cell8_8;
            #endregion

            activeCellRow = activeCellColumn = 0;
            activeColor = Color.LightGray;
            inactiveColor = cells[ activeCellRow, activeCellColumn ].BackColor;
            cells[ activeCellRow, activeCellColumn ].BackColor = activeColor;

            // Generate a new game right off the bat.
            newToolStripMenuItem_Click( newToolStripMenuItem, new EventArgs() );
        }

        /// <summary>
        /// Quit the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }

        /// <summary>
        /// Make a new board.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Cursor = Cursors.WaitCursor;

            // Gneerate a new board.
            gameBoard.generate();
            solutionBoard = gameBoard.deepCopy();
            solutionBoard.solve();

            // Display the new board.
            for ( int row = 0; row < gameBoard.Rows; ++row )
            {
                for ( int col = 0; col < gameBoard.Columns; ++col )
                {
                    if ( gameBoard[ row, col ].Entry != 0 )
                        gameBoard[ row, col ].Locked = true;
                    else
                        gameBoard[ row, col ].Locked = false;

                    updateCellDisplay( row, col );
                }
            }

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Show the solved board for the current puzzle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solveToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Cursor = Cursors.WaitCursor;

            // Copy the solution.
            gameBoard = solutionBoard.deepCopy();

            // Display the solution.
            for ( int row = 0; row < gameBoard.Rows; ++row )
            {
                for ( int col = 0; col < gameBoard.Columns; ++col )
                {
                    updateCellDisplay( row, col );
                }
            }
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// About...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutSudokuToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Form about = new AboutBox();
            about.ShowDialog();
        }

        /// <summary>
        /// Intercept all key presses in the game.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            const int WM_KEYDOWN = 0x100;
            const int WM_SYSKEYDOWN = 0x104;

            if ( ( msg.Msg == WM_KEYDOWN ) || ( msg.Msg == WM_SYSKEYDOWN ) )
            {
                switch ( keyData )
                {
                    case Keys.Down:
                    case Keys.Control | Keys.Down:
                        cell_MouseClick( cells[ ( activeCellRow + 1 ) % gameBoard.Rows, activeCellColumn ], new MouseEventArgs( MouseButtons.None, 1, 0, 0, 0 ) );
                        break;
                    case Keys.Up:
                    case Keys.Control | Keys.Up:
                        cell_MouseClick( cells[ ( activeCellRow + gameBoard.Rows - 1 ) % gameBoard.Rows, activeCellColumn ], new MouseEventArgs( MouseButtons.None, 1, 0, 0, 0 ) );
                        break;
                    case Keys.Left:
                    case Keys.Control | Keys.Left:
                        cell_MouseClick( cells[ activeCellRow, ( activeCellColumn + gameBoard.Columns - 1 ) % gameBoard.Columns ], new MouseEventArgs( MouseButtons.None, 1, 0, 0, 0 ) );
                        break;
                    case Keys.Right:
                    case Keys.Control | Keys.Right:
                        cell_MouseClick( cells[ activeCellRow, ( activeCellColumn + 1 ) % gameBoard.Columns ], new MouseEventArgs( MouseButtons.None, 1, 0, 0, 0 ) );
                        break;
                    case Keys.D1:
                        radioButton1.Checked = true;
                        radioButton_CheckedChanged( radioButton1, new EventArgs() );
                        break;
                    case Keys.D2:
                        radioButton2.Checked = true;
                        radioButton_CheckedChanged( radioButton2, new EventArgs() );
                        break;
                    case Keys.D3:
                        radioButton3.Checked = true;
                        radioButton_CheckedChanged( radioButton3, new EventArgs() );
                        break;
                    case Keys.D4:
                        radioButton4.Checked = true;
                        radioButton_CheckedChanged( radioButton4, new EventArgs() );
                        break;
                    case Keys.D5:
                        radioButton5.Checked = true;
                        radioButton_CheckedChanged( radioButton5, new EventArgs() );
                        break;
                    case Keys.D6:
                        radioButton6.Checked = true;
                        radioButton_CheckedChanged( radioButton6, new EventArgs() );
                        break;
                    case Keys.D7:
                        radioButton7.Checked = true;
                        radioButton_CheckedChanged( radioButton7, new EventArgs() );
                        break;
                    case Keys.D8:
                        radioButton8.Checked = true;
                        radioButton_CheckedChanged( radioButton8, new EventArgs() );
                        break;
                    case Keys.D9:
                        radioButton9.Checked = true;
                        radioButton_CheckedChanged( radioButton9, new EventArgs() );
                        break;
                    case Keys.Space:
                        ToggleCellEntry();
                        break;
                    case Keys.Control | Keys.Space:
                        ToggleCellHint();
                        break;
                    case Keys.Back:
                    case Keys.Delete:
                        if ( !gameBoard[ activeCellRow, activeCellColumn ].Locked )
                        {
                            gameBoard[ activeCellRow, activeCellColumn ].Entry = 0;
                            updateCellDisplay( activeCellRow, activeCellColumn );
                        }
                        break;
                    default:
                        // Keypress is something we don't care about. Pass it along.
                        return base.ProcessCmdKey( ref msg, keyData );
                }
  
                // Finished processing.
                return true;
            }

            // Keypress is something we don't care about. Pass it along.
            return base.ProcessCmdKey( ref msg, keyData );
        }

        /// <summary>
        /// Toggle the active cell's hint for the currently selected symbol.
        /// </summary>
        private void ToggleCellHint()
        {
            SudokuEngine.Cell gameCell = gameBoard[ activeCellRow, activeCellColumn ];
            if ( ( !gameCell.Locked ) && ( gameCell.Entry == 0 ) )
            {
                gameCell.toggleHint( symbol - 1 );
                updateCellDisplay( activeCellRow, activeCellColumn );
            }
        }

        /// <summary>
        /// Toggle the active cell's entry for the currently selected symbol.
        /// </summary>
        private void ToggleCellEntry()
        {
            SudokuEngine.Cell gameCell = gameBoard[ activeCellRow, activeCellColumn ];
            if ( !gameCell.Locked )
            {
                gameCell.Entry = ( symbol == gameCell.Entry ) ? 0 : symbol;
                updateCellDisplay( activeCellRow, activeCellColumn );
            }
        }

        /// <summary>
        /// Refresh the indicated cell.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private void updateCellDisplay( int row, int col )
        {
            SudokuEngine.Cell gameCell = gameBoard[ row, col ];
            Label displayCell = cells[ row, col ];
            displayCell.ForeColor = Color.Black;
            if ( gameCell.Entry == 0 )
            {
                // Display hints
                string hintStr = "";
                for ( int idx = 0; idx < gameBoard.Rows; ++idx )
                {
                    if ( gameCell.Hints[ idx ] )
                    {
                        if ( hintStr.Length > 0 ) hintStr += " ";
                        hintStr += idx + 1;
                    }
                    displayCell.Font = new Font( "Microsoft Sans Serif", 9F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
                    displayCell.Text = hintStr;
                }
            }
            else
            {
                // Display entry
                displayCell.Font = new Font( "Microsoft Sans Serif", 24F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
                displayCell.Text = gameCell.Entry.ToString();
            }

            if ( gameFinished() )
            {
                gradeBoard();
            }
        }

        /// <summary>
        /// Check the finished board against the solution. If the board matches
        /// the solution, board entries turn blue.
        /// </summary>
        private void gradeBoard()
        {
            bool allCorrect = true;
            for ( int row = 0; row < gameBoard.Rows; ++row )
            {
                for ( int col = 0; col < gameBoard.Columns; ++col )
                {
                    if ( gameBoard[ row, col ].Entry != solutionBoard[ row, col ].Entry )
                    {
                        // Entry is incorrect.
                        cells[ row, col ].ForeColor = Color.Red;
                        allCorrect = false;
                    }
                }
            }
            if ( allCorrect )
            {
                for ( int row = 0; row < gameBoard.Rows; ++row )
                {
                    for ( int col = 0; col < gameBoard.Columns; ++col )
                    {
                        cells[ row, col ].ForeColor = Color.Blue;
                    }
                }
            }
        }

        /// <summary>
        /// Determine if the game has been finished. That is, all cells have
        /// an entry.
        /// </summary>
        /// <returns>
        /// true - game is finished.
        /// false - game is not finished.
        /// </returns>
        private bool gameFinished()
        {
            for ( int row = 0; row < gameBoard.Rows; ++row )
            {
                for ( int col = 0; col < gameBoard.Columns; ++col )
                {
                    if ( gameBoard[ row, col ].Entry == 0 )
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Radio button state change handler for all radio buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged( object sender, EventArgs e )
        {
            if ( sender is RadioButton )
            {
                RadioButton button = ( RadioButton ) sender;
                if ( button.Checked )
                {
                    symbol = Convert.ToInt32( button.Text );
                }
            }
        }

        /// <summary>
        /// Mouse click handler for all cells (labels) on the game board.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cell_MouseClick( object sender, MouseEventArgs e )
        {
            if ( sender is Label )
            {
                // Indicate current active cell is no longer active.
                cells[ activeCellRow, activeCellColumn ].BackColor = inactiveColor;

                // Figure out cell coordinates for new active cell.
                Label cell = ( Label ) sender;
                string[] coordinates = Regex.Split( cell.Name, "^cell|_" );
                activeCellRow = Convert.ToInt32( coordinates[ 1 ] );
                activeCellColumn = Convert.ToInt32( coordinates[ 2 ] );

                // Indicate new active cell is active.
                cells[ activeCellRow, activeCellColumn ].BackColor = activeColor;

                if ( e.Button == MouseButtons.Right )
                {
                    ToggleCellHint();
                }
            }
        }

        /// <summary>
        /// Mouse double click handler for all cells (labels) on the game board.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cell_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            if ( sender is Label )
            {
                ToggleCellEntry();
            }
        }
    }
}