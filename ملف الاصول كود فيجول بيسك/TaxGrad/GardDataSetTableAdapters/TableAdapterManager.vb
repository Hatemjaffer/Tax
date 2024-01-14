Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports TaxGrad

Namespace TaxGrad.GardDataSetTableAdapters
    <Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), ToolboxItem(True), DesignerCategory("code"), HelpKeyword("vs.data.TableAdapterManager")> _
    Public Class TableAdapterManager
        Inherits Component
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            TableAdapterManager.__ENCAddToList(Me)
        End Sub

        <DebuggerNonUserCode> _
        Private Shared Sub __ENCAddToList(ByVal value As Object)
            Dim list As List(Of WeakReference) = TableAdapterManager.__ENCList
            SyncLock list
                If (TableAdapterManager.__ENCList.Count = TableAdapterManager.__ENCList.Capacity) Then
                    Dim index As Integer = 0
                    Dim num3 As Integer = (TableAdapterManager.__ENCList.Count - 1)
                    Dim num2 As Integer = 0
                    Do While True
                        Dim num4 As Integer = num3
                        If (num2 > num4) Then
                            TableAdapterManager.__ENCList.RemoveRange(index, (TableAdapterManager.__ENCList.Count - index))
                            TableAdapterManager.__ENCList.Capacity = TableAdapterManager.__ENCList.Count
                            Exit Do
                        End If
                        Dim reference As WeakReference = TableAdapterManager.__ENCList.Item(num2)
                        If reference.IsAlive Then
                            If (num2 <> index) Then
                                TableAdapterManager.__ENCList.Item(index) = TableAdapterManager.__ENCList.Item(num2)
                            End If
                            index += 1
                        End If
                        num2 += 1
                    Loop
                End If
                TableAdapterManager.__ENCList.Add(New WeakReference(value))
            End SyncLock
        End Sub

        <DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Function GetRealUpdatedRows(ByVal updatedRows As DataRow(), ByVal allAddedRows As List(Of DataRow)) As DataRow()
            Dim rowArray As DataRow()
            Dim num1 As Integer
            If ((updatedRows Is Nothing) OrElse (updatedRows.Length < 1)) Then
                num1 = 1
            Else
                num1 = 0
            End If
            If (num1 <> 0) Then
                rowArray = updatedRows
            Else
                Dim num2 As Integer
                If ((allAddedRows Is Nothing) OrElse (allAddedRows.Count < 1)) Then
                    num2 = 1
                Else
                    num2 = 0
                End If
                If (num2 <> 0) Then
                    rowArray = updatedRows
                Else
                    Dim list As New List(Of DataRow)
                    Dim index As Integer = 0
                    Do While True
                        If (index >= updatedRows.Length) Then
                            rowArray = list.ToArray
                            Exit Do
                        End If
                        Dim item As DataRow = updatedRows(index)
                        If Not allAddedRows.Contains(item) Then
                            list.Add(item)
                        End If
                        index += 1
                    Loop
                End If
            End If
            Return rowArray
        End Function

        <DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overridable Function MatchTableAdapterConnection(ByVal inputConnection As IDbConnection) As Boolean
            Dim flag As Boolean
            If (Not Me._connection Is Nothing) Then
                flag = True
            Else
                Dim num1 As Integer
                If ((Me.Connection Is Nothing) OrElse (inputConnection Is Nothing)) Then
                    num1 = 1
                Else
                    num1 = 0
                End If
                If (num1 <> 0) Then
                    flag = True
                Else
                    flag = String.Equals(Me.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal)
                End If
            End If
            Return flag
        End Function

        <DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overridable Sub SortSelfReferenceRows(ByVal rows As DataRow(), ByVal relation As DataRelation, ByVal childFirst As Boolean)
            Array.Sort(Of DataRow)(rows, New SelfReferenceComparer(relation, childFirst))
        End Sub

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
        Public Overridable Function UpdateAll(ByVal dataSet As GardDataSet) As Integer
            Dim num2 As Integer
            If (dataSet Is Nothing) Then
                Throw New ArgumentNullException("dataSet")
            End If
            If Not dataSet.HasChanges Then
                num2 = 0
            Else
                Dim num1 As Integer
                Dim num7 As Integer
                Dim num8 As Integer
                Dim num9 As Integer
                Dim num10 As Integer
                Dim num11 As Integer
                Dim num12 As Integer
                Dim num13 As Integer
                Dim num14 As Integer
                Dim num15 As Integer
                Dim num16 As Integer
                Dim num17 As Integer
                Dim num18 As Integer
                Dim num19 As Integer
                Dim num20 As Integer
                If ((Me._edaraTableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._edaraTableAdapter.Connection)) Then
                    num1 = 0
                Else
                    num1 = 1
                End If
                If (num1 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._empTableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._empTableAdapter.Connection)) Then
                    num7 = 0
                Else
                    num7 = 1
                End If
                If (num7 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._nmodgTableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._nmodgTableAdapter.Connection)) Then
                    num8 = 0
                Else
                    num8 = 1
                End If
                If (num8 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._ossolTableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._ossolTableAdapter.Connection)) Then
                    num9 = 0
                Else
                    num9 = 1
                End If
                If (num9 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._userTableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._userTableAdapter.Connection)) Then
                    num10 = 0
                Else
                    num10 = 1
                End If
                If (num10 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._ossol1TableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._ossol1TableAdapter.Connection)) Then
                    num11 = 0
                Else
                    num11 = 1
                End If
                If (num11 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._nmodgDDTableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._nmodgDDTableAdapter.Connection)) Then
                    num12 = 0
                Else
                    num12 = 1
                End If
                If (num12 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._edara1TableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._edara1TableAdapter.Connection)) Then
                    num13 = 0
                Else
                    num13 = 1
                End If
                If (num13 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._ossolTypeTableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._ossolTypeTableAdapter.Connection)) Then
                    num14 = 0
                Else
                    num14 = 1
                End If
                If (num14 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._ossolType1TableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._ossolType1TableAdapter.Connection)) Then
                    num15 = 0
                Else
                    num15 = 1
                End If
                If (num15 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._ksmTableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._ksmTableAdapter.Connection)) Then
                    num16 = 0
                Else
                    num16 = 1
                End If
                If (num16 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._ksm1TableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._ksm1TableAdapter.Connection)) Then
                    num17 = 0
                Else
                    num17 = 1
                End If
                If (num17 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._typeTableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._typeTableAdapter.Connection)) Then
                    num18 = 0
                Else
                    num18 = 1
                End If
                If (num18 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._type1TableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._type1TableAdapter.Connection)) Then
                    num19 = 0
                Else
                    num19 = 1
                End If
                If (num19 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                If ((Me._nmodgDTableAdapter Is Nothing) OrElse Me.MatchTableAdapterConnection(Me._nmodgDTableAdapter.Connection)) Then
                    num20 = 0
                Else
                    num20 = 1
                End If
                If (num20 <> 0) Then
                    Throw New ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.")
                End If
                Dim connection As IDbConnection = Me.Connection
                If (connection Is Nothing) Then
                    Throw New ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.")
                End If
                Dim flag As Boolean = False
                If ((connection.State And ConnectionState.Broken) = ConnectionState.Broken) Then
                    connection.Close
                End If
                If (connection.State = ConnectionState.Closed) Then
                    connection.Open
                    flag = True
                End If
                Dim transaction As IDbTransaction = connection.BeginTransaction
                If (transaction Is Nothing) Then
                    Throw New ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.")
                End If
                Dim allChangedRows As New List(Of DataRow)
                Dim allAddedRows As New List(Of DataRow)
                Dim list As New List(Of DataAdapter)
                Dim dictionary As New Dictionary(Of Object, IDbConnection)
                Dim num As Integer = 0
                Dim set As DataSet = Nothing
                If Me.BackupDataSetBeforeUpdate Then
                    New DataSet().Merge(dataSet)
                End If
                Try 
                    If (Not Me._edaraTableAdapter Is Nothing) Then
                        dictionary.Add(Me._edaraTableAdapter, Me._edaraTableAdapter.Connection)
                        Me._edaraTableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._edaraTableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._edaraTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._edaraTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._edaraTableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._empTableAdapter Is Nothing) Then
                        dictionary.Add(Me._empTableAdapter, Me._empTableAdapter.Connection)
                        Me._empTableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._empTableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._empTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._empTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._empTableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._nmodgTableAdapter Is Nothing) Then
                        dictionary.Add(Me._nmodgTableAdapter, Me._nmodgTableAdapter.Connection)
                        Me._nmodgTableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._nmodgTableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._nmodgTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._nmodgTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._nmodgTableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._ossolTableAdapter Is Nothing) Then
                        dictionary.Add(Me._ossolTableAdapter, Me._ossolTableAdapter.Connection)
                        Me._ossolTableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._ossolTableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._ossolTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._ossolTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._ossolTableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._userTableAdapter Is Nothing) Then
                        dictionary.Add(Me._userTableAdapter, Me._userTableAdapter.Connection)
                        Me._userTableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._userTableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._userTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._userTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._userTableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._ossol1TableAdapter Is Nothing) Then
                        dictionary.Add(Me._ossol1TableAdapter, Me._ossol1TableAdapter.Connection)
                        Me._ossol1TableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._ossol1TableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._ossol1TableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._ossol1TableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._ossol1TableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._nmodgDDTableAdapter Is Nothing) Then
                        dictionary.Add(Me._nmodgDDTableAdapter, Me._nmodgDDTableAdapter.Connection)
                        Me._nmodgDDTableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._nmodgDDTableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._nmodgDDTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._nmodgDDTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._nmodgDDTableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._edara1TableAdapter Is Nothing) Then
                        dictionary.Add(Me._edara1TableAdapter, Me._edara1TableAdapter.Connection)
                        Me._edara1TableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._edara1TableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._edara1TableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._edara1TableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._edara1TableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._ossolTypeTableAdapter Is Nothing) Then
                        dictionary.Add(Me._ossolTypeTableAdapter, Me._ossolTypeTableAdapter.Connection)
                        Me._ossolTypeTableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._ossolTypeTableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._ossolTypeTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._ossolTypeTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._ossolTypeTableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._ossolType1TableAdapter Is Nothing) Then
                        dictionary.Add(Me._ossolType1TableAdapter, Me._ossolType1TableAdapter.Connection)
                        Me._ossolType1TableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._ossolType1TableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._ossolType1TableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._ossolType1TableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._ossolType1TableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._ksmTableAdapter Is Nothing) Then
                        dictionary.Add(Me._ksmTableAdapter, Me._ksmTableAdapter.Connection)
                        Me._ksmTableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._ksmTableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._ksmTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._ksmTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._ksmTableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._ksm1TableAdapter Is Nothing) Then
                        dictionary.Add(Me._ksm1TableAdapter, Me._ksm1TableAdapter.Connection)
                        Me._ksm1TableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._ksm1TableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._ksm1TableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._ksm1TableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._ksm1TableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._typeTableAdapter Is Nothing) Then
                        dictionary.Add(Me._typeTableAdapter, Me._typeTableAdapter.Connection)
                        Me._typeTableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._typeTableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._typeTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._typeTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._typeTableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._type1TableAdapter Is Nothing) Then
                        dictionary.Add(Me._type1TableAdapter, Me._type1TableAdapter.Connection)
                        Me._type1TableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._type1TableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._type1TableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._type1TableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._type1TableAdapter.Adapter)
                        End If
                    End If
                    If (Not Me._nmodgDTableAdapter Is Nothing) Then
                        dictionary.Add(Me._nmodgDTableAdapter, Me._nmodgDTableAdapter.Connection)
                        Me._nmodgDTableAdapter.Connection = DirectCast(connection, SqlConnection)
                        Me._nmodgDTableAdapter.Transaction = DirectCast(transaction, SqlTransaction)
                        If Me._nmodgDTableAdapter.Adapter.AcceptChangesDuringUpdate Then
                            Me._nmodgDTableAdapter.Adapter.AcceptChangesDuringUpdate = False
                            list.Add(Me._nmodgDTableAdapter.Adapter)
                        End If
                    End If
                    If (Me.UpdateOrder = UpdateOrderOption.UpdateInsertDelete) Then
                        num = ((num + Me.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows)) + Me.UpdateInsertedRows(dataSet, allAddedRows))
                    Else
                        num = ((num + Me.UpdateInsertedRows(dataSet, allAddedRows)) + Me.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows))
                    End If
                    num = (num + Me.UpdateDeletedRows(dataSet, allChangedRows))
                    transaction.Commit
                    If (0 < allAddedRows.Count) Then
                        Dim array As DataRow() = New DataRow(((allAddedRows.Count - 1) + 1)  - 1) {}
                        allAddedRows.CopyTo(array)
                        Dim index As Integer = 0
                        Do While True
                            If (index >= array.Length) Then
                                Exit Do
                            End If
                            array(index).AcceptChanges
                            index += 1
                        Loop
                    End If
                    If (0 < allChangedRows.Count) Then
                        Dim array As DataRow() = New DataRow(((allChangedRows.Count - 1) + 1)  - 1) {}
                        allChangedRows.CopyTo(array)
                        Dim index As Integer = 0
                        Do While True
                            If (index >= array.Length) Then
                                Exit Do
                            End If
                            array(index).AcceptChanges
                            index += 1
                        Loop
                    End If
                Catch exception1 As Exception
                    Dim local1 As Exception = exception1
                    ProjectData.SetProjectError(local1)
                    Dim exception As Exception = local1
                    transaction.Rollback
                    If Me.BackupDataSetBeforeUpdate Then
                        Debug.Assert((Not [set] Is Nothing))
                        dataSet.Clear
                        dataSet.Merge([set])
                    ElseIf (0 < allAddedRows.Count) Then
                        Dim array As DataRow() = New DataRow(((allAddedRows.Count - 1) + 1)  - 1) {}
                        allAddedRows.CopyTo(array)
                        Dim index As Integer = 0
                        Do While True
                            If (index >= array.Length) Then
                                Exit Do
                            End If
                            Dim row3 As DataRow = array(index)
                            row3.AcceptChanges
                            row3.SetAdded
                            index += 1
                        Loop
                    End If
                    Throw exception
                Finally
                    If flag Then
                        connection.Close
                    End If
                    If (Not Me._edaraTableAdapter Is Nothing) Then
                        Me._edaraTableAdapter.Connection = DirectCast(dictionary.Item(Me._edaraTableAdapter), SqlConnection)
                        Me._edaraTableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._empTableAdapter Is Nothing) Then
                        Me._empTableAdapter.Connection = DirectCast(dictionary.Item(Me._empTableAdapter), SqlConnection)
                        Me._empTableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._nmodgTableAdapter Is Nothing) Then
                        Me._nmodgTableAdapter.Connection = DirectCast(dictionary.Item(Me._nmodgTableAdapter), SqlConnection)
                        Me._nmodgTableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._ossolTableAdapter Is Nothing) Then
                        Me._ossolTableAdapter.Connection = DirectCast(dictionary.Item(Me._ossolTableAdapter), SqlConnection)
                        Me._ossolTableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._userTableAdapter Is Nothing) Then
                        Me._userTableAdapter.Connection = DirectCast(dictionary.Item(Me._userTableAdapter), SqlConnection)
                        Me._userTableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._ossol1TableAdapter Is Nothing) Then
                        Me._ossol1TableAdapter.Connection = DirectCast(dictionary.Item(Me._ossol1TableAdapter), SqlConnection)
                        Me._ossol1TableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._nmodgDDTableAdapter Is Nothing) Then
                        Me._nmodgDDTableAdapter.Connection = DirectCast(dictionary.Item(Me._nmodgDDTableAdapter), SqlConnection)
                        Me._nmodgDDTableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._edara1TableAdapter Is Nothing) Then
                        Me._edara1TableAdapter.Connection = DirectCast(dictionary.Item(Me._edara1TableAdapter), SqlConnection)
                        Me._edara1TableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._ossolTypeTableAdapter Is Nothing) Then
                        Me._ossolTypeTableAdapter.Connection = DirectCast(dictionary.Item(Me._ossolTypeTableAdapter), SqlConnection)
                        Me._ossolTypeTableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._ossolType1TableAdapter Is Nothing) Then
                        Me._ossolType1TableAdapter.Connection = DirectCast(dictionary.Item(Me._ossolType1TableAdapter), SqlConnection)
                        Me._ossolType1TableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._ksmTableAdapter Is Nothing) Then
                        Me._ksmTableAdapter.Connection = DirectCast(dictionary.Item(Me._ksmTableAdapter), SqlConnection)
                        Me._ksmTableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._ksm1TableAdapter Is Nothing) Then
                        Me._ksm1TableAdapter.Connection = DirectCast(dictionary.Item(Me._ksm1TableAdapter), SqlConnection)
                        Me._ksm1TableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._typeTableAdapter Is Nothing) Then
                        Me._typeTableAdapter.Connection = DirectCast(dictionary.Item(Me._typeTableAdapter), SqlConnection)
                        Me._typeTableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._type1TableAdapter Is Nothing) Then
                        Me._type1TableAdapter.Connection = DirectCast(dictionary.Item(Me._type1TableAdapter), SqlConnection)
                        Me._type1TableAdapter.Transaction = Nothing
                    End If
                    If (Not Me._nmodgDTableAdapter Is Nothing) Then
                        Me._nmodgDTableAdapter.Connection = DirectCast(dictionary.Item(Me._nmodgDTableAdapter), SqlConnection)
                        Me._nmodgDTableAdapter.Transaction = Nothing
                    End If
                    If (0 < list.Count) Then
                        Dim array As DataAdapter() = New DataAdapter(((list.Count - 1) + 1)  - 1) {}
                        list.CopyTo(array)
                        Dim index As Integer = 0
                        Do While True
                            If (index >= array.Length) Then
                                Exit Do
                            End If
                            Dim adapter As DataAdapter = array(index)
                            adapter.AcceptChangesDuringUpdate = True
                            index += 1
                        Loop
                    End If
                End Try
                num2 = num
            End If
            Return num2
        End Function

        <DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Function UpdateDeletedRows(ByVal dataSet As GardDataSet, ByVal allChangedRows As List(Of DataRow)) As Integer
            Dim num As Integer = 0
            If (Not Me._nmodgDTableAdapter Is Nothing) Then
                Dim num1 As Integer
                Dim dataRows As DataRow() = dataSet.NmodgD.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num1 = 0
                Else
                    num1 = 1
                End If
                If (num1 <> 0) Then
                    num = (num + Me._nmodgDTableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._type1TableAdapter Is Nothing) Then
                Dim num3 As Integer
                Dim dataRows As DataRow() = dataSet.Type1.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num3 = 0
                Else
                    num3 = 1
                End If
                If (num3 <> 0) Then
                    num = (num + Me._type1TableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._typeTableAdapter Is Nothing) Then
                Dim num4 As Integer
                Dim dataRows As DataRow() = dataSet.Type.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num4 = 0
                Else
                    num4 = 1
                End If
                If (num4 <> 0) Then
                    num = (num + Me._typeTableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ksm1TableAdapter Is Nothing) Then
                Dim num5 As Integer
                Dim dataRows As DataRow() = dataSet.Ksm1.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num5 = 0
                Else
                    num5 = 1
                End If
                If (num5 <> 0) Then
                    num = (num + Me._ksm1TableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ksmTableAdapter Is Nothing) Then
                Dim num6 As Integer
                Dim dataRows As DataRow() = dataSet.Ksm.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num6 = 0
                Else
                    num6 = 1
                End If
                If (num6 <> 0) Then
                    num = (num + Me._ksmTableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ossolType1TableAdapter Is Nothing) Then
                Dim num7 As Integer
                Dim dataRows As DataRow() = dataSet.OssolType1.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num7 = 0
                Else
                    num7 = 1
                End If
                If (num7 <> 0) Then
                    num = (num + Me._ossolType1TableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ossolTypeTableAdapter Is Nothing) Then
                Dim num8 As Integer
                Dim dataRows As DataRow() = dataSet.OssolType.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num8 = 0
                Else
                    num8 = 1
                End If
                If (num8 <> 0) Then
                    num = (num + Me._ossolTypeTableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._edara1TableAdapter Is Nothing) Then
                Dim num9 As Integer
                Dim dataRows As DataRow() = dataSet.Edara1.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num9 = 0
                Else
                    num9 = 1
                End If
                If (num9 <> 0) Then
                    num = (num + Me._edara1TableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._nmodgDDTableAdapter Is Nothing) Then
                Dim num10 As Integer
                Dim dataRows As DataRow() = dataSet.NmodgDD.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num10 = 0
                Else
                    num10 = 1
                End If
                If (num10 <> 0) Then
                    num = (num + Me._nmodgDDTableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ossol1TableAdapter Is Nothing) Then
                Dim num11 As Integer
                Dim dataRows As DataRow() = dataSet.Ossol1.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num11 = 0
                Else
                    num11 = 1
                End If
                If (num11 <> 0) Then
                    num = (num + Me._ossol1TableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._userTableAdapter Is Nothing) Then
                Dim num12 As Integer
                Dim dataRows As DataRow() = dataSet.User.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num12 = 0
                Else
                    num12 = 1
                End If
                If (num12 <> 0) Then
                    num = (num + Me._userTableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ossolTableAdapter Is Nothing) Then
                Dim num13 As Integer
                Dim dataRows As DataRow() = dataSet.Ossol.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num13 = 0
                Else
                    num13 = 1
                End If
                If (num13 <> 0) Then
                    num = (num + Me._ossolTableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._nmodgTableAdapter Is Nothing) Then
                Dim num14 As Integer
                Dim dataRows As DataRow() = dataSet.Nmodg.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num14 = 0
                Else
                    num14 = 1
                End If
                If (num14 <> 0) Then
                    num = (num + Me._nmodgTableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._empTableAdapter Is Nothing) Then
                Dim num15 As Integer
                Dim dataRows As DataRow() = dataSet.Emp.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num15 = 0
                Else
                    num15 = 1
                End If
                If (num15 <> 0) Then
                    num = (num + Me._empTableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._edaraTableAdapter Is Nothing) Then
                Dim num16 As Integer
                Dim dataRows As DataRow() = dataSet.Edara.Select(Nothing, Nothing, DataViewRowState.Deleted)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num16 = 0
                Else
                    num16 = 1
                End If
                If (num16 <> 0) Then
                    num = (num + Me._edaraTableAdapter.Update(dataRows))
                    allChangedRows.AddRange(dataRows)
                End If
            End If
            Return num
        End Function

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
        Private Function UpdateInsertedRows(ByVal dataSet As GardDataSet, ByVal allAddedRows As List(Of DataRow)) As Integer
            Dim num As Integer = 0
            If (Not Me._edaraTableAdapter Is Nothing) Then
                Dim num1 As Integer
                Dim dataRows As DataRow() = dataSet.Edara.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num1 = 0
                Else
                    num1 = 1
                End If
                If (num1 <> 0) Then
                    num = (num + Me._edaraTableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._empTableAdapter Is Nothing) Then
                Dim num3 As Integer
                Dim dataRows As DataRow() = dataSet.Emp.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num3 = 0
                Else
                    num3 = 1
                End If
                If (num3 <> 0) Then
                    num = (num + Me._empTableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._nmodgTableAdapter Is Nothing) Then
                Dim num4 As Integer
                Dim dataRows As DataRow() = dataSet.Nmodg.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num4 = 0
                Else
                    num4 = 1
                End If
                If (num4 <> 0) Then
                    num = (num + Me._nmodgTableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ossolTableAdapter Is Nothing) Then
                Dim num5 As Integer
                Dim dataRows As DataRow() = dataSet.Ossol.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num5 = 0
                Else
                    num5 = 1
                End If
                If (num5 <> 0) Then
                    num = (num + Me._ossolTableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._userTableAdapter Is Nothing) Then
                Dim num6 As Integer
                Dim dataRows As DataRow() = dataSet.User.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num6 = 0
                Else
                    num6 = 1
                End If
                If (num6 <> 0) Then
                    num = (num + Me._userTableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ossol1TableAdapter Is Nothing) Then
                Dim num7 As Integer
                Dim dataRows As DataRow() = dataSet.Ossol1.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num7 = 0
                Else
                    num7 = 1
                End If
                If (num7 <> 0) Then
                    num = (num + Me._ossol1TableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._nmodgDDTableAdapter Is Nothing) Then
                Dim num8 As Integer
                Dim dataRows As DataRow() = dataSet.NmodgDD.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num8 = 0
                Else
                    num8 = 1
                End If
                If (num8 <> 0) Then
                    num = (num + Me._nmodgDDTableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._edara1TableAdapter Is Nothing) Then
                Dim num9 As Integer
                Dim dataRows As DataRow() = dataSet.Edara1.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num9 = 0
                Else
                    num9 = 1
                End If
                If (num9 <> 0) Then
                    num = (num + Me._edara1TableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ossolTypeTableAdapter Is Nothing) Then
                Dim num10 As Integer
                Dim dataRows As DataRow() = dataSet.OssolType.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num10 = 0
                Else
                    num10 = 1
                End If
                If (num10 <> 0) Then
                    num = (num + Me._ossolTypeTableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ossolType1TableAdapter Is Nothing) Then
                Dim num11 As Integer
                Dim dataRows As DataRow() = dataSet.OssolType1.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num11 = 0
                Else
                    num11 = 1
                End If
                If (num11 <> 0) Then
                    num = (num + Me._ossolType1TableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ksmTableAdapter Is Nothing) Then
                Dim num12 As Integer
                Dim dataRows As DataRow() = dataSet.Ksm.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num12 = 0
                Else
                    num12 = 1
                End If
                If (num12 <> 0) Then
                    num = (num + Me._ksmTableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._ksm1TableAdapter Is Nothing) Then
                Dim num13 As Integer
                Dim dataRows As DataRow() = dataSet.Ksm1.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num13 = 0
                Else
                    num13 = 1
                End If
                If (num13 <> 0) Then
                    num = (num + Me._ksm1TableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._typeTableAdapter Is Nothing) Then
                Dim num14 As Integer
                Dim dataRows As DataRow() = dataSet.Type.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num14 = 0
                Else
                    num14 = 1
                End If
                If (num14 <> 0) Then
                    num = (num + Me._typeTableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._type1TableAdapter Is Nothing) Then
                Dim num15 As Integer
                Dim dataRows As DataRow() = dataSet.Type1.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num15 = 0
                Else
                    num15 = 1
                End If
                If (num15 <> 0) Then
                    num = (num + Me._type1TableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            If (Not Me._nmodgDTableAdapter Is Nothing) Then
                Dim num16 As Integer
                Dim dataRows As DataRow() = dataSet.NmodgD.Select(Nothing, Nothing, DataViewRowState.Added)
                If ((dataRows Is Nothing) OrElse (0 >= dataRows.Length)) Then
                    num16 = 0
                Else
                    num16 = 1
                End If
                If (num16 <> 0) Then
                    num = (num + Me._nmodgDTableAdapter.Update(dataRows))
                    allAddedRows.AddRange(dataRows)
                End If
            End If
            Return num
        End Function

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
        Private Function UpdateUpdatedRows(ByVal dataSet As GardDataSet, ByVal allChangedRows As List(Of DataRow), ByVal allAddedRows As List(Of DataRow)) As Integer
            Dim num As Integer = 0
            If (Not Me._edaraTableAdapter Is Nothing) Then
                Dim num1 As Integer
                Dim updatedRows As DataRow() = dataSet.Edara.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num1 = 0
                Else
                    num1 = 1
                End If
                If (num1 <> 0) Then
                    num = (num + Me._edaraTableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._empTableAdapter Is Nothing) Then
                Dim num3 As Integer
                Dim updatedRows As DataRow() = dataSet.Emp.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num3 = 0
                Else
                    num3 = 1
                End If
                If (num3 <> 0) Then
                    num = (num + Me._empTableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._nmodgTableAdapter Is Nothing) Then
                Dim num4 As Integer
                Dim updatedRows As DataRow() = dataSet.Nmodg.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num4 = 0
                Else
                    num4 = 1
                End If
                If (num4 <> 0) Then
                    num = (num + Me._nmodgTableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._ossolTableAdapter Is Nothing) Then
                Dim num5 As Integer
                Dim updatedRows As DataRow() = dataSet.Ossol.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num5 = 0
                Else
                    num5 = 1
                End If
                If (num5 <> 0) Then
                    num = (num + Me._ossolTableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._userTableAdapter Is Nothing) Then
                Dim num6 As Integer
                Dim updatedRows As DataRow() = dataSet.User.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num6 = 0
                Else
                    num6 = 1
                End If
                If (num6 <> 0) Then
                    num = (num + Me._userTableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._ossol1TableAdapter Is Nothing) Then
                Dim num7 As Integer
                Dim updatedRows As DataRow() = dataSet.Ossol1.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num7 = 0
                Else
                    num7 = 1
                End If
                If (num7 <> 0) Then
                    num = (num + Me._ossol1TableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._nmodgDDTableAdapter Is Nothing) Then
                Dim num8 As Integer
                Dim updatedRows As DataRow() = dataSet.NmodgDD.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num8 = 0
                Else
                    num8 = 1
                End If
                If (num8 <> 0) Then
                    num = (num + Me._nmodgDDTableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._edara1TableAdapter Is Nothing) Then
                Dim num9 As Integer
                Dim updatedRows As DataRow() = dataSet.Edara1.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num9 = 0
                Else
                    num9 = 1
                End If
                If (num9 <> 0) Then
                    num = (num + Me._edara1TableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._ossolTypeTableAdapter Is Nothing) Then
                Dim num10 As Integer
                Dim updatedRows As DataRow() = dataSet.OssolType.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num10 = 0
                Else
                    num10 = 1
                End If
                If (num10 <> 0) Then
                    num = (num + Me._ossolTypeTableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._ossolType1TableAdapter Is Nothing) Then
                Dim num11 As Integer
                Dim updatedRows As DataRow() = dataSet.OssolType1.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num11 = 0
                Else
                    num11 = 1
                End If
                If (num11 <> 0) Then
                    num = (num + Me._ossolType1TableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._ksmTableAdapter Is Nothing) Then
                Dim num12 As Integer
                Dim updatedRows As DataRow() = dataSet.Ksm.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num12 = 0
                Else
                    num12 = 1
                End If
                If (num12 <> 0) Then
                    num = (num + Me._ksmTableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._ksm1TableAdapter Is Nothing) Then
                Dim num13 As Integer
                Dim updatedRows As DataRow() = dataSet.Ksm1.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num13 = 0
                Else
                    num13 = 1
                End If
                If (num13 <> 0) Then
                    num = (num + Me._ksm1TableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._typeTableAdapter Is Nothing) Then
                Dim num14 As Integer
                Dim updatedRows As DataRow() = dataSet.Type.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num14 = 0
                Else
                    num14 = 1
                End If
                If (num14 <> 0) Then
                    num = (num + Me._typeTableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._type1TableAdapter Is Nothing) Then
                Dim num15 As Integer
                Dim updatedRows As DataRow() = dataSet.Type1.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num15 = 0
                Else
                    num15 = 1
                End If
                If (num15 <> 0) Then
                    num = (num + Me._type1TableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            If (Not Me._nmodgDTableAdapter Is Nothing) Then
                Dim num16 As Integer
                Dim updatedRows As DataRow() = dataSet.NmodgD.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent)
                updatedRows = Me.GetRealUpdatedRows(updatedRows, allAddedRows)
                If ((updatedRows Is Nothing) OrElse (0 >= updatedRows.Length)) Then
                    num16 = 0
                Else
                    num16 = 1
                End If
                If (num16 <> 0) Then
                    num = (num + Me._nmodgDTableAdapter.Update(updatedRows))
                    allChangedRows.AddRange(updatedRows)
                End If
            End If
            Return num
        End Function


        ' Properties
        <DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property UpdateOrder As UpdateOrderOption
            Get
                Return Me._updateOrder
            End Get
            Set(ByVal Value As UpdateOrderOption)
                Me._updateOrder = Value
            End Set
        End Property

        <DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")> _
        Public Property EdaraTableAdapter As EdaraTableAdapter
            Get
                Return Me._edaraTableAdapter
            End Get
            Set(ByVal Value As EdaraTableAdapter)
                Me._edaraTableAdapter = Value
            End Set
        End Property

        <Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
        Public Property EmpTableAdapter As EmpTableAdapter
            Get
                Return Me._empTableAdapter
            End Get
            Set(ByVal Value As EmpTableAdapter)
                Me._empTableAdapter = Value
            End Set
        End Property

        <DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property NmodgTableAdapter As NmodgTableAdapter
            Get
                Return Me._nmodgTableAdapter
            End Get
            Set(ByVal Value As NmodgTableAdapter)
                Me._nmodgTableAdapter = Value
            End Set
        End Property

        <DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")> _
        Public Property OssolTableAdapter As OssolTableAdapter
            Get
                Return Me._ossolTableAdapter
            End Get
            Set(ByVal Value As OssolTableAdapter)
                Me._ossolTableAdapter = Value
            End Set
        End Property

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")> _
        Public Property UserTableAdapter As UserTableAdapter
            Get
                Return Me._userTableAdapter
            End Get
            Set(ByVal Value As UserTableAdapter)
                Me._userTableAdapter = Value
            End Set
        End Property

        <Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
        Public Property Ossol1TableAdapter As Ossol1TableAdapter
            Get
                Return Me._ossol1TableAdapter
            End Get
            Set(ByVal Value As Ossol1TableAdapter)
                Me._ossol1TableAdapter = Value
            End Set
        End Property

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode> _
        Public Property NmodgDDTableAdapter As NmodgDDTableAdapter
            Get
                Return Me._nmodgDDTableAdapter
            End Get
            Set(ByVal Value As NmodgDDTableAdapter)
                Me._nmodgDDTableAdapter = Value
            End Set
        End Property

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")> _
        Public Property Edara1TableAdapter As Edara1TableAdapter
            Get
                Return Me._edara1TableAdapter
            End Get
            Set(ByVal Value As Edara1TableAdapter)
                Me._edara1TableAdapter = Value
            End Set
        End Property

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")> _
        Public Property OssolTypeTableAdapter As OssolTypeTableAdapter
            Get
                Return Me._ossolTypeTableAdapter
            End Get
            Set(ByVal Value As OssolTypeTableAdapter)
                Me._ossolTypeTableAdapter = Value
            End Set
        End Property

        <Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
        Public Property OssolType1TableAdapter As OssolType1TableAdapter
            Get
                Return Me._ossolType1TableAdapter
            End Get
            Set(ByVal Value As OssolType1TableAdapter)
                Me._ossolType1TableAdapter = Value
            End Set
        End Property

        <Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
        Public Property KsmTableAdapter As KsmTableAdapter
            Get
                Return Me._ksmTableAdapter
            End Get
            Set(ByVal Value As KsmTableAdapter)
                Me._ksmTableAdapter = Value
            End Set
        End Property

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")> _
        Public Property Ksm1TableAdapter As Ksm1TableAdapter
            Get
                Return Me._ksm1TableAdapter
            End Get
            Set(ByVal Value As Ksm1TableAdapter)
                Me._ksm1TableAdapter = Value
            End Set
        End Property

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode> _
        Public Property TypeTableAdapter As TypeTableAdapter
            Get
                Return Me._typeTableAdapter
            End Get
            Set(ByVal Value As TypeTableAdapter)
                Me._typeTableAdapter = Value
            End Set
        End Property

        <Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
        Public Property Type1TableAdapter As Type1TableAdapter
            Get
                Return Me._type1TableAdapter
            End Get
            Set(ByVal Value As Type1TableAdapter)
                Me._type1TableAdapter = Value
            End Set
        End Property

        <Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property NmodgDTableAdapter As NmodgDTableAdapter
            Get
                Return Me._nmodgDTableAdapter
            End Get
            Set(ByVal Value As NmodgDTableAdapter)
                Me._nmodgDTableAdapter = Value
            End Set
        End Property

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
        Public Property BackupDataSetBeforeUpdate As Boolean
            Get
                Return Me._backupDataSetBeforeUpdate
            End Get
            Set(ByVal Value As Boolean)
                Me._backupDataSetBeforeUpdate = Value
            End Set
        End Property

        <Browsable(False), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
        Public Property Connection As IDbConnection
            Get
                Dim connection As IDbConnection
                If (Not Me._connection Is Nothing) Then
                    connection = Me._connection
                Else
                    Dim num1 As Integer
                    If ((Me._edaraTableAdapter Is Nothing) OrElse (Me._edaraTableAdapter.Connection Is Nothing)) Then
                        num1 = 0
                    Else
                        num1 = 1
                    End If
                    If (num1 <> 0) Then
                        connection = Me._edaraTableAdapter.Connection
                    Else
                        Dim num2 As Integer
                        If ((Me._empTableAdapter Is Nothing) OrElse (Me._empTableAdapter.Connection Is Nothing)) Then
                            num2 = 0
                        Else
                            num2 = 1
                        End If
                        If (num2 <> 0) Then
                            connection = Me._empTableAdapter.Connection
                        Else
                            Dim num3 As Integer
                            If ((Me._nmodgTableAdapter Is Nothing) OrElse (Me._nmodgTableAdapter.Connection Is Nothing)) Then
                                num3 = 0
                            Else
                                num3 = 1
                            End If
                            If (num3 <> 0) Then
                                connection = Me._nmodgTableAdapter.Connection
                            Else
                                Dim num4 As Integer
                                If ((Me._ossolTableAdapter Is Nothing) OrElse (Me._ossolTableAdapter.Connection Is Nothing)) Then
                                    num4 = 0
                                Else
                                    num4 = 1
                                End If
                                If (num4 <> 0) Then
                                    connection = Me._ossolTableAdapter.Connection
                                Else
                                    Dim num5 As Integer
                                    If ((Me._userTableAdapter Is Nothing) OrElse (Me._userTableAdapter.Connection Is Nothing)) Then
                                        num5 = 0
                                    Else
                                        num5 = 1
                                    End If
                                    If (num5 <> 0) Then
                                        connection = Me._userTableAdapter.Connection
                                    Else
                                        Dim num6 As Integer
                                        If ((Me._ossol1TableAdapter Is Nothing) OrElse (Me._ossol1TableAdapter.Connection Is Nothing)) Then
                                            num6 = 0
                                        Else
                                            num6 = 1
                                        End If
                                        If (num6 <> 0) Then
                                            connection = Me._ossol1TableAdapter.Connection
                                        Else
                                            Dim num7 As Integer
                                            If ((Me._nmodgDDTableAdapter Is Nothing) OrElse (Me._nmodgDDTableAdapter.Connection Is Nothing)) Then
                                                num7 = 0
                                            Else
                                                num7 = 1
                                            End If
                                            If (num7 <> 0) Then
                                                connection = Me._nmodgDDTableAdapter.Connection
                                            Else
                                                Dim num8 As Integer
                                                If ((Me._edara1TableAdapter Is Nothing) OrElse (Me._edara1TableAdapter.Connection Is Nothing)) Then
                                                    num8 = 0
                                                Else
                                                    num8 = 1
                                                End If
                                                If (num8 <> 0) Then
                                                    connection = Me._edara1TableAdapter.Connection
                                                Else
                                                    Dim num9 As Integer
                                                    If ((Me._ossolTypeTableAdapter Is Nothing) OrElse (Me._ossolTypeTableAdapter.Connection Is Nothing)) Then
                                                        num9 = 0
                                                    Else
                                                        num9 = 1
                                                    End If
                                                    If (num9 <> 0) Then
                                                        connection = Me._ossolTypeTableAdapter.Connection
                                                    Else
                                                        Dim num10 As Integer
                                                        If ((Me._ossolType1TableAdapter Is Nothing) OrElse (Me._ossolType1TableAdapter.Connection Is Nothing)) Then
                                                            num10 = 0
                                                        Else
                                                            num10 = 1
                                                        End If
                                                        If (num10 <> 0) Then
                                                            connection = Me._ossolType1TableAdapter.Connection
                                                        Else
                                                            Dim num11 As Integer
                                                            If ((Me._ksmTableAdapter Is Nothing) OrElse (Me._ksmTableAdapter.Connection Is Nothing)) Then
                                                                num11 = 0
                                                            Else
                                                                num11 = 1
                                                            End If
                                                            If (num11 <> 0) Then
                                                                connection = Me._ksmTableAdapter.Connection
                                                            Else
                                                                Dim num12 As Integer
                                                                If ((Me._ksm1TableAdapter Is Nothing) OrElse (Me._ksm1TableAdapter.Connection Is Nothing)) Then
                                                                    num12 = 0
                                                                Else
                                                                    num12 = 1
                                                                End If
                                                                If (num12 <> 0) Then
                                                                    connection = Me._ksm1TableAdapter.Connection
                                                                Else
                                                                    Dim num13 As Integer
                                                                    If ((Me._typeTableAdapter Is Nothing) OrElse (Me._typeTableAdapter.Connection Is Nothing)) Then
                                                                        num13 = 0
                                                                    Else
                                                                        num13 = 1
                                                                    End If
                                                                    If (num13 <> 0) Then
                                                                        connection = Me._typeTableAdapter.Connection
                                                                    Else
                                                                        Dim num14 As Integer
                                                                        If ((Me._type1TableAdapter Is Nothing) OrElse (Me._type1TableAdapter.Connection Is Nothing)) Then
                                                                            num14 = 0
                                                                        Else
                                                                            num14 = 1
                                                                        End If
                                                                        If (num14 <> 0) Then
                                                                            connection = Me._type1TableAdapter.Connection
                                                                        Else
                                                                            Dim num15 As Integer
                                                                            If ((Me._nmodgDTableAdapter Is Nothing) OrElse (Me._nmodgDTableAdapter.Connection Is Nothing)) Then
                                                                                num15 = 0
                                                                            Else
                                                                                num15 = 1
                                                                            End If
                                                                            connection = IIf((num15 = 0), Nothing, Me._nmodgDTableAdapter.Connection)
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                Return connection
            End Get
            Set(ByVal Value As IDbConnection)
                Me._connection = Value
            End Set
        End Property

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property TableAdapterInstanceCount As Integer
            Get
                Dim num As Integer = 0
                If (Not Me._edaraTableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._empTableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._nmodgTableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._ossolTableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._userTableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._ossol1TableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._nmodgDDTableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._edara1TableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._ossolTypeTableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._ossolType1TableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._ksmTableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._ksm1TableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._typeTableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._type1TableAdapter Is Nothing) Then
                    num += 1
                End If
                If (Not Me._nmodgDTableAdapter Is Nothing) Then
                    num += 1
                End If
                Return num
            End Get
        End Property


        ' Fields
        Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)
        Private _updateOrder As UpdateOrderOption
        Private _edaraTableAdapter As EdaraTableAdapter
        Private _empTableAdapter As EmpTableAdapter
        Private _nmodgTableAdapter As NmodgTableAdapter
        Private _ossolTableAdapter As OssolTableAdapter
        Private _userTableAdapter As UserTableAdapter
        Private _ossol1TableAdapter As Ossol1TableAdapter
        Private _nmodgDDTableAdapter As NmodgDDTableAdapter
        Private _edara1TableAdapter As Edara1TableAdapter
        Private _ossolTypeTableAdapter As OssolTypeTableAdapter
        Private _ossolType1TableAdapter As OssolType1TableAdapter
        Private _ksmTableAdapter As KsmTableAdapter
        Private _ksm1TableAdapter As Ksm1TableAdapter
        Private _typeTableAdapter As TypeTableAdapter
        Private _type1TableAdapter As Type1TableAdapter
        Private _nmodgDTableAdapter As NmodgDTableAdapter
        Private _backupDataSetBeforeUpdate As Boolean
        Private _connection As IDbConnection

        ' Nested Types
        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Class SelfReferenceComparer
            Implements IComparer(Of DataRow)
            ' Methods
            <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
            Friend Sub New(ByVal relation As DataRelation, ByVal childFirst As Boolean)
                Me._relation = relation
                Me._childFirst = IIf(Not childFirst, 1, -1)
            End Sub

            <DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function [Compare](ByVal row1 As DataRow, ByVal row2 As DataRow) As Integer Implements IComparer(Of DataRow).Compare
                Dim num As Integer
                If Object.ReferenceEquals(row1, row2) Then
                    num = 0
                ElseIf (row1 Is Nothing) Then
                    num = -1
                ElseIf (row2 Is Nothing) Then
                    num = 1
                Else
                    Dim distance As Integer = 0
                    Dim root As DataRow = Me.GetRoot(row1, distance)
                    Dim num3 As Integer = 0
                    Dim objB As DataRow = Me.GetRoot(row2, num3)
                    If Object.ReferenceEquals(root, objB) Then
                        num = (Me._childFirst * distance.CompareTo(num3))
                    Else
                        Dim num1 As Integer
                        If ((root.Table Is Nothing) OrElse (objB.Table Is Nothing)) Then
                            num1 = 0
                        Else
                            num1 = 1
                        End If
                        Debug.Assert(CBool(num1))
                        num = IIf((root.Table.Rows.IndexOf(root) >= objB.Table.Rows.IndexOf(objB)), 1, -1)
                    End If
                End If
                Return num
            End Function

            <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode> _
            Private Function GetRoot(ByVal row As DataRow, ByRef distance As Integer) As DataRow
                Debug.Assert((Not row Is Nothing))
                Dim row4 As DataRow = row
                distance = 0
                Dim dictionary As IDictionary(Of DataRow, DataRow) = New Dictionary(Of DataRow, DataRow)
                dictionary.Item(row) = row
                Dim parentRow As DataRow = row.GetParentRow(Me._relation, DataRowVersion.Default)
                Do While True
                    Dim num1 As Integer
                    If ((parentRow Is Nothing) OrElse dictionary.ContainsKey(parentRow)) Then
                        num1 = 0
                    Else
                        num1 = 1
                    End If
                    Dim flag As Boolean = CBool(num1)
                    If Not flag Then
                        If (distance Is 0) Then
                            dictionary.Clear
                            dictionary.Item(row) = row
                            parentRow = row.GetParentRow(Me._relation, DataRowVersion.Original)
                            Do While True
                                Dim num2 As Integer
                                If ((parentRow Is Nothing) OrElse dictionary.ContainsKey(parentRow)) Then
                                    num2 = 0
                                Else
                                    num2 = 1
                                End If
                                flag = CBool(num2)
                                If Not flag Then
                                    Exit Do
                                End If
                                distance += 1
                                row4 = parentRow
                                dictionary.Item(parentRow) = parentRow
                                parentRow = parentRow.GetParentRow(Me._relation, DataRowVersion.Original)
                            Loop
                        End If
                        Return row4
                    End If
                    distance += 1
                    row4 = parentRow
                    dictionary.Item(parentRow) = parentRow
                    parentRow = parentRow.GetParentRow(Me._relation, DataRowVersion.Default)
                Loop
            End Function


            ' Fields
            Private _relation As DataRelation
            Private _childFirst As Integer
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Enum UpdateOrderOption
            ' Fields
            InsertUpdateDelete = 0
            UpdateInsertDelete = 1
        End Enum
    End Class
End Namespace

