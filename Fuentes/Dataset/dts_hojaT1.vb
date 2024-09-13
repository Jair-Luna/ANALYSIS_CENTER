﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3705.6060
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dts_hojaT
    Inherits DataSet
    
    Private tableHOJA_TRABAJO As HOJA_TRABAJODataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("HOJA_TRABAJO")) Is Nothing) Then
                Me.Tables.Add(New HOJA_TRABAJODataTable(ds.Tables("HOJA_TRABAJO")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property HOJA_TRABAJO As HOJA_TRABAJODataTable
        Get
            Return Me.tableHOJA_TRABAJO
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dts_hojaT = CType(MyBase.Clone,dts_hojaT)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("HOJA_TRABAJO")) Is Nothing) Then
            Me.Tables.Add(New HOJA_TRABAJODataTable(ds.Tables("HOJA_TRABAJO")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableHOJA_TRABAJO = CType(Me.Tables("HOJA_TRABAJO"),HOJA_TRABAJODataTable)
        If (Not (Me.tableHOJA_TRABAJO) Is Nothing) Then
            Me.tableHOJA_TRABAJO.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dts_hojaT"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dts_hojaT.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableHOJA_TRABAJO = New HOJA_TRABAJODataTable
        Me.Tables.Add(Me.tableHOJA_TRABAJO)
    End Sub
    
    Private Function ShouldSerializeHOJA_TRABAJO() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub HOJA_TRABAJORowChangeEventHandler(ByVal sender As Object, ByVal e As HOJA_TRABAJORowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class HOJA_TRABAJODataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnped_turno As DataColumn
        
        Private columnpaciente As DataColumn
        
        Private columntpa_desc As DataColumn
        
        Private columnare_nombre As DataColumn
        
        Private columnfecha As DataColumn
        
        Private columntes_ordenimp As DataColumn
        
        Private columntpa_orden As DataColumn
        
        Friend Sub New()
            MyBase.New("HOJA_TRABAJO")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property ped_turnoColumn As DataColumn
            Get
                Return Me.columnped_turno
            End Get
        End Property
        
        Friend ReadOnly Property pacienteColumn As DataColumn
            Get
                Return Me.columnpaciente
            End Get
        End Property
        
        Friend ReadOnly Property tpa_descColumn As DataColumn
            Get
                Return Me.columntpa_desc
            End Get
        End Property
        
        Friend ReadOnly Property are_nombreColumn As DataColumn
            Get
                Return Me.columnare_nombre
            End Get
        End Property
        
        Friend ReadOnly Property fechaColumn As DataColumn
            Get
                Return Me.columnfecha
            End Get
        End Property
        
        Friend ReadOnly Property tes_ordenimpColumn As DataColumn
            Get
                Return Me.columntes_ordenimp
            End Get
        End Property
        
        Friend ReadOnly Property tpa_ordenColumn As DataColumn
            Get
                Return Me.columntpa_orden
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As HOJA_TRABAJORow
            Get
                Return CType(Me.Rows(index),HOJA_TRABAJORow)
            End Get
        End Property
        
        Public Event HOJA_TRABAJORowChanged As HOJA_TRABAJORowChangeEventHandler
        
        Public Event HOJA_TRABAJORowChanging As HOJA_TRABAJORowChangeEventHandler
        
        Public Event HOJA_TRABAJORowDeleted As HOJA_TRABAJORowChangeEventHandler
        
        Public Event HOJA_TRABAJORowDeleting As HOJA_TRABAJORowChangeEventHandler
        
        Public Overloads Sub AddHOJA_TRABAJORow(ByVal row As HOJA_TRABAJORow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddHOJA_TRABAJORow(ByVal ped_turno As Long, ByVal paciente As String, ByVal tpa_desc As String, ByVal are_nombre As String, ByVal fecha As Date, ByVal tes_ordenimp As Integer, ByVal tpa_orden As Integer) As HOJA_TRABAJORow
            Dim rowHOJA_TRABAJORow As HOJA_TRABAJORow = CType(Me.NewRow,HOJA_TRABAJORow)
            rowHOJA_TRABAJORow.ItemArray = New Object() {ped_turno, paciente, tpa_desc, are_nombre, fecha, tes_ordenimp, tpa_orden}
            Me.Rows.Add(rowHOJA_TRABAJORow)
            Return rowHOJA_TRABAJORow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As HOJA_TRABAJODataTable = CType(MyBase.Clone,HOJA_TRABAJODataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New HOJA_TRABAJODataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnped_turno = Me.Columns("ped_turno")
            Me.columnpaciente = Me.Columns("paciente")
            Me.columntpa_desc = Me.Columns("tpa_desc")
            Me.columnare_nombre = Me.Columns("are_nombre")
            Me.columnfecha = Me.Columns("fecha")
            Me.columntes_ordenimp = Me.Columns("tes_ordenimp")
            Me.columntpa_orden = Me.Columns("tpa_orden")
        End Sub
        
        Private Sub InitClass()
            Me.columnped_turno = New DataColumn("ped_turno", GetType(System.Int64), Nothing, System.Data.MappingType.Attribute)
            Me.Columns.Add(Me.columnped_turno)
            Me.columnpaciente = New DataColumn("paciente", GetType(System.String), Nothing, System.Data.MappingType.Attribute)
            Me.Columns.Add(Me.columnpaciente)
            Me.columntpa_desc = New DataColumn("tpa_desc", GetType(System.String), Nothing, System.Data.MappingType.Attribute)
            Me.Columns.Add(Me.columntpa_desc)
            Me.columnare_nombre = New DataColumn("are_nombre", GetType(System.String), Nothing, System.Data.MappingType.Attribute)
            Me.Columns.Add(Me.columnare_nombre)
            Me.columnfecha = New DataColumn("fecha", GetType(System.DateTime), Nothing, System.Data.MappingType.Attribute)
            Me.Columns.Add(Me.columnfecha)
            Me.columntes_ordenimp = New DataColumn("tes_ordenimp", GetType(System.Int32), Nothing, System.Data.MappingType.Attribute)
            Me.Columns.Add(Me.columntes_ordenimp)
            Me.columntpa_orden = New DataColumn("tpa_orden", GetType(System.Int32), Nothing, System.Data.MappingType.Attribute)
            Me.Columns.Add(Me.columntpa_orden)
            Me.columnped_turno.Namespace = "http://tempuri.org/dts_hojaT.xsd"
            Me.columnpaciente.Namespace = "http://tempuri.org/dts_hojaT.xsd"
            Me.columntpa_desc.Namespace = "http://tempuri.org/dts_hojaT.xsd"
            Me.columnare_nombre.Namespace = "http://tempuri.org/dts_hojaT.xsd"
            Me.columnfecha.Namespace = "http://tempuri.org/dts_hojaT.xsd"
            Me.columntes_ordenimp.Namespace = "http://tempuri.org/dts_hojaT.xsd"
            Me.columntpa_orden.Namespace = "http://tempuri.org/dts_hojaT.xsd"
        End Sub
        
        Public Function NewHOJA_TRABAJORow() As HOJA_TRABAJORow
            Return CType(Me.NewRow,HOJA_TRABAJORow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New HOJA_TRABAJORow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(HOJA_TRABAJORow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.HOJA_TRABAJORowChangedEvent) Is Nothing) Then
                RaiseEvent HOJA_TRABAJORowChanged(Me, New HOJA_TRABAJORowChangeEvent(CType(e.Row,HOJA_TRABAJORow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.HOJA_TRABAJORowChangingEvent) Is Nothing) Then
                RaiseEvent HOJA_TRABAJORowChanging(Me, New HOJA_TRABAJORowChangeEvent(CType(e.Row,HOJA_TRABAJORow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.HOJA_TRABAJORowDeletedEvent) Is Nothing) Then
                RaiseEvent HOJA_TRABAJORowDeleted(Me, New HOJA_TRABAJORowChangeEvent(CType(e.Row,HOJA_TRABAJORow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.HOJA_TRABAJORowDeletingEvent) Is Nothing) Then
                RaiseEvent HOJA_TRABAJORowDeleting(Me, New HOJA_TRABAJORowChangeEvent(CType(e.Row,HOJA_TRABAJORow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveHOJA_TRABAJORow(ByVal row As HOJA_TRABAJORow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class HOJA_TRABAJORow
        Inherits DataRow
        
        Private tableHOJA_TRABAJO As HOJA_TRABAJODataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableHOJA_TRABAJO = CType(Me.Table,HOJA_TRABAJODataTable)
        End Sub
        
        Public Property ped_turno As Long
            Get
                Try 
                    Return CType(Me(Me.tableHOJA_TRABAJO.ped_turnoColumn),Long)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableHOJA_TRABAJO.ped_turnoColumn) = value
            End Set
        End Property
        
        Public Property paciente As String
            Get
                Try 
                    Return CType(Me(Me.tableHOJA_TRABAJO.pacienteColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableHOJA_TRABAJO.pacienteColumn) = value
            End Set
        End Property
        
        Public Property tpa_desc As String
            Get
                Try 
                    Return CType(Me(Me.tableHOJA_TRABAJO.tpa_descColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableHOJA_TRABAJO.tpa_descColumn) = value
            End Set
        End Property
        
        Public Property are_nombre As String
            Get
                Try 
                    Return CType(Me(Me.tableHOJA_TRABAJO.are_nombreColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableHOJA_TRABAJO.are_nombreColumn) = value
            End Set
        End Property
        
        Public Property fecha As Date
            Get
                Try 
                    Return CType(Me(Me.tableHOJA_TRABAJO.fechaColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableHOJA_TRABAJO.fechaColumn) = value
            End Set
        End Property
        
        Public Property tes_ordenimp As Integer
            Get
                Try 
                    Return CType(Me(Me.tableHOJA_TRABAJO.tes_ordenimpColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableHOJA_TRABAJO.tes_ordenimpColumn) = value
            End Set
        End Property
        
        Public Property tpa_orden As Integer
            Get
                Try 
                    Return CType(Me(Me.tableHOJA_TRABAJO.tpa_ordenColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableHOJA_TRABAJO.tpa_ordenColumn) = value
            End Set
        End Property
        
        Public Function Isped_turnoNull() As Boolean
            Return Me.IsNull(Me.tableHOJA_TRABAJO.ped_turnoColumn)
        End Function
        
        Public Sub Setped_turnoNull()
            Me(Me.tableHOJA_TRABAJO.ped_turnoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspacienteNull() As Boolean
            Return Me.IsNull(Me.tableHOJA_TRABAJO.pacienteColumn)
        End Function
        
        Public Sub SetpacienteNull()
            Me(Me.tableHOJA_TRABAJO.pacienteColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Istpa_descNull() As Boolean
            Return Me.IsNull(Me.tableHOJA_TRABAJO.tpa_descColumn)
        End Function
        
        Public Sub Settpa_descNull()
            Me(Me.tableHOJA_TRABAJO.tpa_descColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isare_nombreNull() As Boolean
            Return Me.IsNull(Me.tableHOJA_TRABAJO.are_nombreColumn)
        End Function
        
        Public Sub Setare_nombreNull()
            Me(Me.tableHOJA_TRABAJO.are_nombreColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsfechaNull() As Boolean
            Return Me.IsNull(Me.tableHOJA_TRABAJO.fechaColumn)
        End Function
        
        Public Sub SetfechaNull()
            Me(Me.tableHOJA_TRABAJO.fechaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Istes_ordenimpNull() As Boolean
            Return Me.IsNull(Me.tableHOJA_TRABAJO.tes_ordenimpColumn)
        End Function
        
        Public Sub Settes_ordenimpNull()
            Me(Me.tableHOJA_TRABAJO.tes_ordenimpColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Istpa_ordenNull() As Boolean
            Return Me.IsNull(Me.tableHOJA_TRABAJO.tpa_ordenColumn)
        End Function
        
        Public Sub Settpa_ordenNull()
            Me(Me.tableHOJA_TRABAJO.tpa_ordenColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class HOJA_TRABAJORowChangeEvent
        Inherits EventArgs
        
        Private eventRow As HOJA_TRABAJORow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As HOJA_TRABAJORow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As HOJA_TRABAJORow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
