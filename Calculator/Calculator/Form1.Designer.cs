namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.Btn = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TilteBar = new System.Windows.Forms.Label();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.BtnDesimal = new Calculator_162001511.CustomButton();
            this.Btn6 = new Calculator_162001511.CustomButton();
            this.BtnSquare = new Calculator_162001511.CustomButton();
            this.Btn3 = new Calculator_162001511.CustomButton();
            this.Btn9 = new Calculator_162001511.CustomButton();
            this.BtnC = new Calculator_162001511.CustomButton();
            this.Btn0 = new Calculator_162001511.CustomButton();
            this.Btn5 = new Calculator_162001511.CustomButton();
            this.BtnX2 = new Calculator_162001511.CustomButton();
            this.Btn2 = new Calculator_162001511.CustomButton();
            this.BtnPM = new Calculator_162001511.CustomButton();
            this.Btn8 = new Calculator_162001511.CustomButton();
            this.Btn4 = new Calculator_162001511.CustomButton();
            this.BtnEquals = new Calculator_162001511.CustomButton();
            this.BtnCE = new Calculator_162001511.CustomButton();
            this.BtnSubtraction = new Calculator_162001511.CustomButton();
            this.Btn1 = new Calculator_162001511.CustomButton();
            this.Btn1X = new Calculator_162001511.CustomButton();
            this.Btn7 = new Calculator_162001511.CustomButton();
            this.BtnAdd = new Calculator_162001511.CustomButton();
            this.BtnDivision = new Calculator_162001511.CustomButton();
            this.BtnMultiply = new Calculator_162001511.CustomButton();
            this.BtnPercent = new Calculator_162001511.CustomButton();
            this.BtnBackSpace = new Calculator_162001511.CustomButton();
            this.customButton7 = new Calculator_162001511.CustomButton();
            this.customButton6 = new Calculator_162001511.CustomButton();
            this.customButton5 = new Calculator_162001511.CustomButton();
            this.customButton4 = new Calculator_162001511.CustomButton();
            this.customButton3 = new Calculator_162001511.CustomButton();
            this.customButton1 = new Calculator_162001511.CustomButton();
            this.ellipseForm = new Calculator_162001511.EllipseControl();
            this.PnlTitle.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTitle.Controls.Add(this.Btn);
            this.PnlTitle.Controls.Add(this.BtnMaximize);
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Controls.Add(this.TilteBar);
            this.PnlTitle.ForeColor = System.Drawing.Color.Violet;
            this.PnlTitle.Location = new System.Drawing.Point(0, 10);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(350, 50);
            this.PnlTitle.TabIndex = 0;
            // 
            // Btn
            // 
            this.Btn.FlatAppearance.BorderSize = 0;
            this.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn.Image = ((System.Drawing.Image)(resources.GetObject("Btn.Image")));
            this.Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn.Location = new System.Drawing.Point(200, 0);
            this.Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(50, 50);
            this.Btn.TabIndex = 2;
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximize.Image")));
            this.BtnMaximize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMaximize.Location = new System.Drawing.Point(250, 0);
            this.BtnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(50, 50);
            this.BtnMaximize.TabIndex = 1;
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExit.Location = new System.Drawing.Point(300, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 50);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TilteBar
            // 
            this.TilteBar.AutoSize = true;
            this.TilteBar.Font = new System.Drawing.Font("Comic Sans MS", 7F);
            this.TilteBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TilteBar.Location = new System.Drawing.Point(0, -1);
            this.TilteBar.Name = "TilteBar";
            this.TilteBar.Size = new System.Drawing.Size(189, 14);
            this.TilteBar.TabIndex = 7;
            this.TilteBar.Text = "Calculator - Tran Duy Man - 162000165";
            // 
            // PnlHistory
            // 
            this.PnlHistory.BackColor = System.Drawing.Color.DimGray;
            this.PnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PnlHistory.Location = new System.Drawing.Point(0, 564);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(350, 0);
            this.PnlHistory.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Silver;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ReadOnly = true;
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(350, 0);
            this.RtBoxDisplayHistory.TabIndex = 4;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -50);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(350, 50);
            this.BtnClearHistory.TabIndex = 3;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 50);
            this.panel1.TabIndex = 2;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(50, 50);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnHistory.Location = new System.Drawing.Point(300, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 50);
            this.BtnHistory.TabIndex = 0;
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.TxtDisplay2.ForeColor = System.Drawing.Color.White;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 110);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.ReadOnly = true;
            this.TxtDisplay2.Size = new System.Drawing.Size(350, 25);
            this.TxtDisplay2.TabIndex = 3;
            this.TxtDisplay2.Text = "0";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold);
            this.TxtDisplay1.ForeColor = System.Drawing.Color.White;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 135);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.ReadOnly = true;
            this.TxtDisplay1.Size = new System.Drawing.Size(350, 50);
            this.TxtDisplay1.TabIndex = 4;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnDesimal
            // 
            this.BtnDesimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDesimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDesimal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDesimal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDesimal.BorderRadius = 20;
            this.BtnDesimal.BorderSize = 0;
            this.BtnDesimal.FlatAppearance.BorderSize = 0;
            this.BtnDesimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesimal.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.BtnDesimal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDesimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDesimal.Location = new System.Drawing.Point(176, 495);
            this.BtnDesimal.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDesimal.Name = "BtnDesimal";
            this.BtnDesimal.Size = new System.Drawing.Size(85, 50);
            this.BtnDesimal.TabIndex = 6;
            this.BtnDesimal.Text = ".";
            this.BtnDesimal.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDesimal.UseVisualStyleBackColor = false;
            this.BtnDesimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn6
            // 
            this.Btn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn6.BorderRadius = 20;
            this.Btn6.BorderSize = 0;
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.Btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn6.Location = new System.Drawing.Point(176, 395);
            this.Btn6.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(85, 50);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "6";
            this.Btn6.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSquare.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSquare.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSquare.BorderRadius = 20;
            this.BtnSquare.BorderSize = 0;
            this.BtnSquare.FlatAppearance.BorderSize = 0;
            this.BtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSquare.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquare.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSquare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSquare.Location = new System.Drawing.Point(176, 295);
            this.BtnSquare.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(85, 50);
            this.BtnSquare.TabIndex = 6;
            this.BtnSquare.Text = "√x";
            this.BtnSquare.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSquare.UseVisualStyleBackColor = false;
            this.BtnSquare.Click += new System.EventHandler(this.BtnMath2Operation_Click);
            // 
            // Btn3
            // 
            this.Btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn3.BorderRadius = 20;
            this.Btn3.BorderSize = 0;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.Btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn3.Location = new System.Drawing.Point(176, 445);
            this.Btn3.Margin = new System.Windows.Forms.Padding(0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(85, 50);
            this.Btn3.TabIndex = 6;
            this.Btn3.Text = "3";
            this.Btn3.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn9
            // 
            this.Btn9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn9.BorderRadius = 20;
            this.Btn9.BorderSize = 0;
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.Btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn9.Location = new System.Drawing.Point(176, 345);
            this.Btn9.Margin = new System.Windows.Forms.Padding(0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(85, 50);
            this.Btn9.TabIndex = 6;
            this.Btn9.Text = "9";
            this.Btn9.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnC
            // 
            this.BtnC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnC.BorderRadius = 20;
            this.BtnC.BorderSize = 0;
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnC.Location = new System.Drawing.Point(176, 245);
            this.BtnC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(85, 50);
            this.BtnC.TabIndex = 6;
            this.BtnC.Text = "C";
            this.BtnC.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // Btn0
            // 
            this.Btn0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn0.BorderRadius = 20;
            this.Btn0.BorderSize = 0;
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.Btn0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn0.Location = new System.Drawing.Point(91, 495);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(85, 50);
            this.Btn0.TabIndex = 6;
            this.Btn0.Text = "0";
            this.Btn0.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn5.BorderRadius = 20;
            this.Btn5.BorderSize = 0;
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.Btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn5.Location = new System.Drawing.Point(91, 395);
            this.Btn5.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(85, 50);
            this.Btn5.TabIndex = 6;
            this.Btn5.Text = "5";
            this.Btn5.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnX2
            // 
            this.BtnX2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnX2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnX2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnX2.BorderRadius = 20;
            this.BtnX2.BorderSize = 0;
            this.BtnX2.FlatAppearance.BorderSize = 0;
            this.BtnX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnX2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnX2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnX2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnX2.Location = new System.Drawing.Point(91, 295);
            this.BtnX2.Margin = new System.Windows.Forms.Padding(0);
            this.BtnX2.Name = "BtnX2";
            this.BtnX2.Size = new System.Drawing.Size(85, 50);
            this.BtnX2.TabIndex = 6;
            this.BtnX2.Text = "x^2";
            this.BtnX2.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnX2.UseVisualStyleBackColor = false;
            this.BtnX2.Click += new System.EventHandler(this.BtnMath2Operation_Click);
            // 
            // Btn2
            // 
            this.Btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn2.BorderRadius = 20;
            this.Btn2.BorderSize = 0;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.Btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn2.Location = new System.Drawing.Point(91, 445);
            this.Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(85, 50);
            this.Btn2.TabIndex = 6;
            this.Btn2.Text = "2";
            this.Btn2.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnPM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnPM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPM.BorderRadius = 20;
            this.BtnPM.BorderSize = 0;
            this.BtnPM.FlatAppearance.BorderSize = 0;
            this.BtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPM.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.BtnPM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnPM.Location = new System.Drawing.Point(6, 495);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(85, 50);
            this.BtnPM.TabIndex = 6;
            this.BtnPM.Text = "±";
            this.BtnPM.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPM.UseVisualStyleBackColor = false;
            this.BtnPM.Click += new System.EventHandler(this.BtnMath2Operation_Click);
            // 
            // Btn8
            // 
            this.Btn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn8.BorderRadius = 20;
            this.Btn8.BorderSize = 0;
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.Btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn8.Location = new System.Drawing.Point(91, 345);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(85, 50);
            this.Btn8.TabIndex = 6;
            this.Btn8.Text = "8";
            this.Btn8.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn4
            // 
            this.Btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn4.BorderRadius = 20;
            this.Btn4.BorderSize = 0;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.Btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn4.Location = new System.Drawing.Point(6, 395);
            this.Btn4.Margin = new System.Windows.Forms.Padding(0);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(85, 50);
            this.Btn4.TabIndex = 6;
            this.Btn4.Text = "4";
            this.Btn4.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEquals.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEquals.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.BtnEquals.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnEquals.BorderRadius = 20;
            this.BtnEquals.BorderSize = 0;
            this.BtnEquals.FlatAppearance.BorderSize = 0;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Gadugi", 18F);
            this.BtnEquals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEquals.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEquals.Location = new System.Drawing.Point(261, 495);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(85, 50);
            this.BtnEquals.TabIndex = 6;
            this.BtnEquals.Text = "=";
            this.BtnEquals.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnCE.BorderRadius = 20;
            this.BtnCE.BorderSize = 0;
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCE.Location = new System.Drawing.Point(91, 245);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(85, 50);
            this.BtnCE.TabIndex = 6;
            this.BtnCE.Text = "CE";
            this.BtnCE.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSubtraction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSubtraction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSubtraction.BorderRadius = 20;
            this.BtnSubtraction.BorderSize = 0;
            this.BtnSubtraction.FlatAppearance.BorderSize = 0;
            this.BtnSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtraction.Font = new System.Drawing.Font("Gadugi", 23F);
            this.BtnSubtraction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSubtraction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSubtraction.Location = new System.Drawing.Point(261, 395);
            this.BtnSubtraction.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(85, 50);
            this.BtnSubtraction.TabIndex = 6;
            this.BtnSubtraction.Text = "-";
            this.BtnSubtraction.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSubtraction.UseVisualStyleBackColor = false;
            this.BtnSubtraction.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn1
            // 
            this.Btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1.BorderRadius = 20;
            this.Btn1.BorderSize = 0;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.Btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn1.Location = new System.Drawing.Point(6, 445);
            this.Btn1.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(85, 50);
            this.Btn1.TabIndex = 6;
            this.Btn1.Text = "1";
            this.Btn1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn1X
            // 
            this.Btn1X.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn1X.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn1X.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1X.BorderRadius = 20;
            this.Btn1X.BorderSize = 0;
            this.Btn1X.FlatAppearance.BorderSize = 0;
            this.Btn1X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1X.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1X.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1X.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn1X.Location = new System.Drawing.Point(6, 295);
            this.Btn1X.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1X.Name = "Btn1X";
            this.Btn1X.Size = new System.Drawing.Size(85, 50);
            this.Btn1X.TabIndex = 6;
            this.Btn1X.Text = "⅟x";
            this.Btn1X.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1X.UseVisualStyleBackColor = false;
            this.Btn1X.Click += new System.EventHandler(this.BtnMath2Operation_Click);
            // 
            // Btn7
            // 
            this.Btn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn7.BorderRadius = 20;
            this.Btn7.BorderSize = 0;
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.Btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn7.Location = new System.Drawing.Point(6, 345);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(85, 50);
            this.Btn7.TabIndex = 6;
            this.Btn7.Text = "7";
            this.Btn7.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnAdd.BorderRadius = 20;
            this.BtnAdd.BorderSize = 0;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Gadugi", 18F);
            this.BtnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAdd.Location = new System.Drawing.Point(261, 445);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 50);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "+";
            this.BtnAdd.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDivision.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDivision.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDivision.BorderRadius = 20;
            this.BtnDivision.BorderSize = 0;
            this.BtnDivision.FlatAppearance.BorderSize = 0;
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivision.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDivision.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDivision.Location = new System.Drawing.Point(261, 295);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(85, 50);
            this.BtnDivision.TabIndex = 6;
            this.BtnDivision.Text = "÷";
            this.BtnDivision.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMultiply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMultiply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnMultiply.BorderRadius = 20;
            this.BtnMultiply.BorderSize = 0;
            this.BtnMultiply.FlatAppearance.BorderSize = 0;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.BtnMultiply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMultiply.Location = new System.Drawing.Point(261, 345);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(85, 50);
            this.BtnMultiply.TabIndex = 6;
            this.BtnMultiply.Text = "×";
            this.BtnMultiply.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPercent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPercent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPercent.BorderRadius = 20;
            this.BtnPercent.BorderSize = 0;
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnPercent.Location = new System.Drawing.Point(6, 245);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(85, 50);
            this.BtnPercent.TabIndex = 6;
            this.BtnPercent.Text = "%";
            this.BtnPercent.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnMath2Operation_Click);
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnBackSpace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnBackSpace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnBackSpace.BorderRadius = 20;
            this.BtnBackSpace.BorderSize = 0;
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackSpace.Image")));
            this.BtnBackSpace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBackSpace.Location = new System.Drawing.Point(261, 245);
            this.BtnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(85, 50);
            this.BtnBackSpace.TabIndex = 6;
            this.BtnBackSpace.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // customButton7
            // 
            this.customButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton7.BorderRadius = 15;
            this.customButton7.BorderSize = 0;
            this.customButton7.FlatAppearance.BorderSize = 0;
            this.customButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton7.ForeColor = System.Drawing.Color.Silver;
            this.customButton7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customButton7.Location = new System.Drawing.Point(10, 207);
            this.customButton7.Margin = new System.Windows.Forms.Padding(0);
            this.customButton7.Name = "customButton7";
            this.customButton7.Size = new System.Drawing.Size(50, 30);
            this.customButton7.TabIndex = 5;
            this.customButton7.Text = "MC";
            this.customButton7.TextColor = System.Drawing.Color.Silver;
            this.customButton7.UseVisualStyleBackColor = false;
            // 
            // customButton6
            // 
            this.customButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton6.BorderRadius = 15;
            this.customButton6.BorderSize = 0;
            this.customButton6.FlatAppearance.BorderSize = 0;
            this.customButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton6.ForeColor = System.Drawing.Color.Silver;
            this.customButton6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customButton6.Location = new System.Drawing.Point(66, 207);
            this.customButton6.Margin = new System.Windows.Forms.Padding(0);
            this.customButton6.Name = "customButton6";
            this.customButton6.Size = new System.Drawing.Size(50, 30);
            this.customButton6.TabIndex = 5;
            this.customButton6.Text = "MR";
            this.customButton6.TextColor = System.Drawing.Color.Silver;
            this.customButton6.UseVisualStyleBackColor = false;
            // 
            // customButton5
            // 
            this.customButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton5.BorderRadius = 15;
            this.customButton5.BorderSize = 0;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.ForeColor = System.Drawing.Color.Silver;
            this.customButton5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customButton5.Location = new System.Drawing.Point(122, 207);
            this.customButton5.Margin = new System.Windows.Forms.Padding(0);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(50, 30);
            this.customButton5.TabIndex = 5;
            this.customButton5.Text = "M+";
            this.customButton5.TextColor = System.Drawing.Color.Silver;
            this.customButton5.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            this.customButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton4.BorderRadius = 15;
            this.customButton4.BorderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.ForeColor = System.Drawing.Color.Silver;
            this.customButton4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customButton4.Location = new System.Drawing.Point(178, 207);
            this.customButton4.Margin = new System.Windows.Forms.Padding(0);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(50, 30);
            this.customButton4.TabIndex = 5;
            this.customButton4.Text = "M-";
            this.customButton4.TextColor = System.Drawing.Color.Silver;
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton3.BorderRadius = 15;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.Silver;
            this.customButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customButton3.Location = new System.Drawing.Point(234, 207);
            this.customButton3.Margin = new System.Windows.Forms.Padding(0);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(50, 30);
            this.customButton3.TabIndex = 5;
            this.customButton3.Text = "MS";
            this.customButton3.TextColor = System.Drawing.Color.Silver;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customButton1.BorderRadius = 15;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Silver;
            this.customButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customButton1.Location = new System.Drawing.Point(290, 207);
            this.customButton1.Margin = new System.Windows.Forms.Padding(0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(50, 30);
            this.customButton1.TabIndex = 5;
            this.customButton1.Text = "M~";
            this.customButton1.TextColor = System.Drawing.Color.Silver;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // ellipseForm
            // 
            this.ellipseForm.CornerRedius = 20;
            this.ellipseForm.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 564);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.BtnDesimal);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.BtnX2);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnSubtraction);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn1X);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.customButton7);
            this.Controls.Add(this.customButton6);
            this.Controls.Add(this.customButton5);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            this.PnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private System.Windows.Forms.Button BtnClearHistory;
        private Calculator_162001511.EllipseControl ellipseForm;
        private Calculator_162001511.CustomButton customButton1;
        private Calculator_162001511.CustomButton BtnBackSpace;
        private Calculator_162001511.CustomButton customButton7;
        private Calculator_162001511.CustomButton customButton6;
        private Calculator_162001511.CustomButton customButton5;
        private Calculator_162001511.CustomButton customButton4;
        private Calculator_162001511.CustomButton customButton3;
        private Calculator_162001511.CustomButton BtnSquare;
        private Calculator_162001511.CustomButton BtnC;
        private Calculator_162001511.CustomButton BtnX2;
        private Calculator_162001511.CustomButton BtnCE;
        private Calculator_162001511.CustomButton Btn1X;
        private Calculator_162001511.CustomButton BtnDivision;
        private Calculator_162001511.CustomButton BtnPercent;
        private Calculator_162001511.CustomButton Btn6;
        private Calculator_162001511.CustomButton Btn9;
        private Calculator_162001511.CustomButton Btn5;
        private Calculator_162001511.CustomButton Btn8;
        private Calculator_162001511.CustomButton Btn4;
        private Calculator_162001511.CustomButton BtnSubtraction;
        private Calculator_162001511.CustomButton Btn7;
        private Calculator_162001511.CustomButton BtnMultiply;
        private Calculator_162001511.CustomButton BtnDesimal;
        private Calculator_162001511.CustomButton Btn3;
        private Calculator_162001511.CustomButton Btn0;
        private Calculator_162001511.CustomButton Btn2;
        private Calculator_162001511.CustomButton BtnPM;
        private Calculator_162001511.CustomButton BtnEquals;
        private Calculator_162001511.CustomButton Btn1;
        private Calculator_162001511.CustomButton BtnAdd;
        private System.Windows.Forms.Label TilteBar;
    }
}

