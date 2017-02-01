using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Droid_deployer
{
    public delegate void GitHubAdapterEventHandler();
    public class GitHubAdapter
    {
        #region Attribute
        public event GitHubAdapterEventHandler StatusChanged;
        public event GitHubAdapterEventHandler ConnectionFailled;

        private bool _isLoggedIn;
        private Octokit.User _currentUser;
        private GitHubClient _client;
        private string _user;
        private string _repoUser;
        private string _password;
        #endregion

        #region Properties
        public string RepoUser
        {
            get { return _repoUser; }
            set { _repoUser = value; }
        }
        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
        }
        public Octokit.User CurrentUser
        {
            get { return _currentUser; }
        }
        #endregion

        #region Constructor
        public GitHubAdapter()
        {
            _isLoggedIn = false;
        }
        public GitHubAdapter(string user, string pwd, string url = "https://github.com")
        {
            try
            {
                _user = user;
                _password = pwd;
                var ghe = new Uri(url);
                _client = new GitHubClient(new ProductHeaderValue("Droid-Deployer"), ghe);
                var basicAuth = new Credentials(user, pwd);
                _client.Credentials = basicAuth;

                _isLoggedIn = true;
                if (StatusChanged != null) { StatusChanged(); }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                if (ConnectionFailled != null)
                {
                    ConnectionFailled();
                }
            }
        }
        #endregion

        #region Methods public
        public async void LogUser(string user, string pwd, string url = "https://github.com")
        {
            try
            {
                _user = user;
                _password = pwd;
                var ghe = new Uri(url);
                _client = new GitHubClient(new ProductHeaderValue("Droid-Deployer"), ghe);
                var basicAuth = new Credentials(user, pwd);
                _client.Credentials = basicAuth;

                if (StatusChanged != null)
                {
                    StatusChanged();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                if (ConnectionFailled != null)
                {
                    ConnectionFailled();
                }
            }
        }
        public void PublishIssue(string repoName, string title, string body)
        {
            try
            {
                if ("Droid-Autre".Equals(repoName))
                {
                    repoName = "Server";
                }
                if (_client != null && _isLoggedIn)
                {
                    Repository repo = GetRepo(repoName);
                    if (repo != null)
                    {
                        NewIssue issue = new NewIssue(title);
                        issue.Body = body;
                        _client.Issue.Create(repo.Id, issue);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        public void LogOff()
        {
            _client = null;
        }
        #endregion

        #region Methods private
        private Repository GetRepo(string repoName)
        {
            if (_client != null && _isLoggedIn)
            {
                string repoUser = string.IsNullOrEmpty(_repoUser) ? _user : _repoUser;
                Task<IReadOnlyList<Octokit.Repository>> getRepoList = null;
                Task.Run(() => getRepoList = _client.Repository.GetAllForUser(repoUser)).Wait();

                if (getRepoList.Result != null && getRepoList.Result.Count > 0)
                {
                    var lstRepo = getRepoList.Result.Where(r => r.Name.Equals(repoName)).ToList();
                    if (lstRepo != null && lstRepo.Count > 0) return lstRepo[0];
                }
            }
            return null;
        }
        #endregion
    }
}