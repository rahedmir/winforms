Public Class frm_emsisoft

    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Public Sub mouse_UP()
        drag = False
    End Sub

    Public Sub mouse_Down()
        drag = True
        mouseX = Windows.Forms.Cursor.Position.X - Me.Left
        mouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Public Sub mouse_Move()
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mouseX
            Me.Top = Windows.Forms.Cursor.Position.Y - mouseY
        End If
    End Sub



    Public Sub full_cheack()

        If GunaCheckWeb.Checked = False And GunaCheckFile.Checked = False And GunaCheckMail.Checked = False And GunaCheckFirewall.Checked = False Then

            btnProtection.BackColor = Color.Red

            imgProtection.BackColor = Color.Red

            lblProtection.BackColor = Color.Red
            lblWebProtection.BackColor = Color.Red
            lblFileGuard.BackColor = Color.Red
            lblMailProtection.BackColor = Color.Red
            lblFirewall.BackColor = Color.Red

            GunaCheckWeb.BackColor = Color.Red
            GunaCheckFile.BackColor = Color.Red
            GunaCheckMail.BackColor = Color.Red
            GunaCheckFirewall.BackColor = Color.Red

            btnProtection.FlatAppearance.MouseDownBackColor = Color.Red
            btnProtection.FlatAppearance.MouseOverBackColor = Color.Red

            lblNotProtected.Visible = True
            lblFixNow.Visible = True

            lblProtected.Visible = False
            lblPartiallyProtected.Visible = False

        ElseIf GunaCheckWeb.Checked = True And GunaCheckFile.Checked = True And GunaCheckMail.Checked = True And GunaCheckFirewall.Checked = True Then

            btnProtection.BackColor = Color.FromArgb(101, 187, 19)

            imgProtection.BackColor = Color.FromArgb(101, 187, 19)

            lblProtection.BackColor = Color.FromArgb(101, 187, 19)
            lblWebProtection.BackColor = Color.FromArgb(101, 187, 19)
            lblFileGuard.BackColor = Color.FromArgb(101, 187, 19)
            lblMailProtection.BackColor = Color.FromArgb(101, 187, 19)
            lblFirewall.BackColor = Color.FromArgb(101, 187, 19)

            GunaCheckWeb.BackColor = Color.FromArgb(101, 187, 19)
            GunaCheckFile.BackColor = Color.FromArgb(101, 187, 19)
            GunaCheckMail.BackColor = Color.FromArgb(101, 187, 19)
            GunaCheckFirewall.BackColor = Color.FromArgb(101, 187, 19)

            btnProtection.FlatAppearance.MouseDownBackColor = Color.FromArgb(101, 187, 19)
            btnProtection.FlatAppearance.MouseOverBackColor = Color.FromArgb(101, 187, 19)

            lblProtected.Visible = True

            lblNotProtected.Visible = False
            lblFixNow.Visible = False

            lblPartiallyProtected.Visible = False
        End If
    End Sub


    Public Sub partially_check()

        If GunaCheckWeb.Checked = False Or GunaCheckFile.Checked = False Or GunaCheckMail.Checked = False Or GunaCheckFirewall.Checked = False Then

            btnProtection.BackColor = Color.FromArgb(237, 198, 0)

            imgProtection.BackColor = Color.FromArgb(237, 198, 0)

            lblProtection.BackColor = Color.FromArgb(237, 198, 0)
            lblWebProtection.BackColor = Color.FromArgb(237, 198, 0)
            lblFileGuard.BackColor = Color.FromArgb(237, 198, 0)
            lblMailProtection.BackColor = Color.FromArgb(237, 198, 0)
            lblFirewall.BackColor = Color.FromArgb(237, 198, 0)

            GunaCheckWeb.BackColor = Color.FromArgb(237, 198, 0)
            GunaCheckFile.BackColor = Color.FromArgb(237, 198, 0)
            GunaCheckMail.BackColor = Color.FromArgb(237, 198, 0)
            GunaCheckFirewall.BackColor = Color.FromArgb(237, 198, 0)

            btnProtection.FlatAppearance.MouseDownBackColor = Color.FromArgb(237, 198, 0)
            btnProtection.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 198, 0)

            lblPartiallyProtected.Visible = True

            lblNotProtected.Visible = False
            lblFixNow.Visible = False

            lblProtected.Visible = False
        End If
    End Sub



    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



    Private Sub frm_emsisoft_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        mouse_UP()
    End Sub
    Private Sub frm_emsisoft_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mouse_Down()
    End Sub

    Private Sub frm_emsisoft_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        mouse_Move()
    End Sub

    Private Sub PanelMain_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelMain.MouseUp
        mouse_UP()
    End Sub

    Private Sub PanelMain_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMain.MouseDown
        mouse_Down()
    End Sub

    Private Sub PanelMain_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelMain.MouseMove
        mouse_Move()
    End Sub



    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click

        panelHome.Visible = True

        panelSecurity.Visible = False
        panelScanner.Visible = False
        panelChest.Visible = False
        panelMenu.Visible = False
        panelSetting.Visible = False
        panelNotification.Visible = False
        panelChat.Visible = False
        panelHelp.Visible = False
    End Sub

    Private Sub imgSecurity_Click(sender As Object, e As EventArgs) Handles imgSecurity.Click

        panelSecurity.Visible = True

        panelHome.Visible = False
        panelScanner.Visible = False
        panelChest.Visible = False
        panelMenu.Visible = False
        panelSetting.Visible = False
        panelNotification.Visible = False
        panelChat.Visible = False
        panelHelp.Visible = False
    End Sub

    Private Sub imgScanner_Click(sender As Object, e As EventArgs) Handles imgScanner.Click

        panelScanner.Visible = True

        panelHome.Visible = False
        panelSecurity.Visible = False
        panelChest.Visible = False
        panelMenu.Visible = False
        panelSetting.Visible = False
        panelNotification.Visible = False
        panelChat.Visible = False
        panelHelp.Visible = False
    End Sub

    Private Sub imgChest_Click(sender As Object, e As EventArgs) Handles imgChest.Click

        panelChest.Visible = True

        panelHome.Visible = False
        panelSecurity.Visible = False
        panelScanner.Visible = False
        panelMenu.Visible = False
        panelSetting.Visible = False
        panelNotification.Visible = False
        panelChat.Visible = False
        panelHelp.Visible = False
    End Sub

    Private Sub imgMenu_Click(sender As Object, e As EventArgs) Handles imgMenu.Click

        panelMenu.Visible = True

        panelHome.Visible = False
        panelSecurity.Visible = False
        panelScanner.Visible = False
        panelChest.Visible = False
        panelSetting.Visible = False
        panelNotification.Visible = False
        panelChat.Visible = False
        panelHelp.Visible = False
    End Sub

    Private Sub imgSetting_Click(sender As Object, e As EventArgs) Handles imgSetting.Click

        panelSetting.Visible = True

        panelHome.Visible = False
        panelSecurity.Visible = False
        panelScanner.Visible = False
        panelChest.Visible = False
        panelMenu.Visible = False
        panelNotification.Visible = False
        panelChat.Visible = False
        panelHelp.Visible = False
    End Sub

    Private Sub imgNotification_Click(sender As Object, e As EventArgs) Handles imgNotification.Click

        panelNotification.Visible = True

        panelHome.Visible = False
        panelSecurity.Visible = False
        panelScanner.Visible = False
        panelChest.Visible = False
        panelMenu.Visible = False
        panelSetting.Visible = False
        panelChat.Visible = False
        panelHelp.Visible = False
    End Sub

    Private Sub imgChat_Click(sender As Object, e As EventArgs) Handles imgChat.Click

        panelChat.Visible = True

        panelHome.Visible = False
        panelSecurity.Visible = False
        panelScanner.Visible = False
        panelChest.Visible = False
        panelMenu.Visible = False
        panelSetting.Visible = False
        panelNotification.Visible = False
        panelHelp.Visible = False
    End Sub

    Private Sub imgHelp_Click(sender As Object, e As EventArgs) Handles imgHelp.Click

        panelHelp.Visible = True

        panelHome.Visible = False
        panelSecurity.Visible = False
        panelScanner.Visible = False
        panelChest.Visible = False
        panelMenu.Visible = False
        panelSetting.Visible = False
        panelNotification.Visible = False
        panelChat.Visible = False
    End Sub


    Private Sub GunaCheckWeb_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckWeb.CheckedChanged
        partially_check()
        full_cheack()
    End Sub

    Private Sub GunaCheckFile_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckFile.CheckedChanged
        partially_check()
        full_cheack()
    End Sub

    Private Sub GunaCheckMail_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckMail.CheckedChanged
        partially_check()
        full_cheack()
    End Sub

    Private Sub GunaCheckFirewall_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckFirewall.CheckedChanged
        partially_check()
        full_cheack()
    End Sub


    Private Sub lblFixNow_MouseHover(sender As Object, e As EventArgs) Handles lblFixNow.MouseHover
        divFixNow.Visible = True
    End Sub

    Private Sub lblFixNow_MouseLeave(sender As Object, e As EventArgs) Handles lblFixNow.MouseLeave
        divFixNow.Visible = False
    End Sub


    Private Sub lblFixNow_Click(sender As Object, e As EventArgs) Handles lblFixNow.Click

        GunaCheckWeb.Checked = True
        GunaCheckFile.Checked = True
        GunaCheckMail.Checked = True
        GunaCheckFirewall.Checked = True

        btnProtection.BackColor = Color.FromArgb(101, 187, 19)

        lblProtected.Visible = True

        lblNotProtected.Visible = False
        lblFixNow.Visible = False
    End Sub



    Private Sub lblQuickScan_MouseHover(sender As Object, e As EventArgs) Handles lblQuickScan.MouseHover
        divQuickScan.Visible = True
    End Sub

    Private Sub lblQuickScan_MouseLeave(sender As Object, e As EventArgs) Handles lblQuickScan.MouseLeave
        divQuickScan.Visible = False
    End Sub

    Private Sub lblMalwareScan_MouseHover(sender As Object, e As EventArgs) Handles lblMalwareScan.MouseHover
        divMalwareScan.Visible = True
    End Sub

    Private Sub lblMalwareScan_MouseLeave(sender As Object, e As EventArgs) Handles lblMalwareScan.MouseLeave
        divMalwareScan.Visible = False
    End Sub

    Private Sub lblCustomScan_MouseHover(sender As Object, e As EventArgs) Handles lblCustomScan.MouseHover
        divCustomScan.Visible = True
    End Sub

    Private Sub lblCustomScan_MouseLeave(sender As Object, e As EventArgs) Handles lblCustomScan.MouseLeave
        divCustomScan.Visible = False
    End Sub

    Private Sub lblQuarantine_MouseHover(sender As Object, e As EventArgs) Handles lblQuarantine.MouseHover
        divQuarantine.Visible = True
    End Sub

    Private Sub lblQuarantine_MouseLeave(sender As Object, e As EventArgs) Handles lblQuarantine.MouseLeave
        divQuarantine.Visible = False
    End Sub



    Private Sub btnWinFirewall_Click(sender As Object, e As EventArgs) Handles btnWinFirewall.Click

        If btnWinFirewall.Text = "ON" Then
            btnWinFirewall.Text = "OFF"
            btnWinFirewall.BackColor = Color.FromArgb(102, 103, 101)

        ElseIf btnWinFirewall.Text = "OFF" Then
            btnWinFirewall.Text = "ON"
            btnWinFirewall.BackColor = Color.FromArgb(101, 187, 19)
        End If
    End Sub

    Private Sub btnNetworkLock_Click(sender As Object, e As EventArgs) Handles btnNetworkLock.Click

        If btnNetworkLock.Text = "ON" Then
            btnNetworkLock.Text = "OFF"
            btnNetworkLock.BackColor = Color.FromArgb(102, 103, 101)
            lblNetworkLock.ForeColor = Color.FromArgb(102, 103, 101)

        ElseIf btnNetworkLock.Text = "OFF" Then
            btnNetworkLock.Text = "ON"
            btnNetworkLock.BackColor = Color.Red
            lblNetworkLock.ForeColor = Color.Red
        End If
    End Sub



    Private Sub lblUpdateNow_Click(sender As Object, e As EventArgs) Handles lblUpdateNow.Click

        If lblUpdateTime.Text = "few moment ago" Then
            lblUpdateTime.Text = "up to date"

        ElseIf lblUpdateTime.Text = "up to date" Then
            lblUpdateTime.Text = "few moment ago"
        End If
    End Sub



    Private Sub lblUpdateNow_MouseHover(sender As Object, e As EventArgs) Handles lblUpdateNow.MouseHover
        divUpdateNow.Visible = True
    End Sub

    Private Sub lblUpdateNow_MouseLeave(sender As Object, e As EventArgs) Handles lblUpdateNow.MouseLeave
        divUpdateNow.Visible = False
    End Sub

    Private Sub lblDetails_MouseHover(sender As Object, e As EventArgs) Handles lblDetails.MouseHover
        divDetails.Visible = True
    End Sub

    Private Sub lblDetails_MouseLeave(sender As Object, e As EventArgs) Handles lblDetails.MouseLeave
        divDetails.Visible = False
    End Sub

    Private Sub lblAbout_MouseHover(sender As Object, e As EventArgs) Handles lblAbout.MouseHover
        divAbout.Visible = True
    End Sub

    Private Sub lblAbout_MouseLeave(sender As Object, e As EventArgs) Handles lblAbout.MouseLeave
        divAbout.Visible = False
    End Sub



    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        Try
            Process.Start("https://www.emsisoft.com/en/")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub imgTwitter_Click(sender As Object, e As EventArgs) Handles imgTwitter.Click
        Try
            Process.Start("https://twitter.com/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub imgYoutube_Click(sender As Object, e As EventArgs) Handles imgYoutube.Click
        Try
            Process.Start("https://www.youtube.com/")
        Catch ex As Exception

        End Try
    End Sub



    Private Sub lblSecNews_1_Click(sender As Object, e As EventArgs) Handles lblSecNews_1.Click
        Try
            Process.Start("https://blog.emsisoft.com/en/35879/pwndlocker-ransomware-decryption-now-available/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblSecNews_2_Click(sender As Object, e As EventArgs) Handles lblSecNews_2.Click
        Try
            Process.Start("https://blog.emsisoft.com/en/35235/ransomware-data-exfiltration-detection-and-mitigation-strategies/facebook-1-3/")
        Catch ex As Exception

        End Try
    End Sub



    Private Sub imgNavLeft_Click(sender As Object, e As EventArgs) Handles imgNavLeft.Click
        lblSecNews_1.Visible = True
        lblSecNews_2.Visible = False
    End Sub

    Private Sub imgNavRight_Click(sender As Object, e As EventArgs) Handles imgNavRight.Click
        lblSecNews_1.Visible = False
        lblSecNews_2.Visible = True
    End Sub

End Class
