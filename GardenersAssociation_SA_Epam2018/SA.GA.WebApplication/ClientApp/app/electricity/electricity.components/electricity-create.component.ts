import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataServiceElectricity } from '../../data-service/data.service.electricity';
import { Electricity } from '../../models/electricity';

@Component({
    templateUrl: '../electricity.template/electricity-create.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class ElectricityCreateComponent {

    electricity: Electricity = new Electricity();    // добавляемый объект
    constructor(private dataService: DataServiceElectricity, private router: Router) { }
    save() {
        this.dataService.createElectricity(this.electricity).subscribe(data =>
            this.router.navigateByUrl("/"));
    }
}