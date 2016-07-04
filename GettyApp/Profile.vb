Public Class Profile

    Private Sub btn_reset_pass_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset_pass.Click
        btn_reset_pass.Enabled = False
        resetPasswordRequestAPI(gettyUser, txt_old_pass.Text, txt_new_pass.Text, txt_conf_pass.Text, API_RESPASS_PATH)
        btn_reset_pass.Enabled = True
    End Sub

    Sub clearField()
        txt_old_pass.Clear()
        txt_new_pass.Clear()
        txt_conf_pass.Clear()
    End Sub

    Private Sub Profile_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        clearField()
        getUserInfoRequestAPI(gettyUser, API_USER_INFO_PATH)
        pb_user_img.Image = Image.FromFile(LOCAL_USER_IMG_PATH & gettyProfile)
    End Sub
End Class