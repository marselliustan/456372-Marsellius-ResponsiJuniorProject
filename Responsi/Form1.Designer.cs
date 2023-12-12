namespace Responsi
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tb_nama = new System.Windows.Forms.TextBox();
            btn_insert = new System.Windows.Forms.Button();
            btn_delete = new System.Windows.Forms.Button();
            btn_edit = new System.Windows.Forms.Button();
            tb_iddep = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            btn_load = new System.Windows.Forms.Button();
            dgv_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_data).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan :";
            // 
            // tb_nama
            // 
            tb_nama.Location = new System.Drawing.Point(132, 32);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new System.Drawing.Size(172, 23);
            tb_nama.TabIndex = 2;
            // 
            // btn_insert
            // 
            btn_insert.Location = new System.Drawing.Point(27, 97);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new System.Drawing.Size(75, 23);
            btn_insert.TabIndex = 4;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new System.Drawing.Point(229, 97);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new System.Drawing.Size(75, 23);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new System.Drawing.Point(125, 97);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new System.Drawing.Size(75, 23);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // tb_iddep
            // 
            tb_iddep.Location = new System.Drawing.Point(132, 61);
            tb_iddep.Name = "tb_iddep";
            tb_iddep.Size = new System.Drawing.Size(172, 23);
            tb_iddep.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(329, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 15);
            label3.TabIndex = 8;
            label3.Text = "ID Departemen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(329, 46);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 15);
            label4.TabIndex = 9;
            label4.Text = "HR: HR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(329, 105);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(72, 15);
            label5.TabIndex = 10;
            label5.Text = "FIN: Finance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(329, 90);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(123, 15);
            label6.TabIndex = 11;
            label6.Text = "PM: Product Manager";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(329, 75);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(87, 15);
            label7.TabIndex = 12;
            label7.Text = "DEV: Developer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(329, 60);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(82, 15);
            label8.TabIndex = 13;
            label8.Text = "ENG: Engineer";
            // 
            // btn_load
            // 
            btn_load.Location = new System.Drawing.Point(377, 306);
            btn_load.Name = "btn_load";
            btn_load.Size = new System.Drawing.Size(75, 23);
            btn_load.TabIndex = 14;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // dgv_data
            // 
            dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_data.Location = new System.Drawing.Point(27, 135);
            dgv_data.Name = "dgv_data";
            dgv_data.RowTemplate.Height = 25;
            dgv_data.Size = new System.Drawing.Size(425, 151);
            dgv_data.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(479, 392);
            Controls.Add(dgv_data);
            Controls.Add(btn_load);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_iddep);
            Controls.Add(btn_edit);
            Controls.Add(btn_delete);
            Controls.Add(btn_insert);
            Controls.Add(tb_nama);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgv_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox tb_iddep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataGridView dgv_data;
    }
}
