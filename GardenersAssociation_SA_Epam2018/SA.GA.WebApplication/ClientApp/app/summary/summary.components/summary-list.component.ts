import { Component, OnInit } from '@angular/core';
import { DataServiceSummary } from '../../data-service/data.service.summary';
import { Summary } from '../../models/summary';

@Component({
    templateUrl: '../summary.template/summary-list.component.html'
})
export class SummaryListComponent implements OnInit {

    summarys: Summary[];
    constructor(private dataService: DataServiceSummary) { }

    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getSummary().subscribe((data: Summary[]) => this.summarys = data);
    }
}