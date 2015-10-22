' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class NumberReversal
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

    Private Sub reverse_Click(sender As Object, e As RoutedEventArgs) Handles reverse.Click
        Dim i As System.Numerics.BigInteger
        Dim a = number.Text
        If System.Numerics.BigInteger.TryParse(a, i) Then
            Dim m As System.Numerics.BigInteger = 1.0E+36
            If i < 0 Then
                reverseResult.Text = "Not a Whole Number"

            ElseIf i < m Then
                Dim b As System.Numerics.BigInteger = 0
                While (i <> 0)
                    b = 10 * b + i Mod 10
                    i /= 10
                End While
                reverseResult.Text = b.ToString()
            Else
                reverseResult.Text = "Overflow"
            End If
        Else
            reverseResult.Text = "Invalid Input"
        End If
    End Sub

End Class
