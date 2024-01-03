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
            menuStrip1 = new MenuStrip();
            StripMenu = new ToolStripMenuItem();
            SaveItem = new ToolStripMenuItem();
            LoadItem = new ToolStripMenuItem();
            panel2 = new Panel();
            DeleteCollectButton = new Button();
            CollectionListBox = new ListBox();
            AddCollectButton = new Button();
            SetTextBox = new TextBox();
            label2 = new Label();
            UpdateButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            InputNum = new TextBox();
            label1 = new Label();
            DrawTank = new PictureBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DrawTank).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(InputNum);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(694, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 479);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { StripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(237, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // StripMenu
            // 
            StripMenu.DropDownItems.AddRange(new ToolStripItem[] { SaveItem, LoadItem });
            StripMenu.Name = "StripMenu";
            StripMenu.Size = new Size(59, 24);
            StripMenu.Text = "Файл";
            // 
            // SaveItem
            // 
            SaveItem.Name = "SaveItem";
            SaveItem.Size = new Size(166, 26);
            SaveItem.Text = "Сохранить";
            SaveItem.Click += SaveToolStripMenuItem_Click;
            // 
            // LoadItem
            // 
            LoadItem.Name = "LoadItem";
            LoadItem.Size = new Size(166, 26);
            LoadItem.Text = "Загрузить";
            LoadItem.Click += LoadToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(DeleteCollectButton);
            panel2.Controls.Add(CollectionListBox);
            panel2.Controls.Add(AddCollectButton);
            panel2.Controls.Add(SetTextBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(16, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 220);
            panel2.TabIndex = 6;
            // 
            // DeleteCollectButton
            // 
            DeleteCollectButton.Location = new Point(3, 181);
            DeleteCollectButton.Name = "DeleteCollectButton";
            DeleteCollectButton.Size = new Size(208, 29);
            DeleteCollectButton.TabIndex = 4;
            DeleteCollectButton.Text = "Удалить набор";
            DeleteCollectButton.UseVisualStyleBackColor = true;
            DeleteCollectButton.Click += ButtonDelObject_Click;
            // 
            // CollectionListBox
            // 
            CollectionListBox.FormattingEnabled = true;
            CollectionListBox.ItemHeight = 20;
            CollectionListBox.Location = new Point(3, 91);
            CollectionListBox.Name = "CollectionListBox";
            CollectionListBox.Size = new Size(207, 84);
            CollectionListBox.TabIndex = 3;
            CollectionListBox.SelectedIndexChanged += ListBoxObjects_SelectedIndexChanged;
            // 
            // AddCollectButton
            // 
            AddCollectButton.Location = new Point(3, 56);
            AddCollectButton.Name = "AddCollectButton";
            AddCollectButton.Size = new Size(208, 29);
            AddCollectButton.TabIndex = 2;
            AddCollectButton.Text = "Добавить набор";
            AddCollectButton.UseVisualStyleBackColor = true;
            AddCollectButton.Click += ButtonAddObject_Click;
            // 
            // SetTextBox
            // 
            SetTextBox.Location = new Point(2, 23);
            SetTextBox.Name = "SetTextBox";
            SetTextBox.Size = new Size(209, 27);
            SetTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 0;
            label2.Text = "Наборы";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(10, 414);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(219, 37);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Обновить коллекцию";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += ButtonRefreshCollection_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(10, 374);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(219, 37);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить технику";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += ButtonRemoveTank_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(10, 296);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(219, 37);
            AddButton.TabIndex = 2;
            AddButton.Text = "Добавить технику";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += ButtonAddTank_Click;
            // 
            // InputNum
            // 
            InputNum.Location = new Point(10, 337);
            InputNum.Name = "InputNum";
            InputNum.Size = new Size(219, 27);
            InputNum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 39);
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
            DrawTank.Size = new Size(694, 479);
            DrawTank.TabIndex = 1;
            DrawTank.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // FormTanksCollections
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 479);
            Controls.Add(DrawTank);
            Controls.Add(panel1);
            Name = "FormTanksCollections";
            Text = "CollectionsFrame";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Button DeleteCollectButton;
        private ListBox CollectionListBox;
        private Button AddCollectButton;
        private TextBox SetTextBox;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem StripMenu;
        private ToolStripMenuItem SaveItem;
        private ToolStripMenuItem LoadItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}