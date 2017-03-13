namespace TasksManager
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxTrainnes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskTrainneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxTasksProject = new System.Windows.Forms.GroupBox();
            this.listBoxTaskProject = new System.Windows.Forms.ListBox();
            this.taskProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTrainneeBindingSource)).BeginInit();
            this.groupBoxTasksProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxTrainnes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trainees";
            // 
            // listBoxTrainnes
            // 
            this.listBoxTrainnes.FormattingEnabled = true;
            this.listBoxTrainnes.Location = new System.Drawing.Point(6, 19);
            this.listBoxTrainnes.Name = "listBoxTrainnes";
            this.listBoxTrainnes.Size = new System.Drawing.Size(146, 342);
            this.listBoxTrainnes.TabIndex = 0;
            this.listBoxTrainnes.Click += new System.EventHandler(this.listBoxTrainnes_Click);
            this.listBoxTrainnes.SelectedIndexChanged += new System.EventHandler(this.listBoxTrainnes_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(178, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks of the trainee";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.numberOfDaysDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taskTrainneeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // numberOfDaysDataGridViewTextBoxColumn
            // 
            this.numberOfDaysDataGridViewTextBoxColumn.DataPropertyName = "NumberOfDays";
            this.numberOfDaysDataGridViewTextBoxColumn.HeaderText = "NumberOfDays";
            this.numberOfDaysDataGridViewTextBoxColumn.Name = "numberOfDaysDataGridViewTextBoxColumn";
            // 
            // taskTrainneeBindingSource
            // 
            this.taskTrainneeBindingSource.DataSource = typeof(TasksManager.Entities.TaskTrainee);
            // 
            // groupBoxTasksProject
            // 
            this.groupBoxTasksProject.Controls.Add(this.listBoxTaskProject);
            this.groupBoxTasksProject.Location = new System.Drawing.Point(738, 13);
            this.groupBoxTasksProject.Name = "groupBoxTasksProject";
            this.groupBoxTasksProject.Size = new System.Drawing.Size(361, 375);
            this.groupBoxTasksProject.TabIndex = 1;
            this.groupBoxTasksProject.TabStop = false;
            this.groupBoxTasksProject.Text = "Tasks";
            // 
            // listBoxTaskProject
            // 
            this.listBoxTaskProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTaskProject.FormattingEnabled = true;
            this.listBoxTaskProject.ItemHeight = 20;
            this.listBoxTaskProject.Location = new System.Drawing.Point(6, 20);
            this.listBoxTaskProject.Name = "listBoxTaskProject";
            this.listBoxTaskProject.Size = new System.Drawing.Size(349, 324);
            this.listBoxTaskProject.TabIndex = 1;
            // 
            // taskProjectBindingSource
            // 
            this.taskProjectBindingSource.DataSource = typeof(TasksManager.Entities.TaskProject);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 447);
            this.Controls.Add(this.groupBoxTasksProject);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTrainneeBindingSource)).EndInit();
            this.groupBoxTasksProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskProjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxTrainnes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxTasksProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource taskTrainneeBindingSource;
        private System.Windows.Forms.ListBox listBoxTaskProject;
        private System.Windows.Forms.BindingSource taskProjectBindingSource;
    }
}

