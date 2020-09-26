using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Common;
namespace FDM
{
    public partial class frmCorrection : Form
    {
        public frmCorrection()
        {
            InitializeComponent();
        }
        InjectionLabTestBLL inbll = new InjectionLabTestBLL();
        LabTestBLL ltbll = new LabTestBLL();
        List<LabTest> ts;
        List<InjectionLabTest> inLbs;
        private void button1_Click(object sender, EventArgs e)
        {
            ts = ltbll.GetLabTests();
            inLbs = inbll.GetInjectionLabTests();
            foreach (InjectionLabTest  inLb in inLbs)
            {
                if (inLb.IsInjectionToken) continue;
                string s = inLb.Type.ToString();
                switch (s)
                {
                    case "Deserving":
                        LabTest x= (from t in ts where
                               t.LabTestId == inLb.Tests[0].LabTestId
                                   select t).Single<LabTest>();
                        inLb.CashReceived = Convert.ToDouble(x.Deserving);
                        this.listBox1.Items.Add(s);
                        break;
                    case "General":
                        LabTest x1 = (from t in ts
                                     where
                                         t.LabTestId == inLb.Tests[0].LabTestId
                                     select t).Single<LabTest>();
                        inLb.CashReceived = Convert.ToDouble(x1.General);
                        this.listBox1.Items.Add(s);
                        break;
                    case "Poor":
                        LabTest x2 = (from t in ts
                                     where
                                         t.LabTestId == inLb.Tests[0].LabTestId
                                     select t).Single<LabTest>();
                        inLb.CashReceived = Convert.ToDouble(x2.Poor);

                        this.listBox1.Items.Add(s);
                        break;
                    case "YCOD":
                        LabTest x3 = (from t in ts
                                     where
                                         t.LabTestId == inLb.Tests[0].LabTestId
                                     select t).Single<LabTest>();
                        inLb.CashReceived = Convert.ToDouble(x3.YCDO);

                        this.listBox1.Items.Add(s);
                        break;
                }
                inbll.UpdateInjectionLabTest(inLb);
            }          
            
        }
    }
}
