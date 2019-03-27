namespace TestWinForm.UI
{
    partial class TeacherCourse
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
            this.coures_data = new System.Windows.Forms.DataGridView();
            this.room_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.room_query = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.con = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.room_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.course_time = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.program_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coures_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_data)).BeginInit();
            this.SuspendLayout();
            // 
            // coures_data
            // 
            this.coures_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coures_data.Location = new System.Drawing.Point(187, 36);
            this.coures_data.Name = "coures_data";
            this.coures_data.RowTemplate.Height = 23;
            this.coures_data.Size = new System.Drawing.Size(305, 173);
            this.coures_data.TabIndex = 0;
            this.coures_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coures_data_CellContentClick);
            // 
            // room_data
            // 
            this.room_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.room_data.Location = new System.Drawing.Point(187, 251);
            this.room_data.Name = "room_data";
            this.room_data.RowTemplate.Height = 23;
            this.room_data.Size = new System.Drawing.Size(305, 187);
            this.room_data.TabIndex = 1;
            this.room_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.room_data_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "全部课程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "空闲教室";
            // 
            // room_query
            // 
            this.room_query.Location = new System.Drawing.Point(244, 221);
            this.room_query.Name = "room_query";
            this.room_query.Size = new System.Drawing.Size(75, 23);
            this.room_query.TabIndex = 4;
            this.room_query.Text = "查询";
            this.room_query.UseVisualStyleBackColor = true;
            this.room_query.Click += new System.EventHandler(this.room_query_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "课程号";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(81, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 21);
            this.id.TabIndex = 6;
            // 
            // con
            // 
            this.con.Location = new System.Drawing.Point(81, 82);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(100, 21);
            this.con.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "课程名";
            // 
            // credit
            // 
            this.credit.Location = new System.Drawing.Point(81, 133);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(100, 21);
            this.credit.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "学分";
            // 
            // room_id
            // 
            this.room_id.Location = new System.Drawing.Point(81, 286);
            this.room_id.Name = "room_id";
            this.room_id.Size = new System.Drawing.Size(100, 21);
            this.room_id.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "教室编号";
            // 
            // course_time
            // 
            this.course_time.Location = new System.Drawing.Point(81, 235);
            this.course_time.Name = "course_time";
            this.course_time.Size = new System.Drawing.Size(100, 21);
            this.course_time.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "上课时间";
            // 
            // program_id
            // 
            this.program_id.Location = new System.Drawing.Point(81, 186);
            this.program_id.Name = "program_id";
            this.program_id.Size = new System.Drawing.Size(100, 21);
            this.program_id.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "培养方案编号";
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(12, 331);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(75, 23);
            this.query.TabIndex = 19;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(104, 365);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 20;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 365);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 21;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(104, 331);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 22;
            this.update.Text = "更新";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // TeacherCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.query);
            this.Controls.Add(this.room_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.course_time);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.program_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.con);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.room_query);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room_data);
            this.Controls.Add(this.coures_data);
            this.Name = "TeacherCourse";
            this.Text = "TeacherCourse";
            this.Load += new System.EventHandler(this.TeacherCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coures_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView coures_data;
        private System.Windows.Forms.DataGridView room_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button room_query;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox con;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox credit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox room_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox course_time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox program_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
    }
}