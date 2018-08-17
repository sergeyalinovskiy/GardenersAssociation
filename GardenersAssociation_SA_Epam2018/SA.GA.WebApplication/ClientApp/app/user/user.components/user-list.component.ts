import { Component, OnInit } from '@angular/core';
import { DataServiceUser } from '../../data-service/data.service.user';
import { User } from '../../models/user';

@Component({
    templateUrl: '../user.template/user-list.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class UserListComponent implements OnInit {

    users: User[];
    constructor(private dataService: DataServiceUser) { }

    ngOnInit() {
        this.load();
    }
    load() {
        this.dataService.getUsers().subscribe((data: User[]) => this.users = data);
    }
    delete(id: number) {
        this.dataService.deleteUser(id).subscribe(data => this.load());
    }
}