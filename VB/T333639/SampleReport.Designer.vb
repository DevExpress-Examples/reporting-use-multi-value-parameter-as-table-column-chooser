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
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim Join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
            Dim RelationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SampleReport))
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
            CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tblHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tblDetail})
            Me.Detail.HeightF = 25.0!
            Me.Detail.Name = "Detail"
            Me.Detail.StylePriority.UsePadding = False
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'tblDetail
            '
            Me.tblDetail.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.tblDetail.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.tblDetail.Name = "tblDetail"
            Me.tblDetail.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.trDetail})
            Me.tblDetail.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
            Me.tblDetail.StylePriority.UseBorders = False
            '
            'trDetail
            '
            Me.trDetail.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell2})
            Me.trDetail.Name = "trDetail"
            Me.trDetail.Weight = 1.0R
            '
            'xrTableCell2
            '
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ID]")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 1.0R
            '
            'TopMargin
            '
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'BottomMargin
            '
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'ReportColumns
            '
            Me.ReportColumns.Description = "Columns"
            Me.ReportColumns.MultiValue = True
            Me.ReportColumns.Name = "ReportColumns"
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tblHeader})
            Me.GroupHeader1.HeightF = 25.0!
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.RepeatEveryPage = True
            Me.GroupHeader1.StylePriority.UseBorders = False
            '
            'tblHeader
            '
            Me.tblHeader.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.tblHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
            Me.tblHeader.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.tblHeader.Name = "tblHeader"
            Me.tblHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.trHeader})
            Me.tblHeader.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
            Me.tblHeader.StylePriority.UseBorders = False
            Me.tblHeader.StylePriority.UseFont = False
            '
            'trHeader
            '
            Me.trHeader.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1})
            Me.trHeader.Name = "trHeader"
            Me.trHeader.Weight = 1.0R
            '
            'xrTableCell1
            '
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "ID"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            Me.xrTableCell1.Weight = 1.0R
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.ReportHeader.Name = "ReportHeader"
            '
            'xrLabel1
            '
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 48.0!)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(629.9999!, 79.99998!)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Products"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'sqlDataSource1
            '
            Me.sqlDataSource1.ConnectionName = "Northwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            Column1.Alias = "ID"
            ColumnExpression1.ColumnName = "ProductID"
            Table1.Name = "Products"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            Column2.Alias = "Name"
            ColumnExpression2.ColumnName = "ProductName"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "QuantityPerUnit"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "UnitPrice"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "UnitsInStock"
            ColumnExpression5.Table = Table1
            Column5.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "UnitsOnOrder"
            ColumnExpression6.Table = Table1
            Column6.Expression = ColumnExpression6
            Column7.Alias = "Supplier"
            ColumnExpression7.ColumnName = "CompanyName"
            Table2.Name = "Suppliers"
            ColumnExpression7.Table = Table2
            Column7.Expression = ColumnExpression7
            Column8.Alias = "Category"
            ColumnExpression8.ColumnName = "CategoryName"
            Table3.Name = "Categories"
            ColumnExpression8.Table = Table3
            Column8.Expression = ColumnExpression8
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Columns.Add(Column5)
            SelectQuery1.Columns.Add(Column6)
            SelectQuery1.Columns.Add(Column7)
            SelectQuery1.Columns.Add(Column8)
            SelectQuery1.Name = "Products"
            RelationColumnInfo1.NestedKeyColumn = "SupplierID"
            RelationColumnInfo1.ParentKeyColumn = "SupplierID"
            Join1.KeyColumns.Add(RelationColumnInfo1)
            Join1.Nested = Table2
            Join1.Parent = Table1
            RelationColumnInfo2.NestedKeyColumn = "CategoryID"
            RelationColumnInfo2.ParentKeyColumn = "CategoryID"
            Join2.KeyColumns.Add(RelationColumnInfo2)
            Join2.Nested = Table3
            Join2.Parent = Table1
            SelectQuery1.Relations.Add(Join1)
            SelectQuery1.Relations.Add(Join2)
            SelectQuery1.Tables.Add(Table1)
            SelectQuery1.Tables.Add(Table2)
            SelectQuery1.Tables.Add(Table3)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            '
            'SampleReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.ReportHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 2, 2, 100.0!)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.ReportColumns})
            Me.RequestParameters = False
            Me.Version = "21.2"
            CType(Me.tblDetail, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tblHeader, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

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
