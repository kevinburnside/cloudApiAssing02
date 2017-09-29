using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300454171_Burnside__ASS2
{
    public partial class Form1 : Form
    {
        private Tasks _tasks = new Tasks();

   

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text;
            string createdBy = createdByTxtBox.Text;
            var taskList = _tasks.FormatTasks(_tasks.ListTasks());

            _tasks.AddTask(description, createdBy);
            MessageBox.Show("Your entity has been added!");
            descriptionTextBox.Clear();
            createdByTxtBox.Clear();
            
            listOfTasksBox.Text = taskList.ToString();

            foreach (string task in taskList)
            {
                listOfTasksBox.Items.Add(task.ToString());
            }
        }

        private void ListOfTasksBox()
        {
            InitializeComponent();
            var taskList = _tasks.FormatTasks(_tasks.ListTasks());
            foreach (string task in taskList)
            {
                MessageBox.Show(task);
            }
           // listOfTasksBox.Text = _tasks.FormatTasks(_tasks.ListTasks());

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var taskList = _tasks.FormatTasks(_tasks.ListTasks());
            listOfTasksBox.Text = taskList.ToString();

            foreach (string task in taskList)
            {                
                listOfTasksBox.Items.Add(task.ToString());                
            }
        }

        private void ModifytaskButton_Click(object sender, EventArgs e)
        {
            var selectedEntity = listOfTasksBox.SelectedItem.ToString();
            var entityId = Convert.ToInt64(selectedEntity);

            _tasks.MarkDone(entityId);
            MessageBox.Show(entityId + " " + "has been marked as done");

        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            var selectedEntity = listOfTasksBox.SelectedItem.ToString();
            var entityId = Convert.ToInt64(selectedEntity);
            var taskList = _tasks.FormatTasks(_tasks.ListTasks());

            _tasks.DeleteTask(entityId);
            MessageBox.Show(entityId + " " + "has been deleted");

            listOfTasksBox.Text = taskList.ToString();

            foreach (string task in taskList)
            {
                listOfTasksBox.Items.Add(task.ToString());
            }
        }
    }
}
