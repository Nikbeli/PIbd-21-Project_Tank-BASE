namespace Tank
{
    partial class FormTankConfig
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
            ParamsGroup = new GroupBox();
            labelTank = new Label();
            labelArmoVehicle = new Label();
            groupBoxColors = new GroupBox();
            panelPink = new Panel();
            panelYellow = new Panel();
            panelCyan = new Panel();
            panelRed = new Panel();
            panelBlue = new Panel();
            panelOrange = new Panel();
            panelGreen = new Panel();
            panelSilver = new Panel();
            checkBoxCaterpillar = new CheckBox();
            checkBoxBodyKit = new CheckBox();
            checkBoxTower = new CheckBox();
            numericWeight = new NumericUpDown();
            numericSpeed = new NumericUpDown();
            weightLabel = new Label();
            speedLabel = new Label();
            panelPictureTank = new Panel();
            pictureBox = new PictureBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            labelColor = new Label();
            labelAdditionalColor = new Label();
            ParamsGroup.SuspendLayout();
            groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSpeed).BeginInit();
            panelPictureTank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // ParamsGroup
            // 
            ParamsGroup.Controls.Add(labelTank);
            ParamsGroup.Controls.Add(labelArmoVehicle);
            ParamsGroup.Controls.Add(groupBoxColors);
            ParamsGroup.Controls.Add(checkBoxCaterpillar);
            ParamsGroup.Controls.Add(checkBoxBodyKit);
            ParamsGroup.Controls.Add(checkBoxTower);
            ParamsGroup.Controls.Add(numericWeight);
            ParamsGroup.Controls.Add(numericSpeed);
            ParamsGroup.Controls.Add(weightLabel);
            ParamsGroup.Controls.Add(speedLabel);
            ParamsGroup.Location = new Point(5, 3);
            ParamsGroup.Margin = new Padding(5, 4, 5, 4);
            ParamsGroup.Name = "ParamsGroup";
            ParamsGroup.Padding = new Padding(5, 4, 5, 4);
            ParamsGroup.Size = new Size(240, 740);
            ParamsGroup.TabIndex = 0;
            ParamsGroup.TabStop = false;
            ParamsGroup.Text = "Params Group Box";
            // 
            // labelTank
            // 
            labelTank.BorderStyle = BorderStyle.FixedSingle;
            labelTank.Location = new Point(120, 644);
            labelTank.Margin = new Padding(5, 0, 5, 0);
            labelTank.Name = "labelTank";
            labelTank.Size = new Size(87, 55);
            labelTank.TabIndex = 10;
            labelTank.Text = "Tank";
            labelTank.TextAlign = ContentAlignment.MiddleCenter;
            labelTank.MouseDown += LabelObject_MouseDown;
            // 
            // labelArmoVehicle
            // 
            labelArmoVehicle.BorderStyle = BorderStyle.FixedSingle;
            labelArmoVehicle.Location = new Point(9, 644);
            labelArmoVehicle.Margin = new Padding(5, 0, 5, 0);
            labelArmoVehicle.Name = "labelArmoVehicle";
            labelArmoVehicle.Size = new Size(96, 55);
            labelArmoVehicle.TabIndex = 9;
            labelArmoVehicle.Text = "ArmoVehicle";
            labelArmoVehicle.TextAlign = ContentAlignment.MiddleCenter;
            labelArmoVehicle.MouseDown += LabelObject_MouseDown;
            // 
            // groupBoxColors
            // 
            groupBoxColors.Controls.Add(panelPink);
            groupBoxColors.Controls.Add(panelYellow);
            groupBoxColors.Controls.Add(panelCyan);
            groupBoxColors.Controls.Add(panelRed);
            groupBoxColors.Controls.Add(panelBlue);
            groupBoxColors.Controls.Add(panelOrange);
            groupBoxColors.Controls.Add(panelGreen);
            groupBoxColors.Controls.Add(panelSilver);
            groupBoxColors.Location = new Point(16, 268);
            groupBoxColors.Margin = new Padding(5, 4, 5, 4);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Padding = new Padding(5, 4, 5, 4);
            groupBoxColors.Size = new Size(210, 348);
            groupBoxColors.TabIndex = 8;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Colors";
            // 
            // panelPink
            // 
            panelPink.BackColor = Color.Fuchsia;
            panelPink.Location = new Point(107, 276);
            panelPink.Margin = new Padding(5, 4, 5, 4);
            panelPink.Name = "panelPink";
            panelPink.Size = new Size(56, 61);
            panelPink.TabIndex = 3;
            panelPink.MouseDown += panelColor_MouseDown;
            // 
            // panelYellow
            // 
            panelYellow.BackColor = Color.Yellow;
            panelYellow.Location = new Point(107, 108);
            panelYellow.Margin = new Padding(5, 4, 5, 4);
            panelYellow.Name = "panelYellow";
            panelYellow.Size = new Size(56, 61);
            panelYellow.TabIndex = 1;
            panelYellow.MouseDown += panelColor_MouseDown;
            // 
            // panelCyan
            // 
            panelCyan.BackColor = Color.Cyan;
            panelCyan.Location = new Point(107, 192);
            panelCyan.Margin = new Padding(5, 4, 5, 4);
            panelCyan.Name = "panelCyan";
            panelCyan.Size = new Size(56, 61);
            panelCyan.TabIndex = 4;
            panelCyan.MouseDown += panelColor_MouseDown;
            // 
            // panelRed
            // 
            panelRed.BackColor = Color.Red;
            panelRed.Location = new Point(107, 24);
            panelRed.Margin = new Padding(5, 4, 5, 4);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(56, 61);
            panelRed.TabIndex = 1;
            panelRed.MouseDown += panelColor_MouseDown;
            // 
            // panelBlue
            // 
            panelBlue.BackColor = Color.Blue;
            panelBlue.Location = new Point(33, 276);
            panelBlue.Margin = new Padding(5, 4, 5, 4);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(56, 61);
            panelBlue.TabIndex = 5;
            panelBlue.MouseDown += panelColor_MouseDown;
            // 
            // panelOrange
            // 
            panelOrange.BackColor = Color.FromArgb(255, 128, 0);
            panelOrange.Location = new Point(33, 108);
            panelOrange.Margin = new Padding(5, 4, 5, 4);
            panelOrange.Name = "panelOrange";
            panelOrange.Size = new Size(56, 61);
            panelOrange.TabIndex = 1;
            panelOrange.MouseDown += panelColor_MouseDown;
            // 
            // panelGreen
            // 
            panelGreen.BackColor = Color.Lime;
            panelGreen.Location = new Point(33, 192);
            panelGreen.Margin = new Padding(5, 4, 5, 4);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(56, 61);
            panelGreen.TabIndex = 2;
            panelGreen.MouseDown += panelColor_MouseDown;
            // 
            // panelSilver
            // 
            panelSilver.BackColor = Color.Silver;
            panelSilver.Location = new Point(33, 24);
            panelSilver.Margin = new Padding(5, 4, 5, 4);
            panelSilver.Name = "panelSilver";
            panelSilver.Size = new Size(56, 61);
            panelSilver.TabIndex = 0;
            panelSilver.MouseDown += panelColor_MouseDown;
            // 
            // checkBoxCaterpillarTank
            // 
            checkBoxCaterpillar.AutoSize = true;
            checkBoxCaterpillar.Location = new Point(18, 180);
            checkBoxCaterpillar.Margin = new Padding(5, 4, 5, 4);
            checkBoxCaterpillar.Name = "checkBoxCaterpillarTank";
            checkBoxCaterpillar.Size = new Size(100, 24);
            checkBoxCaterpillar.TabIndex = 7;
            checkBoxCaterpillar.Text = "Caterpillar";
            checkBoxCaterpillar.UseVisualStyleBackColor = true;
            // 
            // checkBoxBodyKit
            // 
            checkBoxBodyKit.AutoSize = true;
            checkBoxBodyKit.Location = new Point(18, 149);
            checkBoxBodyKit.Margin = new Padding(5, 4, 5, 4);
            checkBoxBodyKit.Name = "checkBoxBodyKit";
            checkBoxBodyKit.Size = new Size(83, 24);
            checkBoxBodyKit.TabIndex = 6;
            checkBoxBodyKit.Text = "BodyKit";
            checkBoxBodyKit.UseVisualStyleBackColor = true;
            // 
            // checkBoxTower
            // 
            checkBoxTower.AutoSize = true;
            checkBoxTower.Location = new Point(18, 216);
            checkBoxTower.Margin = new Padding(5, 4, 5, 4);
            checkBoxTower.Name = "checkBoxTower";
            checkBoxTower.Size = new Size(71, 24);
            checkBoxTower.TabIndex = 5;
            checkBoxTower.Text = "Tower";
            checkBoxTower.UseVisualStyleBackColor = true;
            // 
            // numericWeight
            // 
            numericWeight.Location = new Point(66, 79);
            numericWeight.Margin = new Padding(5, 4, 5, 4);
            numericWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericWeight.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericWeight.Name = "numericWeight";
            numericWeight.Size = new Size(160, 27);
            numericWeight.TabIndex = 4;
            numericWeight.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericSpeed
            // 
            numericSpeed.Location = new Point(66, 36);
            numericSpeed.Margin = new Padding(5, 4, 5, 4);
            numericSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericSpeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericSpeed.Name = "numericSpeed";
            numericSpeed.Size = new Size(160, 27);
            numericSpeed.TabIndex = 3;
            numericSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(11, 79);
            weightLabel.Margin = new Padding(5, 0, 5, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(49, 20);
            weightLabel.TabIndex = 2;
            weightLabel.Text = "weigh";
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new Point(11, 39);
            speedLabel.Margin = new Padding(5, 0, 5, 0);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(49, 20);
            speedLabel.TabIndex = 1;
            speedLabel.Text = "speed";
            // 
            // panel9
            // 
            panelPictureTank.AllowDrop = true;
            panelPictureTank.Controls.Add(pictureBox);
            panelPictureTank.Location = new Point(266, 116);
            panelPictureTank.Margin = new Padding(5, 4, 5, 4);
            panelPictureTank.Name = "panel9";
            panelPictureTank.Size = new Size(784, 520);
            panelPictureTank.TabIndex = 11;
            panelPictureTank.DragDrop += PanelObject_DragDrop;
            panelPictureTank.DragEnter += PanelObject_DragEnter;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(18, 8);
            pictureBox.Margin = new Padding(5, 4, 5, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(741, 508);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(306, 660);
            buttonAdd.Margin = new Padding(5, 4, 5, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(200, 62);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(793, 662);
            buttonCancel.Margin = new Padding(5, 4, 5, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(210, 60);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelColor
            // 
            labelColor.AllowDrop = true;
            labelColor.BorderStyle = BorderStyle.FixedSingle;
            labelColor.Location = new Point(349, 37);
            labelColor.Margin = new Padding(5, 0, 5, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(139, 42);
            labelColor.TabIndex = 14;
            labelColor.Text = "Color";
            labelColor.TextAlign = ContentAlignment.MiddleCenter;
            labelColor.DragDrop += labelColor_DragDrop;
            labelColor.DragEnter += labelColor_DragEnter;
            // 
            // labelAdditionalColor
            // 
            labelAdditionalColor.AllowDrop = true;
            labelAdditionalColor.BorderStyle = BorderStyle.FixedSingle;
            labelAdditionalColor.Location = new Point(815, 32);
            labelAdditionalColor.Margin = new Padding(5, 0, 5, 0);
            labelAdditionalColor.Name = "labelAdditionalColor";
            labelAdditionalColor.Size = new Size(136, 39);
            labelAdditionalColor.TabIndex = 15;
            labelAdditionalColor.Text = "Additional color";
            labelAdditionalColor.TextAlign = ContentAlignment.MiddleCenter;
            labelAdditionalColor.DragDrop += labelColor_DragDrop;
            labelAdditionalColor.DragEnter += labelColor_DragEnter;
            // 
            // FormTankConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 744);
            Controls.Add(labelAdditionalColor);
            Controls.Add(labelColor);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(panelPictureTank);
            Controls.Add(ParamsGroup);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormTankConfig";
            Text = "FormTankConfig";
            ParamsGroup.ResumeLayout(false);
            ParamsGroup.PerformLayout();
            groupBoxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSpeed).EndInit();
            panelPictureTank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ParamsGroup;
        private CheckBox checkBoxCaterpillar;
        private CheckBox checkBoxBodyKit;
        private CheckBox checkBoxTower;
        private NumericUpDown numericWeight;
        private NumericUpDown numericSpeed;
        private Label weightLabel;
        private Label speedLabel;
        private GroupBox groupBoxColors;
        private Panel panelPink;
        private Panel panelYellow;
        private Panel panelCyan;
        private Panel panelRed;
        private Panel panelBlue;
        private Panel panelOrange;
        private Panel panelGreen;
        private Panel panelSilver;
        private Label labelTank;
        private Label labelArmoVehicle;
        private Panel panelPictureTank;
        private PictureBox pictureBox;
        private Button buttonAdd;
        private Button buttonCancel;
        private Label labelColor;
        private Label labelAdditionalColor;
    }
}