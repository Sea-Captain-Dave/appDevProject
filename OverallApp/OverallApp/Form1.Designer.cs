namespace OverallApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.outBox1 = new System.Windows.Forms.RichTextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dumpDBbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AuxButton = new System.Windows.Forms.Button();
            this.auxSearch = new System.Windows.Forms.TextBox();
            this.auxBoxLable = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outBox1
            // 
            this.outBox1.Location = new System.Drawing.Point(21, 215);
            this.outBox1.Name = "outBox1";
            this.outBox1.Size = new System.Drawing.Size(860, 149);
            this.outBox1.TabIndex = 1;
            this.outBox1.Text = "";
            this.outBox1.TextChanged += new System.EventHandler(this.outBox1_TextChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(90, 163);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(238, 22);
            this.searchBox.TabIndex = 3;
            // 
            // dumpDBbutton
            // 
            this.dumpDBbutton.Location = new System.Drawing.Point(320, 376);
            this.dumpDBbutton.Name = "dumpDBbutton";
            this.dumpDBbutton.Size = new System.Drawing.Size(182, 62);
            this.dumpDBbutton.TabIndex = 4;
            this.dumpDBbutton.Text = "Output IDs to text file";
            this.dumpDBbutton.UseVisualStyleBackColor = true;
            this.dumpDBbutton.Click += new System.EventHandler(this.dumpDBbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Goat",
            "Sheep",
            "Cow",
            "Jearsy Cow",
            "Dog",
            "Total Dayly Profit",
            "Total Milk produced",
            "Find ratio older than X",
            "avg Age",
            "Profitablilty of Dairy Vs Wool",
            "Red Animals",
            "Jearsy Cow Tax",
            "total Tax",
            "Jearsy Cow total profit",
            "Dog Cost vs All other costs(not tax)"});
            this.comboBox1.Location = new System.Drawing.Point(522, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Menue";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AuxButton
            // 
            this.AuxButton.Location = new System.Drawing.Point(350, 81);
            this.AuxButton.Name = "AuxButton";
            this.AuxButton.Size = new System.Drawing.Size(75, 23);
            this.AuxButton.TabIndex = 7;
            this.AuxButton.Text = "Go";
            this.AuxButton.UseVisualStyleBackColor = true;
            this.AuxButton.Click += new System.EventHandler(this.AuxButton_Click);
            // 
            // auxSearch
            // 
            this.auxSearch.Location = new System.Drawing.Point(153, 81);
            this.auxSearch.Name = "auxSearch";
            this.auxSearch.Size = new System.Drawing.Size(175, 22);
            this.auxSearch.TabIndex = 8;
            // 
            // auxBoxLable
            // 
            this.auxBoxLable.Location = new System.Drawing.Point(153, 38);
            this.auxBoxLable.Name = "auxBoxLable";
            this.auxBoxLable.Size = new System.Drawing.Size(175, 37);
            this.auxBoxLable.TabIndex = 9;
            this.auxBoxLable.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.auxBoxLable);
            this.Controls.Add(this.auxSearch);
            this.Controls.Add(this.AuxButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dumpDBbutton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.outBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox outBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button dumpDBbutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AuxButton;
        private System.Windows.Forms.TextBox auxSearch;
        private System.Windows.Forms.RichTextBox auxBoxLable;
    }
}

