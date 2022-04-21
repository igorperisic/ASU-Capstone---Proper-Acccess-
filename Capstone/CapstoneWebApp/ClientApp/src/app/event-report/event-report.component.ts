import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-event-report',
  templateUrl: './event-report.component.html',
  styleUrls: ['./event-report.component.css']
})
export class EventReportComponent implements OnInit {

  public data: EventData[];
  public currentSelect: string;
  events = [
    { id: 1, key: "EVT_AD_BackupCreated" },
    { id: 2, key: "EVT_AP_AutoReadopted" },
    { id: 3, key: "EVT_AP_Upgraded" },
    { id: 4, key: "EVT_GW_WANTransition" },
    { id: 5, key: "EVT_LU_Connected" },
    { id: 6, key: "EVT_SW_AutoReadopted" },
    { id: 7, key: "EVT_SW_Lost_Contact" },
    { id: 8, key: "EVT_SW_Upgraded" },
    { id: 9, key: "EVT_WU_Connected" },
    { id: 10, key: "EVT_WU_Disconnected" },
    { id: 11, key: "EVT_WU_RoamRadio" }
  ];

  constructor(private http: HttpClient) {
  }
  //constructor(http: HttpClient) {
  //  http.get<EventData[]>(location.origin + '/api/Events/GetEvent/EVT_WU_Disconnected').subscribe(result => {
  //    console.log(result)
  //    this.data = result;
  //  }, error => console.error(error));
  //}

  ngOnInit() {
  }

  change(key: string) {
    this.currentSelect = key;
    this.http.get<EventData[]>(location.origin + '/api/Events/GetEvent/' + key).subscribe(result => {
      console.log(result)
      this.data = result;
    }, error => console.error(error));
  }

}

interface EventData {
  _id: string;
  ap: string;
  ap_displayName: string;
  site_id: string;
  ap_model: string;
  ap_key: string;
  bytes: number;
  datetime: string;
  duration: number;
  hostkey: string;
  key: string;
  msg: string;
  ssid: string;
  subsystem: string;
  time: object;
  user: string;
  channel: string;
  radio: string;
  channel_from: string;
  channel_t: string;
}


interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
