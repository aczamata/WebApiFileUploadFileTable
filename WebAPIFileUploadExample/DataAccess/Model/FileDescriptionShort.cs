﻿using System.Collections.Generic;

namespace DataAccess.Model
{
    public class AllUploadedFiles
    {
        public List<FileDescriptionShort> FileShortDescriptions { get; set; }
    }
    public class FileDescriptionShort
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}