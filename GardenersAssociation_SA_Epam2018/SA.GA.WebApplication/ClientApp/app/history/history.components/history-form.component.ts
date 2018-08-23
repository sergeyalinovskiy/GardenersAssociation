import { Component, Input } from '@angular/core';
import { History } from '../../models/history';
@Component({
    selector: "history-form",
    templateUrl: '../history.template/history-form.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class HistoryFormComponent {
    @Input() history: History;
}