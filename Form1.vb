Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim _vm = StepProgressVM.SampleVM()

        _vm.AltenatingCaption = True
        _vm.Orientation = 1
        _vm.Progress = 3.45

        Dim st = New StepProgressUC(_vm)

        st.Dock = DockStyle.Fill

        Me.Controls.Add(st)
    End Sub
End Class
