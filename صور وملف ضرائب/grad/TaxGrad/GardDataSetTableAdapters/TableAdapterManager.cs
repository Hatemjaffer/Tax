namespace TaxGrad.GardDataSetTableAdapters
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using TaxGrad;

    [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), ToolboxItem(true), DesignerCategory("code"), HelpKeyword("vs.data.TableAdapterManager")]
    public class TableAdapterManager : Component
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private UpdateOrderOption _updateOrder;
        private TaxGrad.GardDataSetTableAdapters.EdaraTableAdapter _edaraTableAdapter;
        private TaxGrad.GardDataSetTableAdapters.EmpTableAdapter _empTableAdapter;
        private TaxGrad.GardDataSetTableAdapters.NmodgTableAdapter _nmodgTableAdapter;
        private TaxGrad.GardDataSetTableAdapters.OssolTableAdapter _ossolTableAdapter;
        private TaxGrad.GardDataSetTableAdapters.UserTableAdapter _userTableAdapter;
        private TaxGrad.GardDataSetTableAdapters.Ossol1TableAdapter _ossol1TableAdapter;
        private TaxGrad.GardDataSetTableAdapters.NmodgDDTableAdapter _nmodgDDTableAdapter;
        private TaxGrad.GardDataSetTableAdapters.Edara1TableAdapter _edara1TableAdapter;
        private TaxGrad.GardDataSetTableAdapters.OssolTypeTableAdapter _ossolTypeTableAdapter;
        private TaxGrad.GardDataSetTableAdapters.OssolType1TableAdapter _ossolType1TableAdapter;
        private TaxGrad.GardDataSetTableAdapters.KsmTableAdapter _ksmTableAdapter;
        private TaxGrad.GardDataSetTableAdapters.Ksm1TableAdapter _ksm1TableAdapter;
        private TaxGrad.GardDataSetTableAdapters.TypeTableAdapter _typeTableAdapter;
        private TaxGrad.GardDataSetTableAdapters.Type1TableAdapter _type1TableAdapter;
        private TaxGrad.GardDataSetTableAdapters.NmodgDTableAdapter _nmodgDTableAdapter;
        private bool _backupDataSetBeforeUpdate;
        private IDbConnection _connection;

        [DebuggerNonUserCode]
        public TableAdapterManager()
        {
            __ENCAddToList(this);
        }

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                if (__ENCList.Count == __ENCList.Capacity)
                {
                    int index = 0;
                    int num3 = __ENCList.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        int num4 = num3;
                        if (num2 > num4)
                        {
                            __ENCList.RemoveRange(index, __ENCList.Count - index);
                            __ENCList.Capacity = __ENCList.Count;
                            break;
                        }
                        WeakReference reference = __ENCList[num2];
                        if (reference.IsAlive)
                        {
                            if (num2 != index)
                            {
                                __ENCList[index] = __ENCList[num2];
                            }
                            index++;
                        }
                        num2++;
                    }
                }
                __ENCList.Add(new WeakReference(value));
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
        {
            DataRow[] rowArray;
            int num1;
            if ((updatedRows == null) || (updatedRows.Length < 1))
            {
                num1 = 1;
            }
            else
            {
                num1 = 0;
            }
            if (num1 != 0)
            {
                rowArray = updatedRows;
            }
            else
            {
                int num2;
                if ((allAddedRows == null) || (allAddedRows.Count < 1))
                {
                    num2 = 1;
                }
                else
                {
                    num2 = 0;
                }
                if (num2 != 0)
                {
                    rowArray = updatedRows;
                }
                else
                {
                    List<DataRow> list = new List<DataRow>();
                    int index = 0;
                    while (true)
                    {
                        if (index >= updatedRows.Length)
                        {
                            rowArray = list.ToArray();
                            break;
                        }
                        DataRow item = updatedRows[index];
                        if (!allAddedRows.Contains(item))
                        {
                            list.Add(item);
                        }
                        index++;
                    }
                }
            }
            return rowArray;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
        {
            bool flag;
            if (this._connection != null)
            {
                flag = true;
            }
            else
            {
                int num1;
                if ((this.Connection == null) || (inputConnection == null))
                {
                    num1 = 1;
                }
                else
                {
                    num1 = 0;
                }
                if (num1 != 0)
                {
                    flag = true;
                }
                else
                {
                    flag = string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal);
                }
            }
            return flag;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
        {
            Array.Sort<DataRow>(rows, new SelfReferenceComparer(relation, childFirst));
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public virtual int UpdateAll(GardDataSet dataSet)
        {
            int num2;
            if (dataSet == null)
            {
                throw new ArgumentNullException("dataSet");
            }
            if (!dataSet.HasChanges())
            {
                num2 = 0;
            }
            else
            {
                int num1;
                int num7;
                int num8;
                int num9;
                int num10;
                int num11;
                int num12;
                int num13;
                int num14;
                int num15;
                int num16;
                int num17;
                int num18;
                int num19;
                int num20;
                if ((this._edaraTableAdapter == null) || this.MatchTableAdapterConnection(this._edaraTableAdapter.Connection))
                {
                    num1 = 0;
                }
                else
                {
                    num1 = 1;
                }
                if (num1 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._empTableAdapter == null) || this.MatchTableAdapterConnection(this._empTableAdapter.Connection))
                {
                    num7 = 0;
                }
                else
                {
                    num7 = 1;
                }
                if (num7 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._nmodgTableAdapter == null) || this.MatchTableAdapterConnection(this._nmodgTableAdapter.Connection))
                {
                    num8 = 0;
                }
                else
                {
                    num8 = 1;
                }
                if (num8 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._ossolTableAdapter == null) || this.MatchTableAdapterConnection(this._ossolTableAdapter.Connection))
                {
                    num9 = 0;
                }
                else
                {
                    num9 = 1;
                }
                if (num9 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._userTableAdapter == null) || this.MatchTableAdapterConnection(this._userTableAdapter.Connection))
                {
                    num10 = 0;
                }
                else
                {
                    num10 = 1;
                }
                if (num10 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._ossol1TableAdapter == null) || this.MatchTableAdapterConnection(this._ossol1TableAdapter.Connection))
                {
                    num11 = 0;
                }
                else
                {
                    num11 = 1;
                }
                if (num11 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._nmodgDDTableAdapter == null) || this.MatchTableAdapterConnection(this._nmodgDDTableAdapter.Connection))
                {
                    num12 = 0;
                }
                else
                {
                    num12 = 1;
                }
                if (num12 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._edara1TableAdapter == null) || this.MatchTableAdapterConnection(this._edara1TableAdapter.Connection))
                {
                    num13 = 0;
                }
                else
                {
                    num13 = 1;
                }
                if (num13 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._ossolTypeTableAdapter == null) || this.MatchTableAdapterConnection(this._ossolTypeTableAdapter.Connection))
                {
                    num14 = 0;
                }
                else
                {
                    num14 = 1;
                }
                if (num14 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._ossolType1TableAdapter == null) || this.MatchTableAdapterConnection(this._ossolType1TableAdapter.Connection))
                {
                    num15 = 0;
                }
                else
                {
                    num15 = 1;
                }
                if (num15 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._ksmTableAdapter == null) || this.MatchTableAdapterConnection(this._ksmTableAdapter.Connection))
                {
                    num16 = 0;
                }
                else
                {
                    num16 = 1;
                }
                if (num16 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._ksm1TableAdapter == null) || this.MatchTableAdapterConnection(this._ksm1TableAdapter.Connection))
                {
                    num17 = 0;
                }
                else
                {
                    num17 = 1;
                }
                if (num17 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._typeTableAdapter == null) || this.MatchTableAdapterConnection(this._typeTableAdapter.Connection))
                {
                    num18 = 0;
                }
                else
                {
                    num18 = 1;
                }
                if (num18 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._type1TableAdapter == null) || this.MatchTableAdapterConnection(this._type1TableAdapter.Connection))
                {
                    num19 = 0;
                }
                else
                {
                    num19 = 1;
                }
                if (num19 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                if ((this._nmodgDTableAdapter == null) || this.MatchTableAdapterConnection(this._nmodgDTableAdapter.Connection))
                {
                    num20 = 0;
                }
                else
                {
                    num20 = 1;
                }
                if (num20 != 0)
                {
                    throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
                }
                IDbConnection connection = this.Connection;
                if (connection == null)
                {
                    throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
                }
                bool flag = false;
                if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
                {
                    connection.Close();
                }
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    flag = true;
                }
                IDbTransaction transaction = connection.BeginTransaction();
                if (transaction == null)
                {
                    throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
                }
                List<DataRow> allChangedRows = new List<DataRow>();
                List<DataRow> allAddedRows = new List<DataRow>();
                List<DataAdapter> list = new List<DataAdapter>();
                Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
                int num = 0;
                DataSet set = null;
                if (this.BackupDataSetBeforeUpdate)
                {
                    new DataSet().Merge(dataSet);
                }
                try
                {
                    if (this._edaraTableAdapter != null)
                    {
                        dictionary.Add(this._edaraTableAdapter, this._edaraTableAdapter.Connection);
                        this._edaraTableAdapter.Connection = (SqlConnection) connection;
                        this._edaraTableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._edaraTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._edaraTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._edaraTableAdapter.Adapter);
                        }
                    }
                    if (this._empTableAdapter != null)
                    {
                        dictionary.Add(this._empTableAdapter, this._empTableAdapter.Connection);
                        this._empTableAdapter.Connection = (SqlConnection) connection;
                        this._empTableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._empTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._empTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._empTableAdapter.Adapter);
                        }
                    }
                    if (this._nmodgTableAdapter != null)
                    {
                        dictionary.Add(this._nmodgTableAdapter, this._nmodgTableAdapter.Connection);
                        this._nmodgTableAdapter.Connection = (SqlConnection) connection;
                        this._nmodgTableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._nmodgTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._nmodgTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._nmodgTableAdapter.Adapter);
                        }
                    }
                    if (this._ossolTableAdapter != null)
                    {
                        dictionary.Add(this._ossolTableAdapter, this._ossolTableAdapter.Connection);
                        this._ossolTableAdapter.Connection = (SqlConnection) connection;
                        this._ossolTableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._ossolTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._ossolTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._ossolTableAdapter.Adapter);
                        }
                    }
                    if (this._userTableAdapter != null)
                    {
                        dictionary.Add(this._userTableAdapter, this._userTableAdapter.Connection);
                        this._userTableAdapter.Connection = (SqlConnection) connection;
                        this._userTableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._userTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._userTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._userTableAdapter.Adapter);
                        }
                    }
                    if (this._ossol1TableAdapter != null)
                    {
                        dictionary.Add(this._ossol1TableAdapter, this._ossol1TableAdapter.Connection);
                        this._ossol1TableAdapter.Connection = (SqlConnection) connection;
                        this._ossol1TableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._ossol1TableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._ossol1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._ossol1TableAdapter.Adapter);
                        }
                    }
                    if (this._nmodgDDTableAdapter != null)
                    {
                        dictionary.Add(this._nmodgDDTableAdapter, this._nmodgDDTableAdapter.Connection);
                        this._nmodgDDTableAdapter.Connection = (SqlConnection) connection;
                        this._nmodgDDTableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._nmodgDDTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._nmodgDDTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._nmodgDDTableAdapter.Adapter);
                        }
                    }
                    if (this._edara1TableAdapter != null)
                    {
                        dictionary.Add(this._edara1TableAdapter, this._edara1TableAdapter.Connection);
                        this._edara1TableAdapter.Connection = (SqlConnection) connection;
                        this._edara1TableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._edara1TableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._edara1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._edara1TableAdapter.Adapter);
                        }
                    }
                    if (this._ossolTypeTableAdapter != null)
                    {
                        dictionary.Add(this._ossolTypeTableAdapter, this._ossolTypeTableAdapter.Connection);
                        this._ossolTypeTableAdapter.Connection = (SqlConnection) connection;
                        this._ossolTypeTableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._ossolTypeTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._ossolTypeTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._ossolTypeTableAdapter.Adapter);
                        }
                    }
                    if (this._ossolType1TableAdapter != null)
                    {
                        dictionary.Add(this._ossolType1TableAdapter, this._ossolType1TableAdapter.Connection);
                        this._ossolType1TableAdapter.Connection = (SqlConnection) connection;
                        this._ossolType1TableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._ossolType1TableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._ossolType1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._ossolType1TableAdapter.Adapter);
                        }
                    }
                    if (this._ksmTableAdapter != null)
                    {
                        dictionary.Add(this._ksmTableAdapter, this._ksmTableAdapter.Connection);
                        this._ksmTableAdapter.Connection = (SqlConnection) connection;
                        this._ksmTableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._ksmTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._ksmTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._ksmTableAdapter.Adapter);
                        }
                    }
                    if (this._ksm1TableAdapter != null)
                    {
                        dictionary.Add(this._ksm1TableAdapter, this._ksm1TableAdapter.Connection);
                        this._ksm1TableAdapter.Connection = (SqlConnection) connection;
                        this._ksm1TableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._ksm1TableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._ksm1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._ksm1TableAdapter.Adapter);
                        }
                    }
                    if (this._typeTableAdapter != null)
                    {
                        dictionary.Add(this._typeTableAdapter, this._typeTableAdapter.Connection);
                        this._typeTableAdapter.Connection = (SqlConnection) connection;
                        this._typeTableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._typeTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._typeTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._typeTableAdapter.Adapter);
                        }
                    }
                    if (this._type1TableAdapter != null)
                    {
                        dictionary.Add(this._type1TableAdapter, this._type1TableAdapter.Connection);
                        this._type1TableAdapter.Connection = (SqlConnection) connection;
                        this._type1TableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._type1TableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._type1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._type1TableAdapter.Adapter);
                        }
                    }
                    if (this._nmodgDTableAdapter != null)
                    {
                        dictionary.Add(this._nmodgDTableAdapter, this._nmodgDTableAdapter.Connection);
                        this._nmodgDTableAdapter.Connection = (SqlConnection) connection;
                        this._nmodgDTableAdapter.Transaction = (SqlTransaction) transaction;
                        if (this._nmodgDTableAdapter.Adapter.AcceptChangesDuringUpdate)
                        {
                            this._nmodgDTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                            list.Add(this._nmodgDTableAdapter.Adapter);
                        }
                    }
                    if (this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
                    {
                        num = (num + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows)) + this.UpdateInsertedRows(dataSet, allAddedRows);
                    }
                    else
                    {
                        num = (num + this.UpdateInsertedRows(dataSet, allAddedRows)) + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
                    }
                    num += this.UpdateDeletedRows(dataSet, allChangedRows);
                    transaction.Commit();
                    if (0 < allAddedRows.Count)
                    {
                        DataRow[] array = new DataRow[(allAddedRows.Count - 1) + 1];
                        allAddedRows.CopyTo(array);
                        int index = 0;
                        while (true)
                        {
                            if (index >= array.Length)
                            {
                                break;
                            }
                            array[index].AcceptChanges();
                            index++;
                        }
                    }
                    if (0 < allChangedRows.Count)
                    {
                        DataRow[] array = new DataRow[(allChangedRows.Count - 1) + 1];
                        allChangedRows.CopyTo(array);
                        int index = 0;
                        while (true)
                        {
                            if (index >= array.Length)
                            {
                                break;
                            }
                            array[index].AcceptChanges();
                            index++;
                        }
                    }
                }
                catch (Exception exception1)
                {
                    Exception local1 = exception1;
                    ProjectData.SetProjectError(local1);
                    Exception exception = local1;
                    transaction.Rollback();
                    if (this.BackupDataSetBeforeUpdate)
                    {
                        Debug.Assert(set != null);
                        dataSet.Clear();
                        dataSet.Merge(set);
                    }
                    else if (0 < allAddedRows.Count)
                    {
                        DataRow[] array = new DataRow[(allAddedRows.Count - 1) + 1];
                        allAddedRows.CopyTo(array);
                        int index = 0;
                        while (true)
                        {
                            if (index >= array.Length)
                            {
                                break;
                            }
                            DataRow row3 = array[index];
                            row3.AcceptChanges();
                            row3.SetAdded();
                            index++;
                        }
                    }
                    throw exception;
                }
                finally
                {
                    if (flag)
                    {
                        connection.Close();
                    }
                    if (this._edaraTableAdapter != null)
                    {
                        this._edaraTableAdapter.Connection = (SqlConnection) dictionary[this._edaraTableAdapter];
                        this._edaraTableAdapter.Transaction = null;
                    }
                    if (this._empTableAdapter != null)
                    {
                        this._empTableAdapter.Connection = (SqlConnection) dictionary[this._empTableAdapter];
                        this._empTableAdapter.Transaction = null;
                    }
                    if (this._nmodgTableAdapter != null)
                    {
                        this._nmodgTableAdapter.Connection = (SqlConnection) dictionary[this._nmodgTableAdapter];
                        this._nmodgTableAdapter.Transaction = null;
                    }
                    if (this._ossolTableAdapter != null)
                    {
                        this._ossolTableAdapter.Connection = (SqlConnection) dictionary[this._ossolTableAdapter];
                        this._ossolTableAdapter.Transaction = null;
                    }
                    if (this._userTableAdapter != null)
                    {
                        this._userTableAdapter.Connection = (SqlConnection) dictionary[this._userTableAdapter];
                        this._userTableAdapter.Transaction = null;
                    }
                    if (this._ossol1TableAdapter != null)
                    {
                        this._ossol1TableAdapter.Connection = (SqlConnection) dictionary[this._ossol1TableAdapter];
                        this._ossol1TableAdapter.Transaction = null;
                    }
                    if (this._nmodgDDTableAdapter != null)
                    {
                        this._nmodgDDTableAdapter.Connection = (SqlConnection) dictionary[this._nmodgDDTableAdapter];
                        this._nmodgDDTableAdapter.Transaction = null;
                    }
                    if (this._edara1TableAdapter != null)
                    {
                        this._edara1TableAdapter.Connection = (SqlConnection) dictionary[this._edara1TableAdapter];
                        this._edara1TableAdapter.Transaction = null;
                    }
                    if (this._ossolTypeTableAdapter != null)
                    {
                        this._ossolTypeTableAdapter.Connection = (SqlConnection) dictionary[this._ossolTypeTableAdapter];
                        this._ossolTypeTableAdapter.Transaction = null;
                    }
                    if (this._ossolType1TableAdapter != null)
                    {
                        this._ossolType1TableAdapter.Connection = (SqlConnection) dictionary[this._ossolType1TableAdapter];
                        this._ossolType1TableAdapter.Transaction = null;
                    }
                    if (this._ksmTableAdapter != null)
                    {
                        this._ksmTableAdapter.Connection = (SqlConnection) dictionary[this._ksmTableAdapter];
                        this._ksmTableAdapter.Transaction = null;
                    }
                    if (this._ksm1TableAdapter != null)
                    {
                        this._ksm1TableAdapter.Connection = (SqlConnection) dictionary[this._ksm1TableAdapter];
                        this._ksm1TableAdapter.Transaction = null;
                    }
                    if (this._typeTableAdapter != null)
                    {
                        this._typeTableAdapter.Connection = (SqlConnection) dictionary[this._typeTableAdapter];
                        this._typeTableAdapter.Transaction = null;
                    }
                    if (this._type1TableAdapter != null)
                    {
                        this._type1TableAdapter.Connection = (SqlConnection) dictionary[this._type1TableAdapter];
                        this._type1TableAdapter.Transaction = null;
                    }
                    if (this._nmodgDTableAdapter != null)
                    {
                        this._nmodgDTableAdapter.Connection = (SqlConnection) dictionary[this._nmodgDTableAdapter];
                        this._nmodgDTableAdapter.Transaction = null;
                    }
                    if (0 < list.Count)
                    {
                        DataAdapter[] array = new DataAdapter[(list.Count - 1) + 1];
                        list.CopyTo(array);
                        int index = 0;
                        while (true)
                        {
                            if (index >= array.Length)
                            {
                                break;
                            }
                            DataAdapter adapter = array[index];
                            adapter.AcceptChangesDuringUpdate = true;
                            index++;
                        }
                    }
                }
                num2 = num;
            }
            return num2;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateDeletedRows(GardDataSet dataSet, List<DataRow> allChangedRows)
        {
            int num = 0;
            if (this._nmodgDTableAdapter != null)
            {
                int num1;
                DataRow[] dataRows = dataSet.NmodgD.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num1 = 0;
                }
                else
                {
                    num1 = 1;
                }
                if (num1 != 0)
                {
                    num += this._nmodgDTableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._type1TableAdapter != null)
            {
                int num3;
                DataRow[] dataRows = dataSet.Type1.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num3 = 0;
                }
                else
                {
                    num3 = 1;
                }
                if (num3 != 0)
                {
                    num += this._type1TableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._typeTableAdapter != null)
            {
                int num4;
                DataRow[] dataRows = dataSet.Type.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num4 = 0;
                }
                else
                {
                    num4 = 1;
                }
                if (num4 != 0)
                {
                    num += this._typeTableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._ksm1TableAdapter != null)
            {
                int num5;
                DataRow[] dataRows = dataSet.Ksm1.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num5 = 0;
                }
                else
                {
                    num5 = 1;
                }
                if (num5 != 0)
                {
                    num += this._ksm1TableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._ksmTableAdapter != null)
            {
                int num6;
                DataRow[] dataRows = dataSet.Ksm.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num6 = 0;
                }
                else
                {
                    num6 = 1;
                }
                if (num6 != 0)
                {
                    num += this._ksmTableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._ossolType1TableAdapter != null)
            {
                int num7;
                DataRow[] dataRows = dataSet.OssolType1.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num7 = 0;
                }
                else
                {
                    num7 = 1;
                }
                if (num7 != 0)
                {
                    num += this._ossolType1TableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._ossolTypeTableAdapter != null)
            {
                int num8;
                DataRow[] dataRows = dataSet.OssolType.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num8 = 0;
                }
                else
                {
                    num8 = 1;
                }
                if (num8 != 0)
                {
                    num += this._ossolTypeTableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._edara1TableAdapter != null)
            {
                int num9;
                DataRow[] dataRows = dataSet.Edara1.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num9 = 0;
                }
                else
                {
                    num9 = 1;
                }
                if (num9 != 0)
                {
                    num += this._edara1TableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._nmodgDDTableAdapter != null)
            {
                int num10;
                DataRow[] dataRows = dataSet.NmodgDD.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num10 = 0;
                }
                else
                {
                    num10 = 1;
                }
                if (num10 != 0)
                {
                    num += this._nmodgDDTableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._ossol1TableAdapter != null)
            {
                int num11;
                DataRow[] dataRows = dataSet.Ossol1.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num11 = 0;
                }
                else
                {
                    num11 = 1;
                }
                if (num11 != 0)
                {
                    num += this._ossol1TableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._userTableAdapter != null)
            {
                int num12;
                DataRow[] dataRows = dataSet.User.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num12 = 0;
                }
                else
                {
                    num12 = 1;
                }
                if (num12 != 0)
                {
                    num += this._userTableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._ossolTableAdapter != null)
            {
                int num13;
                DataRow[] dataRows = dataSet.Ossol.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num13 = 0;
                }
                else
                {
                    num13 = 1;
                }
                if (num13 != 0)
                {
                    num += this._ossolTableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._nmodgTableAdapter != null)
            {
                int num14;
                DataRow[] dataRows = dataSet.Nmodg.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num14 = 0;
                }
                else
                {
                    num14 = 1;
                }
                if (num14 != 0)
                {
                    num += this._nmodgTableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._empTableAdapter != null)
            {
                int num15;
                DataRow[] dataRows = dataSet.Emp.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num15 = 0;
                }
                else
                {
                    num15 = 1;
                }
                if (num15 != 0)
                {
                    num += this._empTableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            if (this._edaraTableAdapter != null)
            {
                int num16;
                DataRow[] dataRows = dataSet.Edara.Select(null, null, DataViewRowState.Deleted);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num16 = 0;
                }
                else
                {
                    num16 = 1;
                }
                if (num16 != 0)
                {
                    num += this._edaraTableAdapter.Update(dataRows);
                    allChangedRows.AddRange(dataRows);
                }
            }
            return num;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private int UpdateInsertedRows(GardDataSet dataSet, List<DataRow> allAddedRows)
        {
            int num = 0;
            if (this._edaraTableAdapter != null)
            {
                int num1;
                DataRow[] dataRows = dataSet.Edara.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num1 = 0;
                }
                else
                {
                    num1 = 1;
                }
                if (num1 != 0)
                {
                    num += this._edaraTableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._empTableAdapter != null)
            {
                int num3;
                DataRow[] dataRows = dataSet.Emp.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num3 = 0;
                }
                else
                {
                    num3 = 1;
                }
                if (num3 != 0)
                {
                    num += this._empTableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._nmodgTableAdapter != null)
            {
                int num4;
                DataRow[] dataRows = dataSet.Nmodg.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num4 = 0;
                }
                else
                {
                    num4 = 1;
                }
                if (num4 != 0)
                {
                    num += this._nmodgTableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._ossolTableAdapter != null)
            {
                int num5;
                DataRow[] dataRows = dataSet.Ossol.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num5 = 0;
                }
                else
                {
                    num5 = 1;
                }
                if (num5 != 0)
                {
                    num += this._ossolTableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._userTableAdapter != null)
            {
                int num6;
                DataRow[] dataRows = dataSet.User.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num6 = 0;
                }
                else
                {
                    num6 = 1;
                }
                if (num6 != 0)
                {
                    num += this._userTableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._ossol1TableAdapter != null)
            {
                int num7;
                DataRow[] dataRows = dataSet.Ossol1.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num7 = 0;
                }
                else
                {
                    num7 = 1;
                }
                if (num7 != 0)
                {
                    num += this._ossol1TableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._nmodgDDTableAdapter != null)
            {
                int num8;
                DataRow[] dataRows = dataSet.NmodgDD.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num8 = 0;
                }
                else
                {
                    num8 = 1;
                }
                if (num8 != 0)
                {
                    num += this._nmodgDDTableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._edara1TableAdapter != null)
            {
                int num9;
                DataRow[] dataRows = dataSet.Edara1.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num9 = 0;
                }
                else
                {
                    num9 = 1;
                }
                if (num9 != 0)
                {
                    num += this._edara1TableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._ossolTypeTableAdapter != null)
            {
                int num10;
                DataRow[] dataRows = dataSet.OssolType.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num10 = 0;
                }
                else
                {
                    num10 = 1;
                }
                if (num10 != 0)
                {
                    num += this._ossolTypeTableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._ossolType1TableAdapter != null)
            {
                int num11;
                DataRow[] dataRows = dataSet.OssolType1.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num11 = 0;
                }
                else
                {
                    num11 = 1;
                }
                if (num11 != 0)
                {
                    num += this._ossolType1TableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._ksmTableAdapter != null)
            {
                int num12;
                DataRow[] dataRows = dataSet.Ksm.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num12 = 0;
                }
                else
                {
                    num12 = 1;
                }
                if (num12 != 0)
                {
                    num += this._ksmTableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._ksm1TableAdapter != null)
            {
                int num13;
                DataRow[] dataRows = dataSet.Ksm1.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num13 = 0;
                }
                else
                {
                    num13 = 1;
                }
                if (num13 != 0)
                {
                    num += this._ksm1TableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._typeTableAdapter != null)
            {
                int num14;
                DataRow[] dataRows = dataSet.Type.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num14 = 0;
                }
                else
                {
                    num14 = 1;
                }
                if (num14 != 0)
                {
                    num += this._typeTableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._type1TableAdapter != null)
            {
                int num15;
                DataRow[] dataRows = dataSet.Type1.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num15 = 0;
                }
                else
                {
                    num15 = 1;
                }
                if (num15 != 0)
                {
                    num += this._type1TableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            if (this._nmodgDTableAdapter != null)
            {
                int num16;
                DataRow[] dataRows = dataSet.NmodgD.Select(null, null, DataViewRowState.Added);
                if ((dataRows == null) || (0 >= dataRows.Length))
                {
                    num16 = 0;
                }
                else
                {
                    num16 = 1;
                }
                if (num16 != 0)
                {
                    num += this._nmodgDTableAdapter.Update(dataRows);
                    allAddedRows.AddRange(dataRows);
                }
            }
            return num;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private int UpdateUpdatedRows(GardDataSet dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
        {
            int num = 0;
            if (this._edaraTableAdapter != null)
            {
                int num1;
                DataRow[] updatedRows = dataSet.Edara.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num1 = 0;
                }
                else
                {
                    num1 = 1;
                }
                if (num1 != 0)
                {
                    num += this._edaraTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._empTableAdapter != null)
            {
                int num3;
                DataRow[] updatedRows = dataSet.Emp.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num3 = 0;
                }
                else
                {
                    num3 = 1;
                }
                if (num3 != 0)
                {
                    num += this._empTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._nmodgTableAdapter != null)
            {
                int num4;
                DataRow[] updatedRows = dataSet.Nmodg.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num4 = 0;
                }
                else
                {
                    num4 = 1;
                }
                if (num4 != 0)
                {
                    num += this._nmodgTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._ossolTableAdapter != null)
            {
                int num5;
                DataRow[] updatedRows = dataSet.Ossol.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num5 = 0;
                }
                else
                {
                    num5 = 1;
                }
                if (num5 != 0)
                {
                    num += this._ossolTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._userTableAdapter != null)
            {
                int num6;
                DataRow[] updatedRows = dataSet.User.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num6 = 0;
                }
                else
                {
                    num6 = 1;
                }
                if (num6 != 0)
                {
                    num += this._userTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._ossol1TableAdapter != null)
            {
                int num7;
                DataRow[] updatedRows = dataSet.Ossol1.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num7 = 0;
                }
                else
                {
                    num7 = 1;
                }
                if (num7 != 0)
                {
                    num += this._ossol1TableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._nmodgDDTableAdapter != null)
            {
                int num8;
                DataRow[] updatedRows = dataSet.NmodgDD.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num8 = 0;
                }
                else
                {
                    num8 = 1;
                }
                if (num8 != 0)
                {
                    num += this._nmodgDDTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._edara1TableAdapter != null)
            {
                int num9;
                DataRow[] updatedRows = dataSet.Edara1.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num9 = 0;
                }
                else
                {
                    num9 = 1;
                }
                if (num9 != 0)
                {
                    num += this._edara1TableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._ossolTypeTableAdapter != null)
            {
                int num10;
                DataRow[] updatedRows = dataSet.OssolType.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num10 = 0;
                }
                else
                {
                    num10 = 1;
                }
                if (num10 != 0)
                {
                    num += this._ossolTypeTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._ossolType1TableAdapter != null)
            {
                int num11;
                DataRow[] updatedRows = dataSet.OssolType1.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num11 = 0;
                }
                else
                {
                    num11 = 1;
                }
                if (num11 != 0)
                {
                    num += this._ossolType1TableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._ksmTableAdapter != null)
            {
                int num12;
                DataRow[] updatedRows = dataSet.Ksm.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num12 = 0;
                }
                else
                {
                    num12 = 1;
                }
                if (num12 != 0)
                {
                    num += this._ksmTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._ksm1TableAdapter != null)
            {
                int num13;
                DataRow[] updatedRows = dataSet.Ksm1.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num13 = 0;
                }
                else
                {
                    num13 = 1;
                }
                if (num13 != 0)
                {
                    num += this._ksm1TableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._typeTableAdapter != null)
            {
                int num14;
                DataRow[] updatedRows = dataSet.Type.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num14 = 0;
                }
                else
                {
                    num14 = 1;
                }
                if (num14 != 0)
                {
                    num += this._typeTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._type1TableAdapter != null)
            {
                int num15;
                DataRow[] updatedRows = dataSet.Type1.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num15 = 0;
                }
                else
                {
                    num15 = 1;
                }
                if (num15 != 0)
                {
                    num += this._type1TableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            if (this._nmodgDTableAdapter != null)
            {
                int num16;
                DataRow[] updatedRows = dataSet.NmodgD.Select(null, null, DataViewRowState.ModifiedCurrent);
                updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
                if ((updatedRows == null) || (0 >= updatedRows.Length))
                {
                    num16 = 0;
                }
                else
                {
                    num16 = 1;
                }
                if (num16 != 0)
                {
                    num += this._nmodgDTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            return num;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public UpdateOrderOption UpdateOrder
        {
            get => 
                this._updateOrder;
            set => 
                (this._updateOrder = value);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public TaxGrad.GardDataSetTableAdapters.EdaraTableAdapter EdaraTableAdapter
        {
            get => 
                this._edaraTableAdapter;
            set => 
                (this._edaraTableAdapter = value);
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public TaxGrad.GardDataSetTableAdapters.EmpTableAdapter EmpTableAdapter
        {
            get => 
                this._empTableAdapter;
            set => 
                (this._empTableAdapter = value);
        }

        [DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public TaxGrad.GardDataSetTableAdapters.NmodgTableAdapter NmodgTableAdapter
        {
            get => 
                this._nmodgTableAdapter;
            set => 
                (this._nmodgTableAdapter = value);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public TaxGrad.GardDataSetTableAdapters.OssolTableAdapter OssolTableAdapter
        {
            get => 
                this._ossolTableAdapter;
            set => 
                (this._ossolTableAdapter = value);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public TaxGrad.GardDataSetTableAdapters.UserTableAdapter UserTableAdapter
        {
            get => 
                this._userTableAdapter;
            set => 
                (this._userTableAdapter = value);
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public TaxGrad.GardDataSetTableAdapters.Ossol1TableAdapter Ossol1TableAdapter
        {
            get => 
                this._ossol1TableAdapter;
            set => 
                (this._ossol1TableAdapter = value);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode]
        public TaxGrad.GardDataSetTableAdapters.NmodgDDTableAdapter NmodgDDTableAdapter
        {
            get => 
                this._nmodgDDTableAdapter;
            set => 
                (this._nmodgDDTableAdapter = value);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public TaxGrad.GardDataSetTableAdapters.Edara1TableAdapter Edara1TableAdapter
        {
            get => 
                this._edara1TableAdapter;
            set => 
                (this._edara1TableAdapter = value);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public TaxGrad.GardDataSetTableAdapters.OssolTypeTableAdapter OssolTypeTableAdapter
        {
            get => 
                this._ossolTypeTableAdapter;
            set => 
                (this._ossolTypeTableAdapter = value);
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public TaxGrad.GardDataSetTableAdapters.OssolType1TableAdapter OssolType1TableAdapter
        {
            get => 
                this._ossolType1TableAdapter;
            set => 
                (this._ossolType1TableAdapter = value);
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public TaxGrad.GardDataSetTableAdapters.KsmTableAdapter KsmTableAdapter
        {
            get => 
                this._ksmTableAdapter;
            set => 
                (this._ksmTableAdapter = value);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
        public TaxGrad.GardDataSetTableAdapters.Ksm1TableAdapter Ksm1TableAdapter
        {
            get => 
                this._ksm1TableAdapter;
            set => 
                (this._ksm1TableAdapter = value);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode]
        public TaxGrad.GardDataSetTableAdapters.TypeTableAdapter TypeTableAdapter
        {
            get => 
                this._typeTableAdapter;
            set => 
                (this._typeTableAdapter = value);
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public TaxGrad.GardDataSetTableAdapters.Type1TableAdapter Type1TableAdapter
        {
            get => 
                this._type1TableAdapter;
            set => 
                (this._type1TableAdapter = value);
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public TaxGrad.GardDataSetTableAdapters.NmodgDTableAdapter NmodgDTableAdapter
        {
            get => 
                this._nmodgDTableAdapter;
            set => 
                (this._nmodgDTableAdapter = value);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public bool BackupDataSetBeforeUpdate
        {
            get => 
                this._backupDataSetBeforeUpdate;
            set => 
                (this._backupDataSetBeforeUpdate = value);
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public IDbConnection Connection
        {
            get
            {
                IDbConnection connection;
                if (this._connection != null)
                {
                    connection = this._connection;
                }
                else
                {
                    int num1;
                    if ((this._edaraTableAdapter == null) || (this._edaraTableAdapter.Connection == null))
                    {
                        num1 = 0;
                    }
                    else
                    {
                        num1 = 1;
                    }
                    if (num1 != 0)
                    {
                        connection = this._edaraTableAdapter.Connection;
                    }
                    else
                    {
                        int num2;
                        if ((this._empTableAdapter == null) || (this._empTableAdapter.Connection == null))
                        {
                            num2 = 0;
                        }
                        else
                        {
                            num2 = 1;
                        }
                        if (num2 != 0)
                        {
                            connection = this._empTableAdapter.Connection;
                        }
                        else
                        {
                            int num3;
                            if ((this._nmodgTableAdapter == null) || (this._nmodgTableAdapter.Connection == null))
                            {
                                num3 = 0;
                            }
                            else
                            {
                                num3 = 1;
                            }
                            if (num3 != 0)
                            {
                                connection = this._nmodgTableAdapter.Connection;
                            }
                            else
                            {
                                int num4;
                                if ((this._ossolTableAdapter == null) || (this._ossolTableAdapter.Connection == null))
                                {
                                    num4 = 0;
                                }
                                else
                                {
                                    num4 = 1;
                                }
                                if (num4 != 0)
                                {
                                    connection = this._ossolTableAdapter.Connection;
                                }
                                else
                                {
                                    int num5;
                                    if ((this._userTableAdapter == null) || (this._userTableAdapter.Connection == null))
                                    {
                                        num5 = 0;
                                    }
                                    else
                                    {
                                        num5 = 1;
                                    }
                                    if (num5 != 0)
                                    {
                                        connection = this._userTableAdapter.Connection;
                                    }
                                    else
                                    {
                                        int num6;
                                        if ((this._ossol1TableAdapter == null) || (this._ossol1TableAdapter.Connection == null))
                                        {
                                            num6 = 0;
                                        }
                                        else
                                        {
                                            num6 = 1;
                                        }
                                        if (num6 != 0)
                                        {
                                            connection = this._ossol1TableAdapter.Connection;
                                        }
                                        else
                                        {
                                            int num7;
                                            if ((this._nmodgDDTableAdapter == null) || (this._nmodgDDTableAdapter.Connection == null))
                                            {
                                                num7 = 0;
                                            }
                                            else
                                            {
                                                num7 = 1;
                                            }
                                            if (num7 != 0)
                                            {
                                                connection = this._nmodgDDTableAdapter.Connection;
                                            }
                                            else
                                            {
                                                int num8;
                                                if ((this._edara1TableAdapter == null) || (this._edara1TableAdapter.Connection == null))
                                                {
                                                    num8 = 0;
                                                }
                                                else
                                                {
                                                    num8 = 1;
                                                }
                                                if (num8 != 0)
                                                {
                                                    connection = this._edara1TableAdapter.Connection;
                                                }
                                                else
                                                {
                                                    int num9;
                                                    if ((this._ossolTypeTableAdapter == null) || (this._ossolTypeTableAdapter.Connection == null))
                                                    {
                                                        num9 = 0;
                                                    }
                                                    else
                                                    {
                                                        num9 = 1;
                                                    }
                                                    if (num9 != 0)
                                                    {
                                                        connection = this._ossolTypeTableAdapter.Connection;
                                                    }
                                                    else
                                                    {
                                                        int num10;
                                                        if ((this._ossolType1TableAdapter == null) || (this._ossolType1TableAdapter.Connection == null))
                                                        {
                                                            num10 = 0;
                                                        }
                                                        else
                                                        {
                                                            num10 = 1;
                                                        }
                                                        if (num10 != 0)
                                                        {
                                                            connection = this._ossolType1TableAdapter.Connection;
                                                        }
                                                        else
                                                        {
                                                            int num11;
                                                            if ((this._ksmTableAdapter == null) || (this._ksmTableAdapter.Connection == null))
                                                            {
                                                                num11 = 0;
                                                            }
                                                            else
                                                            {
                                                                num11 = 1;
                                                            }
                                                            if (num11 != 0)
                                                            {
                                                                connection = this._ksmTableAdapter.Connection;
                                                            }
                                                            else
                                                            {
                                                                int num12;
                                                                if ((this._ksm1TableAdapter == null) || (this._ksm1TableAdapter.Connection == null))
                                                                {
                                                                    num12 = 0;
                                                                }
                                                                else
                                                                {
                                                                    num12 = 1;
                                                                }
                                                                if (num12 != 0)
                                                                {
                                                                    connection = this._ksm1TableAdapter.Connection;
                                                                }
                                                                else
                                                                {
                                                                    int num13;
                                                                    if ((this._typeTableAdapter == null) || (this._typeTableAdapter.Connection == null))
                                                                    {
                                                                        num13 = 0;
                                                                    }
                                                                    else
                                                                    {
                                                                        num13 = 1;
                                                                    }
                                                                    if (num13 != 0)
                                                                    {
                                                                        connection = this._typeTableAdapter.Connection;
                                                                    }
                                                                    else
                                                                    {
                                                                        int num14;
                                                                        if ((this._type1TableAdapter == null) || (this._type1TableAdapter.Connection == null))
                                                                        {
                                                                            num14 = 0;
                                                                        }
                                                                        else
                                                                        {
                                                                            num14 = 1;
                                                                        }
                                                                        if (num14 != 0)
                                                                        {
                                                                            connection = this._type1TableAdapter.Connection;
                                                                        }
                                                                        else
                                                                        {
                                                                            int num15;
                                                                            if ((this._nmodgDTableAdapter == null) || (this._nmodgDTableAdapter.Connection == null))
                                                                            {
                                                                                num15 = 0;
                                                                            }
                                                                            else
                                                                            {
                                                                                num15 = 1;
                                                                            }
                                                                            connection = (num15 == 0) ? null : this._nmodgDTableAdapter.Connection;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return connection;
            }
            set => 
                (this._connection = value);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
        public int TableAdapterInstanceCount
        {
            get
            {
                int num = 0;
                if (this._edaraTableAdapter != null)
                {
                    num++;
                }
                if (this._empTableAdapter != null)
                {
                    num++;
                }
                if (this._nmodgTableAdapter != null)
                {
                    num++;
                }
                if (this._ossolTableAdapter != null)
                {
                    num++;
                }
                if (this._userTableAdapter != null)
                {
                    num++;
                }
                if (this._ossol1TableAdapter != null)
                {
                    num++;
                }
                if (this._nmodgDDTableAdapter != null)
                {
                    num++;
                }
                if (this._edara1TableAdapter != null)
                {
                    num++;
                }
                if (this._ossolTypeTableAdapter != null)
                {
                    num++;
                }
                if (this._ossolType1TableAdapter != null)
                {
                    num++;
                }
                if (this._ksmTableAdapter != null)
                {
                    num++;
                }
                if (this._ksm1TableAdapter != null)
                {
                    num++;
                }
                if (this._typeTableAdapter != null)
                {
                    num++;
                }
                if (this._type1TableAdapter != null)
                {
                    num++;
                }
                if (this._nmodgDTableAdapter != null)
                {
                    num++;
                }
                return num;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private class SelfReferenceComparer : IComparer<DataRow>
        {
            private DataRelation _relation;
            private int _childFirst;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal SelfReferenceComparer(DataRelation relation, bool childFirst)
            {
                this._relation = relation;
                this._childFirst = !childFirst ? 1 : -1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Compare(DataRow row1, DataRow row2)
            {
                int num;
                if (object.ReferenceEquals(row1, row2))
                {
                    num = 0;
                }
                else if (row1 == null)
                {
                    num = -1;
                }
                else if (row2 == null)
                {
                    num = 1;
                }
                else
                {
                    int distance = 0;
                    DataRow root = this.GetRoot(row1, ref distance);
                    int num3 = 0;
                    DataRow objB = this.GetRoot(row2, ref num3);
                    if (object.ReferenceEquals(root, objB))
                    {
                        num = this._childFirst * distance.CompareTo(num3);
                    }
                    else
                    {
                        int num1;
                        if ((root.Table == null) || (objB.Table == null))
                        {
                            num1 = 0;
                        }
                        else
                        {
                            num1 = 1;
                        }
                        Debug.Assert((bool) num1);
                        num = (root.Table.Rows.IndexOf(root) >= objB.Table.Rows.IndexOf(objB)) ? 1 : -1;
                    }
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private DataRow GetRoot(DataRow row, ref int distance)
            {
                Debug.Assert(row != null);
                DataRow row4 = row;
                distance = 0;
                IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow> {
                    [row] = row
                };
                DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Default);
                while (true)
                {
                    int num1;
                    if ((parentRow == null) || dictionary.ContainsKey(parentRow))
                    {
                        num1 = 0;
                    }
                    else
                    {
                        num1 = 1;
                    }
                    bool flag = (bool) num1;
                    if (!flag)
                    {
                        if (distance == 0)
                        {
                            dictionary.Clear();
                            dictionary[row] = row;
                            parentRow = row.GetParentRow(this._relation, DataRowVersion.Original);
                            while (true)
                            {
                                int num2;
                                if ((parentRow == null) || dictionary.ContainsKey(parentRow))
                                {
                                    num2 = 0;
                                }
                                else
                                {
                                    num2 = 1;
                                }
                                flag = (bool) num2;
                                if (!flag)
                                {
                                    break;
                                }
                                distance++;
                                row4 = parentRow;
                                dictionary[parentRow] = parentRow;
                                parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Original);
                            }
                        }
                        return row4;
                    }
                    distance++;
                    row4 = parentRow;
                    dictionary[parentRow] = parentRow;
                    parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Default);
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public enum UpdateOrderOption
        {
            InsertUpdateDelete,
            UpdateInsertDelete
        }
    }
}

