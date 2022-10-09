using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

using Indihiang.Data;
using Indihiang.DomainObject;
using Indihiang.Cores.Features;
using Indihiang.Cores;
using ZedGraph;
namespace Indihiang.Modules
{
    public partial class AccessUsernameControl : UserControl, BaseControl
    {
        private readonly SynchronizationContext _synContext;
        private List<string> _listYears = new List<string>();
        private List<DumpData> _listAccessUsernames1 = new List<DumpData>();
        private List<DumpData> _listAccessUsernames2 = new List<DumpData>();
        private List<DumpData> _listAccessUsernames3 = new List<DumpData>();
        private List<DumpData> _listAccessUsernames4 = new List<DumpData>();
        private string _guid;
        private string _fileName;

        public AccessUsernameControl()
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

        public List<string> ListOfYear
        {
            set
            {
                _listYears = value;
            }
            get
            {
                return _listYears;
            }
        }

        public void Populate()
        {
            cboYear1.Items.AddRange(_listYears.ToArray());
            cboYear2.Items.AddRange(_listYears.ToArray());
            cboYear3.Items.AddRange(_listYears.ToArray());
            cboYear4.Items.AddRange(_listYears.ToArray());

            RenderInfoEventArgs info = new RenderInfoEventArgs(_guid, LogFeature.ACCESS_USERNAME, _fileName);
            _synContext.Post(OnRenderHandler, info);

        }
        #endregion

        protected virtual void OnRenderHandler(RenderInfoEventArgs e)
        {
            if (RenderHandler != null)
                RenderHandler(this, e);
        }

        private void SetGridLayout1()
        {
            dataGridAccessUsernames.ColumnCount = 2;
            dataGridAccessUsernames.Columns[0].Name = "Date";
            dataGridAccessUsernames.Columns[0].Width = 150;
            dataGridAccessUsernames.Columns[0].ValueType = typeof(System.DateTime);
            dataGridAccessUsernames.Columns[0].DefaultCellStyle.Format = "dd MMM yyyy";
            dataGridAccessUsernames.Columns[1].Name = "Total Users";
            dataGridAccessUsernames.Columns[1].Width = 100;
            //dataGridAccessUsernames.Columns[0].ValueType = typeof(System.Int32);

            dataGridAccessUsernames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAccessUsernames.MultiSelect = false;
        }

        private void SetGridLayout2()
        {
            dataGridAccessUsernames.ColumnCount = 2;
            dataGridAccessUsernames.Columns[0].Name = "Date (Monthly)";
            dataGridAccessUsernames.Columns[0].Width = 150;
            dataGridAccessUsernames.Columns[0].ValueType = typeof(System.DateTime);
            dataGridAccessUsernames.Columns[0].DefaultCellStyle.Format = "MMM yyyy";
            dataGridAccessUsernames.Columns[1].Name = "Total Users";
            dataGridAccessUsernames.Columns[1].Width = 100;
            //dataGridAccessUsernames.Columns[0].ValueType = typeof(System.Int32);

            dataGridAccessUsernames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAccessUsernames.MultiSelect = false;
        }

        private void SetGridLayout3()
        {
            dataGridAccessUsernamesUnique.ColumnCount = 3;
            dataGridAccessUsernamesUnique.Columns[0].Name = "Date";
            dataGridAccessUsernamesUnique.Columns[0].Width = 150;
            dataGridAccessUsernamesUnique.Columns[0].ValueType = typeof(System.DateTime);
            dataGridAccessUsernamesUnique.Columns[0].DefaultCellStyle.Format = "dd MMM yyyy";
            dataGridAccessUsernamesUnique.Columns[1].Name = "Access Username";
            dataGridAccessUsernamesUnique.Columns[1].Width = 200;
            dataGridAccessUsernamesUnique.Columns[2].Name = "Total Hits";
            dataGridAccessUsernamesUnique.Columns[2].Width = 100;
            //dataGridAccessUsernamesUnique.Columns[0].ValueType = typeof(System.Int32);

            dataGridAccessUsernamesUnique.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAccessUsernamesUnique.MultiSelect = false;
        }

        private void SetGridLayout4()
        {
            dataGridAccessUsernamesUnique.ColumnCount = 3;
            dataGridAccessUsernamesUnique.Columns[0].Name = "Date (Month)";
            dataGridAccessUsernamesUnique.Columns[0].Width = 150;
            dataGridAccessUsernamesUnique.Columns[0].ValueType = typeof(System.DateTime);
            dataGridAccessUsernamesUnique.Columns[0].DefaultCellStyle.Format = "MMM yyyy";
            dataGridAccessUsernamesUnique.Columns[1].Name = "Access Username";
            dataGridAccessUsernamesUnique.Columns[1].Width = 200;
            dataGridAccessUsernamesUnique.Columns[2].Name = "Total Hits";
            dataGridAccessUsernamesUnique.Columns[2].Width = 100;
            //dataGridAccessUsernamesUnique.Columns[0].ValueType = typeof(System.Int32);

            dataGridAccessUsernamesUnique.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAccessUsernamesUnique.MultiSelect = false;
        }

        private void GenerateGraphAccessUsernamesPerDay()
        {
            GraphPane pane = zedAccessUsernames1.GraphPane;
            pane.CurveList.Clear();

            pane.Title.Text = "Total Users per Day Graph";
            pane.XAxis.Title.Text = "Date";
            pane.XAxis.Type = AxisType.Date;
            pane.XAxis.Scale.Format = "yyyy-MMM-dd";
            pane.YAxis.Title.Text = "Total Users";
            pane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            pane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            if (_listAccessUsernames1.Count > 0)
            {
                double x, y;
                PointPairList list1 = new PointPairList();

                string year = cboYear1.SelectedItem.ToString();
                for (int i = 0; i < _listAccessUsernames1.Count; i++)
                {
                    DateTime date = new DateTime(Convert.ToInt32(year), _listAccessUsernames1[i].Month, _listAccessUsernames1[i].Day);
                    x = date.ToOADate();

                    y = Convert.ToDouble(_listAccessUsernames1[i].Total);
                    list1.Add(x, y);
                }


                LineItem line = pane.AddCurve("Users per Day", list1, Color.Red, SymbolType.Star);
                line.Line.IsSmooth = true;
            }

            zedAccessUsernames1.IsShowPointValues = true;
            zedAccessUsernames1.AxisChange();
        }

        private void GenerateGraphAccessUsernamesPerMonth()
        {
            GraphPane pane = zedAccessUsernames2.GraphPane;
            pane.CurveList.Clear();

            pane.Title.Text = "Total Users per Month Graph";
            pane.XAxis.Title.Text = "Month";
            pane.XAxis.Type = AxisType.DateAsOrdinal;
            pane.XAxis.Scale.Format = "MMM";
            pane.YAxis.Title.Text = "Total Users";
            pane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            pane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            if (_listAccessUsernames2.Count > 0)
            {
                double x, y;
                PointPairList list1 = new PointPairList();

                string year = cboYear2.SelectedItem.ToString();
                for (int i = 0; i < _listAccessUsernames2.Count; i++)
                {
                    DateTime date = new DateTime(Convert.ToInt32(year), _listAccessUsernames2[i].Month, 1);
                    x = date.ToOADate();

                    y = Convert.ToDouble(_listAccessUsernames2[i].Total);
                    list1.Add(x, y);
                }

                LineItem line = pane.AddCurve("Users per Month", list1, Color.Red, SymbolType.Star);
                line.Line.IsSmooth = true;
            }

            zedAccessUsernames2.IsShowPointValues = true;
            zedAccessUsernames2.AxisChange();
        }

        private void GenerateGraphAccessUsernamesGrid()
        {
            string selectedHits = cboAccessUsernamesData1.SelectedItem.ToString();
            if (_listAccessUsernames3.Count > 0)
            {
                dataGridAccessUsernames.Rows.Clear();
                int year = Convert.ToInt32(cboYear3.SelectedItem);
                if (selectedHits == "Users per Day")
                {
                    SetGridLayout1();
                    for (int i = 0; i < _listAccessUsernames3.Count; i++)
                    {
                        DateTime dt = new DateTime(year, _listAccessUsernames3[i].Month, _listAccessUsernames3[i].Day);
                        List<object> data = new List<object>();
                        data.Add(dt);
                        data.Add(_listAccessUsernames3[i].Total);

                        dataGridAccessUsernames.Rows.Add(data.ToArray());
                    }

                }
                if (selectedHits == "Users per Month")
                {
                    SetGridLayout2();
                    for (int i = 0; i < _listAccessUsernames3.Count; i++)
                    {
                        DateTime dt = new DateTime(year, _listAccessUsernames3[i].Month, 1);
                        List<object> data = new List<object>();
                        data.Add(dt);
                        data.Add(_listAccessUsernames3[i].Total);

                        dataGridAccessUsernames.Rows.Add(data.ToArray());
                    }
                }
            }
        }

        private void GenerateGraphAccessUsernamesUniqueGrid()
        {
            string selectedHits = cboAccessUsernamesData2.SelectedItem.ToString();
            if (_listAccessUsernames4.Count > 0)
            {
                dataGridAccessUsernamesUnique.Rows.Clear();
                int year = Convert.ToInt32(cboYear4.SelectedItem);
                if (selectedHits == "Users per Day")
                {
                    SetGridLayout3();
                    for (int i = 0; i < _listAccessUsernames4.Count; i++)
                    {
                        DateTime dt = new DateTime(year, _listAccessUsernames4[i].Month, _listAccessUsernames4[i].Day);
                        List<object> data = new List<object>();
                        data.Add(dt);
                        data.Add(_listAccessUsernames4[i].Access_Username);
                        data.Add(_listAccessUsernames4[i].Total);

                        dataGridAccessUsernamesUnique.Rows.Add(data.ToArray());
                    }

                }
                if (selectedHits == "Users per Month")
                {
                    SetGridLayout4();
                    for (int i = 0; i < _listAccessUsernames4.Count; i++)
                    {
                        DateTime dt = new DateTime(year, _listAccessUsernames4[i].Month, 1);
                        List<object> data = new List<object>();
                        data.Add(dt);
                        data.Add(_listAccessUsernames4[i].Access_Username);
                        data.Add(_listAccessUsernames4[i].Total);

                        dataGridAccessUsernamesUnique.Rows.Add(data.ToArray());
                    }
                }
            }
        }

        private void SetSize()
        {
            zedAccessUsernames1.Location = new Point(10, 10);
            zedAccessUsernames1.Size = new Size(ClientRectangle.Width - 20, ClientRectangle.Height - 20);

            zedAccessUsernames2.Location = new Point(10, 10);
            zedAccessUsernames2.Size = new Size(ClientRectangle.Width - 20, ClientRectangle.Height - 20);
        }

        private void AccessUsernameControl_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private string zedHits1_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            PointPair pt = curve[iPt];
            DateTime date = DateTime.FromOADate(pt.X);

            return String.Format("{0}\r\nTime: {1:yyyy-MMM-dd}\r\nHits: {2:f2}", curve.Label.Text, date, pt.Y);
        }

        private string zedHits2_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            PointPair pt = curve[iPt];
            DateTime date = DateTime.FromOADate(pt.X);

            return String.Format("[{0:yyyy-MMM} --> {1:f2} Hit(s)]", date, pt.Y);
        }

        //private void backgroundJob_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    try
        //    {
        //        LogDataFacade facade = new LogDataFacade(_guid);
        //        _listYears = facade.GetListyearLogFile();
        //    }
        //    catch (Exception err)
        //    {
        //        System.Diagnostics.Debug.WriteLine(err.Message);
        //    }
        //}

        //private void backgroundJob_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    cboYear1.Items.AddRange(_listYears.ToArray());
        //    cboYear2.Items.AddRange(_listYears.ToArray());
        //    cboYear3.Items.AddRange(_listYears.ToArray());

        //    RenderInfoEventArgs info = new RenderInfoEventArgs(_guid, LogFeature.HITS, _fileName);
        //    _synContext.Post(OnRenderHandler, info);
        //}

        private void btnGenerate1_Click(object sender, EventArgs e)
        {
            if (cboYear1.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose report year", "Information");
                return;
            }
            btnGenerate1.Text = "Generating...";
            btnGenerate1.Enabled = false;
            backgroundJobAccessUsernamesDay.RunWorkerAsync(cboYear1.SelectedItem);
        }

        private void btnGenerate2_Click(object sender, EventArgs e)
        {
            if (cboYear2.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose report year", "Information");
                return;
            }
            btnGenerate2.Text = "Generating...";
            btnGenerate2.Enabled = false;
            backgroundJobAccessUsernamesMonth.RunWorkerAsync(cboYear2.SelectedItem);
        }

        private void backgroundJobAccessUsernamesDay_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string par = e.Argument.ToString();
                LogDataFacade facade = new LogDataFacade(_guid);

                _listAccessUsernames1 = new List<DumpData>(facade.GetAccessUsernamesByParams(Convert.ToInt32(par)));
            }
            catch (Exception err)
            {
                Logger.Write(err.Message);
                Logger.Write(err.StackTrace);

                System.Diagnostics.Debug.WriteLine(err.Message);
            }
        }

        private void backgroundJobAccessUsernamesDay_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_listAccessUsernames1.Count > 0)
            {
                GenerateGraphAccessUsernamesPerDay();
                SetSize();
            }
            btnGenerate1.Text = "Generate";
            btnGenerate1.Enabled = true;
        }

        private void backgroundAccessUsernamesMonth_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string par = e.Argument.ToString();
                LogDataFacade facade = new LogDataFacade(_guid);

                _listAccessUsernames2 = new List<DumpData>(facade.GetMonthAccessUsernamesByParams(Convert.ToInt32(par)));
            }
            catch (Exception err)
            {
                Logger.Write(err.Message);
                Logger.Write(err.StackTrace);

                System.Diagnostics.Debug.WriteLine(err.Message);
            }
        }

        private void backgroundAccessUsernamesMonth_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_listAccessUsernames2.Count > 0)
            {
                GenerateGraphAccessUsernamesPerMonth();
                SetSize();
            }
            btnGenerate2.Text = "Generate";
            btnGenerate2.Enabled = true;
        }

        private void btnGenerate3_Click(object sender, EventArgs e)
        {
            if (cboAccessUsernamesData1.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose report type", "Information");
                return;
            }
            if (cboYear3.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose report year", "Information");
                return;
            }
            btnGenerate3.Text = "Generating...";
            btnGenerate3.Enabled = false;
            backgroundJobAccessUsernamesDataGrid.RunWorkerAsync(string.Format("{0};{1}", cboAccessUsernamesData1.SelectedItem, cboYear3.SelectedItem));
        }

        private void backgroundJobAccessUsernamesDataGrid_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string par = e.Argument.ToString();
                string[] items = par.Split(new char[] { ';' });

                LogDataFacade facade = new LogDataFacade(_guid);

                if (items[0] == "Users per Day")
                    _listAccessUsernames3 = new List<DumpData>(facade.GetAccessUsernamesByParams(Convert.ToInt32(items[1])));

                if (items[0] == "Users per Month")
                    _listAccessUsernames3 = new List<DumpData>(facade.GetMonthAccessUsernamesByParams(Convert.ToInt32(items[1])));

            }
            catch (Exception err)
            {
                Logger.Write(err.Message);
                Logger.Write(err.StackTrace);

                System.Diagnostics.Debug.WriteLine(err.Message);
            }
        }

        private void backgroundAccessUsernamesDataGrid_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_listAccessUsernames3.Count > 0)
                GenerateGraphAccessUsernamesGrid();

            btnGenerate3.Text = "Generate";
            btnGenerate3.Enabled = true;
        }

        private void btnGenerate4_Click(object sender, EventArgs e)
        {
            if (cboAccessUsernamesData2.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose report type", "Information");
                return;
            }
            if (cboYear4.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose report year", "Information");
                return;
            }
            btnGenerate4.Text = "Generating...";
            btnGenerate4.Enabled = false;
            backgroundJobAccessUsernamesUniqueDataGrid.RunWorkerAsync(string.Format("{0};{1}", cboAccessUsernamesData2.SelectedItem, cboYear4.SelectedItem));
        }

        private void backgroundJobAccessUsernamesUniqueDataGrid_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string par = e.Argument.ToString();
                string[] items = par.Split(new char[] { ';' });

                LogDataFacade facade = new LogDataFacade(_guid);

                if (items[0] == "Users per Day")
                    _listAccessUsernames4 = new List<DumpData>(facade.GetAccessUsernamesUniqueByParams(Convert.ToInt32(items[1])));

                if (items[0] == "Users per Month")
                    _listAccessUsernames4 = new List<DumpData>(facade.GetMonthAccessUsernamesUniqueByParams(Convert.ToInt32(items[1])));

            }
            catch (Exception err)
            {
                Logger.Write(err.Message);
                Logger.Write(err.StackTrace);

                System.Diagnostics.Debug.WriteLine(err.Message);
            }
        }

        private void backgroundJobAccessUsernamesUniqueDataGrid_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_listAccessUsernames4.Count > 0)
                GenerateGraphAccessUsernamesUniqueGrid();

            btnGenerate4.Text = "Generate";
            btnGenerate4.Enabled = true;
        }
    }
}
