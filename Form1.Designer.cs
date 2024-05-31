namespace Lab_26
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxTemplatePath = new System.Windows.Forms.TextBox();
            this.buttonSelectTemplate = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxOsobrah = new System.Windows.Forms.TextBox();
            this.textBoxDateF = new System.Windows.Forms.TextBox();
            this.textBoxDateS = new System.Windows.Forms.TextBox();
            this.textBoxPrev = new System.Windows.Forms.TextBox();
            this.textBoxByDate = new System.Windows.Forms.TextBox();
            this.textBoxTypeLich = new System.Windows.Forms.TextBox();
            this.textBoxTarif = new System.Windows.Forms.TextBox();
            this.textBoxM3Price = new System.Windows.Forms.TextBox();
            this.textBoxPilga = new System.Windows.Forms.TextBox();
            this.textBoxBorg = new System.Windows.Forms.TextBox();
            this.labelTemplatePath = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelOsobrah = new System.Windows.Forms.Label();
            this.labelDateF = new System.Windows.Forms.Label();
            this.labelDateS = new System.Windows.Forms.Label();
            this.labelPrev = new System.Windows.Forms.Label();
            this.labelByDate = new System.Windows.Forms.Label();
            this.labelTypeLich = new System.Windows.Forms.Label();
            this.labelTarif = new System.Windows.Forms.Label();
            this.labelM3Price = new System.Windows.Forms.Label();
            this.labelPilga = new System.Windows.Forms.Label();
            this.labelBorg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTemplatePath
            // 
            this.textBoxTemplatePath.Location = new System.Drawing.Point(12, 25);
            this.textBoxTemplatePath.Name = "textBoxTemplatePath";
            this.textBoxTemplatePath.Size = new System.Drawing.Size(260, 20);
            this.textBoxTemplatePath.TabIndex = 0;
            // 
            // buttonSelectTemplate
            // 
            this.buttonSelectTemplate.Location = new System.Drawing.Point(278, 23);
            this.buttonSelectTemplate.Name = "buttonSelectTemplate";
            this.buttonSelectTemplate.Size = new System.Drawing.Size(94, 23);
            this.buttonSelectTemplate.TabIndex = 1;
            this.buttonSelectTemplate.Text = "Вибрати шаблон";
            this.buttonSelectTemplate.UseVisualStyleBackColor = true;
            this.buttonSelectTemplate.Click += new System.EventHandler(this.buttonSelectTemplate_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 622);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(360, 23);
            this.buttonGenerate.TabIndex = 17;
            this.buttonGenerate.Text = "Згенерувати квитанцію";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(360, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 115);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(360, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(12, 155);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(360, 20);
            this.textBoxAddress.TabIndex = 4;
            // 
            // textBoxOsobrah
            // 
            this.textBoxOsobrah.Location = new System.Drawing.Point(12, 195);
            this.textBoxOsobrah.Name = "textBoxOsobrah";
            this.textBoxOsobrah.Size = new System.Drawing.Size(360, 20);
            this.textBoxOsobrah.TabIndex = 5;
            // 
            // textBoxDateF
            // 
            this.textBoxDateF.Location = new System.Drawing.Point(12, 235);
            this.textBoxDateF.Name = "textBoxDateF";
            this.textBoxDateF.Size = new System.Drawing.Size(360, 20);
            this.textBoxDateF.TabIndex = 6;
            // 
            // textBoxDateS
            // 
            this.textBoxDateS.Location = new System.Drawing.Point(12, 275);
            this.textBoxDateS.Name = "textBoxDateS";
            this.textBoxDateS.Size = new System.Drawing.Size(360, 20);
            this.textBoxDateS.TabIndex = 7;
            // 
            // textBoxPrev
            // 
            this.textBoxPrev.Location = new System.Drawing.Point(12, 315);
            this.textBoxPrev.Name = "textBoxPrev";
            this.textBoxPrev.Size = new System.Drawing.Size(360, 20);
            this.textBoxPrev.TabIndex = 8;
            // 
            // textBoxByDate
            // 
            this.textBoxByDate.Location = new System.Drawing.Point(12, 355);
            this.textBoxByDate.Name = "textBoxByDate";
            this.textBoxByDate.Size = new System.Drawing.Size(360, 20);
            this.textBoxByDate.TabIndex = 9;
            // 
            // textBoxTypeLich
            // 
            this.textBoxTypeLich.Location = new System.Drawing.Point(12, 395);
            this.textBoxTypeLich.Name = "textBoxTypeLich";
            this.textBoxTypeLich.Size = new System.Drawing.Size(360, 20);
            this.textBoxTypeLich.TabIndex = 10;
            // 
            // textBoxTarif
            // 
            this.textBoxTarif.Location = new System.Drawing.Point(12, 435);
            this.textBoxTarif.Name = "textBoxTarif";
            this.textBoxTarif.Size = new System.Drawing.Size(360, 20);
            this.textBoxTarif.TabIndex = 11;
            // 
            // textBoxM3Price
            // 
            this.textBoxM3Price.Location = new System.Drawing.Point(12, 475);
            this.textBoxM3Price.Name = "textBoxM3Price";
            this.textBoxM3Price.Size = new System.Drawing.Size(360, 20);
            this.textBoxM3Price.TabIndex = 12;
            // 
            // textBoxPilga
            // 
            this.textBoxPilga.Location = new System.Drawing.Point(12, 515);
            this.textBoxPilga.Name = "textBoxPilga";
            this.textBoxPilga.Size = new System.Drawing.Size(360, 20);
            this.textBoxPilga.TabIndex = 13;
            // 
            // textBoxBorg
            // 
            this.textBoxBorg.Location = new System.Drawing.Point(12, 555);
            this.textBoxBorg.Name = "textBoxBorg";
            this.textBoxBorg.Size = new System.Drawing.Size(360, 20);
            this.textBoxBorg.TabIndex = 14;
            // 
            // labelTemplatePath
            // 
            this.labelTemplatePath.AutoSize = true;
            this.labelTemplatePath.Location = new System.Drawing.Point(9, 9);
            this.labelTemplatePath.Name = "labelTemplatePath";
            this.labelTemplatePath.Size = new System.Drawing.Size(82, 13);
            this.labelTemplatePath.TabIndex = 18;
            this.labelTemplatePath.Text = "Шлях шаблону:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Ім\'я:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(9, 99);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(59, 13);
            this.labelSurname.TabIndex = 20;
            this.labelSurname.Text = "Прізвище:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(9, 139);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(47, 13);
            this.labelAddress.TabIndex = 21;
            this.labelAddress.Text = "Адреса:";
            // 
            // labelOsobrah
            // 
            this.labelOsobrah.AutoSize = true;
            this.labelOsobrah.Location = new System.Drawing.Point(9, 179);
            this.labelOsobrah.Name = "labelOsobrah";
            this.labelOsobrah.Size = new System.Drawing.Size(103, 13);
            this.labelOsobrah.TabIndex = 22;
            this.labelOsobrah.Text = "Особовий рахунок:";
            // 
            // labelDateF
            // 
            this.labelDateF.AutoSize = true;
            this.labelDateF.Location = new System.Drawing.Point(9, 219);
            this.labelDateF.Name = "labelDateF";
            this.labelDateF.Size = new System.Drawing.Size(78, 13);
            this.labelDateF.TabIndex = 23;
            this.labelDateF.Text = "Дата початку:";
            // 
            // labelDateS
            // 
            this.labelDateS.AutoSize = true;
            this.labelDateS.Location = new System.Drawing.Point(9, 259);
            this.labelDateS.Name = "labelDateS";
            this.labelDateS.Size = new System.Drawing.Size(94, 13);
            this.labelDateS.TabIndex = 24;
            this.labelDateS.Text = "Дата закінчення:";
            // 
            // labelPrev
            // 
            this.labelPrev.AutoSize = true;
            this.labelPrev.Location = new System.Drawing.Point(9, 299);
            this.labelPrev.Name = "labelPrev";
            this.labelPrev.Size = new System.Drawing.Size(119, 13);
            this.labelPrev.TabIndex = 25;
            this.labelPrev.Text = "Попередні показання:";
            // 
            // labelByDate
            // 
            this.labelByDate.AutoSize = true;
            this.labelByDate.Location = new System.Drawing.Point(9, 339);
            this.labelByDate.Name = "labelByDate";
            this.labelByDate.Size = new System.Drawing.Size(105, 13);
            this.labelByDate.TabIndex = 26;
            this.labelByDate.Text = "Поточні показання:";
            // 
            // labelTypeLich
            // 
            this.labelTypeLich.AutoSize = true;
            this.labelTypeLich.Location = new System.Drawing.Point(9, 379);
            this.labelTypeLich.Name = "labelTypeLich";
            this.labelTypeLich.Size = new System.Drawing.Size(87, 13);
            this.labelTypeLich.TabIndex = 27;
            this.labelTypeLich.Text = "Тип лічильника:";
            // 
            // labelTarif
            // 
            this.labelTarif.AutoSize = true;
            this.labelTarif.Location = new System.Drawing.Point(9, 419);
            this.labelTarif.Name = "labelTarif";
            this.labelTarif.Size = new System.Drawing.Size(43, 13);
            this.labelTarif.TabIndex = 28;
            this.labelTarif.Text = "Тариф:";
            // 
            // labelM3Price
            // 
            this.labelM3Price.AutoSize = true;
            this.labelM3Price.Location = new System.Drawing.Point(9, 459);
            this.labelM3Price.Name = "labelM3Price";
            this.labelM3Price.Size = new System.Drawing.Size(96, 13);
            this.labelM3Price.TabIndex = 29;
            this.labelM3Price.Text = "Ціна за 1 м³ (грн):";
            // 
            // labelPilga
            // 
            this.labelPilga.AutoSize = true;
            this.labelPilga.Location = new System.Drawing.Point(9, 499);
            this.labelPilga.Name = "labelPilga";
            this.labelPilga.Size = new System.Drawing.Size(92, 13);
            this.labelPilga.TabIndex = 30;
            this.labelPilga.Text = "Пільга/Субсидія:";
            // 
            // labelBorg
            // 
            this.labelBorg.AutoSize = true;
            this.labelBorg.Location = new System.Drawing.Point(9, 539);
            this.labelBorg.Name = "labelBorg";
            this.labelBorg.Size = new System.Drawing.Size(89, 13);
            this.labelBorg.TabIndex = 31;
            this.labelBorg.Text = "Заборгованість:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 666);
            this.Controls.Add(this.labelBorg);
            this.Controls.Add(this.labelPilga);
            this.Controls.Add(this.labelM3Price);
            this.Controls.Add(this.labelTarif);
            this.Controls.Add(this.labelTypeLich);
            this.Controls.Add(this.labelByDate);
            this.Controls.Add(this.labelPrev);
            this.Controls.Add(this.labelDateS);
            this.Controls.Add(this.labelDateF);
            this.Controls.Add(this.labelOsobrah);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTemplatePath);
            this.Controls.Add(this.textBoxBorg);
            this.Controls.Add(this.textBoxPilga);
            this.Controls.Add(this.textBoxM3Price);
            this.Controls.Add(this.textBoxTarif);
            this.Controls.Add(this.textBoxTypeLich);
            this.Controls.Add(this.textBoxByDate);
            this.Controls.Add(this.textBoxPrev);
            this.Controls.Add(this.textBoxDateS);
            this.Controls.Add(this.textBoxDateF);
            this.Controls.Add(this.textBoxOsobrah);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonSelectTemplate);
            this.Controls.Add(this.textBoxTemplatePath);
            this.Name = "Form1";
            this.Text = "Генерація квитанцій";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTemplatePath;
        private System.Windows.Forms.Button buttonSelectTemplate;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxOsobrah;
        private System.Windows.Forms.TextBox textBoxDateF;
        private System.Windows.Forms.TextBox textBoxDateS;
        private System.Windows.Forms.TextBox textBoxPrev;
        private System.Windows.Forms.TextBox textBoxByDate;
        private System.Windows.Forms.TextBox textBoxTypeLich;
        private System.Windows.Forms.TextBox textBoxTarif;
        private System.Windows.Forms.TextBox textBoxM3Price;
        private System.Windows.Forms.TextBox textBoxPilga;
        private System.Windows.Forms.TextBox textBoxBorg;
        private System.Windows.Forms.Label labelTemplatePath;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelOsobrah;
        private System.Windows.Forms.Label labelDateF;
        private System.Windows.Forms.Label labelDateS;
        private System.Windows.Forms.Label labelPrev;
        private System.Windows.Forms.Label labelByDate;
        private System.Windows.Forms.Label labelTypeLich;
        private System.Windows.Forms.Label labelTarif;
        private System.Windows.Forms.Label labelM3Price;
        private System.Windows.Forms.Label labelPilga;
        private System.Windows.Forms.Label labelBorg;
    }
}