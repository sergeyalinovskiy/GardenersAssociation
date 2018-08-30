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

//    export class DropdownMenu {
//    dropdownMenu: HTMLSelectElement;
//    options: HTMLOptionsCollection;

//    constructor(dropdown: HTMLSelectElement) {
//        this.dropdownMenu = dropdown;
//        this.options = dropdown.options;
//    }

//    OnChange() {
//        alert(this.options[this.options.selectedIndex].value);
//        document.location.href = this.options[this.options.selectedIndex].value;
//    }
//}


//window.onload = () => {
//    let select1: HTMLSelectElement = <HTMLSelectElement>document.getElementById("Select1");
//    let ddm1: DropdownMenu = new DropdownMenu(select1);
//    select1.onchange = () => {
//        ddm1.OnChange();
//    }
//}

//class DropdownMenuButton {
//    dropdownMenuButton: HTMLSelectElement;
//    options2: HTMLOptionsCollection;

//    constructor(dropdown: HTMLSelectElement) {
//        this.dropdownMenuButton = dropdown;
//        this.options2 = dropdown.options;
//    }


//    OnClick() {
//        alert(this.options2[this.options2.selectedIndex].value);
//        if (this.options2.selectedIndex >= 1)
//            document.location.href = this.options2[this.options2.selectedIndex].value;
//    }

//}
//window.onload = () => {
//    let select2: HTMLSelectElement = <HTMLSelectElement>document.getElementById("Select2");
//    let btngo: HTMLButtonElement = <HTMLButtonElement>document.getElementById("btnGo");
//    let ddm2: DropdownMenuButton = new DropdownMenuButton(select2);
//    btngo.onclick = () => {
//        ddm2.OnClick();
//    }

//}
