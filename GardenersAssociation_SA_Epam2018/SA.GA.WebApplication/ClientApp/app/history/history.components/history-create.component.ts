import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataServiceHistory } from '../../data-service/data.service.history';
import { History } from '../../models/history';

@Component({
    templateUrl: '../history.template/history-create.component.html'
})
export class HistoryCreateComponent {

    history: History = new History();    // добавляемый объект
    constructor(private dataService: DataServiceHistory, private router: Router) { }
    save() {
        this.dataService.createHistory(this.history).subscribe(data =>
            this.router.navigateByUrl("/"));
    }
}