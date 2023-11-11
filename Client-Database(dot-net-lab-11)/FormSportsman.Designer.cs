namespace Client_Database_dot_net_lab_11_
{
    partial class FormSportsman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxSportClubId = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(71, 26);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(71, 74);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddleName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(71, 125);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxSportClubId
            // 
            this.textBoxSportClubId.Location = new System.Drawing.Point(71, 182);
            this.textBoxSportClubId.Name = "textBoxSportClubId";
            this.textBoxSportClubId.Size = new System.Drawing.Size(100, 20);
            this.textBoxSportClubId.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(159, 294);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "button1";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialogImage";
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Location = new System.Drawing.Point(82, 233);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPhoto.TabIndex = 5;
            this.buttonAddPhoto.Text = "Photo";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // FormSportsman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddPhoto);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSportClubId);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormSportsman";
            this.Text = "FormSportsman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxSportClubId;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonAddPhoto;
    }
}