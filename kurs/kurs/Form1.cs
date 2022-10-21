using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kurs
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            passField.UseSystemPasswordChar = true;
            this.passField.AutoSize = false; //авторазмер офф
            this.passField.Size = new Size(this.passField.Size.Width, 44); //размер одинаковый
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close(); //закрытие по нажатию
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passField.UseSystemPasswordChar = false; //если галочки нет то -
            }
            else
            {
                passField.UseSystemPasswordChar = true; // если галочка есть то +
            }
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            db.openConn();

            
            MySqlCommand command = new MySqlCommand($"SELECT * FROM T_Acc WHERE log_acc='{loginUser}' AND pass_acc ='{passUser}'", db.getConn()); 
            

            adapter.SelectCommand = command;
            adapter.Fill(table); // можем обратиться к каждому элементу
            db.closeConn();

            if (table.Rows.Count > 0) // проверка наличий записей 
                MessageBox.Show("Успешно!");
            else
                MessageBox.Show("Неверные данные!");
        }
    }
}
