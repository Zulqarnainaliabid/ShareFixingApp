using ShareFixingApp.Entityframework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareFixingApp.UC
{
    public partial class CleaningDataUC : UserControl
    {
        public CleaningDataUC()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                FixDailyReportShareHolderProfit(dtpReport.Value.Date);
            }catch(Exception exp)
            {
                MessageBox.Show("clean the data"+exp.Message);
            }
        }

        private void FixDailyReportShareHolderProfit(DateTime date, bool delete = false)
        {
            using (var context = new CurrencyCalculatorEntities())
            {

                var shpds = context.SHProfitDetails.Where(x => x.DateAdded == date.Date).ToList();

                Summary.Text = "";
                foreach (var shpd in shpds)
                {

                    var totalPart = shpd.TodayShare;
                    var line = $"{shpd.ShareHolder.Name} , {shpd.Profit}, {shpd.TodayShare}";
                    Summary.Text = Summary.Text + Environment.NewLine + line;

                    if (delete)
                    {

                        var current = context.SHProfitDetails.FirstOrDefault(x => x.Id ==  shpd.Id);
                        if (current == null)
                        {
                            MessageBox.Show("No record found to be deleted");
                            continue;
                        }
                        context.SHProfitDetails.Remove(current);
                        context.SaveChanges();
                    }
                }

                //var lines = shpds.Select(x => $"{shs.FirstOrDefault(s => s.Id == x.ShareHolderId).Name} , {(long)(totalProfit.Value * 100 * shs.FirstOrDefault(s => s.Id == x.ShareHolderId).Amount / totalValue)}, {((long)(x.TodayShare + totalProfit.Value * 100 * shs.FirstOrDefault(s => s.Id == x.ShareHolderId).Amount / totalValue))}");
                //Summary.Text = string.Join(Environment.NewLine, lines);
            }
            MessageBox.Show("Done");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="Password@0")
            {
                MessageBox.Show("Passowrd is incorect");
                return;
            }
            try
            {
                FixDailyReportShareHolderProfit(dtpReport.Value.Date,true);
            }
            catch (Exception exp)
            {
                MessageBox.Show("clean the data" + exp.Message);
            }
        }
    }
}
