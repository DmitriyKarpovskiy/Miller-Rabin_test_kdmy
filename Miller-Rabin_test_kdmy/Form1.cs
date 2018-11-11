using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Numerics;

namespace Miller_Rabin_test_kdmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height); //no smaller than design size
            this.MaximumSize = new Size(this.Width, this.Height); //no bigger than design size
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Text-box for a number allows to enter only digits
            {
                e.Handled = true;
            }
        }

        public bool MillerRabinTest(BigInteger n, int k)
        {
            // if n == 2 or n == 3 - 'simple', return true
            if (n == 2 || n == 3)
                return true;

            // if n < 2 or n is eve - false
            if (n < 2 || n % 2 == 0)
                return false;

            // show n − 1 as (2^s)·t, where t is not even
            BigInteger t = n - 1;

            int s = 0;

            while (t % 2 == 0)
            {
                t /= 2;
                s += 1;
            }

            // repeat k times
            for (int i = 0; i < k; i++)
            {
                // select random nunber a in [2, n − 2]
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                byte[] _a = new byte[n.ToByteArray().LongLength];

                BigInteger a;

                do
                {
                    rng.GetBytes(_a);
                    a = new BigInteger(_a);
                }
                while (a < 2 || a >= n - 2);

                // x ← a^t mod n
                BigInteger x = BigInteger.ModPow(a, t, n);

                // if x == 1 ore x == n − 1, next iteration
                if (x == 1 || x == n - 1)
                    continue;

                // repeat s − 1 times
                for (int r = 1; r < s; r++)
                {
                    // x ← x^2 mod n
                    x = BigInteger.ModPow(x, 2, n);

                    // if x == 1, return "composite"
                    if (x == 1)
                        return false;

                    // if x == n − 1, next iteration of outer loop
                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }

            // return "simple"
            return true;
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger n = Convert.ToInt64(textBox1.Text);
                bool res = MillerRabinTest(n, 10);
                if (res)
                {
                    lb_result.Text = "Is simple";
                }
                else
                {
                    lb_result.Text = "Is NOT simple";
                }
            }
            catch
            {
                lb_result.Text = "Something goes wrong";
            }
        }
    }
}
