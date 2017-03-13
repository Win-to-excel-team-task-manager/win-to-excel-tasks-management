namespace TasksManager.Presentation
{
    partial class TaskProjectShowUC
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label competenceLevelLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label phasesLabel;
            System.Windows.Forms.Label projectLabel;
            System.Windows.Forms.Label technicalNoteLabel;
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.competenceLevelTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.phasesTextBox = new System.Windows.Forms.TextBox();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.technicalNoteTextBox = new System.Windows.Forms.TextBox();
            this.taskProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codeLabel = new System.Windows.Forms.Label();
            competenceLevelLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            phasesLabel = new System.Windows.Forms.Label();
            projectLabel = new System.Windows.Forms.Label();
            technicalNoteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskProjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(3, 9);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(35, 13);
            codeLabel.TabIndex = 1;
            codeLabel.Text = "Code:";
            // 
            // competenceLevelLabel
            // 
            competenceLevelLabel.AutoSize = true;
            competenceLevelLabel.Location = new System.Drawing.Point(3, 35);
            competenceLevelLabel.Name = "competenceLevelLabel";
            competenceLevelLabel.Size = new System.Drawing.Size(99, 13);
            competenceLevelLabel.TabIndex = 3;
            competenceLevelLabel.Text = "Competence Level:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 61);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // phasesLabel
            // 
            phasesLabel.AutoSize = true;
            phasesLabel.Location = new System.Drawing.Point(3, 113);
            phasesLabel.Name = "phasesLabel";
            phasesLabel.Size = new System.Drawing.Size(45, 13);
            phasesLabel.TabIndex = 9;
            phasesLabel.Text = "Phases:";
            // 
            // projectLabel
            // 
            projectLabel.AutoSize = true;
            projectLabel.Location = new System.Drawing.Point(3, 139);
            projectLabel.Name = "projectLabel";
            projectLabel.Size = new System.Drawing.Size(43, 13);
            projectLabel.TabIndex = 11;
            projectLabel.Text = "Project:";
            // 
            // technicalNoteLabel
            // 
            technicalNoteLabel.AutoSize = true;
            technicalNoteLabel.Location = new System.Drawing.Point(3, 165);
            technicalNoteLabel.Name = "technicalNoteLabel";
            technicalNoteLabel.Size = new System.Drawing.Size(83, 13);
            technicalNoteLabel.TabIndex = 13;
            technicalNoteLabel.Text = "Technical Note:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskProjectBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(108, 6);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(154, 20);
            this.codeTextBox.TabIndex = 2;
            // 
            // competenceLevelTextBox
            // 
            this.competenceLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskProjectBindingSource, "CompetenceLevel", true));
            this.competenceLevelTextBox.Location = new System.Drawing.Point(108, 32);
            this.competenceLevelTextBox.Name = "competenceLevelTextBox";
            this.competenceLevelTextBox.Size = new System.Drawing.Size(46, 20);
            this.competenceLevelTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskProjectBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(108, 58);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(154, 46);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // phasesTextBox
            // 
            this.phasesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskProjectBindingSource, "Phases", true));
            this.phasesTextBox.Location = new System.Drawing.Point(108, 110);
            this.phasesTextBox.Name = "phasesTextBox";
            this.phasesTextBox.Size = new System.Drawing.Size(154, 20);
            this.phasesTextBox.TabIndex = 10;
            // 
            // projectTextBox
            // 
            this.projectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskProjectBindingSource, "Project", true));
            this.projectTextBox.Location = new System.Drawing.Point(108, 136);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(154, 20);
            this.projectTextBox.TabIndex = 12;
            // 
            // technicalNoteTextBox
            // 
            this.technicalNoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskProjectBindingSource, "TechnicalNote", true));
            this.technicalNoteTextBox.Location = new System.Drawing.Point(108, 162);
            this.technicalNoteTextBox.Name = "technicalNoteTextBox";
            this.technicalNoteTextBox.Size = new System.Drawing.Size(154, 20);
            this.technicalNoteTextBox.TabIndex = 14;
            // 
            // taskProjectBindingSource
            // 
            this.taskProjectBindingSource.DataSource = typeof(TasksManager.Entities.TaskProject);
            // 
            // TaskProjectShowUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(competenceLevelLabel);
            this.Controls.Add(this.competenceLevelTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(phasesLabel);
            this.Controls.Add(this.phasesTextBox);
            this.Controls.Add(projectLabel);
            this.Controls.Add(this.projectTextBox);
            this.Controls.Add(technicalNoteLabel);
            this.Controls.Add(this.technicalNoteTextBox);
            this.Name = "TaskProjectShowUC";
            this.Size = new System.Drawing.Size(269, 191);
            ((System.ComponentModel.ISupportInitialize)(this.taskProjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource taskProjectBindingSource;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox competenceLevelTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox phasesTextBox;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.TextBox technicalNoteTextBox;
    }
}
