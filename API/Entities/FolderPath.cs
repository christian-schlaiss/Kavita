﻿
using System;

namespace API.Entities
{
    public class FolderPath
    {
        public int Id { get; set; }
        public string Path { get; set; }
        /// <summary>
        /// Used when scanning to see if we can skip if nothing has changed. (not implemented)
        /// </summary>
        public DateTime LastScanned { get; set; }

        // Relationship
        public Library Library { get; set; }
        public int LibraryId { get; set; }
    }
}
