import { Component, Input } from '@angular/core';
import { Plot } from '../../models/plot';
@Component({
    selector: "plot-form",
    templateUrl: '../plot.template/plot-form.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class PlotFormComponent {
    @Input() plot: Plot;
}