import { Component, OnInit } from '@angular/core';
import { DataService } from '../../data.service';
import { Electricity } from '../../models/electricity';

@Component({
    templateUrl: '../electricity.template/electricity-list.component.html'
})
export class ElectricityListComponent implements OnInit {

    electricitys: Electricity[];
    constructor(private dataService: DataService) { }

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