using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            labelURL.Links.Add( 0, labelURL.Text.Length, "www.dragoncoil.com" );
        }

        private void buttonOK_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void URL_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            // Determine which link was clicked within the LinkLabel.
            labelURL.Links[ labelURL.Links.IndexOf( e.Link ) ].Visited = true;

            // Display the appropriate link based on the value of the 
            // LinkData property of the Link object.
            string target = e.Link.LinkData as string;

            // If the value looks like a URL, navigate to it.
            // Otherwise, display it in a message box.
            if ( target != null )
            {
                System.Diagnostics.Process.Start( target );
            }
            else
            {
                MessageBox.Show( "Item clicked: " + target );
            }
        }
    }
}