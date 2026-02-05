using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public delegate void DownloadCompleted();

    class Downloader
    {
        private readonly DownloadCompleted _callback;

        public Downloader(DownloadCompleted callback)
        {
            _callback = callback;
        }

        public void Download()
        {
            Console.WriteLine("Downloading file...");
            _callback();   // delegate call
        }
    }

}
