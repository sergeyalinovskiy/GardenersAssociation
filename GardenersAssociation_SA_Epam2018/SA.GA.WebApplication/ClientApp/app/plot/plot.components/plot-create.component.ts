import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataServicePlot } from '../../data-service/data.service.plot';
import { Plot } from '../../models/plot';

@Component({
    templateUrl: '../plot.template/plot-create.component.html'
})
export class PlotCreateComponent {

    plot: Plot = new Plot();    // добавляемый объект
    constructor(private dataService: DataServicePlot, private router: Router) { }
    save() {
        this.dataService.createPlot(this.plot).subscribe(data =>
            this.router.navigateByUrl("/"));
    }
}