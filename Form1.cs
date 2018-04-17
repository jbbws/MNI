using MNI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MNI.Controls;
using MNI.Base;

namespace MNI
{
    public partial class CustomForm : Form
    {
        InitExperimentControl initCtrl { get; set; }
        public Experiment exp { get; set; }
        public BindingSource source { get; set; }
        public Aproximation apr { get; set; }
        public StaticAnalyse stat { get; set; }

        public CustomForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            exp = new Experiment();
            initCtrl = new InitExperimentControl();
            initCtrl.InjectExp(exp);
            initCtrl.InjectView(this);
            InitPanel.Controls.Add(initCtrl);
            FactorPanel.Visible = false;
          //  AddFactorControl(exp.FactorCount); 
          //  dgExp.DataSource = exp.dgList;
            seriesGrid.AutoSize = true;            
        }
        public void AddFactorControl(int count)
        {
            FactorPanel.Visible = true;
            for (int i = 0; i < count; i++)
            {
                FactorPanel.Controls.Add(new FactorControl());
            }       
        }
        public void RemoveFactorControl()
        {
            while(FactorPanel.Controls.Count > 1)
            {
                FactorPanel.Controls.RemoveAt(FactorPanel.Controls.Count-1);
            }
            FactorPanel.Visible = false;
        }
        public bool CheckSubmit()
        {
            for(int i = 1; i < FactorPanel.Controls.Count;i++)
            {
                if((FactorPanel.Controls[i] as FactorControl).Submited == false )
                {
                    return false;
                }
            }
            return true;
        }
        public List<Factor> BuildFactorsList()
        {
            List<Factor> result = new List<Factor>();
            for(int i = 1; i < FactorPanel.Controls.Count; i++)
            {
                result.Add((FactorPanel.Controls[i] as FactorControl).Factor);
            }
            return result;
        }
        private void ShowApproximFunc(double[] answ)
        {
            string res = "F = ";
            string head = answ[0].ToString("F1");
            res = res + head + "x(" + 0 + ") ";
            for(int i = 1; i <answ.Length; i++)
            {
                res += answ[i] >= 0 ?"+ " +answ[i].ToString("F1")+"x("+i+") ":" - "+ answ[i].ToString("F1") + "x(" + i + ") ";
            }
            funcLbl.Text = res;
        }
        private void btnStartMNK_Click(object sender, EventArgs e)
        {
            BindingSource source = (BindingSource)seriesGrid.DataSource;
            apr.Gauss = apr.GetDataFromView((DataTable)source.DataSource);
            apr.DirectGaussMethod();
            apr.BackGaussMethod();
            ShowApproximFunc(apr.Answers);
            stat = new StaticAnalyse(apr.GetDataFromView(((DataTable)source.DataSource)),apr);
            fisherTbx.Text = stat.FisherKoef.ToString();
            determTbx.Text = stat.GetDeterminationKoef().ToString();
        }
        public void DisableGrid()
        {
            computeGbx.Enabled = false;
        }
        public void EnableGrid()
        {
            computeGbx.Enabled = true;
        }
        private DataTable CreateGridView()
        {
            DataTable table = new DataTable();           
            for(int i = 0; i< exp.FactorCount; i++)
            {
                DataColumn column = new DataColumn();
                column.DataType = typeof(double);
                column.ColumnName = "Фактор " + (i+1);
                table.Columns.Add(column);
            }
            DataColumn result = new DataColumn();
            result.DataType = typeof(double);
            result.ColumnName = "Результат";
            table.Columns.Add(result);
            for (int i = 0; i < exp.SeriesSource.Count; i++)
            {
                DataRow row = table.NewRow(); 
                for(int j = 0; j < exp.SeriesSource[i].Arguments.Count(); j++)
                {
                    row[j] = exp.SeriesSource[i].Arguments[j]; 
                }
                row[exp.SeriesSource[i].Arguments.Count()] = exp.SeriesSource[i].Result;
                table.Rows.Add(row);
            }
            return table;
        }
        private void buildExptBtn_Click(object sender, EventArgs e)
        {
            if (CheckSubmit() == true)
            {
                var factors = BuildFactorsList();
                exp.Factors = factors;
                var series = exp.Series();
                exp.SeriesSource = exp.CalculateSeries(series, new double[] { 2, 3, 0 });
                var table = CreateGridView();
                BindingSource source = new BindingSource();
                source.DataSource = table;
                seriesGrid.DataSource = source;
                apr = new Aproximation(exp.FactorCount, exp.SeriesSource.Count);
                EnableGrid();

            }
            else
            {
                MessageBox.Show("NOT SUBMITED FACTOR FORM");
            }
        }
        public void Dispose()
        {
            stat = null;
            apr = null;
            seriesGrid.DataSource = null;
            seriesGrid.Rows.Clear();
            seriesGrid.Columns.Clear();
            fisherTbx.Text = String.Empty;
            determTbx.Text = string.Empty;
            funcLbl.Text = String.Empty;
            DisableGrid();
        }
        private void clearMNKBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
