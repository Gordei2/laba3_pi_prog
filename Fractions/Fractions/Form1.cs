using System;
using System.Text.RegularExpressions;

namespace Fractions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onPlusClick(object sender, EventArgs e)
        {
            var frac = parseInput();
            if (frac.Item1 is null || frac.Item2 is null)
            {
                check.Text = "";
                resUpBox.Text = "";
                resDownBox.Text = "";
                return;
            }

            var res = frac.Item1 + frac.Item2;

            resUpBox.Text = res.num.ToString();
            resDownBox.Text = res.den.ToString();
        }

        private void onMinusClick(object sender, EventArgs e)
        {
            var frac = parseInput();
            if (frac.Item1 is null || frac.Item2 is null)
            {
                check.Text = "";
                resUpBox.Text = "";
                resDownBox.Text = "";
                return;
            }

            var res = frac.Item1 - frac.Item2;

            resUpBox.Text = res.num.ToString();
            resDownBox.Text = res.den.ToString();
        }

        private void onMultiplyClick(object sender, EventArgs e)
        {
            var frac = parseInput();
            if (frac.Item1 is null || frac.Item2 is null)
            {
                check.Text = "";
                resUpBox.Text = "";
                resDownBox.Text = "";
                return;
            }

            var res = frac.Item1 * frac.Item2;

            resUpBox.Text = res.num.ToString();
            resDownBox.Text = res.den.ToString();
        }

        private void onDivisionClick(object sender, EventArgs e)
        {
            var frac = parseInput();
            if (frac.Item1 is null || frac.Item2 is null)
            {
                check.Text = "";
                resUpBox.Text = "";
                resDownBox.Text = "";
                return;
            }

            var res = frac.Item1 / frac.Item2;

            resUpBox.Text = res.num.ToString();
            resDownBox.Text = res.den.ToString();
        }

        private void onEqualClick(object sender, EventArgs e)
        {
            var frac = parseInput();
            if (frac.Item1 is null || frac.Item2 is null)
            {
                check.Text = "";
                resUpBox.Text = "";
                resDownBox.Text = "";
                return;
            }

            var res = frac.Item1 == frac.Item2;

            check.Text = res.ToString();
        }

        private void onClickNonEqual(object sender, EventArgs e)
        {
            var frac = parseInput();
            if (frac.Item1 is null || frac.Item2 is null)
            {
                check.Text = "";
                resUpBox.Text = "";
                resDownBox.Text = "";
                return;
            }

            var res = frac.Item1 != frac.Item2;

            check.Text = res.ToString();
        }

        private (Fraction?, Fraction?) parseInput()
        {
            try
            {
                var luv = long.Parse(leftUpBox.Text);
                var ldv = uint.Parse(leftDownBox.Text);
                var ruv = long.Parse(rightUpBox.Text);
                var rdv = uint.Parse(rightDownBox.Text);

                return (new Fraction(luv, ldv), new Fraction(ruv, rdv));
            } catch (ArgumentException)
            {
                MessageBox.Show("Incorrect number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (OverflowException)
            {
                MessageBox.Show("Number overflow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (FormatException)
            {
                MessageBox.Show("Incorrect format exception", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (null, null);
        }

        private void onKeyPressed(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            var regex1 = new Regex(@"[1-9\b-]");
            var regex2 = new Regex(@"[0-9\b]");
            if (!(tb.Text.Length == 0 && regex1.IsMatch(e.KeyChar.ToString()) 
                || tb.Text.Length != 0 && regex2.IsMatch(e.KeyChar.ToString())))
                e.Handled = true;
        }

        private void onKeyDownPressed(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            var regex1 = new Regex(@"[1-9\b]");
            var regex2 = new Regex(@"[0-9\b]");
            if (!(tb.Text.Length == 0 && regex1.IsMatch(e.KeyChar.ToString())
                || tb.Text.Length != 0 && regex2.IsMatch(e.KeyChar.ToString())))
                e.Handled = true;
        }
    }
}