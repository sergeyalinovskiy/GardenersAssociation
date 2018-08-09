import { Component, Input } from '@angular/core';
import { Electricity } from '../../models/electricity';
@Component({
    selector: "electricity-form",
    templateUrl: '../electricity.template/electricity-form.component.html'
})
export class ElectricityFormComponent {
    @Input() electricity: Electricity;
}