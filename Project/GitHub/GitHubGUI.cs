﻿using System.Windows.Forms;

namespace Droid_deployer
{
    public partial class GitHubGUI : Form
    {
        #region Attribute
        private GitHubAdapter _gitHubAdapt;
        #endregion

        #region Properties
        public GitHubAdapter GitHubAdapt
        {
            get { return _gitHubAdapt; }
            set { _gitHubAdapt = value; }
        }
        #endregion

        #region Constructor
        public GitHubGUI()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            _gitHubAdapt = new GitHubAdapter();
            _gitHubAdapt.StatusChanged += _gitHubAdapt_StatusChanged;
            _gitHubLogger.GitHubAdapter = _gitHubAdapt;
        }
        #endregion

        #region Event
        private void _gitHubAdapt_StatusChanged()
        {
            if (_gitHubAdapt.IsLoggedIn)
            {
                _gitHubUserDetail.GitHubAdapter = _gitHubAdapt;
                _gitHubUserDetail.Visible = true;
                _gitHubLogger.Visible = false;
            }
            else
            {
                _gitHubUserDetail.Visible = false;
                _gitHubLogger.Visible = true;
            }
        }
        #endregion
    }
}
