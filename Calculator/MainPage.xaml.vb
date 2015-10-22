' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Common.LayoutAwarePage

        ''' <summary>
        ''' Populates the page with content passed during navigation.  Any saved state is also
        ''' provided when recreating a page from a prior session.
        ''' </summary>
        ''' <param name="navigationParameter">The parameter value passed to
        ''' <see cref="Frame.Navigate"/> when this page was initially requested.
        ''' </param>
        ''' <param name="pageState">A dictionary of state preserved by this page during an earlier
        ''' session.  This will be null the first time a page is visited.</param>
        Protected Overrides Sub LoadState(navigationParameter As Object, pageState As Dictionary(Of String, Object))

        End Sub

        ''' <summary>
        ''' Preserves state associated with this page in case the application is suspended or the
        ''' page is discarded from the navigation cache.  Values must conform to the serialization
        ''' requirements of <see cref="Common.SuspensionManager.SessionState"/>.
        ''' </summary>
        ''' <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        Protected Overrides Sub SaveState(pageState As Dictionary(Of String, Object))

        End Sub

    Private Sub ArithematicOperations_Click(sender As Object, e As RoutedEventArgs) Handles ArithematicOperations.Click
        Me.Frame.Navigate(GetType(ArithmeticOperations))
    End Sub

    Private Sub TrigonometricOperations_Click(sender As Object, e As RoutedEventArgs) Handles TrigonometricOperations.Click
        Me.Frame.Navigate(GetType(TrigonometricOperations))
    End Sub

    Private Sub ComparisonOperations_Click(sender As Object, e As RoutedEventArgs) Handles ComparisonOperations.Click
        Me.Frame.Navigate(GetType(ComparisonOperations))
    End Sub

    Private Sub PermutationAndCombination_Click(sender As Object, e As RoutedEventArgs) Handles PermutationAndCombination.Click
        Me.Frame.Navigate(GetType(PermutationCombination))
    End Sub

    Private Sub EquationSolver_Click(sender As Object, e As RoutedEventArgs) Handles EquationSolver.Click
        Me.Frame.Navigate(GetType(EquationSolver))
    End Sub

    Private Sub HyperbolicFunctions_Click(sender As Object, e As RoutedEventArgs) Handles HyperbolicFunctions.Click
        Me.Frame.Navigate(GetType(HyperbolicFunctions))
    End Sub

    Private Sub Rounding_Click(sender As Object, e As RoutedEventArgs) Handles Rounding.Click
        Me.Frame.Navigate(GetType(Rounding))
    End Sub

    Private Sub Reverse_Click(sender As Object, e As RoutedEventArgs) Handles Reverse.Click
        Me.Frame.Navigate(GetType(Reverse))
    End Sub

    Private Sub OtherApplications_Click(sender As Object, e As RoutedEventArgs) Handles OtherApplications.Click
        Me.Frame.Navigate(GetType(OtherApplications))
    End Sub

End Class
