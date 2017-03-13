using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TasksManager.Entities;

namespace TasksManager.Presentation
{
    public partial class TaskProjectShowUC : UserControl
    {
     
        public TaskProjectShowUC()
        {
            InitializeComponent();
        }
        public void ShowTaskProject(TaskProject taskProject)
        {
            taskProjectBindingSource.Clear();
            taskProjectBindingSource.Add(taskProject);
        }
    }
}
