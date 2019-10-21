﻿using System;
using System.Collections.Generic;
using System.IO;

namespace PrintService.Update
{
    public class UpdateCheckerWeb : IUpdateChecker
    {
        private string updateUrl = null;
        private string user;
        private string psd;

        public void CleanUpdateServices()
        {
            
        }

        public void GetUpdateFIle(UpdateItem item, string savingPath)
        {
            
        }

        public Dictionary<string, string> GetUpdateItems()
        {
            Dictionary<string, string> fileInfoDictionary = new Dictionary<string, string>();
            //try
            //{
            //    List<string> fileVersionInfo = client.GetUpdateFileList(string.Empty).ToList();
            //    foreach (string info in fileVersionInfo)
            //    {
            //        string[] filenameAndVer = info.Split(new char[2] { '%', '%' }, StringSplitOptions.RemoveEmptyEntries);
            //        if (filenameAndVer.Length == 2)
            //            fileInfoDictionary.Add(filenameAndVer[0], filenameAndVer[1]);
            //        else
            //        {
            //            fileInfoDictionary.Add(filenameAndVer[0], "");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}

            return fileInfoDictionary;
        }

        public void Prepare()
        {
            
        }

        public void SetURI(string uri)
        {
            this.updateUrl = uri;
        }

        public void SetVerify(string user, string psd)
        {
            this.user = user;
            this.psd = psd;
        }
    }
}
