<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604322/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T333639)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/T333639/Default.aspx) (VB: [Default.aspx](./VB/T333639/Default.aspx))
* **[SampleReport.cs](./CS/T333639/SampleReport.cs) (VB: [SampleReport.Designer.vb](./VB/T333639/SampleReport.Designer.vb))**
* [SampleReport.Designer.cs](./CS/T333639/SampleReport.Designer.cs) (VB: [SampleReport.Designer.vb](./VB/T333639/SampleReport.Designer.vb))
<!-- default file list end -->
# How to use XtraReport's multi-value parameter as a column chooser
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t333639/)**
<!-- run online end -->


<p>This example demonstrates how to use a <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument9997">report parameter</a> in multi-value mode to grant an end-user the capability to select columns that should be displayed in the report:</p>
<img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-xtrareports-multi-value-parameter-as-a-column-chooser-t333639/15.2.4+/media/3e5d2742-b9ef-11e5-80bf-00155d62480c.png"><br><br>
<p>LookUpValueCollection is used in the report's class to store a column's filed names (as the Value property) and their captions (as the Description property). Then, this collection is used to assign the LookUp values to the report's column chooser parameter and to get the column caption by its field name. The report's <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_DataSourceDemandedtopic">DataSourceDemanded</a> event handler is used to get columns chosen by the end-user and create corresponding cells in the report's XRTable controls (that were created at design time).</p>

<br/>


