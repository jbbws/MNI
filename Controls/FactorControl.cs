using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MNI.Base;

namespace MNI.Controls
{
    public partial class FactorControl : UserControl
    {
        public Factor Factor { get; set; }
        public bool Validated { get; set; }
        public bool Submited { get; set; }
        public FactorControl()
        {
            InitializeComponent();
        }
        public List<TextBox> getView()
        {
            List<TextBox> result = new List<TextBox>();
            result.Add(botTbx);
            result.Add(topTbx);
            result.Add(initTbx);
            result.Add(intTbx);
            return result;
        }
        public bool validateInputs(List<TextBox> view)
        {
            foreach (var item in view)
            {
                if (String.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show("EMPTY FILEDS");
                    return false;
                }
                try
                {
                    Convert.ToDouble(item.Text);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }
        public bool validateData(List<TextBox> view, out List<double> result)
        {
            var bot = Convert.ToDouble(view[0].Text);
            var top = Convert.ToDouble(view[1].Text);
            var value = Convert.ToDouble(view[2].Text);
            var interval = Convert.ToDouble(view[3].Text);
            result = new List<double>();
            if (interval < 0)
            {
                MessageBox.Show("INTREVAL LESS THAN ZERO ERROR");
                return false;
            }
            if (bot > top)
            {
                MessageBox.Show("BORDER ERROR");
                return false;
            }
            if (value > top || value < bot)
            {
                MessageBox.Show("POINT OUT OUF BORDER ERROR");
                return false;
            }
            if (value + interval > top || value -interval <bot)
            {
                MessageBox.Show("OUT OF RANGE CALCULATED");
                return false;
            }
            result.Add(bot);
            result.Add(top);
            result.Add(value);
            result.Add(interval);
            return true;
        }
        private void SubmitHandler(object sender, EventArgs e)
        {
            var items = getView();
            if (validateInputs(items))
            {
                List<double> data;
                Validated = validateData(items, out data);
                if (Validated)
                {
                    Submited = true;
                    lockView(false);
                    Factor = new Factor(data[0], data[1], data[2], data[3]);
                    MessageBox.Show("SUBMITED");
                }
                else
                {
                    Submited = false;
                    MessageBox.Show("INVALID");
                }
            }
        }
        private void lockView(bool param)
        {
            var view = getView();
            foreach (var item in view)
            {
                item.Enabled = param;
            }
            submitBtn.Enabled = param;
        }
        private void clearHanlder(object sender, EventArgs e)
        {
            Validated = false;
            Submited = false;
            var items = getView();
            foreach(var item in items)
            {
                item.Text = String.Empty;
            }
            lockView(true);
            Factor = null;
        }
    }
}
