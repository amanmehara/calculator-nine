' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class Permutation
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

    Private Function fact(number)
        Dim f As System.Numerics.BigInteger = 1
        For i As Integer = 1 To number
            f *= i
        Next
        Return f
    End Function

    Private Sub calculate_Click(sender As Object, e As RoutedEventArgs) Handles calculate.Click
        Dim i As Decimal
        Dim j As Decimal
        Dim a = n.Text
        Dim b = r.Text
        If UInteger.TryParse(a, i) Then
            If i = 0 Then
                permutationResult.Text = "Invalid Input (n not a natural number)"
            ElseIf i > 10000 Then
                permutationResult.Text = "Overflow (max(n) = 10000)"
            ElseIf UInteger.TryParse(b, j) Then
                If i >= j Then
                    Dim permutation As System.Numerics.BigInteger = (fact(i) / fact(i - j))
                    Dim limit As System.Numerics.BigInteger = 1.0E+25
                    If permutation < limit Then
                        permutationResult.Text = permutation.ToString()
                    Else
                        permutationResult.Text = permutation.ToString("E")
                    End If
                Else
                    permutationResult.Text = "Invalid Input (n not greater than r)"
                End If
                Else
                permutationResult.Text = "Invalid Input (r not a whole number)"
            End If
        Else
            permutationResult.Text = "Invalid Input (n not a natural number)"
        End If
    End Sub

End Class
