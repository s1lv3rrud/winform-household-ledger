using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace winform_household_ledger
{
    public partial class Form1 : Form
    {
        public enum Type
        {
            None,
            수입,
            지출
        }

        public enum Category
        {
            None,
            식비,
            교통차량,
            문화생활,
            마트편의점,
            패션미용,
            생활용품,
            주거통신,
            건강,
            교육,
            경조사회비,
            부모님,
            기타
        }
        static ObservableCollection<Ledger> ledgers = new ObservableCollection<Ledger>();

        private void ledgersChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            updateRowSource();
            plotMonthlyChart();
        }

        private void updateRowSource()
        {
            // 선택된 연도와 월에 해당하는 기록만 필터링
            int selectedYear = (int)yearNumericUpDown.Value;
            int selectedMonth = monthComboBox.SelectedIndex + 1;

            var filteredLedgers = ledgers
                .Where(ledger => ledger.Date.Year == selectedYear && ledger.Date.Month == selectedMonth)
                .ToList();

            recordDataGridView.DataSource = filteredLedgers;
        }

        public Form1()
        {
            InitializeComponent();

            monthComboBox.SelectedIndex = DateTime.Now.Month - 1;

            LoadTransactionsFromCsv($"../../dataset.csv");

            ledgers.CollectionChanged += ledgersChanged;

            ledgersChanged(null, null);

            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        void addAmount(decimal value)
        {
            amountNumericUpDown.Value += value;
        }

        private void plus100Button_Click(object sender, EventArgs e)
        {
            addAmount(100);
        }

        private void plus1000Button_Click(object sender, EventArgs e)
        {
            addAmount(1000);
        }

        private void plus10000Button_Click(object sender, EventArgs e)
        {
            addAmount(10000);
        }
        public void SaveTransactionsToCsv(string filePath)
        {
            // CSV 파일에 기록 저장
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("type,amount,date,category,memo");
                foreach (var ledger in ledgers)
                {
                    writer.WriteLine(ledger.ToCsv());
                }
            }
        }
        public void LoadTransactionsFromCsv(string filePath)
        {
            // CSV 파일에서 기록 읽기
            using (StreamReader reader = new StreamReader(filePath))
            {
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    var ledger = new Ledger
                    {
                        Type = (Type)decimal.Parse(values[0]),
                        Amount = decimal.Parse(values[1]),
                        Date = DateTime.Parse(values[2]),
                        Category = (Category)decimal.Parse(values[3]),
                        Memo = values[4]
                    };
                    ledgers.Add(ledger);
                }
            }
        }
        private void recordButton_Click(object sender, EventArgs e)
        {
            var ledger = new Ledger
            {
                Type = inRadioButton.Checked ? (Type)1 : (Type)2,
                Amount = amountNumericUpDown.Value,
                Date = dateDateTimePicker.Value.Date + timeDateTimePicker.Value.TimeOfDay,
                Category = (Category)categoryComboBox.SelectedIndex,
                Memo = memoTextBox.Text
            };
            ledgers.Add(ledger);
            MessageBox.Show("기록되었습니다.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTransactionsToCsv($"../../dataset.csv");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cnt = recordDataGridView.SelectedRows.Count;
            DialogResult dr = MessageBox.Show(cnt + "개의 기록을 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var selectedRows = recordDataGridView.SelectedRows.Cast<DataGridViewRow>().ToList();
                foreach (var row in selectedRows)
                {
                    var ledgerToDelete = (Ledger)row.DataBoundItem;
                    ledgers.Remove(ledgerToDelete);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            updateRowSource();
        }        

        private void plotMonthlyChart()
        {
            // 최근 일년간의 데이터 통계화
            DateTime oneYearAgo = DateTime.Now.AddYears(-1);
            oneYearAgo = new DateTime(oneYearAgo.Year, oneYearAgo.Month, 1);

            // 월별 수입과 지출 계산
            var monthlyIncome = new Dictionary<DateTime, decimal>();
            var monthlyExpense = new Dictionary<DateTime, decimal>();
            for (int i = 1; i <= 12; i++)
            {
                DateTime month = oneYearAgo.AddMonths(i);
                monthlyIncome[month] = 0;
                monthlyExpense[month] = 0;
            }
            var filteredLedgers = ledgers.Where(ledger => ledger.Date >= oneYearAgo && ledger.Date <= DateTime.Now).ToList();
            foreach (var ledger in filteredLedgers)
            {
                DateTime month = new DateTime(ledger.Date.Year, ledger.Date.Month, 1);
                if (ledger.Type == Type.수입)
                {
                    monthlyIncome[month] += ledger.Amount;
                }
                else
                {
                    monthlyExpense[month] += Math.Abs(ledger.Amount);
                }
            }

            // 차트 초기화
            monthlyChart.Series.Clear();
            monthlyChart.ChartAreas.Clear();

            // 차트에 데이터 추가
            ChartArea chartArea = new ChartArea();
            monthlyChart.ChartAreas.Add(chartArea);
            Series incomeSeries = new Series("수입")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Green,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                MarkerColor = Color.Green,
                BorderWidth = 3
            };
            Series expenseSeries = new Series("지출")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                MarkerColor = Color.Red,
                BorderWidth = 3
            };
            foreach (var month in monthlyIncome.Keys)
            {
                incomeSeries.Points.AddXY(month.ToString("yyyy-MM"), monthlyIncome[month]);
                expenseSeries.Points.AddXY(month.ToString("yyyy-MM"), monthlyExpense[month]);
            }
            monthlyChart.Series.Add(incomeSeries);
            monthlyChart.Series.Add(expenseSeries);

            // 차트의 X축과 Y축 설정
            chartArea.AxisX.Title = "월";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisY.Title = "금액";
        }
    }
}
