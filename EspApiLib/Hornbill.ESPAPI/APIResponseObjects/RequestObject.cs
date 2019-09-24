using Newtonsoft.Json;
using System;

public class RequestObject
{
    [JsonProperty("h_pk_reference")]
    public string RequestID { get; set; }

    [JsonProperty("h_summary")]
    public string Summary { get; set; }

    [JsonProperty("h_requesttype")]
    public string RequestType { get; set; }

    [JsonProperty("customer_name")]
    public string CustomerName { get; set; }

    [JsonProperty("h_ownername")]
    public string OwnerName { get; set; }

    [JsonProperty("h_team_name")]
    public string TeamName { get; set; }

    [JsonProperty("h_closedby_teamname")]
    public string ClosedByTeamName { get; set; }

    [JsonProperty("createdby_name")]
    public string CreatedByName { get; set; }

    [JsonProperty("h_service_name")]
    public string ServiceName { get; set; }

    [JsonProperty("h_closedby_username")]
    public string ClosedByName { get; set; }

    [JsonProperty("h_reopencount")]
    public int ReopenedCount { get; set; }

    [JsonProperty("h_closure_category_id")]
    public int ClosureCategoryID { get; set; }

    [JsonProperty("h_closure_category")]
    public string ClosureCategory { get; set; }

    public DateTime DateLogged { get; set; }

    public DateTime DateResolved { get; set; }

    public DateTime DateClosed { get; set; }
}


//TODO: Add and map the below
//"h_fk_user_id": "JSmith",
//  "h_ownerid": "MPython",
//  "h_status": "status.closed",
//  "h_dateclosed": {"@raw": "2019-04-16 13:30:23",},
//  "h_fk_team_id": "organisation/HardwareTeam/",
//  "h_datelastmodified": {"@raw": "2019-04-16 13:30:23"},
//  "h_isanalystunread": "1",
//  "h_container_id": "0",
//  "h_createdby": "JBloggs",
//  "h_resolvedby_username": "John",
//  "h_reopencount": "0",
//  "h_source_type": "Analyst",
//  "h_site": "London HQ",
//  "h_catalog": "IT Change v1",