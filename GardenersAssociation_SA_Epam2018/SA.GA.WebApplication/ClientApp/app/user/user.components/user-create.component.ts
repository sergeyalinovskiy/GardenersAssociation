import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataServiceUser } from '../../data-service/data.service.user';
import { User } from '../../models/user';

@Component({
    templateUrl: '../user.template/user-create.component.html'
})
export class UserCreateComponent {

    user: User = new User();    // добавляемый объект
    constructor(private dataService: DataServiceUser, private router: Router) { }
    save() {
        this.dataService.createUser(this.user).subscribe(data =>
            this.router.navigateByUrl("/"));
    }
}