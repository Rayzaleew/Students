using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Students
{

	public partial class Form1 : Form
	{
		DataBase database = new DataBase();
		
		int selectedRow;
		string query = $"`Student_id` as 'Id',`Group` as 'Номер группы',`Full_name` as 'ФИО', `Exam_1` as 'Экзамен 1',`Exam_2` as 'Экзамен 2',`Exam_3` as 'Экзамен 3',`Exam_4` as 'Экзамен 4',`Exam_5` as 'Экзамен 5',`Offset_1` as 'Зачет 1',`Offset_2` as 'Зачет 2',`Offset_3` as 'Зачет 3',`Offset_4` as 'Зачет 4',`Offset_5` as 'Зачет 5'";
		public Form1()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			
		}

		private void RefreshDataGrid()
		{
			
			string queryString = $"select " + query + $"from Students";
			SQLiteCommand command = new SQLiteCommand(queryString, database.getConnection());
			
			database.openConnection();
			DataTable dt = new DataTable();
			SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			database.closeConnection();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			RefreshDataGrid();
		}


		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;

			if (e.RowIndex >= 0)
			{
				
				if (dataGridView1.Columns.Count > 3)
                {
					DataGridViewRow row = dataGridView1.Rows[selectedRow];
					textBox_id.Text = row.Cells[0].Value.ToString();
					textBox_nGroup.Text = row.Cells[1].Value.ToString();
					textBox_FIO.Text = row.Cells[2].Value.ToString();
					textBox_exam1.Text = row.Cells[3].Value.ToString();
					textBox_exam2.Text = row.Cells[4].Value.ToString();
					textBox_exam3.Text = row.Cells[5].Value.ToString();
					textBox_exam4.Text = row.Cells[6].Value.ToString();
					textBox_exam5.Text = row.Cells[7].Value.ToString();
					textBox_offset1.Text = row.Cells[8].Value.ToString();
					textBox_offset2.Text = row.Cells[9].Value.ToString();
					textBox_offset3.Text = row.Cells[10].Value.ToString();
					textBox_offset4.Text = row.Cells[11].Value.ToString();
					textBox_offset5.Text = row.Cells[12].Value.ToString();
				}
				
			}
		}


		private void Button_update_Click(object sender, EventArgs e)
		{
			RefreshDataGrid();
		}

		private void button_new_Click(object sender, EventArgs e)
		{
			Add_Form addfrm = new Add_Form();
			addfrm.Show();
			RefreshDataGrid();
		}

		private void Search()
		{

			string searchString = $"SELECT" + query + $"FROM Students WHERE 'Group' || Full_name || Exam_1 || Exam_2 || Exam_3 || Exam_4 || Exam_5 || Offset_1 || Offset_2 || Offset_3 || Offset_4 || Offset_5 like '%" + textBox_search.Text + "%'";
			SQLiteCommand com = new SQLiteCommand(searchString, database.getConnection());
			database.openConnection();
			DataTable dt = new DataTable();
			SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;

			database.closeConnection();
		}
		
		private void textBox_search_TextChanged(object sender, EventArgs e)
		{
			Search();
		}


		private void deleteRow()
		{
			int index = dataGridView1.CurrentCell.RowIndex;
			var id = textBox_id.Text;
			var deleteQuery = $"delete from Students where Student_id = {id}";
			var command = new SQLiteCommand(deleteQuery, database.getConnection());
			database.openConnection();
			command.ExecuteNonQuery();
			
			database.closeConnection();
		}


		private void button_delete_Click(object sender, EventArgs e)
		{
			deleteRow();
			ClearFields();
			RefreshDataGrid();
		}


		private void Change()
		{
			var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
			database.openConnection();
			var id = textBox_id.Text;
			var nGroup = textBox_nGroup.Text;
			var FIO = textBox_FIO.Text;
			if (Add_Form.StringIsValid(FIO))
			{
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

				if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
				{
					if (int.TryParse(textBox_exam1.Text, out exam1) && int.TryParse(textBox_exam2.Text, out exam2) && int.TryParse(textBox_exam3.Text, out exam3)
					&& int.TryParse(textBox_exam4.Text, out exam4) && int.TryParse(textBox_exam5.Text, out exam5) && int.TryParse(textBox_offset1.Text, out offset1)
					&& int.TryParse(textBox_offset2.Text, out offset2) && int.TryParse(textBox_offset3.Text, out offset3) && int.TryParse(textBox_offset4.Text, out offset4)
					&& int.TryParse(textBox_offset5.Text, out offset5))
					{
						if (exam1 <= 100 && exam1 >= 0 && exam2 <= 100 && exam2 >= 0 && exam3 <= 100 && exam3 >= 0 && exam4 <= 100 && exam4 >= 0 && exam5 <= 100 && exam5 >= 0 && (offset1 == 1 || offset1 == 0) && (offset2 == 1 || offset2 == 0) && (offset3 == 1 || offset3 == 0) && (offset4 == 1 || offset4 == 0) && (offset5 == 1 || offset5 == 0))
						{
							var changeQuery = $"update Students set 'Group' = '{nGroup}', Full_name = '{FIO}', Exam_1 = '{exam1}', Exam_2 = '{exam2}', Exam_3 = '{exam3}', Exam_4 = '{exam4}', Exam_5 = '{exam5}', Offset_1 = '{offset1}', Offset_2 = '{offset2}', Offset_3 = '{offset3}', Offset_4 = '{offset4}', Offset_5 = '{offset5}' where Student_id = '{id}'";
							var command = new SQLiteCommand(changeQuery, database.getConnection());
							command.ExecuteNonQuery();
						}
						else MessageBox.Show("Результаты экзаменов и зачетов должны соответствовать диапазону!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else
				{
					MessageBox.Show("Результаты экзаменов и зачетов должны иметь числовой формат");
				}
				database.closeConnection();
			}
			else MessageBox.Show("Некорректное имя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}


		private void buttonChange_Click(object sender, EventArgs e)
		{
			Change();
			ClearFields();
			RefreshDataGrid();
		}

		private void ClearFields()
		{
			textBox_id.Text = "";
			textBox_nGroup.Text = "";
			textBox_FIO.Text = "";
			textBox_exam1.Text = "";
			textBox_exam2.Text = "";
			textBox_exam3.Text = "";
			textBox_exam4.Text = "";
			textBox_exam5.Text = "";
			textBox_offset1.Text = "";
			textBox_offset2.Text = "";
			textBox_offset3.Text = "";
			textBox_offset4.Text = "";
			textBox_offset5.Text = "";
		}

	
		private void NON()
		{

			string non = $"SELECT Student_id as 'Id', Full_name as 'ФИО',  COUNT(*) as 'Количество долгов' FROM (\n" +
			"SELECT Student_id, Full_name, COUNT(Exam_1) FROM Students GROUP BY Student_id HAVING Exam_1 < 50\n" +
			"UNION ALL\n" +
			"SELECT Student_id, Full_name, COUNT(Exam_2) FROM Students GROUP BY Student_id HAVING Exam_2 < 50\n" +
			"UNION ALL\n" +
			"SELECT Student_id, Full_name, COUNT(Exam_3) FROM Students GROUP BY Student_id HAVING Exam_3 < 50\n" +
			"UNION ALL\n" +
			"SELECT Student_id, Full_name, COUNT(Exam_4) FROM Students GROUP BY Student_id HAVING Exam_4 < 50\n" +
			"UNION ALL\n" +
			"SELECT Student_id, Full_name, COUNT(Exam_5) FROM Students GROUP BY Student_id HAVING Exam_5 < 50\n" +
			"UNION ALL\n" +
			"SELECT Student_id, Full_name, COUNT(Offset_1) FROM Students GROUP BY Student_id HAVING Offset_1 < 1\n" +
			"UNION ALL\n" +
			"SELECT Student_id, Full_name, COUNT(Offset_2) FROM Students GROUP BY Student_id HAVING Offset_2 < 1\n" +
			"UNION ALL\n" +
			"SELECT Student_id, Full_name, COUNT(Offset_3) FROM Students GROUP BY Student_id HAVING Offset_3 < 1\n" +
			"UNION ALL\n" +
			"SELECT Student_id, Full_name, COUNT(Offset_4) FROM Students GROUP BY Student_id HAVING Offset_4 < 1\n" +
			"UNION ALL\n" +
			"SELECT Student_id, Full_name, COUNT(Offset_5) FROM Students GROUP BY Student_id HAVING Offset_5 < 1\n" +
			") GROUP BY Student_id; ";
			SQLiteCommand com = new SQLiteCommand(non, database.getConnection());
			database.openConnection();
			DataTable dt = new DataTable();
			SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			database.closeConnection();
		}
		private void buttonNON_Click(object sender, EventArgs e)
		{
			NON();
			ClearFields();
		}


		private void SearchAndDel()
		{

			string del = $"DELETE FROM Students WHERE `Group` like '%" + textBox_del.Text + "%'";
			SQLiteCommand com = new SQLiteCommand(del, database.getConnection());
			database.openConnection();
			DataTable dt = new DataTable();
			SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			database.closeConnection();
		}

		private void buttonDel_Click(object sender, EventArgs e)
		{
			SearchAndDel();
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			SaveFileDialog savefile = new SaveFileDialog();
			savefile.DefaultExt = ".txt";
			savefile.Filter = "db|*.txt";
			if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK && savefile.FileName.Length > 0)
			{ 
				using (StreamWriter sw = new StreamWriter(savefile.FileName, true))
				{
					sw.WriteLine("\nПорядковый номер: " + textBox_id.Text);
					sw.WriteLine("Номер группы: " + textBox_nGroup.Text);
					sw.WriteLine("Полное имя: " + textBox_FIO.Text);
					sw.WriteLine("Экзамен 1: " + textBox_exam1.Text);
					sw.WriteLine("Экзамен 2: " + textBox_exam2.Text);
					sw.WriteLine("Экзамен 3: " + textBox_exam3.Text);
					sw.WriteLine("Экзамен 4: " + textBox_exam4.Text);
					sw.WriteLine("Экзамен 5: " + textBox_exam5.Text);
					sw.WriteLine("Зачет 1: " + textBox_offset1.Text);
					sw.WriteLine("Зачет 2: " + textBox_offset2.Text);
					sw.WriteLine("Зачет 3: " + textBox_offset3.Text);
					sw.WriteLine("Зачет 4: " + textBox_offset4.Text);
					sw.WriteLine("Зачет 5: " + textBox_offset5.Text);
					sw.Close();
				}
			}



		}
    }
}
