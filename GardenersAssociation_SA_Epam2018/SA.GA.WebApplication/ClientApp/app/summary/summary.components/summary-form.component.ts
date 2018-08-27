import { Component, Input } from '@angular/core';
import { Summary } from '../../models/summary';
@Component({
    selector: "summary-form",
    templateUrl: '../summary.template/summary-form.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class SummaryFormComponent {
    @Input() summary: Summary;
}

