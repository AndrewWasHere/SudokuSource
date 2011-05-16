//=============================================================================
// Program.cs
// SudokuEngine unit tests
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
using System.Diagnostics;
using System.Text;

namespace SudokuTest
{
    /// <summary>
    /// Unit tests for the Sudoku classes.
    /// </summary>
    class Program
    {
        static void Main( string[] args )
        {
            Debug.Listeners.Add( new TextWriterTraceListener( Console.Out ) );
            Debug.WriteLine( "Starting Sudoku Unit Test..." );
            Debug.Indent();
            TestCell();
            TestBoard();
            Debug.Unindent();

            Console.WriteLine( "End of Sudoku Unit Test. Press ENTER to continue." );
            Console.ReadLine();
        }

        //=====================================================================
        // Board Tests
        private static void TestBoard()
        {
            Debug.WriteLine( "Starting Board Tests..." );
            Debug.Indent();
            BoardTest1();
            BoardTest2();
            BoardTest3();
            BoardTest4();
            BoardTest5();
            BoardTest6();
            BoardTest7();
            Debug.Unindent();
        }

        private static void BoardTest1()
        {
            Debug.WriteLine( "Testing Construction and Initialization..." );

            SudokuEngine.Board board = new SudokuEngine.Board();
            Debug.Assert( board.Rows == 9, "FAILURE: member initialization" );
            Debug.Assert( board.Columns == 9, "FAILURE: member initialization" );
            Debug.Assert( board.SubRows == 3, "FAILURE: member initialization" );
            Debug.Assert( board.SubColumns == 3, "FAILURE: member initialization" );

            for ( int row = 0; row < board.Rows; ++row )
            {
                for ( int col = 0; col < board.Columns; ++col )
                {
                    // Exercise the cell at [ row, col ]. If it hasn't been
                    // initialized, an exception will be thrown.
                    try
                    {
                        board[ row, col ].Locked = true;
                    }
                    catch
                    {
                        Debug.Assert( false, "FAILURE: board initialization [ " + row + ", " + col + " ]" );
                    }
                }
            }
        }

        private static void BoardTest2()
        {
            // Constrution with bad values test.
            try
            {
                SudokuEngine.Board board = new SudokuEngine.Board( 1, 2, 2 );
            }
            catch ( ArgumentOutOfRangeException )
            {
                return;
            }
            catch
            {
                Debug.Assert( false, "FAILURE: sub-dimension > dimension unhandled exception" );
                return;
            }
            Debug.Assert( false, "FAILURE: sub-dimension > dimension not caught" );
        }

        private static void BoardTest3()
        {
            // Board dimensions not a multiple of block dimensions test.
            try
            {
                SudokuEngine.Board board = new SudokuEngine.Board( 9, 2, 2 );
            }
            catch ( ArgumentOutOfRangeException )
            {
                return;
            }
            catch
            {
                Debug.Assert( false, "FAILURE: dimension % sub-dimension unhandled exception" );
                return;
            }
            Debug.Assert( false, "FAILURE: dimension % sub-dimension not caught" );
        }

        private static void BoardTest4()
        {
            Debug.WriteLine( "Testing Accessors..." );

            int dim = 6;
            int subRows = 2;
            int subColumns = 2;
            SudokuEngine.Board board = new SudokuEngine.Board( dim, subRows, subColumns );

            Debug.Assert( board.Rows == dim, "FAILURE: Rows accessor" );
            Debug.Assert( board.Columns == dim, "FAILURE: Columns accessor" );
            Debug.Assert( board.SubRows == subRows, "FAILURE: SubRows accessor" );
            Debug.Assert( board.SubColumns == subColumns, "FAILURE: SubColumns accessor" );
        }

        private static void BoardTest5()
        {
            Debug.WriteLine( "Testing operators..." );

            SudokuEngine.Board board1 = new SudokuEngine.Board();
            SudokuEngine.Board board2 = new SudokuEngine.Board();

            Debug.Assert( board1 == board2, "FAILURE: operator ==" );
            Debug.Assert( !( board1 == board2 ) == ( board1 != board2 ), "FAILURE: operator ==" );
        }

        private static void BoardTest6()
        {
            Debug.WriteLine( "Testing solve interface..." );

            // There's no way to exhaustively test this interface in a repeatable
            // way since the SudokuEngine uses random number generation. The best
            // we can do is exercise the interface a statistically-relevant number 
            // of times and hope that any bugs show themselves in the sampling.
            for ( int i = 0; i < 100; ++i )
            {
                SudokuEngine.Board board = new SudokuEngine.Board();
                board.solve();
                Debug.WriteLine( board );
                verifyBoard( board );
            }
        }

        private static void BoardTest7()
        {
            Debug.WriteLine( "Testing generate interface..." );

            // There's no way to exhaustively test this interface in a repeatable
            // way since the SudokuEngine uses random number generation. The best
            // we can do is exercise the interface a statistically-relevant number 
            // of times and hope that any bugs show themselves in the sampling.
            for ( int i = 0; i < 10; ++i )
            {
                SudokuEngine.Board board = new SudokuEngine.Board();
                board.generate();
                Debug.WriteLine( "Generated board:" );
                Debug.WriteLine( board );
                board.solve();
                Debug.WriteLine( "Solved board:" );
                Debug.WriteLine( board );
                verifyBoard( board );
            }
        }

        private static void verifyBoard( SudokuEngine.Board board )
        {
            // Check rows and columns for duplicates
            for ( int idx1 = 0; idx1 < board.Rows; ++idx1 )
            {
                bool[] rowSymbols = new bool[ board.Rows ];
                bool[] colSymbols = new bool[ board.Columns ];
                for ( int idx2 = 0; idx2 < board.Columns; ++idx2 )
                {
                    // Check row for duplicates
                    int symbol = board[ idx1, idx2 ].Entry;
                    if ( rowSymbols[ symbol - 1 ] )
                    {
                        Debug.WriteLine( "FAILURE: symbol " + symbol + " occurs multiple times on row " + idx1 + " at " );
                        Debug.WriteLine( board );
                        Debug.Assert( false );
                    }
                    else
                    {
                        rowSymbols[ symbol - 1 ] = true;
                    }

                    // Check column for duplicates
                    symbol = board[ idx2, idx1 ].Entry;
                    if ( colSymbols[ symbol - 1 ] )
                    {
                        Debug.WriteLine( "FAILURE: symbol " + symbol + " occurs multiple times on column " + idx1 );
                        Debug.WriteLine( board );
                        Debug.Assert( false );
                    }
                    else
                    {
                        colSymbols[ symbol - 1 ] = true;
                    }
                }
            }

            // Check blocks for duplicates
            for ( int idx1 = 0; idx1 < ( board.Rows / board.SubRows ); ++idx1 )
            {
                for ( int idx2 = 0; idx2 < ( board.Columns / board.SubColumns ); ++idx2 )
                {
                    bool[] symbols = new bool[ board.Rows ];
                    for ( int row = ( idx1 * board.SubRows ); row < ( idx1 * board.SubRows ) + board.SubRows; ++row )
                    {
                        for ( int col = ( idx2 * board.SubColumns ); col < ( idx2 * board.SubColumns ) + board.SubColumns; ++col )
                        {
                            int symbol = board[ row, col ].Entry;
                            if ( symbols[ symbol - 1 ] )
                            {
                                Debug.WriteLine( "FAILURE: symbol " + symbol + " occurs multiple times in block[ " + idx1 + ", " + idx2 + " ]" );
                                Debug.WriteLine( board );
                                Debug.Assert( false );
                            }
                            else
                            {
                                symbols[ symbol - 1 ] = true;
                            }
                        }
                    }
                }
            }
        }

        //=====================================================================
        // Cell Tests
        private static void TestCell()
        {
            Debug.WriteLine( "Starting Cell Tests..." );
            Debug.Indent();
            CellTest1();
            CellTest2();
            CellTest3();
            Debug.Unindent();
        }

        private static void CellTest1()
        {
            Debug.WriteLine( "Testing Construction and Initialization..." );

            const int range = 9;
            SudokuEngine.Cell cell = new SudokuEngine.Cell( range );
            Debug.Assert( cell.Entry == 0, "FAILURE: member initialization" );
            Debug.Assert( !cell.Locked, "FAILURE: member initialization" );
            Debug.Assert( cell.Hints.Length == range, "FAILURE: member initialization" );

            foreach ( bool hint in cell.Hints )
            {
                Debug.Assert( !hint, "FAILURE: hint initialization" );
            }
        }

        private static void CellTest2()
        {
            Debug.WriteLine( "Testing Accessors..." );

            const int range = 9;

            // Locked accessors
            SudokuEngine.Cell cell = new SudokuEngine.Cell( range );
            bool locked = cell.Locked;
            cell.Locked = !locked;
            Debug.Assert( locked != cell.Locked, "FAILURE: Locked interface" );

            // Entry accessors
            cell.Locked = false;
            int entry = 1;        // entry must be in [1, range - 1] for test to be valid.
            cell.Entry = entry;   // Attempt to set in range
            Debug.Assert( cell.Entry == entry, "FAILURE: Entry interface" );

            cell.Entry = entry + range; // Attempt to set out of range.
            Debug.Assert( cell.Entry == range, "FAILURE: Entry interface" );

            cell.Locked = true;
            cell.Entry = entry + 1; // Attempt to set when locked.
            Debug.Assert( cell.Entry == range, "FAILURE: Entry interface" );

            // Hints accessors
            bool[] hints = { true, false, true, true, false, false, false, true, true };
            cell.Hints = hints; // Attempt to set when locked
            Debug.Assert( hints[ 0 ] != cell.Hints[ 0 ], "FAILURE: Hints interface" );

            cell.Locked = false;
            cell.Hints = hints;
            for ( int idx = 0; idx < range; ++idx )
            {
                Debug.Assert( hints[ idx ] == cell.Hints[ idx ], "FAILURE: Hints interface" );
            }

            bool[] shortHints = { false, false, true }; // MUST BE LAST TEST OF FUNCTION!
            try
            {
                cell.Hints = shortHints;
            }
            catch ( ArgumentOutOfRangeException )
            {
                return;
            }
            Debug.Assert( false, "FAILURE: Hints interface" );
        }

        private static void CellTest3()
        {
            Debug.WriteLine( "Testing Interfaces..." );

            const int range = 9;

            // toggleHint()
            SudokuEngine.Cell cell = new SudokuEngine.Cell( range );
            bool[] hints = cell.Hints;
            for ( int idx = 0; idx < range; ++idx )
            {
                cell.toggleHint( idx );
                hints[ idx ] = !hints[ idx ];

                for ( int chk = 0; chk < range; ++chk )
                {
                    Debug.Assert( hints[ chk ] == cell.Hints[ chk ], "FAILURE: toggleHints interface" );
                }
            }

            cell.Locked = true;
            for ( int idx = 0; idx < range; ++idx )
            {
                cell.toggleHint( idx );
                hints[ idx ] = !hints[ idx ];
                Debug.Assert( hints[ idx ] != cell.Hints[ idx ], "FAILURE: toggleHints interface" );
            }
        }
    }
}
