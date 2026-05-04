namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiCheckbox1 = new CuoreUI.Controls.cuiCheckbox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiFileDropper1 = new CuoreUI.Controls.cuiFileDropper();
            cuiComboBox1 = new CuoreUI.Controls.cuiComboBox();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            cuiTextBoxCreditCardNumber1 = new CuoreUI.Controls.cuiTextBoxCreditCardNumber();
            cuiStarRating1 = new CuoreUI.Controls.cuiStarRating();
            cuiSwitch1 = new CuoreUI.Controls.cuiSwitch();
            SuspendLayout();
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Your text here!";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoverForeColor = Color.DimGray;
            cuiButton1.HoverImageTint = Color.DimGray;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.Location = new Point(1111, 21);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.Black;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.Padding = new Padding(12);
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(865, 173);
            cuiButton1.TabIndex = 0;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextPadding = 12;
            cuiButton1.TextSpacing = 2;
            // 
            // cuiCheckbox1
            // 
            cuiCheckbox1.Checked = false;
            cuiCheckbox1.CheckedForeground = Color.FromArgb(255, 106, 0);
            cuiCheckbox1.CheckedOutlineColor = Color.FromArgb(255, 106, 0);
            cuiCheckbox1.CheckedSymbolColor = Color.White;
            cuiCheckbox1.Content = "cuiCheckbox1";
            cuiCheckbox1.Location = new Point(1129, 200);
            cuiCheckbox1.MinimumSize = new Size(16, 16);
            cuiCheckbox1.Name = "cuiCheckbox1";
            cuiCheckbox1.OutlineThickness = 1F;
            cuiCheckbox1.Rounding = 4;
            cuiCheckbox1.ShowSymbols = true;
            cuiCheckbox1.Size = new Size(160, 99);
            cuiCheckbox1.TabIndex = 1;
            cuiCheckbox1.UncheckedForeground = Color.Empty;
            cuiCheckbox1.UncheckedOutlineColor = Color.Gray;
            cuiCheckbox1.UncheckedSymbolColor = Color.Empty;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Your\\ text\\ here!";
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(1315, 357);
            cuiLabel1.Margin = new Padding(6, 7, 6, 7);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(412, 106);
            cuiLabel1.TabIndex = 2;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiFileDropper1
            // 
            cuiFileDropper1.AllowDrop = true;
            cuiFileDropper1.DashedOutline = true;
            cuiFileDropper1.DashedOutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiFileDropper1.DashLength = 8;
            cuiFileDropper1.Filter = "";
            cuiFileDropper1.ForeColor = Color.Gray;
            cuiFileDropper1.HoverContent = "Release to drop";
            cuiFileDropper1.HoverForeColor = Color.FromArgb(128, 128, 128, 128);
            cuiFileDropper1.HoverUploadForeColor = Color.FromArgb(255, 106, 0);
            cuiFileDropper1.Image = (Image)resources.GetObject("cuiFileDropper1.Image");
            cuiFileDropper1.ImagePadding = 2;
            cuiFileDropper1.ImageSize = new Size(24, 24);
            cuiFileDropper1.ImageTint = Color.Gray;
            cuiFileDropper1.Location = new Point(140, 126);
            cuiFileDropper1.Multiselect = false;
            cuiFileDropper1.Name = "cuiFileDropper1";
            cuiFileDropper1.NormalContent = "Drop file here";
            cuiFileDropper1.NormalForeColor = Color.Gray;
            cuiFileDropper1.NormalUploadForeColor = Color.FromArgb(255, 106, 0);
            cuiFileDropper1.OutlineThickness = 1F;
            cuiFileDropper1.PanelColor = Color.FromArgb(16, 255, 255, 255);
            cuiFileDropper1.Rounding = new Padding(8);
            cuiFileDropper1.Size = new Size(244, 133);
            cuiFileDropper1.TabIndex = 3;
            cuiFileDropper1.Text = "cuiFileDropper1";
            cuiFileDropper1.UploadContent = "Click to upload";
            cuiFileDropper1.UploadWithClick = true;
            // 
            // cuiComboBox1
            // 
            cuiComboBox1.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuiComboBox1.DropDownBackgroundColor = Color.White;
            cuiComboBox1.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cuiComboBox1.ExpandArrowColor = Color.Gray;
            cuiComboBox1.ForeColor = Color.Gray;
            cuiComboBox1.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cuiComboBox1.Location = new Point(79, 357);
            cuiComboBox1.Margin = new Padding(6, 7, 6, 7);
            cuiComboBox1.MaxDropDownHeight = 240;
            cuiComboBox1.Name = "cuiComboBox1";
            cuiComboBox1.NoSelectionText = "None";
            cuiComboBox1.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiComboBox1.OutlineThickness = 1F;
            cuiComboBox1.Rounding = 8;
            cuiComboBox1.SelectedIndex = -1;
            cuiComboBox1.SelectedItem = "";
            cuiComboBox1.Size = new Size(406, 147);
            cuiComboBox1.SortAlphabetically = true;
            cuiComboBox1.TabIndex = 4;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.Content = "rrrrrrrrrrrr";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            cuiTextBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Gray;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(987, 611);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox1.Padding = new Padding(121, 39, 121, 9);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.LightGray;
            cuiTextBox1.PlaceholderText = "ggfgfggf";
            cuiTextBox1.Rounding = new Padding(8);
            cuiTextBox1.Size = new Size(532, 90);
            cuiTextBox1.TabIndex = 5;
            cuiTextBox1.TextOffset = new Size(90, 9);
            cuiTextBox1.UnderlinedStyle = false;
            // 
            // cuiTextBoxCreditCardNumber1
            // 
            cuiTextBoxCreditCardNumber1.BackgroundColor = Color.White;
            cuiTextBoxCreditCardNumber1.Content = "";
            cuiTextBoxCreditCardNumber1.FocusBackgroundColor = Color.White;
            cuiTextBoxCreditCardNumber1.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            cuiTextBoxCreditCardNumber1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBoxCreditCardNumber1.ForeColor = Color.Gray;
            cuiTextBoxCreditCardNumber1.Location = new Point(710, 414);
            cuiTextBoxCreditCardNumber1.Margin = new Padding(4);
            cuiTextBoxCreditCardNumber1.Name = "cuiTextBoxCreditCardNumber1";
            cuiTextBoxCreditCardNumber1.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBoxCreditCardNumber1.Padding = new Padding(55, 30, 55, 0);
            cuiTextBoxCreditCardNumber1.PasswordChar = false;
            cuiTextBoxCreditCardNumber1.PlaceholderColor = Color.LightGray;
            cuiTextBoxCreditCardNumber1.PlaceholderText = "Credit card number here..";
            cuiTextBoxCreditCardNumber1.Rounding = new Padding(8);
            cuiTextBoxCreditCardNumber1.Size = new Size(532, 90);
            cuiTextBoxCreditCardNumber1.TabIndex = 6;
            cuiTextBoxCreditCardNumber1.UnderlinedStyle = true;
            // 
            // cuiStarRating1
            // 
            cuiStarRating1.AllowUserInteraction = true;
            cuiStarRating1.Location = new Point(725, 760);
            cuiStarRating1.Name = "cuiStarRating1";
            cuiStarRating1.Rating = 2;
            cuiStarRating1.Size = new Size(300, 56);
            cuiStarRating1.StarBorderSize = 1;
            cuiStarRating1.StarColor = Color.FromArgb(255, 106, 0);
            cuiStarRating1.StarCount = 5;
            cuiStarRating1.TabIndex = 7;
            cuiStarRating1.Text = "cuiStarRating1";
            // 
            // cuiSwitch1
            // 
            cuiSwitch1.Checked = false;
            cuiSwitch1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiSwitch1.CheckedForeground = Color.White;
            cuiSwitch1.CheckedOutlineColor = Color.Empty;
            cuiSwitch1.CheckedSymbolColor = Color.FromArgb(255, 106, 0);
            cuiSwitch1.Location = new Point(1083, 708);
            cuiSwitch1.MinimumSize = new Size(12, 8);
            cuiSwitch1.Name = "cuiSwitch1";
            cuiSwitch1.OutlineThickness = 1F;
            cuiSwitch1.ShowSymbols = false;
            cuiSwitch1.Size = new Size(96, 52);
            cuiSwitch1.TabIndex = 8;
            cuiSwitch1.ThumbSizeModifier = new Size(0, 0);
            cuiSwitch1.UncheckedBackground = Color.FromArgb(64, 128, 128, 128);
            cuiSwitch1.UncheckedForeground = Color.White;
            cuiSwitch1.UncheckedOutlineColor = Color.Empty;
            cuiSwitch1.UncheckedSymbolColor = Color.Gray;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2025, 880);
            Controls.Add(cuiSwitch1);
            Controls.Add(cuiStarRating1);
            Controls.Add(cuiTextBoxCreditCardNumber1);
            Controls.Add(cuiTextBox1);
            Controls.Add(cuiComboBox1);
            Controls.Add(cuiFileDropper1);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiCheckbox1);
            Controls.Add(cuiButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiFileDropper cuiFileDropper1;
        private CuoreUI.Controls.cuiComboBox cuiComboBox1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiTextBoxCreditCardNumber cuiTextBoxCreditCardNumber1;
        private CuoreUI.Controls.cuiStarRating cuiStarRating1;
        private CuoreUI.Controls.cuiSwitch cuiSwitch1;
    }
}
