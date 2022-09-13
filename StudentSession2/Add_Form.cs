using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Students
{
	public partial class Add_Form : Form
	{
		DataBase database = new DataBase();

		public Add_Form()
		{
			InitializeComponent();
		}

		private void Add_Form_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			database.openConnection();

			var nGroup = textBox_nGroup2.Text;
			var FIO = textBox_FIO2.Text;
			int exam1;
			int exam2;
			int exam3;
			int exam4;
			int exam5;
			int offset1;
			int offset2;
			int offset3;
			int offset4;
			int offset5;

			if (int.TryParse(textBox_exam12.Text, out exam1) && int.TryParse(textBox_exam22.Text, out exam2) && int.TryParse(textBox_exam32.Text, out exam3)
				&& int.TryParse(textBox_exam42.Text, out exam4) && int.TryParse(textBox_exam52.Text, out exam5) && int.TryParse(textBox_offset12.Text, out offset1) 
				&& int.TryParse(textBox_offset22.Text, out offset2) && int.TryParse(textBox_offset32.Text, out offset3) && int.TryParse(textBox_offset42.Text, out offset4)
				&& int.TryParse(textBox_offset52.Text, out offset5))
			{
				if (exam1 <= 100 && exam1 >=0 && exam2 <= 100 && exam2 >= 0 && exam3 <= 100 && exam3 >= 0 && exam4 <= 100 && exam4 >= 0 && exam5 <= 100 && exam5 >= 0 && (offset1 == 1 || offset1 ==0) && (offset2 == 1 || offset2 == 0) && (offset3 == 1 || offset3 == 0) && (offset4 == 1 || offset4 == 0) && (offset5 == 1 || offset5 == 0))
				{
					var addQuery = $"INSERT INTO Students ('Group', Full_name, Exam_1, Exam_2, Exam_3, Exam_4, Exam_5, Offset_1, Offset_2, Offset_3, Offset_4, Offset_5) values ('{nGroup}', '{FIO}', '{exam1}', '{exam2}', '{exam3}', '{exam4}', '{exam5}', '{offset1}', '{offset2}', '{offset3}', '{offset4}', '{offset5}')";

					var command = new SQLiteCommand(addQuery, database.getConnection());
					command.ExecuteNonQuery();

					MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else MessageBox.Show("Результаты экзаменов и зачетов должны соответствовать диапазону!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}

			else
			{
				MessageBox.Show("Результаты экзаменов и зачетов должны иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			database.closeConnection();
		}
	}
}
