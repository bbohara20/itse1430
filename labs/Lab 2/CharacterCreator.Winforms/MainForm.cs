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
       // private int numCharacters;
       // private Character[] characters;
       
        public MainForm()
        {
            InitializeComponent();
            Character character;

            toolStripMenuItem11.Click += Exit;
            toolStripMenuItem15.Click += OnAboutFormAdd;
            toolStripMenuItem12.Click += OnCharacterFormAdd;
            //numCharacters = 0;
            //characters = new Character[100];


            //Character character;
            character = new Character();
           // character = new Character();
           //member access operator
            character.Name = "Charisma";
            character.description = "Role Playing Game";



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
        private void OnCharacterFormAdd ( object sender, EventArgs e )
        {
            var form = new CharacterForm();

            var result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;


        }
        private void OnCharacterCreate ( object sender, EventArgs e )
        {
            var form = new CharacterForm();

            // ShowDialog - modal ::= user must interact with child form, cannot access parent
             var result = form.ShowDialog(this);  
            if (result == DialogResult.Cancel)
                return;

            
            //TODO: Save Character
            MessageBox.Show("Save successful");
        }


    }
}
