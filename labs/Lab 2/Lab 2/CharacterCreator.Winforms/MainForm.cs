/*Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
using System.Windows.Forms;
namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
      {
        public MainForm ()
         {
            InitializeComponent();

            toolStripMenuItem11.Click += Exit;
            toolStripMenuItem15.Click += OnAboutFormAdd;
            toolStripMenuItem12.Click += OnCharacterNew;
            toolStripMenuItem13.Click += OnCharacterEdit;
            toolStripMenuItem14.Click += OnCharacterDelete;

            Character character;
            character = new Character();

            //member access operator
            character.Name = "Charisma";
            character.Description = "Role Playing Game";
        }
        private void OnCharacterNew ( object sender, EventArgs e )
        {
            var form = new CharacterForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            //Add the character
            _character = form.SelectedCharacter;
            RefreshRoster();

            }
        private void Exit ( object sender, EventArgs e )
        {
            Application.Exit();
         }
        private void Form1_Load ( object sender, EventArgs e )
        {

        }
        private void menuStrip1_ItemClicked ( object sender, ToolStripItemClickedEventArgs e )
        {

        }
        private void OnAboutFormAdd ( object sender, EventArgs e )
        {
            var form = new AboutForm();

            var result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
              }

        private void RefreshRoster ()
        {
            firstCharacter.DataSource = null;

            if (_character == null)
                return;

            var roster = new Character[1];
            roster[0] = _character;
            firstCharacter.DataSource = roster;
            firstCharacter.DisplayMember = nameof(Character.Name);
           }
        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

          if (MessageBox.Show(this, $"Are you sure you want to delete {character.Name}?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _character = null;
            RefreshRoster();
        }
        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var form = new CharacterForm();
            form.SelectedCharacter = character;

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _character = form.SelectedCharacter;
            RefreshRoster();
            MessageBox.Show("Save successful");
           }
        private Character GetSelectedCharacter ()
        {
            return _character;
        }

       private Character _character;
     }

 }
