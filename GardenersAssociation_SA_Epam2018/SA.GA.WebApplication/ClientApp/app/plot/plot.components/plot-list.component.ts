import { Component, OnInit } from '@angular/core';
import { DataServicePlot } from '../../data-service/data.service.plot';
import { Plot } from '../../models/plot';

@Component({
    templateUrl: '../plot.template/plot-list.component.html'
})
export class PlotListComponent implements OnInit {

    plots: Plot[];
    constructor(private dataService: DataServicePlot) { }

    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getPlots().subscribe((data: Plot[]) => this.plots = data);
    }
    delete(id: number) {
        this.dataService.deletePlot(id).subscribe(data => this.load());
    }
}