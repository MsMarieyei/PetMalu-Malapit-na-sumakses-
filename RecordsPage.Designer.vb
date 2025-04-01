<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordsPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordsPage))
        BtnBack = New Button()
        BtnPrint = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        DataGridView1 = New DataGridView()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        BtnInsert = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnBack
        ' 
        BtnBack.Location = New Point(1694, 949)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(94, 29)
        BtnBack.TabIndex = 1
        BtnBack.Text = "BACK"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' BtnPrint
        ' 
        BtnPrint.Location = New Point(1552, 949)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(94, 29)
        BtnPrint.TabIndex = 2
        BtnPrint.Text = "PRINT"
        BtnPrint.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(1380, 949)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(1213, 949)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 4
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        PrintDocument1.DocumentName = "Record Print"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(77, 349)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1801, 255)
        DataGridView1.TabIndex = 5
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' BtnInsert
        ' 
        BtnInsert.Location = New Point(1033, 949)
        BtnInsert.Name = "BtnInsert"
        BtnInsert.Size = New Size(94, 29)
        BtnInsert.TabIndex = 6
        BtnInsert.Text = "ADD"
        BtnInsert.UseVisualStyleBackColor = True
        ' 
        ' RecordsPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(BtnInsert)
        Controls.Add(DataGridView1)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnPrint)
        Controls.Add(BtnBack)
        Name = "RecordsPage"
        Text = "RecordsPage"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents BtnInsert As Button
End Class
