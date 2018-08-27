import { Component, OnInit } from '@angular/core';
import { DataServiceRate } from '../../data-service/data.service.rate';
import { Rate } from '../../models/rate';

@Component({
    templateUrl: '../rate.template/rate-list.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class RateListComponent implements OnInit {

    rates: Rate[];
    constructor(private dataService: DataServiceRate) { }

    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getRates().subscribe((data: Rate[]) => this.rates = data);
    }
    delete(id: number) {
        this.dataService.deleteRate(id).subscribe(data => this.load());
    }
}