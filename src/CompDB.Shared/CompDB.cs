﻿using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CompDB
{
    public class CompDBXmlClass
    {
        [XmlRoot(ElementName = "Tag", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class Tag
        {
            [XmlAttribute(AttributeName = "Name")]
            public string Name { get; set; }
            [XmlAttribute(AttributeName = "Value")]
            public string Value { get; set; }
        }

        [XmlRoot(ElementName = "Tags", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class Tags
        {
            [XmlElement(ElementName = "Tag", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
            public List<Tag> Tag { get; set; }
            [XmlAttribute(AttributeName = "Type")]
            public string Type { get; set; }
        }

        [XmlRoot(ElementName = "Feature", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class Feature2
        {
            [XmlAttribute(AttributeName = "FeatureID")]
            public string FeatureID { get; set; }
        }

        [XmlRoot(ElementName = "Dependencies", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class Dependencies
        {
            [XmlElement(ElementName = "Feature", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
            public List<Feature2> Feature { get; set; }
        }

        [XmlRoot(ElementName = "Package", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class Package
        {
            [XmlAttribute(AttributeName = "ID")]
            public string ID { get; set; }
            [XmlAttribute(AttributeName = "PackageType")]
            public string PackageType { get; set; }
            [XmlElement(ElementName = "Payload", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
            public Payload Payload { get; set; }
            [XmlAttribute(AttributeName = "Version")]
            public string Version { get; set; }
            [XmlAttribute(AttributeName = "InstalledSize")]
            public string InstalledSize { get; set; }
        }

        [XmlRoot(ElementName = "Packages", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class Packages
        {
            [XmlElement(ElementName = "Package", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
            public List<Package> Package { get; set; }
        }

        [XmlRoot(ElementName = "Features", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class Features
        {
            [XmlElement(ElementName = "Feature", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
            public Feature[] Feature { get; set; }
        }

        [XmlRoot(ElementName = "Feature", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class Feature
        {
            [XmlAttribute(AttributeName = "Type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "FeatureID")]
            public string FeatureID { get; set; }
            [XmlAttribute(AttributeName = "FMID")]
            public string FMID { get; set; }
            [XmlAttribute(AttributeName = "Group")]
            public string Group { get; set; }
            [XmlElement(ElementName = "Dependencies")]
            public Dependencies Dependencies { get; set; }
            [XmlElement(ElementName = "Packages")]
            public Packages Packages { get; set; }
        }

        [XmlRoot(ElementName = "PayloadItem", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class PayloadItem
        {
            [XmlAttribute(AttributeName = "PayloadHash")]
            public string PayloadHash { get; set; }
            [XmlAttribute(AttributeName = "PayloadSize")]
            public string PayloadSize { get; set; }
            [XmlAttribute(AttributeName = "Path")]
            public string Path { get; set; }
            [XmlAttribute(AttributeName = "PayloadType")]
            public string PayloadType { get; set; }
        }

        [XmlRoot(ElementName = "Payload", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class Payload
        {
            [XmlElement(ElementName = "PayloadItem", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
            public PayloadItem PayloadItem { get; set; }
        }

        [XmlRoot(ElementName = "CompDB", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
        public class CompDB
        {
            [XmlElement(ElementName = "Tags", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
            public Tags Tags { get; set; }
            [XmlElement(ElementName = "Features", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
            public Features Features { get; set; }
            [XmlElement(ElementName = "Packages", Namespace = "http://schemas.microsoft.com/embedded/2004/10/ImageUpdate")]
            public Packages Packages { get; set; }
            [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsi { get; set; }
            [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
            public string Xsd { get; set; }
            [XmlAttribute(AttributeName = "CreatedDate")]
            public string CreatedDate { get; set; }
            [XmlAttribute(AttributeName = "Revision")]
            public string Revision { get; set; }
            [XmlAttribute(AttributeName = "SchemaVersion")]
            public string SchemaVersion { get; set; }
            [XmlAttribute(AttributeName = "Product")]
            public string Product { get; set; }
            [XmlAttribute(AttributeName = "BuildID")]
            public string BuildID { get; set; }
            [XmlAttribute(AttributeName = "BuildInfo")]
            public string BuildInfo { get; set; }
            [XmlAttribute(AttributeName = "OSVersion")]
            public string OSVersion { get; set; }
            [XmlAttribute(AttributeName = "BuildArch")]
            public string BuildArch { get; set; }
            [XmlAttribute(AttributeName = "ReleaseType")]
            public string ReleaseType { get; set; }
            [XmlAttribute(AttributeName = "Type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }
        }

        public static CompDB DeserializeCompDB(Stream stringReader)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CompDB));
            return (CompDB)xmlSerializer.Deserialize(stringReader);
        }
    }
}