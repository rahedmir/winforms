
Public Class frmfood_App

    Dim drag As Boolean
    Dim mouse_x As Integer
    Dim mouse_y As Integer

    Public Sub mouse_down()
        drag = True 'Sets the variable drag to true

        mouse_x = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mouse_x

        mouse_y = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mouse_y
    End Sub

    Public Sub mouse_up()
        drag = False
    End Sub

    Public Sub mouse_move()
        If drag Then

            Me.Top = Windows.Forms.Cursor.Position.Y - mouse_y

            Me.Left = Windows.Forms.Cursor.Position.X - mouse_x

        End If
    End Sub



    Private Sub panelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTop.MouseDown
        mouse_down()
    End Sub

    Private Sub panelTop_MouseUp(sender As Object, e As MouseEventArgs) Handles panelTop.MouseUp
        mouse_up()
    End Sub

    Private Sub panelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTop.MouseMove
        mouse_move()
    End Sub




    Private Sub panelLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles panelLeft.MouseDown
        mouse_down()
    End Sub

    Private Sub panelLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles panelLeft.MouseUp
        mouse_up()
    End Sub

    Private Sub panelLeft_MouseMove(sender As Object, e As MouseEventArgs) Handles panelLeft.MouseMove
        mouse_move()
    End Sub



    Private Sub frmFood_App_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelForFoods.Visible = True

        panelForDrinks.Visible = False
        panelForIceCream.Visible = False
        panelForCake.Visible = False
        panelForOrder.Visible = False

        activeFoodsPanel.Visible = True

        activeDrinksPanel.Visible = False
        activeIceCreamPanel.Visible = False
        activeCakePanel.Visible = False
        activeOrderPanel.Visible = False

    End Sub



    Private Sub foodsPanel_Click(sender As Object, e As EventArgs) Handles foodsPanel.Click

        panelForFoods.Visible = True

        panelForDrinks.Visible = False
        panelForIceCream.Visible = False
        panelForCake.Visible = False
        panelForOrder.Visible = False

        activeFoodsPanel.Visible = True

        activeDrinksPanel.Visible = False
        activeIceCreamPanel.Visible = False
        activeCakePanel.Visible = False
        activeOrderPanel.Visible = False

    End Sub

    Private Sub drinksPanel_Click(sender As Object, e As EventArgs) Handles drinksPanel.Click

        panelForDrinks.Visible = True

        panelForFoods.Visible = False
        panelForIceCream.Visible = False
        panelForCake.Visible = False
        panelForOrder.Visible = False

        activeDrinksPanel.Visible = True

        activeFoodsPanel.Visible = False
        activeIceCreamPanel.Visible = False
        activeCakePanel.Visible = False
        activeOrderPanel.Visible = False

    End Sub


    Private Sub iceCreamPanel_Click(sender As Object, e As EventArgs) Handles iceCreamPanel.Click

        panelForIceCream.Visible = True

        panelForFoods.Visible = False
        panelForDrinks.Visible = False
        panelForCake.Visible = False
        panelForOrder.Visible = False

        activeIceCreamPanel.Visible = True

        activeFoodsPanel.Visible = False
        activeDrinksPanel.Visible = False
        activeCakePanel.Visible = False
        activeOrderPanel.Visible = False

    End Sub

    Private Sub cakePanel_Click(sender As Object, e As EventArgs) Handles cakePanel.Click

        panelForCake.Visible = True

        panelForFoods.Visible = False
        panelForDrinks.Visible = False
        panelForIceCream.Visible = False
        panelForOrder.Visible = False

        activeCakePanel.Visible = True

        activeFoodsPanel.Visible = False
        activeDrinksPanel.Visible = False
        activeIceCreamPanel.Visible = False
        activeOrderPanel.Visible = False

    End Sub

    Private Sub orderPanel_Click(sender As Object, e As EventArgs) Handles orderPanel.Click

        panelForOrder.Visible = True

        panelForFoods.Visible = False
        panelForDrinks.Visible = False
        panelForIceCream.Visible = False
        panelForCake.Visible = False

        activeOrderPanel.Visible = True

        activeFoodsPanel.Visible = False
        activeDrinksPanel.Visible = False
        activeIceCreamPanel.Visible = False
        activeCakePanel.Visible = False

    End Sub



    Private Sub imgFacebook_Click(sender As Object, e As EventArgs) Handles imgFacebook.Click
        Try
            Process.Start("https://www.facebook.com/rahedmir.io")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub imgWeb_Click(sender As Object, e As EventArgs) Handles imgWeb.Click
        Try
            Process.Start("https://rahedmir.com")
        Catch ex As Exception

        End Try

    End Sub



    Private Sub imgMinimize_Click(sender As Object, e As EventArgs) Handles imgMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub imgClose_Click(sender As Object, e As EventArgs) Handles imgClose.Click
        Me.Close()
    End Sub


End Class
