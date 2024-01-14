Public Class Form1
    Public buffer As String = ""
    Public filter As String = ""
    Public baseT As String = ""
    Public xiin As String = 0
    Dim reloj As String = ""
    Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Long) As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        timettempo()
    End Sub
    Private Sub msg1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg1.MouseClick
        coloresdeltexbox()
        msg1.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg2.MouseClick
        coloresdeltexbox()
        msg2.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg3.MouseClick
        coloresdeltexbox()
        msg3.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg4.MouseClick
        coloresdeltexbox()
        msg4.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg5_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg5.MouseClick
        coloresdeltexbox()
        msg5.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg6_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg6.MouseClick
        coloresdeltexbox()
        msg6.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg7_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg7.MouseClick
        coloresdeltexbox()
        msg7.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg8_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg8.MouseClick
        coloresdeltexbox()
        msg8.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg9_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg9.MouseClick
        coloresdeltexbox()
        msg9.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg10_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg10.MouseClick
        coloresdeltexbox()
        msg10.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg11_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg11.MouseClick
        coloresdeltexbox()
        msg11.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg12_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg12.MouseClick
        coloresdeltexbox()
        msg12.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg13_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg13.MouseClick
        coloresdeltexbox()
        msg13.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg14_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg14.MouseClick
        coloresdeltexbox()
        msg14.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg15_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg15.MouseClick
        coloresdeltexbox()
        msg15.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg16_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg16.MouseClick
        coloresdeltexbox()
        msg16.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg17_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg17.MouseClick
        coloresdeltexbox()
        msg17.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg18_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg18.MouseClick
        coloresdeltexbox()
        msg18.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg19_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg19.MouseClick
        coloresdeltexbox()
        msg19.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg20_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg20.MouseClick
        coloresdeltexbox()
        msg20.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg21_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg21.MouseClick
        coloresdeltexbox()
        msg21.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg22_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg22.MouseClick
        coloresdeltexbox()
        msg22.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg23_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg23.MouseClick
        coloresdeltexbox()
        msg23.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg24_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg24.MouseClick
        coloresdeltexbox()
        msg24.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg25_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg25.MouseClick
        coloresdeltexbox()
        msg25.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg26_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg26.MouseClick
        coloresdeltexbox()
        msg26.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg27_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg27.MouseClick
        coloresdeltexbox()
        msg27.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg28_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg28.MouseClick
        coloresdeltexbox()
        msg28.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg29_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg29.MouseClick
        coloresdeltexbox()
        msg29.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg30_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg30.MouseClick
        coloresdeltexbox()
        msg30.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg31_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg31.MouseClick
        coloresdeltexbox()
        msg31.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg32_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg32.MouseClick
        coloresdeltexbox()
        msg32.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg33_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg33.MouseClick
        coloresdeltexbox()
        msg33.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg34_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg34.MouseClick
        coloresdeltexbox()
        msg34.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg35_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg35.MouseClick
        coloresdeltexbox()
        msg35.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg36_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg36.MouseClick
        coloresdeltexbox()
        msg36.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg37_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg37.MouseClick
        coloresdeltexbox()
        msg37.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg38_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg38.MouseClick
        coloresdeltexbox()
        msg38.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg39_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg39.MouseClick
        coloresdeltexbox()
        msg39.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg40_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg40.MouseClick
        coloresdeltexbox()
        msg40.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg41_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg41.MouseClick
        coloresdeltexbox()
        msg41.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg42_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg42.MouseClick
        coloresdeltexbox()
        msg42.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg43_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg43.MouseClick
        coloresdeltexbox()
        msg43.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg44_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg44.MouseClick
        coloresdeltexbox()
        msg44.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg45_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg45.MouseClick
        coloresdeltexbox()
        msg45.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg46_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg46.MouseClick
        coloresdeltexbox()
        msg46.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg47_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg47.MouseClick
        coloresdeltexbox()
        msg47.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg48_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg48.MouseClick
        coloresdeltexbox()
        msg48.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg49_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg49.MouseClick
        coloresdeltexbox()
        msg49.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg50_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg50.MouseClick
        coloresdeltexbox()
        msg50.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg51_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg51.MouseClick
        coloresdeltexbox()
        msg51.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg52_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg52.MouseClick
        coloresdeltexbox()
        msg52.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg53_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg53.MouseClick
        coloresdeltexbox()
        msg53.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg54_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg54.MouseClick
        coloresdeltexbox()
        msg54.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg55_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg55.MouseClick
        coloresdeltexbox()
        msg55.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg56_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg56.MouseClick
        coloresdeltexbox()
        msg56.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg57_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg57.MouseClick
        coloresdeltexbox()
        msg57.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg58_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg58.MouseClick
        coloresdeltexbox()
        msg58.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg59_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg59.MouseClick
        coloresdeltexbox()
        msg59.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg60_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg60.MouseClick
        coloresdeltexbox()
        msg60.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg61_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg61.MouseClick
        coloresdeltexbox()
        msg61.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg62_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg62.MouseClick
        coloresdeltexbox()
        msg62.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg63_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg63.MouseClick
        coloresdeltexbox()
        msg63.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg64_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg64.MouseClick
        coloresdeltexbox()
        msg64.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg65_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg65.MouseClick
        coloresdeltexbox()
        msg65.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg66_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg66.MouseClick
        coloresdeltexbox()
        msg66.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg67_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg67.MouseClick
        coloresdeltexbox()
        msg67.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg68_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg68.MouseClick
        coloresdeltexbox()
        msg68.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg69_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg69.MouseClick
        coloresdeltexbox()
        msg69.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg70_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg70.MouseClick
        coloresdeltexbox()
        msg70.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg71_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg71.MouseClick
        coloresdeltexbox()
        msg71.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg72_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg72.MouseClick
        coloresdeltexbox()
        msg72.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg73_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg73.MouseClick
        coloresdeltexbox()
        msg73.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg74_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg74.MouseClick
        coloresdeltexbox()
        msg74.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg75_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg75.MouseClick
        coloresdeltexbox()
        msg75.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg76_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg76.MouseClick
        coloresdeltexbox()
        msg76.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg77_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg77.MouseClick
        coloresdeltexbox()
        msg77.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg78_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg78.MouseClick
        coloresdeltexbox()
        msg78.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg79_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg79.MouseClick
        coloresdeltexbox()
        msg79.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg80_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg80.MouseClick
        coloresdeltexbox()
        msg80.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg81_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg81.MouseClick
        coloresdeltexbox()
        msg81.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg82_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg82.MouseClick
        coloresdeltexbox()
        msg82.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg83_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg83.MouseClick
        coloresdeltexbox()
        msg83.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg84_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg84.MouseClick
        coloresdeltexbox()
        msg84.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg85_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg85.MouseClick
        coloresdeltexbox()
        msg85.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg86_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg86.MouseClick
        coloresdeltexbox()
        msg86.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg87_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg87.MouseClick
        coloresdeltexbox()
        msg87.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg88_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg88.MouseClick
        coloresdeltexbox()
        msg88.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg89_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg89.MouseClick
        coloresdeltexbox()
        msg89.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg90_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg90.MouseClick
        coloresdeltexbox()
        msg90.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg91_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg91.MouseClick
        coloresdeltexbox()
        msg91.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg92_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg92.MouseClick
        coloresdeltexbox()
        msg92.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg93_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg93.MouseClick
        coloresdeltexbox()
        msg93.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg94_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg94.MouseClick
        coloresdeltexbox()
        msg94.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg95_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg95.MouseClick
        coloresdeltexbox()
        msg95.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg96_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg96.MouseClick
        coloresdeltexbox()
        msg96.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg97_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg97.MouseClick
        coloresdeltexbox()
        msg97.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg98_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg98.MouseClick
        coloresdeltexbox()
        msg98.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg99_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg99.MouseClick
        coloresdeltexbox()
        msg99.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg100_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg100.MouseClick
        coloresdeltexbox()
        msg100.BackColor = Color.PaleTurquoise
    End Sub
    Private Sub msg1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg1.MouseDoubleClick
        msg1.Text = ""
    End Sub
    Private Sub msg2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg2.MouseDoubleClick
        msg2.Text = ""
    End Sub
    Private Sub msg3_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg3.MouseDoubleClick
        msg3.Text = ""
    End Sub
    Private Sub msg4_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg4.MouseDoubleClick
        msg4.Text = ""
    End Sub
    Private Sub msg5_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg5.MouseDoubleClick
        msg5.Text = ""
    End Sub
    Private Sub msg6_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg6.MouseDoubleClick
        msg6.Text = ""
    End Sub
    Private Sub msg7_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg7.MouseDoubleClick
        msg7.Text = ""
    End Sub
    Private Sub msg8_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg8.MouseDoubleClick
        msg8.Text = ""
    End Sub
    Private Sub msg9_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg9.MouseDoubleClick
        msg9.Text = ""
    End Sub
    Private Sub msg10_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg10.MouseDoubleClick
        msg10.Text = ""
    End Sub
    Private Sub msg11_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg11.MouseDoubleClick
        msg11.Text = ""
    End Sub
    Private Sub msg12_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg12.MouseDoubleClick
        msg12.Text = ""
    End Sub
    Private Sub msg13_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg13.MouseDoubleClick
        msg13.Text = ""
    End Sub
    Private Sub msg14_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg14.MouseDoubleClick
        msg14.Text = ""
    End Sub
    Private Sub msg15_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg15.MouseDoubleClick
        msg15.Text = ""
    End Sub
    Private Sub msg16_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg16.MouseDoubleClick
        msg16.Text = ""
    End Sub
    Private Sub msg17_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg17.MouseDoubleClick
        msg17.Text = ""
    End Sub
    Private Sub msg18_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg18.MouseDoubleClick
        msg18.Text = ""
    End Sub
    Private Sub msg19_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg19.MouseDoubleClick
        msg19.Text = ""
    End Sub
    Private Sub msg20_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg20.MouseDoubleClick
        msg20.Text = ""
    End Sub
    Private Sub msg21_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg21.MouseDoubleClick
        msg21.Text = ""
    End Sub
    Private Sub msg22_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg22.MouseDoubleClick
        msg22.Text = ""
    End Sub
    Private Sub msg23_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg23.MouseDoubleClick
        msg23.Text = ""
    End Sub
    Private Sub msg24_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg24.MouseDoubleClick
        msg24.Text = ""
    End Sub
    Private Sub msg25_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg25.MouseDoubleClick
        msg25.Text = ""
    End Sub
    Private Sub msg26_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg26.MouseDoubleClick
        msg26.Text = ""
    End Sub
    Private Sub msg27_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg27.MouseDoubleClick
        msg27.Text = ""
    End Sub
    Private Sub msg28_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg28.MouseDoubleClick
        msg28.Text = ""
    End Sub
    Private Sub msg29_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg29.MouseDoubleClick
        msg29.Text = ""
    End Sub
    Private Sub msg30_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg30.MouseDoubleClick
        msg30.Text = ""
    End Sub
    Private Sub msg31_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg31.MouseDoubleClick
        msg31.Text = ""
    End Sub
    Private Sub msg32_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg32.MouseDoubleClick
        msg32.Text = ""
    End Sub
    Private Sub msg33_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg33.MouseDoubleClick
        msg33.Text = ""
    End Sub
    Private Sub msg34_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg34.MouseDoubleClick
        msg34.Text = ""
    End Sub
    Private Sub msg35_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg35.MouseDoubleClick
        msg35.Text = ""
    End Sub
    Private Sub msg36_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg36.MouseDoubleClick
        msg36.Text = ""
    End Sub
    Private Sub msg37_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg37.MouseDoubleClick
        msg37.Text = ""
    End Sub
    Private Sub msg38_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg38.MouseDoubleClick
        msg38.Text = ""
    End Sub
    Private Sub msg39_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg39.MouseDoubleClick
        msg39.Text = ""
    End Sub
    Private Sub msg40_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg40.MouseDoubleClick
        msg40.Text = ""
    End Sub
    Private Sub msg41_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg41.MouseDoubleClick
        msg41.Text = ""
    End Sub
    Private Sub msg42_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg42.MouseDoubleClick
        msg42.Text = ""
    End Sub
    Private Sub msg43_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg43.MouseDoubleClick
        msg43.Text = ""
    End Sub
    Private Sub msg44_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg44.MouseDoubleClick
        msg44.Text = ""
    End Sub
    Private Sub msg45_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg45.MouseDoubleClick
        msg45.Text = ""
    End Sub
    Private Sub msg46_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg46.MouseDoubleClick
        msg46.Text = ""
    End Sub
    Private Sub msg47_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg47.MouseDoubleClick
        msg47.Text = ""
    End Sub
    Private Sub msg48_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg48.MouseDoubleClick
        msg48.Text = ""
    End Sub
    Private Sub msg49_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg49.MouseDoubleClick
        msg49.Text = ""
    End Sub
    Private Sub msg50_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg50.MouseDoubleClick
        msg50.Text = ""
    End Sub
    Private Sub msg51_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg51.MouseDoubleClick
        msg51.Text = ""
    End Sub
    Private Sub msg52_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg52.MouseDoubleClick
        msg52.Text = ""
    End Sub
    Private Sub msg53_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg53.MouseDoubleClick
        msg53.Text = ""
    End Sub
    Private Sub msg54_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg54.MouseDoubleClick
        msg54.Text = ""
    End Sub
    Private Sub msg55_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg55.MouseDoubleClick
        msg55.Text = ""
    End Sub
    Private Sub msg56_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg56.MouseDoubleClick
        msg56.Text = ""
    End Sub
    Private Sub msg57_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg57.MouseDoubleClick
        msg57.Text = ""
    End Sub
    Private Sub msg58_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg58.MouseDoubleClick
        msg58.Text = ""
    End Sub
    Private Sub msg59_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg59.MouseDoubleClick
        msg59.Text = ""
    End Sub
    Private Sub msg60_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg60.MouseDoubleClick
        msg60.Text = ""
    End Sub
    Private Sub msg61_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg61.MouseDoubleClick
        msg61.Text = ""
    End Sub
    Private Sub msg62_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg62.MouseDoubleClick
        msg62.Text = ""
    End Sub
    Private Sub msg63_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg63.MouseDoubleClick
        msg63.Text = ""
    End Sub
    Private Sub msg64_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg64.MouseDoubleClick
        msg64.Text = ""
    End Sub
    Private Sub msg65_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg65.MouseDoubleClick
        msg65.Text = ""
    End Sub
    Private Sub msg66_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg66.MouseDoubleClick
        msg66.Text = ""
    End Sub
    Private Sub msg67_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg67.MouseDoubleClick
        msg67.Text = ""
    End Sub
    Private Sub msg68_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg68.MouseDoubleClick
        msg68.Text = ""
    End Sub
    Private Sub msg69_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg69.MouseDoubleClick
        msg69.Text = ""
    End Sub
    Private Sub msg70_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg70.MouseDoubleClick
        msg70.Text = ""
    End Sub
    Private Sub msg71_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg71.MouseDoubleClick
        msg71.Text = ""
    End Sub
    Private Sub msg72_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg72.MouseDoubleClick
        msg72.Text = ""
    End Sub
    Private Sub msg73_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg73.MouseDoubleClick
        msg73.Text = ""
    End Sub
    Private Sub msg74_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg74.MouseDoubleClick
        msg74.Text = ""
    End Sub
    Private Sub msg75_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg75.MouseDoubleClick
        msg75.Text = ""
    End Sub
    Private Sub msg76_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg76.MouseDoubleClick
        msg76.Text = ""
    End Sub
    Private Sub msg77_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg77.MouseDoubleClick
        msg77.Text = ""
    End Sub
    Private Sub msg78_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg78.MouseDoubleClick
        msg78.Text = ""
    End Sub
    Private Sub msg79_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg79.MouseDoubleClick
        msg79.Text = ""
    End Sub
    Private Sub msg80_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg80.MouseDoubleClick
        msg80.Text = ""
    End Sub
    Private Sub msg81_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg81.MouseDoubleClick
        msg81.Text = ""
    End Sub
    Private Sub msg82_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg82.MouseDoubleClick
        msg82.Text = ""
    End Sub
    Private Sub msg83_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg83.MouseDoubleClick
        msg83.Text = ""
    End Sub
    Private Sub msg84_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg84.MouseDoubleClick
        msg84.Text = ""
    End Sub
    Private Sub msg85_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg85.MouseDoubleClick
        msg85.Text = ""
    End Sub
    Private Sub msg86_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg86.MouseDoubleClick
        msg86.Text = ""
    End Sub
    Private Sub msg87_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg87.MouseDoubleClick
        msg87.Text = ""
    End Sub
    Private Sub msg88_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg88.MouseDoubleClick
        msg88.Text = ""
    End Sub
    Private Sub msg89_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg89.MouseDoubleClick
        msg89.Text = ""
    End Sub
    Private Sub msg90_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg90.MouseDoubleClick
        msg90.Text = ""
    End Sub
    Private Sub msg91_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg91.MouseDoubleClick
        msg91.Text = ""
    End Sub
    Private Sub msg92_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg92.MouseDoubleClick
        msg92.Text = ""
    End Sub
    Private Sub msg93_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg93.MouseDoubleClick
        msg93.Text = ""
    End Sub
    Private Sub msg94_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg94.MouseDoubleClick
        msg94.Text = ""
    End Sub
    Private Sub msg95_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg95.MouseDoubleClick
        msg95.Text = ""
    End Sub
    Private Sub msg96_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg96.MouseDoubleClick
        msg96.Text = ""
    End Sub
    Private Sub msg97_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg97.MouseDoubleClick
        msg97.Text = ""
    End Sub
    Private Sub msg98_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg98.MouseDoubleClick
        msg98.Text = ""
    End Sub
    Private Sub msg99_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg99.MouseDoubleClick
        msg99.Text = ""
    End Sub
    Private Sub msg100_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles msg100.MouseDoubleClick
        msg100.Text = ""
    End Sub
    Dim counescritor As Integer = 0
    Dim datodemsg As String = ""
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        baseT = msg1.Text
        filterB()
        Me.tabcontrol.SelectedTab = Me.TabPage1
        If msg2.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg1.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer1.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg1.Text))
                        datodemsg = msg1.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer1.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer1.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg1.Text))
                    datodemsg = msg1.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer1.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer1.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg1.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer2.Enabled = True
                    Timer1.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg1.Text))
                        datodemsg = msg1.Text
                        timerpass.Text = "1"
                        Escritor.Enabled = True
                        Timer1.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer2.Enabled = True
                        Timer1.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg2.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg1.Text))
                    datodemsg = msg1.Text
                    timerpass.Text = "1"
                    Escritor.Enabled = True
                Else
                    Timer2.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg2.BackColor = Color.PaleTurquoise
                Timer1.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        baseT = msg2.Text
        filterB()
        If msg3.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg2.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer2.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg2.Text))
                        datodemsg = msg2.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer2.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer2.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg2.Text))
                    datodemsg = msg2.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer2.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer2.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg2.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer3.Enabled = True
                    Timer2.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg2.Text))
                        datodemsg = msg2.Text
                        timerpass.Text = "2"
                        Escritor.Enabled = True
                        Timer2.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer3.Enabled = True
                        Timer2.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg3.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg2.Text))
                    datodemsg = msg2.Text
                    timerpass.Text = "2"
                    Escritor.Enabled = True
                Else
                    Timer3.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg3.BackColor = Color.PaleTurquoise
                Timer2.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        baseT = msg3.Text
        filterB()
        If msg4.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg3.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer3.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg3.Text))
                        datodemsg = msg3.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer3.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer3.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg3.Text))
                    datodemsg = msg3.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer3.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer3.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg3.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer4.Enabled = True
                    Timer3.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg3.Text))
                        datodemsg = msg3.Text
                        timerpass.Text = "3"
                        Escritor.Enabled = True
                        Timer3.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer4.Enabled = True
                        Timer3.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg4.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg3.Text))
                    datodemsg = msg3.Text
                    timerpass.Text = "3"
                    Escritor.Enabled = True
                Else
                    Timer4.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg4.BackColor = Color.PaleTurquoise
                Timer3.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        baseT = msg4.Text
        filterB()
        If msg5.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg4.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer4.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg4.Text))
                        datodemsg = msg4.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer4.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer4.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg4.Text))
                    datodemsg = msg4.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer4.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer4.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg4.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer5.Enabled = True
                    Timer4.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg4.Text))
                        datodemsg = msg4.Text
                        timerpass.Text = "4"
                        Escritor.Enabled = True
                        Timer4.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer5.Enabled = True
                        Timer4.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg5.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg4.Text))
                    datodemsg = msg4.Text
                    timerpass.Text = "4"
                    Escritor.Enabled = True
                Else
                    Timer5.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg5.BackColor = Color.PaleTurquoise
                Timer4.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        baseT = msg5.Text
        filterB()
        If msg6.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg5.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer5.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg5.Text))
                        datodemsg = msg5.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer5.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer5.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg5.Text))
                    datodemsg = msg5.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer5.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer5.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg5.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer6.Enabled = True
                    Timer5.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg5.Text))
                        datodemsg = msg5.Text
                        timerpass.Text = "5"
                        Escritor.Enabled = True
                        Timer5.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer6.Enabled = True
                        Timer5.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg6.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg5.Text))
                    datodemsg = msg5.Text
                    timerpass.Text = "5"
                    Escritor.Enabled = True
                Else
                    Timer6.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg6.BackColor = Color.PaleTurquoise
                Timer5.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        baseT = msg6.Text
        filterB()
        If msg7.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg6.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer6.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg6.Text))
                        datodemsg = msg6.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer6.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer6.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg6.Text))
                    datodemsg = msg6.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer6.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer6.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg6.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer7.Enabled = True
                    Timer6.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg6.Text))
                        datodemsg = msg6.Text
                        timerpass.Text = "6"
                        Escritor.Enabled = True
                        Timer6.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer7.Enabled = True
                        Timer6.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg7.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg6.Text))
                    datodemsg = msg6.Text
                    timerpass.Text = "6"
                    Escritor.Enabled = True
                Else
                    Timer7.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg7.BackColor = Color.PaleTurquoise
                Timer6.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        baseT = msg7.Text
        filterB()
        If msg8.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg7.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer7.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg7.Text))
                        datodemsg = msg7.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer7.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer7.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg7.Text))
                    datodemsg = msg7.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer7.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer7.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg7.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer8.Enabled = True
                    Timer7.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg7.Text))
                        datodemsg = msg7.Text
                        timerpass.Text = "7"
                        Escritor.Enabled = True
                        Timer7.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer8.Enabled = True
                        Timer7.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg8.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg7.Text))
                    datodemsg = msg7.Text
                    timerpass.Text = "7"
                    Escritor.Enabled = True
                Else
                    Timer8.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg8.BackColor = Color.PaleTurquoise
                Timer7.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        baseT = msg8.Text
        filterB()
        If msg9.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg8.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer8.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg8.Text))
                        datodemsg = msg8.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer8.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer8.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg8.Text))
                    datodemsg = msg8.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer8.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer8.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg8.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer9.Enabled = True
                    Timer8.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg8.Text))
                        datodemsg = msg8.Text
                        timerpass.Text = "8"
                        Escritor.Enabled = True
                        Timer8.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer9.Enabled = True
                        Timer8.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg9.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg8.Text))
                    datodemsg = msg8.Text
                    timerpass.Text = "8"
                    Escritor.Enabled = True
                Else
                    Timer9.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg9.BackColor = Color.PaleTurquoise
                Timer8.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        baseT = msg9.Text
        filterB()
        If msg10.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg9.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer9.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg9.Text))
                        datodemsg = msg9.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer9.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer9.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg9.Text))
                    datodemsg = msg9.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer9.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer9.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg9.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer10.Enabled = True
                    Timer9.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg9.Text))
                        datodemsg = msg9.Text
                        timerpass.Text = "9"
                        Escritor.Enabled = True
                        Timer9.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer10.Enabled = True
                        Timer9.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg10.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg9.Text))
                    datodemsg = msg9.Text
                    timerpass.Text = "9"
                    Escritor.Enabled = True
                Else
                    Timer10.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg10.BackColor = Color.PaleTurquoise
                Timer9.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        baseT = msg10.Text
        filterB()
        If msg11.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg10.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer10.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg10.Text))
                        datodemsg = msg10.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer10.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer10.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg10.Text))
                    datodemsg = msg10.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer10.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer10.Enabled = False
            End If
        Else

            If CheckBox2.Checked = True Then
                If msg10.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer11.Enabled = True
                    Timer10.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg10.Text))
                        datodemsg = msg10.Text
                        timerpass.Text = "10"
                        Escritor.Enabled = True
                        Timer10.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer11.Enabled = True
                        Timer10.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg11.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg10.Text))
                    datodemsg = msg10.Text
                    timerpass.Text = "10"
                    Escritor.Enabled = True
                Else
                    Timer11.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg11.BackColor = Color.PaleTurquoise
                Timer10.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        baseT = msg11.Text
        filterB()
        If msg12.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg11.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer11.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg11.Text))
                        datodemsg = msg11.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer11.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer11.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg11.Text))
                    datodemsg = msg11.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer11.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer11.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg11.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer12.Enabled = True
                    Timer11.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg11.Text))
                        datodemsg = msg11.Text
                        timerpass.Text = "11"
                        Escritor.Enabled = True
                        Timer11.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer12.Enabled = True
                        Timer11.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg12.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg11.Text))
                    datodemsg = msg11.Text
                    timerpass.Text = "11"
                    Escritor.Enabled = True
                Else
                    Timer12.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg12.BackColor = Color.PaleTurquoise
                Timer11.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer12.Tick
        baseT = msg12.Text
        filterB()
        If msg13.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg12.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer12.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg12.Text))
                        datodemsg = msg12.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer12.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer12.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg12.Text))
                    datodemsg = msg12.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer12.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer12.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg12.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer13.Enabled = True
                    Timer12.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg12.Text))
                        datodemsg = msg12.Text
                        timerpass.Text = "12"
                        Escritor.Enabled = True
                        Timer12.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer13.Enabled = True
                        Timer12.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg13.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg12.Text))
                    datodemsg = msg12.Text
                    timerpass.Text = "12"
                    Escritor.Enabled = True
                Else
                    Timer13.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg13.BackColor = Color.PaleTurquoise
                Timer12.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer13_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer13.Tick
        baseT = msg13.Text
        filterB()
        If msg14.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg13.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer13.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg13.Text))
                        datodemsg = msg13.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer13.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer13.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg13.Text))
                    datodemsg = msg13.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer13.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer13.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg13.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer14.Enabled = True
                    Timer13.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg13.Text))
                        datodemsg = msg13.Text
                        timerpass.Text = "13"
                        Escritor.Enabled = True
                        Timer13.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer14.Enabled = True
                        Timer13.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg14.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg13.Text))
                    datodemsg = msg13.Text
                    timerpass.Text = "13"
                    Escritor.Enabled = True
                Else
                    Timer14.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg14.BackColor = Color.PaleTurquoise
                Timer13.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer14_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer14.Tick
        baseT = msg14.Text
        filterB()
        If msg15.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg14.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer14.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg14.Text))
                        datodemsg = msg14.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer14.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer14.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg14.Text))
                    datodemsg = msg14.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer14.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer14.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg14.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer15.Enabled = True
                    Timer14.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg14.Text))
                        datodemsg = msg14.Text
                        timerpass.Text = "14"
                        Escritor.Enabled = True
                        Timer14.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer15.Enabled = True
                        Timer14.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg15.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg14.Text))
                    datodemsg = msg14.Text
                    timerpass.Text = "14"
                    Escritor.Enabled = True
                Else
                    Timer15.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg15.BackColor = Color.PaleTurquoise
                Timer14.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer15_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer15.Tick
        baseT = msg15.Text
        filterB()
        If msg16.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg15.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer15.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg15.Text))
                        datodemsg = msg15.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer15.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer15.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg15.Text))
                    datodemsg = msg15.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer15.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer15.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg15.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer16.Enabled = True
                    Timer15.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg15.Text))
                        datodemsg = msg15.Text
                        timerpass.Text = "15"
                        Escritor.Enabled = True
                        Timer15.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer16.Enabled = True
                        Timer15.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg16.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg15.Text))
                    datodemsg = msg15.Text
                    timerpass.Text = "15"
                    Escritor.Enabled = True
                Else
                    Timer16.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg16.BackColor = Color.PaleTurquoise
                Timer15.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer16_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer16.Tick
        baseT = msg16.Text
        filterB()
        If msg17.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg16.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer16.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg16.Text))
                        datodemsg = msg16.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer16.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer16.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg16.Text))
                    datodemsg = msg16.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer16.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer16.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg16.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer17.Enabled = True
                    Timer16.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg16.Text))
                        datodemsg = msg16.Text
                        timerpass.Text = "16"
                        Escritor.Enabled = True
                        Timer16.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer17.Enabled = True
                        Timer16.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg17.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg16.Text))
                    datodemsg = msg16.Text
                    timerpass.Text = "16"
                    Escritor.Enabled = True
                Else
                    Timer17.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg17.BackColor = Color.PaleTurquoise
                Timer16.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer17_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer17.Tick
        baseT = msg17.Text
        filterB()
        If msg18.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg17.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer17.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg17.Text))
                        datodemsg = msg17.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer17.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer17.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg17.Text))
                    datodemsg = msg17.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer17.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer17.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg17.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer18.Enabled = True
                    Timer17.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg17.Text))
                        datodemsg = msg17.Text
                        timerpass.Text = "17"
                        Escritor.Enabled = True
                        Timer17.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer18.Enabled = True
                        Timer17.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg18.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg17.Text))
                    datodemsg = msg17.Text
                    timerpass.Text = "17"
                    Escritor.Enabled = True
                Else
                    Timer18.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg18.BackColor = Color.PaleTurquoise
                Timer17.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer18_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer18.Tick
        baseT = msg18.Text
        filterB()
        If msg19.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg18.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer18.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg18.Text))
                        datodemsg = msg18.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer18.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer18.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg18.Text))
                    datodemsg = msg18.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer18.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer18.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg18.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer19.Enabled = True
                    Timer18.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg18.Text))
                        datodemsg = msg18.Text
                        timerpass.Text = "18"
                        Escritor.Enabled = True
                        Timer18.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer19.Enabled = True
                        Timer18.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg19.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg18.Text))
                    datodemsg = msg18.Text
                    timerpass.Text = "18"
                    Escritor.Enabled = True
                Else
                    Timer19.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg19.BackColor = Color.PaleTurquoise
                Timer18.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer19_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer19.Tick
        baseT = msg19.Text
        filterB()
        If msg20.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg19.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer19.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg19.Text))
                        datodemsg = msg19.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer19.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer19.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg19.Text))
                    datodemsg = msg19.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer19.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer19.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg19.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer20.Enabled = True
                    Timer19.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg19.Text))
                        datodemsg = msg19.Text
                        timerpass.Text = "19"
                        Escritor.Enabled = True
                        Timer19.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer20.Enabled = True
                        Timer19.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg20.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg19.Text))
                    datodemsg = msg19.Text
                    timerpass.Text = "19"
                    Escritor.Enabled = True
                Else
                    Timer20.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg20.BackColor = Color.PaleTurquoise
                Timer19.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer20_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer20.Tick
        baseT = msg20.Text
        filterB()
        If msg21.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg20.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer20.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg20.Text))
                        datodemsg = msg20.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer20.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer20.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg20.Text))
                    datodemsg = msg20.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer20.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer20.Enabled = False
            End If
        Else
            Me.tabcontrol.SelectedTab = Me.TabPage2
            If CheckBox2.Checked = True Then
                If msg20.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer21.Enabled = True
                    Timer20.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg20.Text))
                        datodemsg = msg20.Text
                        timerpass.Text = "20"
                        Escritor.Enabled = True
                        Timer20.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer21.Enabled = True
                        Timer20.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg21.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg20.Text))
                    datodemsg = msg20.Text
                    timerpass.Text = "20"
                    Escritor.Enabled = True
                Else
                    Timer21.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg21.BackColor = Color.PaleTurquoise
                Timer20.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer21_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer21.Tick
        baseT = msg21.Text
        filterB()
        If msg22.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg21.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer21.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg21.Text))
                        datodemsg = msg21.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer21.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer21.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg21.Text))
                    datodemsg = msg21.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer21.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer21.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg21.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer22.Enabled = True
                    Timer21.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg21.Text))
                        datodemsg = msg21.Text
                        timerpass.Text = "21"
                        Escritor.Enabled = True
                        Timer21.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer22.Enabled = True
                        Timer21.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg22.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg21.Text))
                    datodemsg = msg21.Text
                    timerpass.Text = "21"
                    Escritor.Enabled = True
                Else
                    Timer22.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg22.BackColor = Color.PaleTurquoise
                Timer21.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer22_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer22.Tick
        baseT = msg22.Text
        filterB()
        If msg23.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg22.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer22.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg22.Text))
                        datodemsg = msg22.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer22.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer22.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg22.Text))
                    datodemsg = msg22.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer22.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer22.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg22.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer23.Enabled = True
                    Timer22.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg22.Text))
                        datodemsg = msg22.Text
                        timerpass.Text = "22"
                        Escritor.Enabled = True
                        Timer22.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer23.Enabled = True
                        Timer22.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg23.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg22.Text))
                    datodemsg = msg22.Text
                    timerpass.Text = "22"
                    Escritor.Enabled = True
                Else
                    Timer23.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg23.BackColor = Color.PaleTurquoise
                Timer22.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer23_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer23.Tick
        baseT = msg23.Text
        filterB()
        If msg24.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg23.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer23.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg23.Text))
                        datodemsg = msg23.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer23.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer23.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg23.Text))
                    datodemsg = msg23.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer23.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer23.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg23.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer24.Enabled = True
                    Timer23.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg23.Text))
                        datodemsg = msg23.Text
                        timerpass.Text = "23"
                        Escritor.Enabled = True
                        Timer23.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer24.Enabled = True
                        Timer23.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg24.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg23.Text))
                    datodemsg = msg23.Text
                    timerpass.Text = "23"
                    Escritor.Enabled = True
                Else
                    Timer24.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg24.BackColor = Color.PaleTurquoise
                Timer23.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer24_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer24.Tick
        baseT = msg24.Text
        filterB()
        If msg25.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg24.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer24.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg24.Text))
                        datodemsg = msg24.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer24.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer24.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg24.Text))
                    datodemsg = msg24.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer24.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer24.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg24.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer25.Enabled = True
                    Timer24.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg24.Text))
                        datodemsg = msg24.Text
                        timerpass.Text = "24"
                        Escritor.Enabled = True
                        Timer24.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer25.Enabled = True
                        Timer24.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg25.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg24.Text))
                    datodemsg = msg24.Text
                    timerpass.Text = "24"
                    Escritor.Enabled = True
                Else
                    Timer25.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg25.BackColor = Color.PaleTurquoise
                Timer24.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer25_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer25.Tick
        baseT = msg25.Text
        filterB()
        If msg26.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg25.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer25.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg25.Text))
                        datodemsg = msg25.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer25.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer25.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg25.Text))
                    datodemsg = msg25.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer25.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer25.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg25.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer26.Enabled = True
                    Timer25.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg25.Text))
                        datodemsg = msg25.Text
                        timerpass.Text = "25"
                        Escritor.Enabled = True
                        Timer25.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer26.Enabled = True
                        Timer25.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg26.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg25.Text))
                    datodemsg = msg25.Text
                    timerpass.Text = "25"
                    Escritor.Enabled = True
                Else
                    Timer26.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg26.BackColor = Color.PaleTurquoise
                Timer25.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer26_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer26.Tick
        baseT = msg26.Text
        filterB()
        If msg27.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg26.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer26.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg26.Text))
                        datodemsg = msg26.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer26.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer26.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg26.Text))
                    datodemsg = msg26.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer26.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer26.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg26.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer27.Enabled = True
                    Timer26.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg26.Text))
                        datodemsg = msg26.Text
                        timerpass.Text = "26"
                        Escritor.Enabled = True
                        Timer26.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer27.Enabled = True
                        Timer26.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg27.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg26.Text))
                    datodemsg = msg26.Text
                    timerpass.Text = "26"
                    Escritor.Enabled = True
                Else
                    Timer27.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg27.BackColor = Color.PaleTurquoise
                Timer26.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer27_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer27.Tick
        baseT = msg27.Text
        filterB()
        If msg28.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg27.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer27.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg27.Text))
                        datodemsg = msg27.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer27.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer27.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg27.Text))
                    datodemsg = msg27.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer27.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer27.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg27.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer28.Enabled = True
                    Timer27.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg27.Text))
                        datodemsg = msg27.Text
                        timerpass.Text = "27"
                        Escritor.Enabled = True
                        Timer27.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer28.Enabled = True
                        Timer27.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg28.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg27.Text))
                    datodemsg = msg27.Text
                    timerpass.Text = "27"
                    Escritor.Enabled = True
                Else
                    Timer28.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg28.BackColor = Color.PaleTurquoise
                Timer27.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer28_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer28.Tick
        baseT = msg28.Text
        filterB()
        If msg29.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg28.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer28.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg28.Text))
                        datodemsg = msg28.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer28.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer28.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg28.Text))
                    datodemsg = msg28.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer28.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer28.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg28.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer29.Enabled = True
                    Timer28.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg28.Text))
                        datodemsg = msg28.Text
                        timerpass.Text = "28"
                        Escritor.Enabled = True
                        Timer28.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer29.Enabled = True
                        Timer28.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg29.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg28.Text))
                    datodemsg = msg28.Text
                    timerpass.Text = "28"
                    Escritor.Enabled = True
                Else
                    Timer29.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg29.BackColor = Color.PaleTurquoise
                Timer28.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer29_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer29.Tick
        baseT = msg29.Text
        filterB()
        If msg30.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg29.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer29.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg29.Text))
                        datodemsg = msg29.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer29.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer29.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg29.Text))
                    datodemsg = msg29.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer29.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer29.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg29.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer30.Enabled = True
                    Timer29.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg29.Text))
                        datodemsg = msg29.Text
                        timerpass.Text = "29"
                        Escritor.Enabled = True
                        Timer29.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer30.Enabled = True
                        Timer29.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg30.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg29.Text))
                    datodemsg = msg29.Text
                    timerpass.Text = "29"
                    Escritor.Enabled = True
                Else
                    Timer30.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg30.BackColor = Color.PaleTurquoise
                Timer29.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer30_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer30.Tick
        baseT = msg30.Text
        filterB()
        If msg31.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg30.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer30.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg30.Text))
                        datodemsg = msg30.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer30.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer30.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg30.Text))
                    datodemsg = msg30.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer30.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer30.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg30.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer31.Enabled = True
                    Timer30.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg30.Text))
                        datodemsg = msg30.Text
                        timerpass.Text = "30"
                        Escritor.Enabled = True
                        Timer30.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer31.Enabled = True
                        Timer30.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg31.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg30.Text))
                    datodemsg = msg30.Text
                    timerpass.Text = "30"
                    Escritor.Enabled = True
                Else
                    Timer31.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg31.BackColor = Color.PaleTurquoise
                Timer30.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer31_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer31.Tick
        baseT = msg31.Text
        filterB()
        If msg32.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg31.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer31.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg31.Text))
                        datodemsg = msg31.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer31.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer31.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg31.Text))
                    datodemsg = msg31.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer31.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer31.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg31.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer32.Enabled = True
                    Timer31.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg31.Text))
                        datodemsg = msg31.Text
                        timerpass.Text = "31"
                        Escritor.Enabled = True
                        Timer31.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer32.Enabled = True
                        Timer31.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg32.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg31.Text))
                    datodemsg = msg31.Text
                    timerpass.Text = "31"
                    Escritor.Enabled = True
                Else
                    Timer32.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg32.BackColor = Color.PaleTurquoise
                Timer31.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer32_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer32.Tick
        baseT = msg32.Text
        filterB()
        If msg33.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg32.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer32.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg32.Text))
                        datodemsg = msg32.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer32.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer32.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg32.Text))
                    datodemsg = msg32.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer32.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer32.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg32.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer33.Enabled = True
                    Timer32.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg32.Text))
                        datodemsg = msg32.Text
                        timerpass.Text = "32"
                        Escritor.Enabled = True
                        Timer32.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer33.Enabled = True
                        Timer32.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg33.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg32.Text))
                    datodemsg = msg32.Text
                    timerpass.Text = "32"
                    Escritor.Enabled = True
                Else
                    Timer33.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg33.BackColor = Color.PaleTurquoise
                Timer32.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer33_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer33.Tick
        baseT = msg33.Text
        filterB()
        If msg34.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg33.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer33.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg33.Text))
                        datodemsg = msg33.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer33.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer33.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg33.Text))
                    datodemsg = msg33.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer33.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer33.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg33.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer34.Enabled = True
                    Timer33.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg33.Text))
                        datodemsg = msg33.Text
                        timerpass.Text = "33"
                        Escritor.Enabled = True
                        Timer33.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer34.Enabled = True
                        Timer33.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg34.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg33.Text))
                    datodemsg = msg33.Text
                    timerpass.Text = "33"
                    Escritor.Enabled = True
                Else
                    Timer34.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg34.BackColor = Color.PaleTurquoise
                Timer33.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer34_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer34.Tick
        baseT = msg34.Text
        filterB()
        If msg35.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg34.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer34.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg34.Text))
                        datodemsg = msg34.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer34.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer34.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg34.Text))
                    datodemsg = msg34.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer34.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer34.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg34.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer35.Enabled = True
                    Timer34.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg34.Text))
                        datodemsg = msg34.Text
                        timerpass.Text = "34"
                        Escritor.Enabled = True
                        Timer34.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer35.Enabled = True
                        Timer34.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg35.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg34.Text))
                    datodemsg = msg34.Text
                    timerpass.Text = "34"
                    Escritor.Enabled = True
                Else
                    Timer35.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg35.BackColor = Color.PaleTurquoise
                Timer34.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer35_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer35.Tick
        baseT = msg35.Text
        filterB()
        If msg36.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg35.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer35.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg35.Text))
                        datodemsg = msg35.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer35.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer35.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg35.Text))
                    datodemsg = msg35.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer35.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer35.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg35.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer36.Enabled = True
                    Timer35.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg35.Text))
                        datodemsg = msg35.Text
                        timerpass.Text = "35"
                        Escritor.Enabled = True
                        Timer35.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer36.Enabled = True
                        Timer35.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg36.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg35.Text))
                    datodemsg = msg35.Text
                    timerpass.Text = "35"
                    Escritor.Enabled = True
                Else
                    Timer36.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg36.BackColor = Color.PaleTurquoise
                Timer35.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer36_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer36.Tick
        baseT = msg36.Text
        filterB()
        If msg37.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg36.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer36.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg36.Text))
                        datodemsg = msg36.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer36.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer36.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg36.Text))
                    datodemsg = msg36.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer36.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer36.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg36.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer37.Enabled = True
                    Timer36.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg36.Text))
                        datodemsg = msg36.Text
                        timerpass.Text = "36"
                        Escritor.Enabled = True
                        Timer36.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer37.Enabled = True
                        Timer36.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg37.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg36.Text))
                    datodemsg = msg36.Text
                    timerpass.Text = "36"
                    Escritor.Enabled = True
                Else
                    Timer37.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg37.BackColor = Color.PaleTurquoise
                Timer36.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer37_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer37.Tick
        baseT = msg37.Text
        filterB()
        If msg38.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg37.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer37.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg37.Text))
                        datodemsg = msg37.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer37.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer37.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg37.Text))
                    datodemsg = msg37.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer37.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer37.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg37.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer38.Enabled = True
                    Timer37.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg37.Text))
                        datodemsg = msg37.Text
                        timerpass.Text = "37"
                        Escritor.Enabled = True
                        Timer37.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer38.Enabled = True
                        Timer37.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg38.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg37.Text))
                    datodemsg = msg37.Text
                    timerpass.Text = "37"
                    Escritor.Enabled = True
                Else
                    Timer38.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg38.BackColor = Color.PaleTurquoise
                Timer37.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer38_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer38.Tick
        baseT = msg38.Text
        filterB()
        If msg39.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg38.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer38.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg38.Text))
                        datodemsg = msg38.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer38.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer38.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg38.Text))
                    datodemsg = msg38.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer38.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer38.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg38.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer39.Enabled = True
                    Timer38.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg38.Text))
                        datodemsg = msg38.Text
                        timerpass.Text = "38"
                        Escritor.Enabled = True
                        Timer38.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer39.Enabled = True
                        Timer38.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg39.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg38.Text))
                    datodemsg = msg38.Text
                    timerpass.Text = "38"
                    Escritor.Enabled = True
                Else
                    Timer39.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg39.BackColor = Color.PaleTurquoise
                Timer38.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer39_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer39.Tick
        baseT = msg39.Text
        filterB()
        If msg40.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg39.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer39.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg39.Text))
                        datodemsg = msg39.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer39.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer39.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg39.Text))
                    datodemsg = msg39.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer39.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer39.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg39.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer40.Enabled = True
                    Timer39.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg39.Text))
                        datodemsg = msg39.Text
                        timerpass.Text = "39"
                        Escritor.Enabled = True
                        Timer39.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer40.Enabled = True
                        Timer39.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg40.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg39.Text))
                    datodemsg = msg39.Text
                    timerpass.Text = "39"
                    Escritor.Enabled = True
                Else
                    Timer40.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg40.BackColor = Color.PaleTurquoise
                Timer39.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer40_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer40.Tick
        baseT = msg40.Text
        filterB()
        If msg41.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg40.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer40.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg40.Text))
                        datodemsg = msg40.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer40.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer40.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg40.Text))
                    datodemsg = msg40.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer40.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer40.Enabled = False
            End If
        Else
            Me.tabcontrol.SelectedTab = Me.TabPage3
            If CheckBox2.Checked = True Then
                If msg40.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer41.Enabled = True
                    Timer40.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg40.Text))
                        datodemsg = msg40.Text
                        timerpass.Text = "40"
                        Escritor.Enabled = True
                        Timer40.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer41.Enabled = True
                        Timer40.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg41.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg40.Text))
                    datodemsg = msg40.Text
                    timerpass.Text = "40"
                    Escritor.Enabled = True
                Else
                    Timer41.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg41.BackColor = Color.PaleTurquoise
                Timer40.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer41_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer41.Tick
        baseT = msg41.Text
        filterB()
        If msg42.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg41.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer41.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg41.Text))
                        datodemsg = msg41.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer41.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer41.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg41.Text))
                    datodemsg = msg41.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer41.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer41.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg41.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer42.Enabled = True
                    Timer41.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg41.Text))
                        datodemsg = msg41.Text
                        timerpass.Text = "41"
                        Escritor.Enabled = True
                        Timer41.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer42.Enabled = True
                        Timer41.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg42.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg41.Text))
                    datodemsg = msg41.Text
                    timerpass.Text = "41"
                    Escritor.Enabled = True
                Else
                    Timer42.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg42.BackColor = Color.PaleTurquoise
                Timer41.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer42_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer42.Tick
        baseT = msg42.Text
        filterB()
        If msg43.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg42.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer42.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg42.Text))
                        datodemsg = msg42.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer42.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer42.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg42.Text))
                    datodemsg = msg42.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer42.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer42.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg42.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer43.Enabled = True
                    Timer42.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg42.Text))
                        datodemsg = msg42.Text
                        timerpass.Text = "42"
                        Escritor.Enabled = True
                        Timer42.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer43.Enabled = True
                        Timer42.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg43.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg42.Text))
                    datodemsg = msg42.Text
                    timerpass.Text = "42"
                    Escritor.Enabled = True
                Else
                    Timer43.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg43.BackColor = Color.PaleTurquoise
                Timer42.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer43_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer43.Tick
        baseT = msg43.Text
        filterB()
        If msg44.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg43.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer43.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg43.Text))
                        datodemsg = msg43.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer43.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer43.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg43.Text))
                    datodemsg = msg43.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer43.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer43.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg43.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer44.Enabled = True
                    Timer43.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg43.Text))
                        datodemsg = msg43.Text
                        timerpass.Text = "43"
                        Escritor.Enabled = True
                        Timer43.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer44.Enabled = True
                        Timer43.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg44.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg43.Text))
                    datodemsg = msg43.Text
                    timerpass.Text = "43"
                    Escritor.Enabled = True
                Else
                    Timer44.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg44.BackColor = Color.PaleTurquoise
                Timer43.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer44_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer44.Tick
        baseT = msg44.Text
        filterB()
        If msg45.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg44.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer44.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg44.Text))
                        datodemsg = msg44.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer44.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer44.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg44.Text))
                    datodemsg = msg44.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer44.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer44.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg44.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer45.Enabled = True
                    Timer44.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg44.Text))
                        datodemsg = msg44.Text
                        timerpass.Text = "44"
                        Escritor.Enabled = True
                        Timer44.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer45.Enabled = True
                        Timer44.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg45.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg44.Text))
                    datodemsg = msg44.Text
                    timerpass.Text = "44"
                    Escritor.Enabled = True
                Else
                    Timer45.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg45.BackColor = Color.PaleTurquoise
                Timer44.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer45_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer45.Tick
        baseT = msg45.Text
        filterB()
        If msg46.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg45.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer45.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg45.Text))
                        datodemsg = msg45.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer45.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer45.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg45.Text))
                    datodemsg = msg45.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer45.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer45.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg45.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer46.Enabled = True
                    Timer45.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg45.Text))
                        datodemsg = msg45.Text
                        timerpass.Text = "45"
                        Escritor.Enabled = True
                        Timer45.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer46.Enabled = True
                        Timer45.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg46.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg45.Text))
                    datodemsg = msg45.Text
                    timerpass.Text = "45"
                    Escritor.Enabled = True
                Else
                    Timer46.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg46.BackColor = Color.PaleTurquoise
                Timer45.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer46_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer46.Tick
        baseT = msg46.Text
        filterB()
        If msg47.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg46.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer46.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg46.Text))
                        datodemsg = msg46.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer46.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer46.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg46.Text))
                    datodemsg = msg46.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer46.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer46.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg46.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer47.Enabled = True
                    Timer46.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg46.Text))
                        datodemsg = msg46.Text
                        timerpass.Text = "46"
                        Escritor.Enabled = True
                        Timer46.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer47.Enabled = True
                        Timer46.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg47.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg46.Text))
                    datodemsg = msg46.Text
                    timerpass.Text = "46"
                    Escritor.Enabled = True
                Else
                    Timer47.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg47.BackColor = Color.PaleTurquoise
                Timer46.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer47_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer47.Tick
        baseT = msg47.Text
        filterB()
        If msg48.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg47.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer47.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg47.Text))
                        datodemsg = msg47.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer47.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer47.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg47.Text))
                    datodemsg = msg47.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer47.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer47.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg47.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer48.Enabled = True
                    Timer47.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg47.Text))
                        datodemsg = msg47.Text
                        timerpass.Text = "47"
                        Escritor.Enabled = True
                        Timer47.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer48.Enabled = True
                        Timer47.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg48.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg47.Text))
                    datodemsg = msg47.Text
                    timerpass.Text = "47"
                    Escritor.Enabled = True
                Else
                    Timer48.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg48.BackColor = Color.PaleTurquoise
                Timer47.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer48_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer48.Tick
        baseT = msg48.Text
        filterB()
        If msg49.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg48.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer48.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg48.Text))
                        datodemsg = msg48.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer48.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer48.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg48.Text))
                    datodemsg = msg48.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer48.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer48.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg48.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer49.Enabled = True
                    Timer48.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg48.Text))
                        datodemsg = msg48.Text
                        timerpass.Text = "48"
                        Escritor.Enabled = True
                        Timer48.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer49.Enabled = True
                        Timer48.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg49.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg48.Text))
                    datodemsg = msg48.Text
                    timerpass.Text = "48"
                    Escritor.Enabled = True
                Else
                    Timer49.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg49.BackColor = Color.PaleTurquoise
                Timer48.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer49_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer49.Tick
        baseT = msg49.Text
        filterB()
        If msg50.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg49.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer49.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg49.Text))
                        datodemsg = msg49.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer49.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer49.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg49.Text))
                    datodemsg = msg49.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer49.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer49.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg49.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer50.Enabled = True
                    Timer49.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg49.Text))
                        datodemsg = msg49.Text
                        timerpass.Text = "49"
                        Escritor.Enabled = True
                        Timer49.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer50.Enabled = True
                        Timer49.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg50.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg49.Text))
                    datodemsg = msg49.Text
                    timerpass.Text = "49"
                    Escritor.Enabled = True
                Else
                    Timer50.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg50.BackColor = Color.PaleTurquoise
                Timer49.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer50_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer50.Tick
        baseT = msg50.Text
        filterB()
        If msg51.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg50.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer50.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg50.Text))
                        datodemsg = msg50.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer50.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer50.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg50.Text))
                    datodemsg = msg50.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer50.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer50.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg50.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer51.Enabled = True
                    Timer50.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg50.Text))
                        datodemsg = msg50.Text
                        timerpass.Text = "50"
                        Escritor.Enabled = True
                        Timer50.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer51.Enabled = True
                        Timer50.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg51.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg50.Text))
                    datodemsg = msg50.Text
                    timerpass.Text = "50"
                    Escritor.Enabled = True
                Else
                    Timer51.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg51.BackColor = Color.PaleTurquoise
                Timer50.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer51_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer51.Tick
        baseT = msg51.Text
        filterB()
        If msg52.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg51.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer51.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg51.Text))
                        datodemsg = msg51.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer51.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer51.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg51.Text))
                    datodemsg = msg51.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer51.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer51.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg51.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer52.Enabled = True
                    Timer51.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg51.Text))
                        datodemsg = msg51.Text
                        timerpass.Text = "51"
                        Escritor.Enabled = True
                        Timer51.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer52.Enabled = True
                        Timer51.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg52.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg51.Text))
                    datodemsg = msg51.Text
                    timerpass.Text = "51"
                    Escritor.Enabled = True
                Else
                    Timer52.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg52.BackColor = Color.PaleTurquoise
                Timer51.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer52_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer52.Tick
        baseT = msg52.Text
        filterB()
        If msg53.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg52.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer52.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg52.Text))
                        datodemsg = msg52.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer52.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer52.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg52.Text))
                    datodemsg = msg52.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer52.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer52.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg52.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer53.Enabled = True
                    Timer52.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg52.Text))
                        datodemsg = msg52.Text
                        timerpass.Text = "52"
                        Escritor.Enabled = True
                        Timer52.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer53.Enabled = True
                        Timer52.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg53.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg52.Text))
                    datodemsg = msg52.Text
                    timerpass.Text = "52"
                    Escritor.Enabled = True
                Else
                    Timer53.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg53.BackColor = Color.PaleTurquoise
                Timer52.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer53_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer53.Tick
        baseT = msg53.Text
        filterB()
        If msg54.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg53.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer53.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg53.Text))
                        datodemsg = msg53.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer53.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer53.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg53.Text))
                    datodemsg = msg53.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer53.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer53.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg53.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer54.Enabled = True
                    Timer53.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg53.Text))
                        datodemsg = msg53.Text
                        timerpass.Text = "53"
                        Escritor.Enabled = True
                        Timer53.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer54.Enabled = True
                        Timer53.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg54.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg53.Text))
                    datodemsg = msg53.Text
                    timerpass.Text = "53"
                    Escritor.Enabled = True
                Else
                    Timer54.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg54.BackColor = Color.PaleTurquoise
                Timer53.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer54_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer54.Tick
        baseT = msg54.Text
        filterB()
        If msg55.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg54.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer54.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg54.Text))
                        datodemsg = msg54.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer54.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer54.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg54.Text))
                    datodemsg = msg54.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer54.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer54.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg54.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer55.Enabled = True
                    Timer54.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg54.Text))
                        datodemsg = msg54.Text
                        timerpass.Text = "54"
                        Escritor.Enabled = True
                        Timer54.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer55.Enabled = True
                        Timer54.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg55.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg54.Text))
                    datodemsg = msg54.Text
                    timerpass.Text = "54"
                    Escritor.Enabled = True
                Else
                    Timer55.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg55.BackColor = Color.PaleTurquoise
                Timer54.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer55_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer55.Tick
        baseT = msg55.Text
        filterB()
        If msg56.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg55.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer55.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg55.Text))
                        datodemsg = msg55.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer55.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer55.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg55.Text))
                    datodemsg = msg55.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer55.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer55.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg55.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer56.Enabled = True
                    Timer55.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg55.Text))
                        datodemsg = msg55.Text
                        timerpass.Text = "55"
                        Escritor.Enabled = True
                        Timer55.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer56.Enabled = True
                        Timer55.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg56.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg55.Text))
                    datodemsg = msg55.Text
                    timerpass.Text = "55"
                    Escritor.Enabled = True
                Else
                    Timer56.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg56.BackColor = Color.PaleTurquoise
                Timer55.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer56_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer56.Tick
        baseT = msg56.Text
        filterB()
        If msg57.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg56.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer56.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg56.Text))
                        datodemsg = msg56.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer56.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer56.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg56.Text))
                    datodemsg = msg56.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer56.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer56.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg56.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer57.Enabled = True
                    Timer56.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg56.Text))
                        datodemsg = msg56.Text
                        timerpass.Text = "56"
                        Escritor.Enabled = True
                        Timer56.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer57.Enabled = True
                        Timer56.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg57.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg56.Text))
                    datodemsg = msg56.Text
                    timerpass.Text = "56"
                    Escritor.Enabled = True
                Else
                    Timer57.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg57.BackColor = Color.PaleTurquoise
                Timer56.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer57_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer57.Tick
        baseT = msg57.Text
        filterB()
        If msg58.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg57.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer57.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg57.Text))
                        datodemsg = msg57.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer57.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer57.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg57.Text))
                    datodemsg = msg57.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer57.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer57.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg57.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer58.Enabled = True
                    Timer57.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg57.Text))
                        datodemsg = msg57.Text
                        timerpass.Text = "57"
                        Escritor.Enabled = True
                        Timer57.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer58.Enabled = True
                        Timer57.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg58.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg57.Text))
                    datodemsg = msg57.Text
                    timerpass.Text = "57"
                    Escritor.Enabled = True
                Else
                    Timer58.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg58.BackColor = Color.PaleTurquoise
                Timer57.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer58_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer58.Tick
        baseT = msg58.Text
        filterB()
        If msg59.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg58.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer58.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg58.Text))
                        datodemsg = msg58.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer58.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer58.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg58.Text))
                    datodemsg = msg58.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer58.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer58.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg58.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer59.Enabled = True
                    Timer58.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg58.Text))
                        datodemsg = msg58.Text
                        timerpass.Text = "58"
                        Escritor.Enabled = True
                        Timer58.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer59.Enabled = True
                        Timer58.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg59.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg58.Text))
                    datodemsg = msg58.Text
                    timerpass.Text = "58"
                    Escritor.Enabled = True
                Else
                    Timer59.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg59.BackColor = Color.PaleTurquoise
                Timer58.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer59_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer59.Tick
        baseT = msg59.Text
        filterB()
        If msg60.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg59.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer59.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg59.Text))
                        datodemsg = msg59.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer59.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer59.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg59.Text))
                    datodemsg = msg59.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer59.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer59.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg59.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer60.Enabled = True
                    Timer59.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg59.Text))
                        datodemsg = msg59.Text
                        timerpass.Text = "59"
                        Escritor.Enabled = True
                        Timer59.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer60.Enabled = True
                        Timer59.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg60.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg59.Text))
                    datodemsg = msg59.Text
                    timerpass.Text = "59"
                    Escritor.Enabled = True
                Else
                    Timer60.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg60.BackColor = Color.PaleTurquoise
                Timer59.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer60_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer60.Tick
        baseT = msg60.Text
        filterB()
        If msg61.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg60.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer60.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg60.Text))
                        datodemsg = msg60.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer60.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer60.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg60.Text))
                    datodemsg = msg60.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer60.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer60.Enabled = False
            End If
        Else
            Me.tabcontrol.SelectedTab = Me.TabPage4
            If CheckBox2.Checked = True Then
                If msg60.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer61.Enabled = True
                    Timer60.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg60.Text))
                        datodemsg = msg60.Text
                        timerpass.Text = "60"
                        Escritor.Enabled = True
                        Timer60.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer61.Enabled = True
                        Timer60.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg61.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg60.Text))
                    datodemsg = msg60.Text
                    timerpass.Text = "60"
                    Escritor.Enabled = True
                Else
                    Timer61.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg61.BackColor = Color.PaleTurquoise
                Timer60.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer61_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer61.Tick
        baseT = msg61.Text
        filterB()
        If msg62.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg61.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer61.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg61.Text))
                        datodemsg = msg61.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer61.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer61.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg61.Text))
                    datodemsg = msg61.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer61.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer61.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg61.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer62.Enabled = True
                    Timer61.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg61.Text))
                        datodemsg = msg61.Text
                        timerpass.Text = "61"
                        Escritor.Enabled = True
                        Timer61.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer62.Enabled = True
                        Timer61.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg62.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg61.Text))
                    datodemsg = msg61.Text
                    timerpass.Text = "61"
                    Escritor.Enabled = True
                Else
                    Timer62.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg62.BackColor = Color.PaleTurquoise
                Timer61.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer62_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer62.Tick
        baseT = msg62.Text
        filterB()
        If msg63.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg62.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer62.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg62.Text))
                        datodemsg = msg62.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer62.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer62.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg62.Text))
                    datodemsg = msg62.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer62.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer62.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg62.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer63.Enabled = True
                    Timer62.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg62.Text))
                        datodemsg = msg62.Text
                        timerpass.Text = "62"
                        Escritor.Enabled = True
                        Timer62.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer63.Enabled = True
                        Timer62.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg63.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg62.Text))
                    datodemsg = msg62.Text
                    timerpass.Text = "62"
                    Escritor.Enabled = True
                Else
                    Timer63.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg63.BackColor = Color.PaleTurquoise
                Timer62.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer63_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer63.Tick
        baseT = msg63.Text
        filterB()
        If msg64.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg63.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer63.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg63.Text))
                        datodemsg = msg63.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer63.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer63.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg63.Text))
                    datodemsg = msg63.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer63.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer63.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg63.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer64.Enabled = True
                    Timer63.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg63.Text))
                        datodemsg = msg63.Text
                        timerpass.Text = "63"
                        Escritor.Enabled = True
                        Timer63.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer64.Enabled = True
                        Timer63.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg64.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg63.Text))
                    datodemsg = msg63.Text
                    timerpass.Text = "63"
                    Escritor.Enabled = True
                Else
                    Timer64.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg64.BackColor = Color.PaleTurquoise
                Timer63.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer64_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer64.Tick
        baseT = msg64.Text
        filterB()
        If msg65.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg64.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer64.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg64.Text))
                        datodemsg = msg64.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer64.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer64.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg64.Text))
                    datodemsg = msg64.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer64.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer64.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg64.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer65.Enabled = True
                    Timer64.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg64.Text))
                        datodemsg = msg64.Text
                        timerpass.Text = "64"
                        Escritor.Enabled = True
                        Timer64.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer65.Enabled = True
                        Timer64.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg65.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg64.Text))
                    datodemsg = msg64.Text
                    timerpass.Text = "64"
                    Escritor.Enabled = True
                Else
                    Timer65.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg65.BackColor = Color.PaleTurquoise
                Timer64.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer65_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer65.Tick
        baseT = msg65.Text
        filterB()
        If msg66.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg65.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer65.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg65.Text))
                        datodemsg = msg65.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer65.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer65.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg65.Text))
                    datodemsg = msg65.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer65.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer65.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg65.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer66.Enabled = True
                    Timer65.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg65.Text))
                        datodemsg = msg65.Text
                        timerpass.Text = "65"
                        Escritor.Enabled = True
                        Timer65.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer66.Enabled = True
                        Timer65.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg66.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg65.Text))
                    datodemsg = msg65.Text
                    timerpass.Text = "65"
                    Escritor.Enabled = True
                Else
                    Timer66.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg66.BackColor = Color.PaleTurquoise
                Timer65.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer66_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer66.Tick
        baseT = msg66.Text
        filterB()
        If msg67.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg66.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer66.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg66.Text))
                        datodemsg = msg66.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer66.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer66.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg66.Text))
                    datodemsg = msg66.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer66.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer66.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg66.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer67.Enabled = True
                    Timer66.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg66.Text))
                        datodemsg = msg66.Text
                        timerpass.Text = "66"
                        Escritor.Enabled = True
                        Timer66.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer67.Enabled = True
                        Timer66.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg67.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg66.Text))
                    datodemsg = msg66.Text
                    timerpass.Text = "66"
                    Escritor.Enabled = True
                Else
                    Timer67.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg67.BackColor = Color.PaleTurquoise
                Timer66.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer67_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer67.Tick
        baseT = msg67.Text
        filterB()
        If msg68.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg67.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer67.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg67.Text))
                        datodemsg = msg67.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer67.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer67.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg67.Text))
                    datodemsg = msg67.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer67.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer67.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg67.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer68.Enabled = True
                    Timer67.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg67.Text))
                        datodemsg = msg67.Text
                        timerpass.Text = "67"
                        Escritor.Enabled = True
                        Timer67.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer68.Enabled = True
                        Timer67.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg68.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg67.Text))
                    datodemsg = msg67.Text
                    timerpass.Text = "67"
                    Escritor.Enabled = True
                Else
                    Timer68.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg68.BackColor = Color.PaleTurquoise
                Timer67.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer68_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer68.Tick
        baseT = msg68.Text
        filterB()
        If msg69.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg68.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer68.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg68.Text))
                        datodemsg = msg68.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer68.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer68.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg68.Text))
                    datodemsg = msg68.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer68.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer68.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg68.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer69.Enabled = True
                    Timer68.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg68.Text))
                        datodemsg = msg68.Text
                        timerpass.Text = "68"
                        Escritor.Enabled = True
                        Timer68.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer69.Enabled = True
                        Timer68.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg69.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg68.Text))
                    datodemsg = msg68.Text
                    timerpass.Text = "68"
                    Escritor.Enabled = True
                Else
                    Timer69.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg69.BackColor = Color.PaleTurquoise
                Timer68.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer69_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer69.Tick
        baseT = msg69.Text
        filterB()
        If msg70.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg69.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer69.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg69.Text))
                        datodemsg = msg69.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer69.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer69.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg69.Text))
                    datodemsg = msg69.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer69.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer69.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg69.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer70.Enabled = True
                    Timer69.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg69.Text))
                        datodemsg = msg69.Text
                        timerpass.Text = "69"
                        Escritor.Enabled = True
                        Timer69.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer70.Enabled = True
                        Timer69.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg70.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg69.Text))
                    datodemsg = msg69.Text
                    timerpass.Text = "69"
                    Escritor.Enabled = True
                Else
                    Timer70.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg70.BackColor = Color.PaleTurquoise
                Timer69.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer70_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer70.Tick
        baseT = msg70.Text
        filterB()
        If msg71.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg70.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer70.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg70.Text))
                        datodemsg = msg70.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer70.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer70.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg70.Text))
                    datodemsg = msg70.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer70.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer70.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg70.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer71.Enabled = True
                    Timer70.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg70.Text))
                        datodemsg = msg70.Text
                        timerpass.Text = "70"
                        Escritor.Enabled = True
                        Timer70.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer71.Enabled = True
                        Timer70.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg71.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg70.Text))
                    datodemsg = msg70.Text
                    timerpass.Text = "70"
                    Escritor.Enabled = True
                Else
                    Timer71.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg71.BackColor = Color.PaleTurquoise
                Timer70.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer71_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer71.Tick
        baseT = msg71.Text
        filterB()
        If msg72.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg71.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer71.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg71.Text))
                        datodemsg = msg71.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer71.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer71.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg71.Text))
                    datodemsg = msg71.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer71.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer71.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg71.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer72.Enabled = True
                    Timer71.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg71.Text))
                        datodemsg = msg71.Text
                        timerpass.Text = "71"
                        Escritor.Enabled = True
                        Timer71.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer72.Enabled = True
                        Timer71.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg72.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg71.Text))
                    datodemsg = msg71.Text
                    timerpass.Text = "71"
                    Escritor.Enabled = True
                Else
                    Timer72.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg72.BackColor = Color.PaleTurquoise
                Timer71.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer72_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer72.Tick
        baseT = msg72.Text
        filterB()
        If msg73.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg72.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer72.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg72.Text))
                        datodemsg = msg72.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer72.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer72.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg72.Text))
                    datodemsg = msg72.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer72.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer72.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg72.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer73.Enabled = True
                    Timer72.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg72.Text))
                        datodemsg = msg72.Text
                        timerpass.Text = "72"
                        Escritor.Enabled = True
                        Timer72.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer73.Enabled = True
                        Timer72.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg73.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg72.Text))
                    datodemsg = msg72.Text
                    timerpass.Text = "72"
                    Escritor.Enabled = True
                Else
                    Timer73.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg73.BackColor = Color.PaleTurquoise
                Timer72.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer73_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer73.Tick
        baseT = msg73.Text
        filterB()
        If msg74.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg73.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer73.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg73.Text))
                        datodemsg = msg73.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer73.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer73.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg73.Text))
                    datodemsg = msg73.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer73.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer73.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg73.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer74.Enabled = True
                    Timer73.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg73.Text))
                        datodemsg = msg73.Text
                        timerpass.Text = "73"
                        Escritor.Enabled = True
                        Timer73.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer74.Enabled = True
                        Timer73.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg74.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg73.Text))
                    datodemsg = msg73.Text
                    timerpass.Text = "73"
                    Escritor.Enabled = True
                Else
                    Timer74.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg74.BackColor = Color.PaleTurquoise
                Timer73.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer74_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer74.Tick
        baseT = msg74.Text
        filterB()
        If msg75.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg74.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer74.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg74.Text))
                        datodemsg = msg74.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer74.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer74.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg74.Text))
                    datodemsg = msg74.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer74.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer74.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg74.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer75.Enabled = True
                    Timer74.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg74.Text))
                        datodemsg = msg74.Text
                        timerpass.Text = "74"
                        Escritor.Enabled = True
                        Timer74.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer75.Enabled = True
                        Timer74.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg75.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg74.Text))
                    datodemsg = msg74.Text
                    timerpass.Text = "74"
                    Escritor.Enabled = True
                Else
                    Timer75.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg75.BackColor = Color.PaleTurquoise
                Timer74.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer75_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer75.Tick
        baseT = msg75.Text
        filterB()
        If msg76.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg75.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer75.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg75.Text))
                        datodemsg = msg75.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer75.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer75.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg75.Text))
                    datodemsg = msg75.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer75.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer75.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg75.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer76.Enabled = True
                    Timer75.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg75.Text))
                        datodemsg = msg75.Text
                        timerpass.Text = "75"
                        Escritor.Enabled = True
                        Timer75.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer76.Enabled = True
                        Timer75.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg76.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg75.Text))
                    datodemsg = msg75.Text
                    timerpass.Text = "75"
                    Escritor.Enabled = True
                Else
                    Timer76.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg76.BackColor = Color.PaleTurquoise
                Timer75.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer76_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer76.Tick
        baseT = msg76.Text
        filterB()
        If msg77.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg76.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer76.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg76.Text))
                        datodemsg = msg76.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer76.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer76.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg76.Text))
                    datodemsg = msg76.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer76.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer76.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg76.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer77.Enabled = True
                    Timer76.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg76.Text))
                        datodemsg = msg76.Text
                        timerpass.Text = "76"
                        Escritor.Enabled = True
                        Timer76.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer77.Enabled = True
                        Timer76.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg77.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg76.Text))
                    datodemsg = msg76.Text
                    timerpass.Text = "76"
                    Escritor.Enabled = True
                Else
                    Timer77.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg77.BackColor = Color.PaleTurquoise
                Timer76.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer77_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer77.Tick
        baseT = msg77.Text
        filterB()
        If msg78.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg77.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer77.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg77.Text))
                        datodemsg = msg77.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer77.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer77.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg77.Text))
                    datodemsg = msg77.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer77.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer77.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg77.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer78.Enabled = True
                    Timer77.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg77.Text))
                        datodemsg = msg77.Text
                        timerpass.Text = "77"
                        Escritor.Enabled = True
                        Timer77.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer78.Enabled = True
                        Timer77.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg78.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg77.Text))
                    datodemsg = msg77.Text
                    timerpass.Text = "77"
                    Escritor.Enabled = True
                Else
                    Timer78.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg78.BackColor = Color.PaleTurquoise
                Timer77.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer78_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer78.Tick
        baseT = msg78.Text
        filterB()
        If msg79.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg78.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer78.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg78.Text))
                        datodemsg = msg78.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer78.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer78.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg78.Text))
                    datodemsg = msg78.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer78.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer78.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg78.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer79.Enabled = True
                    Timer78.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg78.Text))
                        datodemsg = msg78.Text
                        timerpass.Text = "78"
                        Escritor.Enabled = True
                        Timer78.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer79.Enabled = True
                        Timer78.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg79.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg78.Text))
                    datodemsg = msg78.Text
                    timerpass.Text = "78"
                    Escritor.Enabled = True
                Else
                    Timer79.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg79.BackColor = Color.PaleTurquoise
                Timer78.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer79_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer79.Tick
        baseT = msg79.Text
        filterB()
        If msg80.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg79.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer79.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg79.Text))
                        datodemsg = msg79.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer79.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer79.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg79.Text))
                    datodemsg = msg79.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer79.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer79.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg79.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer80.Enabled = True
                    Timer79.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg79.Text))
                        datodemsg = msg79.Text
                        timerpass.Text = "79"
                        Escritor.Enabled = True
                        Timer79.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer80.Enabled = True
                        Timer79.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg80.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg79.Text))
                    datodemsg = msg79.Text
                    timerpass.Text = "79"
                    Escritor.Enabled = True
                Else
                    Timer80.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg80.BackColor = Color.PaleTurquoise
                Timer79.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer80_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer80.Tick
        baseT = msg80.Text
        filterB()
        If msg81.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg80.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer80.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg80.Text))
                        datodemsg = msg80.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer80.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer80.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg80.Text))
                    datodemsg = msg80.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer80.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer80.Enabled = False
            End If
        Else
            Me.tabcontrol.SelectedTab = Me.TabPage5
            If CheckBox2.Checked = True Then
                If msg80.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer81.Enabled = True
                    Timer80.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg80.Text))
                        datodemsg = msg80.Text
                        timerpass.Text = "80"
                        Escritor.Enabled = True
                        Timer80.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer81.Enabled = True
                        Timer80.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg81.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg80.Text))
                    datodemsg = msg80.Text
                    timerpass.Text = "80"
                    Escritor.Enabled = True
                Else
                    Timer81.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg81.BackColor = Color.PaleTurquoise
                Timer80.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer81_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer81.Tick
        baseT = msg81.Text
        filterB()
        If msg82.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg81.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer81.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg81.Text))
                        datodemsg = msg81.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer81.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer81.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg81.Text))
                    datodemsg = msg81.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer81.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer81.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg81.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer82.Enabled = True
                    Timer81.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg81.Text))
                        datodemsg = msg81.Text
                        timerpass.Text = "81"
                        Escritor.Enabled = True
                        Timer81.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer82.Enabled = True
                        Timer81.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg82.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg81.Text))
                    datodemsg = msg81.Text
                    timerpass.Text = "81"
                    Escritor.Enabled = True
                Else
                    Timer82.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg82.BackColor = Color.PaleTurquoise
                Timer81.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer82_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer82.Tick
        baseT = msg82.Text
        filterB()
        If msg83.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg82.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer82.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg82.Text))
                        datodemsg = msg82.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer82.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer82.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg82.Text))
                    datodemsg = msg82.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer82.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer82.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg82.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer83.Enabled = True
                    Timer82.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg82.Text))
                        datodemsg = msg82.Text
                        timerpass.Text = "82"
                        Escritor.Enabled = True
                        Timer82.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer83.Enabled = True
                        Timer82.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg83.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg82.Text))
                    datodemsg = msg82.Text
                    timerpass.Text = "82"
                    Escritor.Enabled = True
                Else
                    Timer83.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg83.BackColor = Color.PaleTurquoise
                Timer82.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer83_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer83.Tick
        baseT = msg83.Text
        filterB()
        If msg84.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg83.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer83.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg83.Text))
                        datodemsg = msg83.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer83.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer83.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg83.Text))
                    datodemsg = msg83.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer83.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer83.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg83.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer84.Enabled = True
                    Timer83.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg83.Text))
                        datodemsg = msg83.Text
                        timerpass.Text = "83"
                        Escritor.Enabled = True
                        Timer83.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer84.Enabled = True
                        Timer83.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg84.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg83.Text))
                    datodemsg = msg83.Text
                    timerpass.Text = "83"
                    Escritor.Enabled = True
                Else
                    Timer84.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg84.BackColor = Color.PaleTurquoise
                Timer83.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer84_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer84.Tick
        baseT = msg84.Text
        filterB()
        If msg85.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg84.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer84.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg84.Text))
                        datodemsg = msg84.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer84.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer84.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg84.Text))
                    datodemsg = msg84.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer84.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer84.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg84.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer85.Enabled = True
                    Timer84.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg84.Text))
                        datodemsg = msg84.Text
                        timerpass.Text = "84"
                        Escritor.Enabled = True
                        Timer84.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer85.Enabled = True
                        Timer84.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg85.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg84.Text))
                    datodemsg = msg84.Text
                    timerpass.Text = "84"
                    Escritor.Enabled = True
                Else
                    Timer85.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg85.BackColor = Color.PaleTurquoise
                Timer84.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer85_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer85.Tick
        baseT = msg85.Text
        filterB()
        If msg86.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg85.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer85.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg85.Text))
                        datodemsg = msg85.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer85.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer85.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg85.Text))
                    datodemsg = msg85.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer85.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer85.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg85.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer86.Enabled = True
                    Timer85.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg85.Text))
                        datodemsg = msg85.Text
                        timerpass.Text = "85"
                        Escritor.Enabled = True
                        Timer85.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer86.Enabled = True
                        Timer85.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg86.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg85.Text))
                    datodemsg = msg85.Text
                    timerpass.Text = "85"
                    Escritor.Enabled = True
                Else
                    Timer86.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg86.BackColor = Color.PaleTurquoise
                Timer85.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer86_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer86.Tick
        baseT = msg86.Text
        filterB()
        If msg87.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg86.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer86.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg86.Text))
                        datodemsg = msg86.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer86.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer86.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg86.Text))
                    datodemsg = msg86.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer86.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer86.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg86.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer87.Enabled = True
                    Timer86.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg86.Text))
                        datodemsg = msg86.Text
                        timerpass.Text = "86"
                        Escritor.Enabled = True
                        Timer86.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer87.Enabled = True
                        Timer86.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg87.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg86.Text))
                    datodemsg = msg86.Text
                    timerpass.Text = "86"
                    Escritor.Enabled = True
                Else
                    Timer87.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg87.BackColor = Color.PaleTurquoise
                Timer86.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer87_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer87.Tick
        baseT = msg87.Text
        filterB()
        If msg88.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg87.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer87.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg87.Text))
                        datodemsg = msg87.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer87.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer87.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg87.Text))
                    datodemsg = msg87.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer87.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer87.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg87.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer88.Enabled = True
                    Timer87.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg87.Text))
                        datodemsg = msg87.Text
                        timerpass.Text = "87"
                        Escritor.Enabled = True
                        Timer87.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer88.Enabled = True
                        Timer87.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg88.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg87.Text))
                    datodemsg = msg87.Text
                    timerpass.Text = "87"
                    Escritor.Enabled = True
                Else
                    Timer88.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg88.BackColor = Color.PaleTurquoise
                Timer87.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer88_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer88.Tick
        baseT = msg88.Text
        filterB()
        If msg89.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg88.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer88.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg88.Text))
                        datodemsg = msg88.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer88.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer88.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg88.Text))
                    datodemsg = msg88.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer88.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer88.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg88.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer89.Enabled = True
                    Timer88.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg88.Text))
                        datodemsg = msg88.Text
                        timerpass.Text = "88"
                        Escritor.Enabled = True
                        Timer88.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer89.Enabled = True
                        Timer88.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg89.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg88.Text))
                    datodemsg = msg88.Text
                    timerpass.Text = "88"
                    Escritor.Enabled = True
                Else
                    Timer89.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg89.BackColor = Color.PaleTurquoise
                Timer88.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer89_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer89.Tick
        baseT = msg89.Text
        filterB()
        If msg90.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg89.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer89.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg89.Text))
                        datodemsg = msg89.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer89.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer89.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg89.Text))
                    datodemsg = msg89.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer89.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer89.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg89.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer90.Enabled = True
                    Timer89.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg89.Text))
                        datodemsg = msg89.Text
                        timerpass.Text = "89"
                        Escritor.Enabled = True
                        Timer89.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer90.Enabled = True
                        Timer89.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg90.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg89.Text))
                    datodemsg = msg89.Text
                    timerpass.Text = "89"
                    Escritor.Enabled = True
                Else
                    Timer90.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg90.BackColor = Color.PaleTurquoise
                Timer89.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer90_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer90.Tick
        baseT = msg90.Text
        filterB()
        If msg91.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg90.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer90.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg90.Text))
                        datodemsg = msg90.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer90.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer90.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg90.Text))
                    datodemsg = msg90.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer90.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer90.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg90.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer91.Enabled = True
                    Timer90.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg90.Text))
                        datodemsg = msg90.Text
                        timerpass.Text = "90"
                        Escritor.Enabled = True
                        Timer90.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer91.Enabled = True
                        Timer90.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg91.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg90.Text))
                    datodemsg = msg90.Text
                    timerpass.Text = "90"
                    Escritor.Enabled = True
                Else
                    Timer91.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg91.BackColor = Color.PaleTurquoise
                Timer90.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer91_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer91.Tick
        baseT = msg91.Text
        filterB()
        If msg92.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg91.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer91.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg91.Text))
                        datodemsg = msg91.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer91.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer91.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg91.Text))
                    datodemsg = msg91.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer91.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer91.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg91.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer92.Enabled = True
                    Timer91.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg91.Text))
                        datodemsg = msg91.Text
                        timerpass.Text = "91"
                        Escritor.Enabled = True
                        Timer91.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer92.Enabled = True
                        Timer91.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg92.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg91.Text))
                    datodemsg = msg91.Text
                    timerpass.Text = "91"
                    Escritor.Enabled = True
                Else
                    Timer92.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg92.BackColor = Color.PaleTurquoise
                Timer91.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer92_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer92.Tick
        baseT = msg92.Text
        filterB()
        If msg93.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg92.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer92.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg92.Text))
                        datodemsg = msg92.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer92.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer92.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg92.Text))
                    datodemsg = msg92.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer92.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer92.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg92.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer93.Enabled = True
                    Timer92.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg92.Text))
                        datodemsg = msg92.Text
                        timerpass.Text = "92"
                        Escritor.Enabled = True
                        Timer92.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer93.Enabled = True
                        Timer92.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg93.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg92.Text))
                    datodemsg = msg92.Text
                    timerpass.Text = "92"
                    Escritor.Enabled = True
                Else
                    Timer93.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg93.BackColor = Color.PaleTurquoise
                Timer92.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer93_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer93.Tick
        baseT = msg93.Text
        filterB()
        If msg94.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg93.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer93.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg93.Text))
                        datodemsg = msg93.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer93.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer93.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg93.Text))
                    datodemsg = msg93.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer93.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer93.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg93.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer94.Enabled = True
                    Timer93.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg93.Text))
                        datodemsg = msg93.Text
                        timerpass.Text = "93"
                        Escritor.Enabled = True
                        Timer93.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer94.Enabled = True
                        Timer93.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg94.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg93.Text))
                    datodemsg = msg93.Text
                    timerpass.Text = "93"
                    Escritor.Enabled = True
                Else
                    Timer94.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg94.BackColor = Color.PaleTurquoise
                Timer93.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer94_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer94.Tick
        baseT = msg94.Text
        filterB()
        If msg95.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg94.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer94.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg94.Text))
                        datodemsg = msg94.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer94.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer94.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg94.Text))
                    datodemsg = msg94.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer94.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer94.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg94.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer95.Enabled = True
                    Timer94.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg94.Text))
                        datodemsg = msg94.Text
                        timerpass.Text = "94"
                        Escritor.Enabled = True
                        Timer94.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer95.Enabled = True
                        Timer94.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg95.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg94.Text))
                    datodemsg = msg94.Text
                    timerpass.Text = "94"
                    Escritor.Enabled = True
                Else
                    Timer95.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg95.BackColor = Color.PaleTurquoise
                Timer94.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer95_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer95.Tick
        baseT = msg95.Text
        filterB()
        If msg96.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg95.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer95.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg95.Text))
                        datodemsg = msg95.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer95.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer95.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg95.Text))
                    datodemsg = msg95.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer95.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer95.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg95.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer96.Enabled = True
                    Timer95.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg95.Text))
                        datodemsg = msg95.Text
                        timerpass.Text = "95"
                        Escritor.Enabled = True
                        Timer95.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer96.Enabled = True
                        Timer95.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg96.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg95.Text))
                    datodemsg = msg95.Text
                    timerpass.Text = "95"
                    Escritor.Enabled = True
                Else
                    Timer96.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg96.BackColor = Color.PaleTurquoise
                Timer95.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer96_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer96.Tick
        baseT = msg96.Text
        filterB()
        If msg97.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg96.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer96.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg96.Text))
                        datodemsg = msg96.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer96.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer96.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg96.Text))
                    datodemsg = msg96.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer96.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer96.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg96.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer97.Enabled = True
                    Timer96.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg96.Text))
                        datodemsg = msg96.Text
                        timerpass.Text = "96"
                        Escritor.Enabled = True
                        Timer96.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer97.Enabled = True
                        Timer96.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg97.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg96.Text))
                    datodemsg = msg96.Text
                    timerpass.Text = "96"
                    Escritor.Enabled = True
                Else
                    Timer97.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg97.BackColor = Color.PaleTurquoise
                Timer96.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer97_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer97.Tick
        baseT = msg97.Text
        filterB()
        If msg98.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg97.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer97.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg97.Text))
                        datodemsg = msg97.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer97.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer97.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg97.Text))
                    datodemsg = msg97.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer97.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer97.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg97.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer98.Enabled = True
                    Timer97.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg97.Text))
                        datodemsg = msg97.Text
                        timerpass.Text = "97"
                        Escritor.Enabled = True
                        Timer97.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer98.Enabled = True
                        Timer97.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg98.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg97.Text))
                    datodemsg = msg97.Text
                    timerpass.Text = "97"
                    Escritor.Enabled = True
                Else
                    Timer98.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg98.BackColor = Color.PaleTurquoise
                Timer97.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer98_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer98.Tick
        baseT = msg98.Text
        filterB()
        If msg99.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg98.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer98.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg98.Text))
                        datodemsg = msg98.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer98.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer98.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg98.Text))
                    datodemsg = msg98.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer98.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer98.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg98.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer99.Enabled = True
                    Timer98.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg98.Text))
                        datodemsg = msg98.Text
                        timerpass.Text = "98"
                        Escritor.Enabled = True
                        Timer98.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer99.Enabled = True
                        Timer98.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg99.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg98.Text))
                    datodemsg = msg98.Text
                    timerpass.Text = "98"
                    Escritor.Enabled = True
                Else
                    Timer99.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg99.BackColor = Color.PaleTurquoise
                Timer98.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer99_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer99.Tick
        baseT = msg99.Text
        filterB()
        If msg100.Text = "" Then
            If CheckBox2.Checked = True Then
                If msg99.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer99.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg99.Text))
                        datodemsg = msg99.Text
                        timerpass.Text = "0"
                        Escritor.Enabled = True
                        Timer99.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer99.Enabled = False
                    End If
                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg99.Text))
                    datodemsg = msg99.Text
                    timerpass.Text = "0"
                    Escritor.Enabled = True
                    Timer99.Enabled = False
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer99.Enabled = False
            End If
        Else
            If CheckBox2.Checked = True Then
                If msg99.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer100.Enabled = True
                    Timer99.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg99.Text))
                        datodemsg = msg99.Text
                        timerpass.Text = "99"
                        Escritor.Enabled = True
                        Timer99.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer100.Enabled = True
                        Timer99.Enabled = False
                    End If

                End If
                coloresdeltexbox()
                msg100.BackColor = Color.PaleTurquoise
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg99.Text))
                    datodemsg = msg99.Text
                    timerpass.Text = "99"
                    Escritor.Enabled = True
                Else
                    Timer100.Enabled = True
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                msg100.BackColor = Color.PaleTurquoise
                Timer99.Enabled = False
            End If
        End If
    End Sub
    Private Sub Timer100_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer100.Tick
        baseT = msg100.Text
        filterB()
            If CheckBox2.Checked = True Then
                If msg100.Text = TextBox3.Text Then
                    SendKeys.Send("^v")
                    Threading.Thread.Sleep(TextBox4.Text)
                    SendKeys.Send("{enter}")
                    Timer100.Enabled = False
                Else
                    If CheckBox1.Checked = True Then
                        counescritor = CStr(Len(msg100.Text))
                        datodemsg = msg100.Text
                        timerpass.Text = "100"
                        Escritor.Enabled = True
                        Timer100.Enabled = False
                    Else
                        SendKeys.Send(buffer)
                        SendKeys.Send("{enter}")
                        Timer100.Enabled = False
                    End If

                End If
                coloresdeltexbox()
            Else
                If CheckBox1.Checked = True Then
                    counescritor = CStr(Len(msg100.Text))
                    datodemsg = msg100.Text
                    timerpass.Text = "100"
                    Escritor.Enabled = True
                Else
                    SendKeys.Send(buffer)
                    SendKeys.Send("{enter}")
                End If
                coloresdeltexbox()
                Timer100.Enabled = False
            End If
    End Sub
    Private Sub Escritor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Escritor.Tick
        If counescritor = 0 Then
            SendKeys.Send("{enter}")
            timerpassescritor()
        Else
            xiin = xiin + 1
            baseT = Mid(datodemsg, xiin, 1)
            filterB()
            SendKeys.Send(buffer)
            counescritor = counescritor - 1
        End If
    End Sub
    Dim hora As String = ""
    Dim hori As String = Now.ToString("HH")
    Dim mini As String = Now.ToString("mm")
    Dim segi As String = Now.ToString("ss")
    Dim programadora As String = "Default"
    Private Sub Control_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Control.Tick
        
        hora = Now.ToString("HH:mm:ss")
        If GetKeyPress(Keys.F2) Then
            If programadora = "Default" Then
                timerpass.Text = "0"
                Timer1.Enabled = True
                coloresdeltexbox()
                msg1.BackColor = Color.PaleTurquoise
                Me.tabcontrol.SelectedTab = Me.TabPage1
            ElseIf programadora = "Hora" Then
                MsgBox("Chatbot is programmed to run automatically at " & reloj & vbCrLf & " To use F2, disable automatic programming")
            End If
f2s:
        End If
        If GetKeyPress(Keys.F2) Then
            GoTo f2s
        End If

        If GetKeyPress(Keys.F3) Then
            timerstop()
            coloresdeltexbox()
f3s:
        End If
        If GetKeyPress(Keys.F3) Then
            GoTo f3s
        End If
    End Sub  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Escritor.Interval = TextBox2.Text
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        msg1.Text = ""
        msg2.Text = ""
        msg3.Text = ""
        msg4.Text = ""
        msg5.Text = ""
        msg6.Text = ""
        msg7.Text = ""
        msg8.Text = ""
        msg9.Text = ""
        msg10.Text = ""
        msg11.Text = ""
        msg12.Text = ""
        msg13.Text = ""
        msg14.Text = ""
        msg15.Text = ""
        msg16.Text = ""
        msg17.Text = ""
        msg18.Text = ""
        msg19.Text = ""
        msg20.Text = ""
        msg21.Text = ""
        msg22.Text = ""
        msg23.Text = ""
        msg24.Text = ""
        msg25.Text = ""
        msg26.Text = ""
        msg27.Text = ""
        msg28.Text = ""
        msg29.Text = ""
        msg30.Text = ""
        msg31.Text = ""
        msg32.Text = ""
        msg33.Text = ""
        msg34.Text = ""
        msg35.Text = ""
        msg36.Text = ""
        msg37.Text = ""
        msg38.Text = ""
        msg39.Text = ""
        msg40.Text = ""
        msg41.Text = ""
        msg42.Text = ""
        msg43.Text = ""
        msg44.Text = ""
        msg45.Text = ""
        msg46.Text = ""
        msg47.Text = ""
        msg48.Text = ""
        msg49.Text = ""
        msg50.Text = ""
        msg51.Text = ""
        msg52.Text = ""
        msg53.Text = ""
        msg54.Text = ""
        msg55.Text = ""
        msg56.Text = ""
        msg57.Text = ""
        msg58.Text = ""
        msg59.Text = ""
        msg60.Text = ""
        msg61.Text = ""
        msg62.Text = ""
        msg63.Text = ""
        msg64.Text = ""
        msg65.Text = ""
        msg66.Text = ""
        msg67.Text = ""
        msg68.Text = ""
        msg69.Text = ""
        msg70.Text = ""
        msg71.Text = ""
        msg72.Text = ""
        msg73.Text = ""
        msg74.Text = ""
        msg75.Text = ""
        msg76.Text = ""
        msg77.Text = ""
        msg78.Text = ""
        msg79.Text = ""
        msg80.Text = ""
        msg81.Text = ""
        msg82.Text = ""
        msg83.Text = ""
        msg84.Text = ""
        msg85.Text = ""
        msg86.Text = ""
        msg87.Text = ""
        msg88.Text = ""
        msg89.Text = ""
        msg90.Text = ""
        msg91.Text = ""
        msg92.Text = ""
        msg93.Text = ""
        msg94.Text = ""
        msg95.Text = ""
        msg96.Text = ""
        msg97.Text = ""
        msg98.Text = ""
        msg99.Text = ""
        msg100.Text = ""
    End Sub
    Private Sub program_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles program.Tick
        If reloj = hora Then
            Timer1.Enabled = True
            program.Enabled = False
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox2.Text = "Default" Then
            reloj = "00:00:00"
            Me.Text = "ChatBot"
            programadora = "Default"
            MsgBox("Normal ChatBot without schedule")
        ElseIf ComboBox2.Text = "Hora" Then
            reloj = hor.Text & ":" & min.Text & ":" & seg.Text
            Me.Text = "ChatBot - Scheduled at " & reloj
            programadora = "Hora"
            MsgBox("ChatBot with schedule at " & reloj)
            timerpass.Text = "0"
            program.Enabled = True
            coloresdeltexbox()
            msg1.BackColor = Color.PaleTurquoise
        End If
    End Sub
    Private Sub Codigo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        My.Settings.text1 = msg1.Text
        My.Settings.text2 = msg2.Text
        My.Settings.text3 = msg3.Text
        My.Settings.text4 = msg4.Text
        My.Settings.text5 = msg5.Text
        My.Settings.text6 = msg6.Text
        My.Settings.text7 = msg7.Text
        My.Settings.text8 = msg8.Text
        My.Settings.text9 = msg9.Text
        My.Settings.text10 = msg10.Text
        My.Settings.text11 = msg11.Text
        My.Settings.text12 = msg12.Text
        My.Settings.text13 = msg13.Text
        My.Settings.text14 = msg14.Text
        My.Settings.text15 = msg15.Text
        My.Settings.text16 = msg16.Text
        My.Settings.text17 = msg17.Text
        My.Settings.text18 = msg18.Text
        My.Settings.text19 = msg19.Text
        My.Settings.text20 = msg20.Text
        My.Settings.text21 = msg21.Text
        My.Settings.text22 = msg22.Text
        My.Settings.text23 = msg23.Text
        My.Settings.text24 = msg24.Text
        My.Settings.text25 = msg25.Text
        My.Settings.text26 = msg26.Text
        My.Settings.text27 = msg27.Text
        My.Settings.text28 = msg28.Text
        My.Settings.text29 = msg29.Text
        My.Settings.text30 = msg30.Text
        My.Settings.text31 = msg31.Text
        My.Settings.text32 = msg32.Text
        My.Settings.text33 = msg33.Text
        My.Settings.text34 = msg34.Text
        My.Settings.text35 = msg35.Text
        My.Settings.text36 = msg36.Text
        My.Settings.text37 = msg37.Text
        My.Settings.text38 = msg38.Text
        My.Settings.text39 = msg39.Text
        My.Settings.text40 = msg40.Text
        My.Settings.text41 = msg41.Text
        My.Settings.text42 = msg42.Text
        My.Settings.text43 = msg43.Text
        My.Settings.text44 = msg44.Text
        My.Settings.text45 = msg45.Text
        My.Settings.text46 = msg46.Text
        My.Settings.text47 = msg47.Text
        My.Settings.text48 = msg48.Text
        My.Settings.text49 = msg49.Text
        My.Settings.text50 = msg50.Text
        My.Settings.text51 = msg51.Text
        My.Settings.text52 = msg52.Text
        My.Settings.text53 = msg53.Text
        My.Settings.text54 = msg54.Text
        My.Settings.text55 = msg55.Text
        My.Settings.text56 = msg56.Text
        My.Settings.text57 = msg57.Text
        My.Settings.text58 = msg58.Text
        My.Settings.text59 = msg59.Text
        My.Settings.text60 = msg60.Text
        My.Settings.text61 = msg61.Text
        My.Settings.text62 = msg62.Text
        My.Settings.text63 = msg63.Text
        My.Settings.text64 = msg64.Text
        My.Settings.text65 = msg65.Text
        My.Settings.text66 = msg66.Text
        My.Settings.text67 = msg67.Text
        My.Settings.text68 = msg68.Text
        My.Settings.text69 = msg69.Text
        My.Settings.text70 = msg70.Text
        My.Settings.text71 = msg71.Text
        My.Settings.text72 = msg72.Text
        My.Settings.text73 = msg73.Text
        My.Settings.text74 = msg74.Text
        My.Settings.text75 = msg75.Text
        My.Settings.text76 = msg76.Text
        My.Settings.text77 = msg77.Text
        My.Settings.text78 = msg78.Text
        My.Settings.text79 = msg79.Text
        My.Settings.text80 = msg80.Text
        My.Settings.text81 = msg81.Text
        My.Settings.text82 = msg82.Text
        My.Settings.text83 = msg83.Text
        My.Settings.text84 = msg84.Text
        My.Settings.text85 = msg85.Text
        My.Settings.text86 = msg86.Text
        My.Settings.text87 = msg87.Text
        My.Settings.text88 = msg88.Text
        My.Settings.text89 = msg89.Text
        My.Settings.text90 = msg90.Text
        My.Settings.text91 = msg91.Text
        My.Settings.text92 = msg92.Text
        My.Settings.text93 = msg93.Text
        My.Settings.text94 = msg94.Text
        My.Settings.text95 = msg95.Text
        My.Settings.text96 = msg96.Text
        My.Settings.text97 = msg97.Text
        My.Settings.text98 = msg98.Text
        My.Settings.text99 = msg99.Text
        My.Settings.text100 = msg100.Text

        My.Settings.Save()
        My.Settings.Reload()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hor.Text = hori
        min.Text = mini
        seg.Text = segi
        msg1.Text = My.Settings.text1
        msg2.Text = My.Settings.text2
        msg3.Text = My.Settings.text3
        msg4.Text = My.Settings.text4
        msg5.Text = My.Settings.text5
        msg6.Text = My.Settings.text6
        msg7.Text = My.Settings.text7
        msg8.Text = My.Settings.text8
        msg9.Text = My.Settings.text9
        msg10.Text = My.Settings.text10
        msg11.Text = My.Settings.text11
        msg12.Text = My.Settings.text12
        msg13.Text = My.Settings.text13
        msg14.Text = My.Settings.text14
        msg15.Text = My.Settings.text15
        msg16.Text = My.Settings.text16
        msg17.Text = My.Settings.text17
        msg18.Text = My.Settings.text18
        msg19.Text = My.Settings.text19
        msg20.Text = My.Settings.text20
        msg21.Text = My.Settings.text21
        msg22.Text = My.Settings.text22
        msg23.Text = My.Settings.text23
        msg24.Text = My.Settings.text24
        msg25.Text = My.Settings.text25
        msg26.Text = My.Settings.text26
        msg27.Text = My.Settings.text27
        msg28.Text = My.Settings.text28
        msg29.Text = My.Settings.text29
        msg30.Text = My.Settings.text30
        msg31.Text = My.Settings.text31
        msg32.Text = My.Settings.text32
        msg33.Text = My.Settings.text33
        msg34.Text = My.Settings.text34
        msg35.Text = My.Settings.text35
        msg36.Text = My.Settings.text36
        msg37.Text = My.Settings.text37
        msg38.Text = My.Settings.text38
        msg39.Text = My.Settings.text39
        msg40.Text = My.Settings.text40
        msg41.Text = My.Settings.text41
        msg42.Text = My.Settings.text42
        msg43.Text = My.Settings.text43
        msg44.Text = My.Settings.text44
        msg45.Text = My.Settings.text45
        msg46.Text = My.Settings.text46
        msg47.Text = My.Settings.text47
        msg48.Text = My.Settings.text48
        msg49.Text = My.Settings.text49
        msg50.Text = My.Settings.text50
        msg51.Text = My.Settings.text51
        msg52.Text = My.Settings.text52
        msg53.Text = My.Settings.text53
        msg54.Text = My.Settings.text54
        msg55.Text = My.Settings.text55
        msg56.Text = My.Settings.text56
        msg57.Text = My.Settings.text57
        msg58.Text = My.Settings.text58
        msg59.Text = My.Settings.text59
        msg60.Text = My.Settings.text60
        msg61.Text = My.Settings.text61
        msg62.Text = My.Settings.text62
        msg63.Text = My.Settings.text63
        msg64.Text = My.Settings.text64
        msg65.Text = My.Settings.text65
        msg66.Text = My.Settings.text66
        msg67.Text = My.Settings.text67
        msg68.Text = My.Settings.text68
        msg69.Text = My.Settings.text69
        msg70.Text = My.Settings.text70
        msg71.Text = My.Settings.text71
        msg72.Text = My.Settings.text72
        msg73.Text = My.Settings.text73
        msg74.Text = My.Settings.text74
        msg75.Text = My.Settings.text75
        msg76.Text = My.Settings.text76
        msg77.Text = My.Settings.text77
        msg78.Text = My.Settings.text78
        msg79.Text = My.Settings.text79
        msg80.Text = My.Settings.text80
        msg81.Text = My.Settings.text81
        msg82.Text = My.Settings.text82
        msg83.Text = My.Settings.text83
        msg84.Text = My.Settings.text84
        msg85.Text = My.Settings.text85
        msg86.Text = My.Settings.text86
        msg87.Text = My.Settings.text87
        msg88.Text = My.Settings.text88
        msg89.Text = My.Settings.text89
        msg90.Text = My.Settings.text90
        msg91.Text = My.Settings.text91
        msg92.Text = My.Settings.text92
        msg93.Text = My.Settings.text93
        msg94.Text = My.Settings.text94
        msg95.Text = My.Settings.text95
        msg96.Text = My.Settings.text96
        msg97.Text = My.Settings.text97
        msg98.Text = My.Settings.text98
        msg99.Text = My.Settings.text99
        msg100.Text = My.Settings.text100
        My.Settings.Save()
        My.Settings.Reload()
    End Sub
    Private Sub hor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles hor.DoubleClick
        hor.Text = ""
    End Sub
    Private Sub min_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles min.DoubleClick
        min.Text = ""
    End Sub
    Private Sub seg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles seg.DoubleClick
        seg.Text = ""
    End Sub

    Private Sub timerpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerpass.Click

    End Sub
End Class
