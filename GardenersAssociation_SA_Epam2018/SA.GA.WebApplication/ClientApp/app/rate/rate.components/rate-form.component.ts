import { Component, Input } from '@angular/core';
import { Rate } from '../../models/rate';
@Component({
    selector: "rate-form",
    templateUrl: '../rate.template/rate-form.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class RateFormComponent {
    @Input() rate: Rate;
}