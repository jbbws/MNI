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
    public partial class InitExperimentControl : UserControl
    {
        public Experiment Experiment { get; set; }
        public CustomForm Root { get; set; }
        bool checkInput(string input, out int res)
        {
            try
            {
                int result = Convert.ToInt32(input);
                res = result;
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("CONVERT FAIL, TRY AGAIN");
                res = -1;
                return false;
            }
        }
        void checkRadio()
        {
            if (setModelRbtn.Checked == true)
                Experiment.ExperimentType = Experiment.Type.Simple;
            else 
            if(setOptimRbtn.Checked == true){
                switch(expTypeCbx.SelectedIndex) {
                    case 0:
                        Experiment.ExperimentType = Experiment.Type.Maximm;
                        break;
                    case 1:
                        Experiment.ExperimentType = Experiment.Type.Minimal;
                        break;
                    default:
                        expTypeCbx.SelectedIndex = 0;
                        Experiment.ExperimentType = Experiment.Type.Maximm;
                        break;
                }   
            }
        }
        void clear()
        {
            factsCountTbx.Text = String.Empty;
            Experiment.ExperimentType = Experiment.Type.Undefined;
            Experiment.Factors = null;
            Experiment.FactorCount = 0;
            setModelRbtn.Checked = true;
            setOptimRbtn.Checked = false;
            expTypeCbx.SelectedItem = 0;
            Root.RemoveFactorControl();
        }
        public InitExperimentControl()
        {
            InitializeComponent();  
        }

        private void acceptExpBtn_Click(object sender, EventArgs e)
        {
            Root.RemoveFactorControl();
            int factCount;
            if(checkInput(factsCountTbx.Text, out factCount))
            {
                Experiment.FactorCount = factCount;
                checkRadio();
                Root.AddFactorControl(Experiment.FactorCount);
            }
            
        }
        private void InitExperimentControl_Load(object sender, EventArgs e)
        {
            expTypeCbx.SelectedItem = expTypeCbx.Items[0];
        }

        private void clearExpBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
    public static class InitExperimentControlExtentions
    {
        public static void InjectExp(this InitExperimentControl control, Experiment exp)
        {
            control.Experiment = exp;
        }
        public static void InjectView(this InitExperimentControl control, CustomForm view)
        {
            control.Root = view;
        }
    }
}
