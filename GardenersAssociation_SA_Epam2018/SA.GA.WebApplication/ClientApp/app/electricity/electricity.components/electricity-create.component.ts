import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../../data.service';
import { Electricity } from '../../models/electricity';

@Component({
    templateUrl: '../electricity.template/electricity-create.component.html'
})
export class ElectricityCreateComponent {

    electricity: Electricity = new Electricity();    // добавляемый объект
    constructor(private dataService: DataService, private router: Router) { }
    save() {
        this.dataService.createElectricity(this.electricity).subscribe(data =>
            this.router.navigateByUrl("/"));
    }
}