using ADO.NET_HW2.Localizations;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ADO.NET_HW2
{
    public partial class Form1 : Form
    {
        string dir;
        string resource;
        string fromLanguage;
        string intoLanguage;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet dataSet;
        Random random;
        Image defaultImage;
        int currentIndex;
        EnglishLocalization englishLocalization;
        RussianLocalization russianLocalization;
        SqlTransaction tran = null;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            panelEdit.Visible = false;
            englishLocalization = new EnglishLocalization();
            russianLocalization = new RussianLocalization();
            dir = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
            resource = dir + @"\Properties\Resources\";
            defaultImage = Image.FromFile(resource+ "giphy.gif");
            fromLanguage = "Russian";
            intoLanguage = "English";
            string attachDBFilename = dir + @"\App_Data\TrainingTranslate.mdf";
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder
            {
                DataSource = @"(localdb)\mssqllocaldb",
                InitialCatalog = "TrainingTranslate",
                AttachDBFilename = attachDBFilename,
                IntegratedSecurity = true
            };
            connection = new SqlConnection(sqlConnectionString.ConnectionString);
            connection.Open();
            adapter = new SqlDataAdapter("select * from RussianWords", connection);
            // SqlCommand delete
            #region delete
            SqlCommand delete = new SqlCommand();
            delete.CommandText = "delete from RussianWords where (Id=@p)";
            delete.Parameters.Add("@p", SqlDbType.Int);
            delete.Parameters["@p"].SourceColumn = "Id";
            delete.Connection = adapter.SelectCommand.Connection;
            adapter.DeleteCommand = delete;
            #endregion delete
            // SqlCommand insert
            #region insert
            SqlCommand insert = new SqlCommand();
            insert.CommandText = "insert into RussianWords (Russian, English, Picture) values (@p1, @p2, @p3)";
            insert.Parameters.Add("@p1",SqlDbType.NVarChar);
            insert.Parameters["@p1"].SourceColumn = "Russian";
            insert.Parameters.Add("@p2", SqlDbType.NVarChar);
            insert.Parameters["@p2"].SourceColumn = "English";
            insert.Parameters.Add("@p3",SqlDbType.Image);
            insert.Parameters["@p3"].SourceColumn = "Picture";
            insert.Connection = adapter.SelectCommand.Connection;
            adapter.InsertCommand = insert;
            #endregion insert
            // SqlCommand update
            #region update
            SqlCommand update = new SqlCommand();
            update.CommandText = "update RussianWords set Russian=@p1, English=@p2, Picture=@p3 where (Id=@pp1) AND (Russian=@pp2) AND (English=@pp3)";
            update.Parameters.Add("@p1", SqlDbType.NVarChar);
            update.Parameters["@p1"].SourceColumn = "Russian";
            update.Parameters.Add("@p2", SqlDbType.NVarChar);
            update.Parameters["@p2"].SourceColumn = "English";
            update.Parameters.Add("@p3", SqlDbType.Image);
            update.Parameters["@p3"].SourceColumn = "Picture";
            update.Parameters.Add("@pp1",SqlDbType.Int);
            update.Parameters["@pp1"].SourceColumn = "Id";
            update.Parameters["@pp1"].SourceVersion = DataRowVersion.Original;
            update.Parameters.Add("@pp2", SqlDbType.NVarChar);
            update.Parameters["@pp2"].SourceColumn = "Russian";
            update.Parameters["@pp2"].SourceVersion = DataRowVersion.Original;
            update.Parameters.Add("@pp3", SqlDbType.NVarChar);
            update.Parameters["@pp3"].SourceColumn = "English";
            update.Parameters["@pp3"].SourceVersion = DataRowVersion.Original;
            update.Connection = adapter.SelectCommand.Connection;
            adapter.UpdateCommand = update;
            #endregion update
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count == 0)
            {
                InitializeDB();
                adapter.Fill(dataSet);
            }
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns["Id"].Visible = false;
            SelectWord();
        }
        private void InitializeDB()
        {
            string[] englishWords = { "apple", "bear", "bicycle", "cake", "cat", "cofe", "dog", "elefante",
                "helicopter", "horse", "monkey", "pear", "pineapple", "programmer", "sea", "smartphone",
                "tea", "telephone", "truck", "wave" };
            string[] russianWords = { "яблоко", "медведь", "велосипед", "торт", "кот", "кофе", "собака", "слон",
                "вертолет", "лошадь", "обезьяна", "груша", "ананас", "программист", "море", "смартфон",
                "чай", "телефон", "грузовик", "волна" };
            string[] imageSource =
            {
                resource+"apple.jpg",
                resource+"bear.gif",
                resource+"bicycle.gif",
                resource+"cake.gif",
                resource+"cat.gif",
                resource+"cofe.jpg",
                resource+"dog.gif",
                resource+"elefante.gif",
                resource+"helicopter.jpeg",
                resource+"horse.gif",
                resource+"monkey.gif",
                resource+"pear.jpg",
                resource+"pineapple.jpg",
                resource+"programmer.gif",
                resource+"sea.jpg",
                resource+"smartphone.gif",
                resource+"tea.jpg",
                resource+"telephone.jpg",
                resource+"truck.gif",
                resource+"wave.jpg"
            };
            DataSet ds = new DataSet(); 
            try
            {
                adapter.Fill(ds);
                for (int i = 0; i < englishWords.Length; i++)
                {
                    MemoryStream ms = new MemoryStream();
                    Image img = Image.FromFile(imageSource[i]);
                    string ext = Path.GetExtension(imageSource[i]).Replace(".", "");
                    if (ext == "gif")
                        img.Save(ms, ImageFormat.Gif);
                    else if (ext == "jpeg" || ext == "jpg")
                        img.Save(ms, ImageFormat.Jpeg);
                    ms.Seek(0, SeekOrigin.Begin);
                    BinaryReader br = new BinaryReader(ms);
                    byte[] buf = br.ReadBytes((int)ms.Length);
                    ds.Tables[0].Rows.Add();
                    ds.Tables[0].Rows[i]["Russian"] = russianWords[i];
                    ds.Tables[0].Rows[i]["English"] = englishWords[i];
                    ds.Tables[0].Rows[i]["Picture"] = buf;
                    ms.Close();
                }
                adapter.Update(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
        private void SelectWord()
        {
            if (dataSet!=null && dataSet.Tables[0]!=null && dataSet.Tables[0].Rows.Count > 0)
            {
                currentIndex = random.Next(0, dataSet.Tables[0].Rows.Count);
                labelInputWord.Text = dataSet.Tables[0].Rows[currentIndex][fromLanguage].ToString();
            }
        }

        private void trainingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelTraining.Visible = true;
            panelEdit.Visible = false;
            pictureBox1.Image = defaultImage;
            labelInputWord.Text = "";
            textBoxTranslation.Text = "";
            SelectWord();
            if(labelInputWord.Text == "")
            {
                buttonConfirm.Enabled = false;
                buttonNext.Enabled = false;
                buttonShowPicture.Enabled = false;
            }
            else
            {
                buttonConfirm.Enabled = true;
                buttonNext.Enabled = true;
                buttonShowPicture.Enabled = true;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTraining.Visible = false;
            panelEdit.Visible = true;
            pictureBox1.Image = defaultImage;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonСonfirm_Click(object sender, EventArgs e)
        {
            if (textBoxTranslation.Text != "")
            {
                if(textBoxTranslation.Text == dataSet.Tables[0].Rows[currentIndex][intoLanguage].ToString())
                {
                    SetStatus(StatusTraining.right);
                }
                else
                {
                    SetStatus(StatusTraining.wrong);
                }
            }
            else
            {
                if(intoLanguage == "English")
                    MessageBox.Show("Please input your answer!");
                else if (intoLanguage == "Russian")
                    MessageBox.Show("Пожалуйста введите ответ!");
            }
        }
        private void SetStatus(StatusTraining status)
        {
            switch (status)
            {
                case StatusTraining.right:
                    {
                        textBoxTranslation.ForeColor = Color.Green;
                        labelInputWord.ForeColor = Color.Green;
                        buttonConfirm.Enabled = false;
                        break;
                    }
                case StatusTraining.wrong:
                    {
                        textBoxTranslation.ForeColor = Color.Red;
                        timerWrongAnswer.Start();
                        break;
                    }
                case StatusTraining.next:
                    {
                        buttonConfirm.Enabled = true;
                        textBoxTranslation.ForeColor = Color.Black;
                        labelInputWord.ForeColor = Color.Black;
                        textBoxTranslation.Text = "";
                        pictureBox1.Image = defaultImage;
                        break;
                    }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            SetStatus(StatusTraining.next);
            SelectWord();
        }

        private void buttonShowPicture_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != dataSet.Tables[0].Rows[currentIndex]["Picture"])
            {
                MemoryStream ms = new MemoryStream();
                try
                {
                    byte[] buf = (byte[])dataSet.Tables[0].Rows[currentIndex]["Picture"];
                    ms.Write(buf, 0, buf.Length);
                    Image img = Image.FromStream(ms);
                    pictureBox1.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
        }

        private void timerWrongAnswer_Tick(object sender, EventArgs e)
        {
            textBoxTranslation.ForeColor = Color.Black;
            textBoxTranslation.Text = "";
            timerWrongAnswer.Stop();
        }

        private void fromRussianToEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromLanguage = "Russian";
            intoLanguage = "English";
            SetMenuLanguage(englishLocalization);
            SelectWord();
        }

        private void fromEnglishToRussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromLanguage = "English";
            intoLanguage = "Russian";
            SetMenuLanguage(russianLocalization);
            SelectWord();
        }

        private void aboutAdvertisingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (intoLanguage == "English")
                MessageBox.Show("For advertising in the application, you can call: +375293336510");
            else if (intoLanguage == "Russian")
                MessageBox.Show("По вопросам размещения рекламы в приложении вы можете позвонить по телефону: +375293336510");

        }
        private void SetMenuLanguage(ILocalization local)
        {
            trainingToolStripMenuItem1.Text = local.trainingToolStripMenuItem;
            editToolStripMenuItem.Text = local.editToolStripMenuItem;
            settingsToolStripMenuItem.Text = local.settingsToolStripMenuItem;
            fromRussianToEnglishToolStripMenuItem.Text = local.fromRussianToEnglishToolStripMenuItem;
            fromEnglishToRussianToolStripMenuItem.Text = local.fromEnglishToRussianToolStripMenuItem;
            aboutAdvertisingToolStripMenuItem.Text = local.aboutAdvertisingToolStripMenuItem;
            exitToolStripMenuItem.Text = local.exitToolStripMenuItem;
            labelWord.Text = local.labelWord;
            labelTranslation.Text = local.labelTranslation;
            buttonConfirm.Text = local.buttonСonfirm;
            buttonNext.Text = local.buttonNext;
            buttonShowPicture.Text = local.buttonShowPicture;
            buttonSaveChanges.Text = local.buttonSaveChanges;
            buttonCancel.Text = local.buttonCancel;
            buttonAddPicture.Text = local.buttonAddPicture;
            this.Text = local.formText;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            tran = connection.BeginTransaction();
            adapter.DeleteCommand.Transaction = tran;
            adapter.InsertCommand.Transaction = tran;
            adapter.UpdateCommand.Transaction = tran;
            try
            {
                adapter.Update(dataSet.Tables[0].Select(null, null, DataViewRowState.Deleted));
                adapter.Update(dataSet.Tables[0].Select(null, null, DataViewRowState.ModifiedCurrent));
                adapter.Update(dataSet.Tables[0].Select(null, null, DataViewRowState.Added));
                tran.Commit();
                dataSet.Clear();
                adapter.Fill(dataSet);
                dataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
            adapter.Fill(dataSet);
        }

        private void buttonAddPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Load(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Jpeg);
                ms.Flush();
                ms.Seek(0, SeekOrigin.Begin);
                BinaryReader br = new BinaryReader(ms);
                byte[] buf = br.ReadBytes((int)ms.Length);
                dataSet.Tables[0].Rows[dataGridView1.CurrentRow.Index]["Picture"] = buf;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    {
                        if (intoLanguage == "English")
                            MessageBox.Show("In row " + (e.RowIndex + 1) + " column \"Russian\" missing value");
                        else if (intoLanguage == "Russian")
                            MessageBox.Show("В строке " + (e.RowIndex + 1) + " столбца \"Russian\" отсутствует значение");
                        break;
                    }
                case 2:
                    {
                        if (intoLanguage == "English")
                            MessageBox.Show("In row " + (e.RowIndex + 1) + " column \"English\" missing value");
                        else if (intoLanguage == "Russian")
                            MessageBox.Show("В строке " + (e.RowIndex + 1) + " столбца \"English\" отсутствует значение");
                        break;
                    }
                case 3:
                    {
                        if (intoLanguage == "English")
                            MessageBox.Show("In row " + (e.RowIndex + 1) + " column \"Picture\" missing value");
                        else if (intoLanguage == "Russian")
                            MessageBox.Show("В строке " + (e.RowIndex + 1) + " столбца \"Picture\" отсутствует значение");
                        break;
                    }
            }
        }
    }
}