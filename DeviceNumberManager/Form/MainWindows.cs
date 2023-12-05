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

            // �G���[�`�F�b�N
            if (!string.IsNullOrEmpty(has_err)) 
            {
                MessageBox.Show(has_err, "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            // �f�o�C�X�i���o�[�̃��X�g���쐬
            List<DeviceNumber> device_numbers = new List<DeviceNumber>();

            // ���[�v�Œǉ�
            for (int i = 1; i <= Convert.ToInt32(textNewNumber.Text); i++)
            {
                device_numbers.Add(new DeviceNumber(Convert.ToInt32(textRegisteredNumber.Text) + i));
            }

            // �f�[�^�\�[�X�ɃZ�b�g
            ViewResultNumbers.DataSource = device_numbers;

            // �\����\���؂�ւ�
            foreach (DataGridViewColumn column in ViewResultNumbers.Columns)
            {
                if (!column.Name.Equals(nameof(DeviceNumber.ManageNumber))) { column.Visible = false; }
            }
            //ViewResultNumbers.Columns["ManageNumber"].Visible = true;
        }

        private string? check_err()
        {
            if (string.IsNullOrEmpty(textRegisteredNumber.Text)) { return "�̔ԍςݔԍ��͕K�{�ł�"; }
            else if (!textRegisteredNumber.Text.Length.Equals(6)) { return "�̔ԍςݔԍ��̌������s���ł��i6�����j"; }
            else if (string.IsNullOrEmpty(textNewNumber.Text)) { return "�V�K���͕K�{�ł�"; }
            else if (!int.TryParse(textNewNumber.Text, out int _)) { return "�V�K���ɐ��l�ȊO�����͂���Ă��܂�"; }
            else { return null; };
        }
    }
}
