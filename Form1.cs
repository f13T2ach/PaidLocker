//�ṩ��С��Ӧ�ó���ʹ��
//�������wpf��Ŀ �����https://blog.csdn.net/dopdkfsds/article/details/93412133 ���ñ���Ŀ

namespace PaidLocker
{
  public partial class Lock : Form
    {
        public Lock()
        {
            InitializeComponent();
            //��ʼ��
            TipBackg.Visible = false;
            //�����Ƕ�ȡĿ¼���Զ��������Կ
            if (File.Exists(@"AutoSaveCorrectKey.txt"))
            {
                string[] lines = File.ReadAllLines(@"AutoSaveCorrectKey.txt");
                string result;
                if (!(VerificateKey_Sample(lines[0], out result)))
                {
                    AlwaysVisibleTip.Text = "�Զ��������Կ��Ч��";
                    TipBackg.Visible = true;
                }
            }
        }

        //������Ϣ
        //���ǡ����ء��ı��ĵ㰴��������
        private void HideTip_Click(object sender, EventArgs e)
        {
            TipBackg.Visible = false;
        }

        //������Ϣ
        //���ǡ����к�������⡱�ı��ĵ㰴�������� Ĭ��Ϊ��
        private void Helper_Click(object sender, EventArgs e)
        {
            //���������ת���йص���ҳ���ߵ���һ���ı��� ��Ϊ�û�����������
            MessageBox.Show("û���ҵ��й����кŵ���ʾ�������Ѱ���������Ѱ�������");
        }

        //������Ϣ
        //���ǵ���ύ��ť��Ĵ������ݣ�������ڡ�VerificateKey��������д����ʽ�������ڡ�VerifivateKey_Sample����д��һЩʾ����
        private void Submit_Click(object sender, EventArgs e)
        {
            string result;
            TipBackg.Visible = false;
            if(VerificateKey_Sample(KeyInput.Text,out result))
            {
                if (AutoLogin.Checked)
                {
                    KeyAccess(KeyInput.Text,true);
                }
            }
            else
            {
                TipBackg.Visible = true;
                AlwaysVisibleTip.Text = result;
            }
        }

        /// <summary>
        /// ������Ϣ
        /// ������֤���кŵĺ���
        /// </summary>
        /// <param name="key">�û������key</param>
        /// <param name="result">��������</param>
        /// <returns>�Ƿ�ͨ��</returns>
        private static bool VerificateKey(string key ,out string result)
        {
            result = "δ��֤��";
            return false;
        }

        //������Ϣ
        //����ʾ��
        private static bool VerificateKey_Sample(string key ,out string result)
        {
            //����������㷨������������㷨��
            long keyTurned;
            //ת��Ϊ������ʽ
            try
            { keyTurned = Convert.ToInt64(key); }
            catch
            { result = "��������кš�"; return false; }
            if(keyTurned>9999999999999999||keyTurned<1000000000000000)
            {
                result = "��������кš�";
                return false;
            }
            //���ݹ�ʽ��Ҳ�����ܱ�5����
            if(keyTurned % 5==0)
            {
                result = "����ɹ���";
                return true;
            }
            else
            {
                result = "���кŲ�����";
                return false;
            }
            //��Ҳ�ύһ��GET���󣬶��ǿ��Եġ�
        }

        //������Ϣ
        //������Key���ú�Ĵ�����
        private void KeyAccess(string key,bool isSave)
        {
            //�������������Ŀ �Ѿ�ͨ���ˡ�

            //�Զ�����
            if (isSave)
            { File.WriteAllText(@"AutoSaveCorrectKey.txt", key); }

            Close();
        }

    }
}