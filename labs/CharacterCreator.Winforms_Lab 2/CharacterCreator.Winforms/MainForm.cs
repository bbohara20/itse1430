using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
     public partial class MainForm : Form
     {
      public MainForm ()
        {
           InitializeComponent();

            toolStripMenuItem2.Click += Exit;
            toolStripMenuItem6.Click += OnAboutFormAdd;
           


        }
        private void Exit ( object sender, EventArgs e )
         {
            Application.Exit();
           }  
         private void menuStrip1_ItemClicked_1 ( object sender, ToolStripItemClickedEventArgs e )
          {

          }
         private void OnAboutFormAdd ( object sender, EventArgs e )
        {
            var form = new AboutForm();

            var result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;


        }

    }
}
