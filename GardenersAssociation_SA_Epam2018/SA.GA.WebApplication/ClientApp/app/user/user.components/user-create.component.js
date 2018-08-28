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
            _this.router.navigateByUrl("/");
            console.log(data);
        }, function (error) { return console.log(error); });
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