' The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

''' <summary>
''' A basic page that provides characteristics common to most applications.
''' </summary>
Public NotInheritable Class TrigonometricOperations
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

    

    Private Sub sinInverse_Click(sender As Object, e As RoutedEventArgs) Handles sinInverse.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If i >= -1 And i <= 1 Then
                If selector.SelectedIndex = 1 Then
                    result.Text = Math.Asin(i) * 180 / Math.PI
                    Exit Sub
                ElseIf selector.SelectedIndex = 2 Then
                    result.Text = Math.Asin(i) * 180 / Math.PI * (10 / 9)
                    Exit Sub
                End If
                result.Text = Math.Asin(i)
            Else
                result.Text = "Invalid Input (Out of Domain)"
            End If
        End If
    End Sub

    Private Sub cosInverse_Click(sender As Object, e As RoutedEventArgs) Handles cosInverse.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If i >= -1 And i <= 1 Then
                If selector.SelectedIndex = 1 Then
                    result.Text = Math.Acos(i) * 180 / Math.PI
                    Exit Sub
                ElseIf selector.SelectedIndex = 2 Then
                    result.Text = Math.Acos(i) * 180 / Math.PI * (10 / 9)
                    Exit Sub
                End If
                result.Text = Math.Acos(i)
            Else
                result.Text = "Invalid Input (Out of Domain)"
            End If
        End If

    End Sub

    Private Sub tanInverse_Click(sender As Object, e As RoutedEventArgs) Handles tanInverse.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If selector.SelectedIndex = 1 Then
                result.Text = Math.Atan(i) * 180 / Math.PI
                Exit Sub
            ElseIf selector.SelectedIndex = 2 Then
                result.Text = Math.Atan(i) * 180 / Math.PI * (10 / 9)
                Exit Sub
            End If
            result.Text = Math.Atan(i)
        End If

    End Sub

    Private Sub cosecInverse_Click(sender As Object, e As RoutedEventArgs) Handles cosecInverse.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If i <= -1 Or i >= 1 Then
                If selector.SelectedIndex = 1 Then
                    result.Text = Math.Atan(Math.Sign(i) / Math.Sqrt(i * i - 1)) * 180 / Math.PI
                    Exit Sub
                ElseIf selector.SelectedIndex = 2 Then
                    result.Text = Math.Atan(Math.Sign(i) / Math.Sqrt(i * i - 1)) * 180 / Math.PI * (10 / 9)
                    Exit Sub
                End If
                result.Text = Math.Atan(Math.Sign(i) / Math.Sqrt(i * i - 1))
            Else
                result.Text = "Invalid Input (Out of Domain)"
            End If
        End If

    End Sub

    Private Sub secInverse_Click(sender As Object, e As RoutedEventArgs) Handles secInverse.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If i <= -1 Or i >= 1 Then
                If selector.SelectedIndex = 1 Then
                    result.Text = (2 * Math.Atan(1) - Math.Atan(Math.Sign(i) / Math.Sqrt(i * i - 1))) * 180 / Math.PI
                    Exit Sub
                ElseIf selector.SelectedIndex = 1 Then
                    result.Text = (2 * Math.Atan(1) - Math.Atan(Math.Sign(i) / Math.Sqrt(i * i - 1))) * 180 / Math.PI * (10 / 9)
                    Exit Sub
                End If
                result.Text = 2 * Math.Atan(1) - Math.Atan(Math.Sign(i) / Math.Sqrt(i * i - 1))
            Else
                result.Text = "Invalid Input (Out of Domain)"
            End If
        End If
    End Sub

    Private Sub cotInverse_Click(sender As Object, e As RoutedEventArgs) Handles cotInverse.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If selector.SelectedIndex = 1 Then
                result.Text = (2 * Math.Atan(1) - Math.Atan(i)) * 180 / Math.PI
                Exit Sub
            ElseIf selector.SelectedIndex = 1 Then
                result.Text = (2 * Math.Atan(1) - Math.Atan(i)) * 180 / Math.PI * (10 / 9)
                Exit Sub
            End If
            result.Text = 2 * Math.Atan(1) - Math.Atan(i)

        End If

    End Sub

    Private Sub sin_Click(sender As Object, e As RoutedEventArgs) Handles sin.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If selector.SelectedIndex = 1 Then
                i = i * Math.PI / 180
            ElseIf selector.SelectedIndex = 2 Then
                i = i * (9 / 10) * Math.PI / 180
            End If
            result.Text = Math.Round(Math.Sin(i), 12)

        End If
    End Sub

    Private Sub cos_Click(sender As Object, e As RoutedEventArgs) Handles cos.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If selector.SelectedIndex = 1 Then
                i = i * Math.PI / 180
            ElseIf selector.SelectedIndex = 2 Then
                i = i * (9 / 10) * Math.PI / 180
            End If
            result.Text = Math.Round(Math.Cos(i), 12)

        End If

    End Sub

    Private Sub tan_Click(sender As Object, e As RoutedEventArgs) Handles tan.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If selector.SelectedIndex = 1 Then
                If i Mod 90 = 0 And i Mod 180 <> 0 Then
                    result.Text = "Not Defined"
                    Exit Sub
                End If
                i = i * Math.PI / 180
            ElseIf selector.SelectedIndex = 2 Then
                If i Mod 100 = 0 And i Mod 200 <> 0 Then
                    result.Text = "Not Defined"
                    Exit Sub
                End If
                i = i * (9 / 10) * Math.PI / 180
            End If
            result.Text = Math.Round(Math.Tan(i), 12)

        End If

    End Sub

    Private Sub cosec_Click(sender As Object, e As RoutedEventArgs) Handles cosec.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If selector.SelectedIndex = 1 Then
                If i Mod 180 = 0 Then
                    result.Text = "Not Defined"
                    Exit Sub
                End If
                i = i * Math.PI / 180
            ElseIf selector.SelectedIndex = 2 Then
                If i Mod 200 = 0 Then
                    result.Text = "Not Defined"
                    Exit Sub
                End If
                i = i * (9 / 10) * Math.PI / 180
            End If
            result.Text = Math.Round(1 / (Math.Sin(i)), 12)

        End If

    End Sub

    Private Sub sec_Click(sender As Object, e As RoutedEventArgs) Handles sec.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If selector.SelectedIndex = 1 Then
                If i Mod 90 = 0 And i Mod 180 <> 0 Then
                    result.Text = "Not Defined"
                    Exit Sub
                End If
                i = i * Math.PI / 180
            ElseIf selector.SelectedIndex = 2 Then
                If i Mod 100 = 0 And i Mod 200 <> 0 Then
                    result.Text = "Not Defined"
                    Exit Sub
                End If
                i = i * (9 / 10) * Math.PI / 180
            End If
            result.Text = Math.Round(1 / (Math.Cos(i)), 12)

        End If

    End Sub

    Private Sub cot_Click(sender As Object, e As RoutedEventArgs) Handles cot.Click
        Dim i As Decimal
        Dim a = angleRatioInput.Text
        If Decimal.TryParse(a, i) Then
            If selector.SelectedIndex = 1 Then
                If i Mod 180 = 0 Then
                    result.Text = "Not Defined"
                    Exit Sub
                End If
                i = i * Math.PI / 180
            ElseIf selector.SelectedIndex = 2 Then
                If i Mod 200 = 0 Then
                    result.Text = "Not Defined"
                    Exit Sub
                End If
                i = i * (9 / 10) * Math.PI / 180
            End If
            result.Text = Math.Round(1 / (Math.Tan(i)), 12)

        End If

    End Sub
End Class
