/*
 *Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
using System.Windows.Forms;
namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm ()
        {
            InitializeComponent();
        }
        public virtual Character SelectedCharacter { get; set; }
        protected override void OnLoad ( EventArgs e )
        {
            //Load the UI
            LoadUI();
        }

        private void menuStrip1_ItemClicked ( object sender, ToolStripItemClickedEventArgs e )
        {

        }
        private void CharacterForm_Load ( object sender, EventArgs e )
        {

        }
        private void label5_Click ( object sender, EventArgs e )
        {

        }

        private void label7_Click ( object sender, EventArgs e )
        {

        }

        private void label11_Click ( object sender, EventArgs e )
        {

        }

        private void label12_Click ( object sender, EventArgs e )
        {

        }

        private void comboBox2_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void comboProfession_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }
        private void OnSave ( object sender, EventArgs e )
        {
            var character = new Character();
            character.Name = _txtName.Text;
            character.Profession = _CbProfession.Text;
            character.Race = _CbRace.Text;
            character.Strength = (int)_txtStrength.Value;
            character.Intelligence = (int)_txtIntelligence.Value;
            character.Agility = (int)_txtAgility.Value;
            character.Constitution = (int)_txtConstitution.Value;
            character.Charisma = (int)_txtCharisma.Value;
            _txtDescription.Text = (string)_txtDescription.Text;
            // character.Description = _txtDescription.Text;


            // Validation
            var error = character.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                // Show error message
                MessageBox.Show(this, error, "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
              }

            {
                
              SelectedCharacter = character;
                Close();
            }
            }

         private void LoadUI ()
         {

            if (SelectedCharacter != null)
            {
                Text = "Edit Character";
                LoadCharacter(SelectedCharacter);
            };
        }
        private void LoadCharacter ( Character character )
        {
            //base.onLoad(e);
            _txtName.Text = character.Name;
            _CbProfession.Text = character.Profession;
            _CbRace.Text = character.Race;
            _txtDescription.Text = _txtDescription.Text;

            _txtStrength.Value = character.Strength;
            _txtIntelligence.Value = character.Intelligence;
            _txtAgility.Value = character.Agility;
            _txtConstitution.Value = character.Constitution;
            _txtCharisma.Value = character.Charisma;
              }


        private int ReadAsInt32 ( Control control )
        {
            var text = control.Text;
            if (Int32.TryParse(text, out var result))
                return result;
            return -1;
        }

        private void btnCance1_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }
    }
}
