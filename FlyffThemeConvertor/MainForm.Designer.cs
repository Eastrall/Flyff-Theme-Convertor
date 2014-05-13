namespace FlyffThemeConverter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.INPUT_FOLDER = new System.Windows.Forms.TextBox();
            this.SELECT_INPUT_FOLDER = new System.Windows.Forms.Button();
            this.SELECT_OUTPUT_FOLDER = new System.Windows.Forms.Button();
            this.OUTPUT_FOLDER = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.START = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PROGRESSION_LABEL = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Flyff default theme folder :";
            // 
            // INPUT_FOLDER
            // 
            this.INPUT_FOLDER.Location = new System.Drawing.Point(16, 41);
            this.INPUT_FOLDER.Name = "INPUT_FOLDER";
            this.INPUT_FOLDER.ReadOnly = true;
            this.INPUT_FOLDER.Size = new System.Drawing.Size(422, 26);
            this.INPUT_FOLDER.TabIndex = 1;
            // 
            // SELECT_INPUT_FOLDER
            // 
            this.SELECT_INPUT_FOLDER.Location = new System.Drawing.Point(444, 41);
            this.SELECT_INPUT_FOLDER.Name = "SELECT_INPUT_FOLDER";
            this.SELECT_INPUT_FOLDER.Size = new System.Drawing.Size(84, 26);
            this.SELECT_INPUT_FOLDER.TabIndex = 2;
            this.SELECT_INPUT_FOLDER.Text = "...";
            this.SELECT_INPUT_FOLDER.UseVisualStyleBackColor = true;
            this.SELECT_INPUT_FOLDER.Click += new System.EventHandler(this.SELECT_INPUT_FOLDER_Click);
            // 
            // SELECT_OUTPUT_FOLDER
            // 
            this.SELECT_OUTPUT_FOLDER.Enabled = false;
            this.SELECT_OUTPUT_FOLDER.Location = new System.Drawing.Point(444, 118);
            this.SELECT_OUTPUT_FOLDER.Name = "SELECT_OUTPUT_FOLDER";
            this.SELECT_OUTPUT_FOLDER.Size = new System.Drawing.Size(84, 26);
            this.SELECT_OUTPUT_FOLDER.TabIndex = 4;
            this.SELECT_OUTPUT_FOLDER.Text = "...";
            this.SELECT_OUTPUT_FOLDER.UseVisualStyleBackColor = true;
            this.SELECT_OUTPUT_FOLDER.Click += new System.EventHandler(this.SELECT_OUTPUT_FOLDER_Click);
            // 
            // OUTPUT_FOLDER
            // 
            this.OUTPUT_FOLDER.Location = new System.Drawing.Point(16, 118);
            this.OUTPUT_FOLDER.Name = "OUTPUT_FOLDER";
            this.OUTPUT_FOLDER.ReadOnly = true;
            this.OUTPUT_FOLDER.Size = new System.Drawing.Size(422, 26);
            this.OUTPUT_FOLDER.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select output folder :";
            // 
            // START
            // 
            this.START.Enabled = false;
            this.START.Location = new System.Drawing.Point(407, 283);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(121, 30);
            this.START.TabIndex = 6;
            this.START.Text = "Convert";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Progression : ";
            // 
            // PROGRESSION_LABEL
            // 
            this.PROGRESSION_LABEL.AutoSize = true;
            this.PROGRESSION_LABEL.Location = new System.Drawing.Point(132, 170);
            this.PROGRESSION_LABEL.Name = "PROGRESSION_LABEL";
            this.PROGRESSION_LABEL.Size = new System.Drawing.Size(0, 20);
            this.PROGRESSION_LABEL.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 204);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(512, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 325);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.PROGRESSION_LABEL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.START);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SELECT_OUTPUT_FOLDER);
            this.Controls.Add(this.OUTPUT_FOLDER);
            this.Controls.Add(this.SELECT_INPUT_FOLDER);
            this.Controls.Add(this.INPUT_FOLDER);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flyff Theme Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INPUT_FOLDER;
        private System.Windows.Forms.Button SELECT_INPUT_FOLDER;
        private System.Windows.Forms.Button SELECT_OUTPUT_FOLDER;
        private System.Windows.Forms.TextBox OUTPUT_FOLDER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PROGRESSION_LABEL;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

