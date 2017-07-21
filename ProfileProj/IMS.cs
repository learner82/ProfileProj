using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace ProfileProj
{
    public partial class IMS : Form
    {
        bool bIsSearching;
        Utils Utils = new Utils();
        DataSet dsInformations = new DataSet();

        public IMS()
        {
            InitializeComponent();
        }

        private void IMS_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;

            ClearBtn.Enabled = false;
            DBFetcher db = new DBFetcher();

            port1Comb.Items.Clear(); //To have the first item selected in the combo box
            port2Comb.Items.Clear();
            var dsPortfolios = db.GetDataForPortfolios();
            foreach (DataRow dr in dsPortfolios.Tables[0].Rows)
            {
                port1Comb.Items.Add(dr["PF_Shortcut1"]);
                port2Comb.Items.Add(dr["PF_Shortcut1"]);
            }

            curComb.Items.Clear();
            var dsCurrency = db.GetDataForCurComb();
            foreach(DataRow dr in dsCurrency.Tables[0].Rows)
            {
                curComb.Items.Add(dr["CR_Name1"]);
            }
            
            ChartControl portChart = new ChartControl();
            
        }

        private void Port1Comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox port1Comb = (ComboBox) sender;

            string selectedPort1 = (string) port1Comb.SelectedItem;
            int count = 0;
            int resultIdx = -1;

            resultIdx = port1Comb.FindStringExact(selectedPort1);

            while (resultIdx != -1)
            {
                port1Comb.Items.RemoveAt(resultIdx);
                count += 1;
                resultIdx = port1Comb.FindStringExact(selectedPort1, resultIdx);

            }
        }

        private void Port2Comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox port2Comb = (ComboBox)sender;

            string selectedPort2 = (string)port1Comb.SelectedItem;
            int count = 0;
            int resultIdx = -1;

            resultIdx = port2Comb.FindStringExact(selectedPort2);

            while (resultIdx != -1)
            {
                port2Comb.Items.RemoveAt(resultIdx);
                count += 1;
                resultIdx = port2Comb.FindStringExact(selectedPort2, resultIdx);

            }
        }

        private void CurComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox curComb = (ComboBox)sender;

            string selectedCur = (string)curComb.SelectedItem;
            int count = 0;
            int resultIdx = -1;

            resultIdx = port2Comb.FindStringExact(selectedCur);

            while (resultIdx != -1)
            {
                port2Comb.Items.RemoveAt(resultIdx);
                count += 1;
                resultIdx = port2Comb.FindStringExact(selectedCur, resultIdx);

            }
        }

        private void dateFromPick_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateToPick_ValueChanged(object sender, EventArgs e)
        {
        
        }
        
        private void executeBtn_Click(object sender, EventArgs e)
        {

            ClearScren();

            bIsSearching = true;

            Application.DoEvents();

            DBFetcher db = new DBFetcher();
          
            ClearBtn.Enabled = true;
            
            Portfolio portfolio1;
            Portfolio portfolio2;

            List<Portfolio> portfolios = new List<Portfolio>();

           
            var dateFrom = dateFromPick.Value;
            var dateTo = dateToPick.Value;

            if (dateFrom >= DateTime.Now || dateFrom >= dateTo || dateTo >= DateTime.Now)
                {
                    MessageBox.Show(Utils.sWrongDates);
                    return;
                }

            if (port1Comb.SelectedItem == null && port2Comb.SelectedItem == null)
            {
                MessageBox.Show(Utils.sWrongWithPort);
                return;
            }

            if (radioBtn1.Checked == true && radioBtn2.Checked == false)
            {

                if (port1Comb.SelectedItem != null)
                {
                    portfolio1 = new Portfolio((string)port1Comb.SelectedItem);
                    portfolios.Add(portfolio1);

                    if (port2Comb.SelectedItem == null)
                    {
                        Application.DoEvents();
                        dsInformations = db.GetDataWithCurr(portfolios, dateFrom, dateTo);

                        if (dsInformations.Tables[0].Rows.Count == 0)
                        {
                            port1CurData.Text = Utils.sEmptyData;
                            port1StartBalData.Text = Utils.sEmptyData;
                            port1ReturnData.Text = Utils.sEmptyData;
                            port1InOutFlowsData.Text = Utils.sEmptyData;
                            port1EndBalData.Text = Utils.sEmptyData;
                            port1PLData.Text = Utils.sEmptyData;

                            port2CurData.Text = Utils.sNoChoiseString;
                            port2StartBalData.Text = Utils.sNoChoiseString;
                            port2ReturnData.Text = Utils.sNoChoiseString;
                            port2InOutFlowsData.Text = Utils.sNoChoiseString;
                            port2EndBalData.Text = Utils.sNoChoiseString;
                            port2PLData.Text = Utils.sNoChoiseString;
                            return;
                        }

                        port1CurData.Text = Utils.GetCurrString(dsInformations, 0);
                        port1StartBalData.Text = Utils.dGetBalStart(dsInformations, 0).ToString();
                        port1EndBalData.Text = Utils.dGetBalEnd(dsInformations, 0).ToString();
                        port1InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 0).ToString();
                        port1PLData.Text = Utils.GetPLString(dsInformations, 0);
                        port1ReturnData.Text = Utils.GetPeriodString(dsInformations, 0);

                        Utils.DrawSeriesChart(portChart, dsInformations.Tables[0], "Portfolio 1");

                        port2CurData.Text = Utils.sNoChoiseString;
                        port2StartBalData.Text = Utils.sNoChoiseString;
                        port2ReturnData.Text = Utils.sNoChoiseString;
                        port2InOutFlowsData.Text = Utils.sNoChoiseString;
                        port2EndBalData.Text = Utils.sNoChoiseString;
                        port2PLData.Text = Utils.sNoChoiseString;

                        bIsSearching = false;
                        
                        return;
                    }

                    else if (port2Comb.SelectedItem != null)
                    {
                        portfolio2 = new Portfolio((string)port2Comb.SelectedItem);
                        portfolios.Add(portfolio2);

                        Application.DoEvents();

                        dsInformations = db.GetDataWithCurr(portfolios, dateFrom, dateTo);

                        if (dsInformations == null )
                        {
                            port1CurData.Text = Utils.sEmptyData;
                            port1StartBalData.Text = Utils.sEmptyData;
                            port1ReturnData.Text = Utils.sEmptyData;
                            port1InOutFlowsData.Text = Utils.sEmptyData;
                            port1EndBalData.Text = Utils.sEmptyData;
                            port1PLData.Text = Utils.sEmptyData;

                            port2CurData.Text = Utils.sEmptyData;
                            port2StartBalData.Text = Utils.sEmptyData;
                            port2ReturnData.Text = Utils.sEmptyData;
                            port2InOutFlowsData.Text = Utils.sEmptyData;
                            port2EndBalData.Text = Utils.sEmptyData;
                            port2PLData.Text = Utils.sEmptyData;

                            bIsSearching = false;
                            return;
                        }

                        else if (dsInformations.Tables[0].Rows.Count == 0 && dsInformations.Tables[1].Rows.Count != 0)
                        {
                            port2CurData.Text = Utils.GetCurrString(dsInformations, 1);
                            port2StartBalData.Text = Utils.dGetBalStart(dsInformations, 1).ToString();
                            port2EndBalData.Text = Utils.dGetBalEnd(dsInformations, 1).ToString();
                            port2InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 1).ToString();
                            port2PLData.Text = Utils.GetPLString(dsInformations, 1);
                            port2ReturnData.Text = Utils.GetPeriodString(dsInformations, 1);

                            Utils.DrawSeriesChart(portChart, dsInformations.Tables[1], "Portfolio 2");

                            port1CurData.Text = Utils.sEmptyData;
                            port1StartBalData.Text = Utils.sEmptyData;
                            port1ReturnData.Text = Utils.sEmptyData;
                            port1InOutFlowsData.Text = Utils.sEmptyData;
                            port1EndBalData.Text = Utils.sEmptyData;
                            port1PLData.Text = Utils.sEmptyData;
                            bIsSearching = false;
                            return;
                        }

                        else if (dsInformations.Tables[0].Rows.Count != 0 && dsInformations.Tables[1].Rows.Count == 0)
                        {
                            port1CurData.Text = Utils.GetCurrString(dsInformations, 0);
                            port1StartBalData.Text = Utils.dGetBalStart(dsInformations, 0).ToString();
                            port1EndBalData.Text = Utils.dGetBalEnd(dsInformations, 0).ToString();
                            port1InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 0).ToString();
                            port1PLData.Text = Utils.GetPLString(dsInformations, 0);
                            port1ReturnData.Text = Utils.GetPeriodString(dsInformations, 0);

                            Application.DoEvents();

                            Utils.DrawSeriesChart(portChart, dsInformations.Tables[0], "Portfolio 1");

                            port2CurData.Text = Utils.sEmptyData;
                            port2StartBalData.Text = Utils.sEmptyData;
                            port2ReturnData.Text = Utils.sEmptyData;
                            port2InOutFlowsData.Text = Utils.sEmptyData;
                            port2EndBalData.Text = Utils.sEmptyData;
                            port2PLData.Text = Utils.sEmptyData;

                            bIsSearching = false;
                            return;
                        }

                        else
                        {
                            port1CurData.Text = Utils.GetCurrString(dsInformations, 0);
                            port1StartBalData.Text = Utils.dGetBalStart(dsInformations, 0).ToString();
                            port1EndBalData.Text = Utils.dGetBalEnd(dsInformations, 0).ToString();
                            port1InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 0).ToString();
                            port1PLData.Text = Utils.GetPLString(dsInformations, 0);
                            port1ReturnData.Text = Utils.GetPeriodString(dsInformations, 0);

                            port2CurData.Text = Utils.GetCurrString(dsInformations, 1);
                            port2StartBalData.Text = Utils.dGetBalStart(dsInformations, 1).ToString();
                            port2EndBalData.Text = Utils.dGetBalEnd(dsInformations, 1).ToString();
                            port2InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 1).ToString();
                            port2PLData.Text = Utils.GetPLString(dsInformations, 1);
                            port2ReturnData.Text = Utils.GetPeriodString(dsInformations, 1);

                            Utils.DrawSeriesChart(portChart, dsInformations.Tables[0], "Portfolio 1");
                            Utils.DrawSeriesChart(portChart, dsInformations.Tables[1], "Portfolio 2");

                            bIsSearching = false;
                            return;
                        }

                    }
                }

                if (port2Comb.SelectedItem != null)
                {
                    portfolio2 = new Portfolio((string)port2Comb.SelectedItem);
                    portfolios.Add(portfolio2);

                    if (port1Comb.SelectedItem == null)
                    {
                        Application.DoEvents();
                        dsInformations = db.GetDataWithCurr(portfolios, dateFrom, dateTo);

                        if (dsInformations.Tables[0].Rows.Count == 0)
                        {
                            port2CurData.Text = Utils.sEmptyData;
                            port2StartBalData.Text = Utils.sEmptyData;
                            port2ReturnData.Text = Utils.sEmptyData;
                            port2InOutFlowsData.Text = Utils.sEmptyData;
                            port2EndBalData.Text = Utils.sEmptyData;
                            port2PLData.Text = Utils.sEmptyData;

                            port1CurData.Text = Utils.sNoChoiseString;
                            port1StartBalData.Text = Utils.sNoChoiseString;
                            port1ReturnData.Text = Utils.sNoChoiseString;
                            port1InOutFlowsData.Text = Utils.sNoChoiseString;
                            port1EndBalData.Text = Utils.sNoChoiseString;
                            port1PLData.Text = Utils.sNoChoiseString;

                            bIsSearching = false;
                            return;
                        }

                        port2CurData.Text = Utils.GetCurrString(dsInformations, 0);
                        port2StartBalData.Text = Utils.dGetBalStart(dsInformations, 0).ToString();
                        port2EndBalData.Text = Utils.dGetBalEnd(dsInformations, 0).ToString();
                        port2InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 0).ToString();
                        port2PLData.Text = Utils.GetPLString(dsInformations, 0);
                        port2ReturnData.Text = Utils.GetPeriodString(dsInformations, 0);

                        Utils.DrawSeriesChart(portChart, dsInformations.Tables[0], "Portfolio 2");

                        port1CurData.Text = Utils.sNoChoiseString;
                        port1StartBalData.Text = Utils.sNoChoiseString;
                        port1ReturnData.Text = Utils.sNoChoiseString;
                        port1InOutFlowsData.Text = Utils.sNoChoiseString;
                        port1EndBalData.Text = Utils.sNoChoiseString;
                        port1PLData.Text = Utils.sNoChoiseString;
                        bIsSearching = false;
                        return;
                    }
                }
            }

            else if(radioBtn1.Checked == false && radioBtn2.Checked == true && curComb.SelectedItem == null)
            {
                MessageBox.Show("Please Choose currency from the list beside");
                return;
            }

            else
            {
                var selectedCurr = (string) curComb.SelectedItem;

                if (port1Comb.SelectedItem != null)
                {
                    portfolio1 = new Portfolio((string) port1Comb.SelectedItem);
                    portfolios.Add(portfolio1);

                    if (port2Comb.SelectedItem == null)
                    {
                        Application.DoEvents();
                        dsInformations =  db.GetDataChangeCurr(portfolios, dateFrom, dateTo, selectedCurr);

                        if (dsInformations.Tables[0].Rows.Count == 0)
                        {
                            port1CurData.Text = Utils.sEmptyData;
                            port1StartBalData.Text = Utils.sEmptyData;
                            port1ReturnData.Text = Utils.sEmptyData;
                            port1InOutFlowsData.Text = Utils.sEmptyData;
                            port1EndBalData.Text = Utils.sEmptyData;
                            port1PLData.Text = Utils.sEmptyData;

                            port2CurData.Text = Utils.sNoChoiseString;
                            port2StartBalData.Text = Utils.sNoChoiseString;
                            port2ReturnData.Text = Utils.sNoChoiseString;
                            port2InOutFlowsData.Text = Utils.sNoChoiseString;
                            port2EndBalData.Text = Utils.sNoChoiseString;
                            port2PLData.Text = Utils.sNoChoiseString;

                            bIsSearching = false;
                            return;
                        }

                        port1CurData.Text = Utils.GetCurrString(dsInformations, 0);
                        port1StartBalData.Text = Utils.dGetBalStart(dsInformations, 0).ToString();
                        port1EndBalData.Text = Utils.dGetBalEnd(dsInformations, 0).ToString();
                        port1InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 0).ToString();
                        port1PLData.Text = Utils.GetPLString(dsInformations, 0);
                        port1ReturnData.Text = Utils.GetPeriodString(dsInformations, 0);

                        Utils.DrawSeriesChart(portChart, dsInformations.Tables[0], "Portfolio 1");

                        port2CurData.Text = Utils.sNoChoiseString;
                        port2StartBalData.Text = Utils.sNoChoiseString;
                        port2ReturnData.Text = Utils.sNoChoiseString;
                        port2InOutFlowsData.Text = Utils.sNoChoiseString;
                        port2EndBalData.Text = Utils.sNoChoiseString;
                        port2PLData.Text = Utils.sNoChoiseString;

                        bIsSearching = false; 
                        return;
                    }

                    else if (port2Comb.SelectedItem != null)
                    {
                        portfolio2 = new Portfolio((string)port2Comb.SelectedItem);
                        portfolios.Add(portfolio2);

                        Application.DoEvents();
                        dsInformations =  db.GetDataChangeCurr(portfolios, dateFrom, dateTo, selectedCurr);

                        if (dsInformations == null)
                        {
                            port1CurData.Text = Utils.sEmptyData;
                            port1StartBalData.Text = Utils.sEmptyData;
                            port1ReturnData.Text = Utils.sEmptyData;
                            port1InOutFlowsData.Text = Utils.sEmptyData;
                            port1EndBalData.Text = Utils.sEmptyData;
                            port1PLData.Text = Utils.sEmptyData;

                            port2CurData.Text = Utils.sEmptyData;
                            port2StartBalData.Text = Utils.sEmptyData;
                            port2ReturnData.Text = Utils.sEmptyData;
                            port2InOutFlowsData.Text = Utils.sEmptyData;
                            port2EndBalData.Text = Utils.sEmptyData;
                            port2PLData.Text = Utils.sEmptyData;
                            bIsSearching = false;
                            return;
                        }

                        else if (dsInformations.Tables[0].Rows.Count == 0 && dsInformations.Tables[1].Rows.Count != 0)
                        {
                            port2CurData.Text = Utils.GetCurrString(dsInformations, 1);
                            port2StartBalData.Text = Utils.dGetBalStart(dsInformations, 1).ToString();
                            port2EndBalData.Text = Utils.dGetBalEnd(dsInformations, 1).ToString();
                            port2InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 1).ToString();
                            port2PLData.Text = Utils.GetPLString(dsInformations, 1);
                            port2ReturnData.Text = Utils.GetPeriodString(dsInformations, 1);

                            Utils.DrawSeriesChart(portChart, dsInformations.Tables[1], "Portfolio 2");

                            port1CurData.Text = Utils.sEmptyData;
                            port1StartBalData.Text = Utils.sEmptyData;
                            port1ReturnData.Text = Utils.sEmptyData;
                            port1InOutFlowsData.Text = Utils.sEmptyData;
                            port1EndBalData.Text = Utils.sEmptyData;
                            port1PLData.Text = Utils.sEmptyData;

                            bIsSearching = false;
                            return;
                        }

                        else if (dsInformations.Tables[0].Rows.Count != 0 && dsInformations.Tables[1].Rows.Count == 0)
                        {
                            port1CurData.Text = Utils.GetCurrString(dsInformations, 0);
                            port1StartBalData.Text = Utils.dGetBalStart(dsInformations, 0).ToString();
                            port1EndBalData.Text = Utils.dGetBalEnd(dsInformations, 0).ToString();
                            port1InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 0).ToString();
                            port1PLData.Text = Utils.GetPLString(dsInformations, 0);
                            port1ReturnData.Text = Utils.GetPeriodString(dsInformations, 0);

                            Utils.DrawSeriesChart(portChart, dsInformations.Tables[0], "Portfolio 1");

                            port2CurData.Text = Utils.sEmptyData;
                            port2StartBalData.Text = Utils.sEmptyData;
                            port2ReturnData.Text = Utils.sEmptyData;
                            port2InOutFlowsData.Text = Utils.sEmptyData;
                            port2EndBalData.Text = Utils.sEmptyData;
                            port2PLData.Text = Utils.sEmptyData;

                            bIsSearching = false;
                            return;
                        }

                        else
                        {
                            port1CurData.Text = Utils.GetCurrString(dsInformations, 0);
                            port1StartBalData.Text = Utils.dGetBalStart(dsInformations, 0).ToString();
                            port1EndBalData.Text = Utils.dGetBalEnd(dsInformations, 0).ToString();
                            port1InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 0).ToString();
                            port1PLData.Text = Utils.GetPLString(dsInformations, 0);
                            port1ReturnData.Text = Utils.GetPeriodString(dsInformations, 0);

                            port2CurData.Text = Utils.GetCurrString(dsInformations, 1);
                            port2StartBalData.Text = Utils.dGetBalStart(dsInformations, 1).ToString();
                            port2EndBalData.Text = Utils.dGetBalEnd(dsInformations, 1).ToString();
                            port2InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 1).ToString();
                            port2PLData.Text = Utils.GetPLString(dsInformations, 1);
                            port2ReturnData.Text = Utils.GetPeriodString(dsInformations, 1);

                            Utils.DrawSeriesChart(portChart, dsInformations.Tables[0], "Portfolio 1");
                            Utils.DrawSeriesChart(portChart, dsInformations.Tables[1], "Portfolio 2");

                            bIsSearching = false;
                            return;
                        }

                    }
                }

                if (port2Comb.SelectedItem != null)
                {
                    portfolio2 = new Portfolio((string)port2Comb.SelectedItem);
                    portfolios.Add(portfolio2);

                    if (port1Comb.SelectedItem == null)
                    {
                        Application.DoEvents();
                        dsInformations= db.GetDataChangeCurr(portfolios, dateFrom, dateTo, selectedCurr);

                        if (dsInformations.Tables[0].Rows.Count == 0)
                        {
                            port2CurData.Text = Utils.sEmptyData;
                            port2StartBalData.Text = Utils.sEmptyData;
                            port2ReturnData.Text = Utils.sEmptyData;
                            port2InOutFlowsData.Text = Utils.sEmptyData;
                            port2EndBalData.Text = Utils.sEmptyData;
                            port2PLData.Text = Utils.sEmptyData;

                            port1CurData.Text = Utils.sNoChoiseString;
                            port1StartBalData.Text = Utils.sNoChoiseString;
                            port1ReturnData.Text = Utils.sNoChoiseString;
                            port1InOutFlowsData.Text = Utils.sNoChoiseString;
                            port1EndBalData.Text = Utils.sNoChoiseString;
                            port1PLData.Text = Utils.sNoChoiseString;

                            bIsSearching = false;
                            return;
                        }
                        port2CurData.Text = Utils.GetCurrString(dsInformations, 0);
                        port2StartBalData.Text = Utils.dGetBalStart(dsInformations, 0).ToString();
                        port2EndBalData.Text = Utils.dGetBalEnd(dsInformations, 0).ToString();
                        port2InOutFlowsData.Text = Utils.dGetInOutFlows(dsInformations, 0).ToString();
                        port2PLData.Text = Utils.GetPLString(dsInformations, 0);
                        port2ReturnData.Text = Utils.GetPeriodString(dsInformations, 0);

                        Utils.DrawSeriesChart(portChart, dsInformations.Tables[0], "Portfolio 2");

                        port1CurData.Text = Utils.sNoChoiseString;
                        port1StartBalData.Text = Utils.sNoChoiseString;
                        port1ReturnData.Text = Utils.sNoChoiseString;
                        port1InOutFlowsData.Text = Utils.sNoChoiseString;
                        port1EndBalData.Text = Utils.sNoChoiseString;
                        port1PLData.Text = Utils.sNoChoiseString;

                        bIsSearching = false;
                        return;
                    }
                }


            }
            
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            
            dateFromPick.Value = DateTime.Now;
            dateToPick.Value = DateTime.Now;

            port1Comb.SelectedIndex = -1;
            port2Comb.SelectedIndex = -1;

            curComb.SelectedIndex = -1;

            port1CurData.Text = Utils.sClearBtnString;
            port1StartBalData.Text = Utils.sClearBtnString;
            port1ReturnData.Text = Utils.sClearBtnString;
            port1InOutFlowsData.Text = Utils.sClearBtnString;
            port1EndBalData.Text = Utils.sClearBtnString;
            port1PLData.Text = Utils.sClearBtnString;

            port2CurData.Text = Utils.sClearBtnString;
            port2StartBalData.Text = Utils.sClearBtnString;
            port2ReturnData.Text = Utils.sClearBtnString;
            port2InOutFlowsData.Text = Utils.sClearBtnString;
            port2EndBalData.Text = Utils.sClearBtnString;
            port2PLData.Text = Utils.sClearBtnString;

            portChart.Series.Clear();

            ClearBtn.Enabled = false;
        }

        private void ClearScren()
        {
           

            port1CurData.Text = Utils.sClearBtnString;
            port1StartBalData.Text = Utils.sClearBtnString;
            port1ReturnData.Text = Utils.sClearBtnString;
            port1InOutFlowsData.Text = Utils.sClearBtnString;
            port1EndBalData.Text = Utils.sClearBtnString;
            port1PLData.Text = Utils.sClearBtnString;

            port2CurData.Text = Utils.sClearBtnString;
            port2StartBalData.Text = Utils.sClearBtnString;
            port2ReturnData.Text = Utils.sClearBtnString;
            port2InOutFlowsData.Text = Utils.sClearBtnString;
            port2EndBalData.Text = Utils.sClearBtnString;
            port2PLData.Text = Utils.sClearBtnString;

            portChart.Series.Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Visible = bIsSearching;
        }
    }
}
