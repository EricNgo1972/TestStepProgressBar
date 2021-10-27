Imports DevExpress.XtraEditors

Public Class StepProgressUC

    Private _vm As StepProgressVM
    Public Sub New(vm As StepProgressVM)

        ' This call is required by the designer.
        InitializeComponent()

        InitStepUC()

        ' Add any initialization after the InitializeComponent() call.

        _vm = vm

        If _vm Is Nothing Then _vm = StepProgressVM.SampleVM


    End Sub

    Private Sub InitStepUC()

        Me.StepProgressBar1.Items.Clear()

        Me.StepProgressBar1.Appearances.ItemAppearance.ContentBlockAppearance.Description.FontStyleDelta = System.Drawing.FontStyle.Italic
        Me.StepProgressBar1.Appearances.ItemAppearance.ContentBlockAppearance.Description.Options.UseFont = True


        Me.StepProgressBar1.AutoSize = True
        Me.StepProgressBar1.ConnectorLineThickness = 3
        Me.StepProgressBar1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft

        Me.StepProgressBar1.IndentBetweenItems = 50
        Me.StepProgressBar1.ItemOptions.ConnectorOffset = 0

        Me.StepProgressBar1.ItemOptions.Indicator.ActiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline
        Me.StepProgressBar1.ItemOptions.Indicator.ActiveStateImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette

        Me.StepProgressBar1.ItemOptions.Indicator.Width = 45

        Me.StepProgressBar1.LayoutMode = DevExpress.XtraEditors.StepProgressBarLayoutMode.FullSize

        Me.StepProgressBar1.SelectedItemIndex = 0

    End Sub

    Private Sub StepProgressUC_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _vm IsNot Nothing Then

            Me.StepProgressBar1.Orientation = _vm.Orientation

            AddImages()

            AddSteps()

            SetProgressValue()

        End If
    End Sub

    Private Sub AddSteps()
        For idx = 0 To _vm.Steps.Count - 1
            Dim itm = _vm.Steps(idx)

            Dim oneStep = New StepProgressBarItem() 'Me.StepProgressBar1.Items.Add(itm.Code)
            oneStep.Progress = itm.Progress

            If _vm.AltenatingCaption AndAlso idx Mod 2 = 0 Then
                oneStep.ContentBlock2.Caption = itm.Code
                oneStep.ContentBlock2.Description = itm.Description
            Else
                oneStep.ContentBlock1.Caption = itm.Code
                oneStep.ContentBlock1.Description = itm.Description
            End If

            oneStep.Options.Indicator.ActiveStateImageOptions.ImageIndex = idx

            If idx < _vm.ImageList.Count Then
                oneStep.Options.Indicator.InactiveStateImageOptions.ImageIndex = idx
            End If

            Me.StepProgressBar1.Items.Add(oneStep)
        Next
    End Sub

    Private Sub AddImages()
        Dim imgs = New DevExpress.Utils.SvgImageCollection()
        imgs.ImageSize = New Size(24, 24)

        For idx = 0 To _vm.Steps.Count - 1
            If idx < _vm.ImageList.Count Then
                imgs.Add(DevExpress.Images.ImageResourceCache.Default.GetSvgImageById(_vm.ImageList(idx)))
            Else
                imgs.Add(DevExpress.Images.ImageResourceCache.Default.GetSvgImageById("BO_Validation"))
            End If

        Next

        Me.StepProgressBar1.Images = imgs
    End Sub

    Private Sub SetProgressValue()
        If StepProgressBar1.Items.Count = 0 Then Exit Sub

        If _vm.Progress >= _vm.Steps.Count Then
            Me.StepProgressBar1.Items.LastOrDefault().Progress = 100
        Else
            Dim IntValue = CInt(_vm.Progress)

            Me.StepProgressBar1.Items(IntValue - 1).Progress = 100
            Me.StepProgressBar1.Items(IntValue).Progress = CInt((_vm.Progress - IntValue) * 100)

        End If

    End Sub
End Class
