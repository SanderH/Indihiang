using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

using Indihiang.Data;
using Indihiang.Cores.Features;
using Indihiang.Cores;
namespace Indihiang.Modules
{
    public partial class FilterControl : UserControl, BaseControl
    {
        private SynchronizationContext _synContext;
        private List<string> _listYears = new List<string>();
        private string _filterPage;
        private string _filterClientIP;
        private string _filterServerIP;
        private string _filterUsername;
        private string _filterDateFrom;
        private string _filterDateTo;

        private string _guid;
        private string _fileName;

        public string FilterPage
        {
            get
            {
                return _filterPage;
            }
            set
            {
                _filterPage = value;
            }
        }

        public string FilterClientIP
        {
            get
            {
                return _filterClientIP;
            }
            set
            {
                _filterClientIP = value;
            }
        }
        public string FilterServerIP
        {
            get
            {
                return _filterServerIP;
            }
            set
            {
                _filterServerIP = value;
            }
        }

        public string FilterUsername
        {
            get
            {
                return _filterUsername;
            }
            set
            {
                _filterUsername = value;
            }
        }

        public string FilterDateFrom
        {
            get
            {
                return _filterDateFrom;
            }
            set
            {
                _filterDateFrom = value;
            }
        }

        public string FilterDateTo
        {
            get
            {
                return _filterDateTo;
            }
            set
            {
                _filterDateTo = value;
            }
        }

        public FilterControl()
        {
            InitializeComponent();
            _synContext = AsyncOperationManager.SynchronizationContext;
        }

        #region BaseControl Members
        public event EventHandler<RenderInfoEventArgs> RenderHandler;

        public string FeatureGuid
        {
            get
            {
                return _guid;
            }
            set
            {
                _guid = value;
            }
        }

        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }

        public void Populate()
        {
            backgroundJob.RunWorkerAsync();
        }
        #endregion

        protected virtual void OnRenderHandler(RenderInfoEventArgs e)
        {
            if (RenderHandler != null)
                RenderHandler(this, e);
        }

        private void ShowData()
        {
            txtFilterPage.Text = _filterPage;
            txtFilterClientIP.Text = _filterClientIP;
            txtFilterServerIP.Text = _filterServerIP;
            txtFilterUsername.Text = _filterUsername;

            RenderInfoEventArgs info = new RenderInfoEventArgs(_guid, LogFeature.GENERAL, _fileName);
            _synContext.Post(OnRenderHandler, info);
        }

        private void backgroundJob_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                LogDataFacade facade = new LogDataFacade(_guid);
                //_filterPage = facade.GetFilterPage();
                //_filterClientIP = facade.GetFilterClientIP();
                //_filterServerIP = facade.GetFilterServerIP();
                //_filterUsername = facade.GetFilterUsername();
            }
            catch (Exception err)
            {
                Logger.Write(err.Message);
                Logger.Write(err.StackTrace);

                System.Diagnostics.Debug.WriteLine(err.Message);
            }
        }

        private void backgroundJob_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ShowData();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            foreach (string file in IndihiangHelper.GetIndihiangFileList(_guid))
            {
                IndihiangHelper.SetFilter(file,
                    txtFilterPage.Text,
                    txtFilterClientIP.Text,
                    txtFilterServerIP.Text,
                    txtFilterUsername.Text,
                    dateFrom.Checked ? dateFrom.Value.ToString("yyyy-MM-dd") : "",
                    dateTo.Checked ? dateTo.Value.ToString("yyyy-MM-dd") : ""
                    );
            }
        }
    }
}
