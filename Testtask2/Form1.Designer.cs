
namespace Testtask2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testTaskDataSet5 = new Testtask2.TestTaskDataSet5();
            this.TabConrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.aprilBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.testTaskDataSet4 = new Testtask2.TestTaskDataSet4();
            this.aprilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testTaskDataSet3 = new Testtask2.TestTaskDataSet3();
            this.departmentTableAdapter = new Testtask2.TestTaskDataSet2TableAdapters.DepartmentTableAdapter();
            this.aprilTableAdapter1 = new Testtask2.TestTaskDataSet3TableAdapters.aprilTableAdapter();
            this.aprilTableAdapter2 = new Testtask2.TestTaskDataSet4TableAdapters.aprilTableAdapter();
            this.departmentTableAdapter1 = new Testtask2.TestTaskDataSet5TableAdapters.DepartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTaskDataSet5)).BeginInit();
            this.TabConrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprilBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTaskDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTaskDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            this.departmentBindingSource1.DataSource = this.testTaskDataSet5;
            // 
            // testTaskDataSet5
            // 
            this.testTaskDataSet5.DataSetName = "TestTaskDataSet5";
            this.testTaskDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TabConrol
            // 
            this.TabConrol.Controls.Add(this.tabPage1);
            this.TabConrol.Controls.Add(this.tabPage2);
            this.TabConrol.Controls.Add(this.tabPage3);
            this.TabConrol.Controls.Add(this.tabPage4);
            this.TabConrol.Controls.Add(this.tabPage5);
            this.TabConrol.Controls.Add(this.tabPage6);
            this.TabConrol.Controls.Add(this.tabPage7);
            this.TabConrol.Controls.Add(this.tabPage8);
            this.TabConrol.Controls.Add(this.tabPage9);
            this.TabConrol.Controls.Add(this.tabPage10);
            this.TabConrol.Controls.Add(this.tabPage11);
            this.TabConrol.Controls.Add(this.tabPage12);
            this.TabConrol.Location = new System.Drawing.Point(264, 0);
            this.TabConrol.Name = "TabConrol";
            this.TabConrol.SelectedIndex = 0;
            this.TabConrol.Size = new System.Drawing.Size(728, 469);
            this.TabConrol.TabIndex = 1;
            this.TabConrol.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabConrol_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Январь";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(750, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "DepartmentId";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FIO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Position";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "2";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "3";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "4";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "5";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "6";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Февраль";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(720, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Март";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(720, 443);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Апрель";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(720, 443);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Май";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(720, 443);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Июнь";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(720, 443);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Июль";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(720, 443);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Август";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(720, 443);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Сентябрь";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(720, 443);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Октябрь";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(720, 443);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "Ноябрь";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(720, 443);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "Декабрь";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // aprilBindingSource2
            // 
            this.aprilBindingSource2.DataMember = "april";
            this.aprilBindingSource2.DataSource = this.testTaskDataSet4;
            // 
            // testTaskDataSet4
            // 
            this.testTaskDataSet4.DataSetName = "TestTaskDataSet4";
            this.testTaskDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aprilBindingSource1
            // 
            this.aprilBindingSource1.DataMember = "april";
            this.aprilBindingSource1.DataSource = this.testTaskDataSet3;
            // 
            // testTaskDataSet3
            // 
            this.testTaskDataSet3.DataSetName = "TestTaskDataSet3";
            this.testTaskDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // aprilTableAdapter1
            // 
            this.aprilTableAdapter1.ClearBeforeFill = true;
            // 
            // aprilTableAdapter2
            // 
            this.aprilTableAdapter2.ClearBeforeFill = true;
            // 
            // departmentTableAdapter1
            // 
            this.departmentTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 468);
            this.Controls.Add(this.TabConrol);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "TTTW";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTaskDataSet5)).EndInit();
            this.TabConrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprilBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTaskDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aprilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTaskDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl TabConrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private TestTaskDataSet2TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TestTaskDataSet3 testTaskDataSet3;
        private System.Windows.Forms.BindingSource aprilBindingSource1;
        private TestTaskDataSet3TableAdapters.aprilTableAdapter aprilTableAdapter1;
        private TestTaskDataSet4 testTaskDataSet4;
        private System.Windows.Forms.BindingSource aprilBindingSource2;
        private TestTaskDataSet4TableAdapters.aprilTableAdapter aprilTableAdapter2;
        private TestTaskDataSet5 testTaskDataSet5;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private TestTaskDataSet5TableAdapters.DepartmentTableAdapter departmentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

