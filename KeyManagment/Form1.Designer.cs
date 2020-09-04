namespace KeyManagment
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAddKey = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxKeyOwner = new System.Windows.Forms.GroupBox();
            this.radioButtonNew = new System.Windows.Forms.RadioButton();
            this.radioButtonExist = new System.Windows.Forms.RadioButton();
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.comboBoxExist = new System.Windows.Forms.ComboBox();
            this.groupBoxPremium = new System.Windows.Forms.GroupBox();
            this.groupBoxGenerateKey = new System.Windows.Forms.GroupBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.groupBoxReview = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxAddKey.SuspendLayout();
            this.groupBoxKeyOwner.SuspendLayout();
            this.groupBoxPremium.SuspendLayout();
            this.groupBoxGenerateKey.SuspendLayout();
            this.groupBoxReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddKey
            // 
            this.groupBoxAddKey.Controls.Add(this.buttonConfirm);
            this.groupBoxAddKey.Controls.Add(this.groupBoxGenerateKey);
            this.groupBoxAddKey.Controls.Add(this.groupBoxPremium);
            this.groupBoxAddKey.Controls.Add(this.groupBoxKeyOwner);
            this.groupBoxAddKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxAddKey.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddKey.Name = "groupBoxAddKey";
            this.groupBoxAddKey.Size = new System.Drawing.Size(342, 402);
            this.groupBoxAddKey.TabIndex = 0;
            this.groupBoxAddKey.TabStop = false;
            this.groupBoxAddKey.Text = "Dodaj klucz";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton3.Location = new System.Drawing.Point(6, 81);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(135, 21);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pakiet Premium3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton2.Location = new System.Drawing.Point(6, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pakiet Premium2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1.Location = new System.Drawing.Point(6, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pakiet Premium1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxKeyOwner
            // 
            this.groupBoxKeyOwner.Controls.Add(this.comboBoxExist);
            this.groupBoxKeyOwner.Controls.Add(this.textBoxNew);
            this.groupBoxKeyOwner.Controls.Add(this.radioButtonExist);
            this.groupBoxKeyOwner.Controls.Add(this.radioButtonNew);
            this.groupBoxKeyOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxKeyOwner.Location = new System.Drawing.Point(6, 25);
            this.groupBoxKeyOwner.Name = "groupBoxKeyOwner";
            this.groupBoxKeyOwner.Size = new System.Drawing.Size(330, 88);
            this.groupBoxKeyOwner.TabIndex = 7;
            this.groupBoxKeyOwner.TabStop = false;
            this.groupBoxKeyOwner.Text = "Właściciel klucza";
            // 
            // radioButtonNew
            // 
            this.radioButtonNew.AutoSize = true;
            this.radioButtonNew.Checked = true;
            this.radioButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonNew.Location = new System.Drawing.Point(7, 23);
            this.radioButtonNew.Name = "radioButtonNew";
            this.radioButtonNew.Size = new System.Drawing.Size(63, 21);
            this.radioButtonNew.TabIndex = 3;
            this.radioButtonNew.TabStop = true;
            this.radioButtonNew.Text = "Nowy";
            this.radioButtonNew.UseVisualStyleBackColor = true;
            this.radioButtonNew.CheckedChanged += new System.EventHandler(this.radioButtonNew_CheckedChanged);
            // 
            // radioButtonExist
            // 
            this.radioButtonExist.AutoSize = true;
            this.radioButtonExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonExist.Location = new System.Drawing.Point(174, 22);
            this.radioButtonExist.Name = "radioButtonExist";
            this.radioButtonExist.Size = new System.Drawing.Size(87, 21);
            this.radioButtonExist.TabIndex = 4;
            this.radioButtonExist.Text = "Istniejący";
            this.radioButtonExist.UseVisualStyleBackColor = true;
            this.radioButtonExist.CheckedChanged += new System.EventHandler(this.radioButtonExist_CheckedChanged);
            // 
            // textBoxNew
            // 
            this.textBoxNew.Location = new System.Drawing.Point(7, 49);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.Size = new System.Drawing.Size(150, 24);
            this.textBoxNew.TabIndex = 5;
            // 
            // comboBoxExist
            // 
            this.comboBoxExist.Enabled = false;
            this.comboBoxExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxExist.FormattingEnabled = true;
            this.comboBoxExist.Location = new System.Drawing.Point(174, 49);
            this.comboBoxExist.Name = "comboBoxExist";
            this.comboBoxExist.Size = new System.Drawing.Size(150, 24);
            this.comboBoxExist.TabIndex = 1;
            // 
            // groupBoxPremium
            // 
            this.groupBoxPremium.Controls.Add(this.radioButton1);
            this.groupBoxPremium.Controls.Add(this.radioButton2);
            this.groupBoxPremium.Controls.Add(this.radioButton3);
            this.groupBoxPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxPremium.Location = new System.Drawing.Point(6, 119);
            this.groupBoxPremium.Name = "groupBoxPremium";
            this.groupBoxPremium.Size = new System.Drawing.Size(330, 113);
            this.groupBoxPremium.TabIndex = 8;
            this.groupBoxPremium.TabStop = false;
            this.groupBoxPremium.Text = "Wybierz pakiet Premium";
            // 
            // groupBoxGenerateKey
            // 
            this.groupBoxGenerateKey.Controls.Add(this.buttonGenerate);
            this.groupBoxGenerateKey.Controls.Add(this.textBoxKey);
            this.groupBoxGenerateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxGenerateKey.Location = new System.Drawing.Point(6, 238);
            this.groupBoxGenerateKey.Name = "groupBoxGenerateKey";
            this.groupBoxGenerateKey.Size = new System.Drawing.Size(330, 99);
            this.groupBoxGenerateKey.TabIndex = 9;
            this.groupBoxGenerateKey.TabStop = false;
            this.groupBoxGenerateKey.Text = "Generuj kod";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(6, 343);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(329, 51);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Zapisz";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(6, 23);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(318, 24);
            this.textBoxKey.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(7, 54);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(317, 37);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Wygeneruj";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // groupBoxReview
            // 
            this.groupBoxReview.Controls.Add(this.listBox1);
            this.groupBoxReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxReview.Location = new System.Drawing.Point(360, 12);
            this.groupBoxReview.Name = "groupBoxReview";
            this.groupBoxReview.Size = new System.Drawing.Size(342, 402);
            this.groupBoxReview.TabIndex = 1;
            this.groupBoxReview.TabStop = false;
            this.groupBoxReview.Text = "Przegląd bazy kodów";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Jan Kowalski",
            "Jacek Nowak",
            "Mateusz Borek",
            "Tomasz Smokowski",
            "Krzysztof Stanowski",
            "Krystian Szczepiński"});
            this.listBox1.Location = new System.Drawing.Point(6, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 94);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 424);
            this.Controls.Add(this.groupBoxReview);
            this.Controls.Add(this.groupBoxAddKey);
            this.Name = "Form1";
            this.Text = "KeyManagment";
            this.groupBoxAddKey.ResumeLayout(false);
            this.groupBoxKeyOwner.ResumeLayout(false);
            this.groupBoxKeyOwner.PerformLayout();
            this.groupBoxPremium.ResumeLayout(false);
            this.groupBoxPremium.PerformLayout();
            this.groupBoxGenerateKey.ResumeLayout(false);
            this.groupBoxGenerateKey.PerformLayout();
            this.groupBoxReview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddKey;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxKeyOwner;
        private System.Windows.Forms.RadioButton radioButtonExist;
        private System.Windows.Forms.RadioButton radioButtonNew;
        private System.Windows.Forms.GroupBox groupBoxPremium;
        private System.Windows.Forms.ComboBox comboBoxExist;
        private System.Windows.Forms.TextBox textBoxNew;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.GroupBox groupBoxGenerateKey;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.GroupBox groupBoxReview;
        private System.Windows.Forms.ListBox listBox1;
    }
}

