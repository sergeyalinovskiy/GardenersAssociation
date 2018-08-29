import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataServiceUser } from '../../data-service/data.service.user';
import { User } from '../../models/user';

@Component({
    templateUrl: '../user.template/user-create.component.html',
    styleUrls: ['../../style/app.component.css']
})
export class UserCreateComponent {

    user: User = new User();    // добавляемый объект
    constructor(private dataService: DataServiceUser, private router: Router) { }
    save() {
        this.dataService.createUser(this.user).subscribe((data) =>

            this.router.navigateByUrl("/"),

            (error) => {

                var resultAddress = error.error.Address[0];
                var resultPhone = error.error.Phone[0];
                var resultFirstName = error.error.FirstName[0];
                var resultLastName = error.error.LastName[0];
                var resultMiddleName = error.error.MiddleName[0];
                var resultAdditionalInformation = error.error.AdditionalInformation[0];

                this.user.Address = resultAddress;
                this.user.Phone = resultPhone;
                this.user.AdditionalInformation = resultAdditionalInformation;
                this.user.FirstName = resultFirstName;
                this.user.LastName = resultLastName;
                this.user.MiddleName = resultMiddleName;

                console.log(this.user);

            }

        );
    }
}