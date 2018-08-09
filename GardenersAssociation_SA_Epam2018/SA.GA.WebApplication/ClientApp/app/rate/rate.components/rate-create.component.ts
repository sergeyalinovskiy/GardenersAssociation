import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../../data.service';
import { Rate } from '../../models/rate';

@Component({
    templateUrl: '../rate.template/rate-create.component.html'
})
export class RateCreateComponent {

    rate: Rate = new Rate();    // добавляемый объект
    constructor(private dataService: DataService, private router: Router) { }
    save() {
        this.dataService.createRate(this.rate).subscribe(data =>
            this.router.navigateByUrl("/"));
    }
}