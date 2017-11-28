using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSpeed
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            TimeTextBox.Text = GetCurrentTime();

            CommitList.Columns.Add("Time", 100);
            CommitList.Columns.Add("Down", 40);
            CommitList.Columns.Add("Up", 40);
            CommitList.Columns.Add("Comment", 150);
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            TimeTextBox.Text = GetCurrentTime();
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            string[] array = new string[4];
            array[0] = "4PM";
            array[1] = "0.01";
            array[2] = "4.63";
            array[3] = "This is the comment field";
            CommitList.Items.Add(new ListViewItem(array));
        }



        public string GetCurrentTime()
        {
            DateTime currentTime;
            string workingString;
            string temp;

            currentTime = DateTime.Now;

            temp = currentTime.Hour.ToString();

            if (currentTime.Hour < 10)
            {
                temp = "0" + temp;
            }

            workingString = temp;

            temp = currentTime.Minute.ToString();

            if (currentTime.Minute < 10)
            {
                temp = "0" + temp;
            }

            workingString += ":" + temp;

            temp = currentTime.Day.ToString();

            if (currentTime.Day < 10)
            {
                temp = "0" + temp;
            }

            workingString += " " + temp;

            temp = currentTime.Month.ToString();

            if (currentTime.Month < 10)
            {
                temp = "0" + temp;
            }

            workingString += "/" + temp;

            workingString += "/" + currentTime.Year.ToString().Substring(2);

            return workingString;
        }
    }
}
