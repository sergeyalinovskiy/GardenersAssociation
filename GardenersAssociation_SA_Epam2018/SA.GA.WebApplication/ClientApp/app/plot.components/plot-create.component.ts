import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../data.service';
import { Plot } from '../models/plot';

@Component({
    templateUrl: '../plot.template/plot-create.component.html'
})
export class PlotCreateComponent {

    plot: Plot = new Plot();    // добавляемый объект
    constructor(private dataService: DataService, private router: Router) { }
    save() {
        this.dataService.createUser(this.plot).subscribe(data =>
            this.router.navigateByUrl("/"));
    }
}