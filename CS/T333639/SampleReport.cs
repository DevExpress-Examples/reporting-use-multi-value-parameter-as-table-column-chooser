using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using System.Linq;

namespace T333639 {
    public partial class SampleReport : DevExpress.XtraReports.UI.XtraReport {
        LookUpValueCollection _reportColumns;

        public SampleReport() {
            InitializeComponent();

            _reportColumns = new LookUpValueCollection() {
                    new LookUpValue("ID", "ID"),
                    new LookUpValue("Name", "Name"),
                    new LookUpValue("Category", "Category"),
                    new LookUpValue("Supplier", "Supplier"),
                    new LookUpValue("UnitPrice", "Price"),
                    new LookUpValue("UnitsInStock", "In Stock"),
                    new LookUpValue("UnitsOnOrder", "On Order"),
                    new LookUpValue("QuantityPerUnit", "Quantity Per Unit")
            };
            StaticListLookUpSettings reportColumnsLookUpSettings = new StaticListLookUpSettings();
            reportColumnsLookUpSettings.LookUpValues.AddRange(_reportColumns);
            this.Parameters["ReportColumns"].LookUpSettings = reportColumnsLookUpSettings;
            this.Parameters["ReportColumns"].Value = new string[] { "ID", "Name", "Category", "Supplier", "UnitPrice" };
        }

        private void SampleReport_DataSourceDemanded(object sender, EventArgs e) {
            string[] columns = (string[])this.Parameters["ReportColumns"].Value;
            
            this.tblHeader.BeginInit();
            this.tblDetail.BeginInit();
            this.trHeader.Cells.Clear();
            this.trDetail.Cells.Clear();
            foreach (string column in columns) {
                string description = _reportColumns.Single(lookupValue => lookupValue.Value.Equals(column)).Description;

                XRTableCell headerCell = new XRTableCell() {
                    Text = description
                };
                this.trHeader.Cells.Add(headerCell);

                XRTableCell detailCell = new XRTableCell();
                detailCell.DataBindings.Add("Text", null, String.Format("{0}.{1}", this.DataMember, column));
                this.trDetail.Cells.Add(detailCell);
            }
            this.tblHeader.EndInit();
            this.tblDetail.EndInit();
        }

    }
}
