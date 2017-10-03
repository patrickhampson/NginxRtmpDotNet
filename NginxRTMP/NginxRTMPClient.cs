using System;
using System.Net.Http;
using System.Net.Security;
using System.Xml.Serialization;
using NginxRTMP;

namespace NginxRtmp
{
    public class NginxRtmpClient
    {

        private string statUrl { get; set; }
        private bool disableCertValidation { get; set; }

        public NginxRtmpClient(string statUrl, bool disableCertValidation = false)
        {
            this.statUrl = statUrl;
            this.disableCertValidation = disableCertValidation;

        }

        public Rtmp pollNginxRtmp()
        {
            var handler = new HttpClientHandler();
            using (var httpClient = new HttpClient(handler))
            {
                if (disableCertValidation)
                {
                    handler.ServerCertificateCustomValidationCallback = (request, cert, chain, errors) =>
                    {
                        // Log it, then use the same answer it would have had if we didn't make a callback.
                        //Console.WriteLine(cert);
                        return errors == SslPolicyErrors.None;
                    };

                }

                var data = httpClient.GetStreamAsync(this.statUrl).Result;

                XmlSerializer serializer = new XmlSerializer(typeof(Rtmp));
                var ret = (Rtmp)serializer.Deserialize(data);

                return ret;
            }
        }
    }
}
