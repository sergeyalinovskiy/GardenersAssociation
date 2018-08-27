import { Component, Input } from '@angular/core';
import { Electricity } from '../../models/electricity';
@Component({
    selector: "electricity-form",
    templateUrl: '../electricity.template/electricity-form.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class ElectricityFormComponent {
    @Input() electricity: Electricity;
}