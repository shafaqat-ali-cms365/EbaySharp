﻿using ICSharpCode.SharpZipLib.Zip;


namespace EbaySharp.Entities.Develop.SellingApps.ListingManagement.Feed.Task
{
    public class ResultFile
    {
        public string FileName { get; set; }
        public Stream FileContent { get; set; }
        public async System.Threading.Tasks.Task SaveUncompressed(string folderPath)
        {
            using (ZipInputStream s = new(FileContent))
            {
                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    FileName = string.Concat(FileName.Split(Path.GetInvalidFileNameChars()));
                    using (FileStream streamWriter = File.Create($"{folderPath}\\{FileName.Replace(".zip", "")}"))
                    {

                        int size = 2048;
                        byte[] data = new byte[2048];
                        while (true)
                        {
                            size = await s.ReadAsync(data, 0, data.Length);
                            if (size > 0)
                            {
                                await streamWriter.WriteAsync(data, 0, size);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
