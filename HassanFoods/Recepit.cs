using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassanFoods
{
    public partial class Recepit : Form
    {
        public Recepit()
        {
            InitializeComponent();
        }

        private void Recepit_Load(object sender, EventArgs e)
        {
            this.rptViewer.RefreshReport();
        }
        public void Print(List<Order> orders,string bill, string date, string time, int j, int note, int change)
        {
            rptViewer.LocalReport.DataSources.Clear();
            DataSet ds = new DataSet();
            DataTable dt;
            DataRow drow;
            DataColumn ncolumn,qcolumn,pcolumn,tcolumn,dcolumn,incolumn,daycolumn,Fcolumn,Ccolumn,Rcolumn;
            List<String> abc = new List<String>();
            dt = new DataTable();
            //Adding Column for dynamic dataset

            ncolumn = new DataColumn("Name", Type.GetType("System.String"));
            qcolumn = new DataColumn("Price", Type.GetType("System.String"));
            pcolumn = new DataColumn("Quantity", Type.GetType("System.String"));
            tcolumn = new DataColumn("Total", Type.GetType("System.String"));
            dcolumn = new DataColumn("Date", Type.GetType("System.String"));
            incolumn = new DataColumn("Invoiceno", Type.GetType("System.String"));
            daycolumn = new DataColumn("Day", Type.GetType("System.String"));
            Fcolumn = new DataColumn("Final", Type.GetType("System.String"));
            Ccolumn = new DataColumn("Change", Type.GetType("System.String"));
            Rcolumn = new DataColumn("Recieve", Type.GetType("System.String"));

            dt.Columns.Add(ncolumn);
            dt.Columns.Add(qcolumn);
            dt.Columns.Add(pcolumn);
            dt.Columns.Add(tcolumn);
            dt.Columns.Add(dcolumn);
            dt.Columns.Add(incolumn);
            dt.Columns.Add(daycolumn);
            dt.Columns.Add(Fcolumn);
            dt.Columns.Add(Rcolumn);
            dt.Columns.Add(Ccolumn);
            j++;

            for (int i = 0; i < orders.Count; i++)
            {
                drow = dt.NewRow();
                drow["Name"] = orders[i].Name;
                drow["Quantity"] = orders[i].Quantity;
                drow["Price"] = orders[i].Price;
                drow["Total"] = bill;
                drow["Date"] = date;
                drow["Invoiceno"] = "SAVHF:10" + j;
                drow["Day"] = time;
                drow["Final"] = (orders[i].Quantity * orders[i].Price);
                drow["Recieve"] = note;
                drow["Change"] = change;
                dt.Rows.Add(drow);
            }
            ds.Tables.Add(dt);
            ds.AcceptChanges();

            if (ds != null && dt.Rows.Count > 0)
            {
                rptViewer.Visible = true;
                rptViewer.ProcessingMode = ProcessingMode.Local;
                string path = System.Configuration.ConfigurationManager.AppSettings["report1"];
                rptViewer.LocalReport.ReportPath = path;
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
                rptViewer.LocalReport.DataSources.Add(rds);
                rptViewer.LocalReport.Refresh();
                rptViewer.RefreshReport();
            }
            
        }
        public void DayOff(List<DayOffReport> dayOffReports,string Date,string Total)
        {
            rptViewer.LocalReport.DataSources.Clear();
            DataSet ds = new DataSet();
            DataTable dt;
            DataRow drow;
            DataColumn ncolumn, qcolumn, pcolumn, tcolumn, dcolumn, incolumn, daycolumn,Fcolumn;
            List<String> abc = new List<String>();
            dt = new DataTable();
            //Adding Column for dynamic dataset

            ncolumn = new DataColumn("Name", Type.GetType("System.String"));
            qcolumn = new DataColumn("Price", Type.GetType("System.String"));
            pcolumn = new DataColumn("Quantity", Type.GetType("System.String"));
            tcolumn = new DataColumn("Total", Type.GetType("System.String"));
            dcolumn = new DataColumn("Date", Type.GetType("System.String"));
            incolumn = new DataColumn("Invoiceno", Type.GetType("System.String"));
            daycolumn = new DataColumn("Day", Type.GetType("System.String"));
            Fcolumn = new DataColumn("Final", Type.GetType("System.String"));
          
            dt.Columns.Add(ncolumn);
            dt.Columns.Add(qcolumn);
            dt.Columns.Add(pcolumn);
            dt.Columns.Add(tcolumn);
            dt.Columns.Add(dcolumn);
            dt.Columns.Add(incolumn);
            dt.Columns.Add(daycolumn);
            dt.Columns.Add(Fcolumn);
         
            for (int i = 0; i < dayOffReports.Count; i++)
            {
                drow = dt.NewRow();
                drow["Name"] = dayOffReports[i].Name;
                drow["Quantity"] =dayOffReports[i].Quantity;
                drow["Price"] = dayOffReports[i].Price;
                drow["Total"] = Total;
                drow["Date"] = Date;
                drow["Final"] = (dayOffReports[i].Quantity * dayOffReports[i].Price);
                dt.Rows.Add(drow);
            }
            ds.Tables.Add(dt);
            ds.AcceptChanges();
            if (ds != null && dt.Rows.Count > 0)
            {
                rptViewer.Visible = true;
                rptViewer.ProcessingMode = ProcessingMode.Local;
                string path = System.Configuration.ConfigurationManager.AppSettings["report2"];
                rptViewer.LocalReport.ReportPath = path;
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
                rptViewer.LocalReport.DataSources.Add(rds);
                rptViewer.LocalReport.Refresh();
                rptViewer.RefreshReport();
            }

        }
    }
}
