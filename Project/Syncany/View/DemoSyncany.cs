using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid_deployer
{
    public partial class DemoSyncany : Form
    {
        #region Attribute
        private Interface_syncany _intSyn;
        #endregion

        #region Properties
        #endregion

        #region Constuctor
        public DemoSyncany()
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
            Tools4Libraries.Log.ApplicationAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-Deployer";
            _intSyn = new Interface_syncany();

            comboBoxConnectionType.Items.Clear();
            foreach (Plugin plugin in SyncanyAdapter.AvalailablePlugins)
            {
                comboBoxConnectionType.Items.Add(plugin.Id);
            }
            dataGridView1.DataSource = _intSyn.CloudRepositories;
        }
        private void CreateCloud()
        {
            if (!string.IsNullOrEmpty(textBoxConfigPath.Text) && !string.IsNullOrEmpty(textBoxOriginPath.Text) && !string.IsNullOrEmpty(_intSyn.CloudConnectionType))
            {
                _intSyn.CloudConfigPath = textBoxConfigPath.Text;
                _intSyn.DirectoryOriginal = textBoxOriginPath.Text;

                _intSyn.GlobalAction("createcloud");
            }
        }
        #endregion

        #region Event
        private void buttonBrowseConfigPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxConfigPath.Text = fbd.SelectedPath;
            }
        }
        private void buttonBrowseOriginPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxOriginPath.Text = fbd.SelectedPath;
            }
        }
        private void buttonCreateCloud_Click(object sender, EventArgs e)
        {
            CreateCloud();
        }
        private void buttonBrowseAddRepository_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxRepoToAssociate.Text = fbd.SelectedPath;
            }
        }
        private void comboBoxConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _intSyn.CloudConnectionType = comboBoxConnectionType.SelectedItem.ToString().Trim();
        }
        private void buttonAddRepo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxRepoToAssociate.Text))
            {
                _intSyn.DirectoryToAssociate = textBoxRepoToAssociate.Text;
                _intSyn.GlobalAction("associatedirectory");
            }
        }
        #endregion
    }
}
