using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8Pg405_LumberjackFlapjack
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                return;
            }
            Lumberjack lumberjack = new Lumberjack(textBoxName.Text);
            breakfastLine.Enqueue(lumberjack);
            RedrawList();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0)
            {
                return;
            }
            Flapjack food;
            if (crispy.Checked == true)
            {
                food = Flapjack.Crispy;
            }
            else if (soggy.Checked == true)
            {
                food = Flapjack.Soggy;
            }
            else if (browned.Checked == true)
            {
                food = Flapjack.Browned;
            }
            else
            {
                food = Flapjack.Banana;
            }

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            string text = currentLumberjack.Name + " has " + (int)howMany.Value + " flapjacks";
            textBoxFlapjacks.Text += text + Environment.NewLine;
            RedrawList();
        }

        private void RedrawList()
        {
            line.Items.Clear();
            foreach (Lumberjack personInLine in breakfastLine)
            {
                line.Items.Add(personInLine.Name);
            }
        }

        private void buttonNextLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            RedrawList();
        }
    }
}
