import { Component, OnInit } from '@angular/core';
import { DataService } from '../../data.service';
import { History } from '../../models/history';

@Component({
    templateUrl: '../history.template/history-list.component.html'
})
export class HistoryListComponent implements OnInit {

    historys: History[];
    constructor(private dataService: DataService) { }

    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getHistorys().subscribe((data: History[]) => this.historys = data);
    }
    delete(id: number) {
        this.dataService.deleteHistory(id).subscribe(data => this.load());
    }
}