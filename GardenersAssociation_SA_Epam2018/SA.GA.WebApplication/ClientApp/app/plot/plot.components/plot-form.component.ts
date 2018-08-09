import { Component, Input } from '@angular/core';
import { Plot } from '../../models/plot';
@Component({
    selector: "plot-form",
    templateUrl: '../plot.template/plot-form.component.html'
})
export class PlotFormComponent {
    @Input() plot: Plot;
}