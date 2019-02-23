namespace ADO.NET_HW2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trainingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromRussianToEnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromEnglishToRussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAdvertisingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelWord = new System.Windows.Forms.Label();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.labelInputWord = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonShowPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerWrongAnswer = new System.Windows.Forms.Timer(this.components);
            this.panelTraining = new System.Windows.Forms.Panel();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTraining.SuspendLayout();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 28);
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.trainingToolStripMenuItem.Text = "Training";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trainingToolStripMenuItem1
            // 
            this.trainingToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainingToolStripMenuItem1.Name = "trainingToolStripMenuItem1";
            this.trainingToolStripMenuItem1.Size = new System.Drawing.Size(92, 29);
            this.trainingToolStripMenuItem1.Text = "Training";
            this.trainingToolStripMenuItem1.Click += new System.EventHandler(this.trainingToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromRussianToEnglishToolStripMenuItem,
            this.fromEnglishToRussianToolStripMenuItem,
            this.aboutAdvertisingToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fromRussianToEnglishToolStripMenuItem
            // 
            this.fromRussianToEnglishToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromRussianToEnglishToolStripMenuItem.Name = "fromRussianToEnglishToolStripMenuItem";
            this.fromRussianToEnglishToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.fromRussianToEnglishToolStripMenuItem.Text = "From Russian to English";
            this.fromRussianToEnglishToolStripMenuItem.Click += new System.EventHandler(this.fromRussianToEnglishToolStripMenuItem_Click);
            // 
            // fromEnglishToRussianToolStripMenuItem
            // 
            this.fromEnglishToRussianToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromEnglishToRussianToolStripMenuItem.Name = "fromEnglishToRussianToolStripMenuItem";
            this.fromEnglishToRussianToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.fromEnglishToRussianToolStripMenuItem.Text = "From English to Russian";
            this.fromEnglishToRussianToolStripMenuItem.Click += new System.EventHandler(this.fromEnglishToRussianToolStripMenuItem_Click);
            // 
            // aboutAdvertisingToolStripMenuItem
            // 
            this.aboutAdvertisingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutAdvertisingToolStripMenuItem.Name = "aboutAdvertisingToolStripMenuItem";
            this.aboutAdvertisingToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.aboutAdvertisingToolStripMenuItem.Text = "About advertising";
            this.aboutAdvertisingToolStripMenuItem.Click += new System.EventHandler(this.aboutAdvertisingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.Location = new System.Drawing.Point(-4, 47);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(56, 24);
            this.labelWord.TabIndex = 2;
            this.labelWord.Text = "Word";
            // 
            // textBoxTranslation
            // 
            this.textBoxTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTranslation.Location = new System.Drawing.Point(115, 117);
            this.textBoxTranslation.Name = "textBoxTranslation";
            this.textBoxTranslation.Size = new System.Drawing.Size(189, 28);
            this.textBoxTranslation.TabIndex = 5;
            // 
            // labelTranslation
            // 
            this.labelTranslation.AutoSize = true;
            this.labelTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTranslation.Location = new System.Drawing.Point(-4, 121);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(102, 24);
            this.labelTranslation.TabIndex = 4;
            this.labelTranslation.Text = "Translation";
            // 
            // labelInputWord
            // 
            this.labelInputWord.BackColor = System.Drawing.SystemColors.Window;
            this.labelInputWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInputWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputWord.Location = new System.Drawing.Point(115, 46);
            this.labelInputWord.Name = "labelInputWord";
            this.labelInputWord.Size = new System.Drawing.Size(189, 23);
            this.labelInputWord.TabIndex = 6;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirm.Location = new System.Drawing.Point(-1, 215);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(115, 36);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "Сonfirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonСonfirm_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(121, 215);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(115, 36);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonShowPicture
            // 
            this.buttonShowPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowPicture.Location = new System.Drawing.Point(242, 215);
            this.buttonShowPicture.Name = "buttonShowPicture";
            this.buttonShowPicture.Size = new System.Drawing.Size(198, 36);
            this.buttonShowPicture.TabIndex = 10;
            this.buttonShowPicture.Text = "Picture";
            this.buttonShowPicture.UseVisualStyleBackColor = true;
            this.buttonShowPicture.Click += new System.EventHandler(this.buttonShowPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ADO.NET_HW2.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(458, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 250);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timerWrongAnswer
            // 
            this.timerWrongAnswer.Interval = 2000;
            this.timerWrongAnswer.Tick += new System.EventHandler(this.timerWrongAnswer_Tick);
            // 
            // panelTraining
            // 
            this.panelTraining.Controls.Add(this.labelWord);
            this.panelTraining.Controls.Add(this.buttonShowPicture);
            this.panelTraining.Controls.Add(this.labelTranslation);
            this.panelTraining.Controls.Add(this.textBoxTranslation);
            this.panelTraining.Controls.Add(this.buttonNext);
            this.panelTraining.Controls.Add(this.labelInputWord);
            this.panelTraining.Controls.Add(this.buttonConfirm);
            this.panelTraining.Location = new System.Drawing.Point(12, 36);
            this.panelTraining.Name = "panelTraining";
            this.panelTraining.Size = new System.Drawing.Size(440, 250);
            this.panelTraining.TabIndex = 11;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.dataGridView1);
            this.panelEdit.Controls.Add(this.buttonAddPicture);
            this.panelEdit.Controls.Add(this.buttonSaveChanges);
            this.panelEdit.Controls.Add(this.buttonCancel);
            this.panelEdit.Location = new System.Drawing.Point(11, 36);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(441, 250);
            this.panelEdit.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 209);
            this.dataGridView1.TabIndex = 11;
            //this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPicture.Location = new System.Drawing.Point(242, 215);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(199, 36);
            this.buttonAddPicture.TabIndex = 10;
            this.buttonAddPicture.Text = "Add picture";
            this.buttonAddPicture.UseVisualStyleBackColor = true;
            this.buttonAddPicture.Click += new System.EventHandler(this.buttonAddPicture_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(-1, 215);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(139, 36);
            this.buttonSaveChanges.TabIndex = 7;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(145, 215);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 36);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 295);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelTraining);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Learning Russian";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTraining.ResumeLayout(false);
            this.panelTraining.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox textBoxTranslation;
        private System.Windows.Forms.Label labelTranslation;
        private System.Windows.Forms.Label labelInputWord;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonShowPicture;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timerWrongAnswer;
        private System.Windows.Forms.ToolStripMenuItem fromRussianToEnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromEnglishToRussianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAdvertisingToolStripMenuItem;
        private System.Windows.Forms.Panel panelTraining;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button buttonAddPicture;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

