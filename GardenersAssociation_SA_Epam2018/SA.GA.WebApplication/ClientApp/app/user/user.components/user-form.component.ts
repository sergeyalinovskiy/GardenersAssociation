﻿import { Component, Input } from '@angular/core';
import { User } from '../../models/user';
@Component({
    selector: "user-form",
    templateUrl: '../user.template/user-form.component.html'
})
export class UserFormComponent {
    @Input() user: User;
}