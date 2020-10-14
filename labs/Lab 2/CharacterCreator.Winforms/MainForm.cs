using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.Design;
//using System.Data;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        
       
        public MainForm()
        {
            InitializeComponent();
           
            toolStripMenuItem11.Click += Exit;
            toolStripMenuItem15.Click += OnAboutFormAdd;

            Character character;
            character = new Character();
           //member access operator
            character.Name = "Charisma";
        }
        private void Exit( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void Form1_Load ( object sender, EventArgs e )
        {
            

        }

        private void menuStrip1_ItemClicked ( object sender, ToolStripItemClickedEventArgs e )
        {

         }
        private void OnAboutFormAdd (object sender, EventArgs e )
        {
            var form = new AboutForm();

             var result = form.ShowDialog(this);  
            if (result == DialogResult.Cancel)
                return;

            
        }

        private void checkBox1_CheckedChanged ( object sender, EventArgs e )
        {

        }
    }
}
