' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class ComparisonOperations
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

    Private Sub compare_Click(sender As Object, e As RoutedEventArgs) Handles compare.Click
        Dim i As Decimal
        Dim j As Decimal
        Dim a = number1.Text
        Dim b = number2.Text
        If Decimal.TryParse(a, i) Then
            If Decimal.TryParse(b, j) Then
                If i > j Then
                    compareSign.Text = number1.Text & " > " & number2.Text
                ElseIf i < j Then
                    compareSign.Text = number1.Text & " < " & number2.Text
                Else
                    compareSign.Text = number1.Text & " = " & number2.Text
                End If
            End If
        End If
    End Sub

End Class
