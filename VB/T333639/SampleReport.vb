Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Imports System.Linq

Namespace T333639
    Partial Public Class SampleReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private _reportColumns As LookUpValueCollection

        Public Sub New()
            InitializeComponent()

            _reportColumns = New LookUpValueCollection() From { _
                New LookUpValue("ID", "ID"), _
                New LookUpValue("Name", "Name"), _
                New LookUpValue("Category", "Category"), _
                New LookUpValue("Supplier", "Supplier"), _
                New LookUpValue("UnitPrice", "Price"), _
                New LookUpValue("UnitsInStock", "In Stock"), _
                New LookUpValue("UnitsOnOrder", "On Order"), _
                New LookUpValue("QuantityPerUnit", "Quantity Per Unit") _
            }
            Dim reportColumnsLookUpSettings As New StaticListLookUpSettings()
            reportColumnsLookUpSettings.LookUpValues.AddRange(_reportColumns)
            Me.Parameters("ReportColumns").LookUpSettings = reportColumnsLookUpSettings
            Me.Parameters("ReportColumns").Value = New String() { "ID", "Name", "Category", "Supplier", "UnitPrice" }
        End Sub

        Private Sub SampleReport_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
            Dim columns() As String = CType(Me.Parameters("ReportColumns").Value, String())

            Me.tblHeader.BeginInit()
            Me.tblDetail.BeginInit()
            Me.trHeader.Cells.Clear()
            Me.trDetail.Cells.Clear()
            For Each column As String In columns
                Dim description As String = _reportColumns.Single(Function(lookupValue) lookupValue.Value.Equals(column)).Description

                Dim headerCell As New XRTableCell() With {.Text = description}
                Me.trHeader.Cells.Add(headerCell)

                Dim detailCell As New XRTableCell()
                detailCell.DataBindings.Add("Text", Nothing, String.Format("{0}.{1}", Me.DataMember, column))
                Me.trDetail.Cells.Add(detailCell)
            Next column
            Me.tblHeader.EndInit()
            Me.tblDetail.EndInit()
        End Sub

    End Class
End Namespace
