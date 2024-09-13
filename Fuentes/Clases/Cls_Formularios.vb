'*************************************************************************
' Nombre:   Cls_Formularios
' Tipo de Archivo: Clase
' Descripción:  Clase para manipular los los b ordes de un formulario
' Autores:  rfn
' Fecha de Creación: 
' Autores Modificaciones: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Imports System
Imports System.IO


Public Class Cls_Formularios


    'Declaraciones de funciones Api

    ' Crea la región
    Private Declare Function CreateRoundRectRgn Lib "gdi32" ( _
        ByVal X1 As Long, _
        ByVal Y1 As Long, _
        ByVal X2 As Long, _
        ByVal Y2 As Long, _
        ByVal X3 As Long, _
        ByVal Y3 As Long) As Long

    'Establece la región
    Private Declare Function SetWindowRgn Lib "user32" ( _
        ByVal hwnd As Long, _
        ByVal hRgn As Long, _
        ByVal bRedraw As Boolean) As Long


    Public Function Redondear_Formulario(ByVal El_Form As frm_Inicio, ByVal Radio As Long)
        Dim Region As Long
        Dim Ret As Long
        Dim Ancho As Long
        Dim Alto As Long
        Dim old_Scale As Integer

        ' guardar la escala  
        '''old_Scale = El_Form.ScaleMode

        ' cambiar la escala a pixeles  
        'El_Form.ScaleMode = vbPixels

        'Obtenemos el ancho y alto de la region del Form  
        '''Ancho = El_Form.ScaleWidth
        '''Alto = El_Form.ScaleHeight

        'Pasar el ancho alto del formualrio y el valor de redondeo .. es decir el radio  
        Region = CreateRoundRectRgn(0, 0, Ancho, Alto, Radio, Radio)

        ' Aplica la región al formulario  
        '''Ret = SetWindowRgn(El_Form.hwnd, Region, True)

        ' restaurar la escala  
        '''El_Form.ScaleMode = old_Scale

    End Function
End Class
