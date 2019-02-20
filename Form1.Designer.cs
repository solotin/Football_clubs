namespace SR_OBDZ
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerAdd = new System.Windows.Forms.Button();
            this.playerRole = new System.Windows.Forms.ComboBox();
            this.playerClub = new System.Windows.Forms.ComboBox();
            this.playerAge = new System.Windows.Forms.NumericUpDown();
            this.playerLN = new System.Windows.Forms.TextBox();
            this.playerNat = new System.Windows.Forms.TextBox();
            this.playerFN = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clubStad = new System.Windows.Forms.ComboBox();
            this.clubLg = new System.Windows.Forms.ComboBox();
            this.clubAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clubName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.stadAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.stadCap = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.stadAdr = new System.Windows.Forms.TextBox();
            this.stadName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.changeSallSave = new System.Windows.Forms.Button();
            this.changeSallSall = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.changeSallPlayer = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.changeResAs = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.changeResSave = new System.Windows.Forms.Button();
            this.changeResGoal = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.changeResPlayer = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.filterGet = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.filterValue = new System.Windows.Forms.ComboBox();
            this.filterName = new System.Windows.Forms.ComboBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.salSumGet = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.salSumFilter = new System.Windows.Forms.ComboBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.profitPlayerGet = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.profitPlayer = new System.Windows.Forms.ComboBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.mostPopularGet = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.mostPopular = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerAge)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stadCap)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeSallSall)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeResAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeResGoal)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "таблица Клуб",
            "таблица Футболисты",
            "таблица Эффективность",
            "таблица Зарплаты",
            "таблица Лиги",
            "таблица Стадионы"});
            this.comboBox1.Location = new System.Drawing.Point(13, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 234);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(13, 329);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 186);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.playerAdd);
            this.tabPage1.Controls.Add(this.playerRole);
            this.tabPage1.Controls.Add(this.playerClub);
            this.tabPage1.Controls.Add(this.playerAge);
            this.tabPage1.Controls.Add(this.playerLN);
            this.tabPage1.Controls.Add(this.playerNat);
            this.tabPage1.Controls.Add(this.playerFN);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 160);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Новый игрок";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Возраст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Клуб";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Роль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Национальность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // playerAdd
            // 
            this.playerAdd.Location = new System.Drawing.Point(455, 100);
            this.playerAdd.Name = "playerAdd";
            this.playerAdd.Size = new System.Drawing.Size(75, 23);
            this.playerAdd.TabIndex = 3;
            this.playerAdd.Text = "Добавить";
            this.playerAdd.UseVisualStyleBackColor = true;
            this.playerAdd.Click += new System.EventHandler(this.playerAdd_Click);
            // 
            // playerRole
            // 
            this.playerRole.FormattingEnabled = true;
            this.playerRole.Items.AddRange(new object[] {
            "Goalkeeper",
            "Defender",
            "Halfback",
            "Forward"});
            this.playerRole.Location = new System.Drawing.Point(305, 103);
            this.playerRole.Name = "playerRole";
            this.playerRole.Size = new System.Drawing.Size(126, 21);
            this.playerRole.TabIndex = 2;
            // 
            // playerClub
            // 
            this.playerClub.FormattingEnabled = true;
            this.playerClub.Location = new System.Drawing.Point(160, 102);
            this.playerClub.Name = "playerClub";
            this.playerClub.Size = new System.Drawing.Size(126, 21);
            this.playerClub.TabIndex = 2;
            // 
            // playerAge
            // 
            this.playerAge.Location = new System.Drawing.Point(309, 40);
            this.playerAge.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.playerAge.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.playerAge.Name = "playerAge";
            this.playerAge.Size = new System.Drawing.Size(122, 20);
            this.playerAge.TabIndex = 1;
            this.playerAge.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // playerLN
            // 
            this.playerLN.Location = new System.Drawing.Point(160, 40);
            this.playerLN.Name = "playerLN";
            this.playerLN.Size = new System.Drawing.Size(126, 20);
            this.playerLN.TabIndex = 0;
            // 
            // playerNat
            // 
            this.playerNat.Location = new System.Drawing.Point(12, 103);
            this.playerNat.Name = "playerNat";
            this.playerNat.Size = new System.Drawing.Size(126, 20);
            this.playerNat.TabIndex = 0;
            // 
            // playerFN
            // 
            this.playerFN.Location = new System.Drawing.Point(12, 40);
            this.playerFN.Name = "playerFN";
            this.playerFN.Size = new System.Drawing.Size(126, 20);
            this.playerFN.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clubStad);
            this.tabPage2.Controls.Add(this.clubLg);
            this.tabPage2.Controls.Add(this.clubAdd);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.clubName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Новый клуб";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clubStad
            // 
            this.clubStad.FormattingEnabled = true;
            this.clubStad.Location = new System.Drawing.Point(316, 65);
            this.clubStad.Name = "clubStad";
            this.clubStad.Size = new System.Drawing.Size(126, 21);
            this.clubStad.TabIndex = 11;
            this.clubStad.DropDown += new System.EventHandler(this.clubStad_DropDown);
            // 
            // clubLg
            // 
            this.clubLg.FormattingEnabled = true;
            this.clubLg.Location = new System.Drawing.Point(169, 64);
            this.clubLg.Name = "clubLg";
            this.clubLg.Size = new System.Drawing.Size(126, 21);
            this.clubLg.TabIndex = 10;
            this.clubLg.DropDown += new System.EventHandler(this.clubLg_DropDown);
            // 
            // clubAdd
            // 
            this.clubAdd.Location = new System.Drawing.Point(466, 62);
            this.clubAdd.Name = "clubAdd";
            this.clubAdd.Size = new System.Drawing.Size(75, 23);
            this.clubAdd.TabIndex = 9;
            this.clubAdd.Text = "Добавить";
            this.clubAdd.UseVisualStyleBackColor = true;
            this.clubAdd.Click += new System.EventHandler(this.clubAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Стадион";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Лига";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Название клуба";
            // 
            // clubName
            // 
            this.clubName.Location = new System.Drawing.Point(18, 65);
            this.clubName.Name = "clubName";
            this.clubName.Size = new System.Drawing.Size(126, 20);
            this.clubName.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.stadAdd);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.stadCap);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.stadAdr);
            this.tabPage3.Controls.Add(this.stadName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(562, 160);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Новый стадион";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // stadAdd
            // 
            this.stadAdd.Location = new System.Drawing.Point(464, 58);
            this.stadAdd.Name = "stadAdd";
            this.stadAdd.Size = new System.Drawing.Size(75, 23);
            this.stadAdd.TabIndex = 11;
            this.stadAdd.Text = "Добавить";
            this.stadAdd.UseVisualStyleBackColor = true;
            this.stadAdd.Click += new System.EventHandler(this.stadAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Вместимость";
            // 
            // stadCap
            // 
            this.stadCap.Location = new System.Drawing.Point(319, 60);
            this.stadCap.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stadCap.Name = "stadCap";
            this.stadCap.Size = new System.Drawing.Size(122, 20);
            this.stadCap.TabIndex = 9;
            this.stadCap.ThousandsSeparator = true;
            this.stadCap.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Адрес";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Название стадиона";
            // 
            // stadAdr
            // 
            this.stadAdr.Location = new System.Drawing.Point(170, 60);
            this.stadAdr.Name = "stadAdr";
            this.stadAdr.Size = new System.Drawing.Size(126, 20);
            this.stadAdr.TabIndex = 5;
            // 
            // stadName
            // 
            this.stadName.Location = new System.Drawing.Point(22, 60);
            this.stadName.Name = "stadName";
            this.stadName.Size = new System.Drawing.Size(126, 20);
            this.stadName.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.changeSallSave);
            this.tabPage4.Controls.Add(this.changeSallSall);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.changeSallPlayer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(562, 160);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Измение зарплат";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // changeSallSave
            // 
            this.changeSallSave.Location = new System.Drawing.Point(425, 63);
            this.changeSallSave.Name = "changeSallSave";
            this.changeSallSave.Size = new System.Drawing.Size(75, 23);
            this.changeSallSave.TabIndex = 8;
            this.changeSallSave.Text = "Сохранить";
            this.changeSallSave.UseVisualStyleBackColor = true;
            this.changeSallSave.Click += new System.EventHandler(this.changeSallSave_Click);
            // 
            // changeSallSall
            // 
            this.changeSallSall.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.changeSallSall.Location = new System.Drawing.Point(228, 66);
            this.changeSallSall.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.changeSallSall.Name = "changeSallSall";
            this.changeSallSall.Size = new System.Drawing.Size(178, 20);
            this.changeSallSall.TabIndex = 7;
            this.changeSallSall.ThousandsSeparator = true;
            this.changeSallSall.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(287, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Зарплата";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Игрок";
            // 
            // changeSallPlayer
            // 
            this.changeSallPlayer.FormattingEnabled = true;
            this.changeSallPlayer.Location = new System.Drawing.Point(28, 65);
            this.changeSallPlayer.Name = "changeSallPlayer";
            this.changeSallPlayer.Size = new System.Drawing.Size(178, 21);
            this.changeSallPlayer.TabIndex = 5;
            this.changeSallPlayer.DropDown += new System.EventHandler(this.comboBox2_DropDown);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.changeResAs);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.changeResSave);
            this.tabPage5.Controls.Add(this.changeResGoal);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.changeResPlayer);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(562, 160);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Изменение результативности";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // changeResAs
            // 
            this.changeResAs.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.changeResAs.Location = new System.Drawing.Point(314, 66);
            this.changeResAs.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.changeResAs.Name = "changeResAs";
            this.changeResAs.Size = new System.Drawing.Size(83, 20);
            this.changeResAs.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(317, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Гол. передачи";
            // 
            // changeResSave
            // 
            this.changeResSave.Location = new System.Drawing.Point(425, 63);
            this.changeResSave.Name = "changeResSave";
            this.changeResSave.Size = new System.Drawing.Size(75, 23);
            this.changeResSave.TabIndex = 13;
            this.changeResSave.Text = "Сохранить";
            this.changeResSave.UseVisualStyleBackColor = true;
            this.changeResSave.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // changeResGoal
            // 
            this.changeResGoal.Location = new System.Drawing.Point(218, 66);
            this.changeResGoal.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.changeResGoal.Name = "changeResGoal";
            this.changeResGoal.Size = new System.Drawing.Size(83, 20);
            this.changeResGoal.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(238, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Голы";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(91, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Игрок";
            // 
            // changeResPlayer
            // 
            this.changeResPlayer.FormattingEnabled = true;
            this.changeResPlayer.Location = new System.Drawing.Point(28, 65);
            this.changeResPlayer.Name = "changeResPlayer";
            this.changeResPlayer.Size = new System.Drawing.Size(178, 21);
            this.changeResPlayer.TabIndex = 9;
            this.changeResPlayer.DropDown += new System.EventHandler(this.comboBox2_DropDown);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.filterGet);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.filterValue);
            this.tabPage6.Controls.Add(this.filterName);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(562, 160);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Макс/мин зарплаты";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // filterGet
            // 
            this.filterGet.Location = new System.Drawing.Point(425, 63);
            this.filterGet.Name = "filterGet";
            this.filterGet.Size = new System.Drawing.Size(75, 23);
            this.filterGet.TabIndex = 14;
            this.filterGet.Text = "Выбрать";
            this.filterGet.UseVisualStyleBackColor = true;
            this.filterGet.Click += new System.EventHandler(this.filterGet_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(254, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Значение фильтра:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(70, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Фильтровать по:";
            // 
            // filterValue
            // 
            this.filterValue.FormattingEnabled = true;
            this.filterValue.Items.AddRange(new object[] {
            "-",
            "Клуб",
            "Лига",
            "Национальность"});
            this.filterValue.Location = new System.Drawing.Point(222, 65);
            this.filterValue.Name = "filterValue";
            this.filterValue.Size = new System.Drawing.Size(178, 21);
            this.filterValue.TabIndex = 12;
            // 
            // filterName
            // 
            this.filterName.FormattingEnabled = true;
            this.filterName.Items.AddRange(new object[] {
            "-",
            "Клуб",
            "Лига",
            "Национальность"});
            this.filterName.Location = new System.Drawing.Point(28, 65);
            this.filterName.Name = "filterName";
            this.filterName.Size = new System.Drawing.Size(178, 21);
            this.filterName.TabIndex = 12;
            this.filterName.SelectedIndexChanged += new System.EventHandler(this.filterName_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.salSumGet);
            this.tabPage7.Controls.Add(this.label21);
            this.tabPage7.Controls.Add(this.salSumFilter);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(562, 160);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Зарплатная ведомость";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // salSumGet
            // 
            this.salSumGet.Location = new System.Drawing.Point(425, 63);
            this.salSumGet.Name = "salSumGet";
            this.salSumGet.Size = new System.Drawing.Size(75, 23);
            this.salSumGet.TabIndex = 19;
            this.salSumGet.Text = "Выбрать";
            this.salSumGet.UseVisualStyleBackColor = true;
            this.salSumGet.Click += new System.EventHandler(this.salSumGet_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(218, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Фильтровать по:";
            // 
            // salSumFilter
            // 
            this.salSumFilter.FormattingEnabled = true;
            this.salSumFilter.Items.AddRange(new object[] {
            "Клуб",
            "Лига"});
            this.salSumFilter.Location = new System.Drawing.Point(176, 65);
            this.salSumFilter.Name = "salSumFilter";
            this.salSumFilter.Size = new System.Drawing.Size(178, 21);
            this.salSumFilter.TabIndex = 16;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.profitPlayerGet);
            this.tabPage8.Controls.Add(this.label20);
            this.tabPage8.Controls.Add(this.profitPlayer);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(562, 160);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Наиболее выгодные игроки";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // profitPlayerGet
            // 
            this.profitPlayerGet.Location = new System.Drawing.Point(425, 63);
            this.profitPlayerGet.Name = "profitPlayerGet";
            this.profitPlayerGet.Size = new System.Drawing.Size(75, 23);
            this.profitPlayerGet.TabIndex = 22;
            this.profitPlayerGet.Text = "Выбрать";
            this.profitPlayerGet.UseVisualStyleBackColor = true;
            this.profitPlayerGet.Click += new System.EventHandler(this.profitPlayerGet_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(218, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Фильтровать по:";
            // 
            // profitPlayer
            // 
            this.profitPlayer.FormattingEnabled = true;
            this.profitPlayer.Items.AddRange(new object[] {
            "Defender",
            "Halfback",
            "Forward"});
            this.profitPlayer.Location = new System.Drawing.Point(176, 65);
            this.profitPlayer.Name = "profitPlayer";
            this.profitPlayer.Size = new System.Drawing.Size(178, 21);
            this.profitPlayer.TabIndex = 20;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.mostPopularGet);
            this.tabPage9.Controls.Add(this.label22);
            this.tabPage9.Controls.Add(this.mostPopular);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(562, 160);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Наиболее востребованые";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // mostPopularGet
            // 
            this.mostPopularGet.Location = new System.Drawing.Point(425, 63);
            this.mostPopularGet.Name = "mostPopularGet";
            this.mostPopularGet.Size = new System.Drawing.Size(75, 23);
            this.mostPopularGet.TabIndex = 25;
            this.mostPopularGet.Text = "Выбрать";
            this.mostPopularGet.UseVisualStyleBackColor = true;
            this.mostPopularGet.Click += new System.EventHandler(this.mostPopularGet_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(218, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Фильтровать по:";
            // 
            // mostPopular
            // 
            this.mostPopular.FormattingEnabled = true;
            this.mostPopular.Items.AddRange(new object[] {
            "Стадионы",
            "Национальность"});
            this.mostPopular.Location = new System.Drawing.Point(176, 65);
            this.mostPopular.Name = "mostPopular";
            this.mostPopular.Size = new System.Drawing.Size(178, 21);
            this.mostPopular.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 527);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Футбольный клуб";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerAge)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stadCap)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeSallSall)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeResAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeResGoal)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playerAdd;
        private System.Windows.Forms.ComboBox playerRole;
        private System.Windows.Forms.ComboBox playerClub;
        private System.Windows.Forms.NumericUpDown playerAge;
        private System.Windows.Forms.TextBox playerLN;
        private System.Windows.Forms.TextBox playerNat;
        private System.Windows.Forms.TextBox playerFN;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox clubLg;
        private System.Windows.Forms.Button clubAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox clubName;
        private System.Windows.Forms.Button stadAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown stadCap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stadAdr;
        private System.Windows.Forms.TextBox stadName;
        private System.Windows.Forms.ComboBox clubStad;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button changeSallSave;
        private System.Windows.Forms.NumericUpDown changeSallSall;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox changeSallPlayer;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button changeResSave;
        private System.Windows.Forms.NumericUpDown changeResGoal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox changeResPlayer;
        private System.Windows.Forms.NumericUpDown changeResAs;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox filterName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox filterValue;
        private System.Windows.Forms.Button filterGet;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button salSumGet;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox salSumFilter;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button profitPlayerGet;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox profitPlayer;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button mostPopularGet;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox mostPopular;
    }
}

