using System;

namespace Hornbill.ESPAPI
{
    public class Activity
    {
        public string ID { get; set; }

        public string StreamID { get; set; }

        public string Verb { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Language { get; set; }

        public DateTime Published { get; set; }

        public DateTime Updated { get; set; }

        public int Likes { get; set; }

        public string Visibility { get; set; }
    }
}
/*
<actorInfo>
	<userId>SYS_SYSTEM</userId>
	<urn>urn:sys:user:SYS_SYSTEM</urn>
	<name>System Internal Context</name>
	<onLineNow>false</onLineNow>
	<icon>00/default</icon>
	<onlineStatus>offline</onlineStatus>
	<accountStatus>active</accountStatus>
	<availabilityStatusInfo>
		<id>0</id>
	</availabilityStatusInfo>
</actorInfo>
<icon>00/default</icon>
<titleNew>{"System Internal Context", "urn:sys:user:SYS_SYSTEM"} posted on Requests for {"Incident IN00009732", "urn:sys:entity:com.hornbill.servicemanager:Requests:IN00009732"}</titleNew>
<youLike>false</youLike>
<read>true</read>
<additionalCommentsCount>0</additionalCommentsCount>
<type>Escalate</type>
<activityType>post</activityType>
<status>normal</status>

 -- VIS -- Convert to enum?
     <xs:enumeration value="public" esp:mappedValue="1"/>
    <xs:enumeration value="trustedGuest" esp:mappedValue="10"/>
    <xs:enumeration value="user" esp:mappedValue="15"/>
    <xs:enumeration value="following" esp:mappedValue="20"/>
    <xs:enumeration value="colleague" esp:mappedValue="30"/>
    <xs:enumeration value="manager" esp:mappedValue="35"/>
    <xs:enumeration value="friend" esp:mappedValue="40"/>
    <xs:enumeration value="members" esp:mappedValue="50"/>
    <xs:enumeration value="owner" esp:mappedValue="100"/>*/