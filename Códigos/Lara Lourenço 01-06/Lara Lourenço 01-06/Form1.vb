Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        RadioButton1.Text = ""
        RadioButton2.Text = ""
        CheckBox2.Text = ""
        CheckBox1.Text = ""
        PictureBox1.Image = Nothing
        PictureBox3.Image = Nothing
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        Select Case ComboBox1.SelectedIndex
            Case 0
                PictureBox1.Image = Nothing
                PictureBox3.Image = Nothing
                ListBox1.Items.Add(" Ganhadores nas categorias de comédia em 2016")
                ListBox1.Items.Add(" Ganhadores nas categorias de comédia em 2015")
                ListBox1.Items.Add(" Ganhadores nas categorias de comédia em 2014")
                ListBox1.Items.Add(" Ganhadores nas categorias de comédia em 2013")

            Case 1
                PictureBox1.Image = Nothing
                PictureBox3.Image = Nothing
                ListBox1.Items.Add(" Ganhadores nas categorias dramáticas em 2016")
                ListBox1.Items.Add(" Ganhadores nas categorias dramáticas em 2015")
                ListBox1.Items.Add(" Ganhadores nas categorias dramáticas em 2014")
                ListBox1.Items.Add(" Ganhadores nas categorias dramáticas em 2013")

        End Select

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        PictureBox1.Image = Nothing
        PictureBox3.Image = Nothing
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        Select Case ComboBox1.SelectedIndex
            Case 0
                Select Case ListBox1.SelectedIndex
                    Case 0
                        PictureBox1.Image = Nothing
                        PictureBox3.Image = Nothing
                        CheckBox1.Checked = False
                        CheckBox2.Checked = False
                        RadioButton1.Checked = False
                        RadioButton2.Checked = False
                        RadioButton1.Text = "2016- Julia Louis-Dreyfus por Veep (protagonista) "
                        RadioButton2.Text = "2016- Kate McKinnon por Saturday Night Live (coadjuvante)  "
                        CheckBox1.Text = "2016- Louie Anderson por Baskets (coadjuvante)"
                        CheckBox2.Text = "2016- Jeffrey Tambor por Transparent (protagonista)"
                    Case 1
                        PictureBox1.Image = Nothing
                        PictureBox3.Image = Nothing
                        CheckBox1.Checked = False
                        CheckBox2.Checked = False
                        RadioButton1.Checked = False
                        RadioButton2.Checked = False
                        RadioButton1.Text = "2015- Allison Janney por Mom (coadjuvante)"
                        RadioButton2.Text = "2015- Julia Louis-Dreyfus por Veep (protagonista) "
                        CheckBox1.Text = "2015- Tony Hale por Veep (coadjuvante)"
                        CheckBox2.Text = "2015- Jeffrey Tambor por Transparent (protagonista)"
                    Case 2
                        PictureBox1.Image = Nothing
                        PictureBox3.Image = Nothing
                        CheckBox1.Checked = False
                        CheckBox2.Checked = False
                        RadioButton1.Checked = False
                        RadioButton2.Checked = False
                        RadioButton1.Text = "2014- Allison Janney por Mom (coadjuvante)"
                        RadioButton2.Text = "2014- Julia Louis-Dreyfus por Veep (protagonista) "
                        CheckBox1.Text = "2014- Ty Burrell por Modern Family (coadjuvante)"
                        CheckBox2.Text = "2014- Jim Parsons por The Big Bang Theory (protagonista)"

                    Case 3
                        PictureBox1.Image = Nothing
                        PictureBox3.Image = Nothing
                        CheckBox1.Checked = False
                        CheckBox2.Checked = False
                        RadioButton1.Checked = False
                        RadioButton2.Checked = False
                        RadioButton1.Text = "2013- Merritt Wever por Nurse Jackie (coadjuvante) "
                        RadioButton2.Text = "2013- Julia Louis-Dreyfus por Veep (protagonista) "
                        CheckBox1.Text = "2013- Tony Hale por Veep (coadjuvante)"
                        CheckBox2.Text = "2013- Jim Parsons por Big Bang Theory (protagonista)"
                End Select
            Case 1
                Select Case ListBox1.SelectedIndex
                    Case 0
                        PictureBox1.Image = Nothing
                        PictureBox3.Image = Nothing
                        CheckBox1.Checked = False
                        CheckBox2.Checked = False
                        RadioButton1.Checked = False
                        RadioButton2.Checked = False
                        RadioButton1.Text = "2016- Tatiana Maslany por Orphan Black (protagonista) "
                        RadioButton2.Text = "2016- Maggie Smith por Downton Abbey (coadjuvante)"
                        CheckBox1.Text = "2016- Ben Mendelsohn por Bloodline (coadjuvante)"
                        CheckBox2.Text = "2016- Rami Malek por Mr. Robot(protagonista)"
                    Case 1
                        PictureBox1.Image = Nothing
                        PictureBox3.Image = Nothing
                        CheckBox1.Checked = False
                        CheckBox2.Checked = False
                        RadioButton1.Checked = False
                        RadioButton2.Checked = False
                        RadioButton1.Text = "2015- Uzo Aduba por Orange is the New Black (coadjuvante)"
                        RadioButton2.Text = "2015- Viola Davis por How to Get Away With Murder (protagonista) "
                        CheckBox1.Text = "2015- Peter Dinklage por Game of Thrones (coadjuvante)"
                        CheckBox2.Text = "2015- Jon Hamm por Mad Men (protagonista)"
                    Case 2
                        PictureBox1.Image = Nothing
                        PictureBox3.Image = Nothing
                        CheckBox1.Checked = False
                        CheckBox2.Checked = False
                        RadioButton1.Checked = False
                        RadioButton2.Checked = False
                        RadioButton1.Text = "2014- Anna Gunn por Breaking Bad (coadjuvante)"
                        RadioButton2.Text = "2014- Julianna Margulies por The Good Wife (protagonista) "
                        CheckBox1.Text = "2014- Aaron Paul por Breaking Bad (coadjuvante)"
                        CheckBox2.Text = "2014- Bryan Cranston por Breaking Bad (protagonista)"
                    Case 3
                        PictureBox1.Image = Nothing
                        PictureBox3.Image = Nothing
                        CheckBox1.Checked = False
                        CheckBox2.Checked = False
                        RadioButton1.Checked = False
                        RadioButton2.Checked = False
                        RadioButton1.Text = "2013- Anna Gunn por Breaking Bad (coadjuvante) "
                        RadioButton2.Text = "2013- Claire Danes por Homeland (protagonista) "
                        CheckBox1.Text = "2013- Bobby Cannavale por Boardwalk Empire (coadjuvante)"
                        CheckBox2.Text = "2013- Jeff Daniels por The Newsroom (protagonista)"
                End Select
        End Select
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Text = "2016- Tatiana Maslany por Orphan Black (protagonista) " Then
            PictureBox1.Image = My.Resources._2016tatiana_orphan_prot
        ElseIf RadioButton1.Text = "2016- Julia Louis-Dreyfus por Veep (protagonista) " Then
            PictureBox1.Image = My.Resources._2016julia_veep_prot
        ElseIf RadioButton1.Text = "2015- Allison Janney por Mom (coadjuvante)" Then
            PictureBox1.Image = My.Resources._2015allison_mom_coa
        ElseIf RadioButton1.Text = "2015- Uzo Aduba por Orange is the New Black (coadjuvante)" Then
            PictureBox1.Image = My.Resources._2015uzo_orange_coa
        ElseIf RadioButton1.Text = "2014- Allison Janney por Mom (coadjuvante)" Then
            PictureBox1.Image = My.Resources._2014allison_mom_coa
        ElseIf RadioButton1.Text = "2014- Anna Gunn por Breaking Bad (coadjuvante)" Then
            PictureBox1.Image = My.Resources._2014anna_breaking_coa
        ElseIf RadioButton1.Text = "2013- Anna Gunn por Breaking Bad (coadjuvante) " Then
            PictureBox1.Image = My.Resources._2013anna_breaking_coa
        ElseIf RadioButton1.Text = "2013- Merritt Wever por Nurse Jackie (coadjuvante) " Then
            PictureBox1.Image = My.Resources._2013merritt_nurse_coa
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Text = "2016- Louie Anderson por Baskets (coadjuvante)" Then
            PictureBox3.Image = My.Resources._2016louie_baskets_coa
            PictureBox3.Visible = True
        End If
        If CheckBox1.Text = "2016- Ben Mendelsohn por Bloodline (coadjuvante)" Then
            PictureBox3.Image = My.Resources._2016ben_bloodline_coa
            PictureBox3.Visible = True
        End If
        If CheckBox1.Text = "2015- Tony Hale por Veep (coadjuvante)" Then
            PictureBox3.Image = My.Resources._2015tony_veep_coa
            PictureBox3.Visible = True
        End If
        If CheckBox1.Text = "2015- Peter Dinklage por Game of Thrones (coadjuvante)" Then
            PictureBox3.Image = My.Resources._2015peter_game_coa
            PictureBox3.Visible = True
        End If
        If CheckBox1.Text = "2014- Aaron Paul por Breaking Bad (coadjuvante)" Then
            PictureBox3.Image = My.Resources._2014aaron_breaking_coa
            PictureBox3.Visible = True
        End If
        If CheckBox1.Text = "2014- Ty Burrell por Modern Family (coadjuvante)" Then
            PictureBox3.Image = My.Resources._2014ty_modern_coa
            PictureBox3.Visible = True
        End If
        If CheckBox1.Text = "2013- Bobby Cannavale por Boardwalk Empire (coadjuvante)" Then
            PictureBox3.Image = My.Resources._2013bobby_boardwalk_coa
            PictureBox3.Visible = True
        End If
        If CheckBox1.Text = "2013- Tony Hale por Veep (coadjuvante)" Then
            PictureBox3.Image = My.Resources._2013tony_veep_coa
            PictureBox3.Visible = True
        End If
        If CheckBox1.Checked = False Then
            PictureBox3.Visible = False
        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Text = "2016- Jeffrey Tambor por Transparent (protagonista)" Then
            PictureBox3.Image = My.Resources._2016jeffrey_transparent_prot
            PictureBox3.Visible = True
        End If
        If CheckBox2.Text = "2016- Rami Malek por Mr. Robot(protagonista)" Then
            PictureBox3.Image = My.Resources._2016rami_robot_prot
            PictureBox3.Visible = True
        End If
        If CheckBox2.Text = "2015- Jon Hamm por Mad Men (protagonista)" Then
            PictureBox3.Image = My.Resources._2015jon_madmen_prot
            PictureBox3.Visible = True
        End If
        If CheckBox2.Text = "2015- Jeffrey Tambor por Transparent (protagonista)" Then
            PictureBox3.Image = My.Resources._2015jeffrey_transparent_prot
            PictureBox3.Visible = True
        End If
        If CheckBox2.Text = "2014- Bryan Cranston por Breaking Bad (protagonista)" Then
            PictureBox3.Image = My.Resources._2014bryan_breaking_prot
            PictureBox3.Visible = True
        End If
        If CheckBox2.Text = "2014- Jim Parsons por The Big Bang Theory (protagonista)" Then
            PictureBox3.Image = My.Resources._2014jim_bigbang_prot
            PictureBox3.Visible = True
        End If
        If CheckBox2.Text = "2013- Jim Parsons por Big Bang Theory (protagonista)" Then
            PictureBox3.Image = My.Resources._2013jim_bigbang_prot
            PictureBox1.Visible = True
        End If
        If CheckBox2.Text = "2013- Jeff Daniels por The Newsroom (protagonista)" Then
            PictureBox3.Image = My.Resources._2013jeff_newsroom_prot
            PictureBox3.Visible = True
        End If
        If CheckBox2.Checked = False Then
            PictureBox3.Visible = False
        End If


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Text = "2016- Kate McKinnon por Saturday Night Live (coadjuvante)  " Then
            PictureBox1.Image = My.Resources._2016kate_saturday_coa
        ElseIf RadioButton2.Text = "2016- Maggie Smith por Downton Abbey (coadjuvante)" Then
            PictureBox1.Image = My.Resources._2016maggie_abbey_coa
        ElseIf RadioButton2.Text = "2015- Julia Louis-Dreyfus por Veep (protagonista) " Then
            PictureBox1.Image = My.Resources._2015julia_veep_prot
        ElseIf RadioButton2.Text = "2015- Viola Davis por How to Get Away With Murder (protagonista) " Then
            PictureBox1.Image = My.Resources._2015viola_murder_prot
        ElseIf RadioButton2.Text = "2014- Julianna Margulies por The Good Wife (protagonista) " Then
            PictureBox1.Image = My.Resources._2014julianna_wife_prot
        ElseIf RadioButton2.Text = "2014- Julia Louis-Dreyfus por Veep (protagonista) " Then
            PictureBox1.Image = My.Resources._2014julia_veep_prot
        ElseIf RadioButton2.Text = "2013- Claire Danes por Homeland (protagonista) " Then
            PictureBox1.Image = My.Resources._2013claire_homeland_prot
        ElseIf RadioButton2.Text = "2013- Julia Louis-Dreyfus por Veep (protagonista) " Then
            PictureBox1.Image = My.Resources._2013julia_veep_prot
        End If
    End Sub


End Class
