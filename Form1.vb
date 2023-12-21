Imports System.Windows.Forms.VisualStyles

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a11, a12, a13, a21, a22, a23, a31, a32, a33, Ab, Ac, Ad, Ae, Af, Ag, Ah, Ai, Aj, Ax As Single
        Dim a1, a2, a3, a4, a5, a6, a7, a8, a9 As Single
        Dim wxy, xyz As String
        a11 = Val(TextBox1.Text)
        a12 = Val(TextBox2.Text)
        a13 = Val(TextBox3.Text)
        a21 = Val(TextBox4.Text)
        a22 = Val(TextBox5.Text)
        a23 = Val(TextBox6.Text)
        a31 = Val(TextBox7.Text)
        a32 = Val(TextBox8.Text)
        a33 = Val(TextBox9.Text)
        Ax = a11 * ((a22 * a33) - (a23 * a32)) - a12 * ((a21 * a33) - (a23 * a31)) + a13 * ((a21 * a32) - (a22 * a31))
        wxy = "The inverse matrix of 'A' is as shown below"
        xyz = "Thank you copyright by Paul Wanjuki"
        Ab = Ax ^ (-1) * ((a22 * a33) - (a23 * a32))
        Ac = -1 * (Ax ^ (-1) * ((a21 * a33) - (a23 * a31)))
        Ad = Ax ^ (-1) * ((a21 * a32) - (a22 * a31))
        Ae = -1 * (Ax ^ (-1) * ((a12 * a33) - (a13 * a32)))
        Af = Ax ^ (-1) * ((a11 * a33) - (a13 * a31))
        Ag = -1 * (Ax ^ (-1) * ((a11 * a32) - (a12 * a31)))
        Ah = Ax ^ (-1) * ((a12 * a23) - (a13 * a22))
        Ai = -1 * (Ax ^ (-1) * ((a11 * a23) - (a13 * a21)))
        Aj = Ax ^ (-1) * ((a11 * a22) - (a12 * a21))


        a1 = ((a22 * a33) - (a23 * a32))
        a2 = -1 * ((a21 * a33) - (a23 * a31))
        a3 = ((a21 * a32) - (a22 * a31))
        a4 = -1 * ((a12 * a33) - (a13 * a32))
        a5 = ((a11 * a33) - (a13 * a31))
        a6 = -1 * ((a11 * a32) - (a12 * a31))
        a7 = ((a12 * a23) - (a13 * a22))
        a8 = -1 * ((a11 * a23) - (a13 * a21))
        a9 = ((a11 * a22) - (a12 * a21))


        TextBox10.Text = Ax
        TextBox11.Text = wxy
        TextBox12.Text = Ab
        TextBox13.Text = Ac
        TextBox14.Text = Ad
        TextBox15.Text = Ae
        TextBox16.Text = Af
        TextBox17.Text = Ag
        TextBox18.Text = Ah
        TextBox19.Text = Ai
        TextBox20.Text = Aj
        TextBox21.Text = xyz
        TextBox22.Text = a1
        TextBox23.Text = a2
        TextBox24.Text = a3
        TextBox25.Text = a4
        TextBox26.Text = a5
        TextBox27.Text = a6
        TextBox28.Text = a7
        TextBox29.Text = a8
        TextBox30.Text = a9

    End Sub

End Class