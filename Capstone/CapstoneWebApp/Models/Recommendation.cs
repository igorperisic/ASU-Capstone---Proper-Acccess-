using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CapstoneWebApp.Models
{
    public class Recommendation
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Icon
        {
            public int height { get; set; }
            public string url { get; set; }
            public int width { get; set; }
        }

        public class UnifiDeviceInfoFromUcore
        {
            public string device_state { get; set; }
            public string fw_status { get; set; }
            public string fw_version { get; set; }
            public string icon_filename { get; set; }
            public List<List<int>> icon_resolutions { get; set; }
            public List<Icon> icons { get; set; }
            public bool managed { get; set; }
            public string name { get; set; }
            public string product_line { get; set; }
            public string product_model { get; set; }
        }

        public class Datum
        {
            public string _id { get; set; }
            public bool _is_guest_by_uap { get; set; }
            public bool _is_guest_by_ugw { get; set; }
            public bool _is_guest_by_usw { get; set; }
            public int _last_seen_by_uap { get; set; }
            public int _last_seen_by_ugw { get; set; }
            public int _last_seen_by_usw { get; set; }
            public int _uptime_by_uap { get; set; }
            public int _uptime_by_ugw { get; set; }
            public int _uptime_by_usw { get; set; }
            public int anomalies { get; set; }
            public string anon_client_id { get; set; }
            public string ap_mac { get; set; }
            public int assoc_time { get; set; }
            public string bssid { get; set; }

            [JsonProperty("bytes-r")]
            public int? BytesR { get; set; }
            public int ccq { get; set; }
            public int channel { get; set; }
            public int confidence { get; set; }
            public int dev_cat { get; set; }
            public int dev_family { get; set; }
            public int dev_id { get; set; }
            public int dev_vendor { get; set; }
            public int dhcpend_time { get; set; }
            public int disconnect_timestamp { get; set; }
            public string essid { get; set; }
            public string fingerprint_engine_version { get; set; }
            public int fingerprint_source { get; set; }
            public int first_seen { get; set; }
            public string gw_mac { get; set; }
            public string hostname { get; set; }
            public string hostname_source { get; set; }
            public int idletime { get; set; }
            public string ip { get; set; }
            public bool is_11r { get; set; }
            public bool is_guest { get; set; }
            public bool is_wired { get; set; }
            public int last_seen { get; set; }
            public int latest_assoc_time { get; set; }
            public string mac { get; set; }
            public string network { get; set; }
            public string network_id { get; set; }
            public int noise { get; set; }
            public int os_name { get; set; }
            public string oui { get; set; }
            public bool powersave_enabled { get; set; }
            public bool qos_policy_applied { get; set; }
            public string radio { get; set; }
            public string radio_name { get; set; }
            public string radio_proto { get; set; }
            public int rssi { get; set; }
            public int rx_bytes { get; set; }

            [JsonProperty("rx_bytes-r")]
            public int RxBytesR { get; set; }
            public int rx_packets { get; set; }
            public int rx_rate { get; set; }
            public int satisfaction { get; set; }
            public int satisfaction_now { get; set; }
            public int satisfaction_real { get; set; }
            public int satisfaction_reason { get; set; }
            public int signal { get; set; }
            public string site_id { get; set; }
            public int sw_depth { get; set; }
            public string sw_mac { get; set; }
            public int sw_port { get; set; }
            public int tx_bytes { get; set; }

            [JsonProperty("tx_bytes-r")]
            public int TxBytesR { get; set; }
            public int tx_mcs { get; set; }
            public int tx_packets { get; set; }
            public int tx_power { get; set; }
            public int tx_rate { get; set; }
            public int tx_retries { get; set; }
            public int uptime { get; set; }
            public string user_group_id_computed { get; set; }
            public string user_id { get; set; }
            public int vlan { get; set; }
            public int wifi_tx_attempts { get; set; }
            public int wired_rate_mbps { get; set; }
            public string wlanconf_id { get; set; }
            public object eagerly_discovered { get; set; }
            public string usergroup_id { get; set; }

            [JsonProperty("wired-rx_bytes")]
            public int? WiredRxBytes { get; set; }

            [JsonProperty("wired-rx_bytes-r")]
            public int? WiredRxBytesR { get; set; }

            [JsonProperty("wired-rx_packets")]
            public int? WiredRxPackets { get; set; }

            [JsonProperty("wired-tx_bytes")]
            public long? WiredTxBytes { get; set; }

            [JsonProperty("wired-tx_bytes-r")]
            public int? WiredTxBytesR { get; set; }

            [JsonProperty("wired-tx_packets")]
            public int? WiredTxPackets { get; set; }
            public string fw_version { get; set; }
            public string icon_filename { get; set; }
            public List<List<int>> icon_resolutions { get; set; }
            public string product_line { get; set; }
            public string product_model { get; set; }
            public UnifiDeviceInfoFromUcore unifi_device_info_from_ucore { get; set; }
            public int? os_class { get; set; }
            public int? priority { get; set; }
        }

        public class Meta
        {
            public string rc { get; set; }
        }

        public class Root
        {
            public List<Datum> data { get; set; }
            public Meta meta { get; set; }
        }


    }
}
