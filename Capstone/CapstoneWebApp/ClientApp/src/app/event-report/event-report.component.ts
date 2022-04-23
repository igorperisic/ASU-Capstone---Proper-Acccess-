import { Component, OnInit, ViewChild} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-event-report',
  templateUrl: './event-report.component.html',
  styleUrls: ['./event-report.component.css']
})
export class EventReportComponent implements OnInit {
  headers: string[] = ['Position', 'Time', 'Message', 'Advanced'];
  public data: EventData[];
  public advancedData: EventData;
  public advancedDataId: number;
  public currentSelect: string;
  private paginator: MatPaginator;
  dataSource = new MatTableDataSource<TableData>();

  @ViewChild(MatPaginator, { static: false }) set matPaginator(mp: MatPaginator) {
    this.paginator = mp;
    this.setDataSourceAttributes();
  }
  //@ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
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

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
  }

  change(key: string) {
    this.currentSelect = key;
    this.http.get<EventData[]>(location.origin + '/api/Events/GetEvent/' + key).subscribe(result => {
      this.data = result;
      this.updateTable();
    }, error => console.error(error));
  }

  updateTable() {
    var count: number = 1;
    var tempData: TableData[] = new Array();
    this.data.forEach(
      function (value) {
        let myObj:TableData = { id: count, time: value.datetime, message: value.msg, eventData: value };
        count = count + 1;
        tempData.push(myObj);
      });
    this.dataSource = new MatTableDataSource<TableData>(tempData);
  }
  showAdvancedTable(eventData: EventData,id: number) {
    this.advancedDataId = id;
    this.advancedData = eventData;
  }
  setDataSourceAttributes() {
    this.dataSource.paginator = this.paginator;
  }
}

interface TableData {
  id: number;
  time: string;
  message: string;
  eventData: EventData;
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
