import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { DataServicePlot } from '../../data-service/data.service.plot';
import { Plot } from '../../models/plot';

@Component({
    templateUrl: '../plot.template/plot-edit.component.html'
})
export class PlotEditComponent implements OnInit {

    id: number;
    plot: Plot;    // изменяемый объект
    loaded: boolean = false;

    constructor(private dataService: DataServicePlot, private router: Router, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        if (this.id)
            this.dataService.getPlot(this.id)
                .subscribe((data: Plot) => {
                    this.plot = data;
                    if (this.plot != null) this.loaded = true;
                });
    }

    save() {
        this.dataService.updatePlot(this.plot).subscribe(data => this.router.navigateByUrl("/"));
    }
}