using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static winform_household_ledger.Form1;

namespace winform_household_ledger
{
    public class Ledger
    {
        public Form1.Type Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        public string Memo { get; set; }

        public string ToCsv()
        {
            // 기록을 csv 형식으로 반환, CSV 파일로 저장 시 사용
            return $"{(int)Type},{Amount},{Date.ToString("yyyy-MM-dd HH:mm:ss")},{(int)Category},{Memo}";
        }
    }
}
