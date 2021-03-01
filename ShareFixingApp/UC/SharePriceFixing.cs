using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareFixingApp.Entityframework;
using System.Data.Entity.Migrations;

namespace ShareFixingApp.UC
{
    public partial class SharePriceFixing : UserControl
    {
        public SharePriceFixing()
        {
            InitializeComponent();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Now.Date.Subtract(dtpReport.Value.Date).TotalDays < 0)
                {
                    MessageBox.Show("No future dates allowed", "Message ");
                    return;
                }

                FixDailyReportShareHolderProfit(dtpReport.Value.Date);
                MessageBox.Show("Done", "Message");

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void FixDailyReportShareHolderProfit(DateTime date, bool update = false)
        {
            using (var context = new CurrencyCalculatorEntities())
            {
                var lastPasedDate = context.SHProfitDetails.ToList().OrderByDescending(x => x.DateAdded).FirstOrDefault(x => x.DateAdded.Subtract(date).Days < 0).DateAdded;

                var shpds = context.SHProfitDetails.Where(x => x.DateAdded == lastPasedDate.Date).ToList();

                var shs = context.ShareHolders.ToList();
                var totalValue = shpds.Sum(x => x.TodayShare);
                long temp = 0;
                Summary.Text = "";
                foreach (var shpd in shpds)
                {

                    var sh = shs.FirstOrDefault(s => s.Id == shpd.ShareHolderId);
                    var part = (long)(totalProfit.Value * shpd.TodayShare / totalValue);
                    var loan = context.LoanDetails.FirstOrDefault(l => l.LoanTakerId == sh.LoanTakerId && l.DateAdded == date);

                    var loanAmount = loan == null ? 0 : (decimal)loan.Amount;

                    temp += part;
                    var totalPart = ((long)(shpd.TodayShare + totalProfit.Value * shpd.TodayShare / totalValue - loanAmount));
                    var line = $"{sh.Name} , {part}, {totalPart}";
                    Summary.Text = Summary.Text + Environment.NewLine + line;

                    if (update)
                    {

                        var current = context.SHProfitDetails.FirstOrDefault(x => x.DateAdded == date && x.ShareHolderId == shpd.ShareHolderId);
                        if (current == null)
                        {
                            current = new SHProfitDetail();
                            current.ShareHolderId = shpd.ShareHolderId;
                            current.DateAdded = date;
                        }
                        current.Profit = part;
                        current.TodayShare = (shpd.TodayShare + part - loanAmount);
                        context.SHProfitDetails.AddOrUpdate(current);
                        context.SaveChanges();
                    }
                }

                //var lines = shpds.Select(x => $"{shs.FirstOrDefault(s => s.Id == x.ShareHolderId).Name} , {(long)(totalProfit.Value * 100 * shs.FirstOrDefault(s => s.Id == x.ShareHolderId).Amount / totalValue)}, {((long)(x.TodayShare + totalProfit.Value * 100 * shs.FirstOrDefault(s => s.Id == x.ShareHolderId).Amount / totalValue))}");
                //Summary.Text = string.Join(Environment.NewLine, lines);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update the details") == DialogResult.OK)
                {

                    FixDailyReportShareHolderProfit(dtpReport.Value.Date, true);
                    MessageBox.Show("Done", "Message");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
