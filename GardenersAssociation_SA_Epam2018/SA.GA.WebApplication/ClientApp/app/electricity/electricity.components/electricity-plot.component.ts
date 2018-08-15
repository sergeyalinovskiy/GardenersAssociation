import { Component, OnInit } from '@angular/core';
import { DataService } from '../../data.service';
import { Electricity } from '../../models/electricity';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    templateUrl: '../electricity.template/electricity-list.component.html'
})
export class ElectricityPlotComponent implements OnInit {

    id: number;
    electricitys: Electricity[];
    constructor(private dataService: DataService, private router: Router, activeRoute: ActivatedRoute) {
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