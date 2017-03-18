namespace TasksManager
{
    partial class TaskTraineeManagementForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTrainees = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDaysJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfTaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTaskTranees = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskTraineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxTasksProject = new System.Windows.Forms.GroupBox();
            this.listBoxTaskProject = new System.Windows.Forms.ListBox();
            this.taskProjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taskProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.taskProjectShowUC1 = new TasksManager.Presentation.TaskProjectShowUC();
            this.splitContainer_Trainee_Project = new System.Windows.Forms.SplitContainer();
            this.splitContainerTaskTrainee = new System.Windows.Forms.SplitContainer();
            this.splitContainer_TaskProject = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskTranees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTraineeBindingSource)).BeginInit();
            this.groupBoxTasksProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskProjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskProjectBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Trainee_Project)).BeginInit();
            this.splitContainer_Trainee_Project.Panel1.SuspendLayout();
            this.splitContainer_Trainee_Project.Panel2.SuspendLayout();
            this.splitContainer_Trainee_Project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTaskTrainee)).BeginInit();
            this.splitContainerTaskTrainee.Panel1.SuspendLayout();
            this.splitContainerTaskTrainee.Panel2.SuspendLayout();
            this.splitContainerTaskTrainee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_TaskProject)).BeginInit();
            this.splitContainer_TaskProject.Panel1.SuspendLayout();
            this.splitContainer_TaskProject.Panel2.SuspendLayout();
            this.splitContainer_TaskProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewTrainees);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 556);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trainees";
            // 
            // dataGridViewTrainees
            // 
            this.dataGridViewTrainees.AutoGenerateColumns = false;
            this.dataGridViewTrainees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.numberOfDaysJobDataGridViewTextBoxColumn,
            this.numberOfTaskDataGridViewTextBoxColumn});
            this.dataGridViewTrainees.DataSource = this.traineeBindingSource;
            this.dataGridViewTrainees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrainees.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTrainees.Name = "dataGridViewTrainees";
            this.dataGridViewTrainees.Size = new System.Drawing.Size(361, 537);
            this.dataGridViewTrainees.TabIndex = 0;
            this.dataGridViewTrainees.DataSourceChanged += new System.EventHandler(this.dataGridViewTrainees_DataSourceChanged);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 85;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 85;
            // 
            // numberOfDaysJobDataGridViewTextBoxColumn
            // 
            this.numberOfDaysJobDataGridViewTextBoxColumn.DataPropertyName = "NumberOfDaysJob";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numberOfDaysJobDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.numberOfDaysJobDataGridViewTextBoxColumn.HeaderText = "Days";
            this.numberOfDaysJobDataGridViewTextBoxColumn.Name = "numberOfDaysJobDataGridViewTextBoxColumn";
            this.numberOfDaysJobDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfDaysJobDataGridViewTextBoxColumn.Width = 35;
            // 
            // numberOfTaskDataGridViewTextBoxColumn
            // 
            this.numberOfTaskDataGridViewTextBoxColumn.DataPropertyName = "NumberOfTask";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numberOfTaskDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.numberOfTaskDataGridViewTextBoxColumn.HeaderText = "Tasks";
            this.numberOfTaskDataGridViewTextBoxColumn.Name = "numberOfTaskDataGridViewTextBoxColumn";
            this.numberOfTaskDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfTaskDataGridViewTextBoxColumn.Width = 40;
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(TasksManager.Entities.Trainee);
            this.traineeBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.traineeBindingSource_BindingComplete);
            this.traineeBindingSource.CurrentChanged += new System.EventHandler(this.traineeBindingSource_CurrentChanged);
            this.traineeBindingSource.PositionChanged += new System.EventHandler(this.traineeBindingSource_PositionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewTaskTranees);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 556);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks of the trainee";
            // 
            // dataGridViewTaskTranees
            // 
            this.dataGridViewTaskTranees.AutoGenerateColumns = false;
            this.dataGridViewTaskTranees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaskTranees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.numberOfDaysDataGridViewTextBoxColumn});
            this.dataGridViewTaskTranees.DataSource = this.TaskTraineeBindingSource;
            this.dataGridViewTaskTranees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTaskTranees.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTaskTranees.Name = "dataGridViewTaskTranees";
            this.dataGridViewTaskTranees.Size = new System.Drawing.Size(482, 537);
            this.dataGridViewTaskTranees.TabIndex = 0;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // numberOfDaysDataGridViewTextBoxColumn
            // 
            this.numberOfDaysDataGridViewTextBoxColumn.DataPropertyName = "NumberOfDays";
            this.numberOfDaysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.numberOfDaysDataGridViewTextBoxColumn.Name = "numberOfDaysDataGridViewTextBoxColumn";
            this.numberOfDaysDataGridViewTextBoxColumn.Width = 40;
            // 
            // TaskTraineeBindingSource
            // 
            this.TaskTraineeBindingSource.DataSource = typeof(TasksManager.Entities.TaskTrainee);
            this.TaskTraineeBindingSource.PositionChanged += new System.EventHandler(this.taskTrainneeBindingSource_PositionChanged);
            // 
            // groupBoxTasksProject
            // 
            this.groupBoxTasksProject.Controls.Add(this.listBoxTaskProject);
            this.groupBoxTasksProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTasksProject.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTasksProject.Name = "groupBoxTasksProject";
            this.groupBoxTasksProject.Size = new System.Drawing.Size(291, 370);
            this.groupBoxTasksProject.TabIndex = 1;
            this.groupBoxTasksProject.TabStop = false;
            this.groupBoxTasksProject.Text = "Tasks";
            // 
            // listBoxTaskProject
            // 
            this.listBoxTaskProject.DataSource = this.taskProjectBindingSource1;
            this.listBoxTaskProject.DisplayMember = "Code";
            this.listBoxTaskProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTaskProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTaskProject.FormattingEnabled = true;
            this.listBoxTaskProject.ItemHeight = 20;
            this.listBoxTaskProject.Location = new System.Drawing.Point(3, 16);
            this.listBoxTaskProject.Name = "listBoxTaskProject";
            this.listBoxTaskProject.Size = new System.Drawing.Size(285, 351);
            this.listBoxTaskProject.TabIndex = 1;
            this.listBoxTaskProject.ValueMember = "Code";
            this.listBoxTaskProject.Click += new System.EventHandler(this.listBoxTaskProject_Click);
            this.listBoxTaskProject.SelectedIndexChanged += new System.EventHandler(this.listBoxTaskProject_SelectedIndexChanged);
            // 
            // taskProjectBindingSource1
            // 
            this.taskProjectBindingSource1.DataSource = typeof(TasksManager.Entities.TaskProject);
            // 
            // taskProjectBindingSource
            // 
            this.taskProjectBindingSource.DataSource = typeof(TasksManager.Entities.TaskProject);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.taskProjectShowUC1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task Details";
            // 
            // taskProjectShowUC1
            // 
            this.taskProjectShowUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskProjectShowUC1.Location = new System.Drawing.Point(3, 16);
            this.taskProjectShowUC1.Name = "taskProjectShowUC1";
            this.taskProjectShowUC1.Size = new System.Drawing.Size(285, 163);
            this.taskProjectShowUC1.TabIndex = 0;
            // 
            // splitContainer_Trainee_Project
            // 
            this.splitContainer_Trainee_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Trainee_Project.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Trainee_Project.Name = "splitContainer_Trainee_Project";
            // 
            // splitContainer_Trainee_Project.Panel1
            // 
            this.splitContainer_Trainee_Project.Panel1.Controls.Add(this.splitContainerTaskTrainee);
            // 
            // splitContainer_Trainee_Project.Panel2
            // 
            this.splitContainer_Trainee_Project.Panel2.Controls.Add(this.splitContainer_TaskProject);
            this.splitContainer_Trainee_Project.Size = new System.Drawing.Size(1154, 556);
            this.splitContainer_Trainee_Project.SplitterDistance = 859;
            this.splitContainer_Trainee_Project.TabIndex = 3;
            // 
            // splitContainerTaskTrainee
            // 
            this.splitContainerTaskTrainee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTaskTrainee.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTaskTrainee.Name = "splitContainerTaskTrainee";
            // 
            // splitContainerTaskTrainee.Panel1
            // 
            this.splitContainerTaskTrainee.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainerTaskTrainee.Panel2
            // 
            this.splitContainerTaskTrainee.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerTaskTrainee.Size = new System.Drawing.Size(859, 556);
            this.splitContainerTaskTrainee.SplitterDistance = 367;
            this.splitContainerTaskTrainee.TabIndex = 0;
            // 
            // splitContainer_TaskProject
            // 
            this.splitContainer_TaskProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_TaskProject.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_TaskProject.Name = "splitContainer_TaskProject";
            this.splitContainer_TaskProject.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_TaskProject.Panel1
            // 
            this.splitContainer_TaskProject.Panel1.Controls.Add(this.groupBoxTasksProject);
            // 
            // splitContainer_TaskProject.Panel2
            // 
            this.splitContainer_TaskProject.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer_TaskProject.Size = new System.Drawing.Size(291, 556);
            this.splitContainer_TaskProject.SplitterDistance = 370;
            this.splitContainer_TaskProject.TabIndex = 0;
            // 
            // TaskTraineeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 556);
            this.Controls.Add(this.splitContainer_Trainee_Project);
            this.Name = "TaskTraineeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskTranees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTraineeBindingSource)).EndInit();
            this.groupBoxTasksProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskProjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskProjectBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer_Trainee_Project.Panel1.ResumeLayout(false);
            this.splitContainer_Trainee_Project.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Trainee_Project)).EndInit();
            this.splitContainer_Trainee_Project.ResumeLayout(false);
            this.splitContainerTaskTrainee.Panel1.ResumeLayout(false);
            this.splitContainerTaskTrainee.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTaskTrainee)).EndInit();
            this.splitContainerTaskTrainee.ResumeLayout(false);
            this.splitContainer_TaskProject.Panel1.ResumeLayout(false);
            this.splitContainer_TaskProject.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_TaskProject)).EndInit();
            this.splitContainer_TaskProject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTaskTranees;
        private System.Windows.Forms.GroupBox groupBoxTasksProject;
        private System.Windows.Forms.BindingSource TaskTraineeBindingSource;
        private System.Windows.Forms.ListBox listBoxTaskProject;
        private System.Windows.Forms.BindingSource taskProjectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewTrainees;
        private System.Windows.Forms.BindingSource traineeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDaysJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfTaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource taskProjectBindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Presentation.TaskProjectShowUC taskProjectShowUC1;
        private System.Windows.Forms.SplitContainer splitContainer_Trainee_Project;
        private System.Windows.Forms.SplitContainer splitContainerTaskTrainee;
        private System.Windows.Forms.SplitContainer splitContainer_TaskProject;
    }
}

