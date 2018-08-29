import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { DataServiceElectricity } from '../../data-service/data.service.electricity';
import { Electricity } from '../../models/electricity';

@Component({
    templateUrl: '../electricity.template/electricity-edit.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class ElectricityEditComponent implements OnInit {

    id: number;
    electricity: Electricity;    // изменяемый объект
    loaded: boolean = false;

    constructor(private dataService: DataServiceElectricity, private router: Router, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        if (this.id)
            this.dataService.getElectricity(this.id)
                .subscribe((data: Electricity) => {
                    this.electricity = data;
                    if (this.electricity != null) this.loaded = true;
                });
    }

    save() {
        this.dataService.updateElectricity(this.electricity).subscribe(data => this.router.navigateByUrl("/"));
    }
    
}