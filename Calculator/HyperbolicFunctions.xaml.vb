' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class HyperbolicFunctions
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


    Private Sub sinh_Click(sender As Object, e As RoutedEventArgs) Handles sinh.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            result.Text = Math.Round((1 - Math.Pow(Math.E, -2 * i)) / (2 * Math.Pow(Math.E, -i)), 15)
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub cosh_Click(sender As Object, e As RoutedEventArgs) Handles cosh.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            result.Text = Math.Round((1 + Math.Pow(Math.E, -2 * i)) / (2 * Math.Pow(Math.E, -i)), 15)
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub tanh_Click(sender As Object, e As RoutedEventArgs) Handles tanh.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            result.Text = Math.Round((1 - Math.Pow(Math.E, -2 * i)) / (1 + Math.Pow(Math.E, -2 * i)), 15)
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub cosech_Click(sender As Object, e As RoutedEventArgs) Handles cosech.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            result.Text = Math.Round((2 * Math.Pow(Math.E, -i)) / (1 - Math.Pow(Math.E, -2 * i)), 15)
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub sech_Click(sender As Object, e As RoutedEventArgs) Handles sech.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            result.Text = Math.Round((2 * Math.Pow(Math.E, -i)) / (1 + Math.Pow(Math.E, -2 * i)), 15)
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub coth_Click(sender As Object, e As RoutedEventArgs) Handles coth.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            result.Text = Math.Round((1 + Math.Pow(Math.E, -2 * i)) / (1 - Math.Pow(Math.E, -2 * i)), 15)
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub sinhInverse_Click(sender As Object, e As RoutedEventArgs) Handles sinhInverse.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            result.Text = Math.Round(Math.Log(i + Math.Sqrt(i ^ 2 + 1)), 15)
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub coshInverse_Click(sender As Object, e As RoutedEventArgs) Handles coshInverse.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            If i >= 1 Then
                result.Text = Math.Round(Math.Log(i + Math.Sqrt(i ^ 2 - 1)), 15)
            Else
                result.Text = "Invalid Input (Out of Domain)"
            End If
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub tanhInverse_Click(sender As Object, e As RoutedEventArgs) Handles tanhInverse.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            If Math.Abs(i) < 1 Then
                result.Text = Math.Round(0.5 * Math.Log((1 + i) / (1 - i)), 15)
            Else
                result.Text = "Invalid Input (Out of Domain)"
            End If
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub cosechInverse_Click(sender As Object, e As RoutedEventArgs) Handles cosechInverse.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            If Math.Abs(i) > 1 Then
                result.Text = Math.Round(0.5 * Math.Log((i + 1) / (i - 1)), 15)
            Else
                result.Text = "Invalid Input (Out of Domain)"
            End If
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub sechInverse_Click(sender As Object, e As RoutedEventArgs) Handles sechInverse.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            If i > 0 And i <= 1 Then
                result.Text = Math.Round(Math.Log((1 / i) + (Math.Sqrt(1 - i ^ 2) / i)), 15)
            Else
                result.Text = "Invalid Input (Out of Domain)"
            End If
        Else
            result.Text = "Invalid Input"
        End If
    End Sub

    Private Sub cothInverse_Click(sender As Object, e As RoutedEventArgs) Handles cothInverse.Click
        Dim i As Decimal
        Dim a = input.Text
        If Decimal.TryParse(a, i) Then
            If i <> 0 Then
                result.Text = Math.Round(Math.Log((1 / i) + (Math.Sqrt(1 + i ^ 2) / Math.Abs(i))), 15)
            Else
                result.Text = "Invalid Input (Out of Domain)"
            End If
        Else
            result.Text = "Invalid Input"
        End If
    End Sub
End Class
