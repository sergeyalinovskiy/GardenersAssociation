import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataServiceSummary } from '../../data-service/data.service.summary';
import { Summary } from '../../models/summary';

@Component({
    templateUrl: '../summary.template/summary-create.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class SummaryCreateComponent {

    summary: Summary = new Summary();    // добавляемый объект
    constructor(private dataService: DataServiceSummary, private router: Router) { }
    save() {
        this.dataService.createSummary(this.summary).subscribe(data =>
            this.router.navigateByUrl("/"));
    }
}