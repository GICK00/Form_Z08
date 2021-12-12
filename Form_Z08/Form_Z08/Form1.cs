using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Form_Z08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder str = new StringBuilder(Convert.ToString(textBoxStr.Text));
                if (str.Length == 0)
                    throw new Exception("Строка должна содержать хотябы 1 символ!");

                max(str);
            }
            catch (Exception ex)
            {
                textBoxResult.Text = $"{ex.Message}";
            }
        }
        public void max(StringBuilder str)
        {
            int max = 0;
            Regex reg = new Regex(@"(?<!\d+)-?\d+");
            MatchCollection maxNum = reg.Matches(str.ToString());
            foreach (Match match in maxNum)
            {
                if (int.Parse(match.Value) > max)
                {
                    max = int.Parse(match.Value);
                }
            }
            textBoxResult.Text = "Максимально число в строке: " + max;
        }
    }
}
