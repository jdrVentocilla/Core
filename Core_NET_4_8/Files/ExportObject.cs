﻿
namespace Core.Files
{
    public class ExportObject
    {
        public string fileName { get; set; }
        public byte[] ms { get; set; }
        public Format format { get; set; }


        public ExportObject(string fileName, byte[] ms, Format format)
        {
            this.ms = ms;
            this.format = format;
            this.fileName = fileName;


        }
    }
}
