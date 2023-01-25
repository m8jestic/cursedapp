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
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.edgeButton = new System.Windows.Forms.Button();
            this.vertexButton = new System.Windows.Forms.Button();
            this.mouseButton = new System.Windows.Forms.Button();
            this.cloth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVertexes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloth)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVertexes
            // 
            this.dataGridVertexes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridVertexes.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridVertexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVertexes.Location = new System.Drawing.Point(12, 451);
            this.dataGridVertexes.Name = "dataGridVertexes";
            this.dataGridVertexes.Size = new System.Drawing.Size(984, 146);
            this.dataGridVertexes.TabIndex = 0;
            this.dataGridVertexes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVertexes_CellEndEdit);
            // 
            // addVertexButton
            // 
            this.addVertexButton.Location = new System.Drawing.Point(761, 422);
            this.addVertexButton.Name = "addVertexButton";
            this.addVertexButton.Size = new System.Drawing.Size(113, 23);
            this.addVertexButton.TabIndex = 1;
            this.addVertexButton.Text = "Добавить город";
            this.addVertexButton.UseVisualStyleBackColor = true;
            this.addVertexButton.Click += new System.EventHandler(this.addVertexButton_Click);
            // 
            // deleteCityButton
            // 
            this.deleteCityButton.Location = new System.Drawing.Point(880, 422);
            this.deleteCityButton.Name = "deleteCityButton";
            this.deleteCityButton.Size = new System.Drawing.Size(116, 23);
            this.deleteCityButton.TabIndex = 2;
            this.deleteCityButton.Text = "Удалить город";
            this.deleteCityButton.UseVisualStyleBackColor = true;
            this.deleteCityButton.Click += new System.EventHandler(this.deleteCityButton_Click);
            // 
            // buttonSolving
            // 
            this.buttonSolving.Location = new System.Drawing.Point(12, 422);
            this.buttonSolving.Name = "buttonSolving";
            this.buttonSolving.Size = new System.Drawing.Size(113, 23);
            this.buttonSolving.TabIndex = 3;
            this.buttonSolving.Text = "Решение";
            this.buttonSolving.UseVisualStyleBackColor = true;
            this.buttonSolving.Click += new System.EventHandler(this.buttonSolving_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.BackgroundImage = global::cursedapp.Properties.Resources._1483063;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearButton.Location = new System.Drawing.Point(567, 410);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(35, 35);
            this.clearButton.TabIndex = 9;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.BackgroundImage = global::cursedapp.Properties.Resources.Transparent_X;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Location = new System.Drawing.Point(526, 410);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(35, 35);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // edgeButton
            // 
            this.edgeButton.BackgroundImage = global::cursedapp.Properties.Resources.png_transparent_black_vertical_line_rectangle_horizontal_line_angle_black_internet;
            this.edgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edgeButton.Location = new System.Drawing.Point(485, 410);
            this.edgeButton.Name = "edgeButton";
            this.edgeButton.Size = new System.Drawing.Size(35, 35);
            this.edgeButton.TabIndex = 7;
            this.edgeButton.UseVisualStyleBackColor = true;
            this.edgeButton.Click += new System.EventHandler(this.edgeButton_Click);
            // 
            // vertexButton
            // 
            this.vertexButton.BackgroundImage = global::cursedapp.Properties.Resources._174;
            this.vertexButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vertexButton.Location = new System.Drawing.Point(444, 410);
            this.vertexButton.Name = "vertexButton";
            this.vertexButton.Size = new System.Drawing.Size(35, 35);
            this.vertexButton.TabIndex = 6;
            this.vertexButton.UseVisualStyleBackColor = true;
            this.vertexButton.Click += new System.EventHandler(this.vertexButton_Click);
            // 
            // mouseButton
            // 
            this.mouseButton.BackgroundImage = global::cursedapp.Properties.Resources.istockphoto_969119274_612x612;
            this.mouseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mouseButton.Location = new System.Drawing.Point(403, 410);
            this.mouseButton.Name = "mouseButton";
            this.mouseButton.Size = new System.Drawing.Size(35, 35);
            this.mouseButton.TabIndex = 5;
            this.mouseButton.UseVisualStyleBackColor = true;
            this.mouseButton.Click += new System.EventHandler(this.MouseButton_Click);
            // 
            // cloth
            // 
            this.cloth.Location = new System.Drawing.Point(12, 1);
            this.cloth.Name = "cloth";
            this.cloth.Size = new System.Drawing.Size(984, 403);
            this.cloth.TabIndex = 4;
            this.cloth.TabStop = false;
            this.cloth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cloth_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 609);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.edgeButton);
            this.Controls.Add(this.vertexButton);
            this.Controls.Add(this.mouseButton);
            this.Controls.Add(this.cloth);
            this.Controls.Add(this.buttonSolving);
            this.Controls.Add(this.deleteCityButton);
            this.Controls.Add(this.addVertexButton);
            this.Controls.Add(this.dataGridVertexes);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVertexes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVertexes;
        private System.Windows.Forms.Button addVertexButton;
        private System.Windows.Forms.Button deleteCityButton;
        private System.Windows.Forms.Button buttonSolving;
        private System.Windows.Forms.PictureBox cloth;
        private System.Windows.Forms.Button mouseButton;
        private System.Windows.Forms.Button vertexButton;
        private System.Windows.Forms.Button edgeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
    }
}