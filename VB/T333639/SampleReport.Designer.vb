Namespace T333639
    Partial Public Class SampleReport
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim relationInfo1 As New DevExpress.DataAccess.Sql.RelationInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim relationInfo2 As New DevExpress.DataAccess.Sql.RelationInfo()
            Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableInfo3 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SampleReport))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.tblDetail = New DevExpress.XtraReports.UI.XRTable()
            Me.trDetail = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportColumns = New DevExpress.XtraReports.Parameters.Parameter()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.tblHeader = New DevExpress.XtraReports.UI.XRTable()
            Me.trHeader = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            DirectCast(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tblHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tblDetail})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.StylePriority.UsePadding = False
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' tblDetail
            ' 
            Me.tblDetail.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.tblDetail.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tblDetail.Name = "tblDetail"
            Me.tblDetail.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trDetail})
            Me.tblDetail.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.tblDetail.StylePriority.UseBorders = False
            ' 
            ' trDetail
            ' 
            Me.trDetail.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell2})
            Me.trDetail.Name = "trDetail"
            Me.trDetail.Weight = 1R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ID")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 1R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportColumns
            ' 
            Me.ReportColumns.Description = "Columns"
            Me.ReportColumns.MultiValue = True
            Me.ReportColumns.Name = "ReportColumns"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.tblHeader})
            Me.GroupHeader1.HeightF = 25F
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.RepeatEveryPage = True
            Me.GroupHeader1.StylePriority.UseBorders = False
            ' 
            ' tblHeader
            ' 
            Me.tblHeader.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.tblHeader.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.tblHeader.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.tblHeader.Name = "tblHeader"
            Me.tblHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.trHeader})
            Me.tblHeader.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.tblHeader.StylePriority.UseBorders = False
            Me.tblHeader.StylePriority.UseFont = False
            ' 
            ' trHeader
            ' 
            Me.trHeader.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1})
            Me.trHeader.Name = "trHeader"
            Me.trHeader.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "ID"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            Me.xrTableCell1.Weight = 1R
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.ReportHeader.HeightF = 100F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 48F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(629.9999F, 79.99998F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Products"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "Northwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "SupplierID"
            relationColumnInfo1.ParentKeyColumn = "SupplierID"
            relationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() { relationColumnInfo1})
            relationInfo1.NestedTable = "Suppliers"
            relationInfo1.ParentTable = "Products"
            relationColumnInfo2.NestedKeyColumn = "CategoryID"
            relationColumnInfo2.ParentKeyColumn = "CategoryID"
            relationInfo2.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() { relationColumnInfo2})
            relationInfo2.NestedTable = "Categories"
            relationInfo2.ParentTable = "Products"
            tableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() { relationInfo1, relationInfo2})
            tableInfo1.Name = "Products"
            columnInfo1.Alias = "ID"
            columnInfo1.Name = "ProductID"
            columnInfo2.Alias = "Name"
            columnInfo2.Name = "ProductName"
            columnInfo3.Name = "QuantityPerUnit"
            columnInfo4.Name = "UnitPrice"
            columnInfo5.Name = "UnitsInStock"
            columnInfo6.Name = "UnitsOnOrder"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6})
            tableInfo2.Name = "Suppliers"
            columnInfo7.Alias = "Supplier"
            columnInfo7.Name = "CompanyName"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo7})
            tableInfo3.Name = "Categories"
            columnInfo8.Alias = "Category"
            columnInfo8.Name = "CategoryName"
            tableInfo3.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo8})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1, tableInfo2, tableInfo3})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' SampleReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.ReportHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 2, 2, 100F)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.ReportColumns})
            Me.RequestParameters = False
            Me.Version = "15.2"
            DirectCast(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tblHeader, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private tblDetail As DevExpress.XtraReports.UI.XRTable
        Private trDetail As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private ReportColumns As DevExpress.XtraReports.Parameters.Parameter
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private tblHeader As DevExpress.XtraReports.UI.XRTable
        Private trHeader As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
