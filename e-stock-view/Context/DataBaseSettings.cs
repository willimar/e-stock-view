using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.stock.view.Context
{
    public class DataBaseSettings
    {
        private readonly string _session;
        private readonly IConfiguration _configuration;

        public string UserName { get { return this._configuration.ReadConfig<string>(this._session, nameof(UserName)); } }
        public string UserPws { get { return this._configuration.ReadConfig<string>(this._session, nameof(UserPws)); } }
        public string Host { get { return this._configuration.ReadConfig<string>(this._session, nameof(Host)); } }
        public string Auth { get { return this._configuration.ReadConfig<string>(this._session, nameof(Auth)); } }
        public string DatabaseName { get { return this._configuration.ReadConfig<string>(this._session, nameof(DatabaseName)); } }
        public int Port { get { return this._configuration.ReadConfig<int>(this._session, nameof(Port)); } }

        public DataBaseSettings(string session, IConfiguration configuration)
        {
            this._session = session;
            this._configuration = configuration;
        }

    }
}
