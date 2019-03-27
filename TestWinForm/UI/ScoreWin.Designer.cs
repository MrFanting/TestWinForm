namespace TestWinForm.UI
{
    partial class ScoreWin
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
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.course_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.TextBox();
            this.naxt = new System.Windows.Forms.Button();
            this.prior = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.course_data = new System.Windows.Forms.DataGridView();
            this.student_data = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.course_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程号";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(107, 44);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 21);
            this.id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "学    号";
            // 
            // course_name
            // 
            this.course_name.Enabled = false;
            this.course_name.Location = new System.Drawing.Point(107, 91);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(100, 21);
            this.course_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "课程名称";
            // 
            // student_id
            // 
            this.student_id.Enabled = false;
            this.student_id.Location = new System.Drawing.Point(107, 134);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(100, 21);
            this.student_id.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "成    绩";
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(107, 179);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(100, 21);
            this.grade.TabIndex = 8;
            // 
            // naxt
            // 
            this.naxt.Location = new System.Drawing.Point(123, 245);
            this.naxt.Name = "naxt";
            this.naxt.Size = new System.Drawing.Size(75, 23);
            this.naxt.TabIndex = 9;
            this.naxt.Text = "下一个";
            this.naxt.UseVisualStyleBackColor = true;
            this.naxt.Click += new System.EventHandler(this.button2_Click);
            // 
            // prior
            // 
            this.prior.Location = new System.Drawing.Point(26, 245);
            this.prior.Name = "prior";
            this.prior.Size = new System.Drawing.Size(75, 23);
            this.prior.TabIndex = 10;
            this.prior.Text = "上一个";
            this.prior.UseVisualStyleBackColor = true;
            this.prior.Click += new System.EventHandler(this.button3_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(26, 295);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 11;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button4_Click);
            // 
            // course_data
            // 
            this.course_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.course_data.Location = new System.Drawing.Point(224, 29);
            this.course_data.Name = "course_data";
            this.course_data.RowTemplate.Height = 23;
            this.course_data.Size = new System.Drawing.Size(268, 150);
            this.course_data.TabIndex = 12;
            this.course_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // student_data
            // 
            this.student_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_data.Location = new System.Drawing.Point(224, 217);
            this.student_data.Name = "student_data";
            this.student_data.RowTemplate.Height = 23;
            this.student_data.Size = new System.Drawing.Size(268, 150);
            this.student_data.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "全部课程";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "学生信息";
            // 
            // ScoreWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 406);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.student_data);
            this.Controls.Add(this.course_data);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.prior);
            this.Controls.Add(this.naxt);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "ScoreWin";
            this.Text = "成绩管理";
            this.Load += new System.EventHandler(this.ScoreWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.course_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox course_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.Button naxt;
        private System.Windows.Forms.Button prior;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DataGridView course_data;
        private System.Windows.Forms.DataGridView student_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}