/*
 *Name: Bam Bohara
 *Course: ITSE 1430
 *Lab: Character Creator
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
            character.Profession =_CbProfession.Text;
            character.Race = _CbRace.Text;
            character.Strength = ReadAsInt32(_txtStrength);
            character.Intelligence = ReadAsInt32(_txtIntelligence);
            character.Agility = ReadAsInt32(_txtAgility);
            character.Constitution = ReadAsInt32(_txtConstitution);
            character.Charisma = ReadAsInt32(_txtCharisma);
            SelectedCharacter = character;
           
            Close();

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
            _txtDescription.Text =character.Description;

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
 
        
        private void OnValidateName ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as TextBox;

            //Name is required
            if (String.IsNullOrEmpty(control.Text))
            {
                //Set error using ErrorProvider
                _error1.SetError(control, "Name is required"); // error message shown on mouse over
                e.Cancel = true;  //Not validate
            } else
            {
                //Clear error from provider
                _error1.SetError(control, "");
            }
        }

        private void OnValidatedProfession ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as ComboBox;

            //Profession is required
            if (String.IsNullOrEmpty(control.Text))
            {
                //Set error using ErrorProvider
                _error2.SetError(control, "Profession is required"); // error message shown on mouse over
                e.Cancel = true;  //Not validate
            } else
            {
                //Clear error from provider
                _error2.SetError(control, "");
            }

        }

        //private void OnValidateRace ( object sender, System.ComponentModel.CancelEventArgs e )
        //{
        //    var control = sender as ComboBox;

        //    //Name is required
        //    if (String.IsNullOrEmpty(control.Text))
        //    {
        //        //Set error using ErrorProvider
        //        _error3.SetError(control, "Race is required");
        //        e.Cancel = true;  //Not validate
        //    } else
        //    {
        //        //Clear error from provider
        //        _error3.SetError(control, "");
        //    }

        //}

        private void OnValidatedRace ( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var control = sender as ComboBox;

            //Name is required
            if (String.IsNullOrEmpty(control.Text))
            {
                //Set error using ErrorProvider
                _error3.SetError(control, "Race is required"); // error message shown on mouse over
                e.Cancel = true;  //Not validate
            } else
            {
                //Clear error from provider
                _error3.SetError(control, "");
            }

        }
    }
}
