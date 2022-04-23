import { Component, OnInit, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { interval } from 'rxjs';

@Component({
  selector: 'app-network-recommendation',
  templateUrl: './network-recommendation.component.html',
  styleUrls: ['./network-recommendation.component.css']
})


export class NetworkRecommendationComponent implements OnInit {
  headers: string[] = ['Hostname', 'Now', 'Real', 'IP', 'Signal', 'Advanced'];
  public data: RecommendationData[]

  public currentSelect: string;
  private paginator: MatPaginator;
  dataSource = new MatTableDataSource<TableData>();


  @ViewChild(MatPaginator, { static: false }) set matPaginator(mp: MatPaginator) {
    this.paginator = mp;
    this.setDataSourceAttributes();
  }
  constructor(private http: HttpClient) {

    this.http.get<RecommendationData[]>(location.origin + '/api/Recommendation/GetRecommendation/test').subscribe(result => {
      this.data = result;
      //this.updateTable();
    }, error => console.error(error));


  }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
  }

  change(hostname: string) {
    this.http.get<RecommendationData[]>(location.origin + '/api/Recommendation/GetRecommendation' + hostname).subscribe(result => {
      this.data = result;
      this.updateTable();
    }, error => console.error(error));
  }
  updateTable() {
    var count: number = 1;
    var tempData: TableData[] = new Array();
    this.data.forEach(
      function (value) {
        let myObj: TableData = { hostname: value.hostname, satisfaction_real: value.satisfaction_real, satisfaction_now: value.satisfaction_now, ip: value.ip, signal: value.signal, recommendationData: value };
        count = count + 1;
        tempData.push(myObj);
      });
    this.dataSource = new MatTableDataSource<TableData>(tempData);

  }

  setDataSourceAttributes() {
    this.dataSource.paginator = this.paginator;
  }
}


interface TableData {
  hostname: string;
  satisfaction_now: string;
  satisfaction_real: string;
  ip: string;
  signal: number;
  recommendationData: RecommendationData;
}

interface RecommendationData {
  hostname: string;
  satisfaction_now: string;
  satisfaction_real: string;
  ip: string;
  signal: number;
}
