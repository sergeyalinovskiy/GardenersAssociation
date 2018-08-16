import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { DataServiceHistory } from '../../data-service/data.service.history';
import { History } from '../../models/history';

@Component({
    templateUrl: '../history.template/history-edit.component.html'
})
export class HistoryEditComponent implements OnInit {

    id: number;
    history: History;    // изменяемый объект
    loaded: boolean = false;

    constructor(private dataService: DataServiceHistory, private router: Router, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        if (this.id)
            this.dataService.getHistory(this.id)
                .subscribe((data: History) => {
                    this.history = data;
                    if (this.history != null) this.loaded = true;
                });
    }

    save() {
        this.dataService.updateHistory(this.history).subscribe(data => this.router.navigateByUrl("/"));
    }
}