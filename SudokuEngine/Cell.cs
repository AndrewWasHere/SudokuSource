//=============================================================================
// Cell.cs
// SudokuEngine cell
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
using System.Text;

namespace SudokuEngine
{
    /// <summary>
    /// One of the value holding cells that make up a board.
    /// 
    /// Valid entry values are [0, range], where
    ///    0 ==> Empty cell
    ///    [1, range] ==> cell value
    /// Hints is a helper object storing a player's guesses of the values of a cell.
    /// It is up to the interface to display the hints or not.
    /// </summary>
    public class Cell
    {
        //=====================================================================
        // Constructors
        public Cell( int rangeVal )
        {
            range = rangeVal;
            entry = 0;
            hints = new bool[ range ];
            locked = false;
        }

        //=====================================================================
        // Interfaces
        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }

        public int Entry
        {
            get { return entry; }
            set
            {
                if ( !locked )
                {
                    if ( value < 0 )
                        entry = 0;
                    else if ( value > range )
                        entry = range;
                    else
                        entry = value;
                }
            }
        }

        public bool[] Hints
        {
            get 
            {
                bool[] hintsCopy = new bool[ hints.Length ];
                for ( int idx = 0; idx < hints.Length; ++idx )
                {
                    hintsCopy[ idx ] = hints[ idx ];
                }
                return hintsCopy; 
            }
            set
            {
                if ( !locked )
                {
                    if ( value.Length == range )
                    {
                        for ( int idx = 0; idx < hints.Length; ++idx )
                        {
                            hints[ idx ] = value[ idx ];
                        }
                    }
                    else
                    {
                        throw new
                        ArgumentOutOfRangeException
                        (
                            "Hints dimension changed from " + range + 
                            " to " + value.Length
                        );
                    }
                }
            }
        }

        public void toggleHint( int symbolIndex )
        {
            if ( !locked )
            {
                hints[ symbolIndex ] = !hints[ symbolIndex ];
            }
        }

        public Cell deepCopy()
        {
            Cell copy = new Cell( this.range );
            copy.entry = entry;
            copy.locked = locked;
            copy.Hints = hints;

            return copy;
        }

        public static bool operator ==( Cell lhs, Cell rhs )
        {
            return lhs.entry == rhs.entry;
        }

        public static bool operator !=( Cell lhs, Cell rhs )
        {
            return lhs.entry != rhs.entry;
        }

        //=====================================================================
        // Override functions
        public override bool Equals( object obj )
        {
            if ( !( obj is Cell ) )
            {
                return false;
            }
            return this == ( Cell ) obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "entry: " + entry.ToString() + "; hints: " + hints.ToString();
        }

        //=====================================================================
        // Private parts
        private int range;
        private int entry;
        private bool[] hints;
        private bool locked;
    }
}
