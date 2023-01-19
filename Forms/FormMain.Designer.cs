namespace cursedapp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridVertexes = new System.Windows.Forms.DataGridView();
            this.addVertexButton = new System.Windows.Forms.Button();
            this.deleteCityButton = new System.Windows.Forms.Button();
            this.buttonSolving = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVertexes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVertexes
            // 
            this.dataGridVertexes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridVertexes.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridVertexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVertexes.Location = new System.Drawing.Point(12, 82);
            this.dataGridVertexes.Name = "dataGridVertexes";
            this.dataGridVertexes.Size = new System.Drawing.Size(776, 356);
            this.dataGridVertexes.TabIndex = 0;
            this.dataGridVertexes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVertexes_CellEndEdit);
            // 
            // addVertexButton
            // 
            this.addVertexButton.Location = new System.Drawing.Point(542, 53);
            this.addVertexButton.Name = "addVertexButton";
            this.addVertexButton.Size = new System.Drawing.Size(113, 23);
            this.addVertexButton.TabIndex = 1;
            this.addVertexButton.Text = "Добавить город";
            this.addVertexButton.UseVisualStyleBackColor = true;
            this.addVertexButton.Click += new System.EventHandler(this.addVertexButton_Click);
            // 
            // deleteCityButton
            // 
            this.deleteCityButton.Location = new System.Drawing.Point(672, 53);
            this.deleteCityButton.Name = "deleteCityButton";
            this.deleteCityButton.Size = new System.Drawing.Size(116, 23);
            this.deleteCityButton.TabIndex = 2;
            this.deleteCityButton.Text = "Удалить город";
            this.deleteCityButton.UseVisualStyleBackColor = true;
            this.deleteCityButton.Click += new System.EventHandler(this.deleteCityButton_Click);
            // 
            // buttonSolving
            // 
            this.buttonSolving.Location = new System.Drawing.Point(12, 53);
            this.buttonSolving.Name = "buttonSolving";
            this.buttonSolving.Size = new System.Drawing.Size(113, 23);
            this.buttonSolving.TabIndex = 3;
            this.buttonSolving.Text = "Решение";
            this.buttonSolving.UseVisualStyleBackColor = true;
            this.buttonSolving.Click += new System.EventHandler(this.buttonSolving_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSolving);
            this.Controls.Add(this.deleteCityButton);
            this.Controls.Add(this.addVertexButton);
            this.Controls.Add(this.dataGridVertexes);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVertexes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVertexes;
        private System.Windows.Forms.Button addVertexButton;
        private System.Windows.Forms.Button deleteCityButton;
        private System.Windows.Forms.Button buttonSolving;
    }
}