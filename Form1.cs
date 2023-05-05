using System;
using System.Collections.Generic;  
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaniBogat
{
	public partial class Form1 : Form
	{
		//1.Connrct to BD 
		string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Quizz11d.mdf;Integrated Security=True;Connect Timeout=30";
		SqlConnection connectToDb;
		//2.Command
		SqlCommand command;
		//3.Read the Reader
		SqlDataReader reader;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			connectToDb = new SqlConnection(connstr);
			connectToDb.Open();
			MessageBox.Show("OK!");
			string query = "Select* from Questions";
			command = new SqlCommand(query, connectToDb);
			reader = command.ExecuteReader();
			reader.Read();
			LoadRecord();
			

		}
		public void LoadRecord()
		{
			label1.BackColor = SystemColors.Window;
			label1.ForeColor = Color.Black;
			label2.BackColor = SystemColors.Window;
			label2.ForeColor = Color.Black;
			label3.BackColor = SystemColors.Window;
			label3.ForeColor = Color.Black;
			label4.BackColor = SystemColors.Window;
			label4.ForeColor = Color.Black;
			label5.BackColor = SystemColors.Window;
			label5.ForeColor = Color.Black;
			if (reader.Read())
			{
				label1.Text = reader[1].ToString();
				label2.Text = reader[2].ToString();
				label3.Text = reader[3].ToString();
				label4.Text = reader[4].ToString();
				label5.Text = reader[5].ToString();
			}
			else
			{
				MessageBox.Show("Свършиха въпросите.");

			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
			if (label2.Text == reader[6].ToString())
			{
				LoadRecord();
			}
			else
			{
				label2.BackColor = Color.Red;
				MessageBox.Show("Играта приключи!");
				this.Close();
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{
			if (label3.Text == reader[6].ToString())
			{
				LoadRecord();
			}
			else
			{
				label3.BackColor = Color.Red;
				MessageBox.Show("Играта приключи!");
				this.Close();
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{
			if (label4.Text == reader[6].ToString())
			{
				LoadRecord();
			}
			else
			{
				label4.BackColor = Color.Red;
				MessageBox.Show("Играта приключи!");
				this.Close();
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{
			if (label5.Text == reader[6].ToString())
			{
				LoadRecord();
			}
			else
			{
				label5.BackColor = Color.Red;
				MessageBox.Show("Играта приключи!");
				this.Close();
			}
		}
	}
}

