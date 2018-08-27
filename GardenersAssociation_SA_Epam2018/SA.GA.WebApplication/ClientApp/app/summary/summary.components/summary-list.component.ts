import { Component, OnInit } from '@angular/core';
import { DataServiceSummary } from '../../data-service/data.service.summary';
import { Summary } from '../../models/summary';

@Component({
    templateUrl: '../summary.template/summary-list.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class SummaryListComponent implements OnInit {

    summarys: Summary[];
    summary: Summary;
    constructor(private dataService: DataServiceSummary) { }

    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getSummary().subscribe((data: Summary[]) => this.summarys = data);
    }
}