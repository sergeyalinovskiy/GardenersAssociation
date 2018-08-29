var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataServiceUser } from '../../data-service/data.service.user';
import { User } from '../../models/user';
var UserCreateComponent = /** @class */ (function () {
    function UserCreateComponent(dataService, router) {
        this.dataService = dataService;
        this.router = router;
        this.user = new User(); // добавляемый объект
    }
    UserCreateComponent.prototype.save = function () {
        var _this = this;
        this.dataService.createUser(this.user).subscribe(function (data) {
            return _this.router.navigateByUrl("/");
        }, function (error) {
            var resultAddress = error.error.Address[0];
            var resultPhone = error.error.Phone[0];
            var resultFirstName = error.error.FirstName[0];
            var resultLastName = error.error.LastName[0];
            var resultMiddleName = error.error.MiddleName[0];
            var resultAdditionalInformation = error.error.AdditionalInformation[0];
            _this.user.Address = resultAddress;
            _this.user.Phone = resultPhone;
            _this.user.AdditionalInformation = resultAdditionalInformation;
            _this.user.FirstName = resultFirstName;
            _this.user.LastName = resultLastName;
            _this.user.MiddleName = resultMiddleName;
            console.log(_this.user);
        });
    };
    UserCreateComponent = __decorate([
        Component({
            templateUrl: '../user.template/user-create.component.html',
            styleUrls: ['../../style/app.component.css']
        }),
        __metadata("design:paramtypes", [DataServiceUser, Router])
    ], UserCreateComponent);
    return UserCreateComponent;
}());
export { UserCreateComponent };
//# sourceMappingURL=user-create.component.js.map