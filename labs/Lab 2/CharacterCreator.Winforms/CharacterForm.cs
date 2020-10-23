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

        
        public virtual Character Character { get; set; }
       
          private void onCancel ( object sender, EventArgs e )
            {
                Close();
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

            private void textBox2_TextChanged ( object sender, EventArgs e )
            {

            }

            private void comboBox2_SelectedIndexChanged ( object sender, EventArgs e )
            {

            }

            private void textBox3_TextChanged ( object sender, EventArgs e )
            {

            }

            private void textBox5_TextChanged ( object sender, EventArgs e )
            {

            }

            private void comboProfession_SelectedIndexChanged ( object sender, EventArgs e )
            {

            }

            private void listBox1_SelectedIndexChanged ( object sender, EventArgs e )
            {

            }

            private void listBox5_SelectedIndexChanged ( object sender, EventArgs e )
            {

            }

            private void OnSave ( object sender, EventArgs e )
            {
                var character = new Character();
                character.Name = txtName.Text;
                character.Profession =txtComboProfession.SelectedText;
                character.Race = txtComboRace.SelectedText;
                character.Strength = ReadAsInt32(txtStrength);
                character.Intelligence = ReadAsInt32(txtIntelligence);
                character.Agility = ReadAsInt32(txtAgility);
                character.Constitution = ReadAsInt32(txtConstitution);
                character.Charisma = ReadAsInt32(txtCharisma);

                // Validation
                var error = character.Validate();
                if (!String.IsNullOrEmpty(error))
                {
                    // Show error message
                    MessageBox.Show(this, error, "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult =DialogResult.None;
                    Close();
                    return;

                };
                //Return character
                Character = character;
                Close();

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

        }
    }
