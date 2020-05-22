Public Class FormNuevoViaje

    Function validacion() As Boolean
        Dim aux As Integer
        Integer.TryParse(txt_importe.Text, aux)
        If txt_direccionorigen.Text <> "" Then
            If txt_direcciondestino.Text <> "" Then
                If txt_importe.Text <> "" And aux > 0 Then
                    Return True
                Else
                    MessageBox.Show("Error en Importe")
                End If
            Else
                MessageBox.Show("Error en Direccion Destino")
            End If
        Else
            MessageBox.Show("Error en Direccion Origen")
        End If
    End Function

    Function validarSQL() As Boolean
        Dim sql As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql = "SELECT * FROM Viajes WHERE (IdRemisero = '" & cmb_idremisero.SelectedValue & "') AND (IdPasajero = '" & cmb_idpasajero.SelectedValue & "') AND (FechaViaje = '" & FechaInvertida(dtp_fechaviaje.Value).ToString & "')"
        ConsultarDatos(sql, tabla)
        If (tabla.Rows.Count = 0) Then
            Return True
        End If
        Return False
    End Function
    Private Sub FormNuevoViaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        dtp_fechaviaje.MaxDate = Date.Today

        Dim sql1 As String
        Dim sql2 As String
        Dim tabla As DataTable
        tabla = New DataTable

        sql1 = "SELECT IdRemisero,Apellido FROM Remiseros WHERE Activo = 1"
        ConsultarDatos(sql1, tabla)
        cmb_idremisero.DataSource = tabla
        cmb_idremisero.DisplayMember = "Apellido"   'lo q muestra
        cmb_idremisero.ValueMember = "IdRemisero"   'valor 
        cmb_idremisero.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_idremisero.SelectedIndex = 0

        sql2 = "SELECT IdPasajero,Apellido FROM Pasajeros "
        ConsultarDatos(sql2, tabla)
        cmb_idpasajero.DataSource = tabla
        cmb_idpasajero.DisplayMember = "Apellido"
        cmb_idpasajero.ValueMember = "IdPasajero"
        cmb_idpasajero.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_idpasajero.SelectedIndex = 0

        rb_exclusivo.Checked = True
        cb_anulado.Checked = False
    End Sub

    Private Sub Btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Dim sql As String
        Dim TipoDeServicio As String
        Dim Anulado As Integer

        If rb_ejecutivo.Checked = True Then
            TipoDeServicio = "Ejecutivo"
        ElseIf rb_exclusivo.Checked = True Then
            TipoDeServicio = "Exclusivo"
        Else
            TipoDeServicio = "Compartido"
        End If

        If cb_anulado.Checked = False Then
            Anulado = 0
        Else
            Anulado = 1
        End If

        If validacion() = True Then
            If validarSQL() = True Then
                sql = "INSERT [dbo].[Viajes] ([IdRemisero], [IdPasajero], [FechaViaje], [DireccionOrigen], [DireccionDestino], [Importe], [TipoDeServicio], [Anulado]) 
                        VALUES ('" & cmb_idremisero.SelectedValue & "' , '" & cmb_idpasajero.SelectedValue & "' , '" & FechaInvertida(dtp_fechaviaje.Value).ToString & "' , '" & txt_direccionorigen.Text & "' , '" & txt_direcciondestino.Text & "' , '" & txt_importe.Text & "' , '" & TipoDeServicio & "' , '" & Anulado & "')"
                AltaBajaModific(sql)
                MessageBox.Show("Alta Viaje Correcto")
                txt_direccionorigen.Text = ""
                txt_direcciondestino.Text = ""
                txt_importe.Text = ""
                cb_anulado.Checked = False
            Else
                MessageBox.Show("Error Existencia Viaje")
            End If
        End If
    End Sub

    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
    End Sub
End Class