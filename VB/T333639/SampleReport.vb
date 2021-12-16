Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Namespace T333639
    Partial Public Class SampleReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private _reportColumns As LookUpValueCollection

        Public Sub New()
            InitializeComponent()

            ' Initialize a list of lookup values for report columns.
            _reportColumns = New LookUpValueCollection() From {
                New LookUpValue("ID", "ID"),
                New LookUpValue("Name", "Name"),
                New LookUpValue("Category", "Category"),
                New LookUpValue("Supplier", "Supplier"),
                New LookUpValue("UnitPrice", "Price"),
                New LookUpValue("UnitsInStock", "In Stock"),
                New LookUpValue("UnitsOnOrder", "On Order"),
                New LookUpValue("QuantityPerUnit", "Quantity Per Unit")
            }

            Dim reportColumnsLookUpSettings As New StaticListLookUpSettings()
            reportColumnsLookUpSettings.LookUpValues.AddRange(_reportColumns)

            ' Assign the list of lookup values to the report's ReportColumns parameter.
            Me.Parameters("ReportColumns").LookUpSettings = reportColumnsLookUpSettings
            ' Specify default lookup values.
            Me.Parameters("ReportColumns").Value = New String() { "ID", "Name", "Category", "Supplier", "UnitPrice" }
        End Sub

        Private Sub SampleReport_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
            ' Get the selected report columns.
            Dim columns() As String = CType(Me.Parameters("ReportColumns").Value, String())

            Me.tblHeader.BeginInit()
            Me.tblDetail.BeginInit()
            Me.trHeader.Cells.Clear()
            Me.trDetail.Cells.Clear()

            ' Create a table header cell and table body cell for each selected column.
            For Each column As String In columns
                Dim description As String = _reportColumns.Single(Function(lookupValue) lookupValue.Value.Equals(column)).Description

                ' Assign a column description to the table header cell.
                Dim headerCell As New XRTableCell() With {.Text = description}
                Me.trHeader.Cells.Add(headerCell)

                ' Bind the table body cell to the column.
                Dim detailCell As New XRTableCell()
                detailCell.DataBindings.Add("Text", Nothing, String.Format("{0}.{1}", Me.DataMember, column))
                Me.trDetail.Cells.Add(detailCell)
            Next column

            Me.tblHeader.EndInit()
            Me.tblDetail.EndInit()
        End Sub

    End Class
End Namespace
