Imports System.Data.SqlClient
Imports System.Text


Public Class frm_HistoriaClinica


    Public frm_refer_main As Frm_Main
    Public pac_id As Integer
    Dim opr_test As New Cls_Test()
    Dim opr_pedido As New Cls_Pedido()
    Dim opr_agenda As New Cls_Agenda()
    Private lng_pac_id As Long
    Public var_Convenio As String
    Public var_Fecha As Date
    Public var_Lab As String
    Public var_Servicio As String
    Public var_PrePost As String
    Public Var_NumAux As String
    Public Var_Ped_id As Long
    Public opr_res As New Cls_Resultado()

    Dim secuencia As String()
    Dim sec_nombre As String = Nothing
    Dim sec_inicio As Integer
    Dim sec_fin As Integer

    Dim arr_datoshc As String()
    Dim arr_datosDemog As String()
    Dim var_hic_cli As Integer
    Private WithEvents dtt_Historico As New DataTable("Registros")
    Private WithEvents dtt_conHist As New DataTable("Registros")


    Public Function ExisteForm(ByVal str_frmbusca As String) As Boolean
        Dim ctl As System.Windows.Forms.Form
        ExisteForm = False
        For Each ctl In Me.MdiChildren
            If ctl.Name = str_frmbusca Then
                ExisteForm = True
                Exit Function
            End If
        Next
    End Function



    Private Sub frm_HistoriaClinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If IsNothing(frm_refer_main) Then frm_refer_main = Me.ParentForm

        Panel1.AutoScroll = True
        Panel1.VerticalScroll.Visible = True
        Panel1.HorizontalScroll.Visible = True

        opr_pedido.ContarPedido()

        
        cmb_Campo.Text = "<TODOS>"

        secuencia = Split(var_Convenio, "/")

        sec_nombre = Trim(secuencia(0).ToString)
        sec_inicio = CInt(secuencia(1).ToString)
        sec_fin = CInt(secuencia(2).ToString)

        arr_datosDemog = Split(opr_pedido.LeerDemografico(pac_id), "º")
        If UBound(arr_datosDemog) > 1 Then
            lbl_DDoc.Text = arr_datosDemog(1)
            lbl_DApellidos.Text = arr_datosDemog(2)
            lbl_DNombres.Text = arr_datosDemog(3)
            lbl_DDirec.Text = arr_datosDemog(4)
            lbl_DFono.Text = arr_datosDemog(5)
            lbl_DMail.Text = arr_datosDemog(6)
            lbl_DGenero.Text = arr_datosDemog(7)
            lbl_DFecNac.Text = arr_datosDemog(8)
            lbl_DObs.Text = arr_datosDemog(9)
            lbl_DPoliza.Text = arr_datosDemog(10)
            lbl_DPais.Text = arr_datosDemog(11)
            lbl_pais.Text = arr_datosDemog(11)

            lbl_DProvincia.Text = arr_datosDemog(12)

            lbl_DCiudad.Text = arr_datosDemog(13)
            lbl_ciudad.Text = arr_datosDemog(13)

            lbl_DProfesion.Text = arr_datosDemog(14)

        End If

        If opr_pedido.ExisteHistoriaClinica(pac_id) > 0 Then
            Dim i = 0
            Dim arr_datosSV As String()
            Dim arr_datosEF As String()

            arr_datoshc = Split(opr_pedido.LeerHistoriaClinica(pac_id), "º")

            VisualizaGrids()

            If UBound(arr_datoshc) > 1 Then
                var_hic_cli = arr_datoshc(0)
                cmb_zona.Text = arr_datoshc(3)
                txt_HOcupacion.Text = arr_datoshc(4)
                txt_hcHobbies.Text = arr_datoshc(5)
                txt_hcInmun.Text = arr_datoshc(6)
                cmb_HabTox.Text = arr_datoshc(7)
                txt_HabiTox_Otro.Text = arr_datoshc(8)
                txt_TiemHab.Text = arr_datoshc(9)
                txt_hc_MotConsulta.Text = arr_datoshc(10)

                txt_HisEnfeAct.Text = arr_datoshc(11)
                txt_HTToAnam.Text = arr_datoshc(12)
                txt_HSeg.Text = arr_datoshc(13)
                txt_HPsicoS.Text = arr_datoshc(14)
                txt_hcEvolInicio.Text = arr_datoshc(15)
                cmb_APP.Text = arr_datoshc(16)
                cmb_EnfToroideas.Text = arr_datoshc(17)
                txt_Cancer.Text = arr_datoshc(18)
                txt_EnferInfecc.Text = arr_datoshc(19)
                txt_OtrasEnfer.Text = arr_datoshc(20)

                txt_TTo_Antec.Text = arr_datoshc(21)
                txt_Cirugias.Text = arr_datoshc(22)

                '23 DESENCADENANTES
                Dim arreglo = Split(arr_datoshc(23), "|")
                Dim param As String()
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "OTROS"
                            If param(1) = 1 Then
                                chk1_OTROS.Checked = True
                            Else
                                chk1_OTROS.Checked = False
                            End If
                        Case "Polvo"
                            If param(1) = 1 Then
                                chk1_Polvo.Checked = True
                            Else
                                chk1_Polvo.Checked = False
                            End If
                        Case "Humo"
                            If param(1) = 1 Then
                                chk1_Humo.Checked = True
                            Else
                                chk1_Humo.Checked = False
                            End If
                        Case "Olores fuertes"
                            If param(1) = 1 Then
                                chk1_Olores.Checked = True
                            Else
                                chk1_Olores.Checked = False
                            End If
                        Case "Frio"
                            If param(1) = 1 Then
                                chk1_Frio.Checked = True
                            Else
                                chk1_Frio.Checked = False
                            End If
                        Case "Humedad"
                            If param(1) = 1 Then
                                chk1_Humedad.Checked = True
                            Else
                                chk1_Humedad.Checked = False
                            End If
                        Case "Calor"
                            If param(1) = 1 Then
                                chk1_Calor.Checked = True
                            Else
                                chk1_Calor.Checked = False
                            End If
                        Case "Alimentos"
                            If param(1) = 1 Then
                                chk1_Alimentos.Checked = True
                            Else
                                chk1_Alimentos.Checked = False
                            End If
                    End Select
                Next

                '24 DESENCADENANTES OTRO
                txt_DesOtro.Text = arr_datoshc(24)


                '25 MENSTRUACION
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(25), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Cólico"
                            If param(1) = 1 Then
                                chkM_Colico.Checked = True
                            Else
                                chkM_Colico.Checked = False
                            End If
                        Case "Cefalea"
                            If param(1) = 1 Then
                                chkM_Cefalea.Checked = True
                            Else
                                chkM_Cefalea.Checked = False
                            End If
                        Case "Migraña"
                            If param(1) = 1 Then
                                chkM_Migrana.Checked = True
                            Else
                                chkM_Migrana.Checked = False
                            End If
                        Case "TOMA"
                            If param(1) = 1 Then
                                chkM_Toma.Checked = True
                                'txt_MenstruToma.Text = param(2)
                            Else
                                chkM_Toma.Checked = False
                            End If
                    End Select
                Next

                '26 MENSTRUACION TOMA
                txt_MenstruToma.Text = arr_datoshc(26)

                '27 SINTOMAS OJOS
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(27), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Lagrimeo"
                            If param(1) = 1 Then
                                chkO_Lagrimeo.Checked = True
                            Else
                                chkO_Lagrimeo.Checked = False
                            End If
                        Case "Conjuntivitis"
                            If param(1) = 1 Then
                                chkO_Conjuntivitis.Checked = True
                            Else
                                chkO_Conjuntivitis.Checked = False
                            End If
                        Case "Enrojecimiento"
                            If param(1) = 1 Then
                                chkO_Enrojecimiento.Checked = True
                            Else
                                chkO_Enrojecimiento.Checked = False
                            End If
                    End Select
                Next

                '28 SINTOMAS NARIZ
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(28), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Rinorrea"
                            If param(1) = 1 Then
                                chkSN_Rinorrea.Checked = True
                            Else
                                chkSN_Rinorrea.Checked = False
                            End If
                        Case "Acuosa"
                            If param(1) = 1 Then
                                chkSN_Acuosa.Checked = True
                            Else
                                chkSN_Acuosa.Checked = False
                            End If
                        Case "Densa"
                            If param(1) = 1 Then
                                chkSN_Densa.Checked = True
                            Else
                                chkSN_Densa.Checked = False
                            End If
                        Case "Purulenta"
                            If param(1) = 1 Then
                                chkSN_Purulenta.Checked = True
                            Else
                                chkSN_Purulenta.Checked = False
                            End If
                        Case "Resequedad"
                            If param(1) = 1 Then
                                chkSN_Resequedad.Checked = True
                            Else
                                chkSN_Resequedad.Checked = False
                            End If
                        Case "Obtrucc. Nasal"
                            If param(1) = 1 Then
                                chkSN_ObtNasal.Checked = True
                            Else
                                chkSN_ObtNasal.Checked = False
                            End If
                    End Select
                Next

                '29 CRISIS DE ESTORNUDOS
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(29), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "No"
                            If param(1) = 1 Then
                                chkCE_No.Checked = True
                            Else
                                chkCE_No.Checked = False
                            End If
                        Case "Raro"
                            If param(1) = 1 Then
                                chkCE_Raro.Checked = True
                            Else
                                chkCE_Raro.Checked = False
                            End If
                        Case "Frecuente"
                            If param(1) = 1 Then
                                chkCE_Frecuente.Checked = True
                            Else
                                chkCE_Frecuente.Checked = False
                            End If
                    End Select
                Next


                '30 BOCA
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(30), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Resp. Oral"
                            If param(1) = 1 Then
                                chkB_RespOral.Checked = True
                            Else
                                chkB_RespOral.Checked = False
                            End If
                        Case "Ronca"
                            If param(1) = 1 Then
                                chkB_Ronca.Checked = True
                            Else
                                chkB_Ronca.Checked = False
                            End If
                        Case "Duerme boca abierta"
                            If param(1) = 1 Then
                                chkB_DurmeBAbierta.Checked = True
                            Else
                                chkB_DurmeBAbierta.Checked = False
                            End If
                    End Select
                Next


                '31 PLURITO
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(31), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Nariz"
                            If param(1) = 1 Then
                                chk3_Nariz.Checked = True
                            Else
                                chk3_Nariz.Checked = False
                            End If
                        Case "Ojos"
                            If param(1) = 1 Then
                                chk3_Ojos.Checked = True
                            Else
                                chk3_Ojos.Checked = False
                            End If
                        Case "Garganta"
                            If param(1) = 1 Then
                                chk3_Garganta.Checked = True
                            Else
                                chk3_Garganta.Checked = False
                            End If
                        Case "Oidos"
                            If param(1) = 1 Then
                                chk3_Oidos.Checked = True
                            Else
                                chk3_Oidos.Checked = False
                            End If
                        Case "Palatinos"
                            If param(1) = 1 Then
                                chk3_Palatinos.Checked = True
                            Else
                                chk3_Palatinos.Checked = False
                            End If
                        Case "Edema palpebral"
                            If param(1) = 1 Then
                                chk3_EdemPalpe.Checked = True
                            Else
                                chk3_EdemPalpe.Checked = False
                            End If
                        Case "Descamacion borde palpebral"
                            If param(1) = 1 Then
                                chk3_DescaPal.Checked = True
                            Else
                                chk3_DescaPal.Checked = False
                            End If
                    End Select
                Next


                '32 TOS
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(32), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Dia"
                            If param(1) = 1 Then
                                chk5_Dia.Checked = True
                            Else
                                chk5_Dia.Checked = False
                            End If
                        Case "Noche"
                            If param(1) = 1 Then
                                chk5_Noche.Checked = True
                            Else
                                chk5_Noche.Checked = False
                            End If
                        Case "Seca"
                            If param(1) = 1 Then
                                chk5_Seca.Checked = True
                            Else
                                chk5_Seca.Checked = False
                            End If
                        Case "Con flema"
                            If param(1) = 1 Then
                                chk5_Flema.Checked = True
                            Else
                                chk5_Flema.Checked = False
                            End If
                        Case "Opr. Toraxica"
                            If param(1) = 1 Then
                                chk5_OpToraxica.Checked = True
                            Else
                                chk5_OpToraxica.Checked = False
                            End If
                        Case "Ejercicio"
                            If param(1) = 1 Then
                                chk5_Ejercicio.Checked = True
                            Else
                                chk5_Ejercicio.Checked = False
                            End If
                    End Select
                Next

                '33 ACC ASMATICOS
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(33), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Diurnos"
                            If param(1) = 1 Then
                                chk4_Diurnos.Checked = True
                            Else
                                chk4_Diurnos.Checked = False
                            End If
                        Case "Nocturnos"
                            If param(1) = 1 Then
                                chk4_Nocturnos.Checked = True
                            Else
                                chk4_Nocturnos.Checked = False
                            End If
                        Case "Roncus"
                            If param(1) = 1 Then
                                chk4_Roncus.Checked = True
                            Else
                                chk4_Roncus.Checked = False
                            End If
                        Case "Sibilanc"
                            If param(1) = 1 Then
                                chk4_Sibilanc.Checked = True
                            Else
                                chk4_Sibilanc.Checked = False
                            End If
                        Case "Disnea"
                            If param(1) = 1 Then
                                chk4_Disnea.Checked = True
                            Else
                                chk4_Disnea.Checked = False
                            End If
                    End Select
                Next


                '34 PIEL
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(34), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Habones"
                            If param(1) = 1 Then
                                chk6_Habones.Checked = True
                            Else
                                chk6_Habones.Checked = False
                            End If
                        Case "Dermografismo"
                            If param(1) = 1 Then
                                chk6_Demografismo.Checked = True
                            Else
                                chk6_Demografismo.Checked = False
                            End If
                        Case "Eccema pliegues"
                            If param(1) = 1 Then
                                chk6_EccPliegues.Checked = True
                            Else
                                chk6_EccPliegues.Checked = False
                            End If
                        Case "Edema"
                            If param(1) = 1 Then
                                chk6_Edema.Checked = True
                            Else
                                chk6_Edema.Checked = False
                            End If
                        Case "Contacto"
                            If param(1) = 1 Then
                                chk6_Contacto.Checked = True
                            Else
                                chk6_Contacto.Checked = False
                            End If
                        Case "Xerosis"
                            If param(1) = 1 Then
                                chk6_Xerosis.Checked = True
                            Else
                                chk6_Xerosis.Checked = False
                            End If
                        Case "Liquenificacion"
                            If param(1) = 1 Then
                                chk6_Liqunif.Checked = True
                            Else
                                chk6_Liqunif.Checked = False
                            End If
                        Case "Papulas"
                            If param(1) = 1 Then
                                chk6_Papulas.Checked = True
                            Else
                                chk6_Papulas.Checked = False
                            End If
                        Case "Manchas"
                            If param(1) = 1 Then
                                chk6_Manchas.Checked = True
                            Else
                                chk6_Manchas.Checked = False
                            End If
                        Case "Despigmentacion"
                            If param(1) = 1 Then
                                chk6_Despig.Checked = True
                            Else
                                chk6_Despig.Checked = False
                            End If
                        Case "Rash"
                            If param(1) = 1 Then
                                chk6_Rash.Checked = True
                            Else
                                chk6_Rash.Checked = False
                            End If
                        Case "Salpullidos"
                            If param(1) = 1 Then
                                chk6_Salpullidos.Checked = True
                            Else
                                chk6_Salpullidos.Checked = False
                            End If
                        Case "Placas"
                            If param(1) = 1 Then
                                chk6_Placas.Checked = True
                            Else
                                chk6_Placas.Checked = False
                            End If
                        Case "Otros"
                            If param(1) = 1 Then
                                chk6_Otros.Checked = True
                            Else
                                chk6_Otros.Checked = False
                            End If
                    End Select
                Next

                '35 PIEL CAMPO
                txt_PielOtros.Text = arr_datoshc(35)



                '36 DIGESTIVOS
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(36), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Acidez"
                            If param(1) = 1 Then
                                chkDig_Acidez.Checked = True
                            Else
                                chkDig_Acidez.Checked = False
                            End If
                        Case "Pirosis"
                            If param(1) = 1 Then
                                chkDig_Pirosis.Checked = True
                            Else
                                chkDig_Pirosis.Checked = False
                            End If
                        Case "Flatos"
                            If param(1) = 1 Then
                                chkDig_Flatos.Checked = True
                            Else
                                chkDig_Flatos.Checked = False
                            End If
                        Case "Dolor Abdominal"
                            If param(1) = 1 Then
                                chkDig_DolAbdo.Checked = True
                            Else
                                chkDig_DolAbdo.Checked = False
                            End If
                        Case "Vomito"
                            If param(1) = 1 Then
                                chkDig_Vomito.Checked = True
                            Else
                                chkDig_Vomito.Checked = False
                            End If
                        Case "Diarrea"
                            If param(1) = 1 Then
                                chkDig_Diarrea.Checked = True
                            Else
                                chkDig_Diarrea.Checked = False
                            End If
                        Case "Regurgitacion"
                            If param(1) = 1 Then
                                chkDig_Regurgit.Checked = True
                            Else
                                chkDig_Regurgit.Checked = False
                            End If
                        Case "Intolerancia alimentaria"
                            If param(1) = 1 Then
                                chkDig_IntolAlim.Checked = True
                            Else
                                chkDig_IntolAlim.Checked = False
                            End If
                    End Select
                Next


                '37 DIGESTIVOS ALIMENTORIOS
                txt_DigIntolerAlim.Text = arr_datoshc(37)

                '38 RAM
                txt_Ram.Text = Trim(arr_datoshc(38))


                '39 ASMA 
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(39), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "MADRE"
                            If param(1) = 1 Then
                                chk_Asm1.Checked = True
                            Else
                                chk_Asm1.Checked = False
                            End If
                        Case "FAM. MATERNA"
                            If param(1) = 1 Then
                                chk_Asm2.Checked = True
                            Else
                                chk_Asm2.Checked = False
                            End If
                        Case "PADRE"
                            If param(1) = 1 Then
                                chk_Asm3.Checked = True
                            Else
                                chk_Asm3.Checked = False
                            End If
                        Case "FAM. PATERNA"
                            If param(1) = 1 Then
                                chk_Asm4.Checked = True
                            Else
                                chk_Asm4.Checked = False
                            End If
                        Case "HERMANOS"
                            If param(1) = 1 Then
                                chk_Asm5.Checked = True
                            Else
                                chk_Asm5.Checked = False
                            End If
                        Case "HIJOS"
                            If param(1) = 1 Then
                                chk_Asm6.Checked = True
                            Else
                                chk_Asm6.Checked = False
                            End If
                        Case "OTRO"
                            If param(1) = 1 Then
                                chk_Asm7.Checked = True
                            Else
                                chk_Asm7.Checked = False
                            End If
                    End Select
                Next

                '40 ANT FAM RIÑITIS
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(40), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "MADRE"
                            If param(1) = 1 Then
                                chk_Rin1.Checked = True
                            Else
                                chk_Rin1.Checked = False
                            End If
                        Case "FAM. MATERNA"
                            If param(1) = 1 Then
                                chk_Rin2.Checked = True
                            Else
                                chk_Rin2.Checked = False
                            End If
                        Case "PADRE"
                            If param(1) = 1 Then
                                chk_Rin3.Checked = True
                            Else
                                chk_Rin3.Checked = False
                            End If
                        Case "FAM. PATERNA"
                            If param(1) = 1 Then
                                chk_Rin4.Checked = True
                            Else
                                chk_Rin4.Checked = False
                            End If
                        Case "HERMANOS"
                            If param(1) = 1 Then
                                chk_Rin5.Checked = True
                            Else
                                chk_Rin5.Checked = False
                            End If
                        Case "HIJOS"
                            If param(1) = 1 Then
                                chk_Rin6.Checked = True
                            Else
                                chk_Rin6.Checked = False
                            End If
                        Case "OTRO"
                            If param(1) = 1 Then
                                chk_Rin7.Checked = True
                            Else
                                chk_Rin6.Checked = False
                            End If
                    End Select
                Next

                '41 ANT FAM URTICARIA
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(41), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "MADRE"
                            If param(1) = 1 Then
                                chk_Urt1.Checked = True
                            Else
                                chk_Urt1.Checked = False
                            End If
                        Case "FAM. MATERNA"
                            If param(1) = 1 Then
                                chk_Urt2.Checked = True
                            Else
                                chk_Urt2.Checked = False
                            End If
                        Case "PADRE"
                            If param(1) = 1 Then
                                chk_Urt6.Checked = True
                            Else
                                chk_Urt6.Checked = False
                            End If
                        Case "FAM. PATERNA"
                            If param(1) = 1 Then
                                chk_Urt3.Checked = True
                            Else
                                chk_Urt3.Checked = False
                            End If
                        Case "HERMANOS"
                            If param(1) = 1 Then
                                chk_Urt5.Checked = True
                            Else
                                chk_Urt5.Checked = False
                            End If
                        Case "HIJOS"
                            If param(1) = 1 Then
                                chk_Urt4.Checked = True
                            Else
                                chk_Urt4.Checked = False
                            End If
                        Case "OTRO"
                            If param(1) = 1 Then
                                chk_Urt7.Checked = True
                            Else
                                chk_Urt7.Checked = False
                            End If
                    End Select
                Next

                '42 ANT FAM ECCEMA
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(42), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "MADRE"
                            If param(1) = 1 Then
                                chk_Ecc1.Checked = True
                            Else
                                chk_Ecc1.Checked = False
                            End If
                        Case "FAM. MATERNA"
                            If param(1) = 1 Then
                                chk_Ecc2.Checked = True
                            Else
                                chk_Ecc2.Checked = False
                            End If
                        Case "PADRE"
                            If param(1) = 1 Then
                                chk_Ecc3.Checked = True
                            Else
                                chk_Ecc3.Checked = False
                            End If
                        Case "FAM. PATERNA"
                            If param(1) = 1 Then
                                chk_Ecc4.Checked = True
                            Else
                                chk_Ecc4.Checked = False
                            End If
                        Case "HERMANOS"
                            If param(1) = 1 Then
                                chk_Ecc5.Checked = True
                            Else
                                chk_Ecc5.Checked = False
                            End If
                        Case "HIJOS"
                            If param(1) = 1 Then
                                chk_Ecc6.Checked = True
                            Else
                                chk_Ecc6.Checked = False
                            End If
                        Case "OTRO"
                            If param(1) = 1 Then
                                chk_Ecc7.Checked = True
                            Else
                                chk_Ecc7.Checked = False
                            End If
                    End Select
                Next

                '43 ANT FAM CONJUNTIVITIS
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(43), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "MADRE"
                            If param(1) = 1 Then
                                chk_Con1.Checked = True
                            Else
                                chk_Con1.Checked = False
                            End If
                        Case "FAM. MATERNA"
                            If param(1) = 1 Then
                                chk_Con2.Checked = True
                            Else
                                chk_Con2.Checked = False
                            End If
                        Case "PADRE"
                            If param(1) = 1 Then
                                chk_Con3.Checked = True
                            Else
                                chk_Con3.Checked = False
                            End If
                        Case "FAM. PATERNA"
                            If param(1) = 1 Then
                                chk_Con4.Checked = True
                            Else
                                chk_Con4.Checked = False
                            End If
                        Case "HERMANOS"
                            If param(1) = 1 Then
                                chk_Con5.Checked = True
                            Else
                                chk_Con5.Checked = False
                            End If
                        Case "HIJOS"
                            If param(1) = 1 Then
                                chk_Con6.Checked = True
                            Else
                                chk_Con6.Checked = False
                            End If
                        Case "OTRO"
                            If param(1) = 1 Then
                                chk_Con7.Checked = True
                            Else
                                chk_Con7.Checked = False
                            End If
                    End Select
                Next

                '44 ANT FAM DROGAS
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(44), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "MADRE"
                            If param(1) = 1 Then
                                chk_Dro1.Checked = True
                            Else
                                chk_Dro1.Checked = False
                            End If
                        Case "FAM. MATERNA"
                            If param(1) = 1 Then
                                chk_Dro2.Checked = True
                            Else
                                chk_Dro2.Checked = False
                            End If
                        Case "PADRE"
                            If param(1) = 1 Then
                                chk_Dro3.Checked = True
                            Else
                                chk_Dro3.Checked = False
                            End If
                        Case "FAM. PATERNA"
                            If param(1) = 1 Then
                                chk_Dro4.Checked = True
                            Else
                                chk_Dro4.Checked = False
                            End If
                        Case "HERMANOS"
                            If param(1) = 1 Then
                                chk_Dro5.Checked = True
                            Else
                                chk_Dro5.Checked = False
                            End If
                        Case "HIJOS"
                            If param(1) = 1 Then
                                chk_Dro6.Checked = True
                            Else
                                chk_Dro6.Checked = False
                            End If
                        Case "OTRO"
                            If param(1) = 1 Then
                                chk_Dro7.Checked = True
                            Else
                                chk_Dro7.Checked = False
                            End If
                    End Select
                Next

                '45 ANT FAM MIGRAÑA
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(45), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "MADRE"
                            If param(1) = 1 Then
                                chk_Mig6.Checked = True
                            Else
                                chk_Mig6.Checked = False
                            End If
                        Case "FAM. MATERNA"
                            If param(1) = 1 Then
                                chk_Mig1.Checked = True
                            Else
                                chk_Mig1.Checked = False
                            End If
                        Case "PADRE"
                            If param(1) = 1 Then
                                chk_Mig5.Checked = True
                            Else
                                chk_Mig5.Checked = False
                            End If
                        Case "FAM. PATERNA"
                            If param(1) = 1 Then
                                chk_Mig2.Checked = True
                            Else
                                chk_Mig2.Checked = False
                            End If
                        Case "HERMANOS"
                            If param(1) = 1 Then
                                chk_Mig4.Checked = True
                            Else
                                chk_Mig4.Checked = False
                            End If
                        Case "HIJOS"
                            If param(1) = 1 Then
                                chk_Mig3.Checked = True
                            Else
                                chk_Mig3.Checked = False
                            End If
                        Case "OTRO"
                            If param(1) = 1 Then
                                chk_Mig7.Checked = True
                            Else
                                chk_Mig7.Checked = False
                            End If
                    End Select
                Next


                '46 ANT FAM EDEMA
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(46), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "MADRE"
                            If param(1) = 1 Then
                                chk_Ede6.Checked = True
                            Else
                                chk_Ede6.Checked = False
                            End If
                        Case "FAM. MATERNA"
                            If param(1) = 1 Then
                                chk_Ede1.Checked = True
                            Else
                                chk_Ede1.Checked = False
                            End If
                        Case "PADRE"
                            If param(1) = 1 Then
                                chk_Ede5.Checked = True
                            Else
                                chk_Ede5.Checked = False
                            End If
                        Case "FAM. PATERNA"
                            If param(1) = 1 Then
                                chk_Ede2.Checked = True
                            Else
                                chk_Ede2.Checked = False
                            End If
                        Case "HERMANOS"
                            If param(1) = 1 Then
                                chk_Ede4.Checked = True
                            Else
                                chk_Ede4.Checked = False
                            End If
                        Case "HIJOS"
                            If param(1) = 1 Then
                                chk_Ede3.Checked = True
                            Else
                                chk_Ede3.Checked = False
                            End If
                        Case "OTRO"
                            If param(1) = 1 Then
                                chk_Ede7.Checked = True
                            Else
                                chk_Ede7.Checked = False
                            End If
                    End Select
                Next

                ''47 VACIO

                '48 ANTECE FAM OTRO
                txt_AntFamOtro.Text = arr_datoshc(48)


                '49 SIGNOS ESPECIALES 1
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(49), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "LENG. GEOGRAFICA"
                            If param(1) = 1 Then
                                chkSig_1.Checked = True
                            Else
                                chkSig_1.Checked = False
                            End If
                        Case "AMID. HIPER DERECHA"
                            If param(1) = 1 Then
                                chkSig_2.Checked = True
                            Else
                                chkSig_2.Checked = False
                            End If
                        Case "CRIPTIC."
                            If param(1) = 1 Then
                                chkSig_3.Checked = True
                            Else
                                chkSig_3.Checked = False
                            End If
                        Case "CON PUS"
                            If param(1) = 1 Then
                                chkSig_4.Checked = True
                            Else
                                chkSig_4.Checked = False
                            End If
                        Case "GANGLIOS"
                            If param(1) = 1 Then
                                chkSig_5.Checked = True
                            Else
                                chkSig_5.Checked = False
                            End If
                        Case "CONJUNTIVAS"
                            If param(1) = 1 Then
                                chkSig_6.Checked = True
                            Else
                                chkSig_6.Checked = False
                            End If
                        Case "S DE D MORGAN"
                            If param(1) = 1 Then
                                chkSig_7.Checked = True
                            Else
                                chkSig_7.Checked = False
                            End If
                        Case "S DARIER"
                            If param(1) = 1 Then
                                chkSig_8.Checked = True
                            Else
                                chkSig_8.Checked = False
                            End If
                        Case "SALUDO ALERGICO"
                            If param(1) = 1 Then
                                chkSig_9.Checked = True
                            Else
                                chkSig_9.Checked = False
                            End If
                    End Select
                Next

                '50 SIGNOS ESPECIALES 2
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(50), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "ESCROTAL"
                            If param(1) = 1 Then
                                chkSig2_1.Checked = True
                            Else
                                chkSig2_1.Checked = False
                            End If
                        Case "AMID. HIPER IZQUIERDA"
                            If param(1) = 1 Then
                                chkSig2_2.Checked = True
                            Else
                                chkSig2_2.Checked = False
                            End If
                        Case "IRREGULAR"
                            If param(1) = 1 Then
                                chkSig2_3.Checked = True
                            Else
                                chkSig2_3.Checked = False
                            End If
                        Case "LAGRIMEO"
                            If param(1) = 1 Then
                                chkSig2_4.Checked = True
                            Else
                                chkSig2_4.Checked = False
                            End If
                    End Select
                Next


                '51 ANT RESP. NORMAL
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(51), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Roncus"
                            If param(1) = 1 Then
                                chk7_Roncus.Checked = True
                            Else
                                chk7_Roncus.Checked = False
                            End If
                        Case "Sibilian"
                            If param(1) = 1 Then
                                chk7_Sibilian.Checked = True
                            Else
                                chk7_Sibilian.Checked = False
                            End If
                        Case "Tiraje"
                            If param(1) = 1 Then

                                chk7_Tiraje.Checked = True
                            Else
                                chk7_Tiraje.Checked = False
                            End If
                        Case "Tos"
                            If param(1) = 1 Then
                                chk7_Tos.Checked = True
                            Else
                                chk7_Tos.Checked = False
                            End If
                    End Select
                Next

                '52 ANT RESP. FORZADA
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(52), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Roncus"
                            If param(1) = 1 Then
                                chk8_Roncus.Checked = True
                            Else
                                chk8_Roncus.Checked = False
                            End If
                        Case "Sibilian"
                            If param(1) = 1 Then
                                chk8_Sibilian.Checked = True
                            Else
                                chk8_Sibilian.Checked = False
                            End If
                        Case "Tiraje"
                            If param(1) = 1 Then

                                chk8_Tiraje.Checked = True
                            Else
                                chk8_Tiraje.Checked = False
                            End If
                        Case "Tos"
                            If param(1) = 1 Then
                                chk8_Tos.Checked = True
                            Else
                                chk8_Tos.Checked = False
                            End If
                    End Select
                Next

                '53 ANT NARIZ
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(53), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Edema"
                            If param(1) = 1 Then
                                chk9_Edema.Checked = True
                            Else
                                chk9_Edema.Checked = False
                            End If
                        Case "Moco"
                            If param(1) = 1 Then
                                chk9_Moco.Checked = True
                            Else
                                chk9_Moco.Checked = False
                            End If
                        Case "% Obstruc."
                            If param(1) = 1 Then

                                chk9_Obs.Checked = True
                            Else
                                chk9_Obs.Checked = False
                            End If
                        Case "Desv. Tab"
                            If param(1) = 1 Then
                                chk9_Desv.Checked = True
                            Else
                                chk9_Desv.Checked = False
                            End If
                    End Select
                Next

                '54 ANT NARIZ %
                txt_Obstr.Text = Trim(arr_datoshc(54))


                '55 ANT NARIZ HIPER CORN
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(55), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Grave"
                            If param(1) = 1 Then
                                chkHCorn_Grave.Checked = True
                            Else
                                chkHCorn_Grave.Checked = False
                            End If
                        Case "Moderado"
                            If param(1) = 1 Then
                                chkHCorn_Moderado.Checked = True
                            Else
                                chkHCorn_Moderado.Checked = False
                            End If
                        Case "Leve"
                            If param(1) = 1 Then

                                chkHCorn_Leve.Checked = True
                            Else
                                chkHCorn_Leve.Checked = False
                            End If
                    End Select
                Next

                '56 NARIZ POLIPOS
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(56), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Der."
                            If param(1) = 1 Then
                                chk_Pol_D.Checked = True
                            Else
                                chk_Pol_D.Checked = False
                            End If
                        Case "Izq."
                            If param(1) = 1 Then
                                chk_Pol_I.Checked = True
                            Else
                                chk_Pol_I.Checked = False
                            End If
                    End Select
                Next


                '57 NARIZ MUCOSA
                txt_NarizMucosa.Text = Trim(arr_datoshc(57))

                '58 GARGANTA
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(58), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    Select Case param(0)
                        Case "Inflamada"
                            If param(1) = 1 Then
                                chk10_Inflamada.Checked = True
                            Else
                                chk10_Inflamada.Checked = False
                            End If
                        Case "Granulosa"
                            If param(1) = 1 Then
                                chk10_Granulosa.Checked = True
                            Else
                                chk10_Granulosa.Checked = False
                            End If
                        Case "S Reflujo"
                            If param(1) = 1 Then
                                chk10_SReflujo.Checked = True
                            Else
                                chk10_SReflujo.Checked = False
                            End If
                        Case "Goteo"
                            If param(1) = 1 Then
                                chk10_Goteo.Checked = True
                            Else
                                chk10_Goteo.Checked = False
                            End If
                        Case "Exudado"
                            If param(1) = 1 Then
                                chk10_Exudado.Checked = True
                            Else
                                chk10_Exudado.Checked = False
                            End If
                    End Select
                Next

                '59 ANT PIEL
                txt_CampoPiel.Text = Trim(arr_datoshc(59))


                '60 ANT IMAGEN
                txt_LabImagen.Text = Trim(arr_datoshc(60))

                '61 ANT BIOPSIA
                txt_LabBiopsia.Text = Trim(arr_datoshc(61))

                '62 LAB 1
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(62), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    dgv_Lab1.Rows(i).Cells(1).Value = param(1)
                Next

                '63 LAB 2
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(63), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    dgv_Lab2.Rows(i).Cells(1).Value = param(1)
                Next

                '64 LAB 3
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(64), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    dgv_Lab3.Rows(i).Cells(1).Value = param(1)
                Next

                '65 LAB 4
                arreglo = Nothing
                param = Nothing
                arreglo = Split(arr_datoshc(65), "|")
                For i = 0 To UBound(arreglo) - 1
                    param = Split(arreglo(i), ",")
                    dgv_Lab4.Rows(i).Cells(1).Value = param(1)
                Next

                '66 LAB OTROS
                txt_LabOtros.Text = Trim(arr_datoshc(66))


            End If
        Else
            cmb_APP.SelectedIndex = 0
            cmb_EnfToroideas.SelectedIndex = 0
            cmb_HabTox.SelectedIndex = 0
            cmb_zona.SelectedIndex = 0
            'For Each ctlMentruacion As Control In frm_formulario.grp_Menstruacion.Controls
            'For Each ctlCombos As Control In Panel1.Controls
            ' ctlCombos.SelectedIndex = 1
            ' Next
            Limpia()
            VisualizaGrids()
        End If


        '***********************************
        ' HISORIAL DE CAMBIOS
        '***********************************
        Dim dtcA_columna1 As New DataColumn("hic_id", GetType(System.Double))
        Dim dtcA_columna2 As New DataColumn("hic_fecha", GetType(System.String))
        'Dim dtcA_columna3 As New DataColumn("pac_id", GetType(System.Double))
        Dim dtcA_columna3 As New DataColumn("CAMPO", GetType(System.String))
        Dim dtcA_columna4 As New DataColumn("VALOR_ANTERIOR", GetType(System.String))
        Dim dtcA_columna5 As New DataColumn("VALOR_NUEVO", GetType(System.String))
        Dim dtcA_columna6 As New DataColumn("USUARIO", GetType(System.String))

        dtt_Historico.Columns.Add(dtcA_columna1)
        dtt_Historico.Columns.Add(dtcA_columna2)
        dtt_Historico.Columns.Add(dtcA_columna3)
        dtt_Historico.Columns.Add(dtcA_columna4)
        dtt_Historico.Columns.Add(dtcA_columna5)
        dtt_Historico.Columns.Add(dtcA_columna6)

        If actualizaDtsHistorico(var_hic_cli, Trim(cmb_Campo.Text)) = True Then

            dgv_Cambios.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            dgv_Cambios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgv_Cambios.Columns("hic_id").Visible = False

            dgv_Cambios.Columns("hic_fecha").HeaderText = "FECHA"
            dgv_Cambios.Columns("hic_fecha").Width = 115

            dgv_Cambios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            dgv_Cambios.Columns("CAMPO").HeaderText = "CAMPO"
            dgv_Cambios.Columns("CAMPO").Width = 150


            dgv_Cambios.Columns("VALOR_ANTERIOR").HeaderText = "ANTERIOR"
            dgv_Cambios.Columns("VALOR_ANTERIOR").Width = 310

            dgv_Cambios.Columns("VALOR_NUEVO").HeaderText = "NUEVO"
            dgv_Cambios.Columns("VALOR_NUEVO").Width = 310

            dgv_Cambios.Columns("USUARIO").HeaderText = "USUARIO"
            dgv_Cambios.Columns("USUARIO").Width = 100

            With dgv_Cambios
                .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8)
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .DefaultCellStyle.BackColor = Color.WhiteSmoke
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With
        End If


        '****************************************
        'HISTORIAL DE CONSULTAS
        '****************************************
        '' ''CREO COLUMNAS PARA GRID CONSULTAS HISTORICAS 
        Dim dtConHist_columna1 As New DataColumn("AGE_ID", GetType(System.Single))
        Dim dtConHist_columna2 As New DataColumn("CON_FECHA", GetType(System.String))
        Dim dtConHist_columna3 As New DataColumn("CON_HORA", GetType(System.String))
        Dim dtConHist_columna4 As New DataColumn("MED_NOMBRE", GetType(System.String))
        Dim dtConHist_columna5 As New DataColumn("MED_ID", GetType(System.Single))
        Dim dtConHist_columna6 As New DataColumn("AGE_ESTADO", GetType(System.String))

        dtt_conHist.Columns.Add(dtConHist_columna1)
        dtt_conHist.Columns.Add(dtConHist_columna2)
        dtt_conHist.Columns.Add(dtConHist_columna3)
        dtt_conHist.Columns.Add(dtConHist_columna4)
        dtt_conHist.Columns.Add(dtConHist_columna5)
        dtt_conHist.Columns.Add(dtConHist_columna6)

        actualizaDtsConHist(pac_id)

        dgv_ConsultaHistorico.Columns("AGE_ID").HeaderText = "ID"
        dgv_ConsultaHistorico.Columns("AGE_ID").Visible = False

        dgv_ConsultaHistorico.Columns("CON_FECHA").HeaderText = "FECHA"
        dgv_ConsultaHistorico.Columns("CON_FECHA").Width = 140

        dgv_ConsultaHistorico.Columns("CON_HORA").HeaderText = "HORA"
        dgv_ConsultaHistorico.Columns("CON_HORA").Width = 50

        dgv_ConsultaHistorico.Columns("MED_NOMBRE").HeaderText = "ESPECIALIDAD"
        dgv_ConsultaHistorico.Columns("MED_NOMBRE").Width = 220

        dgv_ConsultaHistorico.Columns("MED_ID").HeaderText = "ID MED"
        dgv_ConsultaHistorico.Columns("MED_ID").Visible = False

        dgv_ConsultaHistorico.Columns("AGE_ESTADO").HeaderText = "ESTADO"
        dgv_ConsultaHistorico.Columns("AGE_ESTADO").Width = 130

        With dgv_ConsultaHistorico
            .DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        lbl_ToTConsultas.Text = CStr(dgv_ConsultaHistorico.Rows.Count)
        lbl_TotCie.Text = ""
        lbl_TotExas.Text = CStr(dgv_ConsultaHistorico.Rows.Count)


    End Sub

    Public Sub actualizaDtsConHist(ByVal pac_id As Integer)
        dtt_conHist.Clear()
        opr_res.LlenarGridConHist(dgv_ConsultaHistorico, pac_id, dtt_conHist)

    End Sub

    Private Sub SeleccionPages(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        Select Case TabControl1.SelectedIndex
            Case 2
                arr_datoshc = Split(opr_pedido.LeerHistoriaClinica(pac_id), "º")
                actualizaDtsHistorico(var_hic_cli, Trim(cmb_Campo.Text))

        End Select

    End Sub
    Private Function actualizaDtsHistorico(ByVal hic_id As Integer, ByVal campo As String) As Boolean


        dtt_Historico.Clear()

        If opr_agenda.ExisteHistorico(hic_id) > 0 Then
            'LEO HISTORICO
            opr_res.LlenarGridHC_Historico(dgv_Cambios, dtt_Historico, hic_id, campo)
            actualizaDtsHistorico = True
        Else
            actualizaDtsHistorico = False
            opr_pedido.VisualizaMensaje("No existene historicos para este peciente", 250)
        End If



    End Function



    Private Sub VisualizaGrids()
        Dim dtLab0 As DataTable = New DataTable()
        Dim dtLab1 As DataTable = New DataTable()
        Dim dtLab2 As DataTable = New DataTable()
        Dim dtLab3 As DataTable = New DataTable()
        Dim dtLab4 As DataTable = New DataTable()


        Dim dtc01 As New DataColumn("Examen", GetType(System.String))
        Dim dtc02 As New DataColumn("Resultado", GetType(System.String))
        dtLab0.Columns.Add(dtc01)
        dtLab0.Columns.Add(dtc02)

        Dim dtc1 As New DataColumn("Examen", GetType(System.String))
        Dim dtc2 As New DataColumn("Resultado", GetType(System.String))
        dtLab1.Columns.Add(dtc1)
        dtLab1.Columns.Add(dtc2)

        Dim dtc21 As New DataColumn("Examen", GetType(System.String))
        Dim dtc22 As New DataColumn("Resultado", GetType(System.String))
        dtLab2.Columns.Add(dtc21)
        dtLab2.Columns.Add(dtc22)

        Dim dtc31 As New DataColumn("Examen", GetType(System.String))
        Dim dtc32 As New DataColumn("Resultado", GetType(System.String))
        dtLab3.Columns.Add(dtc31)
        dtLab3.Columns.Add(dtc32)

        Dim dtc41 As New DataColumn("Examen", GetType(System.String))
        Dim dtc42 As New DataColumn("Resultado", GetType(System.String))
        dtLab4.Columns.Add(dtc41)
        dtLab4.Columns.Add(dtc42)


        dgv_Lab1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv_Lab1.DefaultCellStyle.SelectionForeColor = Color.LightYellow
        dgv_Lab1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 8)
        dgv_Lab1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        ' *****************************
        ' ESPECIALES
        '******************************



        ' *****************************
        ' LAB 1
        '******************************

        Dim row As DataRow = dtLab1.NewRow()
        row("Examen") = "Hemoglobina"
        row("Resultado") = ""
        dtLab1.Rows.Add(row)

        Dim row2 As DataRow = dtLab1.NewRow()
        row2("Examen") = "Hematocrito"
        row2("Resultado") = ""
        dtLab1.Rows.Add(row2)

        Dim row3 As DataRow = dtLab1.NewRow()
        row3("Examen") = "Leucocitos"
        row3("Resultado") = ""
        dtLab1.Rows.Add(row3)

        Dim row4 As DataRow = dtLab1.NewRow()
        row4("Examen") = "Segmentados"
        row4("Resultado") = ""
        dtLab1.Rows.Add(row4)

        Dim row5 As DataRow = dtLab1.NewRow()
        row5("Examen") = "Linfocits"
        row5("Resultado") = ""
        dtLab1.Rows.Add(row5)

        Dim row6 As DataRow = dtLab1.NewRow()
        row6("Examen") = "Eoscinofilos"
        row6("Resultado") = ""
        dtLab1.Rows.Add(row6)

        Dim row7 As DataRow = dtLab1.NewRow()
        row7("Examen") = "Cit. Nasal"
        row7("Resultado") = ""
        dtLab1.Rows.Add(row7)

        dtLab1.AcceptChanges()
        dgv_Lab1.DataSource = dtLab1

        '******************************
        'LAB2
        '******************************

        Dim row21 As DataRow = dtLab2.NewRow()
        row21("Examen") = "Glucosa"
        row21("Resultado") = ""
        dtLab2.Rows.Add(row21)

        Dim row22 As DataRow = dtLab2.NewRow()
        row22("Examen") = "Colesterol"
        row22("Resultado") = ""
        dtLab2.Rows.Add(row22)

        Dim row23 As DataRow = dtLab2.NewRow()
        row23("Examen") = "Hdl"
        row23("Resultado") = ""
        dtLab2.Rows.Add(row23)

        Dim row24 As DataRow = dtLab2.NewRow()
        row24("Examen") = "Ldl"
        row24("Resultado") = ""
        dtLab2.Rows.Add(row24)

        Dim row25 As DataRow = dtLab2.NewRow()
        row25("Examen") = "Trigliceridos"
        row25("Resultado") = ""
        dtLab2.Rows.Add(row25)

        Dim row26 As DataRow = dtLab2.NewRow()
        row26("Examen") = "Creatinina"
        row26("Resultado") = ""
        dtLab2.Rows.Add(row26)

        Dim row27 As DataRow = dtLab2.NewRow()
        row27("Examen") = "Urea"
        row27("Resultado") = ""
        dtLab2.Rows.Add(row27)

        Dim row28 As DataRow = dtLab2.NewRow()
        row28("Examen") = "Ac. Urico"
        row28("Resultado") = ""
        dtLab2.Rows.Add(row28)

        dtLab2.AcceptChanges()
        dgv_Lab2.DataSource = dtLab2

        '******************************
        'LAB3
        '******************************

        Dim row31 As DataRow = dtLab3.NewRow()
        row31("Examen") = "COPRO"
        row31("Resultado") = ""
        dtLab3.Rows.Add(row31)

        Dim row32 As DataRow = dtLab3.NewRow()
        row32("Examen") = "EMO"
        row32("Resultado") = ""
        dtLab3.Rows.Add(row32)

        Dim row33 As DataRow = dtLab3.NewRow()
        row33("Examen") = "TSH"
        row33("Resultado") = ""
        dtLab3.Rows.Add(row33)

        Dim row34 As DataRow = dtLab3.NewRow()
        row34("Examen") = "TGO"
        row34("Resultado") = ""
        dtLab3.Rows.Add(row34)

        Dim row35 As DataRow = dtLab3.NewRow()
        row35("Examen") = "TGP"
        row35("Resultado") = ""
        dtLab3.Rows.Add(row35)

        Dim row36 As DataRow = dtLab3.NewRow()
        row36("Examen") = "GGT"
        row36("Resultado") = ""
        dtLab3.Rows.Add(row36)

        Dim row37 As DataRow = dtLab3.NewRow()
        row37("Examen") = "C3"
        row37("Resultado") = ""
        dtLab3.Rows.Add(row37)

        Dim row38 As DataRow = dtLab3.NewRow()
        row38("Examen") = "C4"
        row38("Resultado") = ""
        dtLab3.Rows.Add(row38)


        dtLab3.AcceptChanges()
        dgv_Lab3.DataSource = dtLab3

        '******************************
        'LAB4
        '******************************

        Dim row41 As DataRow = dtLab4.NewRow()
        row41("Examen") = "IgE"
        row41("Resultado") = ""
        dtLab4.Rows.Add(row41)

        Dim row42 As DataRow = dtLab4.NewRow()
        row42("Examen") = "PCR"
        row42("Resultado") = ""
        dtLab4.Rows.Add(row42)

        Dim row43 As DataRow = dtLab4.NewRow()
        row43("Examen") = "ASTO"
        row43("Resultado") = ""
        dtLab4.Rows.Add(row43)

        Dim row44 As DataRow = dtLab4.NewRow()
        row44("Examen") = "ANA"
        row44("Resultado") = ""
        dtLab4.Rows.Add(row44)

        Dim row45 As DataRow = dtLab4.NewRow()
        row45("Examen") = "FR"
        row45("Resultado") = ""
        dtLab4.Rows.Add(row45)

        Dim row46 As DataRow = dtLab4.NewRow()
        row46("Examen") = "ANTI DNA"
        row46("Resultado") = ""
        dtLab4.Rows.Add(row46)

        Dim row47 As DataRow = dtLab4.NewRow()
        row47("Examen") = "ANCA"
        row47("Resultado") = ""
        dtLab4.Rows.Add(row47)

        dtLab4.AcceptChanges()
        dgv_Lab4.DataSource = dtLab4

        'For Each 

    End Sub

    Private Sub txt_filtro_Ocupacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'Operaciones al precionar ENTER 
            'cmb_ocupacion.Text = txt_hc_ocupacion.Text
            'txt_hc_ocupacion.Text = ""

        ElseIf e.KeyCode = Keys.Delete Then
            'txt_hc_ocupacion.Text = ""
        End If
    End Sub

    Sub CargarColeccionOcupacion(ByVal ColeccionOcup As AutoCompleteStringCollection)
        On Error Resume Next
        opr_test.LeerColeccionOcup(ColeccionOcup)

    End Sub


    Private Sub btn_ssalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ssalir.Click
        Me.Close()
    End Sub

    Private Sub ComparaPalabras(ByVal texto1 As String, ByVal texto2 As String, ByRef diferencia As String)

        Dim comparador As StringComparer = StringComparer.OrdinalIgnoreCase
        If comparador.Equals(texto1, texto2) Then
            'Console.WriteLine("Las palabras son iguales.")
        Else
            ''Console.WriteLine("Las palabras son diferentes.")

            ' Encontrar cambio agregado
            diferencia = EncontrarCambio(texto2, texto1)
            'Console.WriteLine("Diferencias encontradas: " & diferencias)
        End If

    End Sub

    Function EncontrarDiferencias(ByVal original As String, ByVal nueva As String) As String
        Dim diferencias As New StringBuilder()

        ' Encontrar la longitud mínima entre las dos palabras
        Dim longitudMinima As Integer = Math.Min(original.Length, nueva.Length)

        ' Iterar a través de los caracteres y encontrar las diferencias
        For i As Integer = 0 To longitudMinima - 1
            If original(i) <> nueva(i) Then
                diferencias.Append("["c).Append(original(i)).Append(" -> ").Append(nueva(i)).Append("]"c)
            End If
        Next

        ' Agregar los caracteres adicionales si hay alguna diferencia en la longitud
        If original.Length > nueva.Length Then
            diferencias.Append(" Caracteres adicionales en la palabra original: ").Append(original.Substring(nueva.Length))
        ElseIf original.Length < nueva.Length Then
            diferencias.Append(" Caracteres adicionales en la nueva palabra: ").Append(nueva.Substring(original.Length))
        End If

        Return diferencias.ToString()
    End Function

    Function EncontrarCambio(ByVal original As String, ByVal nueva As String) As String

        Dim longitudTxt1 As Integer = original.Length

        EncontrarCambio = Mid(nueva, longitudTxt1, nueva.Length)

        Return EncontrarCambio

    End Function

    Private Sub btn_gguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gguardar.Click
        Dim diferencia As String

        If arr_datoshc Is Nothing = False Then

            If cmb_zona.Text <> arr_datoshc(3) Then
                'ComparaPalabras(cmb_zona.Text, arr_datoshc(3), diferencia)
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "ZONA", arr_datoshc(3), cmb_zona.Text, pac_id, g_sng_user)
            End If


            If txt_HOcupacion.Text <> arr_datoshc(4) Then
                'ComparaPalabras(txt_HOcupacion.Text, arr_datoshc(4), diferencia)
                'If diferencia <> "" Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "OCUPACION", arr_datoshc(4), txt_HOcupacion.Text, pac_id, g_sng_user)
            End If

            If txt_hcHobbies.Text <> arr_datoshc(5) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "HOBBIES", arr_datoshc(5), txt_hcHobbies.Text, pac_id, g_sng_user)
            End If

            If txt_hcInmun.Text <> arr_datoshc(6) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "INMUNIZACIONES", arr_datoshc(6), txt_hcInmun.Text, pac_id, g_sng_user)
            End If

            If cmb_HabTox.Text <> arr_datoshc(7) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "HABITOS TOXICOS", arr_datoshc(7), cmb_HabTox.Text, pac_id, g_sng_user)
            End If

            If txt_HabiTox_Otro.Text <> arr_datoshc(8) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "OTROS HABITOS TOXICOS", arr_datoshc(8), txt_HabiTox_Otro.Text, pac_id, g_sng_user)
            End If

            If txt_TiemHab.Text <> arr_datoshc(9) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "TIEMPO OTRO HABITO", arr_datoshc(9), txt_TiemHab.Text, pac_id, g_sng_user)
            End If

            If txt_hc_MotConsulta.Text <> arr_datoshc(10) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "MOTIVO DE LA CONSULTA", arr_datoshc(10), txt_hc_MotConsulta.Text, pac_id, g_sng_user)
            End If

            If txt_HisEnfeAct.Text <> arr_datoshc(11) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "HIST. ENFERMEDAD ACTUAL", arr_datoshc(11), txt_HisEnfeAct.Text, pac_id, g_sng_user)
            End If

            If txt_HTToAnam.Text <> arr_datoshc(12) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "TTO ANAMESIS", arr_datoshc(12), txt_HTToAnam.Text, pac_id, g_sng_user)
            End If
            If txt_HSeg.Text <> arr_datoshc(13) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "SEGUIMIENTO", arr_datoshc(13), txt_HSeg.Text, pac_id, g_sng_user)
            End If

            If txt_HPsicoS.Text <> arr_datoshc(14) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "HIST. PICOSOCIAL", arr_datoshc(14), txt_HPsicoS.Text, pac_id, g_sng_user)
            End If

            If txt_hcEvolInicio.Text <> arr_datoshc(15) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "EVOLUCION INICIO", arr_datoshc(15), txt_hcEvolInicio.Text, pac_id, g_sng_user)
            End If
            If cmb_APP.Text <> arr_datoshc(16) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "ANTECEDENTES PERSONALES", arr_datoshc(16), cmb_APP.Text, pac_id, g_sng_user)
            End If

            If cmb_EnfToroideas.Text <> arr_datoshc(17) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "ENFER. TIRIDEAS", arr_datoshc(17), cmb_EnfToroideas.Text, pac_id, g_sng_user)
            End If
            If txt_Cancer.Text <> arr_datoshc(18) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "CANCER", arr_datoshc(18), txt_Cancer.Text, pac_id, g_sng_user)
            End If

            If txt_EnferInfecc.Text <> arr_datoshc(19) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "ENFER. INFECCIOSAS", arr_datoshc(19), txt_EnferInfecc.Text, pac_id, g_sng_user)
            End If
            If txt_OtrasEnfer.Text <> arr_datoshc(20) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "OTRAS ENFERMEDADES", arr_datoshc(20), txt_OtrasEnfer.Text, pac_id, g_sng_user)
            End If

            If txt_TTo_Antec.Text <> arr_datoshc(21) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "TTO. ANTECEDENTES", arr_datoshc(21), txt_TTo_Antec.Text, pac_id, g_sng_user)
            End If
            If txt_Cirugias.Text <> arr_datoshc(22) Then
                opr_pedido.GuardaHistoriaCambios(var_hic_cli, "CIRUGIAS", arr_datoshc(22), txt_Cirugias.Text, pac_id, g_sng_user)
            End If
            opr_pedido.GuardaHistoria(Me, pac_id, var_hic_cli, arr_datoshc, False)
        Else
            opr_pedido.GuardaHistoria(Me, pac_id, var_hic_cli, arr_datoshc, True)
        End If
        arr_datoshc = Split(opr_pedido.LeerHistoriaClinica(pac_id), "º")

    End Sub

    Private Function obtieneDatosTramaTodo(ByVal pac_id As Integer, ByVal campo As String) As String
        Return opr_res.ConsultaDatosTramaTodo(pac_id, campo)
    End Function

    Private Function obtieneDatosTramaSolo(ByVal pac_id As Integer, ByVal campo As String) As String
        Return opr_res.ConsultaDatosTramaSolo(pac_id, campo)
    End Function

    Private Function obtieneDatosTramaVertical(ByVal pac_id As Integer, ByVal campo As String) As String
        Return opr_res.ConsultaDatosTramaVertical(pac_id, campo)
    End Function

    Private Function obtieneDatosTramaLab(ByVal pac_id As Integer, ByVal campo As String) As String
        Return opr_res.ConsultaDatosTramaLab(pac_id, campo)
    End Function

    Private Sub btn_ImpHistoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpHistoria.Click
        Dim str_sql As String
        Dim obj_reporte As New rpt_historiaclinica()
        Dim var_life As String

        If opr_pedido.LeerLife(pac_id) = 1 Then
            var_life = "PACIENTE LIFE"
        Else
            var_life = ""
        End If

        'ANTECEDENTES ESPECIALES
        Dim datosDesencadenate = obtieneDatosTramaSolo(pac_id, "hic_Desencadenantes")
        Dim datosMenstrucion = obtieneDatosTramaSolo(pac_id, "hic_Menstruacion")

        Dim datosSinOjos = obtieneDatosTramaSolo(pac_id, "hic_SinOjos")
        Dim datosSinNariz = obtieneDatosTramaSolo(pac_id, "hic_SinNariz")
        Dim datosSinEstonudos = obtieneDatosTramaSolo(pac_id, "hic_Estornudos")
        Dim datosSinBoca = obtieneDatosTramaSolo(pac_id, "hic_SinBoca")
        Dim datosPrurito = obtieneDatosTramaSolo(pac_id, "hic_Prurito")
        Dim datosTos = obtieneDatosTramaSolo(pac_id, "hic_Tos")
        Dim datosAccAsmaticos = obtieneDatosTramaSolo(pac_id, "Hic_AccAsmaticos")
        Dim datosPiel = obtieneDatosTramaSolo(pac_id, "hic_Piel")
        Dim datosDigestivos = obtieneDatosTramaSolo(pac_id, "hic_Digestivos")
        'RAM

        'ANTECE FAMILIARES
        Dim datosAntASMA = obtieneDatosTramaVertical(pac_id, "hic_AntecFamAsma")
        Dim datosRinit = obtieneDatosTramaVertical(pac_id, "hic_AntecFamRiñitis")
        Dim datosUrtic = obtieneDatosTramaVertical(pac_id, "hic_AntecFamUrticaria")
        Dim datosEccem = obtieneDatosTramaVertical(pac_id, "hic_AntecFamEccem")
        Dim datosConjun = obtieneDatosTramaVertical(pac_id, "hic_AntecFamConjunt")
        Dim datosDrogas = obtieneDatosTramaVertical(pac_id, "hic_AntecFamDrogas")
        Dim datosMigra = obtieneDatosTramaVertical(pac_id, "hic_AntecFamMigra")
        Dim datosEdema = obtieneDatosTramaVertical(pac_id, "hic_AntecFamEdema")
        Dim datosOtros = obtieneDatosTramaVertical(pac_id, "hic_AntecFamOtro")

        'SIGNOS ESPECIALES
        Dim datosEspeciales1 = obtieneDatosTramaVertical(pac_id, "hic_SignosEsp1")
        Dim datosEspeciales2 = obtieneDatosTramaVertical(pac_id, "hic_SignosEsp2")

        Dim datosResNorm = obtieneDatosTramaTodo(pac_id, "hic_TotaxResNormal")
        Dim datosResForz = obtieneDatosTramaTodo(pac_id, "hic_ToraxResForzada")
        Dim datosNariz = obtieneDatosTramaTodo(pac_id, "hic_Nariz")
        Dim datosNarizHiper = obtieneDatosTramaTodo(pac_id, "hic_NarizHiperCorn")
        Dim datosPolipos = obtieneDatosTramaTodo(pac_id, "hic_NarizPolipos")
        Dim datosGargan = obtieneDatosTramaTodo(pac_id, "hic_Garganta")

        Dim datosLab1 = obtieneDatosTramaLab(pac_id, "hic_DatosLab1")
        Dim datosLab2 = obtieneDatosTramaLab(pac_id, "hic_DatosLab2")
        Dim datosLab3 = obtieneDatosTramaLab(pac_id, "hic_DatosLab3")
        Dim datosLab4 = obtieneDatosTramaLab(pac_id, "hic_DatosLab4")

        str_sql = "select (pc.PAC_APELLIDO + ' ' + pc.PAC_NOMBRE) as paciente, pc.PAC_DOC, pc.PAC_FECNAC, pc.PAC_SEXO, pc.PAC_OBS, pc.PAC_GRADO, pc.PAC_FONO, pc.PAC_MAIL, pc.PAC_DIRECCION, '" & var_life & "' as pac_poliza, " & _
        "hc.hic_fecha, hc.hic_Zona, hc.hic_Ocupacion, hc.hic_Hobbies, hc.hic_Inmunizaciones, hc.hic_HabitosToxicos, hc.hic_Tiempo, hc.hic_MotivoConsulta, hc.hic_HistEnferActual, " & _
        "hc.hic_TTo_Ananmesis, hc.hic_Seguimiento, hc.hic_PsicoS, hc.hic_EnferEvolInicio, hc.hic_App, hc.hic_EnferToroideas, hc.hic_Cancer, hc.hic_EnferInfecc, hc.hic_Otras, " & _
        "hc.hic_TTo_Antec, hc.hc_Cirugias, hc.hic_RAM, hc. hic_CampoPiel, hc.hic_DatosLabImagen, hc.hic_DatosLabBiopsia, hc.hic_DatosLabOtros, " & _
        "hc.hic_Zona, hc.hic_Ocupacion, hc.hic_Hobbies, hc.hic_Inmunizaciones, hc.hic_HabitosToxicos, hc.hic_Tiempo, hc.hic_MotivoConsulta, hc.hic_HistEnferActual, hc.hic_TTo_Ananmesis, hc.hic_Seguimiento, hc.hic_PsicoS, hc.hic_EnferEvolInicio, hc.hic_App, hc.hic_EnferToroideas, hc.hic_Cancer, hc.hic_EnferInfecc, hc.hic_Otras, hc.hic_TTo_Antec, hc.hc_Cirugias, hc.hic_RAM, hc.hic_CampoPiel, hc.hic_DatosLabImagen, hc.hic_DatosLabBiopsia, hc.hic_DatosLabOtros, '" & _
        datosDesencadenate & "' as hic_Desencadenantes, hic_DesencadenantesOtro, '" & datosMenstrucion & "' as hic_Menstruacion, hic_MenstruacionToma, '" & datosSinOjos & "' as hic_SinOjos, '" & datosSinNariz & "' as hic_SinNariz, '" & datosSinEstonudos & "' as hic_Estornudos, '" & datosSinBoca & "' as hic_SinBoca, '" & datosPrurito & "' as hic_Prurito, '" & datosTos & "' as hic_Tos, '" & _
        datosAccAsmaticos & "' as Hic_AccAsmaticos, '" & datosPiel & "' as hic_Piel, '" & datosDigestivos & "' as hic_Digestivos, hic_DigestivosCampo, '" & datosAntASMA & "' as hic_AntecFamAsma, '" & datosRinit & "' as hic_AntecFamRiñitis, '" & datosUrtic & "' as hic_AntecFamUrticaria, '" & datosEccem & "' as hic_AntecFamEccem, '" & _
        datosConjun & "' as hic_AntecFamConjunt, '" & datosDrogas & "' as hic_AntecFamDrogas, '" & datosMigra & "' as hic_AntecFamMigra, '" & datosEdema & "' as hic_AntecFamEdema, hic_AntecFamOtroCampo, '" & _
        datosEspeciales1 & "' as hic_SignosEsp1, '" & datosEspeciales2 & "' as hic_SignosEsp2, '" & datosResNorm & "' as hic_TotaxResNormal, '" & datosResForz & "' as hic_ToraxResForzada, '" & datosNariz & "' as hic_Nariz, '" & datosNarizHiper & "' as hic_NarizHiperCorn, '" & datosPolipos & "' as hic_NarizPolipos, hc.hic_NarizMucosa, '" & datosGargan & "' as hic_Garganta, " & _
        "pr.PROV_NOMBRE, ci.CIU_NOMBRE, pc.PAC_PAIS, pc.PAC_PROFESION, " & _
        "'" & datosLab1 & "' as hic_DatosLab1, " & _
        "'" & datosLab2 & "' as hic_DatosLab2, " & _
        "'" & datosLab3 & "' as hic_DatosLab3, " & _
        "'" & datosLab4 & "' as hic_DatosLab4 " & _
        "from historiaclinica as hc, paciente as pc, provincia as pr, ciudad as ci " & _
        "where hc.pac_id = " & pac_id & " And hc.pac_id = pc.PAC_ID and pr.PROV_ID = pc.PROV_ID and pc.CIU_ID = ci.CIU_ID ;"

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , True, 0)
        frm_MDIChild.int_alto = Me.Height
        frm_MDIChild.int_ancho = Me.Width
        frm_MDIChild.Text = "HISTORIA CLINICA"
        frm_MDIChild.Show()

        Me.Cursor = System.Windows.Forms.Cursors.Default

        opr_pedido.VisualizaMensaje("Generando reporte", 300)
    End Sub

    Private Sub btn_AAgendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''Dim x As Long = opr_pedido.LeerMaxPedido()
        ''Dim fechaGuardaAgenda As String = Nothing
        ''Dim SiNoGuardo As Boolean = False
        ''Dim Varmed As Integer = 0
        ''x = x + 1

        ''If Not ExisteForm("Frm_Agenda") Then
        ''    Dim FrM_MDIChild As New Frm_Agenda()

        ''    FrM_MDIChild.frm_refer_main_form = Me.ParentForm
        ''    FrM_MDIChild.Tag = 1
        ''    FrM_MDIChild.VarPac = lng_pac_id
        ''    FrM_MDIChild.NomPac = Trim(lbl_paciente.Text)
        ''    FrM_MDIChild.VarPed = x

        ''    FrM_MDIChild.ShowDialog(Me.ParentForm)
        ''    fechaGuardaAgenda = Format(FrM_MDIChild.cal1.SelectionRange.Start, "dd/MM/yyyy") & " " & Format(Now(), "HH:mm:ss")
        ''    SiNoGuardo = FrM_MDIChild.SiNoGuardo
        ''    If FrM_MDIChild.Tag = 1 Then
        ''        If SiNoGuardo Then
        ''            'opr_pedido.GuardarPedidoAgenda(Me, lng_pac_id, x, 1, 9, CInt(FrM_MDIChild.VarMed))
        ''            g_opr_usuario.CargarTransaccion(g_str_login, "AGENDAMIENTO", "PEDIDO=" & x, g_sng_user, x, "", "")
        ''            opr_pedido.ActualizaCodigo(lbl_doc.Text)

        ''            If MsgBox("El pedido ha sido agendado satisfactoriamente, desea seguir ingresando pedidos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ANALISYS") = MsgBoxResult.Yes Then
        ''                '    'Limpia()
        ''                'Abrir_frmImprimiendo()

        ''                'rfn nuevo
        ''                'lst_pedidos.Items.Clear()
        ''                'dts_lista = opr_res.LlenaListPedido(lst_pedidos, Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), Format(Dtp_ped_fecing.Value, "dd/MM/yyyy"), area, 0)
        ''                '***
        ''                btn_eeditar.Enabled = True 'EDITAR
        ''                btn_gguardar.Enabled = False ' GUARDAR
        ''                btn_ssalir.Enabled = True ' SALIR
        ''                'txt_doc.Text = Format(opr_pedido.LeerMaxCodigo(), "0000000000")
        ''                Me.Tag = ""
        ''                Limpia()
        ''                '*****
        ''            Else

        ''                'Abrir_frmImprimiendo()
        ''                Me.Close()
        ''            End If

        ''            btn_ssalir.Enabled = True 'salir 
        ''            'rfn nuevo

        ''        Else
        ''            ''frm_refer_main_form.escribemsj("ERRORES AL GUARDAR PEDIDO")
        ''        End If

        ''    Else

        ''    End If
        ''Else
        ''End If
    End Sub

    Sub Limpia()
        ''lbl_paciente.Text = ""
        ''lbl_doc.Text = ""
        ''lbl_edad.Text = ""
        ''cmb_ocupacion.SelectedIndex = 0
        ''txt_hc_AntPatPersonales.Text = ""
        ''txt_hc_AntPatFamiliares.Text = ""
        ''txt_hc_MedHabitual.Text = ""
        ''txt_hc_Alergias.Text = ""
        ''txt_hc_Tabaco.Text = ""
        ''txt_hc_Drogas.Text = ""
        ''txt_hc_Alcohol.Text = ""
        ''txt_hc_MotConsulta.Text = ""
        ''txt_hc_EnferActual.Text = ""
        ''txt_hc_TenArterial.Text = ""
        ''txt_hc_FreCardiaca.Text = ""


        For Each controlText As Windows.Forms.Control In Me.Controls
            If TypeOf controlText Is TextBox Then
                CType(controlText, TextBox).Clear()
            End If
        Next

        'For Each controlText As Windows.Forms.Control In Me.grp_SVitales.Controls
        '    If TypeOf controlText Is TextBox Then
        '        CType(controlText, TextBox).Clear()
        '    End If
        'Next


    End Sub


    Private Sub btn_ImpSignosV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str_sql As String
        Dim obj_reporte As New rpt_SignosVitales()
        'Dim str_edad As String = Nothing

        str_sql = "select  top 1 (p.PAC_APELLIDO + ' ' + p.PAC_NOMBRE) as paciente, sv.sig_fecha, sig_tensArt, sv.sig_FrecCard, sv.sig_FrecResp, sv.sig_Temp, sv.sig_Satur, sv.sig_Peso " & _
                   "from SignosVitales as sv , paciente as p " & _
                "where sv.pac_id = p.PAC_ID and p.PAC_ID = " & pac_id & _
                "order by sig_id desc "

        Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , True, 0)
        frm_MDIChild.int_alto = Me.Height
        frm_MDIChild.int_ancho = Me.Width
        frm_MDIChild.Text = "SIGNOS VITALES"
        frm_MDIChild.Show()

        Me.Cursor = System.Windows.Forms.Cursors.Default



        'g_opr_usuario.CargarTransaccion(g_str_login, "03 IMPRIMIR PEDIDO", "PEDIDO=" & g_lng_ped_id, g_sng_user, g_lng_ped_id, "", "")
        opr_pedido.VisualizaMensaje("Generando reporte", 300)
    End Sub

    Private Sub btn_ImpExFisico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str_sql As String
        Dim obj_reporte As New rpt_ExaFisico()
        'Dim str_edad As String = Nothing

        str_sql = "select  top 1 (p.PAC_APELLIDO + ' ' + p.PAC_NOMBRE) as paciente, sv.sig_fecha, sig_tensArt, sv.sig_FrecCard, sv.sig_FrecResp, sv.sig_Temp, sv.sig_Satur, sv.sig_Peso " & _
                   "from SignosVitales as sv , paciente as p " & _
                "where sv.pac_id = p.PAC_ID and p.PAC_ID = " & pac_id & _
                "order by sig_id desc "

        'Dim frm_MDIChild As New Frm_reportes(str_sql, "", obj_reporte, , , , , , , , , True)
        'frm_MDIChild.int_alto = Me.Height
        'frm_MDIChild.int_ancho = Me.Width
        'frm_MDIChild.Text = "EXAMEN FISICO"
        'frm_MDIChild.Show()

        Me.Cursor = System.Windows.Forms.Cursors.Default



        'g_opr_usuario.CargarTransaccion(g_str_login, "03 IMPRIMIR PEDIDO", "PEDIDO=" & g_lng_ped_id, g_sng_user, g_lng_ped_id, "", "")
        opr_pedido.VisualizaMensaje("Generando reporte", 300)
    End Sub





    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Panel1.AutoScroll = True
        Panel1.VerticalScroll.Visible = True
        Panel1.HorizontalScroll.Visible = True
    End Sub


    Private Sub cmb_Campo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Campo.SelectedIndexChanged
        actualizaDtsHistorico(var_hic_cli, Trim(cmb_Campo.Text))
    End Sub
End Class