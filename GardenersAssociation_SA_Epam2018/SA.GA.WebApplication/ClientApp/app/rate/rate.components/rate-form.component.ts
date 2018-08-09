import { Component, Input } from '@angular/core';
import { Rate } from '../../models/rate';
@Component({
    selector: "rate-form",
    templateUrl: '../rate.template/rate-form.component.html'
})
export class RateFormComponent {
    @Input() rate: Rate;
}