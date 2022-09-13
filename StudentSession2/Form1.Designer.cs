namespace Students
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_nGroup = new System.Windows.Forms.TextBox();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_exam1 = new System.Windows.Forms.TextBox();
            this.textBox_exam2 = new System.Windows.Forms.TextBox();
            this.button_new = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.Button_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_exam3 = new System.Windows.Forms.TextBox();
            this.textBox_exam4 = new System.Windows.Forms.TextBox();
            this.textBox_exam5 = new System.Windows.Forms.TextBox();
            this.textBox_offset2 = new System.Windows.Forms.TextBox();
            this.textBox_offset1 = new System.Windows.Forms.TextBox();
            this.textBox_offset3 = new System.Windows.Forms.TextBox();
            this.textBox_offset4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_offset5 = new System.Windows.Forms.TextBox();
            this.buttonNON = new System.Windows.Forms.Button();
            this.textBox_del = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search.Location = new System.Drawing.Point(741, 48);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(203, 26);
            this.textBox_search.TabIndex = 2;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(932, 270);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id.Location = new System.Drawing.Point(23, 34);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(36, 26);
            this.textBox_id.TabIndex = 4;
            // 
            // textBox_nGroup
            // 
            this.textBox_nGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_nGroup.Location = new System.Drawing.Point(65, 34);
            this.textBox_nGroup.Name = "textBox_nGroup";
            this.textBox_nGroup.Size = new System.Drawing.Size(147, 26);
            this.textBox_nGroup.TabIndex = 5;
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FIO.Location = new System.Drawing.Point(218, 34);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(331, 26);
            this.textBox_FIO.TabIndex = 6;
            // 
            // textBox_exam1
            // 
            this.textBox_exam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exam1.Location = new System.Drawing.Point(65, 92);
            this.textBox_exam1.Name = "textBox_exam1";
            this.textBox_exam1.Size = new System.Drawing.Size(100, 26);
            this.textBox_exam1.TabIndex = 7;
            this.textBox_exam1.TextChanged += new System.EventHandler(this.textBox_exam1_TextChanged);
            // 
            // textBox_exam2
            // 
            this.textBox_exam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exam2.Location = new System.Drawing.Point(65, 125);
            this.textBox_exam2.Name = "textBox_exam2";
            this.textBox_exam2.Size = new System.Drawing.Size(100, 26);
            this.textBox_exam2.TabIndex = 8;
            // 
            // button_new
            // 
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_new.Location = new System.Drawing.Point(418, 95);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(170, 26);
            this.button_new.TabIndex = 9;
            this.button_new.Text = "Новая запись";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(418, 125);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(170, 26);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.Location = new System.Drawing.Point(418, 157);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(170, 26);
            this.buttonChange.TabIndex = 11;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(418, 189);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(170, 26);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Сохранить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Button_update
            // 
            this.Button_update.BackColor = System.Drawing.Color.LightPink;
            this.Button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_update.Location = new System.Drawing.Point(12, 46);
            this.Button_update.Name = "Button_update";
            this.Button_update.Size = new System.Drawing.Size(189, 30);
            this.Button_update.TabIndex = 13;
            this.Button_update.Text = "Обновить данные";
            this.Button_update.UseVisualStyleBackColor = false;
            this.Button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_exam3
            // 
            this.textBox_exam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exam3.Location = new System.Drawing.Point(65, 157);
            this.textBox_exam3.Name = "textBox_exam3";
            this.textBox_exam3.Size = new System.Drawing.Size(100, 26);
            this.textBox_exam3.TabIndex = 15;
            // 
            // textBox_exam4
            // 
            this.textBox_exam4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exam4.Location = new System.Drawing.Point(65, 189);
            this.textBox_exam4.Name = "textBox_exam4";
            this.textBox_exam4.Size = new System.Drawing.Size(100, 26);
            this.textBox_exam4.TabIndex = 16;
            // 
            // textBox_exam5
            // 
            this.textBox_exam5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exam5.Location = new System.Drawing.Point(65, 221);
            this.textBox_exam5.Name = "textBox_exam5";
            this.textBox_exam5.Size = new System.Drawing.Size(100, 26);
            this.textBox_exam5.TabIndex = 17;
            // 
            // textBox_offset2
            // 
            this.textBox_offset2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_offset2.Location = new System.Drawing.Point(245, 127);
            this.textBox_offset2.Name = "textBox_offset2";
            this.textBox_offset2.Size = new System.Drawing.Size(100, 26);
            this.textBox_offset2.TabIndex = 18;
            // 
            // textBox_offset1
            // 
            this.textBox_offset1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_offset1.Location = new System.Drawing.Point(245, 95);
            this.textBox_offset1.Name = "textBox_offset1";
            this.textBox_offset1.Size = new System.Drawing.Size(100, 26);
            this.textBox_offset1.TabIndex = 19;
            // 
            // textBox_offset3
            // 
            this.textBox_offset3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_offset3.Location = new System.Drawing.Point(245, 159);
            this.textBox_offset3.Name = "textBox_offset3";
            this.textBox_offset3.Size = new System.Drawing.Size(100, 26);
            this.textBox_offset3.TabIndex = 20;
            // 
            // textBox_offset4
            // 
            this.textBox_offset4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_offset4.Location = new System.Drawing.Point(245, 191);
            this.textBox_offset4.Name = "textBox_offset4";
            this.textBox_offset4.Size = new System.Drawing.Size(100, 26);
            this.textBox_offset4.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(217, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ф.И.О";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Номер группы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(61, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Экзамены (0 до 100)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(241, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Зачеты (0 или 1)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(37, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(37, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(37, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(37, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "5";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(37, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "4";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox_offset5
            // 
            this.textBox_offset5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_offset5.Location = new System.Drawing.Point(245, 223);
            this.textBox_offset5.Name = "textBox_offset5";
            this.textBox_offset5.Size = new System.Drawing.Size(100, 26);
            this.textBox_offset5.TabIndex = 33;
            this.textBox_offset5.TextChanged += new System.EventHandler(this.textBox_offset5_TextChanged);
            // 
            // buttonNON
            // 
            this.buttonNON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNON.Location = new System.Drawing.Point(418, 220);
            this.buttonNON.Name = "buttonNON";
            this.buttonNON.Size = new System.Drawing.Size(170, 27);
            this.buttonNON.TabIndex = 34;
            this.buttonNON.Text = "Все неуспевающие";
            this.buttonNON.UseVisualStyleBackColor = true;
            this.buttonNON.Click += new System.EventHandler(this.buttonNON_Click);
            // 
            // textBox_del
            // 
            this.textBox_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_del.Location = new System.Drawing.Point(598, 125);
            this.textBox_del.Name = "textBox_del";
            this.textBox_del.Size = new System.Drawing.Size(256, 26);
            this.textBox_del.TabIndex = 35;
            this.textBox_del.TextChanged += new System.EventHandler(this.textBox_del_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(680, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Поиск";
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(598, 157);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(256, 26);
            this.buttonDel.TabIndex = 37;
            this.buttonDel.Text = "Удалить группу";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(594, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(323, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Введите группу, которую хотите удалить";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(598, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 26);
            this.button1.TabIndex = 39;
            this.button1.Text = "Сохранить данные студента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.textBox_del);
            this.panel1.Controls.Add(this.buttonNON);
            this.panel1.Controls.Add(this.textBox_offset5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_offset4);
            this.panel1.Controls.Add(this.textBox_offset3);
            this.panel1.Controls.Add(this.textBox_offset1);
            this.panel1.Controls.Add(this.textBox_offset2);
            this.panel1.Controls.Add(this.textBox_exam5);
            this.panel1.Controls.Add(this.textBox_exam4);
            this.panel1.Controls.Add(this.textBox_exam3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonChange);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_new);
            this.panel1.Controls.Add(this.textBox_exam2);
            this.panel1.Controls.Add(this.textBox_exam1);
            this.panel1.Controls.Add(this.textBox_FIO);
            this.panel1.Controls.Add(this.textBox_nGroup);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Location = new System.Drawing.Point(12, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 295);
            this.panel1.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(954, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Сессия студентов";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_nGroup;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_exam1;
        private System.Windows.Forms.TextBox textBox_exam2;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button Button_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_exam3;
        private System.Windows.Forms.TextBox textBox_exam4;
        private System.Windows.Forms.TextBox textBox_exam5;
        private System.Windows.Forms.TextBox textBox_offset2;
        private System.Windows.Forms.TextBox textBox_offset1;
        private System.Windows.Forms.TextBox textBox_offset3;
        private System.Windows.Forms.TextBox textBox_offset4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_offset5;
        private System.Windows.Forms.Button buttonNON;
        private System.Windows.Forms.TextBox textBox_del;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

