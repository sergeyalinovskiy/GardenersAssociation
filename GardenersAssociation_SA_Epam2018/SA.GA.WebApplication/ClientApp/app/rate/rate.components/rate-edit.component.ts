import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { DataServiceRate } from '../../data-service/data.service.rate';
import { Rate } from '../../models/rate';

@Component({
    templateUrl: '../rate.template/rate-edit.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class RateEditComponent implements OnInit {

    id: number;
    rate: Rate;    // изменяемый объект
    loaded: boolean = false;

    constructor(private dataService: DataServiceRate, private router: Router, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        if (this.id)
            this.dataService.getRate(this.id)
                .subscribe((data: Rate) => {
                    this.rate = data;
                    if (this.rate != null) this.loaded = true;
                });
    }

    save() {
        this.dataService.updateRate(this.rate).subscribe(data => this.router.navigateByUrl("/"));
    }
}