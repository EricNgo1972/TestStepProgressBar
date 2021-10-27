Imports DevExpress.Utils

Public Class StepProgressVM

    Public Shared Function SampleVM() As StepProgressVM
        Dim ret = New StepProgressVM

        ret.Steps.Add(New StepInfo() With {.Code = "KickOff", .Description = "Kick off project"})
        ret.Steps.Add(New StepInfo() With {.Code = "SystemDesign", .Description = "Design and produce SDD"})
        ret.Steps.Add(New StepInfo() With {.Code = "Implementation", .Description = "Implement and deploy"})
        ret.Steps.Add(New StepInfo() With {.Code = "UserTraining", .Description = "Training for end-user"})
        ret.Steps.Add(New StepInfo() With {.Code = "SignOff", .Description = "Complete and handover to client"})

        ret.ImageList.Add("State_Priority_Normal")
        ret.ImageList.Add("Action_Show_PivotGrid_Designer")
        ret.ImageList.Add("BO_WorkflowDefinition")
        ret.ImageList.Add("Doctor")
        ret.ImageList.Add("Shopping_Favorites")

        Return ret
    End Function

    Private _progress As Decimal
    Public Property Progress As Decimal
        Get
            Return _progress
        End Get
        Set(ByVal value As Decimal)
            _progress = value
        End Set
    End Property

#Region "Contents"

    Private _steps As List(Of StepInfo)
    Public ReadOnly Property Steps As List(Of StepInfo)
        Get
            If _steps Is Nothing Then _steps = New List(Of StepInfo)
            Return _steps
        End Get
    End Property

    Private _imageList As List(Of String)
    Public ReadOnly Property ImageList As List(Of String)
        Get
            If _imageList Is Nothing Then _imageList = New List(Of String)
            Return _imageList
        End Get
    End Property

#End Region

#Region "Appearance"

    Private _altenatingCaption As Boolean
    Public Property AltenatingCaption As Boolean
        Get
            Return _altenatingCaption
        End Get
        Set(ByVal value As Boolean)
            _altenatingCaption = value
        End Set
    End Property

    Private _orientation As Integer
    ''' <summary>
    ''' 0-Horizontal. 1-Vertical
    ''' </summary>
    ''' <returns></returns>
    Public Property Orientation As Integer
        Get
            Return _orientation
        End Get
        Set(ByVal value As Integer)
            _orientation = value
        End Set
    End Property


#End Region

    <Serializable>
    Class StepInfo

        Property Code As String = ""
        Property Description As String = ""
        Property Progress As Integer

    End Class

End Class
