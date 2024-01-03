namespace Tank
{
    partial class FormTanksCollections
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
            panel1 = new Panel();
            UpdateButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            InputNum = new TextBox();
            label1 = new Label();
            DrawTank = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DrawTank).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(InputNum);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(550, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 451);
            panel1.TabIndex = 0;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(10, 241);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(229, 37);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Обновить коллекцию";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += ButtonRefreshCollection_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(10, 176);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(229, 37);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить технику";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += ButtonRemoveTank_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(10, 53);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(229, 37);
            AddButton.TabIndex = 2;
            AddButton.Text = "Добавить технику";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += ButtonAddTank_Click;
            // 
            // InputNum
            // 
            InputNum.Location = new Point(10, 133);
            InputNum.Name = "InputNum";
            InputNum.Size = new Size(228, 27);
            InputNum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 3);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Инструменты";
            // 
            // DrawTank
            // 
            DrawTank.Dock = DockStyle.Fill;
            DrawTank.Location = new Point(0, 0);
            DrawTank.Name = "DrawTank";
            DrawTank.Size = new Size(550, 451);
            DrawTank.TabIndex = 1;
            DrawTank.TabStop = false;
            // 
            // CollectionsFrame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(DrawTank);
            Controls.Add(panel1);
            Name = "CollectionsFrame";
            Text = "CollectionsFrame";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DrawTank).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button AddButton;
        private TextBox InputNum;
        private Label label1;
        private PictureBox DrawTank;
    }
}