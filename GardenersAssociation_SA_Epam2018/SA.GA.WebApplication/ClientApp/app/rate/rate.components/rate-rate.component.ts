import { Component, OnInit } from '@angular/core';
import { DataServiceRate } from '../../data-service/data.service.rate';
import { Rate } from '../../models/rate';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    templateUrl: '../rate.template/rate-rate.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class RateComponent implements OnInit {

    id: number;
    rates: Rate[];
    constructor(private dataService: DataServiceRate,private router: Router, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getRateInfo(this.id).subscribe((data: Rate[]) => this.rates = data);
    }
    delete(id: number) {
        this.dataService.deleteRate(id).subscribe(data => this.load());
    }
}