<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StepProgressUC
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StepProgressUC))
        Me.StepProgressBar1 = New DevExpress.XtraEditors.StepProgressBar()
        Me.StepProgressBarItem1 = New DevExpress.XtraEditors.StepProgressBarItem()
        Me.StepProgressBarItem2 = New DevExpress.XtraEditors.StepProgressBarItem()
        Me.StepProgressBarItem3 = New DevExpress.XtraEditors.StepProgressBarItem()
        CType(Me.StepProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StepProgressBar1
        '
        Me.StepProgressBar1.Appearances.ItemAppearance.ContentBlockAppearance.Caption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.StepProgressBar1.Appearances.ItemAppearance.ContentBlockAppearance.Caption.Options.UseFont = True
        Me.StepProgressBar1.Appearances.ItemAppearance.ContentBlockAppearance.Description.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.StepProgressBar1.Appearances.ItemAppearance.ContentBlockAppearance.Description.Options.UseFont = True
        Me.StepProgressBar1.AutoSize = True
        Me.StepProgressBar1.ConnectorLineThickness = 3
        Me.StepProgressBar1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.StepProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StepProgressBar1.IndentBetweenItems = 50
        Me.StepProgressBar1.ItemOptions.ConnectorOffset = -10
        Me.StepProgressBar1.ItemOptions.Indicator.ActiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline
        Me.StepProgressBar1.ItemOptions.Indicator.ActiveStateImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette
        Me.StepProgressBar1.ItemOptions.Indicator.Width = 45
        Me.StepProgressBar1.Items.Add(Me.StepProgressBarItem1)
        Me.StepProgressBar1.Items.Add(Me.StepProgressBarItem2)
        Me.StepProgressBar1.Items.Add(Me.StepProgressBarItem3)
        Me.StepProgressBar1.LayoutMode = DevExpress.XtraEditors.StepProgressBarLayoutMode.FullSize
        Me.StepProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.StepProgressBar1.Name = "StepProgressBar1"
        Me.StepProgressBar1.SelectedItemIndex = 0
        Me.StepProgressBar1.Size = New System.Drawing.Size(740, 106)
        Me.StepProgressBar1.TabIndex = 0
        '
        'StepProgressBarItem1
        '
        Me.StepProgressBarItem1.ContentBlock2.Caption = "Order"
        Me.StepProgressBarItem1.ContentBlock2.Description = "Place order"
        Me.StepProgressBarItem1.Name = "StepProgressBarItem1"
        Me.StepProgressBarItem1.Options.Indicator.ActiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem1.Options.Indicator.ActiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.StepProgressBarItem1.Options.Indicator.InactiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem1.Options.Indicator.InactiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.StepProgressBarItem1.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
        '
        'StepProgressBarItem2
        '
        Me.StepProgressBarItem2.ContentBlock2.Caption = "Shipping"
        Me.StepProgressBarItem2.ContentBlock2.Description = "Delivery to customer"
        Me.StepProgressBarItem2.Name = "StepProgressBarItem2"
        Me.StepProgressBarItem2.Options.Indicator.ActiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem2.Options.Indicator.ActiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.StepProgressBarItem2.Options.Indicator.InactiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem2.Options.Indicator.InactiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        '
        'StepProgressBarItem3
        '
        Me.StepProgressBarItem3.ContentBlock2.Caption = "Payment"
        Me.StepProgressBarItem3.ContentBlock2.Description = "Complete Order "
        Me.StepProgressBarItem3.Name = "StepProgressBarItem3"
        Me.StepProgressBarItem3.Options.Indicator.ActiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem3.Options.Indicator.ActiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.StepProgressBarItem3.Options.Indicator.InactiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem3.Options.Indicator.InactiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        '
        'StepProgressUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StepProgressBar1)
        Me.Name = "StepProgressUC"
        Me.Size = New System.Drawing.Size(740, 106)
        CType(Me.StepProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StepProgressBar1 As DevExpress.XtraEditors.StepProgressBar
    Friend WithEvents StepProgressBarItem1 As DevExpress.XtraEditors.StepProgressBarItem
    Friend WithEvents StepProgressBarItem2 As DevExpress.XtraEditors.StepProgressBarItem
    Friend WithEvents StepProgressBarItem3 As DevExpress.XtraEditors.StepProgressBarItem
End Class
