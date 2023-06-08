using System.Xml.Serialization;

namespace Refresh.GameServer.Types.UserData.Photos;

#nullable disable

[XmlRoot("photo")]
[XmlType("photo")]
public class SerializedPhoto
{
    [XmlAttribute("timestamp")]
    public long Timestamp { get; set; }
    
    [XmlElement("small")] public string SmallHash { get; set; }
    [XmlElement("medium")] public string MediumHash { get; set; }
    [XmlElement("large")] public string LargeHash { get; set; }
    [XmlElement("plan")] public string PlanHash { get; set; }
    
    [XmlArray("subjects")] public List<SerializedPhotoSubject> PhotoSubjects { get; set; }
}