import { Component, OnInit } from '@angular/core';
import { DataServicePlot } from '../../data-service/data.service.plot';
import { Plot } from '../../models/plot';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    templateUrl: '../plot.template/plot-user.component.html'
})
export class PlotUserComponent implements OnInit {

    id: number;
    plots: Plot[];
    constructor(private dataService: DataServicePlot, private router: Router, activeRoute: ActivatedRoute)
    {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getUserPlots(this.id).subscribe((data: Plot[]) => this.plots = data);
    }
    delete(id: number) {
        this.dataService.deletePlot(id).subscribe(data => this.load());
    }
}