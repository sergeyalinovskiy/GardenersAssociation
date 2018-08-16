import { Component, OnInit } from '@angular/core';
import { DataServiceElectricity } from '../../data-service/data.service.electricity';
import { Electricity } from '../../models/electricity';

@Component({
    templateUrl: '../electricity.template/electricity-list.component.html'
})
export class ElectricityListComponent implements OnInit {

    electricitys: Electricity[];
    constructor(private dataService: DataServiceElectricity) { }

    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getElectricitys().subscribe((data: Electricity[]) => this.electricitys = data);
    }
    delete(id: number) {
        this.dataService.deleteElectricity(id).subscribe(data => this.load());
    }
}