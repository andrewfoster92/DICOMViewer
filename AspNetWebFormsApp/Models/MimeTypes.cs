﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetWebFormsApp.DICOM.Models
{
    static class  MimeTypes
    {
        public static string DICOM = "application/dicom";
        public static string xmlDicom = "application/dicom+xml";
        public static string Jpeg = "image/jpeg";
        public static string WebP = "image/webp";
        public static string Json = "application/dicom+json";
        public static string UncompressedData = "application/octet-stream";
        public static string PlainText = "text/plain";
        public static string MultipartRelated = "multipart/related";
    }
}