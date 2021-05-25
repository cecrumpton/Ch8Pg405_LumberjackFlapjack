namespace Ch8Pg405_LumberjackFlapjack
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
            this.labelLumberjackName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddLumberjack = new System.Windows.Forms.Button();
            this.labelLine = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.ListBox();
            this.labelFeed = new System.Windows.Forms.Label();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.textBoxFlapjacks = new System.Windows.Forms.TextBox();
            this.buttonNextLumberjack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLumberjackName
            // 
            this.labelLumberjackName.AutoSize = true;
            this.labelLumberjackName.Location = new System.Drawing.Point(13, 13);
            this.labelLumberjackName.Name = "labelLumberjackName";
            this.labelLumberjackName.Size = new System.Drawing.Size(120, 17);
            this.labelLumberjackName.TabIndex = 0;
            this.labelLumberjackName.Text = "Lumberjack name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(163, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(261, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonAddLumberjack
            // 
            this.buttonAddLumberjack.Location = new System.Drawing.Point(13, 46);
            this.buttonAddLumberjack.Name = "buttonAddLumberjack";
            this.buttonAddLumberjack.Size = new System.Drawing.Size(411, 23);
            this.buttonAddLumberjack.TabIndex = 2;
            this.buttonAddLumberjack.Text = "Add Lumberjack";
            this.buttonAddLumberjack.UseVisualStyleBackColor = true;
            this.buttonAddLumberjack.Click += new System.EventHandler(this.buttonAddLumberjack_Click);
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(13, 91);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(94, 17);
            this.labelLine.TabIndex = 3;
            this.labelLine.Text = "Breakfast line";
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.ItemHeight = 16;
            this.line.Location = new System.Drawing.Point(13, 121);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(161, 340);
            this.line.TabIndex = 4;
            // 
            // labelFeed
            // 
            this.labelFeed.AutoSize = true;
            this.labelFeed.Location = new System.Drawing.Point(10, 32);
            this.labelFeed.Name = "labelFeed";
            this.labelFeed.Size = new System.Drawing.Size(129, 17);
            this.labelFeed.TabIndex = 5;
            this.labelFeed.Text = "Feed a Lumberjack";
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(12, 52);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(120, 22);
            this.howMany.TabIndex = 6;
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(13, 91);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(68, 21);
            this.crispy.TabIndex = 7;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(12, 130);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(69, 21);
            this.soggy.TabIndex = 8;
            this.soggy.TabStop = true;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(12, 166);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(84, 21);
            this.browned.TabIndex = 9;
            this.browned.TabStop = true;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(12, 202);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(78, 21);
            this.banana.TabIndex = 10;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.Location = new System.Drawing.Point(9, 229);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(201, 23);
            this.addFlapjacks.TabIndex = 11;
            this.addFlapjacks.Text = "Add flapjacks";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            // 
            // textBoxFlapjacks
            // 
            this.textBoxFlapjacks.Location = new System.Drawing.Point(9, 258);
            this.textBoxFlapjacks.Multiline = true;
            this.textBoxFlapjacks.Name = "textBoxFlapjacks";
            this.textBoxFlapjacks.ReadOnly = true;
            this.textBoxFlapjacks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFlapjacks.Size = new System.Drawing.Size(201, 68);
            this.textBoxFlapjacks.TabIndex = 12;
            // 
            // buttonNextLumberjack
            // 
            this.buttonNextLumberjack.Location = new System.Drawing.Point(9, 332);
            this.buttonNextLumberjack.Name = "buttonNextLumberjack";
            this.buttonNextLumberjack.Size = new System.Drawing.Size(201, 23);
            this.buttonNextLumberjack.TabIndex = 13;
            this.buttonNextLumberjack.Text = "Next Lumberjack";
            this.buttonNextLumberjack.UseVisualStyleBackColor = true;
            this.buttonNextLumberjack.Click += new System.EventHandler(this.buttonNextLumberjack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFeed);
            this.groupBox1.Controls.Add(this.textBoxFlapjacks);
            this.groupBox1.Controls.Add(this.buttonNextLumberjack);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Location = new System.Drawing.Point(197, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 370);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.buttonAddLumberjack);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelLumberjackName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLumberjackName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddLumberjack;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Label labelFeed;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.TextBox textBoxFlapjacks;
        private System.Windows.Forms.Button buttonNextLumberjack;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

