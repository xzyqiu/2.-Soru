using System;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            double indirim = 0;

            if (checkBoxKazak.Checked && checkBoxGomlek.Checked && checkBoxPantolon.Checked)
            {
                indirim = 0.30; 
            }
            else if (checkBoxKazak.Checked && checkBoxGomlek.Checked)
            {
                indirim = 0.20; 
            }
            else if (checkBoxKazak.Checked || checkBoxGomlek.Checked || checkBoxPantolon.Checked)
            {
                if (checkBoxKazak.Checked)
                    indirim = 0.15; 
                else if (checkBoxGomlek.Checked)
                    indirim = 0.20; 
                else if (checkBoxPantolon.Checked)
                    indirim = 0.30; 
            }
            labelSonuc.Text = "İndirim: %" + (indirim * 100).ToString();
        }
    }

    public abstract class Urun
    {
        public abstract double IndirimYap();
    }

    public class Kazak : Urun
    {
        public override double IndirimYap()
        {
            return 0.15;
        }
    }

    public class Gomlek : Urun
    {
        public override double IndirimYap()
        {
            return 0.20;
        }
    }

    public class Pantolon : Urun
    {
        public override double IndirimYap()
        {
            return 0.30;
        }
    }
}
