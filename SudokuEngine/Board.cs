//=============================================================================
// Board.cs
// SudokuEngine board.
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

namespace SudokuEngine
{
    /// <summary>
    /// A game board.
    /// 
    /// Exceptions:
    /// ArgumentOutOfRangeException if its given hinkey board dimensions on construction.
    /// </summary>
    public class Board
    {
        //=====================================================================
        // Constructors

        public Board() : this( 9, 3, 3 )
        {
            // Nothing to do.
        }

        public Board( int boardDimensionsVar, int subRowsVar, int subColsVar )
        {
            // Validate passed in dimensions.
            if ( ( subRowsVar > boardDimensionsVar ) || ( subColsVar > boardDimensionsVar ) )
            {
                throw new ArgumentOutOfRangeException( "board sub-dimension greater than dimension." );
            }
            if ( ( boardDimensionsVar % subRowsVar != 0 ) || ( boardDimensionsVar % subColsVar != 0 ) )
            {
                throw new ArgumentOutOfRangeException( "board dimension not a multiple of a sub-dimension." );
            }

            // Store board dimensions.
            boardDimensions.row = boardDimensions.column = boardDimensionsVar;
            blockDimensions.row = subRowsVar;
            blockDimensions.column = subColsVar;

            // Create a new board.
            board = new SudokuEngine.Cell[ boardDimensions.row, boardDimensions.column ];
            initialize();
        }

        //=====================================================================
        // Interfaces

        /// <summary>
        /// Number of rows on the board.
        /// </summary>
        public int Rows
        {
            get { return boardDimensions.row; }
        }

        /// <summary>
        /// Number of columns on the board.
        /// </summary>
        public int Columns
        {
            get { return boardDimensions.column; }
        }

        /// <summary>
        /// Number of rows in a block.
        /// </summary>
        public int SubRows
        {
            get { return blockDimensions.row; }
        }

        /// <summary>
        /// Number of columns in a block.
        /// </summary>
        public int SubColumns
        {
            get { return blockDimensions.column; }
        }

        /// <summary>
        /// Access board cell by its spot on the board.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns>Cell at the specified coordinates.</returns>
        public Cell this[ int row, int col ]
        {
            get
            {
                return board[ row, col ];
            }
            set
            {
                board[ row, col ] = value;
            }
        }

        /// <summary>
        /// Public interface to generate a board that is uniquely solvable.
        /// </summary>
        public void generate()
        {
            // Erase the current board.
            initialize();
            // Solve the empty board to generate a puzzle solution.
            solve();
            // remove a random entry while the board remains uniquely solvable
            List<Coordinates> cells = getCells( CellType.NonEmpty );
            manipulate.randomShuffle( cells );
            foreach ( Coordinates cell in cells )
            {
                // Copy the current board.
                Board newBoard = deepCopy();

                // Remove a cell.
                newBoard[ cell.row, cell.column ].Entry = 0;

                int solutions = newBoard.solveBoard( 2 );
                if ( solutions == 1 )
                {
                    // Board is uniquely solvable.
                    board[ cell.row, cell.column ].Entry = 0;
                }
            }
        }

        /// <summary>
        /// Public interface requesting the board be solved from its current state.
        /// </summary>
        public void solve()
        {
            solveBoard( 1 );
        }

        /// <summary>
        /// This should probably be implemented as the IClonable interface.
        /// </summary>
        /// <returns> copy of board</returns>
        public Board deepCopy()
        {
            Board newBoard = new Board( boardDimensions.row, blockDimensions.row, blockDimensions.column );

            for ( int row = 0; row < boardDimensions.row; ++row )
            {
                for ( int col = 0; col < boardDimensions.column; ++col )
                {
                    newBoard.board[ row, col ] = board[ row, col ].deepCopy();
                }
            }

            return newBoard;
        }

        /// <summary>
        /// Comparator.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static bool operator ==( Board lhs, Board rhs )
        {
            for ( int row = 0; row < lhs.boardDimensions.row; ++row )
            {
                for ( int col = 0; col < lhs.boardDimensions.column; ++col )
                {
                    if ( lhs.board[ row, col ] != rhs.board[ row, col ] )
                    {
                        // Boards are not equivalent.
                        return false;
                    }
                }
            }

            // Boards are equivalent.
            return true;
        }

        /// <summary>
        /// Inverse comparator.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static bool operator !=( Board lhs, Board rhs )
        {
            return !( lhs == rhs );
        }

        //=====================================================================
        // Override functions

        public override bool Equals( object obj )
        {
            if ( obj is Board )
            {
                return this == ( Board ) obj; ;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string output = "";
            for ( int row = 0; row < boardDimensions.row; ++row )
            {
                if ( row % blockDimensions.row == 0 )
                {
                    output += "\n";
                }
                for ( int col = 0; col < boardDimensions.column; ++col )
                {
                    if ( col % blockDimensions.column == 0 )
                    {
                        output += " ";
                    }
                    output += board[ row, col ].Entry;
                }
                output += "\n";
            }
            return output;
        }

        //=====================================================================
        // Private parts

        /// <summary>
        /// Board coordinates.
        /// </summary>
        private struct Coordinates
        {
            public Coordinates( int rowVal, int colVal )
            {
                row = rowVal;
                column = colVal;
            }
            public override string ToString()
            {
                return "[ " + row + ", " + column + " ]";
            }

            public int row;
            public int column;
        }

        /// <summary>
        /// Zero out the board.
        /// </summary>
        private void initialize()
        {
            for ( int row = 0; row < boardDimensions.row; ++row )
            {
                for ( int col = 0; col < boardDimensions.column; ++col )
                {
                    board[ row, col ] = new Cell( boardDimensions.row );
                }
            }
        }

        /// <summary>
        /// Returns cells that match the requested cell type.
        /// </summary>
        /// <param name="celltype">Indicates to look for empty or non-empty cells</param>
        /// <returns>List of cell coordinates that match the cell type</returns>
        private List<Coordinates> getCells( CellType celltype )
        {
            List< Coordinates > cells = new List< Coordinates >();
            for ( int row = 0; row < boardDimensions.row; ++row )
            {
                for ( int col = 0; col < boardDimensions.column; ++col )
                {
                    if 
                    ( 
                        ( celltype == CellType.NonEmpty && board[ row, col ].Entry != 0 ) || 
                        ( celltype == CellType.Empty && board[ row, col ].Entry == 0 ) 
                    )
                    {
                        cells.Add( new Coordinates( row, col ) );
                    }
                }
            }
            return cells;
        }

        /// <summary>
        /// Attempt to solve the board in its current state, multiple times,
        /// if need be.
        /// </summary>
        /// <param name="maxSolutions">Maximum number of solutions to look for</param>
        /// <returns>Number of solutions to the current board that are found.</returns>
        private int solveBoard( int maxSolutions )
        {
            List<Coordinates> emptyCells = getCells( CellType.Empty );
            if ( emptyCells.Count == 0 )
                return 1;

            manipulate.randomShuffle( emptyCells );

            Debug.WriteLine( "Empty cells: " + emptyCells.Count );

            // Find all deterministic solutions.
            int lastEmptyCellCount = 0;
            while ( lastEmptyCellCount != emptyCells.Count )
            {
                lastEmptyCellCount = emptyCells.Count;

                if ( !completeRows( emptyCells ) ) return 0;
                if ( emptyCells.Count == 0 ) return 1;
                if ( !completeColumns( emptyCells ) ) return 0;
                if ( emptyCells.Count == 0 ) return 1;
                if ( !completeBlocks( emptyCells ) ) return 0;
                if ( emptyCells.Count == 0 ) return 1;
                if ( !solveUniqueSolutions( emptyCells ) ) return 0;
                if ( emptyCells.Count == 0 ) return 1;
            }

            // Try probabilistic solutions (ie. guess).
            // Determine possible solutions for each empty cell and randomly
            // choose one of the cells with the fewest number of solutions.
            Coordinates smallest = emptyCells[ 0 ];
            Dictionary<Coordinates, List<int>> solutionSets = new Dictionary<Coordinates, List<int>>();
            foreach ( Coordinates cell in emptyCells )
            {
                List<int> solutions = findSolutions( cell );
                solutionSets.Add( cell, solutions );
                if
                (
                    ( solutionSets[ cell ].Count < solutionSets[ smallest ].Count ) ||
                    (
                        ( solutionSets[ cell ].Count == solutionSets[ smallest ].Count ) &&
                        ( random.Next( 2 ) == 0 )
                    )
                )
                {
                    // New smallest.
                    smallest = cell;
                }
            }

            int solutionCount = 0;  // Solution counter

            // An empty solution set ==> board not solvable. Quit trying.
            if ( solutionSets[ smallest ].Count != 0 )
            {
                Board solvedBoard = deepCopy();

                // Try possible solutions in random order.
                List<int> solutions = solutionSets[ smallest ];
                manipulate.randomShuffle( solutions );
                foreach ( int solution in solutions )
                {
                    // Copy the current board.
                    Board newBoard = deepCopy();

                    // Fill in out guess.
                    Debug.WriteLine( "Guessing at [ " + smallest.row + ", " + smallest.column + " ]" );
                    newBoard[ smallest.row, smallest.column ].Entry = solution;

                    // Try to solve after the guess.
                    solutionCount += newBoard.solveBoard( maxSolutions );
                    if ( newBoard.getCells( CellType.Empty ).Count == 0 )
                    {
                        // Board has been solved.
                        solvedBoard = newBoard.deepCopy();
                    }
                    if ( solutionCount >= maxSolutions )
                    {
                        // Found all solutions we need.
                        break;
                    }
                }

                // Keep last solved board.
                board = solvedBoard.board;
            }

            return solutionCount;
        }

        /// <summary>
        /// Checks for rows with only one remaining empty cell and attempts
        /// to fill those in.
        /// </summary>
        /// <param name="emptyCells"></param>
        /// <returns>
        /// true - board solution valid so far.
        /// false - board solution is not valid.
        /// </returns>
        private bool completeRows( List<Coordinates> emptyCells )
        {
            for ( int row = 0; row < boardDimensions.row; ++row )
            {
                List<int> solutions = new List<int>();
                for ( int idx = 1; idx <= boardDimensions.row; ++idx )
                {
                    solutions.Add( idx );
                }
                for ( int col = 0; col < boardDimensions.column; ++col )
                {
                    if ( board[ row, col ].Entry != 0 )
                    {
                        solutions.Remove( board[ row, col ].Entry );
                    }
                }
                if ( solutions.Count == 1 )
                {
                    // Only one solution in this row.
                    for ( int idx = 0; idx < emptyCells.Count; ++idx )
                    {
                        if ( emptyCells[ idx ].row == row )
                        {
                            if ( isSolution( solutions[ 0 ], emptyCells[ idx ] ) )
                            {
                                Debug.WriteLine( "Completing row at [ " + emptyCells[ idx ].row + ", " + emptyCells[ idx ].column + " ]"  );

                                board[ emptyCells[ idx ].row, emptyCells[ idx ].column ].Entry = solutions[ 0 ];
                                emptyCells.RemoveAt( idx );
                                break;
                            }
                            else
                            {
                                // Invalid solution.
                                Debug.WriteLine( "Invalid Row Solution at [ " + emptyCells[ idx ].row + ", " + emptyCells[ idx ].column + " ]" );

                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Checks for columns with only one remaining empty cell and attempts
        /// to fill those in.
        /// </summary>
        /// <param name="emptyCells"></param>
        /// <returns>        
        /// true - board solution valid so far.
        /// false - board solution is not valid.
        /// </returns>
        private bool completeColumns( List<Coordinates> emptyCells )
        {
            for ( int col = 0; col < boardDimensions.column; ++col )
            {
                List<int> solutions = new List<int>();
                for ( int idx = 1; idx <= boardDimensions.row; ++idx )
                {
                    solutions.Add( idx );
                }
                for ( int row = 0; row < boardDimensions.row; ++row )
                {
                    if ( board[ row, col ].Entry != 0 )
                    {
                        solutions.Remove( board[ row, col ].Entry );
                    }
                }
                if ( solutions.Count == 1 )
                {
                    // Only one solution in this row.
                    for ( int idx = 0; idx < emptyCells.Count; ++idx )
                    {
                        if ( emptyCells[ idx ].column == col )
                        {
                            if ( isSolution( solutions[ 0 ], emptyCells[ idx ] ) )
                            {
                                Debug.WriteLine( "Completing column at [ " + emptyCells[ idx ].row + ", " + emptyCells[ idx ].column + " ]" );

                                board[ emptyCells[ idx ].row, emptyCells[ idx ].column ].Entry = solutions[ 0 ];
                                emptyCells.RemoveAt( idx );
                                break;
                            }
                            else
                            {
                                // Invalid solution.
                                Debug.WriteLine( "Invalid Column Solution at [ " +emptyCells[ idx ].row + ", " + emptyCells[ idx ].column + " ]" );

                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Checks for blocks with only one remaining empty cell and attempts
        /// to fill those in.
        /// </summary>
        /// <param name="emptyCells"></param>
        /// <returns>        
        /// true - board solution valid so far.
        /// false - board solution is not valid.
        /// </returns>
        private bool completeBlocks( List<Coordinates> emptyCells )
        {
            for ( int blockRow = 0; blockRow < ( boardDimensions.row / blockDimensions.row ); ++blockRow )
            {
                for ( int blockCol = 0; blockCol < ( boardDimensions.column / blockDimensions.column ); ++blockCol )
                {
                    List<int> solutions = new List<int>();
                    for ( int idx = 1; idx <= boardDimensions.row; ++idx )
                    {
                        solutions.Add( idx );
                    }

                    int rowStart = blockRow * blockDimensions.row;
                    int colStart = blockCol * blockDimensions.column;
                    for ( int row = rowStart; row < ( rowStart + blockDimensions.row ); ++row )
                    {
                        for ( int col = colStart; col < ( colStart + blockDimensions.column ); ++col )
                        {
                            if ( board[ row, col ].Entry != 0 )
                            {
                                solutions.Remove( board[ row, col ].Entry );
                            }
                        }
                    }
                    if ( solutions.Count == 1 )
                    {
                        // Only one solution in this block.
                        for ( int idx = 0; idx < emptyCells.Count; ++idx )
                        {
                            if 
                            (
                                ( emptyCells[ idx ].row >= rowStart ) && 
                                ( emptyCells[ idx ].row < rowStart + blockDimensions.row ) &&
                                ( emptyCells[ idx ].column >= colStart ) &&
                                ( emptyCells[ idx ].column < colStart + blockDimensions.column )
                            )
                            {
                                if ( isSolution( solutions[ 0 ], emptyCells[ idx ] ) )
                                {
                                    Debug.WriteLine( "Completing block at [ " + emptyCells[ idx ].row + ", " + emptyCells[ idx ].column + " ]" );

                                    board[ emptyCells[ idx ].row, emptyCells[ idx ].column ].Entry = solutions[ 0 ];
                                    emptyCells.RemoveAt( idx );
                                    break;
                                }
                                else
                                {
                                    // Invalid solution.
                                    Debug.WriteLine( "Invalid Block Solution at [ " + emptyCells[ idx ].row + ", " + emptyCells[ idx ].column + " ]" );

                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Looks for empty cells that have only one possible solution and fills
        /// them in.
        /// </summary>
        /// <param name="emptyCells"></param>
        /// <returns>        
        /// true - board solution valid so far.
        /// false - board solution is not valid.
        /// </returns>
        private bool solveUniqueSolutions( List<Coordinates> emptyCells )
        {
            // It's easier to iterate backwards through the list since the
            // list can lose members during the iteration.
            for ( int idx = emptyCells.Count - 1; idx >= 0; --idx )
            {
                List< int > solutions = findSolutions( emptyCells[ idx ] );
                if ( solutions.Count == 1 )
                {
                    // Unique solution.
                    Debug.WriteLine( "Unique Solution at [ " + emptyCells[ idx ].row + ", " + emptyCells[ idx ].column + " ]" );

                    board[ emptyCells[ idx ].row, emptyCells[ idx ].column ].Entry = solutions[ 0 ];
                    emptyCells.RemoveAt( idx );
                }
                if ( solutions.Count == 0 )
                {
                    // Invalid solution.
                    Debug.WriteLine( "Invalid Solution at [ " + emptyCells[ idx ].row + ", " + emptyCells[ idx ].column + " ]" );

                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Find all solutions of the cell at the specified coordinates.
        /// </summary>
        /// <param name="emptyCell">Cell coordinates to check.</param>
        /// <returns>List of valid solutions for the specified cell.</returns>
        private List<int> findSolutions( Coordinates emptyCell )
        {
            List<int> solutions = new List<int>();

            // Loop through possible solution symbols.
            for ( int solution = 1; solution <= boardDimensions.row; ++solution )
            {
                if ( isSolution( solution, emptyCell ) )
                {
                    // Solution is possible.
                    solutions.Add( solution );
                }
            }
            return solutions;
        }

        /// <summary>
        /// Check to see if the specified symbol is a valid solution to the
        /// specified cell.
        /// </summary>
        /// <param name="solution">Symbol to check.</param>
        /// <param name="emptyCell">Cell coordinates to check at.</param>
        /// <returns>
        /// true - solution is a possible solution for the specified cell.
        /// false - solution is not a possible solution for the specified cell.
        /// </returns>
        private bool isSolution( int solution, Coordinates emptyCell )
        {
            // Check row and column
            for ( int check = 0; check < boardDimensions.row; ++check )
            {
                // Column check
                if
                (
                    ( check != emptyCell.row ) &&
                    ( board[ check, emptyCell.column ].Entry == solution )
                )
                {
                    // Solution already exists in column.
                    return false;
                }

                // Row check
                if
                (
                    ( check != emptyCell.column ) &&
                    ( board[ emptyCell.row, check ].Entry == solution )
                )
                {
                    // Solution already exists in row.
                    return false;
                }
            }

            // Check block
            int rowStart = ( emptyCell.row / blockDimensions.row ) * blockDimensions.row;
            int colStart = ( emptyCell.column / blockDimensions.column ) * blockDimensions.column;
            for ( int row = rowStart; row < ( rowStart + blockDimensions.row ); ++row )
            {
                for ( int column = colStart; column < ( colStart + blockDimensions.column ); ++column )
                {
                    if
                    (
                        !( ( row == emptyCell.row ) && ( column == emptyCell.column ) ) &&
                        ( board[ row, column ].Entry == solution )
                    )
                    {
                        // Solution already exists in block.
                        return false;
                    }
                }
            }

            // Solution is possible.
            return true;
        }

        private Coordinates boardDimensions;
        private Coordinates blockDimensions;
        private Cell[ , ] board;

        private Manipulate.ListManipluator manipulate = new Manipulate.ListManipluator();
        private Random random = new Random();

        private enum CellType { Empty, NonEmpty };
    }
}
