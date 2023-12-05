using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceNumberManager.Model
{
    public class DeviceNumber
    {
        [DisplayName("管理番号")]
        public string? ManageNumber { get; set; }

        [DisplayName("記号")]
        public string Mark { get; set; } = "N";

        [DisplayName("番号")]
        public int MainNumber { get; set; }

        [DisplayName("チェックデジット")]
        public int DigitNumber{ get; set; }

        public DeviceNumber(int _main_number)
        {
            MainNumber = _main_number;
            DigitNumber = CalcDegit(_main_number);
            ManageNumber = $"{Mark}{MainNumber.ToString("000000")}{DigitNumber}";
        }

        public static int CalcDegit(int _main_number)
        {
            int sum = 0;
            // 文字列に変換して配列に格納
            char[] rev_num = _main_number.ToString().ToCharArray();
            // 配列を反転
            Array.Reverse(rev_num);
            for (int i = 0; i < rev_num.Count(); i++)
            {
                sum += Convert.ToInt32(rev_num[i].ToString()) * (i % 6 + 2);
            }

            // 余り算出
            int mod = sum % 11;

            // 余りが0 or 1の場合、チェックデジットは0
            if (mod.Equals(0) || mod.Equals(1)) { return 0; }
            else { return 11 - mod; }
        }
    }
}
