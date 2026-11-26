Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports MySql.Data.MySqlClient

Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public table As New DataTable

    ' Global session variables
    Public currentUser As String = ""
    Public currentRole As String = ""
    Public isLoggedIn As Boolean = False
    Public selectedPetID As String = "1"

    ' XAMPP MySQL / phpMyAdmin connection string
    Public connectionString As String = "server=localhost; username=root; password=; database=gentripets_db; SslMode=Disabled;"

    Sub openCon()
        If con.State = ConnectionState.Open OrElse con.State = ConnectionState.Broken Then
            con.Close()
        End If
        con.ConnectionString = connectionString
        con.Open()
    End Sub

    ' Helper to get pet photo from images folder or generate a clean placeholder
    Function GetPetPhoto(petName As String, species As String, width As Integer, height As Integer) As Image
        Dim safeName As String = petName.ToLower().Trim()
        Dim folderPath As String = Path.Combine(Application.StartupPath, "images")
        Dim jpgPath As String = Path.Combine(folderPath, safeName & ".jpg")
        Dim pngPath As String = Path.Combine(folderPath, safeName & ".png")

        Dim filePath As String = ""
        If File.Exists(jpgPath) Then
            filePath = jpgPath
        ElseIf File.Exists(pngPath) Then
            filePath = pngPath
        End If

        If filePath <> "" Then
            Try
                Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                    Using srcImg As Image = Image.FromStream(fs)
                        ' Fit whole image inside target box without cropping
                        Dim bmp As New Bitmap(width, height)
                        Using g As Graphics = Graphics.FromImage(bmp)
                            g.InterpolationMode = InterpolationMode.HighQualityBicubic
                            g.SmoothingMode = SmoothingMode.AntiAlias
                            g.Clear(Color.FromArgb(240, 244, 240))

                            Dim scaleX As Double = width / CDbl(srcImg.Width)
                            Dim scaleY As Double = height / CDbl(srcImg.Height)
                            Dim scale As Double = Math.Min(scaleX, scaleY)

                            Dim drawW As Integer = CInt(Math.Floor(srcImg.Width * scale))
                            Dim drawH As Integer = CInt(Math.Floor(srcImg.Height * scale))
                            Dim offsetX As Integer = (width - drawW) \ 2
                            Dim offsetY As Integer = (height - drawH) \ 2

                            g.DrawImage(srcImg, offsetX, offsetY, drawW, drawH)
                        End Using
                        Return bmp
                    End Using
                End Using
            Catch
            End Try
        End If

        ' Fallback placeholder (no Pet.vb class needed)
        Return CreatePlaceholderPhoto(petName, species, width, height)
    End Function

    ' Generic placeholder image drawn from database pet name and species
    Function CreatePlaceholderPhoto(petName As String, species As String, width As Integer, height As Integer) As Image
        Dim bmp As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias

            Dim bgTop As Color = Color.FromArgb(235, 243, 236)
            Dim bgBottom As Color = Color.FromArgb(205, 225, 208)
            Dim iconText As String = "??"

            If species = "Dog" Then
                bgTop = Color.FromArgb(240, 245, 235)
                bgBottom = Color.FromArgb(210, 230, 205)
                iconText = "??"
            ElseIf species = "Cat" Then
                bgTop = Color.FromArgb(245, 238, 245)
                bgBottom = Color.FromArgb(228, 215, 235)
                iconText = "??"
            ElseIf species = "Small Pet" Then
                bgTop = Color.FromArgb(254, 248, 235)
                bgBottom = Color.FromArgb(245, 230, 200)
                iconText = "??"
            End If

            Using br As New LinearGradientBrush(New Rectangle(0, 0, width, height), bgTop, bgBottom, LinearGradientMode.Vertical)
                g.FillRectangle(br, 0, 0, width, height)
            End Using

            Using iconFont As New Font("Segoe UI Emoji", 24, FontStyle.Regular)
                Dim sf As New StringFormat() With {
                    .Alignment = StringAlignment.Center,
                    .LineAlignment = StringAlignment.Center
                }
                g.DrawString(iconText, iconFont, Brushes.Black, New RectangleF(0, 0, width, height), sf)
            End Using

            Using borderPen As New Pen(Color.FromArgb(215, 225, 215), 1)
                g.DrawRectangle(borderPen, 0, 0, width - 1, height - 1)
            End Using
        End Using
        Return bmp
    End Function

    ' Helper to build short description from database fields
    Function GetPetDescription(petName As String, breed As String, species As String) As String
        Return petName & " is a loving " & breed & " (" & species & ") looking for a warm forever home."
    End Function

    ' Helper to build 3 short trait tags from database fields
    Function GetPetTags(petName As String, vaccinated As String, temp As Integer, cling As Integer) As List(Of String)
        Dim tags As New List(Of String)
        If temp <= 2 Then
            tags.Add("Chill")
        ElseIf temp >= 4 Then
            tags.Add("Playful")
        Else
            tags.Add("Balanced")
        End If

        If cling <= 2 Then
            tags.Add("Affectionate")
        Else
            tags.Add("Independent")
        End If

        If vaccinated.ToLower() = "yes" Then
            tags.Add("Vaccinated")
        End If
        Return tags
    End Function

    ' Helper to classify Age Group from age string
    Function GetAgeGroup(ageText As String) As String
        Dim low As String = ageText.ToLower()
        If low.Contains("month") OrElse low.Contains("week") Then
            Return "Puppy/Kitten"
        End If
        If low.Contains("1 year") OrElse low.Contains("1.5") OrElse low.Contains("2 year") Then
            Return "Young"
        End If
        If low.Contains("7") OrElse low.Contains("8") OrElse low.Contains("9") OrElse low.Contains("10") OrElse low.Contains("11") OrElse low.Contains("12") Then
            Return "Senior"
        End If
        Return "Adult"
    End Function
End Module
