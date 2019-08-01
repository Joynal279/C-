namespace Student_ManagementApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDept = new System.Windows.Forms.TextBox();
            this.buttonAction = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dept.";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(175, 37);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(175, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxDept
            // 
            this.textBoxDept.Location = new System.Drawing.Point(175, 115);
            this.textBoxDept.Name = "textBoxDept";
            this.textBoxDept.Size = new System.Drawing.Size(100, 20);
            this.textBoxDept.TabIndex = 5;
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(199, 182);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(75, 23);
            this.buttonAction.TabIndex = 6;
            this.buttonAction.Text = "Submit";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Barguna District",
            "Barisal District",
            "Bhola District",
            "Jhalokati District",
            "Patuakhali District",
            "Pirojpur District",
            "Bandarban District",
            "Brahmanbaria District",
            "Chandpur District",
            "Chittagong District",
            "Comilla District",
            "Cox\'s Bazar District",
            "Feni District",
            "khagrachhari District",
            "Lakshmipur District",
            "Noakhali District",
            "Rangamati District",
            "Dhaka District",
            "Faridpur District",
            "Gazipur District",
            "Gopalganj District",
            "Kishoreganj District",
            "Madaripur District",
            "Manikganj District",
            "Munshiganj District",
            "Narayanganj District",
            "Narsingdi District",
            "Rajbari District",
            "Shariatpur District",
            "Tangail District",
            "Bagerhat District",
            "Chuadanga District",
            "Jessore District",
            "Jhenaidah District",
            "Khulna District",
            "Kushtia District",
            "Magura District",
            "Meherpur District",
            "Narail District",
            "Satkhira District",
            "Jamalpur District",
            "Mymensingh District",
            "Netrokona District",
            "Sherpur District",
            "Bogra District",
            "Joypurhat District",
            "Naogaon District",
            "Natore District",
            "Chapai Nawabganj District",
            "Pabna District",
            "Rajshahi District",
            "Sirajganj District",
            "Dinajpur District",
            "Gaibandha District",
            "Kurigram District",
            "Lalmonirhat District",
            "Nilphamari District",
            "Panchagarh District",
            "Rangpur District",
            "Thakurgaon District",
            "Habiganj District",
            "Moulvibazar District",
            "Sunamganj District",
            "Sylhet District"});
            this.comboBox1.Location = new System.Drawing.Point(175, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "District";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.textBoxDept);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDept;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}

