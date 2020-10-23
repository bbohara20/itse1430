using System;

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

            toolStripMenuItem11.Click += Exit;
            toolStripMenuItem15.Click += OnAboutFormAdd;
            toolStripMenuItem12.Click += OnCharacterAdd;
           
          Character character;
            character = new Character();
           // character = new Character();
           //member access operator
            character.Name = "Charisma";
            character.description = "Role Playing Game";
           }
        private void OnCharacterAdd ( object sender, EventArgs e )
        {
            var form = new CharacterForm();

            // ShowDialog - modal ::= user must interact with child form, cannot access parent
            var result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            
            //AddCharacter(form.Character);
             _character = form.Character;
           // MessageBox.Show(_character.Name);
            MessageBox.Show("Save successful");

           }
    
          private Character _character;
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
            

    }
}
