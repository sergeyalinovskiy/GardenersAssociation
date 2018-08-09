import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../../data.service';
import { History } from '../../models/history';

@Component({
    templateUrl: '../history.template/history-create.component.html'
})
export class HistoryCreateComponent {

    history: History = new History();    // добавляемый объект
    constructor(private dataService: DataService, private router: Router) { }
    save() {
        this.dataService.createUser(this.history).subscribe(data =>
            this.router.navigateByUrl("/"));
    }
}