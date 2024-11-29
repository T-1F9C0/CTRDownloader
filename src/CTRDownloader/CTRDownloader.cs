using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UnifiedUpdatePlatform.Services.WindowsUpdate;

namespace CTRDownloader
{
    public static class CTRDownloader
    {
        [UnmanagedCallersOnly(EntryPoint = "DownloadCTR")]
        public static int DownloadCTR()
        {
            try
            {
                string[] categoryId = ["b04ba118-2f7f-4e8f-9276-acb69df6a6ab"];
                CTAC ctac = new UnifiedUpdatePlatform.Services.WindowsUpdate.CTAC();
                DirectoryInfo downloadDir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                DownloadProgress downloadProgress = new DownloadProgress();

                MSStoreDownloader.DownloadPackageAsync(categoryId, ctac, downloadDir, downloadProgress).GetAwaiter().GetResult();

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
