using System;
using System.Drawing;
using System.Windows.Forms;

namespace winform_household_ledger
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.myRecordTabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.recordDataGridView = new System.Windows.Forms.DataGridView();
            this.recordContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordingTabPage = new System.Windows.Forms.TabPage();
            this.timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.plus10000Button = new System.Windows.Forms.Button();
            this.plus1000Button = new System.Windows.Forms.Button();
            this.plus100Button = new System.Windows.Forms.Button();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.recordButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outRadioButton = new System.Windows.Forms.RadioButton();
            this.inRadioButton = new System.Windows.Forms.RadioButton();
            this.statisticsTabPage = new System.Windows.Forms.TabPage();
            this.monthlyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.myRecordTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).BeginInit();
            this.recordContextMenuStrip.SuspendLayout();
            this.recordingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.statisticsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.myRecordTabPage);
            this.tabControl1.Controls.Add(this.recordingTabPage);
            this.tabControl1.Controls.Add(this.statisticsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // myRecordTabPage
            // 
            this.myRecordTabPage.Controls.Add(this.label6);
            this.myRecordTabPage.Controls.Add(this.monthComboBox);
            this.myRecordTabPage.Controls.Add(this.searchButton);
            this.myRecordTabPage.Controls.Add(this.yearNumericUpDown);
            this.myRecordTabPage.Controls.Add(this.recordDataGridView);
            this.myRecordTabPage.Location = new System.Drawing.Point(4, 22);
            this.myRecordTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myRecordTabPage.Name = "myRecordTabPage";
            this.myRecordTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myRecordTabPage.Size = new System.Drawing.Size(776, 435);
            this.myRecordTabPage.TabIndex = 0;
            this.myRecordTabPage.Text = "내 가계부";
            this.myRecordTabPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "*Shift 또는 Ctrl 키로 복수선택 가능    *오른쪽 클릭하여 삭제";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "1월",
            "2월",
            "3월",
            "4월",
            "5월",
            "6월",
            "7월",
            "8월",
            "9월",
            "10월",
            "11월",
            "12월"});
            this.monthComboBox.Location = new System.Drawing.Point(625, 4);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(67, 20);
            this.monthComboBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(698, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "조회";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(569, 5);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(50, 21);
            this.yearNumericUpDown.TabIndex = 2;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // recordDataGridView
            // 
            this.recordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordDataGridView.ContextMenuStrip = this.recordContextMenuStrip;
            this.recordDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recordDataGridView.Location = new System.Drawing.Point(3, 28);
            this.recordDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordDataGridView.Name = "recordDataGridView";
            this.recordDataGridView.ReadOnly = true;
            this.recordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordDataGridView.Size = new System.Drawing.Size(770, 405);
            this.recordDataGridView.TabIndex = 0;
            // 
            // recordContextMenuStrip
            // 
            this.recordContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.recordContextMenuStrip.Name = "recordContextMenuStrip";
            this.recordContextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "삭제(&D)";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // recordingTabPage
            // 
            this.recordingTabPage.Controls.Add(this.timeDateTimePicker);
            this.recordingTabPage.Controls.Add(this.amountNumericUpDown);
            this.recordingTabPage.Controls.Add(this.plus10000Button);
            this.recordingTabPage.Controls.Add(this.plus1000Button);
            this.recordingTabPage.Controls.Add(this.plus100Button);
            this.recordingTabPage.Controls.Add(this.memoTextBox);
            this.recordingTabPage.Controls.Add(this.categoryComboBox);
            this.recordingTabPage.Controls.Add(this.recordButton);
            this.recordingTabPage.Controls.Add(this.label5);
            this.recordingTabPage.Controls.Add(this.label4);
            this.recordingTabPage.Controls.Add(this.label3);
            this.recordingTabPage.Controls.Add(this.dateDateTimePicker);
            this.recordingTabPage.Controls.Add(this.label2);
            this.recordingTabPage.Controls.Add(this.label1);
            this.recordingTabPage.Controls.Add(this.outRadioButton);
            this.recordingTabPage.Controls.Add(this.inRadioButton);
            this.recordingTabPage.Location = new System.Drawing.Point(4, 22);
            this.recordingTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordingTabPage.Name = "recordingTabPage";
            this.recordingTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordingTabPage.Size = new System.Drawing.Size(776, 435);
            this.recordingTabPage.TabIndex = 1;
            this.recordingTabPage.Text = "기록하기";
            this.recordingTabPage.UseVisualStyleBackColor = true;
            // 
            // timeDateTimePicker
            // 
            this.timeDateTimePicker.CustomFormat = "";
            this.timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeDateTimePicker.Location = new System.Drawing.Point(321, 84);
            this.timeDateTimePicker.Name = "timeDateTimePicker";
            this.timeDateTimePicker.ShowUpDown = true;
            this.timeDateTimePicker.Size = new System.Drawing.Size(104, 21);
            this.timeDateTimePicker.TabIndex = 16;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(144, 136);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(119, 21);
            this.amountNumericUpDown.TabIndex = 15;
            // 
            // plus10000Button
            // 
            this.plus10000Button.Location = new System.Drawing.Point(428, 133);
            this.plus10000Button.Name = "plus10000Button";
            this.plus10000Button.Size = new System.Drawing.Size(75, 23);
            this.plus10000Button.TabIndex = 14;
            this.plus10000Button.Text = "+10000\\";
            this.plus10000Button.UseVisualStyleBackColor = true;
            this.plus10000Button.Click += new System.EventHandler(this.plus10000Button_Click);
            // 
            // plus1000Button
            // 
            this.plus1000Button.Location = new System.Drawing.Point(347, 133);
            this.plus1000Button.Name = "plus1000Button";
            this.plus1000Button.Size = new System.Drawing.Size(75, 23);
            this.plus1000Button.TabIndex = 13;
            this.plus1000Button.Text = "+1000\\";
            this.plus1000Button.UseVisualStyleBackColor = true;
            this.plus1000Button.Click += new System.EventHandler(this.plus1000Button_Click);
            // 
            // plus100Button
            // 
            this.plus100Button.Location = new System.Drawing.Point(269, 134);
            this.plus100Button.Name = "plus100Button";
            this.plus100Button.Size = new System.Drawing.Size(75, 23);
            this.plus100Button.TabIndex = 12;
            this.plus100Button.Text = "+100\\";
            this.plus100Button.UseVisualStyleBackColor = true;
            this.plus100Button.Click += new System.EventHandler(this.plus100Button_Click);
            // 
            // memoTextBox
            // 
            this.memoTextBox.Location = new System.Drawing.Point(144, 231);
            this.memoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(200, 21);
            this.memoTextBox.TabIndex = 10;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(144, 179);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(200, 20);
            this.categoryComboBox.TabIndex = 9;
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(60, 272);
            this.recordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(284, 30);
            this.recordButton.TabIndex = 8;
            this.recordButton.Text = "기록하기";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(60, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "메모";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(60, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "카테고리";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(60, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "금액";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Checked = false;
            this.dateDateTimePicker.Location = new System.Drawing.Point(144, 83);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(171, 21);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(60, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "날짜";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "수입/지출";
            // 
            // outRadioButton
            // 
            this.outRadioButton.AutoSize = true;
            this.outRadioButton.Location = new System.Drawing.Point(213, 38);
            this.outRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outRadioButton.Name = "outRadioButton";
            this.outRadioButton.Size = new System.Drawing.Size(47, 16);
            this.outRadioButton.TabIndex = 1;
            this.outRadioButton.Text = "지출";
            this.outRadioButton.UseVisualStyleBackColor = true;
            // 
            // inRadioButton
            // 
            this.inRadioButton.AutoSize = true;
            this.inRadioButton.Checked = true;
            this.inRadioButton.Location = new System.Drawing.Point(144, 38);
            this.inRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inRadioButton.Name = "inRadioButton";
            this.inRadioButton.Size = new System.Drawing.Size(47, 16);
            this.inRadioButton.TabIndex = 0;
            this.inRadioButton.TabStop = true;
            this.inRadioButton.Text = "수입";
            this.inRadioButton.UseVisualStyleBackColor = true;
            // 
            // statisticsTabPage
            // 
            this.statisticsTabPage.Controls.Add(this.monthlyChart);
            this.statisticsTabPage.Location = new System.Drawing.Point(4, 22);
            this.statisticsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statisticsTabPage.Name = "statisticsTabPage";
            this.statisticsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statisticsTabPage.Size = new System.Drawing.Size(776, 435);
            this.statisticsTabPage.TabIndex = 2;
            this.statisticsTabPage.Text = "통계";
            this.statisticsTabPage.UseVisualStyleBackColor = true;
            // 
            // monthlyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.monthlyChart.ChartAreas.Add(chartArea2);
            this.monthlyChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.monthlyChart.Legends.Add(legend2);
            this.monthlyChart.Location = new System.Drawing.Point(3, 2);
            this.monthlyChart.Name = "monthlyChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.monthlyChart.Series.Add(series2);
            this.monthlyChart.Size = new System.Drawing.Size(770, 431);
            this.monthlyChart.TabIndex = 0;
            this.monthlyChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.myRecordTabPage.ResumeLayout(false);
            this.myRecordTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).EndInit();
            this.recordContextMenuStrip.ResumeLayout(false);
            this.recordingTabPage.ResumeLayout(false);
            this.recordingTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.statisticsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage myRecordTabPage;
        private TabPage recordingTabPage;
        private TabPage statisticsTabPage;
        private DataGridView recordDataGridView;
        private TextBox memoTextBox;
        private ComboBox categoryComboBox;
        private Button recordButton;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dateDateTimePicker;
        private Label label2;
        private Label label1;
        private RadioButton outRadioButton;
        private RadioButton inRadioButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthlyChart;
        private Button plus10000Button;
        private Button plus1000Button;
        private Button plus100Button;
        private NumericUpDown amountNumericUpDown;
        private ComboBox monthComboBox;
        private Button searchButton;
        private NumericUpDown yearNumericUpDown;
        private DateTimePicker timeDateTimePicker;
        private ContextMenuStrip recordContextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label6;
    }
}
