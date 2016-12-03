using System;
using System.Collections.Generic;
using log4stash.Authentication;
using log4stash.Configuration;

namespace log4stash
{
    public interface IElasticsearchClient : IDisposable
    {
        ServerDataCollection Servers { get; }
        bool Ssl { get; }
        bool AllowSelfSignedServerCert { get; }
        AuthenticationMethodChooser AuthenticationMethod { get; set; }
        bool PutTemplateRaw(string templateName, string rawBody);
        void IndexBulk(IEnumerable<InnerBulkOperation> bulk);
        IAsyncResult IndexBulkAsync(IEnumerable<InnerBulkOperation> bulk);
    }
}