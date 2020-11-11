using System;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this._CbProfession = new System.Windows.Forms.ComboBox();
            this._CbRace = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._txtStrength = new System.Windows.Forms.NumericUpDown();
            this._txtIntelligence = new System.Windows.Forms.NumericUpDown();
            this._txtAgility = new System.Windows.Forms.NumericUpDown();
            this._txtConstitution = new System.Windows.Forms.NumericUpDown();
            this._txtCharisma = new System.Windows.Forms.NumericUpDown();
            this._error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this._error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this._error3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._error3)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(121, 12);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(112, 23);
            this._txtName.TabIndex = 0;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-41, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-41, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-41, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Profession:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 20);
            // 
            // _CbProfession
            // 
            this._CbProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CbProfession.FormattingEnabled = true;
            this._CbProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this._CbProfession.Location = new System.Drawing.Point(120, 39);
            this._CbProfession.Name = "_CbProfession";
            this._CbProfession.Size = new System.Drawing.Size(112, 23);
            this._CbProfession.TabIndex = 8;
            this._CbProfession.SelectedIndexChanged += new System.EventHandler(this.comboProfession_SelectedIndexChanged);
            this._CbProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatedProfession);
            // 
            // _CbRace
            // 
            this._CbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CbRace.FormattingEnabled = true;
            this._CbRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this._CbRace.Location = new System.Drawing.Point(120, 68);
            this._CbRace.Name = "_CbRace";
            this._CbRace.Size = new System.Drawing.Size(112, 23);
            this._CbRace.TabIndex = 9;
            this._CbRace.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this._CbRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatedRace);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Race:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Strength:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Intelligence:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Agility:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Constitution:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Charisma:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(89, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Description";
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(118, 239);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(112, 70);
            this._txtDescription.TabIndex = 33;
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(121, 97);
            this._txtStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(112, 23);
            this._txtStrength.TabIndex = 34;
            this._txtStrength.Tag = "Strength";
            this._txtStrength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtIntelligence
            // 
            this._txtIntelligence.Location = new System.Drawing.Point(121, 126);
            this._txtIntelligence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtIntelligence.Name = "_txtIntelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(111, 23);
            this._txtIntelligence.TabIndex = 35;
            this._txtIntelligence.Tag = "Intellgence";
            this._txtIntelligence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(121, 152);
            this._txtAgility.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(109, 23);
            this._txtAgility.TabIndex = 36;
            this._txtAgility.Tag = "Agility";
            this._txtAgility.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(119, 181);
            this._txtConstitution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(112, 23);
            this._txtConstitution.TabIndex = 37;
            this._txtConstitution.Tag = "Constitution";
            this._txtConstitution.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(120, 210);
            this._txtCharisma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(110, 23);
            this._txtCharisma.TabIndex = 38;
            this._txtCharisma.Tag = "Charisma";
            this._txtCharisma.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _error1
            // 
            this._error1.ContainerControl = this;
            // 
            // _error2
            // 
            this._error2.ContainerControl = this;
            // 
            // _error3
            // 
            this._error3.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this._txtIntelligence);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._CbRace);
            this.Controls.Add(this._CbProfession);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._error3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCancel_Click ( object sender, EventArgs e )
        {
            Close();
        }
        
        private void OnSavebtn ( object sender, EventArgs e )
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

            // Validation
            //var error = character.Validate();
            //if (!String.IsNullOrEmpty(error))
            //{
            //    // Show error message
            //    MessageBox.Show(this, error, "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    DialogResult =DialogResult.None;
            //    Close();
            //    return;

            //   };
            //Return character
           // MessageBox.Show(character.Name);
            SelectedCharacter = character;
           // MessageBox.Show(Character.Name);
            Close();

        

        //var character = new Character();
        //character.Name = txtName.Text;
        //character.Profession =txtComboProfession.SelectedText;
        //character.Race = txtComboRace.SelectedText;
        //character.Strength = ReadAsInt32(txtStrength);
        //character.Intelligence = ReadAsInt32(txtIntelligence);
        //character.Agility = ReadAsInt32(txtAgility);
        //character.Constitution = ReadAsInt32(txtConstitution);
        //character.Charisma = ReadAsInt32(txtCharisma);

        // Validation
       // Return character
               //Close ();
        
            } 
             #endregion

        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ComboBox _CbProfession;
        private System.Windows.Forms.ComboBox _CbRace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox _textname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox _txtDescription;
        private NumericUpDown _txtStrength;
        private NumericUpDown _txtIntelligence;
        private NumericUpDown _txtAgility;
        private NumericUpDown _txtConstitution;
        private NumericUpDown _txtCharisma;
        private ErrorProvider _error1;
        private ErrorProvider _error2;
        private ErrorProvider _error3;
    }
}