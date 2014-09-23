using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FincadMonitor.Fincad
{
    public class F3WorkerPoolStatus
    {
        public string Status { get; set; }

        [JsonProperty("workerPool")]
        public Dictionary<string, List<Object>> WorkerPool { get; set; }

        public System.Data.DataTable ToDataTable()
        {
            System.Data.DataTable _resultTable = new System.Data.DataTable();
            System.Data.DataRow _resultRow = null;

            _resultTable.TableName = "F3WorkerPoolStatus";
            _resultTable.Columns.Add("WorkerID", typeof(System.String));
            _resultTable.Columns.Add("PlatformPortNumber", typeof(System.Int64));
            _resultTable.Columns.Add("WorkerIPAddress", typeof(System.String));
            _resultTable.Columns.Add("WorkerPortNumber", typeof(System.Int64));
            _resultTable.Columns.Add("SessionID", typeof(System.String));
            _resultTable.Columns.Add("NRequest", typeof(System.Int64));
            _resultTable.Columns.Add("NResponses", typeof(System.Int64));
            _resultTable.Columns.Add("LastRequest", typeof(System.DateTime));

            foreach (var item in WorkerPool)
            {
                _resultRow = _resultTable.NewRow();
                _resultRow["WorkerID"] = item.Key;
                _resultRow["PlatformPortNumber"] = (long)item.Value[0];
                _resultRow["WorkerIPAddress"] = (string)item.Value[1];
                _resultRow["WorkerPortNumber"] = (long)item.Value[2];
                _resultRow["SessionID"] = (string)item.Value[3];
                _resultRow["NRequest"] = (long)item.Value[4];
                _resultRow["NResponses"] = (long)item.Value[5];
                _resultRow["LastRequest"] = UnixTimeStampToDateTime((double)item.Value[6]);
                _resultTable.Rows.Add(_resultRow);
            }

            return _resultTable;
        }

        private DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public bool HasError()
        {
            if (!string.IsNullOrEmpty(Status) && !Status.Contains("#"))
                return true;

            return false;

        }
    }
}
