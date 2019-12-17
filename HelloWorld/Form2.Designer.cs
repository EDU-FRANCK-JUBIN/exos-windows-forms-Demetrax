namespace HelloWorld
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nœud2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nœud3");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nœud0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nœud4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nœud5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nœud1", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teAdress = new System.Windows.Forms.TextBox();
            this.teName = new System.Windows.Forms.TextBox();
            this.laAdress = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.liCity = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Submit = new System.Windows.Forms.Button();
            this.buCancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teAdress);
            this.groupBox1.Controls.Add(this.teName);
            this.groupBox1.Controls.Add(this.laAdress);
            this.groupBox1.Controls.Add(this.laName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Detail";
            // 
            // teAdress
            // 
            this.teAdress.Location = new System.Drawing.Point(86, 46);
            this.teAdress.Name = "teAdress";
            this.teAdress.Size = new System.Drawing.Size(151, 20);
            this.teAdress.TabIndex = 3;
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(86, 19);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(151, 20);
            this.teName.TabIndex = 2;
            // 
            // laAdress
            // 
            this.laAdress.AutoSize = true;
            this.laAdress.Location = new System.Drawing.Point(6, 54);
            this.laAdress.Name = "laAdress";
            this.laAdress.Size = new System.Drawing.Size(39, 13);
            this.laAdress.TabIndex = 1;
            this.laAdress.Text = "Adress";
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Location = new System.Drawing.Point(6, 27);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(35, 13);
            this.laName.TabIndex = 0;
            this.laName.Text = "Name";
            // 
            // liCity
            // 
            this.liCity.FormattingEnabled = true;
            this.liCity.Items.AddRange(new object[] {
            "Toulouse",
            "Paris",
            "Lopez"});
            this.liCity.Location = new System.Drawing.Point(21, 98);
            this.liCity.Name = "liCity";
            this.liCity.Size = new System.Drawing.Size(120, 69);
            this.liCity.TabIndex = 1;
            this.liCity.SelectedIndexChanged += new System.EventHandler(this.liCity_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(180, 98);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(180, 122);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(180, 203);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // buCancel
            // 
            this.buCancel.Location = new System.Drawing.Point(276, 203);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(75, 23);
            this.buCancel.TabIndex = 5;
            this.buCancel.Text = "Cancel";
            this.buCancel.UseVisualStyleBackColor = true;
            this.buCancel.Click += new System.EventHandler(this.buCancel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(276, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "ASP";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(276, 122);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "C#";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(431, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nœud2";
            treeNode1.Text = "Nœud2";
            treeNode2.Name = "Nœud3";
            treeNode2.Text = "Nœud3";
            treeNode3.Name = "Nœud0";
            treeNode3.Text = "Nœud0";
            treeNode4.Name = "Nœud4";
            treeNode4.Text = "Nœud4";
            treeNode5.Name = "Nœud5";
            treeNode5.Text = "Nœud5";
            treeNode6.Name = "Nœud1";
            treeNode6.Text = "Nœud1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 8;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HelloWorld.Properties.Resources.Sun;
            this.pictureBox5.Location = new System.Drawing.Point(639, 122);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 68);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HelloWorld.Properties.Resources.Sun;
            this.pictureBox4.Location = new System.Drawing.Point(587, 122);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 68);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HelloWorld.Properties.Resources.Sun;
            this.pictureBox3.Location = new System.Drawing.Point(535, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 68);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HelloWorld.Properties.Resources.Sun;
            this.pictureBox2.Location = new System.Drawing.Point(483, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 68);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HelloWorld.Properties.Resources.Sun;
            this.pictureBox1.Location = new System.Drawing.Point(431, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 68);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 240);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buCancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.liCity);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label laName;
        private System.Windows.Forms.Label laAdress;
        private System.Windows.Forms.TextBox teName;
        private System.Windows.Forms.TextBox teAdress;
        private System.Windows.Forms.ListBox liCity;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button buCancel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}