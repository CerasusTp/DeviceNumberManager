using DeviceNumberManager.Model;

namespace DeviceNumberManager
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            var has_err = check_err();

            // エラーチェック
            if (!string.IsNullOrEmpty(has_err)) 
            {
                MessageBox.Show(has_err, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            // デバイスナンバーのリストを作成
            List<DeviceNumber> device_numbers = new List<DeviceNumber>();

            // ループで追加
            for (int i = 1; i <= Convert.ToInt32(textNewNumber.Text); i++)
            {
                device_numbers.Add(new DeviceNumber(Convert.ToInt32(textRegisteredNumber.Text) + i));
            }

            // データソースにセット
            ViewResultNumbers.DataSource = device_numbers;

            // 表示非表示切り替え
            foreach (DataGridViewColumn column in ViewResultNumbers.Columns)
            {
                if (!column.Name.Equals(nameof(DeviceNumber.ManageNumber))) { column.Visible = false; }
            }
            //ViewResultNumbers.Columns["ManageNumber"].Visible = true;
        }

        private string? check_err()
        {
            if (string.IsNullOrEmpty(textRegisteredNumber.Text)) { return "採番済み番号は必須です"; }
            else if (!textRegisteredNumber.Text.Length.Equals(6)) { return "採番済み番号の桁数が不正です（6文字）"; }
            else if (string.IsNullOrEmpty(textNewNumber.Text)) { return "新規数は必須です"; }
            else if (!int.TryParse(textNewNumber.Text, out int _)) { return "新規数に数値以外が入力されています"; }
            else { return null; };
        }
    }
}
