using Common.Logging;
using FincadMonitor.Fincad;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FincadMonitor
{
    public partial class MonitorApplicationForm : Form
    {
        private F3PlatformInterface _interface;
        private readonly ILog _logger = LogManager.GetCurrentClassLogger();

        public MonitorApplicationForm()
        {
            InitializeComponent();
        }

        #region "event handlers"

        #region "buttons"
        private void btnConnect_Click(object sender, EventArgs e)
        {
            _logger.Info("Connected Clicked");
            F3WorkerPoolStatus _status = null;            
            bool _hasError = false;

            _status = this.GetStatus();
            _hasError = _status.HasError();
            if (!_hasError)
            {
                this.btnConnect.Image = global::FincadMonitor.Properties.Resources.check;
                this.dgvWorkers.DataSource = _status.ToDataTable();
            }
            else
                this.btnConnect.Image = global::FincadMonitor.Properties.Resources.error;

            sslServerConnection.Text = _interface.g_uri;
        }

        private void btnActiveSessions_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {

        }

        private void btnKillSession_Click(object sender, EventArgs e)
        {

        }

        private void btnKillAllSessions_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region "grids"
        #endregion

        #endregion

        #region "private members"

        #region "fincad connection"
        private F3PlatformInterface InitializeInterface()
        {
            string _addressInput = txtAddress.Text;
            string _portInput = txtPort.Text;
            string _address = string.Empty;

            if (string.IsNullOrEmpty(_addressInput)) { _addressInput = "localhost"; }
            if (string.IsNullOrEmpty(_portInput)) { _portInput = "8505"; }

            _address = string.Format("http://{0}:{1}/", _addressInput, _portInput);

            if (_interface == null || !_interface.g_uri.Equals(_address, StringComparison.InvariantCultureIgnoreCase))
                _interface = F3PlatformInterface.getInstance(ref _address);

            return _interface;
        }

        private F3WorkerPoolStatus GetStatus()
        {
            string _statusText = string.Empty;
            F3WorkerPoolStatus _status = null;
            F3PlatformInterface _interfaceInstance = InitializeInterface();
            try
            {
                _statusText = _interfaceInstance.GetStatus();
                _status = JsonConvert.DeserializeObject<F3WorkerPoolStatus>(_statusText);
            }
            catch (Exception ex)
            {
                _logger.Error("error getting status", ex);
            }
            return _status;
        }

        #endregion

        #region "log"

        Timer _logReadingTimer = null;

        void HookupLogger()
        {
            _logReadingTimer = new Timer();
            _logReadingTimer.Interval = 1000;
            _logReadingTimer.Tick += logReadingTimer_Ticker;
            _logReadingTimer.Enabled = true;
            _logReadingTimer.Start();
        }

        void UnhookupLogger()
        {
            _logReadingTimer.Stop();            
        }

        void logReadingTimer_Ticker(object sender, EventArgs e)
        {
            this.ReadLogs();
        }

        void ReadLogs()
        {
            string[] values = null;
            var target = NLog.LogManager.Configuration.FindTargetByName("memory");
            var mt = target as NLog.Targets.MemoryTarget;
            IList <string> messagesToRemove = new List<string>();

            while (mt.Logs.Count > 0)
            {
                var log = mt.Logs[0];
                values = log.Split('|');
                mt.Logs.RemoveAt(0);
            }
            
        }

        #endregion

        private void MonitorApplicationForm_Load(object sender, EventArgs e)
        {
            this.HookupLogger();
            _logger.Info("Monitor Started");
        }

        #endregion

        private void MonitorApplicationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.UnhookupLogger();
        }

    }
}
