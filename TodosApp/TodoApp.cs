using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodosApp
{
    public partial class TodoApp : Form
    {
        SqlConnection conn;
        public TodoApp()
        {
            InitializeComponent();
            string connectionString = @"Data Source=ASUS-TUF-GAMING;Initial Catalog=My_DB;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            LoadTodos();
        }
        private void LoadTodos()
        {
            try
            {
                string query = $"select * from tblTodo;";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                todoCheckBox.Items.Clear();
                while (dr.Read())
                {
                    todoCheckBox.Items.Add(dr.GetString(1), dr.GetString(2).Equals("True"));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void AddTodo(object sender, EventArgs e)
        {
            if (todoBox.Text.Trim().Length == 0)
                return;
            try
            {
                string query = $@"Insert into tblTodo(title) values ('{todoBox.Text}');";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                todoBox.Text = "";
                conn.Close();
                LoadTodos();
            }
        }

        private void UpdateTodos(object sender, EventArgs e)
        {
            if (todoCheckBox.CheckedItems.Count == 0)
            { return; }
            try
            {
                conn.Open();
                string todos = "";
                foreach (string todo in todoCheckBox.CheckedItems)
                {
                    todos += $@"'{todo}',";
                }
                todos = "(" + todos.Substring(0, todos.Length-1) + ")";
                string query =
                    $@"update tblTodo " +
                    $@"set completed = 'True' " +
                    $@"where title in {todos};" +
                    $@"update tblTodo " +
                    $@"set completed = 'False' " +
                    $@"where title not in {todos};";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DeleteCompleted(object sender, EventArgs e)
        {
            if (todoCheckBox.CheckedItems.Count == 0)
            { return; }
            try
            {
                conn.Open();
                string todos = "";
                foreach (string todo in todoCheckBox.CheckedItems)
                {
                    todos += $@"'{todo}',";
                }
                todos = "(" + todos.Substring(0, todos.Length - 1) + ")";
                string query =
                    $@"delete tblTodo " +
                    $@"where title in {todos};";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
                LoadTodos();
            }
        }
    }
}
