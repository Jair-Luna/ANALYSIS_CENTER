'*************************************************************************
' Nombre:   Cls_InitFile
' Tipo de Archivo: clase
' Descripción:  Clase para la manipular archivos de configuraciones
' Autores: Obtenido del Internet
' Fecha de Creación: 
' Autores Modificaciones: 
' Ultima Modificación: 
' Proyecto TRUESOLUTIONS
'*************************************************************************

Option Explicit On 
Option Strict On

Imports System

Public Class Cls_IniFile


#Region "Private variables"
    ' =======================================================================
    ' Private variables used in the class

    Private mFileName As String = ""
    Private mDs As Data.DataSet
#End Region

#Region "Contructors"
    ' =======================================================================
    ' Constructors

    Public Sub New()
        'Nothing here
    End Sub

    Public Sub New(ByVal iniFileName As String)
        ' Open the IniFile
        FileName = iniFileName
    End Sub

#End Region

#Region "Methodes"
    ' =======================================================================
    ' Methodes

    Public Overloads Function ReadString(ByVal section As String, ByVal key As String) As String
        ' Function ReadString Number 1

        ' Read string from INI Dataset

        ' Use function number 2
        ' Use an empty string as defaultvalue
        Return Me.ReadString(section, key, "")
    End Function

    Public Overloads Function ReadString(ByVal section As String, ByVal key As String, ByVal defaultValue As String) As String
        ' Function ReadString Number 2

        ' Read string from INI Dataset
        Return Read(section, key, defaultValue)
    End Function

    Public Overloads Function ReadString(ByVal section As String, ByVal key As String, ByVal defaultValue As String, ByVal iniFileName As String) As String
        ' Function ReadString Number 3

        ' Open the IniFile
        FileName = iniFileName

        ' Read string from INI Dataset

        ' Use function number 2
        Return Me.ReadString(section, key, defaultValue)
    End Function

    Public Overloads Function ReadInteger(ByVal section As String, ByVal key As String) As Integer
        ' Function ReadInteger Number 1

        ' Store return value

        ' Use function number 2
        ' Use 0 as defaultvalue
        Return Me.ReadInteger(section, key, 0)
    End Function

    Public Overloads Function ReadInteger(ByVal section As String, ByVal key As String, ByVal defaultValue As Integer) As Integer
        ' Function ReadInteger Number 2

        ' Store return value
        Dim ret As Integer
        Dim tmpRet As String

        ' Read string from INI Dataset
        ' First convert DefaultValue to a string to use the Common Read function
        tmpRet = Read(section, key, CType(defaultValue, String))

        Try
            ' Convert the Value to an Integer
            ret = CType(tmpRet, Integer)

        Catch
            ' When the value couldn't convert to a integer, return zero
            ret = 0
        End Try

        Return ret
    End Function

    Public Overloads Function ReadInteger(ByVal section As String, ByVal key As String, ByVal defaultValue As Integer, ByVal iniFileName As String) As Integer
        ' Function ReadInteger Number 3

        ' Open the IniFile
        FileName = iniFileName

        ' Use ReadInteger function number 2
        Return Me.ReadInteger(section, key, defaultValue)
    End Function

    Public Function SectionNames() As Collections.ArrayList
        ' Store return value in an arraylist
        Dim ret As New Collections.ArrayList()

        Dim table As Data.DataTable

        ' Loop through all the Tables
        For Each table In mDs.Tables
            ' Add tablename to the ArrayList
            ret.Add(table.TableName)
        Next

        Return ret
    End Function

    Public Overloads Sub WriteString(ByVal section As String, ByVal key As String, ByVal value As String)
        ' Function WriteString Number 1

        ' Store data in dataset
        Write(section, key, value)

        ' Write dataset back to disk
        DumpDatasetToIni()
    End Sub

    Public Overloads Sub WriteString(ByVal section As String, ByVal key As String, ByVal value As String, ByVal iniFileName As String)
        ' Function WriteString Number 2

        ' Open the IniFile
        FileName = iniFileName

        ' Use WriteString function number 1
        Me.WriteString(section, key, value)
    End Sub

    Public Overloads Sub WriteInteger(ByVal section As String, ByVal key As String, ByVal value As Integer)
        ' Function WriteInteger Number 1

        ' First convert Value to a string to use the WriteString function number 1
        Me.WriteString(section, key, value.ToString)
    End Sub

    Public Overloads Sub WriteInteger(ByVal section As String, ByVal key As String, ByVal value As Integer, ByVal iniFileName As String)
        ' Function WriteInteger Number 2

        ' First convert Value to a string to use the WriteString function number 2
        Me.WriteString(section, key, value.ToString, iniFileName)
    End Sub

    Public Overloads Sub DeleteSection(ByVal section As String)
        ' Function DeleteSection Number 1

        ' Delete 'Section' Table from Dataset
        ' First check if section exists
        If Not (mDs.Tables(section) Is Nothing) Then
            ' Section is found, so kill it
            mDs.Tables.Remove(section)

            ' Write dataset back to disk
            DumpDatasetToIni()
        End If
    End Sub

    Public Overloads Sub DeleteSection(ByVal section As String, ByVal iniFileName As String)
        ' Function DeleteSection Number 2

        ' Open the IniFile
        FileName = iniFileName

        ' Use DeleteSection function number 1
        Me.DeleteSection(section)
    End Sub
#End Region

#Region "Properties"
    ' =======================================================================
    ' Properties

    Public Property FileName() As String
        Get
            ' Return Filename
            Return mFileName
        End Get
        Set(ByVal Value As String)
            ' Check if File is allready open
            If Value.Trim <> mFileName Then
                ' If not, open it
                mFileName = Value

                LoadIniToDataSet()
            End If
        End Set
    End Property

    Public ReadOnly Property DataSet() As Data.DataSet
        Get
            ' Return Dataset
            Return mDs
        End Get
    End Property

#End Region

#Region "Private Section"
    ' =======================================================================
    ' Private Section

    Private Function Read(ByVal section As String, ByVal key As String, ByVal defaultValue As String) As String
        ' Store return value
        Dim ret As String

        Try
            ' Section = TableName
            ' Key = ColumnName
            ' Row = 0, because there is only one row for each table
            ' Get the value from the dataset
            ret = mDs.Tables(section).Rows(0).Item(key).ToString

        Catch
            ' If the Section or Key isn't found return the DefaultValue
            ret = defaultValue
        End Try

        Return ret
    End Function

    Private Sub Write(ByVal section As String, ByVal key As String, ByVal value As String)
        ' Section = Table
        ' Key = Column
        ' Row = 0, because there is only one row for each table

        ' Look for section in Dataset
        If (mDs.Tables(section) Is Nothing) Then
            ' Section is not found
            ' Add section to the dataset
            mDs.Tables.Add(section)

            ' Add Key to Section
            mDs.Tables(section).Columns.Add(key)

            ' We must add a new row to the dataset
            Dim row As Data.DataRow
            row = mDs.Tables(section).NewRow

            ' Add Value to Key
            row.Item(key) = value
            mDs.Tables(section).Rows.Add(row)

        Else
            ' Section was found, now look for key in section
            If (mDs.Tables(section).Columns(key) Is Nothing) Then
                ' Key is not found
                ' Add key to the section
                mDs.Tables(section).Columns.Add(key)
            End If

            ' Update Value for key
            mDs.Tables(section).Rows(0).Item(key) = value

        End If
    End Sub

    Private Overloads Sub LoadIniToDataSet()
        ' Initialise Dataset
        mDs = New Data.DataSet()

        ' Open the File
        Dim file As New IO.FileInfo(mFileName)

        ' Create DatasetName from IniFileName by removing the file extention
        mDs.DataSetName = file.Name.Remove(file.Name.IndexOf(file.Extension), file.Extension.Length)

        ' Check if inifile exists on specified path
        If file.Exists() Then
            ' Store each Section as a Table in the Dataset
            Dim table As Data.DataTable

            ' Define row to fill with KeyValue
            Dim row As Data.DataRow

            ' A switch to keep track when we have add the row to the table
            Dim addRow As Boolean = False

            ' A switch to keep track when we have add the row to the table
            Dim skipSection As Boolean = False

            ' Use a filestream to read the IniFile
            Dim fileStream As New IO.StreamReader(mFileName)
            Dim readLine As String

            ' Read the first line
            readLine = fileStream.ReadLine

            ' Loop to the end of the File
            Do While Not (readLine Is Nothing)
                ' Trim all leading en ending spaces
                readLine = readLine.Trim()

                ' Skip empty lines and commented lines
                If readLine <> "" And Not readLine.StartsWith(";") Then

                    ' Check if the line is a Section Header
                    If readLine.StartsWith("[") AndAlso readLine.EndsWith("]") Then
                        ' A new Section means a new Table

                        ' Before we create a new table
                        ' add all the values to the previous created table
                        If addRow Then
                            table.Rows.Add(row)
                        End If

                        ' remove brackets from readline
                        readLine = readLine.TrimStart("["c)
                        readLine = readLine.TrimEnd("]"c)

                        ' Tablename is SectionName
                        ' Check if table allready exists
                        ' If so, skip the rest of the section
                        ' An iniFile can't have double sections

                        ' First set it to True, will be corrected a few lines below
                        skipSection = True

                        table = mDs.Tables(readLine)
                        If (table Is Nothing) Then
                            ' If not, Create new table
                            table = New Data.DataTable(readLine)

                            ' Add Table to Dataset
                            mDs.Tables.Add(table)

                            ' Adds a new row to the table
                            row = table.NewRow

                            skipSection = False
                        End If

                        ' Clear switch
                        addRow = False
                    Else
                        If Not skipSection Then
                            ' Use a string array to store data
                            Dim splitLine() As String
                            ' Split the line by a =
                            ' SplitDate(0) holds the Key
                            ' SplitDate(1) holds the KeyValue
                            splitLine = readLine.Split("="c)
                            ' Columnname is Key
                            ' Check if Key allready exists
                            ' if so Skip it, a section can't have double keys
                            If (table.Columns(splitLine(0)) Is Nothing) Then
                                ' Add Key as a new column to the table
                                table.Columns.Add(splitLine(0))
                                ' Check if line is splitted ok
                                If splitLine.Length = 2 Then
                                    ' Fill Key-column with KeyValue 
                                    row.Item(splitLine(0)) = splitLine(1)
                                Else
                                    ' Fill Key-column with empty string 
                                    row.Item(splitLine(0)) = ""
                                End If
                                ' Set switch for adding row
                                addRow = True
                            End If
                        End If
                    End If
                End If
                ' Read next Line
                readLine = fileStream.ReadLine
            Loop
            ' Don't forget the last entries
            If addRow Then
                table.Rows.Add(row)
            End If
            ' Close file
            fileStream.Close()
        End If
    End Sub

    Private Sub DumpDatasetToIni()
        ' Check if inifile exists on specified path
        If IO.File.Exists(mFileName) Then
            ' if, so....delete it
            IO.File.Delete(mFileName)
        End If

        ' Use a StreamWriter to make a new inifile
        Dim file As IO.StreamWriter = IO.File.CreateText(mFileName)

        ' Section = TableName
        ' Key = ColumnName
        ' Row = 0, because there is only one row for each table
        Dim table As Data.DataTable
        Dim col As Data.DataColumn
        Dim value As String

        ' Loop through all sections
        For Each table In mDs.Tables
            ' Write section name
            file.WriteLine("[" & table.TableName & "]")

            ' Loop through all key's in section
            For Each col In table.Columns
                ' Find value for key
                value = table.Rows(0).Item(col).ToString

                ' Write Key and Value
                file.WriteLine(col.ColumnName & "=" & value)
            Next

            ' Make an empty line between the sections
            file.WriteLine("")
        Next

        ' Close IniFile
        file.Close()

    End Sub

#End Region

End Class
