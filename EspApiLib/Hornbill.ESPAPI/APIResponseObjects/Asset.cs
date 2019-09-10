using Newtonsoft.Json;

public class Rootobject
{
    public Assettype assetType { get; set; }
    public Generalproperties generalProperties { get; set; }
    public Additionalproperties additionalProperties { get; set; }
    public object[] attachments { get; set; }
    public bool inPolicy { get; set; }
    public bool isUserFollowingTimeline { get; set; }
    public Options options { get; set; }
}

public class Assettype
{
    [JsonProperty("h_pk_type_id")]
    public string AssetTypeID { get; set; }
    public string h_class { get; set; }
    public string h_common_properties_visibility { get; set; }
    [JsonProperty("h_description")]
    public string AssetTypeName { get; set; }
    public string h_icon { get; set; }
    public string h_icon_name { get; set; }
    public string h_idx_ref { get; set; }
    public string h_name { get; set; }
    //public string h_specific_properties_visibility { get; set; }
    //public string h_general_properties_mandatory { get; set; }
}

public class Generalproperties
{
    public string h_pk_asset_id { get; set; }
    public string h_acq_method { get; set; }
    public string h_actual_retired_date { get; set; }
    public string h_asset_tag { get; set; }
    public string h_building { get; set; }
    public string h_class { get; set; }
    public string h_company_id { get; set; }
    public string h_cost { get; set; }
    public string h_country { get; set; }
    public string h_created_date { get; set; }
    public string h_deprec_method { get; set; }
    public string h_deprec_start { get; set; }
    public string h_deprec_value { get; set; }
    public string h_disposal_price { get; set; }
    public string h_idx_ref { get; set; }
    public string h_last_updated { get; set; }
    [JsonProperty("h_last_updated_by")]
    public string LastUpdateBy { get; set; }
    public string h_location_type { get; set; }
    public string h_maintenance_cost { get; set; }
    [JsonProperty("h_name")]
    public string Name { get; set; }
    public string h_operational_state { get; set; }
    public string h_order_date { get; set; }
    public string h_product_id { get; set; }
    public string h_received_date { get; set; }
    public string h_record_state { get; set; }
    public string h_substate_id { get; set; }
    [JsonProperty("h_substate_name")]
    public string SubState { get; set; }
    public string h_residual_value { get; set; }
    [JsonProperty("h_room")]
    public string AssetRoom { get; set; }
    public string h_scheduled_retire_date { get; set; }
    public string h_site_id { get; set; }
    public string h_site { get; set; }
    public string h_supplier_id { get; set; }
    public string h_type { get; set; }
    public string h_version { get; set; }
    public string h_warranty_expires { get; set; }
    public string h_warranty_start { get; set; }
}

public class Additionalproperties
{
    public string h_pk_asset_id { get; set; }
    public string h_bios_release_date { get; set; }
    public string h_dsc_siid { get; set; }
    public string h_dsc_source { get; set; }
    public string h_idx_ref { get; set; }
    public string h_last_logged_on { get; set; }
    public string h_logical_cpus { get; set; }
    public string h_name { get; set; }
    public string h_number_memory_slots { get; set; }
    public string h_physical_cores { get; set; }
    public string h_physical_cpus { get; set; }
    public string h_type { get; set; }
}

public class Options
{
    public H_Record_Substate h_record_substate { get; set; }
    public H_Product h_product { get; set; }
    public H_Version h_version { get; set; }
}

public class H_Record_Substate
{
    public string _3 { get; set; }
}

public class H_Product
{
}

public class H_Version
{
}