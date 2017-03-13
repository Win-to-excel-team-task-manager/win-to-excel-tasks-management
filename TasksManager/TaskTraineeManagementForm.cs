using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TasksManager.BAL;
using TasksManager.DAL;
using TasksManager.Entities;
using TasksManager.Helpers;

namespace TasksManager
{
    public partial class TaskTraineeManagementForm : Form
    {
        TaskProjectBLO taskProjectBLO;
        TraineeBLO traineeBLO;
        TaskTraineeBLO traineeTaskBLO;
        public TaskTraineeManagementForm()
        {
            InitializeComponent();
            dataGridViewTaskTranees.ShowRowErrors = true;
            dataGridViewTaskTranees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

        }

        private void listBoxTrainnes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creat BLO Instances
            taskProjectBLO = new TaskProjectBLO();
            traineeBLO = new TraineeBLO();

            // Load Tasks Project
            listBoxTaskProject.DataSource = taskProjectBLO.GetData();

            // Load Trainee 
            traineeBindingSource.DataSource = traineeBLO.GetData();
            this.showTainneeError();




        }

        /// <summary>
        /// Show Trainee Error
        /// </summary>
        private void showTainneeError()
        {
            foreach (DataGridViewRow row in dataGridViewTrainees.Rows)
            {
                Trainee Trainee = (Trainee)row.DataBoundItem;
                if(Trainee != null)
                if (Trainee.Errors.Count() > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                        row.ErrorText = "Erreur";
                        
                    //foreach (DataGridViewCell cell in row.Cells)
                    //{
                    //    if (yourCondition) cell.ErrorText = yourErrorText;
                    //}
                    }

            }
        }

        /// <summary>
        /// Show TaskTrainee Error
        /// </summary>
        private void showTaskTainneeError()
        {
            foreach (DataGridViewRow row in dataGridViewTaskTranees.Rows)
            {
                TaskTrainee TaskTrainee = (TaskTrainee)row.DataBoundItem;
                if (TaskTrainee != null)
                    if (TaskTrainee.Errors.Count() > 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.ToolTipText = TaskTrainee.ErrorsMessage();
                           // if (yourCondition) cell.ErrorText = yourErrorText;
                        }
                    }

            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        

        private void traineeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
           
        }

        private void taskTrainneeBindingSource_PositionChanged(object sender, EventArgs e)
        {
            TaskTrainee taskTrainee =(TaskTrainee) TaskTraineeBindingSource.Current;
            if(taskTrainee != null)
            listBoxTaskProject.SelectedValue = taskTrainee.Title;

        }

        private void traineeBindingSource_PositionChanged(object sender, EventArgs e)
        {
            TaskTraineeBindingSource.Clear();

            Trainee trainee = (Trainee)traineeBindingSource.Current;
            if (trainee != null)
            {
                traineeTaskBLO = new TaskTraineeBLO(trainee.FileName);

                TaskTraineeBindingSource.DataSource = traineeTaskBLO.GetData();
                showTaskTainneeError();





            }
        }

        private void listBoxTaskProject_Click(object sender, EventArgs e)
        {
            TaskProject taskProject =(TaskProject) listBoxTaskProject.SelectedItem;
            if (taskProject != null)
                taskProjectShowUC1.ShowTaskProject(taskProject);
        }

        private void dataGridViewTrainees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void traineeBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
           
              
                    
        }

        private void dataGridViewTrainees_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dataGridViewTrainees_DataSourceChanged(object sender, EventArgs e)
        {

        }
    }
}
