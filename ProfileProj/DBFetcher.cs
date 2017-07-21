using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileProj
{
    public class DBFetcher
    {

        public static string connString = ConfigurationManager.ConnectionStrings["IMS_LAB"].ConnectionString;
        
        public const string sSqlCommandForPortfolios = "select PF_Shortcut1,PF_Code from Portfolios";

        public const string sSqlCmdForCurrency = "select CR_Code, CR_Name1 from Currencies";
        
        public  DataSet GetDataForPortfolios()
        {
            DataSet dsPortfolios = new DataSet();
            SqlDataAdapter adapter;
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sSqlCommandForPortfolios, conn))
                    {
                        adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dsPortfolios);
                        return dsPortfolios;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public  DataSet GetDataForCurComb()
        {
            DataSet dsCurrency = new DataSet();
            SqlDataAdapter adapter;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sSqlCmdForCurrency, conn))
                    {
                        adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dsCurrency);
                        return dsCurrency;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public  DataSet GetData(List<Portfolio> Portfolios, DateTime dateFrom, DateTime dateTo)
        {
            DataSet dsDataSet = new DataSet();
            SqlDataAdapter adapter;

            try
            {
                using(SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    foreach(Portfolio p in Portfolios) {

                        using (SqlCommand cmd = new SqlCommand("getPortfolioData", conn))
                        {
                            new SqlCommand("getPortfolioData", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@DateFrom", dateFrom));
                            cmd.Parameters.Add(new SqlParameter("@DateTo", dateTo));
                            cmd.Parameters.Add(new SqlParameter("@PF_Shortcut1", p.Name));
                            cmd.Parameters.Add(new SqlParameter("@varPeriodReturn", 1));

                            adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dsDataSet, p.Name);
                        }
                    }
                    return dsDataSet;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;


            }
        }

        public  DataSet GetDataWithCurr(List<Portfolio> Portfolios, DateTime dateFrom, DateTime dateTo)
        {
            DataSet dsDataSet = new DataSet();
            SqlDataAdapter adapter;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    foreach (Portfolio p in Portfolios)
                    {

                        using (SqlCommand cmd = new SqlCommand("dataTableforEachPortfolioWithCurrency", conn))
                        {
                            new SqlCommand("dataTableforEachPortfolioWithCurrency", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@DateFrom", dateFrom));
                            cmd.Parameters.Add(new SqlParameter("@DateTo", dateTo));
                            cmd.Parameters.Add(new SqlParameter("@PF_Shortcut1", p.Name));
                            cmd.Parameters.Add(new SqlParameter("@varPeriodReturn", 1));

                            adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dsDataSet, p.Name);
                        }
                    }
                    return dsDataSet;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;


            }
        }

        public  DataSet GetDataChangeCurr(List<Portfolio> Portfolios, DateTime dateFrom, DateTime dateTo, string comboValue)
        {
            DataSet dsDataSet = new DataSet();
            SqlDataAdapter adapter;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    foreach (Portfolio p in Portfolios)
                    {

                        using (SqlCommand cmd = new SqlCommand("ChangePortCurr", conn))
                        {
                            new SqlCommand("ChangePortCurr", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@DateFrom", dateFrom));
                            cmd.Parameters.Add(new SqlParameter("@DateTo", dateTo));
                            cmd.Parameters.Add(new SqlParameter("@PF_Shortcut1", p.Name));
                            cmd.Parameters.Add(new SqlParameter("@varPeriodReturn", 1));
                            cmd.Parameters.Add(new SqlParameter("@RefCccyShortcut", comboValue));

                            adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dsDataSet, p.Name);
                        }
                    }
                    return dsDataSet;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;


            }

        }
    }
}
