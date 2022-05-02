//提供给小众应用程序使用
//如果你是wpf项目 请参阅https://blog.csdn.net/dopdkfsds/article/details/93412133 调用本项目

namespace PaidLocker
{
  public partial class Lock : Form
    {
        public Lock()
        {
            InitializeComponent();
            //初始化
            TipBackg.Visible = false;
            //这里是读取目录下自动储存的密钥
            if (File.Exists(@"AutoSaveCorrectKey.txt"))
            {
                string[] lines = File.ReadAllLines(@"AutoSaveCorrectKey.txt");
                string result;
                if (!(VerificateKey_Sample(lines[0], out result)))
                {
                    AlwaysVisibleTip.Text = "自动保存的密钥无效了";
                    TipBackg.Visible = true;
                }
            }
        }

        //定制信息
        //这是“隐藏”文本的点按触发内容
        private void HideTip_Click(object sender, EventArgs e)
        {
            TipBackg.Visible = false;
        }

        //定制信息
        //这是“序列号相关问题”文本的点按触发内容 默认为空
        private void Helper_Click(object sender, EventArgs e)
        {
            //这里可以跳转到有关的网页或者弹出一个文本框 来为用户解答相关内容
            MessageBox.Show("没有找到有关序列号的提示。你可以寻找软件作者寻求帮助。");
        }

        //定制信息
        //这是点击提交按钮后的触发内容，你可以在“VerificateKey”函数编写处理方式。我们在“VerifivateKey_Sample”中写了一些示例。
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
        /// 定制信息
        /// 这是验证序列号的函数
        /// </summary>
        /// <param name="key">用户输入的key</param>
        /// <param name="result">错误内容</param>
        /// <returns>是否通过</returns>
        private static bool VerificateKey(string key ,out string result)
        {
            result = "未验证。";
            return false;
        }

        //定制信息
        //这是示例
        private static bool VerificateKey_Sample(string key ,out string result)
        {
            //如果是依靠算法，比如下面的算法。
            long keyTurned;
            //转换为长整数式
            try
            { keyTurned = Convert.ToInt64(key); }
            catch
            { result = "错误的序列号。"; return false; }
            if(keyTurned>9999999999999999||keyTurned<1000000000000000)
            {
                result = "错误的序列号。";
                return false;
            }
            //根据公式，也就是能被5整除
            if(keyTurned % 5==0)
            {
                result = "激活成功。";
                return true;
            }
            else
            {
                result = "序列号不存在";
                return false;
            }
            //你也提交一个GET请求，都是可以的。
        }

        //定制信息
        //这里是Key可用后的处理方案
        private void KeyAccess(string key,bool isSave)
        {
            //在这里告诉主项目 已经通过了。

            //自动保存
            if (isSave)
            { File.WriteAllText(@"AutoSaveCorrectKey.txt", key); }

            Close();
        }

    }
}