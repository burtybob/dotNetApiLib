using System.Xml.Serialization;

/// <remarks/>
[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
public partial class methodCallResult
{
    /// <remarks/>
    [XmlArrayItem("item", IsNullable = false)]
    [XmlArray("params")]
    public Item[] Items { get; set; }

    /// <remarks/>
    [XmlAttribute()]
    public string status { get; set; }
}

/// <remarks/>
[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public partial class Item
{
    /// <summary>
    /// Internal Hornbill ID
    /// </summary>
    public ushort id { get; set; }

    /// <summary>
    /// The name of the Item
    /// </summary>
    public string name { get; set; }
}