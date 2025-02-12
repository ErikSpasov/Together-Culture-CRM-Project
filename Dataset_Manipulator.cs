using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGui
{
    internal class Dataset_Manipulator
    {

        private DataSet dataset;

        public Dataset_Manipulator(DataSet dataset)
        {
            this.dataset = dataset;
        }

        public int Database
        {
            get => default;
            set
            {
            }
        }

        // Will return selected element form the result table/s from the SQL query into varible of datatype dataset.

        public string ReturnElementAsString(int tableNum, int rowNum, int columnNum)
        {
            return dataset.Tables[tableNum].Rows[rowNum].ItemArray.GetValue(columnNum).ToString();    
        }

        public int ReturnElementAsInt(int tableNum, int rowNum, int columnNum)
        {
            return Convert.ToInt32(dataset.Tables[tableNum].Rows[rowNum].ItemArray.GetValue(columnNum));
        }

        public int ReturnMaxTableNum()
        {
            return dataset.Tables.Count;
        }

        public int ReturnMaxRowNum(int table)
        {
            return dataset.Tables[table].Rows.Count;
        }

        public int ReturnMaxColumnNum(int table)
        {
            return dataset.Tables[table].Columns.Count;
        }

    }
}
