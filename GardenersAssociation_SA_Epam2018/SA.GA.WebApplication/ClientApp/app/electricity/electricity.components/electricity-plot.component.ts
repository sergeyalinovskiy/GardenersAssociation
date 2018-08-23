import { Component, OnInit } from '@angular/core';
import { DataServiceElectricity } from '../../data-service/data.service.electricity';
import { Electricity } from '../../models/electricity';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    templateUrl: '../electricity.template/electricity-plot.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class ElectricityPlotComponent implements OnInit {

    id: number;
    electricitys: Electricity[];
    constructor(private dataService: DataServiceElectricity, private router: Router, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }
    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getPlotElectricity(this.id).subscribe((data: Electricity[]) => this.electricitys = data);
    }
    delete(id: number) {
        this.dataService.deleteElectricity(id).subscribe(data => this.load());
    }
}