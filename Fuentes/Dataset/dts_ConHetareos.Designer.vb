﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.9148
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''<summary>
'''Represents a strongly typed in-memory cache of data.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
 Global.System.Serializable(),  _
 Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 Global.System.Xml.Serialization.XmlRootAttribute("dts_ConHetareos"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class dts_ConHetareos
    Inherits Global.System.Data.DataSet
    
    Private tableCONHETAREOS As CONHETAREOSDataTable
    
    Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub New()
        MyBase.New
        Me.BeginInit
        Me.InitClass
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, false)
        If (Me.IsBinarySerialized(info, context) = true) Then
            Me.InitVars(false)
            Dim schemaChangedHandler1 As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)),String)
        If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet
            ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("CONHETAREOS")) Is Nothing) Then
                MyBase.Tables.Add(New CONHETAREOSDataTable(ds.Tables("CONHETAREOS")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.Browsable(false),  _
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property CONHETAREOS() As CONHETAREOSDataTable
        Get
            Return Me.tableCONHETAREOS
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.BrowsableAttribute(true),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)>  _
    Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set
            Me._schemaSerializationMode = value
        End Set
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)>  _
    Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit
        Me.InitClass
        Me.EndInit
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Overrides Function Clone() As Global.System.Data.DataSet
        Dim cln As dts_ConHetareos = CType(MyBase.Clone,dts_ConHetareos)
        cln.InitVars
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet
            ds.ReadXml(reader)
            If (Not (ds.Tables("CONHETAREOS")) Is Nothing) Then
                MyBase.Tables.Add(New CONHETAREOSDataTable(ds.Tables("CONHETAREOS")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.ReadXml(reader)
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
        Dim stream As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
        Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars()
        Me.InitVars(true)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableCONHETAREOS = CType(MyBase.Tables("CONHETAREOS"),CONHETAREOSDataTable)
        If (initTable = true) Then
            If (Not (Me.tableCONHETAREOS) Is Nothing) Then
                Me.tableCONHETAREOS.InitVars
            End If
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub InitClass()
        Me.DataSetName = "dts_ConHetareos"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dts_ConHetareos.xsd"
        Me.EnforceConstraints = true
        Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableCONHETAREOS = New CONHETAREOSDataTable
        MyBase.Tables.Add(Me.tableCONHETAREOS)
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Function ShouldSerializeCONHETAREOS() As Boolean
        Return false
    End Function
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
        Dim ds As dts_ConHetareos = New dts_ConHetareos
        Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType
        Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence
        Dim any As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
        If xs.Contains(dsSchema.TargetNamespace) Then
            Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
            Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
            Try 
                Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                dsSchema.Write(s1)
                Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                Do While schemas.MoveNext
                    schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                    s2.SetLength(0)
                    schema.Write(s2)
                    If (s1.Length = s2.Length) Then
                        s1.Position = 0
                        s2.Position = 0
                        
                        Do While ((s1.Position <> s1.Length)  _
                                    AndAlso (s1.ReadByte = s2.ReadByte))
                            
                            
                        Loop
                        If (s1.Position = s1.Length) Then
                            Return type
                        End If
                    End If
                    
                Loop
            Finally
                If (Not (s1) Is Nothing) Then
                    s1.Close
                End If
                If (Not (s2) Is Nothing) Then
                    s2.Close
                End If
            End Try
        End If
        xs.Add(dsSchema)
        Return type
    End Function
    
    Public Delegate Sub CONHETAREOSRowChangeEventHandler(ByVal sender As Object, ByVal e As CONHETAREOSRowChangeEvent)
    
    '''<summary>
    '''Represents the strongly named DataTable class.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"),  _
     Global.System.Serializable(),  _
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
    Partial Public Class CONHETAREOSDataTable
        Inherits Global.System.Data.DataTable
        Implements Global.System.Collections.IEnumerable
        
        Private columnFECHAI As Global.System.Data.DataColumn
        
        Private columnFECHAF As Global.System.Data.DataColumn
        
        Private columnpac_sexo As Global.System.Data.DataColumn
        
        Private columnpac_usafecnac As Global.System.Data.DataColumn
        
        Private columnpac_fecnac As Global.System.Data.DataColumn
        
        Private columnped_id As Global.System.Data.DataColumn
        
        Private columnedad As Global.System.Data.DataColumn
        
        Private columnexamenes As Global.System.Data.DataColumn
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New()
            MyBase.New
            Me.TableName = "CONHETAREOS"
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New
            Me.TableName = table.TableName
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
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property FECHAIColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnFECHAI
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property FECHAFColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnFECHAF
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property pac_sexoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnpac_sexo
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property pac_usafecnacColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnpac_usafecnac
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property pac_fecnacColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnpac_fecnac
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property ped_idColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnped_id
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property edadColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnedad
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property examenesColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnexamenes
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Default ReadOnly Property Item(ByVal index As Integer) As CONHETAREOSRow
            Get
                Return CType(Me.Rows(index),CONHETAREOSRow)
            End Get
        End Property
        
        Public Event CONHETAREOSRowChanging As CONHETAREOSRowChangeEventHandler
        
        Public Event CONHETAREOSRowChanged As CONHETAREOSRowChangeEventHandler
        
        Public Event CONHETAREOSRowDeleting As CONHETAREOSRowChangeEventHandler
        
        Public Event CONHETAREOSRowDeleted As CONHETAREOSRowChangeEventHandler
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Sub AddCONHETAREOSRow(ByVal row As CONHETAREOSRow)
            Me.Rows.Add(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overloads Function AddCONHETAREOSRow(ByVal FECHAI As Date, ByVal FECHAF As Date, ByVal pac_sexo As String, ByVal pac_usafecnac As Short, ByVal pac_fecnac As Date, ByVal ped_id As Long, ByVal edad As Long, ByVal examenes As Long) As CONHETAREOSRow
            Dim rowCONHETAREOSRow As CONHETAREOSRow = CType(Me.NewRow,CONHETAREOSRow)
            Dim columnValuesArray() As Object = New Object() {FECHAI, FECHAF, pac_sexo, pac_usafecnac, pac_fecnac, ped_id, edad, examenes}
            rowCONHETAREOSRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowCONHETAREOSRow)
            Return rowCONHETAREOSRow
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements Global.System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As CONHETAREOSDataTable = CType(MyBase.Clone,CONHETAREOSDataTable)
            cln.InitVars
            Return cln
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New CONHETAREOSDataTable
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub InitVars()
            Me.columnFECHAI = MyBase.Columns("FECHAI")
            Me.columnFECHAF = MyBase.Columns("FECHAF")
            Me.columnpac_sexo = MyBase.Columns("pac_sexo")
            Me.columnpac_usafecnac = MyBase.Columns("pac_usafecnac")
            Me.columnpac_fecnac = MyBase.Columns("pac_fecnac")
            Me.columnped_id = MyBase.Columns("ped_id")
            Me.columnedad = MyBase.Columns("edad")
            Me.columnexamenes = MyBase.Columns("examenes")
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Sub InitClass()
            Me.columnFECHAI = New Global.System.Data.DataColumn("FECHAI", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnFECHAI)
            Me.columnFECHAF = New Global.System.Data.DataColumn("FECHAF", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnFECHAF)
            Me.columnpac_sexo = New Global.System.Data.DataColumn("pac_sexo", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnpac_sexo)
            Me.columnpac_usafecnac = New Global.System.Data.DataColumn("pac_usafecnac", GetType(Short), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnpac_usafecnac)
            Me.columnpac_fecnac = New Global.System.Data.DataColumn("pac_fecnac", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnpac_fecnac)
            Me.columnped_id = New Global.System.Data.DataColumn("ped_id", GetType(Long), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnped_id)
            Me.columnedad = New Global.System.Data.DataColumn("edad", GetType(Long), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnedad)
            Me.columnexamenes = New Global.System.Data.DataColumn("examenes", GetType(Long), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnexamenes)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function NewCONHETAREOSRow() As CONHETAREOSRow
            Return CType(Me.NewRow,CONHETAREOSRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New CONHETAREOSRow(builder)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(CONHETAREOSRow)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.CONHETAREOSRowChangedEvent) Is Nothing) Then
                RaiseEvent CONHETAREOSRowChanged(Me, New CONHETAREOSRowChangeEvent(CType(e.Row,CONHETAREOSRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.CONHETAREOSRowChangingEvent) Is Nothing) Then
                RaiseEvent CONHETAREOSRowChanging(Me, New CONHETAREOSRowChangeEvent(CType(e.Row,CONHETAREOSRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.CONHETAREOSRowDeletedEvent) Is Nothing) Then
                RaiseEvent CONHETAREOSRowDeleted(Me, New CONHETAREOSRowChangeEvent(CType(e.Row,CONHETAREOSRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.CONHETAREOSRowDeletingEvent) Is Nothing) Then
                RaiseEvent CONHETAREOSRowDeleting(Me, New CONHETAREOSRowChangeEvent(CType(e.Row,CONHETAREOSRow), e.Action))
            End If
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub RemoveCONHETAREOSRow(ByVal row As CONHETAREOSRow)
            Me.Rows.Remove(row)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence
            Dim ds As dts_ConHetareos = New dts_ConHetareos
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "CONHETAREOSDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream
                Try 
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current,Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0
                            
                            Do While ((s1.Position <> s1.Length)  _
                                        AndAlso (s1.ReadByte = s2.ReadByte))
                                
                                
                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If
                        
                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class
    
    '''<summary>
    '''Represents strongly named DataRow class.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Partial Public Class CONHETAREOSRow
        Inherits Global.System.Data.DataRow
        
        Private tableCONHETAREOS As CONHETAREOSDataTable
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableCONHETAREOS = CType(Me.Table,CONHETAREOSDataTable)
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property FECHAI() As Date
            Get
                Try 
                    Return CType(Me(Me.tableCONHETAREOS.FECHAIColumn),Date)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'FECHAI' de la tabla 'CONHETAREOS' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCONHETAREOS.FECHAIColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property FECHAF() As Date
            Get
                Try 
                    Return CType(Me(Me.tableCONHETAREOS.FECHAFColumn),Date)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'FECHAF' de la tabla 'CONHETAREOS' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCONHETAREOS.FECHAFColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property pac_sexo() As String
            Get
                Try 
                    Return CType(Me(Me.tableCONHETAREOS.pac_sexoColumn),String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'pac_sexo' de la tabla 'CONHETAREOS' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCONHETAREOS.pac_sexoColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property pac_usafecnac() As Short
            Get
                Try 
                    Return CType(Me(Me.tableCONHETAREOS.pac_usafecnacColumn),Short)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'pac_usafecnac' de la tabla 'CONHETAREOS' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCONHETAREOS.pac_usafecnacColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property pac_fecnac() As Date
            Get
                Try 
                    Return CType(Me(Me.tableCONHETAREOS.pac_fecnacColumn),Date)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'pac_fecnac' de la tabla 'CONHETAREOS' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCONHETAREOS.pac_fecnacColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property ped_id() As Long
            Get
                Try 
                    Return CType(Me(Me.tableCONHETAREOS.ped_idColumn),Long)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'ped_id' de la tabla 'CONHETAREOS' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCONHETAREOS.ped_idColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property edad() As Long
            Get
                Try 
                    Return CType(Me(Me.tableCONHETAREOS.edadColumn),Long)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'edad' de la tabla 'CONHETAREOS' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCONHETAREOS.edadColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property examenes() As Long
            Get
                Try 
                    Return CType(Me(Me.tableCONHETAREOS.examenesColumn),Long)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'examenes' de la tabla 'CONHETAREOS' es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCONHETAREOS.examenesColumn) = value
            End Set
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsFECHAINull() As Boolean
            Return Me.IsNull(Me.tableCONHETAREOS.FECHAIColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetFECHAINull()
            Me(Me.tableCONHETAREOS.FECHAIColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsFECHAFNull() As Boolean
            Return Me.IsNull(Me.tableCONHETAREOS.FECHAFColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetFECHAFNull()
            Me(Me.tableCONHETAREOS.FECHAFColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function Ispac_sexoNull() As Boolean
            Return Me.IsNull(Me.tableCONHETAREOS.pac_sexoColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Setpac_sexoNull()
            Me(Me.tableCONHETAREOS.pac_sexoColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function Ispac_usafecnacNull() As Boolean
            Return Me.IsNull(Me.tableCONHETAREOS.pac_usafecnacColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Setpac_usafecnacNull()
            Me(Me.tableCONHETAREOS.pac_usafecnacColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function Ispac_fecnacNull() As Boolean
            Return Me.IsNull(Me.tableCONHETAREOS.pac_fecnacColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Setpac_fecnacNull()
            Me(Me.tableCONHETAREOS.pac_fecnacColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function Isped_idNull() As Boolean
            Return Me.IsNull(Me.tableCONHETAREOS.ped_idColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Setped_idNull()
            Me(Me.tableCONHETAREOS.ped_idColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsedadNull() As Boolean
            Return Me.IsNull(Me.tableCONHETAREOS.edadColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetedadNull()
            Me(Me.tableCONHETAREOS.edadColumn) = Global.System.Convert.DBNull
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function IsexamenesNull() As Boolean
            Return Me.IsNull(Me.tableCONHETAREOS.examenesColumn)
        End Function
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub SetexamenesNull()
            Me(Me.tableCONHETAREOS.examenesColumn) = Global.System.Convert.DBNull
        End Sub
    End Class
    
    '''<summary>
    '''Row event argument class
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")>  _
    Public Class CONHETAREOSRowChangeEvent
        Inherits Global.System.EventArgs
        
        Private eventRow As CONHETAREOSRow
        
        Private eventAction As Global.System.Data.DataRowAction
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub New(ByVal row As CONHETAREOSRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Row() As CONHETAREOSRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
