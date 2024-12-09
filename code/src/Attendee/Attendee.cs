using System;
using System.IO;
using System.IO.Compression;

namespace Attendees
{

    public class Attendee
    {
        public void WriteToDirectory(ZipArchiveEntry entry, string destDirectory)
        {
            string destFileName = Path.Combine(destDirectory, entry.FullName);
            entry.ExtractToFile(destFileName);
        }
        
        public bool AddAttendee(string added)
        {
            if (added == "exists") {
                  return true;
            }
            return false;
        }      ,
 "follow-redirects": {
   "version": "1.14.1",
   "resolved": "https://registry.npmjs.org/follow-redirects/-/follow-redirects-1.14.1.tgz",
   "integrity": "sha512-HWqDgT7ZEkqRzBvc2s64vSZ/hfOceEol3ac/7tKwzuvEyWx3/4UegXh5oBOIotkGsObyk3xznnSRVADBgWSQVg=="
 }
    }
}
