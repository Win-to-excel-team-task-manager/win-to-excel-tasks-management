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
    public partial class Form1 : Form
    {
        TaskProjectBLO taskProjectBLO;
        TraineeBLO traineeBLO;
        TraineeTaskBLO traineeTaskBLO;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void listBoxTrainnes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taskProjectBLO = new TaskProjectBLO();
            traineeBLO = new TraineeBLO();

            // Load Tasks Project
            listBoxTaskProject.DataSource = taskProjectBLO.GetData();

            // Load Trainee 
            listBoxTrainnes.DataSource = traineeBLO.GetData();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void listBoxTrainnes_Click(object sender, EventArgs e)
        {
           
 
                Trainee trainee = (Trainee)listBoxTrainnes.SelectedItem;
                traineeTaskBLO = new TraineeTaskBLO(trainee.FileName);
                dataGridView1.DataSource = traineeTaskBLO.GetData();
             

                MessageBox.Show(ShowMessage.GetMassageAsString());
             
          

        }
    }
}
