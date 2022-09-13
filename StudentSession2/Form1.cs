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

	enum RowState
	{
		Existed,
		New,
		Modified,
		ModifiedNew,
		Deleted
	}

	public partial class Form1 : Form
	{
		DataBase database = new DataBase();
		
		int selectedRow;
		public Form1()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			
		}

		private void CreateColoumns()
		{
		   
			dataGridView1.Columns.Add("id", "id");
			dataGridView1.Columns.Add("nGroup", "Номер группы");
			dataGridView1.Columns.Add("FIO", "Ф.И.О");
			dataGridView1.Columns.Add("exam1", "Экзамен1");
			dataGridView1.Columns.Add("exam2", "Экзамен2");
			dataGridView1.Columns.Add("exam3", "Экзамен3");
			dataGridView1.Columns.Add("exam4", "Экзамен4");
			dataGridView1.Columns.Add("exam5", "Экзамен5");
			dataGridView1.Columns.Add("offset1", "Зачет1");
			dataGridView1.Columns.Add("offset2", "Зачет2");
			dataGridView1.Columns.Add("offset3", "Зачет3");
			dataGridView1.Columns.Add("offset4", "Зачет4");
			dataGridView1.Columns.Add("offset5", "Зачет5");
			dataGridView1.Columns.Add(".", String.Empty);
		}

		private void ReadSingRow(DataGridView dgw, IDataRecord record)
		{
			dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetInt32(6), record.GetInt32(7), record.GetInt32(8), record.GetInt32(9), record.GetInt32(10), record.GetInt32(11), record.GetInt32(12));
		}

		private void RefreshDataGrid(DataGridView dgw)
		{
			dgw.Rows.Clear();
			
			string queryString = $"SELECT `Student_id`,`Group`,`Full_name`, `Exam_1`,`Exam_2`,`Exam_3`,`Exam_4`,`Exam_5`,`Offset_1`,`Offset_2`,`Offset_3`,`Offset_4`,`Offset_5` FROM Students";
			SQLiteCommand command = new SQLiteCommand(queryString, database.getConnection());
			
			database.openConnection();
			SQLiteDataReader reader = command.ExecuteReader();

			while(reader.Read())
			{
				ReadSingRow(dgw, reader);
			}
			reader.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			CreateColoumns();
			RefreshDataGrid(dataGridView1);
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;

			if(e.RowIndex >= 0)
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

		private void Button_update_Click(object sender, EventArgs e)
		{
			RefreshDataGrid(dataGridView1);
		}

		private void button_new_Click(object sender, EventArgs e)
		{
			Add_Form addfrm = new Add_Form();
			addfrm.Show();
		}

		private void Search(DataGridView dgw)
		{
			dgw.Rows.Clear();

			string searchString = $"SELECT `Student_id`,`Group`,`Full_name`, `Exam_1`,`Exam_2`,`Exam_3`,`Exam_4`,`Exam_5`,`Offset_1`,`Offset_2`,`Offset_3`,`Offset_4`,`Offset_5` FROM Students WHERE 'Group' || Full_name || Exam_1 || Exam_2 || Exam_3 || Exam_4 || Exam_5 || Offset_1 || Offset_2 || Offset_3 || Offset_4 || Offset_5 like '%" + textBox_search.Text + "%'";
			SQLiteCommand com = new SQLiteCommand(searchString, database.getConnection());
			database.openConnection();
			SQLiteDataReader read = com.ExecuteReader();

			while(read.Read())
			{
				ReadSingRow(dgw, read);
			}
			read.Close();
		}
		
		private void textBox_search_TextChanged(object sender, EventArgs e)
		{
			Search(dataGridView1);
		}


		private void deleteRow()
		{
			int index = dataGridView1.CurrentCell.RowIndex;

			dataGridView1.Rows[index].Visible = false;

			if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
			{
				dataGridView1.Rows[index].Cells[12].Value = RowState.Deleted;
				return;
			}
			dataGridView1.Rows[index].Cells[12].Value = RowState.Deleted;
		}

		private void UpDate()
		{
			database.openConnection();
			for(int index = 0; index < dataGridView1.Rows.Count; index++)
			{
				var rowState = (RowState)dataGridView1.Rows[index].Cells[12].Value;

				if(rowState == RowState.Existed)
				{
					continue;
				}
				if(rowState == RowState.Deleted)
				{
					var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
					var deleteQuery = $"delete from Students where Student_id = {id}";
					var command = new SQLiteCommand(deleteQuery, database.getConnection());
					command.ExecuteNonQuery();
				}
				if(rowState != RowState.Modified)
				{
					var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
					var nGroup = dataGridView1.Rows[index].Cells[1].Value.ToString();
					var FIO = dataGridView1.Rows[index].Cells[2].Value.ToString();
					var exam1 = dataGridView1.Rows[index].Cells[3].Value.ToString();
					var exam2 = dataGridView1.Rows[index].Cells[4].Value.ToString();
					var exam3 = dataGridView1.Rows[index].Cells[5].Value.ToString();
					var exam4 = dataGridView1.Rows[index].Cells[6].Value.ToString();
					var exam5 = dataGridView1.Rows[index].Cells[7].Value.ToString();
					var offset1 = dataGridView1.Rows[index].Cells[8].Value.ToString();
					var offset2 = dataGridView1.Rows[index].Cells[9].Value.ToString();
					var offset3 = dataGridView1.Rows[index].Cells[10].Value.ToString();
					var offset4 = dataGridView1.Rows[index].Cells[11].Value.ToString();
					var offset5 = dataGridView1.Rows[index].Cells[12].Value.ToString();

					var changeQuery = $"update Students set 'Group' = '{nGroup}', Full_name = '{FIO}', Exam_1 = '{exam1}', Exam_2 = '{exam2}', Exam_3 = '{exam3}', Exam_4 = '{exam4}', Exam_5 = '{exam5}', Offset_1 = '{offset1}', Offset_2 = '{offset2}', Offset_3 = '{offset3}', Offset_4 = '{offset4}', Offset_5 = '{offset5}' where Student_id = '{id}'"; 
					var command = new SQLiteCommand(changeQuery, database.getConnection());
					command.ExecuteNonQuery(); 
				}
			}
			database.closeConnection();
		}

		private void button_delete_Click(object sender, EventArgs e)
		{
			deleteRow();
			ClearFields();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			UpDate();
		}

		private void Change()
		{
			var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

			var id = textBox_id.Text;
			var nGroup = textBox_nGroup.Text;
			var FIO = textBox_FIO.Text;
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
						dataGridView1.Rows[selectedRowIndex].SetValues(id, nGroup, FIO, exam1, exam2, exam3, exam4, exam5, offset1, offset2, offset3, offset4, offset5);
						dataGridView1.Rows[selectedRowIndex].Cells[13].Value = RowState.Modified;
					}
					else MessageBox.Show("Результаты экзаменов и зачетов должны соответствовать диапазону!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Результаты экзаменов и зачетов должны иметь числовой формат");
			}
		}


		private void buttonChange_Click(object sender, EventArgs e)
		{
			Change();
			ClearFields();
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void textBox_offset5_TextChanged(object sender, EventArgs e)
		{

		}
		private void NON(DataGridView dgw)
		{
            dgw.Rows.Clear();
			string non = $"SELECT `Student_id`,`Group`,`Full_name`, `Exam_1`,`Exam_2`,`Exam_3`,`Exam_4`,`Exam_5`,`Offset_1`,`Offset_2`,`Offset_3`,`Offset_4`,`Offset_5` FROM Students WHERE Exam_1 < '50' OR Exam_2 < '50' OR Exam_3 < '50' OR Exam_4 < '50' OR Exam_5 < '50' OR Offset_1 != '1' OR Offset_2 != '1' OR Offset_3 != '1' OR Offset_4 != '1' OR Offset_5 != '1'";
			SQLiteCommand com = new SQLiteCommand(non, database.getConnection());
			database.openConnection();
			SQLiteDataReader read = com.ExecuteReader();

			while (read.Read())
			{
				ReadSingRow(dgw, read);
			}
			read.Close();
        }
		private void buttonNON_Click(object sender, EventArgs e)
		{
			NON(dataGridView1);
		}


		private void SearchAndDel(DataGridView dgw)
		{
			dgw.Rows.Clear();

			
			string del = $"DELETE FROM Students WHERE `Group` like '%" + textBox_del.Text + "%'";
			SQLiteCommand com = new SQLiteCommand(del, database.getConnection());
			database.openConnection();
			SQLiteDataReader read = com.ExecuteReader();

			while (read.Read())
			{
				ReadSingRow(dgw, read);
			}
			read.Close();
		}

		private void textBox_del_TextChanged(object sender, EventArgs e)
		{
		}

		private void buttonDel_Click(object sender, EventArgs e)
		{
			SearchAndDel(dataGridView1);
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
					sw.WriteLine("Порядковый номер: " + textBox_id.Text);
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

		private void textBox_exam1_TextChanged(object sender, EventArgs e)
		{

		}

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
