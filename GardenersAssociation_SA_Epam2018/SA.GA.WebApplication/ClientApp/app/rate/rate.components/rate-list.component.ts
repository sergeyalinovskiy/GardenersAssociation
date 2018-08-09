import { Component, OnInit } from '@angular/core';
import { DataService } from '../../data.service';
import { Rate } from '../../models/rate';

@Component({
    templateUrl: '../rate.template/rate-list.component.html'
})
export class RateListComponent implements OnInit {

    rates: Rate[];
    constructor(private dataService: DataService) { }

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