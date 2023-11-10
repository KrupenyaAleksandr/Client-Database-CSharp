namespace Client_Database_dot_net_lab_11_
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlSportsman = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewSportsman = new System.Windows.Forms.ListView();
            this.columnSportsmanId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSportsmanFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSportsmanMiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSportsmanLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSportsmanSportClubId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripSportsman = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSelectSportsman = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInsertSportsman = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateSportsman = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteSportsman = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewSportClub = new System.Windows.Forms.ListView();
            this.columnSportClubId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSportClubTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSelectSportClub = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInsertSportClub = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateSportClub = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteSportClub = new System.Windows.Forms.ToolStripButton();
            this.tabControlSportsman.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStripSportsman.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSportsman
            // 
            this.tabControlSportsman.Controls.Add(this.tabPage1);
            this.tabControlSportsman.Controls.Add(this.tabPage2);
            this.tabControlSportsman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSportsman.Location = new System.Drawing.Point(0, 0);
            this.tabControlSportsman.Name = "tabControlSportsman";
            this.tabControlSportsman.SelectedIndex = 0;
            this.tabControlSportsman.Size = new System.Drawing.Size(499, 450);
            this.tabControlSportsman.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewSportsman);
            this.tabPage1.Controls.Add(this.toolStripSportsman);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Спортсмены";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewSportsman
            // 
            this.listViewSportsman.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSportsmanId,
            this.columnSportsmanFirstName,
            this.columnSportsmanMiddleName,
            this.columnSportsmanLastName,
            this.columnSportsmanSportClubId});
            this.listViewSportsman.FullRowSelect = true;
            this.listViewSportsman.GridLines = true;
            this.listViewSportsman.HideSelection = false;
            this.listViewSportsman.Location = new System.Drawing.Point(3, 28);
            this.listViewSportsman.Name = "listViewSportsman";
            this.listViewSportsman.Size = new System.Drawing.Size(486, 393);
            this.listViewSportsman.TabIndex = 0;
            this.listViewSportsman.UseCompatibleStateImageBehavior = false;
            this.listViewSportsman.View = System.Windows.Forms.View.Details;
            // 
            // columnSportsmanId
            // 
            this.columnSportsmanId.Text = "ID";
            this.columnSportsmanId.Width = 80;
            // 
            // columnSportsmanFirstName
            // 
            this.columnSportsmanFirstName.Text = "First name";
            this.columnSportsmanFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSportsmanFirstName.Width = 110;
            // 
            // columnSportsmanMiddleName
            // 
            this.columnSportsmanMiddleName.Text = "Middle name";
            this.columnSportsmanMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSportsmanMiddleName.Width = 110;
            // 
            // columnSportsmanLastName
            // 
            this.columnSportsmanLastName.Text = "Last name";
            this.columnSportsmanLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSportsmanLastName.Width = 110;
            // 
            // columnSportsmanSportClubId
            // 
            this.columnSportsmanSportClubId.Text = "Sport club id";
            this.columnSportsmanSportClubId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSportsmanSportClubId.Width = 76;
            // 
            // toolStripSportsman
            // 
            this.toolStripSportsman.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSelectSportsman,
            this.toolStripButtonInsertSportsman,
            this.toolStripButtonUpdateSportsman,
            this.toolStripButtonDeleteSportsman});
            this.toolStripSportsman.Location = new System.Drawing.Point(3, 3);
            this.toolStripSportsman.Name = "toolStripSportsman";
            this.toolStripSportsman.Size = new System.Drawing.Size(485, 25);
            this.toolStripSportsman.TabIndex = 0;
            this.toolStripSportsman.Text = "toolStrip1";
            // 
            // toolStripButtonSelectSportsman
            // 
            this.toolStripButtonSelectSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelectSportsman.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelectSportsman.Name = "toolStripButtonSelectSportsman";
            this.toolStripButtonSelectSportsman.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonSelectSportsman.Text = "Получить";
            this.toolStripButtonSelectSportsman.Click += new System.EventHandler(this.toolStripButtonSelectSportsman_Click);
            // 
            // toolStripButtonInsertSportsman
            // 
            this.toolStripButtonInsertSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInsertSportsman.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertSportsman.Name = "toolStripButtonInsertSportsman";
            this.toolStripButtonInsertSportsman.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonInsertSportsman.Text = "Добавить";
            this.toolStripButtonInsertSportsman.Click += new System.EventHandler(this.toolStripButtonInsertSportsman_Click);
            // 
            // toolStripButtonUpdateSportsman
            // 
            this.toolStripButtonUpdateSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdateSportsman.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateSportsman.Name = "toolStripButtonUpdateSportsman";
            this.toolStripButtonUpdateSportsman.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonUpdateSportsman.Text = "Обновить";
            this.toolStripButtonUpdateSportsman.Click += new System.EventHandler(this.toolStripButtonUpdateSportsman_Click);
            // 
            // toolStripButtonDeleteSportsman
            // 
            this.toolStripButtonDeleteSportsman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteSportsman.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteSportsman.Name = "toolStripButtonDeleteSportsman";
            this.toolStripButtonDeleteSportsman.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonDeleteSportsman.Text = "Удалить";
            this.toolStripButtonDeleteSportsman.Click += new System.EventHandler(this.toolStripButtonDeleteSportsman_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewSportClub);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спортивные клубы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewSportClub
            // 
            this.listViewSportClub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSportClubId,
            this.columnSportClubTitle});
            this.listViewSportClub.FullRowSelect = true;
            this.listViewSportClub.GridLines = true;
            this.listViewSportClub.HideSelection = false;
            this.listViewSportClub.Location = new System.Drawing.Point(3, 28);
            this.listViewSportClub.Name = "listViewSportClub";
            this.listViewSportClub.Size = new System.Drawing.Size(486, 393);
            this.listViewSportClub.TabIndex = 1;
            this.listViewSportClub.UseCompatibleStateImageBehavior = false;
            this.listViewSportClub.View = System.Windows.Forms.View.Details;
            // 
            // columnSportClubId
            // 
            this.columnSportClubId.Text = "ID";
            this.columnSportClubId.Width = 80;
            // 
            // columnSportClubTitle
            // 
            this.columnSportClubTitle.Text = "Title";
            this.columnSportClubTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSportClubTitle.Width = 124;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSelectSportClub,
            this.toolStripButtonInsertSportClub,
            this.toolStripButtonUpdateSportClub,
            this.toolStripButtonDeleteSportClub});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(485, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStripSportClub";
            // 
            // toolStripButtonSelectSportClub
            // 
            this.toolStripButtonSelectSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelectSportClub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelectSportClub.Name = "toolStripButtonSelectSportClub";
            this.toolStripButtonSelectSportClub.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonSelectSportClub.Text = "Загрузить";
            // 
            // toolStripButtonInsertSportClub
            // 
            this.toolStripButtonInsertSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInsertSportClub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertSportClub.Name = "toolStripButtonInsertSportClub";
            this.toolStripButtonInsertSportClub.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonInsertSportClub.Text = "Добавить";
            // 
            // toolStripButtonUpdateSportClub
            // 
            this.toolStripButtonUpdateSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdateSportClub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateSportClub.Name = "toolStripButtonUpdateSportClub";
            this.toolStripButtonUpdateSportClub.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonUpdateSportClub.Text = "Обновить";
            // 
            // toolStripButtonDeleteSportClub
            // 
            this.toolStripButtonDeleteSportClub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteSportClub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteSportClub.Name = "toolStripButtonDeleteSportClub";
            this.toolStripButtonDeleteSportClub.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonDeleteSportClub.Text = "Удалить";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.tabControlSportsman);
            this.Name = "FormMain";
            this.Text = "Main";
            this.tabControlSportsman.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStripSportsman.ResumeLayout(false);
            this.toolStripSportsman.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSportsman;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStripSportsman;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelectSportsman;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertSportsman;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateSportsman;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteSportsman;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewSportsman;
        private System.Windows.Forms.ColumnHeader columnSportsmanId;
        private System.Windows.Forms.ColumnHeader columnSportsmanFirstName;
        private System.Windows.Forms.ColumnHeader columnSportsmanMiddleName;
        private System.Windows.Forms.ColumnHeader columnSportsmanLastName;
        private System.Windows.Forms.ColumnHeader columnSportsmanSportClubId;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelectSportClub;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertSportClub;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateSportClub;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteSportClub;
        private System.Windows.Forms.ListView listViewSportClub;
        private System.Windows.Forms.ColumnHeader columnSportClubId;
        private System.Windows.Forms.ColumnHeader columnSportClubTitle;
    }
}

